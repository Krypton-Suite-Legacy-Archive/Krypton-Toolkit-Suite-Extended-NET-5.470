using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColourCreator.UI
{
    class BaseForm : Form
    {
        #region Variables
        protected static readonly bool _runningOnMono = Type.GetType("Mono.Runtime") != null;
        #endregion

        #region Methods
        protected BaseForm()
        {
            AutoScaleMode = AutoScaleMode.Dpi;

            if (!_runningOnMono)
            {
                Font = SystemFonts.MessageBoxFont;
            }
        }
        #endregion
    }
}