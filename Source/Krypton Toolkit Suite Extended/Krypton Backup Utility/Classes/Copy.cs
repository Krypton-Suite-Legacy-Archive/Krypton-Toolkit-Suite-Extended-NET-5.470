using Common;
using KryptonBackupUtility.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KryptonBackupUtility.Classes
{
    public class Copy
    {
        #region Variables
        private BackgroundWorker _backgroundWorker;

        private Timer _timer;

        public static OperationType _currentOperation = OperationType.IDLE;

        public static Stopwatch _operationSW;

        public static Exception _operationException;

        public static bool _userCancel;

        public static int _totalFileCount;

        public static long _totalFilesSize;

        public static int _currentFileCount;

        public static long _cumulativeFileSize;

        public static int _totalDirectoryCount;
        #endregion

        #region Properties
        public bool IsBusy
        {
            get
            {
                if (BackgroundWorker == null)
                {
                    return false;
                }
                else
                {
                    return BackgroundWorker.IsBusy;
                }
            }
        }

        public BackgroundWorker BackgroundWorker
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get => _backgroundWorker;

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_backgroundWorker != null)
                {
                    _backgroundWorker = null;
                }

                _backgroundWorker = value;
            }
        }

        public Timer Timer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get => _timer;

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_timer != null)
                {
                    _timer = null;
                }

                _timer = value;
            }
        }
        #endregion

        #region Constructor
        public Copy()
        {

        }
        #endregion

        #region Methods
        /// <summary>Begins the operation.</summary>
        /// <param name="sourceDirectoryPath">The source directory path.</param>
        /// <param name="targetBaseDirectoryPath">The target base directory path.</param>
        /// <param name="parsingInstructions">The parsing instructions.</param>
        public void BeginOperation(string sourceDirectoryPath, string targetBaseDirectoryPath, DirectoryParsing parsingInstructions)
        {
            try
            {
                if (string.IsNullOrEmpty(sourceDirectoryPath) || string.IsNullOrEmpty(sourceDirectoryPath.Trim()))
                {
                    throw new ArgumentException("The directory path to copy from cannot be null or empty.");
                }
                else if (string.IsNullOrEmpty(targetBaseDirectoryPath) || string.IsNullOrEmpty(targetBaseDirectoryPath.Trim()))
                {
                    throw new ArgumentException("The directory path to copy to cannot be null or empty.");
                }
                else
                {
                    DirectoryInfo sourceDirectoryInfo = new DirectoryInfo(sourceDirectoryPath), targetDirectoryInfo = new DirectoryInfo(targetBaseDirectoryPath);

                    if (!sourceDirectoryInfo.Exists)
                    {
                        throw new DirectoryNotFoundException("The source directory path could not be located.");
                    }
                    else if (!targetDirectoryInfo.Exists)
                    {
                        throw new DirectoryNotFoundException("The target directory path could not be located.");
                    }
                    else
                    {
                        OperationCompleteEventArgs args = new OperationCompleteEventArgs();

                        args.Dispose();

                        _operationException = null;

                        _userCancel = false;

                        _totalDirectoryCount = 0;

                        _totalFileCount = 0;

                        _totalFilesSize = 0;

                        _currentFileCount = 0;

                        _cumulativeFileSize = 0;

                        BackgroundWorkerInstructions instructions = new BackgroundWorkerInstructions() { SourceDirectoryInfoList = new List<DirectoryInfo> { sourceDirectoryInfo }, TargetBaseDirectory = targetDirectoryInfo, ParsingType = parsingInstructions };

                        Timer = new Timer() { Interval = 500, Enabled = true };

                        _operationSW = new Stopwatch();

                        BackgroundWorker = new BackgroundWorker() { WorkerSupportsCancellation = true };

                        BackgroundWorker.RunWorkerAsync(instructions);
                    }
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }

        public void CancelOperation()
        {
            _userCancel = true;

            OnProgressChanged();
        }

        private List<string> GenerateSafeFolderList(string folder)
        {

            // -------------------------------------------
            // Based On A Function By John Wein As Posted:
            // 
            // http://social.msdn.microsoft.com/Forums/en-US/vbgeneral/thread/d6e64558-395b-4b48-8b64-0f5a7e3a7623
            // 
            // Thanks John!
            // -------------------------------------------

            List<string> retVal = new List<string>();

            Stack<string> Dirs = new Stack<string>();
            Dirs.Push(folder);

            while (Dirs.Count > 0)
            {
                if (_userCancel)
                    break;
                else
                {
                    string Dir = Dirs.Pop();

                    try
                    {
                        foreach (string D in Directory.GetDirectories(Dir))
                        {
                            // Do not include any that are either system or hidden

                            var dirInfo = new DirectoryInfo(D);
                            if ((dirInfo.Attributes & FileAttributes.Hidden) == 0 && (dirInfo.Attributes & FileAttributes.System) == 0)
                            {
                                if (!retVal.Contains(D))
                                    retVal.Add(D);
                            }

                            Dirs.Push(D);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (retVal.Contains(Dir))
                        {
                            int indexToRemove = 0;

                            for (int i = 0, loopTo = retVal.Count - 1; i <= loopTo; i++)
                            {
                                if ((retVal[i] ?? "") == (Dir ?? ""))
                                {
                                    indexToRemove = i;
                                    break;
                                }
                            }

                            retVal.RemoveAt(indexToRemove);
                        }
                        continue;
                    }
                }
            }

            return retVal;
        }
        #endregion

        #region Event Handlers
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (e.Argument != null)
                {
                    var instructions = (BackgroundWorkerInstructions)e.Argument;

                    if (instructions != null)
                    {
                        _operationSW.Start();

                        var fileInfoList = new List<FileInfo>();
                        var safeDirectoryPaths = new List<string>();

                        _currentOperation = OperationType.ENUMERATINGDIRECTORIES;

                        foreach (DirectoryInfo di in instructions.SourceDirectoryInfoList)
                        {
                            if (_userCancel)
                            {
                                BackgroundWorker.CancelAsync();
                            }
                            else
                            {
                                safeDirectoryPaths.Add(di.FullName);

                                if (instructions.ParsingType == (int)DirectoryParsing.INCLUDESUBDIRECTORIES)
                                {
                                    var list = GenerateSafeFolderList(di.FullName);

                                    if (list != null)
                                    {
                                        foreach (string dirPath in list)
                                        {
                                            safeDirectoryPaths.Add(dirPath);
                                        }
                                    }

                                    safeDirectoryPaths.Sort();
                                }
                            }
                        }

                        _totalDirectoryCount = safeDirectoryPaths.Count;
                        _currentOperation = OperationType.ENUMERATINGFILES;

                        foreach (string dirPath in safeDirectoryPaths)
                        {
                            if (_userCancel)
                            {
                                BackgroundWorker.CancelAsync();
                            }
                            else
                            {
                                string[] files = Directory.GetFiles(dirPath);

                                if (files != null && files.Length > 0)
                                {
                                    foreach (string filePath in files)
                                    {
                                        if (_userCancel)
                                            BackgroundWorker.CancelAsync();
                                        else
                                        {
                                            var fi = new FileInfo(filePath);

                                            if (fi.Exists)
                                            {
                                                fileInfoList.Add(fi);
                                                _totalFileCount += 1;
                                                _totalFilesSize += fi.Length;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        _currentOperation = OperationType.COPYING;

                        foreach (FileInfo fi in fileInfoList)
                        {
                            if (_userCancel)
                                BackgroundWorker.CancelAsync();
                            else
                            {
                                string sourceRoot = Directory.GetDirectoryRoot(fi.FullName); // GetPathRoot(fi.FullName);

                                string targetPath = Path.Combine(instructions.TargetBaseDirectory.FullName, fi.FullName.Replace(sourceRoot, ""));

                                string targetDirectoryPath = Path.GetDirectoryName(targetPath);

                                if (!Directory.Exists(targetDirectoryPath))
                                {
                                    Directory.CreateDirectory(targetDirectoryPath);

                                    _currentFileCount += 1;
                                    _cumulativeFileSize += fi.Length;

                                    File.Copy(fi.FullName, targetPath, true);
                                }
                                else
                                {
                                    var currentFI = new FileInfo(targetPath);

                                    if (currentFI.Exists)
                                    {
                                        if (currentFI.Length != fi.Length || currentFI.LastWriteTimeUtc != fi.LastWriteTimeUtc)
                                            File.Copy(fi.FullName, targetPath, true);

                                        _currentFileCount += 1;
                                        _cumulativeFileSize += fi.Length;
                                    }
                                    else
                                    {
                                        _currentFileCount += 1;
                                        _cumulativeFileSize += fi.Length;

                                        File.Copy(fi.FullName, targetPath, true);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _operationException = ex;
                BackgroundWorker.CancelAsync();
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _operationSW.Stop();

            Timer.Enabled = false;

            OnCompleted();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            OnProgressChanged();
        }
        #endregion

        #region Events
        /// <summary>
        /// An event indicating that a change in the progress of the
        /// operation has occurred.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        public event ProgressChangedEventHandler ProgressChanged;

        /// <summary>
        /// An event indicating that the operation has completed.
        /// Note that if an exception is thrown or if the user cancels
        /// the operation, this event is also raised.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        public event OperationCompleteEventHandler OperationComplete;
        #endregion

        #region Delegates
        public delegate void ProgressChangedEventHandler(object sender, ProgressChangedEventArgs e);

        public delegate void OperationCompleteEventHandler(object sender, OperationCompleteEventArgs e);

        private delegate List<string> GenerateSafeFolderListDelegate(string folder);
        #endregion

        #region Protected
        /// <summary>
        /// An overridable method used to raise the ProgressChanged event.
        /// </summary>
        /// <remarks></remarks>
        protected virtual void OnProgressChanged()
        {
            ProgressChanged?.Invoke(this, new ProgressChangedEventArgs());
        }

        /// <summary>
        /// An overridable method used to raise the OperationComplete event.
        /// </summary>
        /// <remarks></remarks>
        protected virtual void OnCompleted()
        {
            OperationComplete?.Invoke(this, new OperationCompleteEventArgs());
        }
        #endregion
    }
}