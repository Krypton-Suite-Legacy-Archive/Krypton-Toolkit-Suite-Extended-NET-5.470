#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion


using ComponentFactory.Krypton.Toolkit;

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
        SQUAREBRACKET
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
        /// 
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="extraTitleText"></param>
        /// <param name="bracketType"></param>
        /// <param name="administratorText"></param>
        public static void UpdateWindowText(KryptonForm owner, string extraTitleText = "", BracketType bracketType = BracketType.CURLYBRACKET, string administratorText = "Administrator")
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
                default:
                    break;
            }
        }
        #endregion
    }
}