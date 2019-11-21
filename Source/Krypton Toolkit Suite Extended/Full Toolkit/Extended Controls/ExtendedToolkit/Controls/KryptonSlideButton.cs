using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    public class KryptonSlideButton : Control
    {
        #region Variables
        private float diameter;
        //private RoundedRectangleF rect;
        private RectangleF circle;
        private bool isOn;
        private float artis;
        private Color borderColour;
        private bool textEnabled;
        private Timer paintTicker = new Timer();
        private KryptonPalette palette = new KryptonPalette();
        #endregion
    }
}