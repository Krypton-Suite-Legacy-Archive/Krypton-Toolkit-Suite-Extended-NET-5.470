using ExtendedControls.ExtendedToolkit.Controls.Drawing.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToolbarItems
{
    [ToolboxBitmap(typeof(KryptonComboBoxToolStripMenuItem)), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class KryptonColourPickerToolStripComboBox : KryptonComboBoxToolStripMenuItem
    {
        #region Variables
        private Office2007MenuHelper _menuHelper;
        #endregion

        #region Events
        [Browsable(true)]
        public event EventHandler SelectedColourChanged;
        #endregion

        #region Property
        [Browsable(true)]
        public Color Colour { get => _menuHelper.ColourPlate.SelectedColour; set => _menuHelper.ColourPlate.SelectedColour = value; }
        #endregion

        #region Constructors
        public KryptonColourPickerToolStripComboBox()
        {
            OnInitialisation();
        }

        public KryptonColourPickerToolStripComboBox(IContainer container)
        {
            container.Add(this);

            OnInitialisation();
        }
        #endregion

        #region Initialisation
        private void OnInitialisation()
        {
            this.KryptonComboBoxControl.ComboBox.Items.Add("Color");

            KryptonComboBoxControl.ComboBox.SelectedIndex = 0;

            KryptonComboBoxControl.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            KryptonComboBoxControl.ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            _menuHelper = new Office2007MenuHelper();

            _menuHelper.ColourPlate.SelectedColourChanged += new EventHandler(ColourPlate_SelectedColourChanged);
        }
        #endregion

        #region Events
        private void ColourPlate_SelectedColourChanged(object sender, EventArgs e)
        {
            if (SelectedColourChanged != null) SelectedColourChanged(this, new EventArgs());
        }
        #endregion

        #region Methods
        private void ShowDropDown()
        {
            if (_menuHelper != null) _menuHelper.Show(KryptonComboBoxControl, new Point(0, Height));
        }
        #endregion

        #region Overrides
        protected override void OnMouseUp(MouseEventArgs e)
        {
            ShowDropDown();

            base.OnMouseUp(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        
        #endregion
    }
}