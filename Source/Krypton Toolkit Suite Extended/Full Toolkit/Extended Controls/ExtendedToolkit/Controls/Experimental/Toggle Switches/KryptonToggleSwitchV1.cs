#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Experimental.ToggleSwitches
{
    [ToolboxBitmap(typeof(KryptonButton))]
    [DefaultEvent("ToggleStateChanged")]
    public class KryptonToggleSwitchV1 : Control
    {
        #region Variables
        private bool _toggled;

        private ToggleState _toggleState;

        private Rectangle _bar;

        private Size _cHandle = new Size(15, 20);

        private ToggleStateChangedEventHandler ToggleStateChangedEventHandlerEvent;

        // Krypton stuff
        private IPalette _palette;

        private IRenderer _renderer;
        #endregion

        #region Enumerations        
        /// <summary>
        /// 
        /// </summary>
        public enum ToggleState
        {
            ONOFF,
            YESNO,
            TRUEFALSE,
            IO
        }
        #endregion

        #region Delegates        
        /// <summary>
        /// 
        /// </summary>
        public delegate void ToggleStateChangedEventHandler();
        #endregion

        #region Custom Events        
        /// <summary>
        /// Occurs when [toggle state changed].
        /// </summary>
        public event ToggleStateChangedEventHandler ToggleStateChanged
        {
            add
            {
                ToggleStateChangedEventHandlerEvent = (ToggleStateChangedEventHandler)Delegate.Combine(ToggleStateChangedEventHandlerEvent, value);
            }

            remove
            {
                ToggleStateChangedEventHandlerEvent = (ToggleStateChangedEventHandler)Delegate.Remove(ToggleStateChangedEventHandlerEvent, value);
            }
        }

        /// <summary>
        /// Called when [palette paint].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PaletteLayoutEventArgs"/> instance containing the event data.</param>
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }

        /// <summary>
        /// Called when [global palette changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            if (_palette != null)
            {
                _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
            }

            _palette = KryptonManager.CurrentGlobalPalette;

            if (_palette != null)
            {
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
            }

            Invalidate();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets Toggled.
        /// </summary>
        /// <value>
        /// _toggled.
        /// </value>
        public bool Toggled
        {
            get
            {
                return _toggled;
            }


            set
            {
                _toggled = value;

                Invalidate();

                if (ToggleStateChangedEventHandlerEvent != null)
                {
                    ToggleStateChangedEventHandlerEvent();
                }
            }
        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        /// <value>
        /// _toggleState.
        /// </value>
        public ToggleState State
        {
            get
            {
                return _toggleState;
            }


            set
            {
                _toggleState = value;

                Invalidate();
            }
        }
        #endregion

        #region Over-ridable Events               
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.Control" /> and its child controls and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing"><see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_palette != null)
                {
                    _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

                    _palette = null;
                }

                KryptonManager.GlobalPaletteChanged -= new EventHandler(OnGlobalPaletteChanged);
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            Width = 79;

            Height = 27;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            Toggled = !Toggled;

            Focus();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_palette != null)
            {
                PaletteState _state = Enabled ? PaletteState.Normal : PaletteState.Disabled;

                Color _backColour1 = _palette.GetBackColor1(PaletteBackStyle.ButtonStandalone, _state), _backColour2 = _palette.GetBackColor2(PaletteBackStyle.ButtonStandalone, _state), _borderColour = _palette.GetBorderColor1(PaletteBorderStyle.ButtonStandalone, _state), _textColour = _palette.GetContentShortTextColor1(PaletteContentStyle.ButtonStandalone, _state);

                Graphics g = e.Graphics;

                Font _textTypeface = _palette.GetContentShortTextFont(PaletteContentStyle.ButtonStandalone, _state);

                g.SmoothingMode = SmoothingMode.HighQuality;

                g.Clear(Parent.BackColor);

                int _switchXLoc = 3;

                Rectangle _controlRectangle = new Rectangle(0, 0, Width - 1, Height - 1);

                //GraphicsPath _path 

                if (_toggled)
                {
                    _switchXLoc = 37;

                    using (SolidBrush backBrush1 = new SolidBrush(_backColour2))
                    {
                        g.FillRectangle(backBrush1, e.ClipRectangle);
                    }
                }
            }

            base.OnPaint(e);
        }
        #endregion

        #region Constructor        
        /// <summary>
        /// Initialises a new instance of the <see cref="KryptonToggleSwitchV1"/> class.
        /// </summary>
        public KryptonToggleSwitchV1()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);

            // Cache current global palette settings
            _palette = KryptonManager.CurrentGlobalPalette;

            // Hook into palette events
            if (_palette != null)
            {
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
            }

            // Notify when palette is changed
            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);
        }
        #endregion
    }
}