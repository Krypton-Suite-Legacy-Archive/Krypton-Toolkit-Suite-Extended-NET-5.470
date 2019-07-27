#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion


using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.UAC;

namespace ExtendedControls.Base.Code.Windows
{
    /// <summary>
    /// The bracket type.
    /// </summary>
    public enum BracketType
    {
        /// <summary>
        /// Curved brackets '()'.
        /// </summary>
        CURVEDBRACKET,
        /// <summary>
        /// Curly brackets '{}'.
        /// </summary>
        CURLYBRACKET,
        /// <summary>
        /// Square brackets '[]'.
        /// </summary>
        SQUAREBRACKET,
        /// <summary>
        /// No bracket.
        /// </summary>
        NOBRACKET
    }

    public class WindowHandler
    {
        #region Constructor
        public WindowHandler()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Updates the window text.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="extraTitleText">The extra title text.</param>
        /// <param name="bracketType">Type of the bracket.</param>
        /// <param name="administratorText">The administrator text.</param>
        private static void UpdateWindowText(KryptonForm owner, string extraTitleText = "", BracketType bracketType = BracketType.CURLYBRACKET, string administratorText = "Administrator")
        {
            string tempWindowTitleText = owner.Text;

            switch (bracketType)
            {
                case BracketType.CURVEDBRACKET:
                    if (extraTitleText != "")
                    {
                        owner.Text = $"{ tempWindowTitleText } { extraTitleText } ({ administratorText })";
                    }
                    else
                    {
                        owner.Text = $"{ tempWindowTitleText } ({ administratorText })";
                    }
                    break;
                case BracketType.CURLYBRACKET:
                    if (extraTitleText != "")
                    {
                        owner.Text = $"{ tempWindowTitleText } { extraTitleText } {{ {administratorText } }}";
                    }
                    else
                    {
                        owner.Text = $"{ tempWindowTitleText } {{{ administratorText }}}";
                    }
                    break;
                case BracketType.SQUAREBRACKET:
                    if (extraTitleText != "")
                    {
                        owner.Text = $"{ tempWindowTitleText } { extraTitleText } [{ administratorText}]";
                    }
                    else
                    {
                        owner.Text = $"{ tempWindowTitleText } [{ administratorText }]";
                    }
                    break;
                case BracketType.NOBRACKET:
                    if (extraTitleText != "")
                    {
                        owner.Text = $"{ tempWindowTitleText } { extraTitleText } - { administratorText }";
                    }
                    else
                    {
                        owner.Text = $"{ tempWindowTitleText } - { administratorText }";
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Uacs the elevated update window text.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="extraTitleText">The extra title text.</param>
        /// <param name="bracketType">Type of the bracket.</param>
        /// <param name="administratorText">The administrator text.</param>
        public static void UACElevatedUpdateWindowText(KryptonForm owner, string extraTitleText = "", BracketType bracketType = BracketType.CURLYBRACKET, string administratorText = "Administrator")
        {
            if (UACHandler.GetHasElevateProcessWithAdministrativeRights())
            {
                UpdateWindowText(owner, extraTitleText, bracketType, administratorText);
            }
        }
        #endregion
    }
}