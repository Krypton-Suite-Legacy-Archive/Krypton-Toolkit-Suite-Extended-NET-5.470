using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Messageboxes.Enumerations;
using ExtendedControls.Properties;
using KryptonExtendedToolkit.Base.Code;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Messageboxes.Classes
{
    public class ExtendedKryptonMessagebox : KryptonForm
    {
        #region Designer Code
        private void InitializeComponent()
        {
            this.kpnlBackdrop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblMessage = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.kchkOptionalCheck = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kbtnButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kpnlBottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pbxDivider = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).BeginInit();
            this.kpnlBackdrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBottom)).BeginInit();
            this.kpnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDivider)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlBackdrop
            // 
            this.kpnlBackdrop.Controls.Add(this.klblMessage);
            this.kpnlBackdrop.Controls.Add(this.pbxIcon);
            this.kpnlBackdrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackdrop.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackdrop.Name = "kpnlBackdrop";
            this.kpnlBackdrop.Size = new System.Drawing.Size(800, 450);
            this.kpnlBackdrop.TabIndex = 0;
            // 
            // klblMessage
            // 
            this.klblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.klblMessage.Location = new System.Drawing.Point(331, 12);
            this.klblMessage.Name = "klblMessage";
            this.klblMessage.Size = new System.Drawing.Size(205, 21);
            this.klblMessage.StateCommon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMessage.Text = "<#YOUR MESSAGE HERE#>";
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Location = new System.Drawing.Point(12, 12);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(128, 128);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            // 
            // kchkOptionalCheck
            // 
            this.kchkOptionalCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kchkOptionalCheck.Location = new System.Drawing.Point(12, 11);
            this.kchkOptionalCheck.Name = "kchkOptionalCheck";
            this.kchkOptionalCheck.Size = new System.Drawing.Size(101, 26);
            this.kchkOptionalCheck.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkOptionalCheck.TabIndex = 5;
            this.kchkOptionalCheck.Values.Text = "Some Text";
            // 
            // kbtnButton3
            // 
            this.kbtnButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnButton3.AutoSize = true;
            this.kbtnButton3.Location = new System.Drawing.Point(679, 7);
            this.kbtnButton3.Name = "kbtnButton3";
            this.kbtnButton3.Size = new System.Drawing.Size(109, 30);
            this.kbtnButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnButton3.TabIndex = 4;
            this.kbtnButton3.Values.Text = "Button 3 Text";
            // 
            // kbtnButton2
            // 
            this.kbtnButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnButton2.AutoSize = true;
            this.kbtnButton2.Location = new System.Drawing.Point(564, 7);
            this.kbtnButton2.Name = "kbtnButton2";
            this.kbtnButton2.Size = new System.Drawing.Size(109, 30);
            this.kbtnButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnButton2.TabIndex = 3;
            this.kbtnButton2.Values.Text = "Button 2 Text";
            // 
            // kbtnButton1
            // 
            this.kbtnButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnButton1.AutoSize = true;
            this.kbtnButton1.Location = new System.Drawing.Point(449, 7);
            this.kbtnButton1.Name = "kbtnButton1";
            this.kbtnButton1.Size = new System.Drawing.Size(109, 30);
            this.kbtnButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnButton1.TabIndex = 2;
            this.kbtnButton1.Values.Text = "Button 1 Text";
            // 
            // kpnlBottom
            // 
            this.kpnlBottom.Controls.Add(this.kchkOptionalCheck);
            this.kpnlBottom.Controls.Add(this.kbtnButton3);
            this.kpnlBottom.Controls.Add(this.kbtnButton1);
            this.kpnlBottom.Controls.Add(this.kbtnButton2);
            this.kpnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlBottom.Location = new System.Drawing.Point(0, 401);
            this.kpnlBottom.Name = "kpnlBottom";
            this.kpnlBottom.Size = new System.Drawing.Size(800, 49);
            this.kpnlBottom.TabIndex = 1;
            // 
            // pbxDivider
            // 
            this.pbxDivider.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbxDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbxDivider.Location = new System.Drawing.Point(0, 399);
            this.pbxDivider.Name = "pbxDivider";
            this.pbxDivider.Size = new System.Drawing.Size(800, 2);
            this.pbxDivider.TabIndex = 2;
            this.pbxDivider.TabStop = false;
            // 
            // ExtendedKryptonMessagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxDivider);
            this.Controls.Add(this.kpnlBottom);
            this.Controls.Add(this.kpnlBackdrop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtendedKryptonMessagebox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtendedKryptonMessagebox";
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).EndInit();
            this.kpnlBackdrop.ResumeLayout(false);
            this.kpnlBackdrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBottom)).EndInit();
            this.kpnlBottom.ResumeLayout(false);
            this.kpnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDivider)).EndInit();
            this.ResumeLayout(false);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private KryptonPanel kpnlBackdrop;
        private PictureBox pbxIcon;
        private KryptonCheckBox kchkOptionalCheck;
        private KryptonButton kbtnButton3;
        private KryptonButton kbtnButton2;
        private KryptonButton kbtnButton1;
        private KryptonWrapLabel klblMessage;
        private KryptonPanel kpnlBottom;
        private PictureBox pbxDivider;
        private IContainer components = null;
        #endregion

        #region Help Information
        internal class HelpInformation
        {
            #region Properties
            /// <summary>
            /// Gets the HelpFilePath property.
            /// </summary>
            public string HelpFilePath { get; }

            /// <summary>
            /// Gets the Keyword property.
            /// </summary>
            public string Keyword { get; }

            /// <summary>
            /// Gets the Navigator property.
            /// </summary>
            public HelpNavigator Navigator { get; }

            /// <summary>
            /// Gets the Param property.
            /// </summary>
            public object Param { get; }

            #endregion

            public HelpInformation()
            {

            }

            /// <summary>
            /// Initialize a new instance of the HelpInfo class.
            /// </summary>
            /// <param name="helpFilePath">Value for HelpFilePath.</param>
            public HelpInformation(string helpFilePath)
            {
                HelpFilePath = helpFilePath;
            }

            /// <summary>
            /// Initialize a new instance of the HelpInfo class.
            /// </summary>
            /// <param name="helpFilePath">Value for HelpFilePath.</param>
            /// <param name="keyword">Value for Keyword</param>
            public HelpInformation(string helpFilePath, string keyword)
            {
                HelpFilePath = helpFilePath;
                Keyword = keyword;
            }

            /// <summary>
            /// Initialize a new instance of the HelpInfo class.
            /// </summary>
            /// <param name="helpFilePath">Value for HelpFilePath.</param>
            /// <param name="navigator">Value for Navigator</param>
            public HelpInformation(string helpFilePath, HelpNavigator navigator)
            {
                HelpFilePath = helpFilePath;
                Navigator = navigator;
            }

            /// <summary>
            /// Initialize a new instance of the HelpInfo class.
            /// </summary>
            /// <param name="helpFilePath">Value for HelpFilePath.</param>
            /// <param name="navigator">Value for Navigator</param>
            /// <param name="param">Value for Param</param>
            public HelpInformation(string helpFilePath, HelpNavigator navigator, object param)
            {
                HelpFilePath = helpFilePath;
                Navigator = navigator;
                Param = param;
            }
        }
        #endregion

        #region Variables
        private KryptonManager _paletteManager = null;

        private DialogResult _resultButton1, _resultButton2, _resultButton3, _overallResult;

        private KryptonMessageBoxExtendedResult _extendedResult1, _extendedResult2, _extendedResult3, _overallExtendedResult;

        private string _message = string.Empty, _caption = string.Empty, _checkboxText = string.Empty, _checkState, _buttonOneText, _buttonTwoText, _buttonThreeText;

        private StringCollection _buttonTextCustom = new StringCollection();

        private Resources _graphics = new Resources();
        private IWin32Window showOwner;
        private string messageContent;
        private string caption;
        private KryptonMessageBoxExtendedApplicationIconVisibility iconVisibility;
        private KryptonMessageBoxExtendedBorderType borderType;
        private KryptonMessageBoxExtendedBoxButtonCount buttonCount;
        private KryptonMessageBoxExtendedButtons buttons;
        private KryptonMessageBoxExtendedBoxOptions options;
        private KryptonMessageBoxExtendedResult extendedResult;
        private HelpInformation helpInfo;
        private KryptonMessageBoxExtendedDefaultButton defaultButton;
        private KryptonMessageBoxExtendedIcon icon;
        private string[] buttonTextCollection;
        private string checkBoxText;
        private Image customIcon;
        #endregion

        #region Static Fields
        private const int GAP = 10;
        private static readonly int _osMajorVersion;
        #endregion

        #region Properties
        public KryptonMessageBoxExtendedResult ExtendedResultOne { get { return _extendedResult1; } set { _extendedResult1 = value; } }

        public KryptonMessageBoxExtendedResult ExtendedResultTwo { get { return _extendedResult2; } set { _extendedResult2 = value; } }

        public KryptonMessageBoxExtendedResult ExtendedResultThree { get { return _extendedResult3; } set { _extendedResult3 = value; } }

        public KryptonMessageBoxExtendedResult OverallExtendedResult { get { return _overallExtendedResult; } set { _overallExtendedResult = value; } }
        #endregion

        #region Constructor
        static ExtendedKryptonMessagebox()
        {
            _osMajorVersion = Environment.OSVersion.Version.Major;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="showOwner"></param>
        /// <param name="messageContent"></param>
        /// <param name="caption"></param>
        /// <param name="iconVisibility"></param>
        /// <param name="borderType"></param>
        /// <param name="buttonCount"></param>
        /// <param name="buttons"></param>
        /// <param name="options"></param>
        /// <param name="helpInfo"></param>
        /// <param name="defaultButton"></param>
        /// <param name="icon"></param>
        /// <param name="buttonTextCollection"></param>
        /// <param name="checkBoxText"></param>
        /// <param name="customIcon"></param>
        private ExtendedKryptonMessagebox(IWin32Window showOwner, string messageContent, string caption, KryptonMessageBoxExtendedApplicationIconVisibility iconVisibility, KryptonMessageBoxExtendedBorderType borderType, KryptonMessageBoxExtendedBoxButtonCount buttonCount, KryptonMessageBoxExtendedButtons buttons, KryptonMessageBoxExtendedBoxOptions options, HelpInformation helpInfo, KryptonMessageBoxExtendedDefaultButton defaultButton, KryptonMessageBoxExtendedIcon icon, string[] buttonTextCollection, string checkBoxText, Image customIcon)
        {
            this.showOwner = showOwner;
            this.messageContent = messageContent;
            this.caption = caption;
            this.iconVisibility = iconVisibility;
            this.borderType = borderType;
            this.buttonCount = buttonCount;
            this.buttons = buttons;
            this.options = options;
            this.helpInfo = helpInfo;
            this.defaultButton = defaultButton;
            this.icon = icon;
            this.buttonTextCollection = buttonTextCollection;
            this.checkBoxText = checkBoxText;
            this.customIcon = customIcon;

            InitializeComponent();

            UpdateText();

            UpdateCheckBox();

            UpdateBorderStyle();

            UpdateIconVisibility();

            UpdateIconType();

            UpdateButtonCount();

            UpdateButtons();

            UpdateMessageboxDefaultButton();

            UpdateHelp();

            UpdateTextExtra();

            UpdateSizing(showOwner);
        }

        public ExtendedKryptonMessagebox(IWin32Window showOwner, string messageContent, string caption, KryptonMessageBoxExtendedApplicationIconVisibility iconVisibility, KryptonMessageBoxExtendedBorderType borderType, KryptonMessageBoxExtendedBoxButtonCount buttonCount, KryptonMessageBoxExtendedButtons buttons, KryptonMessageBoxExtendedBoxOptions options, KryptonMessageBoxExtendedDefaultButton defaultButton, KryptonMessageBoxExtendedIcon icon, string[] buttonTextCollection, string checkBoxText, Image customIcon)
        {

        }
        #endregion

        #region Show Methods
        /// <summary>
        /// Shows the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static KryptonMessageBoxExtendedResult Show(string text)
        {
            return InternalShow(null, text, string.Empty, KryptonMessageBoxExtendedApplicationIconVisibility.HIDDEN, KryptonMessageBoxExtendedBorderType.FIXED3D, KryptonMessageBoxExtendedBoxButtonCount.ONE, KryptonMessageBoxExtendedButtons.OK, 0, null, KryptonMessageBoxExtendedDefaultButton.BUTTON3);
        }

        public static KryptonMessageBoxExtendedResult Show(IWin32Window owner, string text)
        {
            return InternalShow(owner, text, string.Empty, KryptonMessageBoxExtendedApplicationIconVisibility.HIDDEN, KryptonMessageBoxExtendedBorderType.FIXED3D, KryptonMessageBoxExtendedBoxButtonCount.ONE, KryptonMessageBoxExtendedButtons.OK, 0, null, KryptonMessageBoxExtendedDefaultButton.BUTTON3);
        }

        public static KryptonMessageBoxExtendedResult Show(string text, string caption)
        {
            return InternalShow(null, text, caption, KryptonMessageBoxExtendedApplicationIconVisibility.HIDDEN, KryptonMessageBoxExtendedBorderType.FIXED3D, KryptonMessageBoxExtendedBoxButtonCount.ONE, KryptonMessageBoxExtendedButtons.OK, 0, null, KryptonMessageBoxExtendedDefaultButton.BUTTON3);
        }

        public static KryptonMessageBoxExtendedResult Show(IWin32Window owner, string text, string caption)
        {
            return InternalShow(owner, text, caption, KryptonMessageBoxExtendedApplicationIconVisibility.HIDDEN, KryptonMessageBoxExtendedBorderType.FIXED3D, KryptonMessageBoxExtendedBoxButtonCount.ONE, KryptonMessageBoxExtendedButtons.OK, 0, null, KryptonMessageBoxExtendedDefaultButton.BUTTON3);
        }

        public static KryptonMessageBoxExtendedResult Show(string text, string caption, KryptonMessageBoxExtendedButtons buttons)
        {
            return InternalShow(null, text, caption, KryptonMessageBoxExtendedApplicationIconVisibility.HIDDEN, KryptonMessageBoxExtendedBorderType.FIXED3D, KryptonMessageBoxExtendedBoxButtonCount.ONE, buttons, 0, null, KryptonMessageBoxExtendedDefaultButton.BUTTON3);
        }

        public static KryptonMessageBoxExtendedResult Show(string messageContent, string caption, KryptonMessageBoxExtendedButtons buttons, KryptonMessageBoxExtendedIcon icon)
        {
            return InternalShow(null, messageContent, caption, KryptonMessageBoxExtendedApplicationIconVisibility.VISIBLE, KryptonMessageBoxExtendedBorderType.FIXED3D, KryptonMessageBoxExtendedBoxButtonCount.THREE, buttons, KryptonMessageBoxExtendedBoxOptions.DEFAULTDESKTOPONLY, null, KryptonMessageBoxExtendedDefaultButton.BUTTON3, icon, null, null, null);
        }

        public static KryptonMessageBoxExtendedResult Show(IWin32Window owner, string messageContent, string caption, KryptonMessageBoxExtendedApplicationIconVisibility iconVisibility, KryptonMessageBoxExtendedBorderType borderType, KryptonMessageBoxExtendedBoxButtonCount buttonCount, KryptonMessageBoxExtendedButtons buttons, KryptonMessageBoxExtendedBoxOptions options, string helpInfoPath = null, KryptonMessageBoxExtendedDefaultButton defaultButton = KryptonMessageBoxExtendedDefaultButton.BUTTON1, KryptonMessageBoxExtendedIcon icon = KryptonMessageBoxExtendedIcon.NONE, string[] buttonTextCollection = null, string checkBoxText = null, Image customIcon = null)
        {
            return InternalShow(owner, messageContent, caption, iconVisibility, borderType, buttonCount, buttons, options, new HelpInformation(helpInfoPath), defaultButton, icon, buttonTextCollection, checkBoxText, customIcon);
        }
        #endregion

        #region Methods
        public KryptonMessageBoxExtendedResult ShowDialogExtended(IWin32Window owner)
        {
            Show();

            while (!Disposing)
            {
                Application.DoEvents();
            }

            return extendedResult;
        }

        public string GetButtonText(KryptonButton button)
        {
            return button.Text;
        }
        #endregion

        #region Show Helper
        /// <summary>
        /// Internals the show.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="messageContent">Content of the message.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="iconVisibility">The icon visibility.</param>
        /// <param name="borderType">Type of the border.</param>
        /// <param name="buttonCount">The button count.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="options">The options.</param>
        /// <param name="helpInfo">The help information.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="result">The result.</param>
        /// <param name="buttonTextCollection">The button text collection.</param>
        /// <param name="customIcon">The custom icon.</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">Cannot show modal dialog when non-interactive</exception>
        /// <exception cref="ArgumentException">
        /// Cannot show message box from a service with an owner specified - options
        /// or
        /// Cannot show message box from a service with help specified - options
        /// </exception>
        private static KryptonMessageBoxExtendedResult InternalShow(IWin32Window owner, string messageContent, string caption, KryptonMessageBoxExtendedApplicationIconVisibility iconVisibility, KryptonMessageBoxExtendedBorderType borderType, KryptonMessageBoxExtendedBoxButtonCount buttonCount, KryptonMessageBoxExtendedButtons buttons, KryptonMessageBoxExtendedBoxOptions options, HelpInformation helpInfo = null, KryptonMessageBoxExtendedDefaultButton defaultButton = KryptonMessageBoxExtendedDefaultButton.BUTTON1, KryptonMessageBoxExtendedIcon icon = KryptonMessageBoxExtendedIcon.NONE, string[] buttonTextCollection = null, string checkBoxText = null, Image customIcon = null) // KryptonMessageBoxExtendedResult result = KryptonMessageBoxExtendedResult.OK,
        {
            // Check if trying to show a message box from a non-interactive process, this is not possible
            if (!SystemInformation.UserInteractive && ((options & (KryptonMessageBoxExtendedBoxOptions.SERVICENOTIFICATION | KryptonMessageBoxExtendedBoxOptions.DEFAULTDESKTOPONLY)) == 0))
            {
                throw new InvalidOperationException("Cannot show modal dialog when non-interactive");
            }

            // Check if trying to show a message box from a service and the owner has been specified, this is not possible
            if ((owner != null) && ((options & (KryptonMessageBoxExtendedBoxOptions.SERVICENOTIFICATION | KryptonMessageBoxExtendedBoxOptions.DEFAULTDESKTOPONLY)) != 0))
            {
                throw new ArgumentException(@"Cannot show message box from a service with an owner specified", nameof(options));
            }

            // Check if trying to show a message box from a service and help information is specified, this is not possible
            if ((helpInfo != null) && ((options & (KryptonMessageBoxExtendedBoxOptions.SERVICENOTIFICATION | KryptonMessageBoxExtendedBoxOptions.DEFAULTDESKTOPONLY)) != 0))
            {
                throw new ArgumentException(@"Cannot show message box from a service with help specified", nameof(options));
            }

            // If help information provided or we are not a service/default desktop application then grab an owner for showing the message box
            IWin32Window showOwner = null;
            if ((helpInfo != null) || ((options & (KryptonMessageBoxExtendedBoxOptions.SERVICENOTIFICATION | KryptonMessageBoxExtendedBoxOptions.DEFAULTDESKTOPONLY)) == 0))
            {
                // If do not have an owner passed in then get the active window and use that instead
                showOwner = owner ?? FromHandle(PI.GetActiveWindow());
            }

            using (ExtendedKryptonMessagebox ekmb = new ExtendedKryptonMessagebox(showOwner, messageContent, caption, iconVisibility, borderType, buttonCount, buttons, options, helpInfo, defaultButton, icon, buttonTextCollection, checkBoxText, customIcon))
            {
                ekmb.StartPosition = showOwner == null ? FormStartPosition.CenterScreen : FormStartPosition.CenterParent;

                return ekmb.ShowDialogExtended(showOwner);
            }
        }
        #endregion

        #region Update Methods
        private void UpdateText()
        {
            Text = (string.IsNullOrEmpty(_caption) ? string.Empty : _caption.Split(Environment.NewLine.ToCharArray())[0]);

            klblMessage.Text = messageContent;
        }

        private void UpdateCheckBox()
        {
            if (_checkboxText != string.Empty)
            {
                kchkOptionalCheck.Text = _checkboxText;

                kchkOptionalCheck.Visible = true;
            }
            else
            {
                kchkOptionalCheck.Visible = false;
            }
        }

        private void UpdateBorderStyle()
        {
            switch (borderType)
            {
                case KryptonMessageBoxExtendedBorderType.NONE:
                    FormBorderStyle = FormBorderStyle.None;
                    break;
                case KryptonMessageBoxExtendedBorderType.FIXEDSINGLE:
                    FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;
                case KryptonMessageBoxExtendedBorderType.FIXED3D:
                    FormBorderStyle = FormBorderStyle.Fixed3D;
                    break;
                case KryptonMessageBoxExtendedBorderType.FIXEDDIALOG:
                    FormBorderStyle = FormBorderStyle.FixedDialog;
                    break;
                case KryptonMessageBoxExtendedBorderType.SIZABLE:
                    FormBorderStyle = FormBorderStyle.Sizable;
                    break;
                case KryptonMessageBoxExtendedBorderType.FIXEDTOOLWINDOW:
                    FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    break;
                case KryptonMessageBoxExtendedBorderType.SIZABLETOOLWINDOW:
                    FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    break;
                default:
                    break;
            }
        }

        private void UpdateIconVisibility()
        {
            switch (iconVisibility)
            {
                case KryptonMessageBoxExtendedApplicationIconVisibility.VISIBLE:
                    pbxIcon.Visible = true;

                    klblMessage.Location = new Point(146, 12);
                    break;
                case KryptonMessageBoxExtendedApplicationIconVisibility.HIDDEN:
                    pbxIcon.Visible = false;

                    klblMessage.Location = new Point(12, 12);
                    break;
                default:
                    pbxIcon.Visible = true;

                    klblMessage.Location = new Point(146, 12);
                    break;
            }
        }

        private void UpdateIconType()
        {
            switch (icon)
            {
                case KryptonMessageBoxExtendedIcon.HAND:
                    pbxIcon.Image = Resources.Hand_128_x_128;
                    break;
                case KryptonMessageBoxExtendedIcon.QUESTION:
                    pbxIcon.Image = Resources.Question_128_x_128;
                    break;
                case KryptonMessageBoxExtendedIcon.EXCLAMATION:
                    pbxIcon.Image = Resources.Warning_128_x_128;
                    break;
                case KryptonMessageBoxExtendedIcon.ASTERISK:
                    pbxIcon.Image = Resources.Critical_128_x_128;
                    break;
                case KryptonMessageBoxExtendedIcon.STOP:
                    pbxIcon.Image = Resources.Stop_128_x_128;
                    break;
                case KryptonMessageBoxExtendedIcon.ERROR:
                    pbxIcon.Image = Resources.Critical_128_x_128;
                    break;
                case KryptonMessageBoxExtendedIcon.INFORMATION:
                    pbxIcon.Image = Resources.Information_128_x_128;
                    break;
                case KryptonMessageBoxExtendedIcon.CUSTOM:
                    if (customIcon != null)
                    {
                        pbxIcon.Image = customIcon;
                    }
                    else
                    {
                        pbxIcon.Visible = false;

                        klblMessage.Location = new Point(12, 12);
                    }
                    break;
                case KryptonMessageBoxExtendedIcon.CRITICAL:
                    pbxIcon.Image = Resources.Critical;
                    break;
                case KryptonMessageBoxExtendedIcon.OK:
                    pbxIcon.Image = Resources.Ok;
                    break;
                case KryptonMessageBoxExtendedIcon.NONE:
                    pbxIcon.Visible = false;

                    klblMessage.Location = new Point(12, 12);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Updates the button count.
        /// </summary>
        private void UpdateButtonCount()
        {
            switch (buttonCount)
            {
                case KryptonMessageBoxExtendedBoxButtonCount.ONE:
                    kbtnButton1.Visible = false;

                    kbtnButton2.Visible = false;

                    kbtnButton3.Visible = true;
                    break;
                case KryptonMessageBoxExtendedBoxButtonCount.TWO:
                    kbtnButton1.Visible = false;

                    kbtnButton2.Visible = true;

                    kbtnButton3.Visible = true;
                    break;
                case KryptonMessageBoxExtendedBoxButtonCount.THREE:
                    kbtnButton1.Visible = true;

                    kbtnButton2.Visible = true;

                    kbtnButton3.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void UpdateButtonCount(KryptonMessageBoxExtendedBoxButtonCount buttonCount)
        {
            switch (buttonCount)
            {
                case KryptonMessageBoxExtendedBoxButtonCount.ONE:
                    kbtnButton1.Visible = false;

                    kbtnButton2.Visible = false;

                    kbtnButton3.Visible = true;
                    break;
                case KryptonMessageBoxExtendedBoxButtonCount.TWO:
                    kbtnButton1.Visible = false;

                    kbtnButton2.Visible = true;

                    kbtnButton3.Visible = true;
                    break;
                case KryptonMessageBoxExtendedBoxButtonCount.THREE:
                    kbtnButton1.Visible = true;

                    kbtnButton2.Visible = true;

                    kbtnButton3.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void UpdateButtons()
        {
            switch (buttons)
            {
                case KryptonMessageBoxExtendedButtons.OK:
                    kbtnButton3.Text = "&Ok";
                    break;
                case KryptonMessageBoxExtendedButtons.OKCANCEL:
                    kbtnButton2.Text = "&Ok";

                    kbtnButton3.Text = "C&ancel";
                    break;
                case KryptonMessageBoxExtendedButtons.YESNO:
                    kbtnButton2.Text = "&Yes";

                    kbtnButton3.Text = "N&o";
                    break;
                case KryptonMessageBoxExtendedButtons.YESNOCANCEL:
                    kbtnButton1.Text = "&Yes";

                    kbtnButton2.Text = "N&o";

                    kbtnButton3.Text = "C&ancel";
                    break;
                case KryptonMessageBoxExtendedButtons.RETRY:
                    kbtnButton3.Text = "R&etry";
                    break;
                case KryptonMessageBoxExtendedButtons.ABORT:
                    kbtnButton3.Text = "A&bort";
                    break;
                case KryptonMessageBoxExtendedButtons.RETRYABORT:
                    kbtnButton2.Text = "R&etry";

                    kbtnButton3.Text = "A&bort";
                    break;
                case KryptonMessageBoxExtendedButtons.RETRYABORTCANCEL:
                    kbtnButton1.Text = "R&etry";

                    kbtnButton2.Text = "A&bort";

                    kbtnButton3.Text = "C&ancel";
                    break;
                case KryptonMessageBoxExtendedButtons.CUSTOM:
                    if (_buttonTextCustom == null || buttonTextCollection != null)
                    {
                        foreach (string buttonText in buttonTextCollection)
                        {
                            _buttonTextCustom.Add(buttonText);
                        }
                    }

                    string[] tmp;

                    foreach (string itemText in _buttonTextCustom)
                    {
                        tmp = new string[] { itemText };

                        if (buttonCount == KryptonMessageBoxExtendedBoxButtonCount.ONE)
                        {
                            kbtnButton3.Text = tmp[2];
                        }
                        else if (buttonCount == KryptonMessageBoxExtendedBoxButtonCount.TWO)
                        {
                            kbtnButton2.Text = tmp[1];

                            kbtnButton3.Text = tmp[3];
                        }
                        else if (buttonCount == KryptonMessageBoxExtendedBoxButtonCount.THREE)
                        {
                            kbtnButton1.Text = tmp[0];

                            kbtnButton2.Text = tmp[1];

                            kbtnButton3.Text = tmp[2];
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void UpdateButtons(KryptonMessageBoxExtendedButtons buttons)
        {
            switch (buttons)
            {
                case KryptonMessageBoxExtendedButtons.OK:
                    UpdateButtonCount(KryptonMessageBoxExtendedBoxButtonCount.ONE);

                    kbtnButton3.Text = "&Ok";
                    break;
                case KryptonMessageBoxExtendedButtons.OKCANCEL:
                    UpdateButtonCount(KryptonMessageBoxExtendedBoxButtonCount.TWO);

                    kbtnButton2.Text = "&Ok";

                    kbtnButton3.Text = "C&ancel";
                    break;
                case KryptonMessageBoxExtendedButtons.YESNO:
                    UpdateButtonCount(KryptonMessageBoxExtendedBoxButtonCount.TWO);

                    kbtnButton2.Text = "&Yes";

                    kbtnButton3.Text = "N&o";
                    break;
                case KryptonMessageBoxExtendedButtons.YESNOCANCEL:
                    UpdateButtonCount(KryptonMessageBoxExtendedBoxButtonCount.THREE);

                    kbtnButton1.Text = "&Yes";

                    kbtnButton2.Text = "N&o";

                    kbtnButton3.Text = "C&ancel";
                    break;
                case KryptonMessageBoxExtendedButtons.RETRY:
                    UpdateButtonCount(KryptonMessageBoxExtendedBoxButtonCount.ONE);

                    kbtnButton3.Text = "R&etry";
                    break;
                case KryptonMessageBoxExtendedButtons.ABORT:
                    UpdateButtonCount(KryptonMessageBoxExtendedBoxButtonCount.ONE);

                    kbtnButton3.Text = "A&bort";
                    break;
                case KryptonMessageBoxExtendedButtons.RETRYABORT:
                    UpdateButtonCount(KryptonMessageBoxExtendedBoxButtonCount.TWO);

                    kbtnButton2.Text = "R&etry";

                    kbtnButton3.Text = "A&bort";
                    break;
                case KryptonMessageBoxExtendedButtons.RETRYABORTCANCEL:
                    UpdateButtonCount(KryptonMessageBoxExtendedBoxButtonCount.THREE);

                    kbtnButton1.Text = "R&etry";

                    kbtnButton2.Text = "A&bort";

                    kbtnButton3.Text = "C&ancel";
                    break;
                case KryptonMessageBoxExtendedButtons.CUSTOM:
                    if (_buttonTextCustom == null || buttonTextCollection != null)
                    {
                        foreach (string buttonText in buttonTextCollection)
                        {
                            _buttonTextCustom.Add(buttonText);
                        }
                    }

                    string[] tmp;

                    foreach (string itemText in _buttonTextCustom)
                    {
                        tmp = new string[] { itemText };

                        if (buttonCount == KryptonMessageBoxExtendedBoxButtonCount.ONE)
                        {
                            kbtnButton3.Text = tmp[2];
                        }
                        else if (buttonCount == KryptonMessageBoxExtendedBoxButtonCount.TWO)
                        {
                            kbtnButton2.Text = tmp[1];

                            kbtnButton3.Text = tmp[3];
                        }
                        else if (buttonCount == KryptonMessageBoxExtendedBoxButtonCount.THREE)
                        {
                            kbtnButton1.Text = tmp[0];

                            kbtnButton2.Text = tmp[1];

                            kbtnButton3.Text = tmp[2];
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void UpdateMessageboxDefaultButton()
        {
            switch (defaultButton)
            {
                case KryptonMessageBoxExtendedDefaultButton.BUTTON1:
                    if (buttonCount == KryptonMessageBoxExtendedBoxButtonCount.TWO)
                    {
                        AcceptButton = kbtnButton2;
                    }
                    else
                    {
                        AcceptButton = kbtnButton1;
                    }
                    break;
                case KryptonMessageBoxExtendedDefaultButton.BUTTON2:
                    AcceptButton = kbtnButton2;
                    break;
                case KryptonMessageBoxExtendedDefaultButton.BUTTON3:
                    AcceptButton = kbtnButton3;
                    break;
                default:
                    break;
            }
        }

        private void UpdateHelp()
        {

        }

        private void UpdateTextExtra()
        {

        }

        private void UpdateSizing(IWin32Window owner)
        {

        }
        #endregion

        #region Setters & Getters
        /// <summary>
        /// Sets the ExtendedResultOne to the value of extendedResultOne.
        /// </summary>
        /// <param name="extendedResultOne">The value of extendedResultOne.</param>
        public void SetExtendedResultOne(KryptonMessageBoxExtendedResult extendedResultOne)
        {
            ExtendedResultOne = extendedResultOne;
        }

        /// <summary>
        /// Gets the ExtendedResultOne value.
        /// </summary>
        /// <returns>The value of extendedResultOne.</returns>
        public KryptonMessageBoxExtendedResult GetExtendedResultOne()
        {
            return ExtendedResultOne;
        }

        /// <summary>
        /// Sets the ExtendedResultTwo to the value of extendedResultTwo.
        /// </summary>
        /// <param name="extendedResultTwo">The value of extendedResultTwo.</param>
        public void SetExtendedResultTwo(KryptonMessageBoxExtendedResult extendedResultTwo)
        {
            ExtendedResultTwo = extendedResultTwo;
        }

        /// <summary>
        /// Gets the ExtendedResultTwo value.
        /// </summary>
        /// <returns>The value of extendedResultTwo.</returns>
        public KryptonMessageBoxExtendedResult GetExtendedResultTwo()
        {
            return ExtendedResultTwo;
        }

        /// <summary>
        /// Sets the ExtendedResultThree to the value of extendedResultThree.
        /// </summary>
        /// <param name="extendedResultThree">The value of extendedResultThree.</param>
        public void SetExtendedResultThree(KryptonMessageBoxExtendedResult extendedResultThree)
        {
            ExtendedResultThree = extendedResultThree;
        }

        /// <summary>
        /// Gets the ExtendedResultThree value.
        /// </summary>
        /// <returns>The value of extendedResultThree.</returns>
        public KryptonMessageBoxExtendedResult GetExtendedResultThree()
        {
            return ExtendedResultThree;
        }
        #endregion
    }
}