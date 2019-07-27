using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.FloatingFramework.Controls
{
    [Browsable(false), Serializable]
    public class MenuStripPanelExtened : ToolStripPanel
    {
        #region Variables
        private Rectangle _activeRectangle;
        #endregion

        #region Property
        public Rectangle ActiveRectangle { get => _activeRectangle; }
        #endregion

        #region Overrides
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            _activeRectangle = ClientRectangle;

            if (_activeRectangle.Width < 23 || _activeRectangle.Height < 23)
            {
                if (Orientation == Orientation.Horizontal)
                {
                    _activeRectangle.Height = 23;
                }
                else
                {
                    _activeRectangle.Width = 23;
                }

                switch (base.Dock)
                {
                    case DockStyle.Bottom:
                        _activeRectangle.Y -= 23;
                        break;
                    case DockStyle.Left:
                        _activeRectangle.X += 23;
                        break;
                    case DockStyle.Right:
                        _activeRectangle.X -= 23;
                        break;
                    default:
                        break;
                }
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            MenuStrip menuStrip = e.Control as MenuStrip;

            if (menuStrip != null)
            {
                if (Orientation == Orientation.Horizontal)
                {
                    menuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
                }
                else
                {
                    menuStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                }
            }
        }
        #endregion
    }
}
