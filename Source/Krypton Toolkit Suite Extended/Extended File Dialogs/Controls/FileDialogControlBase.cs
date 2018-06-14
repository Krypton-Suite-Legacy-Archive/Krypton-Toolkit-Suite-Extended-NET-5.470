//  Copyright (c) 2006, Gustavo Franco
//  Copyright © Decebal Mihailescu 2007-2015

//  Email:  gustavo_franco@hotmail.com
//  All rights reserved.

//  Redistribution and use in source and binary forms, with or without modification, 
//  are permitted provided that the following conditions are met:

//  Redistributions of source code must retain the above copyright notice, 
//  this list of conditions and the following disclaimer. 
//  Redistributions in binary form must reproduce the above copyright notice, 
//  this list of conditions and the following disclaimer in the documentation 
//  and/or other materials provided with the distribution. 

//  THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
//  PURPOSE. IT CAN BE DISTRIBUTED FREE OF CHARGE AS LONG AS THIS HEADER 
//  REMAINS UNCHANGED.

using ExtendedFileDialogs.Classes;
using ExtendedFileDialogs.Enumerations;
using ExtendedFileDialogs.Structs;
using GlobalUtilities.Classes;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExtendedFileDialogs.Controls
{
    public partial class FileDialogControlBase : UserControl
    {
        #region Delegates
        public delegate void PathChangedEventHandler(IWin32Window sender, string filePath);

        public delegate void FilterChangedEventHandler(IWin32Window sender, int index);
        #endregion

        #region Events
        //for weird reasons the designer wants the events public not protected    
        [Category("FileDialogExtenders")]
        public event PathChangedEventHandler EventFileNameChanged;

        [Category("FileDialogExtenders")]
        public event PathChangedEventHandler EventFolderNameChanged;

        [Category("FileDialogExtenders")]
        public event FilterChangedEventHandler EventFilterChanged;

        [Category("FileDialogExtenders")]
        public event CancelEventHandler EventClosingDialog;
        #endregion

        #region Constants Declaration
        private const SetWindowPosFlags UFLAGSHIDE =
            SetWindowPosFlags.SWP_NOACTIVATE |
            SetWindowPosFlags.SWP_NOOWNERZORDER |
            SetWindowPosFlags.SWP_NOMOVE |
            SetWindowPosFlags.SWP_NOSIZE |
            SetWindowPosFlags.SWP_HIDEWINDOW;
        #endregion

        #region Variables Declaration
        FileDialog _MSdialog;

        NativeWindow _dlgWrapper;

        private AddonWindowLocation _StartLocation = AddonWindowLocation.Right;

        private FolderViewMode _DefaultViewMode = FolderViewMode.Default;

        IntPtr _hFileDialogHandle = IntPtr.Zero;

        FileDialogType _FileDlgType;

        string _InitialDirectory = string.Empty, _Filter = "All files (*.*)|*.*", _DefaultExt = "jpg", _FileName = string.Empty, _Caption = "Save", _OKCaption = "&Open";

        int _FilterIndex = 1;

        bool _AddExtension = true, _CheckFileExists = true, _EnableOkBtn = true, _DereferenceLinks = true, _ShowHelp, _hasRunInitMSDialog;

        RECT _OpenDialogWindowRect = new RECT();

        IntPtr _hOKButton = IntPtr.Zero;

        [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]

        IntPtr _hListViewPtr;

        ExceptionHandler _eh = new ExceptionHandler();
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDialogControlBase"/> class.
        /// </summary>
        public FileDialogControlBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        static uint _originalDlgHeight, _originalDlgWidth;

        internal static uint OriginalDlgWidth
        {
            get { return FileDialogControlBase._originalDlgWidth; }
            set { FileDialogControlBase._originalDlgWidth = value; }
        }

        internal static uint OriginalDlgHeight
        {
            get { return FileDialogControlBase._originalDlgHeight; }
            set { FileDialogControlBase._originalDlgHeight = value; }
        }

        [Browsable(false)]
        public string[] FileDlgFileNames
        {
            get { return DesignMode ? null : MSDialog.FileNames; }
        }

        [Browsable(false)]
        public FileDialog MSDialog
        {
            set { _MSdialog = value; }
            get { return _MSdialog; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue(AddonWindowLocation.Right)]
        public AddonWindowLocation FileDlgStartLocation
        {
            get { return _StartLocation; }
            set
            {
                _StartLocation = value;
                if (DesignMode)
                {
                    this.Refresh();
                }
            }
        }

        Size _OriginalCtrlSize;
        internal Size OriginalCtrlSize
        {
            get { return _OriginalCtrlSize; }
            set
            {
                _OriginalCtrlSize = value;
            }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue(FolderViewMode.Default)]
        public FolderViewMode FileDlgDefaultViewMode
        {
            get { return _DefaultViewMode; }
            set { _DefaultViewMode = value; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue(FileDialogType.OpenFileDlg)]
        public FileDialogType FileDlgType
        {
            get { return _FileDlgType; }
            set { _FileDlgType = value; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue("")]
        public string FileDlgInitialDirectory
        {
            get { return DesignMode ? _InitialDirectory : MSDialog.InitialDirectory; }
            set
            {
                _InitialDirectory = value;
                if (!DesignMode && MSDialog != null)
                    MSDialog.InitialDirectory = value;
            }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue("")]
        public string FileDlgFileName
        {
            get { return DesignMode ? _FileName : MSDialog.FileName; }
            set { _FileName = value; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue("")]
        public string FileDlgCaption
        {
            get { return _Caption; }
            set { _Caption = value; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue("&Open")]
        public string FileDlgOkCaption
        {
            get { return _OKCaption; }
            set { _OKCaption = value; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue("jpg")]
        public string FileDlgDefaultExt
        {
            get { return DesignMode ? _DefaultExt : MSDialog.DefaultExt; }
            set { _DefaultExt = value; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue("All files (*.*)|*.*")]
        public string FileDlgFilter
        {
            get { return DesignMode ? _Filter : MSDialog.Filter; }
            set { _Filter = value; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue(1)]
        public int FileDlgFilterIndex
        {
            get { return DesignMode ? _FilterIndex : MSDialog.FilterIndex; }
            set { _FilterIndex = value; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue(true)]
        public bool FileDlgAddExtension
        {
            get { return DesignMode ? _AddExtension : MSDialog.AddExtension; }
            set { _AddExtension = value; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue(true)]
        public bool FileDlgEnableOkBtn
        {
            get { return _EnableOkBtn; }
            set
            {
                _EnableOkBtn = value;
                if (!DesignMode && MSDialog != null && _hOKButton != IntPtr.Zero)
                {
                    NativeMethods.EnableWindow(_hOKButton, _EnableOkBtn);
                }
            }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue(true)]
        public bool FileDlgCheckFileExists
        {
            get { return DesignMode ? _CheckFileExists : MSDialog.CheckFileExists; }
            set
            { _CheckFileExists = value; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue(false)]
        public bool FileDlgShowHelp
        {
            get { return DesignMode ? _ShowHelp : MSDialog.ShowHelp; }
            set { _ShowHelp = value; }
        }

        [Category("FileDialogExtenders")]
        [DefaultValue(true)]
        public bool FileDlgDereferenceLinks
        {
            get { return DesignMode ? _DereferenceLinks : MSDialog.DereferenceLinks; }
            set { _DereferenceLinks = value; }
        }
        #endregion

        #region Overrides & Virtuals        
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!DesignMode)
            {
                if (MSDialog != null)
                {
                    MSDialog.FileOk += new CancelEventHandler(DialogClosing);

                    MSDialog.Disposed += new EventHandler(DialogDisposed);

                    MSDialog.HelpRequest += new EventHandler(HelpRequest);

                    FileDlgEnableOkBtn = _EnableOkBtn;

                    NativeMethods.SetWindowText(new HandleRef(_dlgWrapper, _dlgWrapper.Handle), _Caption);

                    NativeMethods.SetWindowText(new HandleRef(this, _hOKButton), _OKCaption);
                }
            }
        }

        public void SortViewByColumn(int index)
        {
            try
            {
                IntPtr hWndWin = NativeMethods.FindWindowEx(_dlgWrapper.Handle, IntPtr.Zero, "SHELLDLL_DefView", "");

                if (hWndWin != IntPtr.Zero)
                {
                    NativeMethods.SendMessage(new HandleRef(this, hWndWin), (int)Msg.WM_COMMAND, (IntPtr)(int)DefaultViewType.Details, IntPtr.Zero);

                    #region Sort by date
                    int HDN_FIRST = (-300);
                    int HDN_ITEMCLICKW = (HDN_FIRST - 22);

                    //get the ListView//s hWnd
                    IntPtr hWndLV = NativeMethods.FindWindowEx(hWndWin, IntPtr.Zero, "SysListView32", IntPtr.Zero);
                    //get the ColumnHeaders hWnd
                    IntPtr hWndColHd = NativeMethods.FindWindowEx(hWndLV, IntPtr.Zero, "SysHeader32", IntPtr.Zero);

                    //now click on column 3 to sort for date
                    NMHEADER NMH = new NMHEADER();
                    NMH.hdr.hwndFrom = hWndColHd;
                    NMH.hdr.code = (uint)HDN_ITEMCLICKW;
                    NMH.iItem = index;
                    NMH.iButton = 0;

                    // Initialize unmanged memory to hold the struct.
                    IntPtr ptrNMH = Marshal.AllocHGlobal(Marshal.SizeOf(NMH));
                    try
                    {

                        // Copy the struct to unmanaged memory.
                        Marshal.StructureToPtr(NMH, ptrNMH, false);

                        NativeMethods.SendMessage(new HandleRef(this, hWndLV), (uint)Msg.WM_NOTIFY, IntPtr.Zero, ptrNMH);
                        //click again for descending order = newest files first
                        NativeMethods.SendMessage(new HandleRef(this, hWndLV), (uint)Msg.WM_NOTIFY, IntPtr.Zero, ptrNMH);
                    }
                    finally
                    {
                        // Free the unmanaged memory.
                        Marshal.FreeHGlobal(ptrNMH);
                    }



                    ////if wanted give the dialog a larger size here
                    //If DialogXSize > 0 And DialogYSize > 0 Then
                    //   SetWindowPos hWndDlg, 0&, 0&, 0&, DialogXSize, DialogYSize, 0&
                    //End If
                    //}
                    #endregion
                }
            }
            catch (Exception exc)
            {
                _eh.ThrowException(MessageBoxIcon.Error, $"An error has occurred: { exc.Message }", "Error Thrown", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.Control" /> and its child controls and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing"><see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (IsDisposed)
            {
                return;
            }

            if (MSDialog != null)
            {
                MSDialog.FileOk -= new CancelEventHandler(DialogClosing);

                MSDialog.Disposed -= new EventHandler(DialogDisposed);

                MSDialog.HelpRequest -= new EventHandler(HelpRequest);

                MSDialog.Dispose();

                MSDialog = null;
            }

            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        public virtual void OnFileNameChanged(IWin32Window sender, string fileName)
        {
            if (EventFileNameChanged != null)
            {
                EventFileNameChanged(sender, fileName);
            }
        }

        public void OnFolderNameChanged(IWin32Window sender, string folderName)
        {
            if (EventFolderNameChanged != null)
            {
                EventFolderNameChanged(sender, folderName);
            }

            UpdateListView();
        }

        private void UpdateListView()
        {
            _hListViewPtr = NativeMethods.GetDlgItem(_hFileDialogHandle, (int)ControlsId.DefaultView);

            if (FileDlgDefaultViewMode != FolderViewMode.Default && _hFileDialogHandle != IntPtr.Zero)
            {
                NativeMethods.SendMessage(new HandleRef(this, _hListViewPtr), (int)Msg.WM_COMMAND, (IntPtr)(int)FileDlgDefaultViewMode, IntPtr.Zero);

                if (FileDlgDefaultViewMode == FolderViewMode.Details || FileDlgDefaultViewMode == FolderViewMode.List)
                {
                    SortViewByColumn(0);
                }
            }
        }

        internal void OnFilterChanged(IWin32Window sender, int index)
        {
            if (EventFilterChanged != null)
            {
                EventFilterChanged(sender, index);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (DesignMode)
            {
                Graphics g = e.Graphics;
                {
                    HatchBrush hatchBrush = null;

                    Pen pen = null;

                    try
                    {
                        switch (FileDlgStartLocation)
                        {
                            case AddonWindowLocation.Right:
                                hatchBrush = new System.Drawing.Drawing2D.HatchBrush(HatchStyle.NarrowHorizontal, Color.Black, Color.Red);

                                pen = new Pen(hatchBrush, 5);

                                g.DrawLine(pen, 0, 0, 0, this.Height);
                                break;
                            case AddonWindowLocation.Bottom:
                                hatchBrush = new System.Drawing.Drawing2D.HatchBrush(HatchStyle.NarrowVertical, Color.Black, Color.Red);

                                pen = new Pen(hatchBrush, 5);

                                g.DrawLine(pen, 0, 0, this.Width, 0);
                                break;
                            case AddonWindowLocation.BottomRight:
                            default:
                                hatchBrush = new System.Drawing.Drawing2D.HatchBrush(HatchStyle.Sphere, Color.Black, Color.Red);

                                pen = new Pen(hatchBrush, 5);

                                g.DrawLine(pen, 0, 0, 4, 4);
                                break;
                        }
                    }
                    catch (Exception exc)
                    {
                        _eh.ThrowException(MessageBoxIcon.Error, $"An error has occurred: { exc.Message }", "Error Thrown", MessageBoxButtons.OK);
                    }
                    finally
                    {
                        if (pen != null)
                        {
                            pen.Dispose();
                        }

                        if (hatchBrush != null)
                        {
                            hatchBrush.Dispose();
                        }
                    }
                }
            }

            base.OnPaint(e);
        }
        #endregion

        #region Methods
        public DialogResult ShowDialog()
        {
            return ShowDialog(null);
        }

        protected virtual void OnPrepareMSDialog()
        {
            InitMSDialog();
        }
        private void InitMSDialog()
        {
            MSDialog.InitialDirectory = _InitialDirectory.Length == 0 ? Path.GetDirectoryName(Application.ExecutablePath) : _InitialDirectory;

            MSDialog.AddExtension = _AddExtension;

            MSDialog.Filter = _Filter;

            MSDialog.FilterIndex = _FilterIndex;

            MSDialog.CheckFileExists = _CheckFileExists;

            MSDialog.DefaultExt = _DefaultExt;

            MSDialog.FileName = _FileName;

            MSDialog.DereferenceLinks = _DereferenceLinks;

            MSDialog.ShowHelp = _ShowHelp;

            _hasRunInitMSDialog = true;
        }

        public DialogResult ShowDialog(IWin32Window owner)
        {
            DialogResult returnDialogResult = DialogResult.Cancel;
            if (this.IsDisposed)
            {
                return returnDialogResult;
            }

            if (owner == null || owner.Handle == IntPtr.Zero)
            {
                WindowWrapper wr = new WindowWrapper(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle);

                owner = wr;
            }

            OriginalCtrlSize = this.Size;

            _MSdialog = (FileDlgType == FileDialogType.OpenFileDlg) ? new OpenFileDialog() as FileDialog : new SaveFileDialog() as FileDialog;

            _dlgWrapper = new WholeDialogWrapper(this);

            OnPrepareMSDialog();

            if (!_hasRunInitMSDialog)
            {
                InitMSDialog();
            }

            try
            {
                System.Reflection.PropertyInfo AutoUpgradeInfo = MSDialog.GetType().GetProperty("AutoUpgradeEnabled");
                if (AutoUpgradeInfo != null)
                {
                    AutoUpgradeInfo.SetValue(MSDialog, false, null);
                }

                returnDialogResult = _MSdialog.ShowDialog(owner);
            }
            // Sometimes if you open a animated .gif on the preview and the Form is closed, .Net class throw an exception
            // Lets ignore this exception and keep closing the form.
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                _eh.ThrowException(MessageBoxIcon.Error, $"Unable to get the modal dialog handle: { ex.Message }", "Error", MessageBoxButtons.OK);
            }
            return returnDialogResult;
        }

        internal DialogResult ShowDialogExt(FileDialog fdlg, IWin32Window owner)
        {
            DialogResult returnDialogResult = DialogResult.Cancel;
            if (this.IsDisposed)
            {
                return returnDialogResult;
            }

            if (owner == null || owner.Handle == IntPtr.Zero)
            {
                WindowWrapper wr = new WindowWrapper(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle);

                owner = wr;
            }

            OriginalCtrlSize = this.Size;

            MSDialog = fdlg;

            _dlgWrapper = new WholeDialogWrapper(this);

            try
            {
                System.Reflection.PropertyInfo AutoUpgradeInfo = MSDialog.GetType().GetProperty("AutoUpgradeEnabled");

                if (AutoUpgradeInfo != null)
                {
                    AutoUpgradeInfo.SetValue(MSDialog, false, null);
                }

                returnDialogResult = _MSdialog.ShowDialog(owner);
            }
            // Sometimes if you open a animated .gif on the preview and the Form is closed, .Net class throw an exception
            // Lets ignore this exception and keep closing the form.
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                _eh.ThrowException(MessageBoxIcon.Error, $"Unable to get the modal dialog handle: { ex.Message }", "Error", MessageBoxButtons.OK);
            }

            return returnDialogResult;
        }
        #endregion

        #region Event Handlers
        private void DialogDisposed(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void DialogClosing(object sender, CancelEventArgs e)
        {
            if (EventClosingDialog != null)
            {
                EventClosingDialog(this, e);
            }
        }

        private void HelpRequest(object sender, EventArgs e)
        {
            OnHelpRequested(new HelpEventArgs(new Point()));
        }
        #endregion

        #region Helper Types
        public class WindowWrapper : IWin32Window
        {
            private IntPtr _hwnd;

            public WindowWrapper(IntPtr handle)
            {
                _hwnd = handle;
            }

            public IntPtr Handle
            {
                get
                {
                    return _hwnd;
                }
            }
            #endregion
        }
    }
}