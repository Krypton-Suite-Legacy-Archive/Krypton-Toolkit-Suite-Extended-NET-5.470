using KryptonFileCopier.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace KryptonFileCopier.Classes
{
    //http://www.pinvoke.net/default.aspx/kernel32.CopyFileEx
    /// <summary>
    /// Copies a list of files or a directory tree to a destination
    /// 
    /// Support for GUI is implemented by the ICopyFilesDiag interface
    /// and passed to the class in the copy() method.
    /// </summary>
    public class CopyFiles
    {
        #region Variables
        private bool _cancel = false;

        private Int32 _totalFiles = 0, _totalFilesCopied = 0;

        private List<string> _files = new List<string>(), _newFileNames = new List<string>();

        private List<ST_CopyFileDetails> _filesCopied = new List<CopyFiles.ST_CopyFileDetails>();

        private string _destinationDir = "", _sourceDir = "", _currentFileName;

        private IAsyncResult CopyResult;

        private DEL_CopyFiles _delCopy;

        private ICopyFilesDialog _digWindow;
        #endregion

        #region Structs
        public struct ST_CopyFileDetails
        {
            string OriginalURI, NewURI;

            public ST_CopyFileDetails(string fromURI, string toURI) { OriginalURI = fromURI; NewURI = toURI; }
        }
        #endregion

        #region Enumerations
        // These Enums are used for the windows CopyFileEx function
        [Flags]
        private enum CopyFileFlags : uint
        {
            COPY_FILE_FAIL_IF_EXISTS = 0x00000001,
            COPY_FILE_RESTARTABLE = 0x00000002,
            COPY_FILE_OPEN_SOURCE_FOR_WRITE = 0x00000004,
            COPY_FILE_ALLOW_DECRYPTED_DESTINATION = 0x00000008
        }

        private enum CopyProgressResult : uint
        {
            PROGRESS_CONTINUE = 0,
            PROGRESS_CANCEL = 1,
            PROGRESS_STOP = 2,
            PROGRESS_QUIET = 3
        }

        private enum CopyProgressCallbackReason : uint
        {
            CALLBACK_CHUNK_FINISHED = 0x00000000,
            CALLBACK_STREAM_SWITCH = 0x00000001
        }
        #endregion

        #region Events
        public event DEL_copyComplete EV_copyComplete;

        public event DEL_copyCanceled EV_copyCanceled;
        #endregion

        #region Delegates
        private delegate CopyProgressResult CopyProgressRoutine(Int64 TotalFileSize, Int64 TotalBytesTransferred, Int64 StreamSize, Int64 StreamBytesTransferred, UInt32 dwStreamNumber, CopyProgressCallbackReason dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

        private delegate CopyProgressResult DEL_CopyProgressHandler(Int64 total, Int64 transferred, Int64 streamSize, Int64 StreamByteTrans, UInt32 dwStreamNumber, CopyProgressCallbackReason reason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

        private delegate void DEL_CopyFiles();

        private delegate void DEL_ShowDiag(ICopyFilesDialog diag);

        private delegate void DEL_HideDiag(ICopyFilesDialog diag);

        private delegate void DEL_CopyfilesCallback(IAsyncResult r);

        public delegate void DEL_cancelCopy();

        public delegate void DEL_copyComplete();

        public delegate void DEL_copyCanceled(List<ST_CopyFileDetails> filescopied);
        #endregion

        #region Constructors
        public CopyFiles(string source, string destination)
        {
            _sourceDir = source;

            _destinationDir = destination;
        }

        public CopyFiles(List<string> sourceFiles, string destination)
        {
            /**
             * The sourceDir does not need to be set if the user is supplying a
             * list of files.
             *
             * Example :
             *     Source Destination
             *     c:\Temp1\Test.txt c:\DestFolder\Test.txt
             * c:\temp2\temp1\test1.txt c:\DestFolder\Test1.txt
             * c:\temp3\blah\Test.txt c:\DestFolder\Test(2).txt
             *
             *
             * This is worked out in CheckFilenames()
             */

            _files = sourceFiles;

            _totalFiles = _files.Count;

            _destinationDir = destination;
        }
        #endregion

        #region Kernel32 Calls
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern unsafe bool CopyFileEx(string lpExistingFileName, string lpNewFileName, CopyProgressRoutine lpProgressRoutine, IntPtr lpData, Boolean* pbCancel, CopyFileFlags dwCopyFlags);
        #endregion

        #region Methods
        private List<string> GetFiles(string sourceDirectory)
        {
            List<string> _foundFiles = new List<string>();

            string[] _fileEntries, _subDirectoryEntries;

            _fileEntries = Directory.GetFiles(sourceDirectory);

            foreach (string fileName in _fileEntries)
            {
                _foundFiles.Add(fileName);
            }

            _subDirectoryEntries = Directory.GetDirectories(sourceDirectory);

            foreach (string subDirectories in _subDirectoryEntries)
            {
                if ((File.GetAttributes(subDirectories) & FileAttributes.ReparsePoint) != FileAttributes.ReparsePoint)
                {
                    _foundFiles.AddRange(GetFiles(subDirectories));
                }
            }

            return _foundFiles;
        }

        private CopyProgressResult CopyProgressHandler(Int64 total, Int64 transferred, Int64 streamSize, Int64 StreamByteTrans, UInt32 dwStreamNumber, CopyProgressCallbackReason reason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData)
        {
            if (_digWindow != null)
            {
                if (_digWindow.SynchronizationObject != null && _digWindow.SynchronizationObject.InvokeRequired)
                {
                    _digWindow.SynchronizationObject.Invoke(new CopyProgressRoutine(CopyProgressHandler), new Object[] { total, transferred, streamSize, StreamByteTrans, dwStreamNumber, reason, hSourceFile, hDestinationFile, lpData });
                }
                else
                {
                    _digWindow.Update(_totalFiles, _totalFilesCopied, total, transferred, _currentFileName);
                }
            }

            return CopyProgressResult.PROGRESS_CONTINUE;
        }

        private void ShowDialog(ICopyFilesDialog dialog)
        {
            if (_digWindow != null)
            {
                if (_digWindow.SynchronizationObject != null && _digWindow.SynchronizationObject.InvokeRequired)
                {
                    _digWindow.SynchronizationObject.Invoke(new DEL_ShowDiag(ShowDialog), new Object[] { dialog });
                }
                else
                {
                    dialog.Show();
                }
            }
        }

        private void HideDialog(ICopyFilesDialog dialog)
        {
            if (_digWindow != null)
            {
                if (_digWindow.SynchronizationObject != null && _digWindow.SynchronizationObject.InvokeRequired)
                {
                    _digWindow.SynchronizationObject.Invoke(new DEL_HideDiag(HideDialog), new Object[] { dialog });
                }
                else
                {
                    dialog.Hide();

                    _cancel = false;
                }
            }
        }

        private void CancelCopy() { _cancel = true; OnCopyCanceled(); }

        private void Copyfiles()
        {
            Int32 index = 0;

            if (_digWindow != null)
            {
                _digWindow.EN_cancelCopy += CancelCopy;

                ShowDialog(_digWindow);
            }

            if (_sourceDir != "")
            {
                _files = GetFiles(_sourceDir);
            }
            else
            {
                CheckFileNames();
            }

            _totalFiles = _files.Count;

            foreach (string fileName in _files.ToArray())
            {
                String[] _filePath;

                string _temporyFilePath, _temporyDirectoryPath = "";

                if (_sourceDir != "")
                {
                    _temporyFilePath = fileName;

                    _temporyFilePath = _temporyFilePath.Replace(_sourceDir, "");

                    _temporyFilePath = Path.Combine(_destinationDir, _temporyFilePath);
                }
                else
                {
                    _temporyFilePath = Path.Combine(_destinationDir, _newFileNames[index]);
                }

                _filePath = _temporyFilePath.Split('\\');

                for (int i = 0; i < _filePath.Length - 1; i++)
                {
                    _temporyDirectoryPath += _filePath[i] + "\\";
                }

                if (!Directory.Exists(_temporyDirectoryPath))
                {
                    Directory.CreateDirectory(_temporyDirectoryPath);
                }

                if (_cancel)
                {
                    break;
                }

                _currentFileName = fileName;

                unsafe
                {
                    fixed (Boolean* cancelP = &_cancel)
                    {
                        CopyFileEx(fileName, _temporyFilePath, new CopyProgressRoutine(CopyProgressHandler), IntPtr.Zero, cancelP, 0);
                    }
                }

                _filesCopied.Add(new ST_CopyFileDetails(fileName, _temporyFilePath));

                _totalFilesCopied += 1;

                index += 1;
            }
        }

        private void OnCopyComplete()
        {
            if (EV_copyComplete != null)
            {
                EV_copyComplete();
            }
        }

        private void OnCopyCanceled()
        {
            if (EV_copyCanceled != null)
            {
                EV_copyCanceled(_filesCopied);
            }
        }

        private void CheckFileNames()
        {
            // Variables
            String[] fileNames = new String[_files.Count];

            List<String> tempFileNameArr;

            Int32 index = 0, innerIndex = 0, filenameIndex = 0, filenameNumber = 0;

            //Load filenames into an array
            foreach (String tempFileName in _files)
            {
                fileNames[index] = Path.GetFileName(tempFileName);
                index += 1;
            }

            //Loop each filename in the array
            index = 0;
            foreach (String originalFilename in fileNames)
            {

                //See if this filename is repeated in the list
                innerIndex = 0;
                filenameNumber = 2;
                foreach (String dupeFilename in fileNames)
                {
                    //dont compair the same index!
                    if (innerIndex != index)
                    {

                        if (originalFilename == dupeFilename)
                        {
                            //insert the duplicate number into the new filename e.g (2) and clear
                            //the current name.
                            tempFileNameArr = new List<String>(fileNames[innerIndex].Split('.'));
                            tempFileNameArr.Insert(tempFileNameArr.Count - 1, "[*REMOVEME*] (" + filenameNumber + ")");
                            fileNames[innerIndex] = "";

                            //Rebuild the new filename
                            filenameIndex = 0;
                            foreach (String newFilename in tempFileNameArr)
                            {

                                //put a dot before the file extension
                                if (filenameIndex == tempFileNameArr.Count - 1)
                                { fileNames[innerIndex] += "."; }

                                //append the new filename
                                fileNames[innerIndex] += newFilename.Replace("[*REMOVEME*]", "");

                                //only add a . if its not the injected portion e.g (2)
                                if ((filenameIndex < tempFileNameArr.Count - 3 && newFilename.StartsWith("[*REMOVEME*]") == false))
                                { fileNames[innerIndex] += "."; }

                                filenameIndex += 1;
                            }

                            //Trim any trailing .'s
                            fileNames[innerIndex].TrimEnd(new Char[] { '.' });
                            filenameNumber += 1;
                        }
                    }
                    innerIndex += 1;
                }
                index += 1;

            }

            //Update the list of new filenames.
            _newFileNames = new List<String>(fileNames);

        }

        //Copy the files
        public void Copy()
        {
            Copyfiles();
        }

        public void CopyAsync(ICopyFilesDialog diag)
        {
            _digWindow = diag;

            if (_digWindow != null && _digWindow.SynchronizationObject == null)
            {
                throw new Exception("Dialog window sent with no SynchronizationObject");
            }

            _delCopy = new DEL_CopyFiles(Copyfiles);

            CopyResult = _delCopy.BeginInvoke(CopyfilesCallback, null);
        }

        // Async Callbacks
        private void CopyfilesCallback(IAsyncResult r)
        {
            //Kill off the thread as its finished.
            _delCopy.EndInvoke(CopyResult);

            HideDialog(_digWindow);

            OnCopyComplete();
        }
        #endregion
    }
}