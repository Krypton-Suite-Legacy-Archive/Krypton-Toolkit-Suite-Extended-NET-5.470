#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
#region Resources
#endregion

namespace KryptonExtendedToolkit.ExtendedToolkit.ToolstripControls
{
    /// <summary>
    /// A <see cref="MenuItem"/> that displays the most recently used files to the user.
    /// </summary>
    [ToolboxBitmap(typeof(ToolStripMenuItem)), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.MenuStrip | ToolStripItemDesignerAvailability.ContextMenuStrip), DefaultEvent(nameof(RecentFileMenuItemClick))]
    public class KryptonMostRecentlyUsedFileMenuItem : MenuItem  /// Component
    {
        #region Variables
        private string _clearItemHistoryText = CLEAR_LIST_MENU_ITEM_TEXT;

        private string[] _fileExtentions;

        private IFileListStorage _storage;
        #endregion

        #region Constants
        private const string CLEAR_LIST_MENU_ITEM_TEXT = "&Clear List";

        private const int MAXIMUM_RECENTLY_USED_ITEMS = 10;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonMostRecentlyUsedFileMenuItem"/> class.
        /// </summary>
        public KryptonMostRecentlyUsedFileMenuItem()
        {
            // TODO: Nothing
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonMostRecentlyUsedFileMenuItem"/> class.
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

        #region IFileListStorage Interface
        /// <summary>
        /// Defines a class that implements storage for an MRU file list.
        /// </summary>
        public interface IFileListStorage
        {
            /// <summary>
            /// Gets or sets the files declared in this storage instance.
            /// </summary>
            /// <value>
            /// The file listing. Each file should declare its full path.
            /// </value>
            IEnumerable<string> Files { get; set; }

            /// <summary>
            /// Adds a new file to the list.
            /// </summary>
            /// <param name="fileNameWithFullPath">The file name with full path.</param>
            void AddRecentFile(string fileNameWithFullPath);

            /// <summary>
            /// Initializes this instance and sets up any local settings required for execution.
            /// </summary>
            void Initialize();

            /// <summary>
            /// Removes the file from the list.
            /// </summary>
            /// <param name="fileNameWithFullPath">The file name with full path.</param>
            void RemoveRecentFile(string fileNameWithFullPath);
        }
        #endregion

        #region IMenuBuilder Interface
        /// <summary>
        /// Defines a class that implements a menu handler for an MRU file list.
        /// </summary>
        public interface IMenuBuilder
        {
            /// <summary>
            /// Clears the menu items of all files.
            /// </summary>
            void ClearRecentFiles();

            /// <summary>
            /// Rebuilds the menus.
            /// </summary>
            /// <param name="files">The file listing.</param>
            /// <param name="fileMenuItemClick">The handler for when one of the automatically added recent file menu items is clicked..</param>
            /// <param name="clearListMenuItemText">The clear list menu item text. A <c>null</c> value indicates that this menu items should not be shown.</param>
            /// <param name="clearListMenuItemClick">The handler for when the clear recent files menu item is clicked.</param>
            void RebuildMenus(IEnumerable<string> files, Action<string> fileMenuItemClick, string clearListMenuItemText = null, Action clearListMenuItemClick = null);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the clear list menu item text.
        /// </summary>
        /// <value>
        /// The clear list menu item text. Set this value to <c>null</c> to hide this menu item.
        /// </value>
        [Category("Appearance"), DefaultValue(CLEAR_LIST_MENU_ITEM_TEXT), Description("The clear list menu item text."), Localizable(true)]
        public string ClearListMenuItemText
        {
            get
            {
                return _clearItemHistoryText;
            }

            set
            {
                _clearItemHistoryText = value;

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
                return (_fileExtentions == null) ? string.Empty : string.Join("|", _fileExtentions);
            }

            set
            {
                _fileExtentions = value?.ToLower().Replace(".", "").Split('|', ';', ',', ' ');

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
                if (_fileExtentions != null && _fileExtentions.Length > 0)
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

                                foreach (var file in Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.Recent), "*.lnk").Where(s => _fileExtentions.Contains(Path.GetExtension(s.Substring(0, s.Length - 4)).Trim('.').ToLower())))
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
                if (StorageHandler != null)
                {
                    StorageHandler.Files = res;
                }

                return res;
            }
        }

        /// <summary>
        /// Gets or sets the maximum number of files to maintain in the history.
        /// </summary>
        /// <value>
        /// The maximum number of files to maintain in the history.
        /// </value>
        [DefaultValue(MAXIMUM_RECENTLY_USED_ITEMS), Category("Behavior"), Description("The maximum number of files to maintain in the history.")]
        public int MaxHistoryCount { get; set; } = MAXIMUM_RECENTLY_USED_ITEMS;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IMenuBuilder MenuBuilderHandler { get; set; }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IFileListStorage StorageHandler
        {
            get
            {
                return _storage;
            }

            set
            {
                _storage = value;

                _storage?.Initialize();
            }
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

                StorageHandler?.AddRecentFile(fileNameWithFullPath);
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
                StorageHandler?.RemoveRecentFile(fileNameWithFullPath);

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
            fileArray.AddRange(this.Files.ToArray());
            try
            {
                if (StorageHandler != null)
                {
                    foreach (var s in StorageHandler.Files)
                        try { File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Recent), Path.GetFileName(s), ".lnk")); } catch { }
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
        /// <summary>
        /// Refreshes the recent files menu.
        /// </summary>
        protected void RefreshRecentFilesMenu()
        {
            if (!DesignMode)
            {
                MenuBuilderHandler?.RebuildMenus(this.Files, this.OnRecentFileMenuItemClick, this.ClearListMenuItemText, this.OnClearListMenuItemClick);
            }
        }
        #endregion

        #region WIN32 Handler
        [DllImport("shell32.dll", CharSet = CharSet.Ansi)]
        private static extern void SHAddToRecentDocs(int flag, [In] string path);
        #endregion

        #region AppSettingsFileListStorage Class
        /// <summary>
        /// Storage in the local application settings.
        /// </summary>
        public class AppSettingsFileListStorage : IFileListStorage
        {
            private const string propName = "__MRUList__";
            private ApplicationSettingsBase settings;

            /// <summary>
            /// Initializes a new instance of the <see cref="AppSettingsFileListStorage" /> class.
            /// </summary>
            public AppSettingsFileListStorage() { }

            /// <summary>
            /// Gets or sets the files.
            /// </summary>
            /// <value>
            /// The files.
            /// </value>
            public IEnumerable<string> Files
            {
                get { return new List<string>(SettingsValue.OfType<string>()); }
                set
                {
                    var col = new StringCollection();
                    if (value != null)
                        col.AddRange(value.ToArray());
                    SettingsValue = col;
                }
            }

            private ApplicationSettingsBase Settings
            {
                get { return settings; }
                set { settings = value; AddMRUPropToSettings(); }
            }

            private StringCollection SettingsValue
            {
                get { return settings != null ? settings[propName] as StringCollection : new StringCollection(); }
                set { if (settings != null) settings[propName] = value; }
            }

            /// <summary>
            /// Adds the recent file.
            /// </summary>
            /// <param name="fileNameWithFullPath">The file name with full path.</param>
            public void AddRecentFile(string fileNameWithFullPath)
            {
                StringCollection col = new StringCollection();
                col.Add(fileNameWithFullPath);
                col.AddRange(SettingsValue.OfType<string>().ToArray());
                SettingsValue = col;
            }

            /// <summary>
            /// Initializes this instance.
            /// </summary>
            public void Initialize()
            {
                TryLoadAppSettings();
            }

            /// <summary>
            /// Removes the recent file.
            /// </summary>
            /// <param name="fileNameWithFullPath">The file name with full path.</param>
            public void RemoveRecentFile(string fileNameWithFullPath)
            {
                StringCollection col = SettingsValue;
                col.Remove(fileNameWithFullPath);
                SettingsValue = col;
            }

            private void AddMRUPropToSettings()
            {
                if (Settings?.Properties[propName] == null)
                {
                    object defValue = new StringCollection();

                    SettingsAttributeDictionary d = new SettingsAttributeDictionary();
                    d.Add(typeof(UserScopedSettingAttribute), new UserScopedSettingAttribute());
                    Settings.Properties.Add(new SettingsProperty(propName, typeof(StringCollection),
                        Settings.Providers["LocalFileSettingsProvider"], false, defValue,
                        SettingsSerializeAs.Xml, d, false, false));
                    Settings.Reload();
                    var conf = SettingsValue;
                    if (conf == null)
                    {
                        SettingsValue = new StringCollection();
                        Settings.Save();
                    }
                }
            }

            private void TryLoadAppSettings()
            {
                var appSettingsType = GetType().Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(ApplicationSettingsBase))).First();
                if (appSettingsType != null)
                {
                    var defProp = appSettingsType?.GetProperty("Default");
                    if (defProp != null)
                        Settings = (ApplicationSettingsBase)defProp.GetValue(null, null);
                    else
                        Settings = (ApplicationSettingsBase)ApplicationSettingsBase.Synchronized((ApplicationSettingsBase)Activator.CreateInstance(appSettingsType));
                }
                else
                    throw new ApplicationException("Assembly hosting MRUManager must already have a settings instance derived from ApplicationSettingsBase.");
            }
        }
        #endregion

        #region RegistryFileListStorage Class
        /// <summary>
        /// 
        /// </summary>
        public class RegistryFileListStorage : IFileListStorage
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="RegistryFileListStorage" /> class.
            /// </summary>
            public RegistryFileListStorage() { }

            /// <summary>
            /// Gets or sets the files.
            /// </summary>
            /// <value>
            /// The files.
            /// </value>
            public IEnumerable<string> Files
            {
                get { return GetFiles(GetKey()); }
                set { SetFiles(GetKey(), value); }
            }

            /// <summary>
            /// Gets or sets the name of the sub key.
            /// </summary>
            /// <value>
            /// The name of the sub key.
            /// </value>
            public string SubKeyName { get; set; }

            /// <summary>
            /// Adds the recent file.
            /// </summary>
            /// <param name="fileNameWithFullPath">The file name with full path.</param>
            public void AddRecentFile(string fileNameWithFullPath)
            {
                try
                {
                    using (var rK = GetKey())
                    {
                        var l = new List<string>(GetFiles(rK));
                        l.Insert(0, fileNameWithFullPath);
                        SetFiles(rK, l.Distinct());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            /// <summary>
            /// Initializes this instance.
            /// </summary>
            public void Initialize()
            {
                if (SubKeyName == null)
                {
                    string company = GetAssemblyAttribute<System.Reflection.AssemblyCompanyAttribute>()?.Company;
                    string product = GetAssemblyAttribute<System.Reflection.AssemblyProductAttribute>()?.Product;
                    string s = null;
                    if (company != null && product != null)
                        s = $"{company}\\{product}";
                    else if (company != null)
                        s = company;
                    else if (product != null)
                        s = product;
                    else
                        s = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                    SubKeyName = $"Software\\{s}\\MRU";
                }
            }

            /// <summary>
            /// Removes the recent file.
            /// </summary>
            /// <param name="fileNameWithFullPath">The file name with full path.</param>
            public void RemoveRecentFile(string fileNameWithFullPath)
            {
                try
                {
                    using (var rK = GetKey())
                    {
                        var l = new List<string>(GetFiles(rK));
                        l.RemoveAll(s => string.Equals(s, fileNameWithFullPath, StringComparison.InvariantCultureIgnoreCase));
                        SetFiles(rK, l.Distinct());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            private static T GetAssemblyAttribute<T>() => (T)System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(T), true).FirstOrDefault();

            private IEnumerable<string> GetFiles(SafeRegKey rK)
            {
                string s;
                for (int i = 0; true; i++)
                {
                    s = rK.Key.GetValue(i.ToString(), null) as string;
                    if (s == null)
                        break;
                    yield return s;
                }
            }

            private void SetFiles(SafeRegKey rK, IEnumerable<string> value)
            {
                int i = 0;
                while (true)
                {
                    try { rK.Key.DeleteValue(i++.ToString(), true); }
                    catch { break; }
                }
                i = 0;
                foreach (string s in value)
                    rK.Key.SetValue(i++.ToString(), s);
            }

            private SafeRegKey GetKey() => new SafeRegKey(Microsoft.Win32.Registry.CurrentUser, SubKeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);

            #region Registry Handling
            private class SafeRegKey : IDisposable
            {
                public Microsoft.Win32.RegistryKey Key;

                public SafeRegKey(Microsoft.Win32.RegistryKey root, string subKeyName, Microsoft.Win32.RegistryKeyPermissionCheck opt)
                {
                    Key = root.CreateSubKey(subKeyName, opt);
                }

                public static implicit operator Microsoft.Win32.RegistryKey(SafeRegKey k) => k.Key;

                public void Dispose()
                {
                    Key.Close();
                }
            }
            #endregion
        }
        #endregion
    }
}

#region User Controls
#if !WPF
namespace KryptonExtendedToolkit.Windows.Forms
{
    #region Using Statements
    using KryptonExtendedToolkit.ExtendedToolkit.ToolstripControls;
    using System.Windows.Forms;
    #endregion

    #region MenuStripMRUManager Class
    /// <summary>
    /// A class that manages a Most Recently Used file listing and interacts with a MenuStrip to
    /// display a menu list of the files. By default, the application settings are used to store the history.
    /// Optionally a constructor can be used to provide an alternate class to handle that work.
    /// </summary>
    [DefaultProperty("RecentFileMenuItem")]
    public class KryptonMenuStripMRUManager : KryptonMostRecentlyUsedFileMenuItem
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonMenuStripMRUManager"/> class.
        /// </summary>
        public KryptonMenuStripMRUManager()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonMenuStripMRUManager" /> class.
        /// </summary>
        /// <param name="extensions">The extensions of files to find in system MRU list.</param>
        /// <param name="parentMenuItem">The parent "Recent Files" menu item.</param>
        /// <param name="onRecentFileClick">Action to run when The on recent file click.</param>
        /// <param name="onClearRecentFilesClick">Optional. The on clear recent files click.</param>
        /// <param name="storageHandler">Optional. The storage handler.</param>
        public KryptonMenuStripMRUManager(string extensions, ToolStripMenuItem parentMenuItem, Action<string> onRecentFileClick, Action<StringCollection> onClearRecentFilesClick = null, IFileListStorage storageHandler = null) : base(storageHandler == null ? new AppSettingsFileListStorage() : storageHandler, new MenuStripMenuBuilder())
        {
            FileExtensions = extensions;

            ((MenuStripMenuBuilder)MenuBuilderHandler).RecentFileMenuItem = parentMenuItem;

            if (onRecentFileClick != null)
            {
                RecentFileMenuItemClick += onRecentFileClick;
            }

            if (onClearRecentFilesClick != null)
            {
                ClearListMenuItemClick += onClearRecentFilesClick;
            }

            RefreshRecentFilesMenu();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the recent file menu item.
        /// </summary>
        /// <value>
        /// The recent file menu item.
        /// </value>
        [DefaultValue(null), Category("Behavior"), Description("The recent file menu item.")]
        public ToolStripMenuItem RecentFileMenuItem
        {
            get
            {
                return ((MenuStripMenuBuilder)MenuBuilderHandler).RecentFileMenuItem;
            }

            set
            {
                ((MenuStripMenuBuilder)MenuBuilderHandler).RecentFileMenuItem = value;

                RefreshRecentFilesMenu();
            }
        }
        #endregion

        #region MenuStripMenuBuilder Class
        /// <summary>
		/// Builds a menu within a MenuStrip.
		/// </summary>
		private class MenuStripMenuBuilder : IMenuBuilder
        {
            private Action<string> fileMenuItemClickAction;

            /// <summary>
            /// Initializes a new instance of the <see cref="MenuStripMenuBuilder" /> class.
            /// </summary>
            public MenuStripMenuBuilder()
            {
            }

            /// <summary>
            /// Gets or sets the recent file menu item.
            /// </summary>
            /// <value>
            /// The recent file menu item.
            /// </value>
            public ToolStripMenuItem RecentFileMenuItem { get; set; }

            /// <summary>
            /// Clears the recent files.
            /// </summary>
            public void ClearRecentFiles()
            {
                if (RecentFileMenuItem != null)
                {
                    RecentFileMenuItem.DropDownItems.Clear();

                    RecentFileMenuItem.Enabled = true;
                }
            }

            /// <summary>
            /// Rebuilds the menus.
            /// </summary>
            /// <param name="files">The file listing.</param>
            /// <param name="fileMenuItemClick">The handler for when one of the automatically added recent file menu items is clicked..</param>
            /// <param name="clearListMenuItemText">The clear list menu item text. A <c>null</c> value indicates that this menu items should not be shown.</param>
            /// <param name="clearListMenuItemClick">The handler for when the clear recent files menu item is clicked.</param>
            /// <exception cref="NotImplementedException"></exception>
            public void RebuildMenus(IEnumerable<string> files, Action<string> fileMenuItemClick, string clearListMenuItemText = null, Action clearListMenuItemClick = null)
            {
                var _files = new List<string>();

                foreach (string item in files)
                {
                    _files.Add(item);
                }

                if (RecentFileMenuItem != null)
                {
                    RecentFileMenuItem.DropDownItems.Clear();

                    fileMenuItemClickAction = fileMenuItemClick;

                    _files.ForEach(f => RecentFileMenuItem.DropDownItems.Add(new ToolStripMenuItem(CompactPath(f, RecentFileMenuItem.Font, RecentFileMenuItem.Width), null, OnFileMenuItemClick) { Tag = f }));

                    if (RecentFileMenuItem.DropDownItems.Count == 0)
                    {
                        RecentFileMenuItem.Enabled = false;

                        return;
                    }

                    if (!string.IsNullOrEmpty(clearListMenuItemText))
                    {
                        RecentFileMenuItem.DropDownItems.Add("-");

                        RecentFileMenuItem.DropDownItems.Add(clearListMenuItemText, null, (o, e) => clearListMenuItemClick());
                    }

                    RecentFileMenuItem.Enabled = true;
                }
            }

            private void OnFileMenuItemClick(object sender, EventArgs e)
            {
                var item = sender as ToolStripMenuItem;

                if (item != null)
                {
                    fileMenuItemClickAction(item.Tag.ToString());
                }
            }

            public static string CompactPath(string stringToCompact, Font font, int maxWidthInPts)
            {
                string compactedString = string.Copy(stringToCompact);

                TextRenderer.MeasureText(compactedString, font, new Size(maxWidthInPts, 0), TextFormatFlags.PathEllipsis | TextFormatFlags.ModifyString);

                return compactedString;
            }
        }
        #endregion
    }
    #endregion
}
#else

#endif
#endregion