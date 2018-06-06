using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColourComposer.UX
{
    class BaseForm : Form
    {
        protected static readonly bool RUNNINGONMONO = Type.GetType("Mono.Runtime") != null;

        protected BaseForm()
        {
            AutoScaleMode = AutoScaleMode.Dpi;

            if (!RUNNINGONMONO)
            {
                Font = SystemFonts.MessageBoxFont;
            }
        }
    }
}