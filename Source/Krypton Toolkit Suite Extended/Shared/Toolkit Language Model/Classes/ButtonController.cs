using ComponentFactory.Krypton.Toolkit;

namespace ToolkitLanguageModel.Classes
{
    public class ButtonController
    {
        #region Variables
        private static string[] _buttonTextArray = new string[6];
        #endregion

        #region Constructor
        public ButtonController()
        {

        }
        #endregion

        #region Methods
        private static void SetLanguage(Language language, string okText = "", string yesText = "", string noText = "", string cancelText = "", string abortText = "", string ignoreText = "")
        {
            switch (language)
            {
                case Language.CZECH:
                    _buttonTextArray = "OK,Ano,Ne,Storno,Přerušení".Split(',');
                    break;
                case Language.FRANÇAIS:
                    _buttonTextArray = "OK,Oui,Non,Annuler,Annuler".Split(',');
                    break;
                case Language.DEUTSCH:
                    _buttonTextArray = "OK,Ja,Nein,Abbrechen,Abbrechen".Split(',');
                    break;
                case Language.SLOVAKIAN:
                    _buttonTextArray = "OK,Áno,Nie,Zrušiť,Prerušiť".Split(',');
                    break;
                case Language.ESPAÑOL:
                    _buttonTextArray = "OK,Sí,No,Cancelar,Aborta".Split(',');
                    break;
                case Language.CUSTOM:
                    _buttonTextArray = SetCustomText(okText, yesText, noText, cancelText, abortText, ignoreText);
                    break;
                default:
                    _buttonTextArray = "OK,Yes,No,Cancel,Abort,Ignore".Split(',');
                    break;
            }
        }

        private static string[] SetCustomText(string okText, string yesText, string noText, string cancelText, string abortText, string ignoreText)
        {
            string[] tempArray = new string[6];

            tempArray = $"{ okText },{ yesText },{ noText },{ cancelText },{ abortText },{ ignoreText }".Split(',');

            return tempArray;
        }

        private static void AdaptButtonText(KryptonButton okButton, KryptonButton yesButton, KryptonButton noButton, KryptonButton cancelButton, KryptonButton abortButton, KryptonButton ignoreButton)
        {
            okButton.Text = _buttonTextArray[0];

            yesButton.Text = _buttonTextArray[1];

            noButton.Text = _buttonTextArray[2];

            cancelButton.Text = _buttonTextArray[3];

            abortButton.Text = _buttonTextArray[4];

            ignoreButton.Text = _buttonTextArray[5];
        }

        private static void AdaptButtonVisibility(ButtonType buttonType, KryptonButton okButton, KryptonButton yesButton, KryptonButton noButton, KryptonButton cancelButton, KryptonButton abortButton, KryptonButton ignoreButton)
        {
            AdaptButtonText(okButton, yesButton, noButton, cancelButton, abortButton, ignoreButton);

            switch (buttonType)
            {
                case ButtonType.OK:
                    break;
                case ButtonType.OKCANCEL:
                    break;
                case ButtonType.YESNO:
                    break;
                case ButtonType.YESNOCANCEL:
                    break;
                case ButtonType.RETRYCANCEL:
                    break;
                case ButtonType.ABORTRETRYIGNORE:
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}