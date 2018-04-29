using System.Drawing;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

using ExtendedControls.ExtendedToolkit.Messageboxes.Enumerations;
using ExtendedControls.Properties;

namespace KryptonExtendedToolkit.ExtendedToolkit.Messageboxes.UI
{
    public partial class ExtendedKryptonMessagebox : KryptonForm
    {
        #region Variables
        KryptonManager _paletteManager = null;

        DialogResult _resultButton1, _resultButton2, _resultButton3, _overallResult;
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
        #endregion

        public ExtendedKryptonMessagebox()
        {
            InitializeComponent();
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
    }
}