using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    public class KryptonMarqueeLabel : ComponentFactory.Krypton.Toolkit.KryptonLabel
    {
        #region Variables
        int _marqueeSpeed, _marqueeInterval;

        Timer _marqueeTimer;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets the text associated with this control.
        /// </summary>
        [Category("Appearance"), Browsable(true)]
        public override string Text { get => base.Text; set => base.Text = value; }

        /// <summary>
        /// Gets or sets the marquee speed.
        /// </summary>
        /// <value>
        /// The marquee speed.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [Category("Appearance"), Browsable(true), DefaultValue(5)]
        public int MarqueeSpeed
        {
            get => _marqueeSpeed;

            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();

                _marqueeSpeed = value;
            }
        }

        /// <summary>
        /// Gets or sets the marquee interval.
        /// </summary>
        /// <value>
        /// The marquee interval.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [Category("Appearance"), Browsable(true), DefaultValue(250)]
        public int MarqueeInterval
        {
            get => _marqueeInterval;

            set
            {
                if (value < 150) throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

        #region Constructor
        public KryptonMarqueeLabel()
        {
            _marqueeTimer = new Timer();

            _marqueeTimer.Interval = MarqueeInterval;

            _marqueeTimer.Enabled = true;

            _marqueeTimer.Start();

            _marqueeTimer.Tick += MarqueeTimer_Tick;
        }
        #endregion

        #region Event Handlers        
        /// <summary>
        /// Handles the Tick event of the MarqueeTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MarqueeTimer_Tick(object sender, EventArgs e)
        {
            this.Left = this.Left - MarqueeSpeed;

            if (this.Left <= -this.Width) this.Left = this.Width;
        }
        #endregion

        #region Overrides
        protected override void OnResize(EventArgs e)
        {
            this.Top = (this.Height - this.Height) / 2;

            this.Left = this.Width;
        }
        #endregion
    }
}