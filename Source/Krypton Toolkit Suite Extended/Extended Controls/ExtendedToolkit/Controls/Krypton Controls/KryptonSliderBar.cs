using ExtendedControls.ExtendedToolkit.Utilities.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [System.Drawing.ToolboxBitmap(typeof(TrackBar))]
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip), DefaultEvent("ValueChanged")]
    public partial class KryptonSliderBar : ToolStripControlHostFixed
    {
        //Event
        public event ValueChangedEventHandler ValueChanged;
        public delegate void ValueChangedEventHandler(KryptonSlider Sender, KryptonSlider.SliderEventArgs e);

        //Starter
        public KryptonSliderBar()
            : base(new KryptonSlider())
        {
        }

        //Relayed Properties
        [Category("Control")]
        public KryptonSlider Tracker
        {
            get { return Control as KryptonSlider; }
        }
        [Category("Slider Values"), DefaultValue(typeof(bool), "false")]
        public bool SingleClick
        {
            get { return (Control as KryptonSlider).SingleClick; }
            set { (Control as KryptonSlider).SingleClick = value; }
        }
        [Category("Slider Values"), DefaultValue(typeof(int), "200")]
        public int FireInterval
        {
            get { return (Control as KryptonSlider).FireInterval; }
            set { (Control as KryptonSlider).FireInterval = value; }
        }
        [Category("Slider Values"), DefaultValue(typeof(Size), "140, 16")]
        public Size TrackerSize
        {
            get { return (Control as KryptonSlider).Size; }
            set { (Control as KryptonSlider).Size = value; }
        }
        [Category("Slider Values"), DefaultValue(0)]
        public int Value
        {
            get { return (this.Control as KryptonSlider).Value; }
            set { (this.Control as KryptonSlider).Value = value; }
        }
        [Category("Slider Values"), DefaultValue(100)]
        public int Range
        {
            get { return (this.Control as KryptonSlider).Range; }
            set { (this.Control as KryptonSlider).Range = value; }
        }
        [Category("Slider Values"), DefaultValue(5)]
        public int Steps
        {
            get { return (this.Control as KryptonSlider).Steps; }
            set { (this.Control as KryptonSlider).Steps = value; }
        }
        [Category("Slider Values")]
        public int Maximum
        {
            get { return (this.Control as KryptonSlider).Maximum; }
        }
        [Category("Slider Values")]
        public int Minimum
        {
            get { return (this.Control as KryptonSlider).Minimum; }
        }

        //Event Handlers
        private void OnValueChanged(KryptonSlider Sender, KryptonSlider.SliderEventArgs e)
        {
            if (ValueChanged != null)
            {
                ValueChanged(Sender, e);
            }
        }
        private void kminus_SliderButtonFire(KryptonSliderButton Sender, System.EventArgs e)
        {

        }
        private void kplus_SliderButtonFire(KryptonSliderButton Sender, System.EventArgs e)
        {

        }

        protected override void OnSubscribeControlEvents(Control c)
        {
            base.OnSubscribeControlEvents(c);
            (this.Control as KryptonSlider).ValueChanged += OnValueChanged;
            (this.Control as KryptonSlider).kminus.SliderButtonFire += kminus_SliderButtonFire;
            (this.Control as KryptonSlider).kplus.SliderButtonFire += kplus_SliderButtonFire;
        }
        protected override void OnUnsubscribeControlEvents(Control c)
        {
            base.OnUnsubscribeControlEvents(c);
            (this.Control as KryptonSlider).ValueChanged -= OnValueChanged;
            (this.Control as KryptonSlider).kminus.SliderButtonFire -= kminus_SliderButtonFire;
            (this.Control as KryptonSlider).kplus.SliderButtonFire -= kplus_SliderButtonFire;
        }

    }


}