using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooling.Classes.Other
{
    public class ToolTipManager
    {
        #region Constructors
        public ToolTipManager()
        {

        }
        #endregion

        #region Methods
        public void DisplayToolTip(ToolTip information, PictureBox target, string colourType, int alphaValue, int redValue, int greenValue, int blueValue, string hexValue, double hueValue)
        {
            information.SetToolTip(target, $"{ colourType } Colour\nARGB: ({ alphaValue.ToString() }, { redValue.ToString() }, { greenValue.ToString() }, { blueValue.ToString() })\nRGB: ({ redValue.ToString() }, { greenValue.ToString() }, { blueValue.ToString() })\nHexadecimal Value: #{ hexValue.ToUpper() }\nHue Value: { hueValue.ToString() }");
        }
        #endregion
    }
}