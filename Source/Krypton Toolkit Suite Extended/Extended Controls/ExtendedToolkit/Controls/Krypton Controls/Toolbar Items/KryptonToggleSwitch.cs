using ExtendedControls.ExtendedToolkit.Utilities.Controls;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToolbarItems
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip), DefaultEvent("SliderValueChanged")]
    public class KryptonToggleSwitch : ToolStripUserControlHost
    {
        #region Event
        public delegate void SliderChangedEventHandler(object sender, EventArgs e);
        public event SliderChangedEventHandler SliderValueChanged;
        #endregion

        #region Properties
        [Category("Control")]
        public new KryptonToggleSwitchToolbarControl Control { get => Control as KryptonToggleSwitchToolbarControl; }
        #endregion

        #region Constructor
        public KryptonToggleSwitch() : base(new KryptonToggleSwitchToolbarControl())
        {

        }
        #endregion

        #region Event Handlers
        private void OnSliderValueChanged(object sender, EventArgs e)
        {
            if (SliderValueChanged != null)
            {
                SliderValueChanged(sender, e);
            }
        }

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);

            (Control as KryptonToggleSwitchToolbarControl).SliderValueChanged += OnSliderValueChanged;
        }

        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);

            (Control as KryptonToggleSwitchToolbarControl).SliderValueChanged -= OnSliderValueChanged;
        }
        #endregion
    }
}