using ExtendedControls.ExtendedToolkit.Utilities.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip), DefaultEvent("ValueChanged")]
    public partial class KryptonViewBar : ToolStripControlHostFixed
    {

        //Event
        public delegate void EventHandler(object Sender, EventArgs e);
        public event EventHandler KcmdleftClick;
        public event EventHandler KcmdmiddleleftClick;
        public event EventHandler KcmdmiddlerightClick;
        public event EventHandler KcmdrightClick;

        //Starter
        public KryptonViewBar()
            : base(new KryptonViewButtons())
        {
        }

        //Relayed Properties
        [Category("Control")]
        public KryptonViewButtons ViewButtons
        {
            get { return Control as KryptonViewButtons; }
        }

        [Category("ViewButtons"), DefaultValue(typeof(Size), "140, 16")]
        public Size ViewBarSize
        {
            get { return (Control as KryptonViewButtons).Size; }
            set { (Control as KryptonViewButtons).Size = value; }
        }

        [Category("ViewButtons"), DefaultValue(typeof(string), "100%")]
        public string PercentageLabel
        {
            get { return (Control as KryptonViewButtons).PercentageLabel; }
            set { (Control as KryptonViewButtons).PercentageLabel = value; }
        }


        //Event Handlers
        private void OnKcmdLeftClick(object Sender, EventArgs e)
        {
            if (KcmdleftClick != null)
            {
                KcmdleftClick(Sender, e);
            }
        }
        private void OnKcmdMiddleLeftClick(object Sender, EventArgs e)
        {
            if (KcmdmiddleleftClick != null)
            {
                KcmdmiddleleftClick(Sender, e);
            }
        }
        private void OnKcmdMiddleRightClick(object Sender, EventArgs e)
        {
            if (KcmdmiddlerightClick != null)
            {
                KcmdmiddlerightClick(Sender, e);
            }
        }
        private void OnKcmdRightClick(object Sender, EventArgs e)
        {
            if (KcmdrightClick != null)
            {
                KcmdrightClick(Sender, e);
            }
        }

        protected override void OnSubscribeControlEvents(Control c)
        {
            base.OnSubscribeControlEvents(c);
            (this.Control as KryptonViewButtons).kcmdleft.Click += OnKcmdLeftClick;
            (this.Control as KryptonViewButtons).kcmdmiddleleft.Click += OnKcmdMiddleLeftClick;
            (this.Control as KryptonViewButtons).kcmdmiddleright.Click += OnKcmdMiddleRightClick;
            (this.Control as KryptonViewButtons).kcmdright.Click += OnKcmdRightClick;

        }
        protected override void OnUnsubscribeControlEvents(Control c)
        {
            base.OnUnsubscribeControlEvents(c);
            (this.Control as KryptonViewButtons).kcmdleft.Click -= OnKcmdLeftClick;
            (this.Control as KryptonViewButtons).kcmdmiddleleft.Click -= OnKcmdMiddleLeftClick;
            (this.Control as KryptonViewButtons).kcmdmiddleright.Click -= OnKcmdMiddleRightClick;
            (this.Control as KryptonViewButtons).kcmdright.Click -= OnKcmdRightClick;
        }


    }


}