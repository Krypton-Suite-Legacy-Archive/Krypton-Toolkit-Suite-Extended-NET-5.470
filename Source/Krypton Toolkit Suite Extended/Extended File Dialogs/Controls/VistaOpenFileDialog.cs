using ExtendedFileDialogs.Classes;
using ExtendedFileDialogs.Enumerations;
using ExtendedFileDialogs.Interop;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ExtendedFileDialogs.Controls
{
    /// <summary>
    /// Prompts the user to open a file.
    /// </summary>
    /// <remarks>
    /// <para>
    ///   This class will use the Vista style file dialog if possible, and automatically fall back to the old-style 
    ///   dialog on versions of Windows older than Vista.
    /// </para>
    /// <para>
    ///   As of .Net 3.5 and .Net 2.0 SP1, the regular <see cref="System.Windows.Forms.OpenFileDialog"/> class will also use
    ///   the new Vista style dialogs. However, certain options, such as settings <see cref="System.Windows.Forms.OpenFileDialog.ShowReadOnly"/>,
    ///   still cause that class to revert to the old style dialogs. For this reason, this class is still provided.
    ///   It is recommended that you use the <see cref="System.Windows.Forms.FileDialog"/> class whenever possible.
    /// </para>
    /// </remarks>
    /// <threadsafety static="true" instance="false"/>
    [System.Drawing.ToolboxBitmap(typeof(OpenFileDialog), "ToolboxBitmaps.OpenFileDialog.bmp"), Description("Prompts the user to open a file.")]
    public class VistaOpenFileDialog : VistaFileDialog
    {
        private bool _showReadOnly;
        private bool _readOnlyChecked;
        private const int _openDropDownId = 0x4002;
        private const int _openItemId = 0x4003;
        private const int _readOnlyItemId = 0x4004;

        /// <summary>
        /// Creates a new instance of <see cref="VistaOpenFileDialog" /> class.
        /// </summary>
        public VistaOpenFileDialog()
            : this(false)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="VistaOpenFileDialog" /> class.
        /// </summary>
        /// <param name="forceDownlevel">When <see langword="true"/>, the old style common file dialog will always be used even if the OS supports the Vista style.</param>
        public VistaOpenFileDialog(bool forceDownlevel)
        {
            if (forceDownlevel || !IsVistaFileDialogSupported)
                DownlevelDialog = new OpenFileDialog();
        }

        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether the dialog box displays a warning if the user specifies a file name that does not exist.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the dialog box displays a warning if the user specifies a file name that does not exist; otherwise, <see langword="false"/>. The default value is <see langword="true"/>.
        /// </value>
        [DefaultValue(true), Description("A value indicating whether the dialog box displays a warning if the user specifies a file name that does not exist.")]
        public override bool CheckFileExists
        {
            get
            {
                return base.CheckFileExists;
            }
            set
            {
                base.CheckFileExists = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the dialog box allows multiple files to be selected.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the dialog box allows multiple files to be selected together or concurrently; otherwise, <see langword="false"/>. 
        /// The default value is <see langword="false"/>.
        /// </value>
        [Description("A value indicating whether the dialog box allows multiple files to be selected."), DefaultValue(false), Category("Behavior")]
        public bool Multiselect
        {
            get
            {
                if (DownlevelDialog != null)
                    return ((OpenFileDialog)DownlevelDialog).Multiselect;
                return GetOption(NativeMethods.FOS.FOS_ALLOWMULTISELECT);
            }
            set
            {
                if (DownlevelDialog != null)
                    ((OpenFileDialog)DownlevelDialog).Multiselect = value;

                SetOption(NativeMethods.FOS.FOS_ALLOWMULTISELECT, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the dialog box contains a read-only check box.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the dialog box contains a read-only check box; otherwise, <see langword="false"/>. The default value is <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// If the Vista style dialog is used, this property can only be used to determine whether the user chose
        /// Open as read-only on the dialog; setting it in code will have no effect.
        /// </remarks>
        [Description("A value indicating whether the dialog box contains a read-only check box."), Category("Behavior"), DefaultValue(false)]
        public bool ShowReadOnly
        {
            get
            {
                if (DownlevelDialog != null)
                    return ((OpenFileDialog)DownlevelDialog).ShowReadOnly;
                return _showReadOnly;
            }
            set
            {
                if (DownlevelDialog != null)
                    ((OpenFileDialog)DownlevelDialog).ShowReadOnly = value;
                else
                    _showReadOnly = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the read-only check box is selected.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the read-only check box is selected; otherwise, <see langword="false"/>. The default value is <see langword="false"/>.
        /// </value>
        [DefaultValue(false), Description("A value indicating whether the read-only check box is selected."), Category("Behavior")]
        public bool ReadOnlyChecked
        {
            get
            {
                if (DownlevelDialog != null)
                    return ((OpenFileDialog)DownlevelDialog).ReadOnlyChecked;
                return _readOnlyChecked;
            }
            set
            {
                if (DownlevelDialog != null)
                    ((OpenFileDialog)DownlevelDialog).ReadOnlyChecked = value;
                else
                    _readOnlyChecked = value;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Resets all properties to their default values.
        /// </summary>
        public override void Reset()
        {
            base.Reset();
            if (DownlevelDialog == null)
            {
                CheckFileExists = true;
                _showReadOnly = false;
                _readOnlyChecked = false;
            }
        }

        /// <summary>
        /// Opens the file selected by the user, with read-only permission. The file is specified by the FileName property. 
        /// </summary>
        /// <returns>A Stream that specifies the read-only file selected by the user.</returns>
        /// <exception cref="System.ArgumentNullException">The file name is <see langword="null"/>.</exception>
        public System.IO.Stream OpenFile()
        {
            if (DownlevelDialog != null)
                return ((OpenFileDialog)DownlevelDialog).OpenFile();
            else
            {
                string fileName = FileName;
                if (string.IsNullOrEmpty(fileName))
                    throw new ArgumentNullException("FileName");
                return new FileStream(fileName, FileMode.Open, FileAccess.Read);
            }
        }

        #endregion

        #region Internal Methods

        internal override IFileDialog CreateFileDialog()
        {
            return new Interop.NativeFileOpenDialog();
        }

        internal override void SetDialogProperties(IFileDialog dialog)
        {
            base.SetDialogProperties(dialog);
            if (_showReadOnly)
            {
                IFileDialogCustomize customise = (IFileDialogCustomize)dialog;
                customise.EnableOpenDropDown(_openDropDownId);
                customise.AddControlItem(_openDropDownId, _openItemId, ComDlgResources.LoadString(ComDlgResourceId.OpenButton));
                customise.AddControlItem(_openDropDownId, _readOnlyItemId, ComDlgResources.LoadString(ComDlgResourceId.ReadOnly));
            }
        }

        internal override void GetResult(IFileDialog dialog)
        {
            if (Multiselect)
            {
                IShellItemArray results;
                ((IFileOpenDialog)dialog).GetResults(out results);
                uint count;
                results.GetCount(out count);
                string[] fileNames = new string[count];
                for (uint x = 0; x < count; ++x)
                {
                    IShellItem item;
                    results.GetItemAt(x, out item);
                    string name;
                    item.GetDisplayName(NativeMethods.SIGDN.SIGDN_FILESYSPATH, out name);
                    fileNames[x] = name;
                }
                FileNamesInternal = fileNames;

            }
            else
                FileNamesInternal = null;

            if (ShowReadOnly)
            {
                Interop.IFileDialogCustomize customize = (Interop.IFileDialogCustomize)dialog;
                int selected;
                customize.GetSelectedControlItem(_openDropDownId, out selected);
                _readOnlyChecked = (selected == _readOnlyItemId);
            }

            base.GetResult(dialog);
        }

        #endregion

    }
}