using System;
using System.ComponentModel;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;

namespace ExtendedColourControls
{
    public class ColourPickerDialog : KryptonForm
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ColourPickerDialog
            // 
            this.ClientSize = new System.Drawing.Size(979, 398);
            this.Name = "ColourPickerDialog";
            this.ResumeLayout(false);

        }

        #region Constants

        private static readonly object _eventPreviewColourChanged = new object();

        #endregion

        #region Fields

        private Brush _textureBrush;

        #endregion

        #region Events

        [Category("Property Changed")]
        public event EventHandler PreviewColourChanged
        {
            //add { this.Events.AddHandler(_eventPreviewColorChanged, value); }
            //remove { this.Events.RemoveHandler(_eventPreviewColorChanged, value); }
        }

        #endregion

        #region Properties

        public Color Colour
        {
            //get { return colorEditorManager.Color; }
            //set { colorEditorManager.Color = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowAlphaChannel { get; set; }

        #endregion
    }
}