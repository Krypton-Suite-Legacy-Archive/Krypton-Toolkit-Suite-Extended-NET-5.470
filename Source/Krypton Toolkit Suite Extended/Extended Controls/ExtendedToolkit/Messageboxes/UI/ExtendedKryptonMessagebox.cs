using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Messageboxes.Enumerations;
using ExtendedControls.Properties;
using KryptonExtendedToolkit.Base.Code;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonExtendedToolkit.ExtendedToolkit.Messageboxes.UI
{
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(KryptonMessageBox))]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public partial class ExtendedKryptonMessagebox : KryptonForm
    {
        #region HelpInfo Class
        public class HelpInfo
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

            #region Constructors
            /// <summary>
            /// Initialize a new instance of the HelpInfo class.
            /// </summary>
            public HelpInfo()
            {
            }

            /// <summary>
            /// Initialize a new instance of the HelpInfo class.
            /// </summary>
            /// <param name="helpFilePath">Value for HelpFilePath.</param>
            public HelpInfo(string helpFilePath)
            {
                HelpFilePath = helpFilePath;
            }

            /// <summary>
            /// Initialize a new instance of the HelpInfo class.
            /// </summary>
            /// <param name="helpFilePath">Value for HelpFilePath.</param>
            /// <param name="keyword">Value for Keyword</param>
            public HelpInfo(string helpFilePath, string keyword)
            {
                HelpFilePath = helpFilePath;
                Keyword = keyword;
            }

            /// <summary>
            /// Initialize a new instance of the HelpInfo class.
            /// </summary>
            /// <param name="helpFilePath">Value for HelpFilePath.</param>
            /// <param name="navigator">Value for Navigator</param>
            public HelpInfo(string helpFilePath, HelpNavigator navigator)
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
            public HelpInfo(string helpFilePath, HelpNavigator navigator, object param)
            {
                HelpFilePath = helpFilePath;
                Navigator = navigator;
                Param = param;
            }
            #endregion
        }

        [ToolboxItem(false)]
        internal class MessageButton : KryptonButton
        {
            #region Instance Fields

            #endregion

            #region Identity
            /// <summary>
            /// Gets and sets the ignoring of Alt+F4
            /// </summary>
            public bool IgnoreAltF4 { get; set; }

            #endregion

            #region Protected
            /// <summary>
            /// Processes Windows messages.
            /// </summary>
            /// <param name="m">The Windows Message to process. </param>
            protected override void WndProc(ref Message m)
            {
                switch (m.Msg)
                {
                    case PI.WM_KEYDOWN:
                    case PI.WM_SYSKEYDOWN:
                        if (IgnoreAltF4)
                        {
                            // Extract the keys being pressed
                            Keys keys = ((Keys)((int)m.WParam.ToInt64()));

                            // If the user standard combination ALT + F4
                            if ((keys == Keys.F4) && ((ModifierKeys & Keys.Alt) == Keys.Alt))
                            {
                                // Eat the message, so standard window proc does not close the window
                                return;
                            }
                        }
                        break;
                }

                base.WndProc(ref m);
            }
            #endregion

        }
        #endregion

        #region Variables
        private KryptonManager _paletteManager = null;

        private DialogResult _resultButton1, _resultButton2, _resultButton3, _overallResult;

        private string _message = string.Empty, _caption = string.Empty, _checkboxText = string.Empty, _checkState, _buttonOneText, _buttonTwoText, _buttonThreeText;

        private StringCollection _buttonTextCustom = new StringCollection();

        private Resources _graphics = new Resources();
        private IWin32Window showOwner;
        private string messageContent;
        private KryptonMessageBoxExtendedApplicationIconVisibility _iconVisibility;
        private KryptonMessageBoxExtendedBorderType _borderType;
        private KryptonMessageBoxExtendedBoxButtonCount _buttonCount;
        private KryptonMessageBoxExtendedButtons _buttons;
        private KryptonMessageBoxExtendedBoxOptions _options;
        private HelpInfo _helpInfo;
        private KryptonMessageBoxExtendedDefaultButton _defaultButton;
        private KryptonMessageBoxExtendedIcon _icon;
        private string[] _buttonTextCollection;
        private Image _customIcon;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets PaletteManager.
        /// </summary>
        /// <value>
        /// _paletteManager.
        /// </value>
        public KryptonManager PaletteManager
        {
            get
            {
                return _paletteManager;
            }


            set
            {
                _paletteManager = value;
            }
        }

        /// <summary>
        /// Gets or sets ButtonResultOne.
        /// </summary>
        /// <value>
        /// _result1.
        /// </value>
        public DialogResult ButtonResultOne
        {
            get
            {
                return _resultButton1;
            }


            set
            {
                _resultButton1 = value;
            }
        }

        /// <summary>
        /// Gets or sets ButtonResultTwo.
        /// </summary>
        /// <value>
        /// _resultButton2.
        /// </value>
        public DialogResult ButtonResultTwo
        {
            get
            {
                return _resultButton2;
            }


            set
            {
                _resultButton2 = value;
            }
        }

        /// <summary>
        /// Gets or sets ButtonResultThree.
        /// </summary>
        /// <value>
        /// _resultButton3.
        /// </value>
        public DialogResult ButtonResultThree
        {
            get
            {
                return _resultButton3;
            }


            set
            {
                _resultButton3 = value;
            }
        }

        /// <summary>
        /// Gets or sets OverallResult.
        /// </summary>
        /// <value>
        /// _overallResult.
        /// </value>
        public DialogResult OverallResult
        {
            get
            {
                return _overallResult;
            }


            set
            {
                _overallResult = value;
            }
        }

        public string Message { get { return _message; } set { _message = value; } }

        public string Caption { get { return _caption; } set { _caption = value; } }

        public string CheckboxText { get { return _checkboxText; } set { _checkboxText = value; } }
        #endregion

        #region Constructors

        #region UNUSED CODE
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedKryptonMessagebox" /> class.
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
        /// <param name="buttonTextCollection">The button text collection.</param>
        /// <param name="checkBoxText">The check box text.</param>
        /// <param name="customIcon">The custom icon.</param>
        //public ExtendedKryptonMessagebox(string message, string caption, KryptonMessageBoxExtendedApplicationIconVisibility iconVisibility, KryptonMessageBoxExtendedBorderType borderType, KryptonMessageBoxExtendedBoxButtonCount buttonCount, KryptonMessageBoxExtendedButtons buttons, KryptonMessageBoxExtendedDefaultButton defaultButton = KryptonMessageBoxExtendedDefaultButton.BUTTON1, KryptonMessageBoxExtendedIcon icon = KryptonMessageBoxExtendedIcon.NONE, KryptonMessageBoxExtendedResult result = KryptonMessageBoxExtendedResult.OK, string[] buttonTextCollection = null, Image customIcon = null)
        //{
        //    InitializeComponent();

        //    SetMessage(message);

        //    SetCaption(caption);

        //    #region Icon Visibility
        //    switch (iconVisibility)
        //    {
        //        case KryptonMessageBoxExtendedApplicationIconVisibility.VISIBLE:
        //            pbxIcon.Visible = true;

        //            klblMessage.Location = new Point(146, 12);
        //            break;
        //        case KryptonMessageBoxExtendedApplicationIconVisibility.HIDDEN:
        //            pbxIcon.Visible = false;

        //            klblMessage.Location = new Point(12, 12);
        //            break;
        //        default:
        //            pbxIcon.Visible = true;

        //            klblMessage.Location = new Point(146, 12);
        //            break;
        //    }
        //    #endregion

        //    #region Border Types
        //    switch (borderType)
        //    {
        //        case KryptonMessageBoxExtendedBorderType.NONE:
        //            FormBorderStyle = FormBorderStyle.None;
        //            break;
        //        case KryptonMessageBoxExtendedBorderType.FIXEDSINGLE:
        //            FormBorderStyle = FormBorderStyle.FixedSingle;
        //            break;
        //        case KryptonMessageBoxExtendedBorderType.FIXED3D:
        //            FormBorderStyle = FormBorderStyle.Fixed3D;
        //            break;
        //        case KryptonMessageBoxExtendedBorderType.FIXEDDIALOG:
        //            FormBorderStyle = FormBorderStyle.FixedDialog;
        //            break;
        //        case KryptonMessageBoxExtendedBorderType.SIZABLE:
        //            FormBorderStyle = FormBorderStyle.Sizable;
        //            break;
        //        case KryptonMessageBoxExtendedBorderType.FIXEDTOOLWINDOW:
        //            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        //            break;
        //        case KryptonMessageBoxExtendedBorderType.SIZABLETOOLWINDOW:
        //            FormBorderStyle = FormBorderStyle.SizableToolWindow;
        //            break;
        //        default:
        //            break;
        //    }
        //    #endregion

        //    #region Button Count
        //    SetButtonCount(buttonCount);
        //    #endregion

        //    #region Buttons
        //    switch (buttons)
        //    {
        //        case KryptonMessageBoxExtendedButtons.OK:
        //            SetButtonCount(KryptonMessageBoxExtendedBoxButtonCount.ONE);

        //            kbtnButton3.Text = "&Ok";
        //            break;
        //        case KryptonMessageBoxExtendedButtons.OKCANCEL:
        //            SetButtonCount(KryptonMessageBoxExtendedBoxButtonCount.TWO);

        //            kbtnButton2.Text = "&Ok";

        //            kbtnButton3.Text = "C&ancel";
        //            break;
        //        case KryptonMessageBoxExtendedButtons.YESNO:
        //            SetButtonCount(KryptonMessageBoxExtendedBoxButtonCount.TWO);

        //            kbtnButton2.Text = "&Yes";

        //            kbtnButton3.Text = "N&o";
        //            break;
        //        case KryptonMessageBoxExtendedButtons.YESNOCANCEL:
        //            SetButtonCount(KryptonMessageBoxExtendedBoxButtonCount.THREE);

        //            kbtnButton1.Text = "&Yes";

        //            kbtnButton2.Text = "N&o";

        //            kbtnButton3.Text = "C&ancel";
        //            break;
        //        case KryptonMessageBoxExtendedButtons.RETRY:
        //            SetButtonCount(KryptonMessageBoxExtendedBoxButtonCount.ONE);

        //            kbtnButton3.Text = "R&etry";
        //            break;
        //        case KryptonMessageBoxExtendedButtons.ABORT:
        //            SetButtonCount(KryptonMessageBoxExtendedBoxButtonCount.ONE);

        //            kbtnButton3.Text = "A&bort";
        //            break;
        //        case KryptonMessageBoxExtendedButtons.RETRYABORT:
        //            SetButtonCount(KryptonMessageBoxExtendedBoxButtonCount.TWO);

        //            kbtnButton2.Text = "R&etry";

        //            kbtnButton3.Text = "A&bort";
        //            break;
        //        case KryptonMessageBoxExtendedButtons.RETRYABORTCANCEL:
        //            SetButtonCount(KryptonMessageBoxExtendedBoxButtonCount.THREE);

        //            kbtnButton1.Text = "R&etry";

        //            kbtnButton2.Text = "A&bort";

        //            kbtnButton3.Text = "C&ancel";
        //            break;
        //        case KryptonMessageBoxExtendedButtons.CUSTOM:
        //            SetButtonCount(buttonCount);

        //            if (_buttonTextCustom == null || buttonTextCollection != null)
        //            {
        //                foreach (string buttonText in buttonTextCollection)
        //                {
        //                    _buttonTextCustom.Add(buttonText);
        //                }
        //            }

        //            string[] tmp;

        //            foreach (string itemText in _buttonTextCustom)
        //            {
        //                tmp = new string[] { itemText };

        //                if (buttonCount == KryptonMessageBoxExtendedBoxButtonCount.ONE)
        //                {
        //                    kbtnButton3.Text = tmp[2];
        //                }
        //                else if (buttonCount == KryptonMessageBoxExtendedBoxButtonCount.TWO)
        //                {
        //                    kbtnButton2.Text = tmp[1];

        //                    kbtnButton3.Text = tmp[3];
        //                }
        //                else if (buttonCount == KryptonMessageBoxExtendedBoxButtonCount.THREE)
        //                {
        //                    kbtnButton1.Text = tmp[0];

        //                    kbtnButton2.Text = tmp[1];

        //                    kbtnButton3.Text = tmp[2];
        //                }
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //    #endregion

        //    #region Default Button
        //    switch (defaultButton)
        //    {
        //        case KryptonMessageBoxExtendedDefaultButton.BUTTON1:
        //            AcceptButton = kbtnButton1;
        //            break;
        //        case KryptonMessageBoxExtendedDefaultButton.BUTTON2:
        //            AcceptButton = kbtnButton2;
        //            break;
        //        case KryptonMessageBoxExtendedDefaultButton.BUTTON3:
        //            AcceptButton = kbtnButton3;
        //            break;
        //        default:
        //            break;
        //    }
        //    #endregion

        //    #region Icon
        //    switch (icon)
        //    {
        //        case KryptonMessageBoxExtendedIcon.HAND:
        //            pbxIcon.Image = Resources.Hand;
        //            break;
        //        case KryptonMessageBoxExtendedIcon.QUESTION:
        //            pbxIcon.Image = Resources.Question;
        //            break;
        //        case KryptonMessageBoxExtendedIcon.EXCLAMATION:
        //            pbxIcon.Image = Resources.Warning_2;
        //            break;
        //        case KryptonMessageBoxExtendedIcon.ASTERISK:
        //            pbxIcon.Image = Resources.Critical;
        //            break;
        //        case KryptonMessageBoxExtendedIcon.STOP:
        //            pbxIcon.Image = Resources.Stop;
        //            break;
        //        case KryptonMessageBoxExtendedIcon.ERROR:
        //            pbxIcon.Image = Resources.Critical;
        //            break;
        //        case KryptonMessageBoxExtendedIcon.INFORMATION:
        //            pbxIcon.Image = Resources.Information_2;
        //            break;
        //        case KryptonMessageBoxExtendedIcon.CUSTOM:
        //            if (customIcon != null)
        //            {
        //                pbxIcon.Image = customIcon;
        //            }
        //            else
        //            {
        //                pbxIcon.Visible = false;

        //                klblMessage.Location = new Point(12, 12);
        //            }
        //            break;
        //        case KryptonMessageBoxExtendedIcon.CRITICAL:
        //            pbxIcon.Image = Resources.Critical;
        //            break;
        //        case KryptonMessageBoxExtendedIcon.OK:
        //            pbxIcon.Image = Resources.Ok;
        //            break;
        //        case KryptonMessageBoxExtendedIcon.NONE:
        //            pbxIcon.Visible = false;

        //            klblMessage.Location = new Point(12, 12);
        //            break;
        //        default:
        //            break;
        //    }
        //    #endregion
        //}
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedKryptonMessagebox"/> class.
        /// </summary>
        public ExtendedKryptonMessagebox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedKryptonMessagebox"/> class.
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
        /// <param name="buttonTextCollection">The button text collection.</param>
        /// <param name="checkBoxText">The check box text.</param>
        /// <param name="customIcon">The custom icon.</param>
        public ExtendedKryptonMessagebox(IWin32Window owner, string messageContent, string caption, KryptonMessageBoxExtendedApplicationIconVisibility iconVisibility, KryptonMessageBoxExtendedBorderType borderType, KryptonMessageBoxExtendedBoxButtonCount buttonCount, KryptonMessageBoxExtendedButtons buttons, KryptonMessageBoxExtendedBoxOptions options, HelpInfo helpInfo = null, KryptonMessageBoxExtendedDefaultButton defaultButton = KryptonMessageBoxExtendedDefaultButton.BUTTON1, KryptonMessageBoxExtendedIcon icon = KryptonMessageBoxExtendedIcon.NONE, string[] buttonTextCollection = null, string checkBoxText = null, Image customIcon = null)
        {
            _message = messageContent;

            _caption = caption;

            _iconVisibility = iconVisibility;

            _borderType = borderType;

            _buttonCount = buttonCount;

            _buttons = buttons;

            _options = options;

            _helpInfo = helpInfo;

            _defaultButton = defaultButton;

            _icon = icon;

            _buttonTextCollection = buttonTextCollection;

            _checkboxText = checkBoxText;

            _customIcon = customIcon;

            InitializeComponent();
        }
        #endregion

        private void SetButtonCount(KryptonMessageBoxExtendedBoxButtonCount buttonCount)
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

        #region Show Methods
        /// <summary>
        /// Shows the specified messagebox title.
        /// </summary>
        /// <param name="messageboxTitle">The messagebox title.</param>
        /// <param name="messageboxText">The messagebox text.</param>
        /// <param name="buttonCount">The button count.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="result">The result.</param>
        /// <param name="kryptonButtonText1">The krypton button text1.</param>
        /// <param name="kryptonButtonText2">The krypton button text2.</param>
        /// <param name="kryptonButtonText3">The krypton button text3.</param>
        public void Show(string messageboxTitle, string messageboxText, KryptonMessageBoxExtendedBoxButtonCount buttonCount = KryptonMessageBoxExtendedBoxButtonCount.ONE, KryptonMessageBoxExtendedButtons buttons = KryptonMessageBoxExtendedButtons.OK, KryptonMessageBoxExtendedResult result = KryptonMessageBoxExtendedResult.OK, string kryptonButtonText1 = null, string kryptonButtonText2 = null, string kryptonButtonText3 = null)
        {
            Text = messageboxTitle;

            pbxIcon.Visible = false;

            klblMessage.Location = new Point(12, 12);

            klblMessage.Text = messageboxText;

            AssignButtonDialogResults(result);

            SetButtonText(buttons, kryptonButtonText1, kryptonButtonText2, kryptonButtonText3, buttonCount);
        }

        /// <summary>
        /// Shows the specified messagebox title.
        /// </summary>
        /// <param name="messageboxTitle">The messagebox title.</param>
        /// <param name="messageBoxText">The message box text.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <param name="kryptonButtonText1">The krypton button text1.</param>
        /// <param name="kryptonButtonText2">The krypton button text2.</param>
        /// <param name="kryptonButtonText3">The krypton button text3.</param>
        public void Show(string messageboxTitle, string messageBoxText, KryptonMessageBoxExtendedButtons buttons, KryptonMessageBoxExtendedIcon icon, KryptonMessageBoxExtendedDefaultButton defaultButton = KryptonMessageBoxExtendedDefaultButton.BUTTON1, string kryptonButtonText1 = null, string kryptonButtonText2 = null, string kryptonButtonText3 = null, string iconCustomFileName = null, KryptonMessageBoxExtendedBoxButtonCount buttonCount = KryptonMessageBoxExtendedBoxButtonCount.ONE)
        {
            Text = messageboxTitle;

            klblMessage.Text = messageBoxText;

            SetButtonText(buttons, kryptonButtonText1, kryptonButtonText2, kryptonButtonText3, buttonCount);

            #region Messagebox Icons
            switch (icon)
            {
                case KryptonMessageBoxExtendedIcon.HAND:
                    pbxIcon.Image = new Bitmap(Resources.if_Symbol_Stop_49267);
                    break;
                case KryptonMessageBoxExtendedIcon.QUESTION:
                    pbxIcon.Image = new Bitmap(Resources.if_Symbol_Help_49263);
                    break;
                case KryptonMessageBoxExtendedIcon.EXCLAMATION:
                    pbxIcon.Image = new Bitmap(Resources.if_Symbol_Exclamation_49262);
                    break;
                case KryptonMessageBoxExtendedIcon.ASTERISK:
                    pbxIcon.Image = new Bitmap(Resources.if_Symbol_Restricted_49266);
                    break;
                case KryptonMessageBoxExtendedIcon.STOP:
                    pbxIcon.Image = new Bitmap(Resources.if_Symbol_Stop_49267);
                    break;
                case KryptonMessageBoxExtendedIcon.ERROR:
                    pbxIcon.Image = new Bitmap(Resources.if_Symbol_Error_49261);
                    break;
                case KryptonMessageBoxExtendedIcon.INFORMATION:
                    pbxIcon.Image = new Bitmap(Resources.if_Symbol_Information_49264);
                    break;
                case KryptonMessageBoxExtendedIcon.CUSTOM:
                    if (iconCustomFileName != null)
                    {
                        pbxIcon.Image = new Bitmap(iconCustomFileName);
                    }
                    else
                    {
                        pbxIcon.Visible = false;

                        klblMessage.Location = new Point(12, 12);
                    }
                    break;
                case KryptonMessageBoxExtendedIcon.CRITICAL:
                    pbxIcon.Image = new Bitmap(Resources.if_Symbol_Error_49261);
                    break;
                case KryptonMessageBoxExtendedIcon.OK:
                    pbxIcon.Image = new Bitmap(Resources.Check);
                    break;
                case KryptonMessageBoxExtendedIcon.NONE:
                    pbxIcon.Visible = false;

                    klblMessage.Location = new Point(12, 12);
                    break;
            }
            #endregion

            SetDefaultButton(defaultButton);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Assigns the button dialog results.
        /// </summary>
        /// <param name="result">The result.</param>
        private void AssignButtonDialogResults(KryptonMessageBoxExtendedResult result)
        {
            switch (result)
            {
                case KryptonMessageBoxExtendedResult.CANCEL:
                    kbtnButton3.DialogResult = DialogResult.Cancel;
                    break;
                case KryptonMessageBoxExtendedResult.NO:
                    kbtnButton3.DialogResult = DialogResult.No;
                    break;
                case KryptonMessageBoxExtendedResult.NONE:
                    kbtnButton3.DialogResult = DialogResult.None;
                    break;
                case KryptonMessageBoxExtendedResult.OK:
                    kbtnButton3.DialogResult = DialogResult.OK;
                    break;
                case KryptonMessageBoxExtendedResult.YES:
                    kbtnButton3.DialogResult = DialogResult.Yes;
                    break;
                case KryptonMessageBoxExtendedResult.YESNO:
                    kbtnButton2.DialogResult = DialogResult.Yes;

                    kbtnButton3.DialogResult = DialogResult.No;
                    break;
                case KryptonMessageBoxExtendedResult.RETRY:
                    kbtnButton3.DialogResult = DialogResult.Retry;
                    break;
                case KryptonMessageBoxExtendedResult.ABORT:
                    kbtnButton3.DialogResult = DialogResult.Abort;
                    break;
                case KryptonMessageBoxExtendedResult.RETRYABORT:
                    kbtnButton2.DialogResult = DialogResult.Retry;

                    kbtnButton3.DialogResult = DialogResult.Abort;
                    break;
                case KryptonMessageBoxExtendedResult.RETRYABORTCANCEL:
                    kbtnButton1.DialogResult = DialogResult.Retry;

                    kbtnButton2.DialogResult = DialogResult.Abort;

                    kbtnButton3.DialogResult = DialogResult.Cancel;
                    break;
                case KryptonMessageBoxExtendedResult.CUSTOM:
                    // Just default to ok
                    kbtnButton1.DialogResult = DialogResult.OK;

                    kbtnButton2.DialogResult = DialogResult.OK;

                    kbtnButton3.DialogResult = DialogResult.OK;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Sets the button text.
        /// </summary>
        /// <param name="buttons">The buttons.</param>
        /// <param name="kryptonButtonText1">The krypton button text1.</param>
        /// <param name="kryptonButtonText2">The krypton button text2.</param>
        /// <param name="kryptonButtonText3">The krypton button text3.</param>
        /// <param name="buttonCount">The button count.</param>
        public void SetButtonText(KryptonMessageBoxExtendedButtons buttons, string kryptonButtonText1 = null, string kryptonButtonText2 = null, string kryptonButtonText3 = null, KryptonMessageBoxExtendedBoxButtonCount buttonCount = KryptonMessageBoxExtendedBoxButtonCount.THREE)
        {
            switch (buttons)
            {
                case KryptonMessageBoxExtendedButtons.OK:
                    kbtnButton1.Visible = false;

                    kbtnButton2.Visible = false;

                    kbtnButton3.Text = "&Ok";
                    break;
                case KryptonMessageBoxExtendedButtons.OKCANCEL:
                    kbtnButton1.Visible = false;

                    kbtnButton2.Text = "&Ok";

                    kbtnButton3.Text = "C&ancel";
                    break;
                case KryptonMessageBoxExtendedButtons.YESNO:
                    kbtnButton1.Visible = false;

                    kbtnButton2.Text = "Y&es";

                    kbtnButton3.Text = "&No";
                    break;
                case KryptonMessageBoxExtendedButtons.YESNOCANCEL:
                    kbtnButton1.Text = "&Yes";

                    kbtnButton2.Text = "N&o";

                    kbtnButton3.Text = "C&ancel";
                    break;
                case KryptonMessageBoxExtendedButtons.RETRY:
                    kbtnButton1.Visible = false;

                    kbtnButton2.Visible = false;

                    kbtnButton3.Text = "&Retry";
                    break;
                case KryptonMessageBoxExtendedButtons.ABORT:
                    kbtnButton1.Visible = false;

                    kbtnButton2.Visible = false;

                    kbtnButton3.Text = "A&bort";
                    break;
                case KryptonMessageBoxExtendedButtons.RETRYABORT:
                    kbtnButton1.Visible = false;

                    kbtnButton2.Text = "&Retry";

                    kbtnButton3.Text = "A&bort";
                    break;
                case KryptonMessageBoxExtendedButtons.RETRYABORTCANCEL:
                    kbtnButton1.Text = "&Retry";

                    kbtnButton2.Text = "A&bort";

                    kbtnButton3.Text = "C&ancel";
                    break;
                case KryptonMessageBoxExtendedButtons.CUSTOM:
                    kbtnButton1.Text = kryptonButtonText1;

                    kbtnButton2.Text = kryptonButtonText2;

                    kbtnButton3.Text = kryptonButtonText3;

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
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Sets the default button.
        /// </summary>
        /// <param name="defaultButton">The default button.</param>
        private void SetDefaultButton(KryptonMessageBoxExtendedDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case KryptonMessageBoxExtendedDefaultButton.BUTTON1:
                    AcceptButton = kbtnButton1;
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
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the PaletteManager to the value of manager.
        /// </summary>
        /// <param name="manager">The desired value of PaletteManager.</param>
        public void SetPaletteManager(KryptonManager manager)
        {
            PaletteManager = manager;
        }

        /// <summary>
        /// Returns the value of the PaletteManager.
        /// </summary>
        /// <returns>The value of the PaletteManager.</returns>
        public KryptonManager GetPaletteManager()
        {
            return PaletteManager;
        }

        /// <summary>
        /// Sets the Message to the value of message.
        /// </summary>
        /// <param name="message">The value of message.</param>
        private void SetMessage(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Gets the Message value.
        /// </summary>
        /// <returns>The value of message.</returns>
        private string GetMessage()
        {
            return Message;
        }

        /// <summary>
        /// Sets the Caption to the value of caption.
        /// </summary>
        /// <param name="caption">The value of caption.</param>
        private void SetCaption(string caption)
        {
            Caption = caption;
        }

        /// <summary>
        /// Gets the Caption value.
        /// </summary>
        /// <returns>The value of caption.</returns>
        private string GetCaption()
        {
            return Caption;
        }

        /// <summary>
        /// Sets the CheckboxText to the value of checkboxText.
        /// </summary>
        /// <param name="checkboxText">The value of checkboxText.</param>
        private void SetCheckboxText(string checkboxText)
        {
            CheckboxText = checkboxText;
        }

        /// <summary>
        /// Gets the CheckboxText value.
        /// </summary>
        /// <returns>The value of checkboxText.</returns>
        private string GetCheckboxText()
        {
            return CheckboxText;
        }

        /// <summary>
        /// Sets the ButtonResultOne to the value of result.
        /// </summary>
        /// <param name="result">The desired value of ButtonResultOne.</param>
        public void SetButtonResultOne(DialogResult result)
        {
            ButtonResultOne = result;
        }

        /// <summary>
        /// Returns the value of the ButtonResultOne.
        /// </summary>
        /// <returns>The value of the ButtonResultOne.</returns>
        public DialogResult GetButtonResultOne()
        {
            return ButtonResultOne;
        }

        /// <summary>
        /// Sets the ButtonResultTwo to the value of result.
        /// </summary>
        /// <param name="result">The desired value of ButtonResultTwo.</param>
        public void SetButtonResultTwo(DialogResult result)
        {
            ButtonResultTwo = result;
        }

        /// <summary>
        /// Returns the value of the ButtonResultTwo.
        /// </summary>
        /// <returns>The value of the ButtonResultTwo.</returns>
        public DialogResult GetButtonResultTwo()
        {
            return ButtonResultTwo;
        }

        /// <summary>
        /// Sets the ButtonResultThree to the value of result.
        /// </summary>
        /// <param name="result">The desired value of ButtonResultThree.</param>
        public void SetButtonResultThree(DialogResult result)
        {
            ButtonResultThree = result;
        }

        private void kbtnButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = GetButtonResultThree();
        }

        private void kbtnButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = GetButtonResultTwo();
        }

        /// <summary>
        /// Returns the value of the ButtonResultThree.
        /// </summary>
        /// <returns>The value of the ButtonResultThree.</returns>
        public DialogResult GetButtonResultThree()
        {
            return ButtonResultThree;
        }

        /// <summary>
        /// Sets the OverallResult to the value of result.
        /// </summary>
        /// <param name="result">The desired value of OverallResult.</param>
        public void SetOverallResult(DialogResult result)
        {
            OverallResult = result;
        }

        /// <summary>
        /// Returns the value of the OverallResult.
        /// </summary>
        /// <returns>The value of the OverallResult.</returns>
        public DialogResult GetOverallResult()
        {
            return OverallResult;
        }
        #endregion

        #region Event Handlers
        private void ExtendedKryptonMessagebox_Load(object sender, EventArgs e)
        {
            Text = GetCaption();

            klblMessage.Text = GetMessage();
        }
        #endregion

        #region Show Methods

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
        private static KryptonMessageBoxExtendedResult InternalShow(IWin32Window owner, string messageContent, string caption, KryptonMessageBoxExtendedApplicationIconVisibility iconVisibility, KryptonMessageBoxExtendedBorderType borderType, KryptonMessageBoxExtendedBoxButtonCount buttonCount, KryptonMessageBoxExtendedButtons buttons, KryptonMessageBoxExtendedBoxOptions options, HelpInfo helpInfo = null, KryptonMessageBoxExtendedDefaultButton defaultButton = KryptonMessageBoxExtendedDefaultButton.BUTTON1, KryptonMessageBoxExtendedIcon icon = KryptonMessageBoxExtendedIcon.NONE, string[] buttonTextCollection = null, string checkBoxText = null, Image customIcon = null) // KryptonMessageBoxExtendedResult result = KryptonMessageBoxExtendedResult.OK,
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

                return ekmb.ShowDialog(showOwner);
            }
        }
        #endregion

        #region Update Methods
        private void UpdateText()
        {
            Text = (string.IsNullOrEmpty(_caption) ? string.Empty : _caption.Split(Environment.NewLine.ToCharArray())[0]);


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
        #endregion
    }
}