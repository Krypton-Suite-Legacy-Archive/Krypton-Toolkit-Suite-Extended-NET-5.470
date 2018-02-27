using ExtendedControls.Base.Code;
using ExtendedControls.Interfaces;
using GlobalUtilities.Classes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.ToolstripControls
{
    /// <summary>
    /// Adds an option so show/clear MRU file items. Adapted from (https://www.codeproject.com/Articles/1020671/MRU-File-Manager-Component).
    /// </summary>
    [ToolboxBitmap(typeof(MenuItem)), Description("Adds an option so show/clear MRU file items."), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.MenuStrip | ToolStripItemDesignerAvailability.ContextMenuStrip), DefaultEvent(RecentFileMenuItemClick)]
    public partial class KryptonMostRecentlyUsedFileMenuItem : MenuItem
    {
        #region Variables
        private GlobalMethods _globalMethods = new GlobalMethods();

        private ApplicationSettingsFileListStorage _applicationSettingsFileListStorage = new ApplicationSettingsFileListStorage();

        private IFileListStorage _fileListStorage;

        private string _clearListMenuItemText = DEFINE_CLEAR_LIST_MENU_ITEM_TEXT;

        private string[] _extentions;
        #endregion

        #region Constants
        private const string DEFINE_CLEAR_LIST_MENU_ITEM_TEXT = "&Clear Most Used List";

        private const int DEFINE_MAXIMUM_ITEM_HISTORY_COUNT = 10;
        #endregion

        #region Constructors
        /// <summary>
        /// Initialises a new instance of the <see cref="KryptonMostRecentlyUsedFileMenuItem"/> class.
        /// </summary>
        public KryptonMostRecentlyUsedFileMenuItem()
        {
            // TODO: Empty constructor.
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="KryptonMostRecentlyUsedFileMenuItem"/> class.
        /// </summary>
        /// <param name="fileListStorage">The file list storage.</param>
        /// <param name="menuBuilder">The menu builder.</param>
        public KryptonMostRecentlyUsedFileMenuItem(IFileListStorage fileListStorage, IMenuBuilder menuBuilder)
        {
            StorageHandler = fileListStorage;

            MenuBuilderHandler = menuBuilder;
        }
        #endregion

        #region Events
        /// <summary>
        /// Occurs when the clear recent files menu item is clicked.
        /// </summary>
        [Category("Behavior"), Description("Occurs when the clear recent files menu item is clicked.")]
        public event Action<StringCollection> ClearListMenuItemClick;

        /// <summary>
        /// Occurs when one of the automatically added recent file menu items is clicked.
        /// </summary>
        [Category("Behavior"), Description("Occurs when one of the automatically added recent file menu items is clicked.")]
        public event Action<string> RecentFileMenuItemClick;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the clear list menu item text.
        /// </summary>
        /// <value>
        /// The clear list menu item text. Set this value to <c>null</c> to hide this menu item.
        /// </value>
        [Category("Appearance"), DefaultValue(DEFINE_CLEAR_LIST_MENU_ITEM_TEXT), Description("The clear list menu item text."), Localizable(true)]
        public string ClearListMenuItemText
        {
            get
            {
                return _clearListMenuItemText;
            }

            set
            {
                _clearListMenuItemText = value;

                RefreshRecentFilesMenu();
            }
        }

        /// <summary>
        /// Gets or sets the vertical bar ('|') separated list of extensions without periods that are supported.
        /// </summary>
        /// <value>
        /// The file extensions.
        /// </value>
        [DefaultValue(null), Category("Behavior"), Description("Required. Vertical bar ('|') separated list of extensions without periods that are supported.")]
        public string FileExtensions
        {
            get
            {
                return (_extentions == null) ? string.Empty : string.Join("|", _extentions);
            }

            set
            {
                _extentions = value?.ToLower().Replace(".", "").Split('|', ';', ',', ' ');

                RefreshRecentFilesMenu();
            }
        }

        /// <summary>
        /// Gets the list of most recently used files.
        /// </summary>
        /// <value>
        /// The files in reverse chronological order.
        /// </value>
        [Browsable(false)]
        public IEnumerable<string> Files
        {
            get
            {
                // Pre-load with values from local settings
                var recentFiles = (StorageHandler != null) ? new List<string>(StorageHandler.Files) : new List<string>();

                // Augment with values from Recently Used Files system folder
                if (_extentions != null && _extentions.Length > 0)
                {
                    try
                    {
                        Type type = Type.GetTypeFromProgID("Wscript.Shell");

                        if (type != null)
                        {
                            dynamic script = null;

                            try
                            {
                                script = Activator.CreateInstance(type);

                                foreach (var file in Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.Recent), "*.lnk").Where(s => exts.Contains(Path.GetExtension(s.Substring(0, s.Length - 4)).Trim('.').ToLower())))
                                {

                                    dynamic sc = null;
                                    try
                                    {
                                        sc = script.CreateShortcut(file);

                                        recentFiles.Add(sc.TargetPath);
                                    }
                                    finally
                                    {
                                        if (sc != null)
                                        {
                                            Marshal.FinalReleaseComObject(sc);
                                        }
                                    }
                                }
                            }
                            finally
                            {
                                if (script != null)
                                {
                                    Marshal.FinalReleaseComObject(script);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.ToString());
                    }
                }

                // Sort files by last write time
                var res = recentFiles.Distinct().Where(s => !string.IsNullOrWhiteSpace(s) && File.Exists(s)).OrderByDescending(s => File.GetLastWriteTimeUtc(s)).Take(MaxHistoryCount);

                // Update settings with updated list
                if (StorageHandler != null) StorageHandler.Files = res;

                return res;
            }
        }

        /// <summary>
        /// Gets or sets the maximum number of files to maintain in the history.
        /// </summary>
        /// <value>
        /// The maximum number of files to maintain in the history.
        /// </value>
        [DefaultValue(DEFINE_MAXIMUM_ITEM_HISTORY_COUNT), Category("Behavior"), Description("The maximum number of files to maintain in the history.")]
        public int MaxHistoryCount { get; set; } = DEFINE_MAXIMUM_ITEM_HISTORY_COUNT;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IMenuBuilder MenuBuilderHandler { get; set; }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IFileListStorage StorageHandler
        {
            get { return storage; }
            set { storage = value; storage?.Initialize(); }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds the recent file.
        /// </summary>
        /// <param name="fileNameWithFullPath">The file name with full path.</param>
        public void AddRecentFile(string fileNameWithFullPath)
        {
            if (string.IsNullOrWhiteSpace(fileNameWithFullPath) || !File.Exists(fileNameWithFullPath))
            {
                throw new FileNotFoundException("Unable to add a file that doesn't exist.", fileNameWithFullPath);
            }

            try
            {
                SHAddToRecentDocs(2, fileNameWithFullPath);

                StorageHandler?.AddFileToRecentsList(fileNameWithFullPath);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            RefreshRecentFilesMenu();
        }

        /// <summary>
        /// Removes the recent file.
        /// </summary>
        /// <param name="fileNameWithFullPath">The file name with full path.</param>
        public void RemoveRecentFile(string fileNameWithFullPath)
        {
            try
            {
                StorageHandler?.RemoveFileFromRecentsList(fileNameWithFullPath);

                File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Recent), Path.GetFileName(fileNameWithFullPath), ".lnk"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            RefreshRecentFilesMenu();
        }

        private void OnClearListMenuItemClick()
        {
            var fileArray = new StringCollection();

            fileArray.AddRange(Files.ToArray());

            try
            {
                if (StorageHandler != null)
                {
                    foreach (var s in StorageHandler.Files)
                    {
                        try
                        {
                            File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Recent), Path.GetFileName(s), ".lnk"));
                        }
                        catch
                        {

                        }
                    }
                    StorageHandler.Files = null;
                }
                MenuBuilderHandler?.ClearRecentFiles();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            ClearListMenuItemClick?.Invoke(fileArray);
        }

        private void OnRecentFileMenuItemClick(string file)
        {
            RecentFileMenuItemClick?.Invoke(file);
        }
        #endregion

        #region Protected Methods
        protected void RefreshRecentFilesMenu()
        {
            if (!DesignMode)
            {
                MenuBuilderHandler?.RebuildMenus(Files, OnRecentFileMenuItemClick, ClearListMenuItemText, OnClearListMenuItemClick);
            }
        }
        #endregion

        #region WIN32 API Calls
        [DllImport("shell32.dll", CharSet = CharSet.Ansi)]
        private static extern void SHAddToRecentDocs(int flag, [In] string path);
        #endregion
    }
}