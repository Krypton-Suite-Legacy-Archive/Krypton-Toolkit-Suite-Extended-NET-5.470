using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls;
using System.ComponentModel.Design;

namespace ExtendedControls.ExtendedToolkit.Designers
{
    internal class KryptonColourButtonExtendedActionList : DesignerActionList
    {
        #region Variables
        private readonly KryptonColourButtonExtended _colourButton;

        private readonly IComponentChangeService _service;
        #endregion

        #region Constructor
        public KryptonColourButtonExtendedActionList(KryptonColourButtonExtendedDesigner owner) : base(owner.Component)
        {
            _colourButton = owner.Component as KryptonColourButtonExtended;

            _service = (IComponentChangeService)GetService(typeof(IComponentChangeService));
        }
        #endregion

        #region Properties
        public ButtonStyle ButtonStyle
        {
            get => _colourButton.ButtonStyle;
        }
        #endregion
    }
}