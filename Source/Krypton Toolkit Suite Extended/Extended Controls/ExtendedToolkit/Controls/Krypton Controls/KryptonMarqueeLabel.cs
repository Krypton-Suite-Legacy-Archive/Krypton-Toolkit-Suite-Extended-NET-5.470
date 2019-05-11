#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    #region Old Code
    /*
    public class KryptonMarqueeLabel : UserControl
    {
        private Timer tmrRoll;
        private IContainer components;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblRollLabel;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            this.klblRollLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tmrRoll = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // klblRollLabel
            // 
            this.klblRollLabel.Location = new System.Drawing.Point(64, 22);
            this.klblRollLabel.Name = "klblRollLabel";
            this.klblRollLabel.Size = new System.Drawing.Size(88, 20);
            this.klblRollLabel.TabIndex = 0;
            popupPositionValues3.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.klblRollLabel.ToolTipValues.ToolTipPosition = popupPositionValues3;
            this.klblRollLabel.Values.Text = "kryptonLabel1";
            // 
            // tmrRoll
            // 
            this.tmrRoll.Enabled = true;
            this.tmrRoll.Interval = 200;
            this.tmrRoll.Tick += new System.EventHandler(this.TmrRoll_Tick);
            // 
            // KryptonMarqueeLabel
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.klblRollLabel);
            this.Name = "KryptonMarqueeLabel";
            this.Size = new System.Drawing.Size(290, 42);
            this.Resize += new System.EventHandler(this.KryptonMarqueeLabel_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Variables
        int _marqueeSpeed = 5;
        #endregion

        #region Properties
        [Category("Appearance"), Browsable(true)]
        public override string Text { get => klblRollLabel.Text; set => klblRollLabel.Text = value; }

        [Category("Appearance")]
        public int MarqueeSpeed
        {
            get => _marqueeSpeed;

            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();

                _marqueeSpeed = value;
            }
        }
        #endregion

        public KryptonMarqueeLabel()
        {
            InitializeComponent();
        }

        private void TmrRoll_Tick(object sender, EventArgs e)
        {
            klblRollLabel.Left = klblRollLabel.Left - MarqueeSpeed;

            if (klblRollLabel.Left <= -klblRollLabel.Width)
            {
                klblRollLabel.Left = this.Width;
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            klblRollLabel.StateCommon.LongText.Font = Font;

            klblRollLabel.StateCommon.ShortText.Font = Font;

            base.OnFontChanged(e);
        }

        private void KryptonMarqueeLabel_Resize(object sender, EventArgs e)
        {
            klblRollLabel.Top = (Height - klblRollLabel.Height) / 2;

            klblRollLabel.Left = Width;
        }
    }
    */
    #endregion

    public class KryptonMarqueeLabel : KryptonLabel
    {
        int offset;

        public Timer MarqueeTimer { get; set; }

        public int Speed { get; set; }

        public int YOffset { get; set; }

        public KryptonMarqueeLabel()
        {
            YOffset = 0;

            Speed = 1;

            MarqueeTimer = new Timer();

            MarqueeTimer.Interval = 25;

            MarqueeTimer.Enabled = true;

            MarqueeTimer.Tick += MarqueeTimer_Tick;
        }

        private void MarqueeTimer_Tick(object sender, EventArgs e)
        {
            offset = (offset - Speed);

            if (offset < -ClientSize.Width)
            {
                offset = 0;
            }

            Invalidate();
        }

        public void Start() => MarqueeTimer.Start();

        public void Stop() => MarqueeTimer.Stop();


    }
}