using ExtendedControls.ExtendedToolkit.Utilities.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToolbarItems
{
    [System.Drawing.ToolboxBitmap(typeof(TrackBar))]
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip), DefaultEvent("ValueChanged")]
    public partial class KryptonSliderBar : ToolStripControlHostFixed
    {
        //Event
        public event ValueChangedEventHandler ValueChanged;
        public delegate void ValueChangedEventHandler(KryptonToolbarSlider sender, KryptonToolbarSlider.SliderEventArgs e);

        //Starter
        public KryptonSliderBar()
            : base(new KryptonToolbarSlider())
        {
        }

        //Relayed Properties
        [Category("Control")]
        public KryptonToolbarSlider Tracker
        {
            get { return Control as KryptonToolbarSlider; }
        }
        [Category("Slider Values"), DefaultValue(typeof(bool), "false")]
        public bool SingleClick
        {
            get { return (Control as KryptonToolbarSlider).SingleClick; }
            set { (Control as KryptonToolbarSlider).SingleClick = value; }
        }
        [Category("Slider Values"), DefaultValue(typeof(int), "200")]
        public int FireInterval
        {
            get { return (Control as KryptonToolbarSlider).FireInterval; }
            set { (Control as KryptonToolbarSlider).FireInterval = value; }
        }
        [Category("Slider Values"), DefaultValue(typeof(Size), "140, 16")]
        public Size TrackerSize
        {
            get { return (Control as KryptonToolbarSlider).Size; }
            set { (Control as KryptonToolbarSlider).Size = value; }
        }
        [Category("Slider Values"), DefaultValue(0)]
        public int Value
        {
            get { return (this.Control as KryptonToolbarSlider).Value; }
            set { (this.Control as KryptonToolbarSlider).Value = value; }
        }
        [Category("Slider Values"), DefaultValue(100)]
        public int Range
        {
            get { return (this.Control as KryptonToolbarSlider).Range; }
            set { (this.Control as KryptonToolbarSlider).Range = value; }
        }
        [Category("Slider Values"), DefaultValue(5)]
        public int Steps
        {
            get { return (this.Control as KryptonToolbarSlider).Steps; }
            set { (this.Control as KryptonToolbarSlider).Steps = value; }
        }
        [Category("Slider Values")]
        public int Maximum
        {
            get { return (this.Control as KryptonToolbarSlider).Maximum; }
        }
        [Category("Slider Values")]
        public int Minimum
        {
            get { return (this.Control as KryptonToolbarSlider).Minimum; }
        }

        //Event Handlers
        private void OnValueChanged(KryptonToolbarSlider sender, KryptonToolbarSlider.SliderEventArgs e)
        {
            if (ValueChanged != null)
            {
                ValueChanged(sender, e);
            }
        }
        private void kminus_SliderButtonFire(KryptonSliderButton sender, System.EventArgs e)
        {

        }
        private void kplus_SliderButtonFire(KryptonSliderButton sender, System.EventArgs e)
        {

        }

        protected override void OnSubscribeControlEvents(Control c)
        {
            base.OnSubscribeControlEvents(c);
            (this.Control as KryptonToolbarSlider).ValueChanged += OnValueChanged;
            (this.Control as KryptonToolbarSlider).kminus.SliderButtonFire += kminus_SliderButtonFire;
            (this.Control as KryptonToolbarSlider).kplus.SliderButtonFire += kplus_SliderButtonFire;
        }
        protected override void OnUnsubscribeControlEvents(Control c)
        {
            base.OnUnsubscribeControlEvents(c);
            (this.Control as KryptonToolbarSlider).ValueChanged -= OnValueChanged;
            (this.Control as KryptonToolbarSlider).kminus.SliderButtonFire -= kminus_SliderButtonFire;
            (this.Control as KryptonToolbarSlider).kplus.SliderButtonFire -= kplus_SliderButtonFire;
        }

    }


}