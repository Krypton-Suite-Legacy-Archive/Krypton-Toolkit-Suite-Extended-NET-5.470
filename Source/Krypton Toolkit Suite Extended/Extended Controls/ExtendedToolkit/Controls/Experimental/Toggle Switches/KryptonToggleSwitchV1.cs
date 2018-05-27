using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Experimental.ToggleSwitches
{
    [DefaultEvent("ToggleStateChanged")]
    public class KryptonToggleSwitchV1 : Control
    {
        #region Variables
        private bool _toggled;

        private ToggleState _toggleState;

        private Rectangle _bar;

        private Size _cHandle = new Size(15, 20);

        private ToggleStateChangedEventHandler ToggleStateChangedEventHandlerEvent;
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
            base.OnPaint(e);
        }
        #endregion

        #region Constructor        
        /// <summary>
        /// Initialises a new instance of the <see cref="KryptonToggleSwitchV1"/> class.
        /// </summary>
        public KryptonToggleSwitchV1()
        {
            SetStyle((ControlStyles)(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint), true);
        }
        #endregion
    }
}