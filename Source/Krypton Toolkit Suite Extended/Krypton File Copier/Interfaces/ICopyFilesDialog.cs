using KryptonFileCopier.Classes;
using System;
using System.ComponentModel;

namespace KryptonFileCopier.Interfaces
{
    public interface ICopyFilesDialog
    {
        ISynchronizeInvoke SynchronizationObject { get; set; }

        event CopyFiles.DEL_cancelCopy EN_cancelCopy;

        //This is how the CopyClass will send your dialog information about
        //the transfer
        void Update(Int32 totalFiles, Int32 copiedFiles, Int64 totalBytes, Int64 copiedBytes, String currentFilename);

        void Show();

        void Hide();
    }
}