#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    #region TreeView
    [ToolboxBitmap(typeof(KryptonTreeView)), Description("A directory and file browser.")]
    public class KryptonFileSystemTreeView : KryptonTreeView
    {
        #region Variables
        private bool _showFiles = true;

        private ImageList _imageList = new ImageList();

        private Hashtable _systemIcons = new Hashtable();

        private Icon _folderIcon = null;

        private static readonly int Folder = 0;
        #endregion

        #region Property
        public Icon FolderIcon { get => _folderIcon; set => _folderIcon = value; }
        #endregion

        #region Constructor
        public KryptonFileSystemTreeView()
        {
            ImageList = _imageList;

            MouseDown += KryptonFileSystemTreeView_MouseDown;

            BeforeExpand += KryptonFileSystemTreeView_BeforeExpand;

            try
            {
                string folderIcon = "Icons\\Folder.ico";

                Icon applicationIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

                if (File.Exists(folderIcon))
                {
                    FolderIcon = new Icon(folderIcon);
                }
                else
                {
                    FolderIcon = applicationIcon;
                }
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
        #endregion

        #region Event Handlers
        private void KryptonFileSystemTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node is KryptonTreeNode) return;

            //KryptonDirectoryNode
        }

        private void KryptonFileSystemTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
    #endregion

    #region Class : KryptonDirectoryNode
    public class KryptonDirectoryNode : KryptonTreeNode
    {
        #region Variable
        private DirectoryInfo _directoryInfo;
        #endregion

        #region Property
        //public KryptonFileSystemTreeView TreeView { get => (KryptonFileSystemTreeView)base.TreeView; }
        #endregion
    }
    #endregion

    #region Class : KryptonFakeChildNode
    public class KryptonFakeChildNode : KryptonTreeNode
    {

    }
    #endregion

    #region Class : KryptonFileNode
    public class KryptonFileNode : KryptonTreeNode
    {

    }
    #endregion
}