using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.FloatingFramework.UX
{
    public partial class KryptonFloatingForm : KryptonForm
    {
        #region Events
        public event EventHandler DockingRequested;
        #endregion

        #region Constants
        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        #endregion

        #region Constructor
        public KryptonFloatingForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Overrides
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCLBUTTONDBLCLK:
                    Fire_DockingRequested();
                    break;
            }

            base.WndProc(ref m);
        }
        #endregion

        #region Event Handlers
        private void Fire_DockingRequested()
        {
            if (DockingRequested != null)
            {
                DockingRequested(this, new EventArgs());
            }
        }
        #endregion
    }
}