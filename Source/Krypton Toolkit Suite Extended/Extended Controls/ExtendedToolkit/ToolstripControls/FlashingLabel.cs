using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.ToolstripControls
{
    [ToolboxBitmap(typeof(ToolStripLabel))]
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class FlashingLabel : ToolStripLabel
    {
        #region Variables
        private bool _enableFlashing;
        private Color _flashColour1, _flashColour2;
        private int _flashTimeout;
        private Timer _flashTimer = new Timer();
        #endregion

        #region Properties
        public bool EnableFlashing { get => _enableFlashing; set => _enableFlashing = value; }

        public Color FlashColour1 { get => _flashColour1; set => _flashColour1 = value; }

        public Color FlashColour2 { get => _flashColour2; set => _flashColour2 = value; }

        public int FlashTimeout { get => _flashTimeout; set => _flashTimeout = value; }
        #endregion

        #region Constructor
        public FlashingLabel()
        {
            EnableFlashing = false;

            FlashColour1 = Color.Transparent;

            FlashColour2 = Color.Red;

            FlashTimeout = 500;

            _flashTimer.Enabled = EnableFlashing;

            _flashTimer.Interval = FlashTimeout;

            _flashTimer.Tick += FlashTimer_Tick;
        }
        #endregion

        #region Event Handlers
        private void FlashTimer_Tick(object sender, EventArgs e)
        {
            if (BackColor == FlashColour1)
            {
                BackColor = FlashColour2;
            }
            else if (BackColor == FlashColour2)
            {
                BackColor = FlashColour1;
            }
        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            if (EnableFlashing)
            {
                _flashTimer.Start();
            }
            else
            {
                _flashTimer.Stop();
            }

            base.OnPaint(e);
        }
        #endregion
    }
}