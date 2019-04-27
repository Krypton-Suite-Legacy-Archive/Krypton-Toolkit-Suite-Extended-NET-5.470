using ExtendedControls.Base.Code.FileExplorer;
using ExtendedControls.Base.Enumerations;
using ExtendedControls.Base.Structs.FileExplorer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.FileExplorer
{
    public class FileBrowser : ListView
    {
        #region Variables
        private WIN32 _win32 = new WIN32();
        private ImageList _imageList16 = new ImageList(), _imageList32 = new ImageList();
        private BackgroundWorker _iconLoader = new BackgroundWorker();
        private List<ItemType> _paths = new List<ItemType>();
        private bool _use16 = true, _isSoloFileBrowser = true;
        private string _defaultPath = "C:\\", _selectedPath = string.Empty;
        #endregion

        #region Properties
        public bool IsSoloFileBrowser { get => _isSoloFileBrowser; set => _isSoloFileBrowser = value; }

        public string DefaultPath { get => _defaultPath; set => _defaultPath = value; }

        public string SelectedPath { get => _selectedPath; set => _selectedPath = value; }
        #endregion

        #region Constructor
        public FileBrowser()
        {

        }
        #endregion

        public void Load()
        {
            _imageList16.ColorDepth = ColorDepth.Depth32Bit;

            _imageList32.ColorDepth = ColorDepth.Depth32Bit;

            _imageList32.ImageSize = new Size(32, 32);

            SmallImageList = _imageList16;

            LargeImageList = _imageList32;

            Activation = ItemActivation.TwoClick;

            MultiSelect = false;

            Columns.Add("colName", "Name");

            Columns.Add("colType", "Type");

            Columns.Add("Size", 1, HorizontalAlignment.Right);

            Columns.Add("colDate", "Date");

            _iconLoader.WorkerReportsProgress = true;

            _iconLoader.WorkerSupportsCancellation = true;

            _iconLoader.DoWork += IconLoader_DoWork;

            _iconLoader.ProgressChanged += IconLoader_ProgressChanged;

            _iconLoader.RunWorkerCompleted += IconLoader_RunWorkerCompleted;

            ItemActivate += FileBrowser_ItemActivate;

            ItemSelectionChanged += FileBrowser_ItemSelectionChanged;

            Browse(DefaultPath);
        }

        private void FileBrowser_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (SelectedItems.Count <= 0) return;

            ListViewItem lvi = SelectedItems[0];

            ItemType type = (ItemType)lvi.Tag;

            if (type.Type == SupportedExplorerTypes.FOLDER)
            {
                DirectoryInfo directoryInfo = (DirectoryInfo)type.ItemInfo;

                SelectedPath = directoryInfo.FullName;
            }
            else
            {
                FileInfo fileInfo = (FileInfo)type.ItemInfo;

                SelectedPath = fileInfo.FullName;
            }
        }

        private void FileBrowser_ItemActivate(object sender, EventArgs e)
        {
            if (SelectedItems.Count <= 0) return;

            ListViewItem lvi = SelectedItems[0];

            ItemType type = (ItemType)lvi.Tag;

            if (type.Type == SupportedExplorerTypes.FOLDER)
            {
                DirectoryInfo directoryInfo = (DirectoryInfo)type.ItemInfo;

                Browse(directoryInfo.FullName);
            }
        }

        private void IconLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate { AutoColumnResize(); }));
        }

        private void IconLoader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                string fileName = (string)e.UserState, name = Path.GetFileName((string)e.UserState);

                ListViewItem lvi = null;

                Invoke(new MethodInvoker(delegate { lvi = FindItemWithText(name, false, 0, true); }));

                if (lvi != null)
                {
                    try
                    {
                        Debug.WriteLine(name);

                        lvi.ImageKey = fileName;
                    }
                    catch (Exception exc)
                    {
                        Debug.WriteLine(exc.Message);
                    }
                    finally
                    {
                        Application.DoEvents();
                    }
                }
            }
        }

        private void IconLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            string fullName = string.Empty;

            foreach (ItemType item in _paths)
            {
                if (_iconLoader.CancellationPending)
                {
                    e.Cancel = true;

                    return;
                }

                if (item.Type == SupportedExplorerTypes.FOLDER)
                {
                    DirectoryInfo directoryInfo = (DirectoryInfo)item.ItemInfo;

                    if (_use16)
                    {
                        if (!_imageList16.Images.ContainsKey(directoryInfo.FullName))
                        {
                            _imageList16.Images.Add(directoryInfo.FullName, _win32.GetIcon(directoryInfo.FullName, false));
                        }
                    }
                    else
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            if (!_imageList32.Images.ContainsKey(directoryInfo.FullName))
                            {
                                _imageList32.Images.Add(directoryInfo.FullName, _win32.GetIcon(directoryInfo.FullName, true));
                            }
                        }));
                    }

                    fullName = directoryInfo.FullName;
                }
                else
                {
                    FileInfo fileInfo = (FileInfo)item.ItemInfo;

                    if (_use16)
                    {
                        if (!_imageList16.Images.ContainsKey(fileInfo.FullName))
                        {
                            _imageList16.Images.Add(fileInfo.FullName, _win32.GetIcon(fileInfo.FullName, true));
                        }
                    }
                    else
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            if (!_imageList32.Images.ContainsKey(fileInfo.FullName))
                            {
                                _imageList32.Images.Add(fileInfo.FullName, _win32.GetIcon(fileInfo.FullName, false));
                            }
                        }));
                    }

                    fullName = fileInfo.FullName;
                }

                string name = Path.GetFileName(fullName);

                ListViewItem lvi = null;

                Invoke(new MethodInvoker(delegate { lvi = FindItemWithText(name, false, 0, true); }));

                if (lvi != null)
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        lvi.ImageKey = fullName;

                        if (item.Type == SupportedExplorerTypes.FILE)
                        {
                            lvi.SubItems[1].Text = _win32.GetFileType(fullName);

                            lvi.SubItems[2].Text = _win32.GetFileSize(fullName);
                        }
                    }));
                }
            }
        }

        public void Browse(string path)
        {
            _iconLoader.CancelAsync();

            if (View == View.LargeIcon || View == View.Tile) _use16 = false;

            while (_iconLoader.IsBusy)
            {
                Application.DoEvents();
            }

            _paths.Clear();

            Items.Clear();

            BeginUpdate();

            if (IsSoloFileBrowser)
            {
                DirectoryInfo currentPath = new DirectoryInfo(path);

                if (currentPath.FullName.Length > 3)
                {
                    ListViewItem lvi = new ListViewItem("...");

                    lvi.Tag = new ItemType() { ItemInfo = currentPath.Parent, Type = SupportedExplorerTypes.FOLDER };

                    Items.Add(lvi);
                }
            }

            foreach (string folder in Directory.GetDirectories(path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folder);

                if (directoryInfo.Attributes.ToString().Contains("System")) continue;

                ListViewItem lvi = new ListViewItem(directoryInfo.Name);

                lvi.ImageKey = directoryInfo.FullName;

                lvi.Tag = new ItemType() { ItemInfo = directoryInfo, Type = SupportedExplorerTypes.FOLDER };

                for (int i = 0; i < Columns.Count; i++)
                {
                    lvi.SubItems.Add(string.Empty);
                }

                lvi.SubItems[3].Text = directoryInfo.CreationTime.ToString();

                lvi.SubItems[1].Text = "File folder";

                Items.Add(lvi);

                _paths.Add((ItemType)lvi.Tag);
            }

            foreach (string file in Directory.GetFiles(path))
            {
                FileInfo fileInfo = new FileInfo(file);

                if (fileInfo.Attributes.ToString().Contains("System")) continue;

                ListViewItem lvi = new ListViewItem(fileInfo.Name);

                lvi.ImageKey = fileInfo.FullName;

                lvi.Tag = new ItemType() { ItemInfo = fileInfo, Type = SupportedExplorerTypes.FILE };

                for (int i = 0; i < Columns.Count; i++)
                {
                    lvi.SubItems.Add(string.Empty);
                }

                lvi.SubItems[3].Text = fileInfo.CreationTime.ToString();

                Items.Add(lvi);

                _paths.Add((ItemType)lvi.Tag);
            }

            EndUpdate();

            Refresh();

            Application.DoEvents();

            _iconLoader.RunWorkerAsync();
        }

        private void AutoColumnResize()
        {
            foreach (ColumnHeader header in Columns)
            {
                header.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
    }
}