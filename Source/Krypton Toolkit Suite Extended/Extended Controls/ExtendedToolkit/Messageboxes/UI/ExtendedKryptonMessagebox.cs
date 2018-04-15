using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Messageboxes.Enumerations;
using System.Windows.Forms;

namespace KryptonExtendedToolkit.ExtendedToolkit.Messageboxes.UI
{
    public partial class ExtendedKryptonMessagebox : KryptonForm
    {
        KryptonManager _paletteManager = null;

        DialogResult result;

        public ExtendedKryptonMessagebox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows the specified messagebox.
        /// </summary>
        /// <param name="messageboxTitle">The messagebox title.</param>
        /// <param name="messageText">The message text.</param>
        public void Show(string messageboxTitle, string messageText)
        {

        }

        /// <summary>
        /// Shows the specified messagebox.
        /// </summary>
        /// <param name="messageboxTitle">The messagebox title.</param>
        /// <param name="messageText">The message text.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="defaultButton">The default button.</param>
        public void Show(string messageboxTitle, string messageText, KryptonMessageBoxExtendedButtons buttons, KryptonMessageBoxExtendedIcon icon, KryptonMessageBoxExtendedDefaultButton defaultButton = KryptonMessageBoxExtendedDefaultButton.BUTTON1)
        {

        }

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
                    kbtnButton3.Text = "&Ok";
                    break;
                case KryptonMessageBoxExtendedButtons.OKCANCEL:
                    kbtnButton2.Text = "&Ok";

                    kbtnButton3.Text = "C&ancel";
                    break;
                case KryptonMessageBoxExtendedButtons.YESNO:
                    kbtnButton2.Text = "Y&es";

                    kbtnButton3.Text = "&No";
                    break;
                case KryptonMessageBoxExtendedButtons.YESNOCANCEL:
                    break;
                case KryptonMessageBoxExtendedButtons.RETRY:
                    break;
                case KryptonMessageBoxExtendedButtons.ABORT:
                    break;
                case KryptonMessageBoxExtendedButtons.RETRYABORT:
                    break;
                case KryptonMessageBoxExtendedButtons.RETRYABORTCANCEL:
                    break;
                case KryptonMessageBoxExtendedButtons.CUSTOM:
                    kbtnButton1.Text = kryptonButtonText1;

                    kbtnButton2.Text = kryptonButtonText2;

                    kbtnButton3.Text = kryptonButtonText3;

                    switch (buttonCount)
                    {
                        case KryptonMessageBoxExtendedBoxButtonCount.ONE:
                            break;
                        case KryptonMessageBoxExtendedBoxButtonCount.TWO:
                            break;
                        case KryptonMessageBoxExtendedBoxButtonCount.THREE:
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}