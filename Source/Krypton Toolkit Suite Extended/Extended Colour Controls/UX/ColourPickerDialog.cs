using System.ComponentModel;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;

namespace ExtendedColourControls
{
    public class ColourPickerDialog : KryptonForm
    {
        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.colourWheel1 = new ExtendedColourControls.ColourWheel();
            this.cem = new ExtendedColourControls.ColourEditorManager();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.colourWheel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(979, 467);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // colourWheel1
            // 
            this.colourWheel1.BackColor = System.Drawing.Color.Transparent;
            this.colourWheel1.Location = new System.Drawing.Point(12, 12);
            this.colourWheel1.Name = "colourWheel1";
            this.colourWheel1.Size = new System.Drawing.Size(192, 147);
            this.colourWheel1.TabIndex = 1;
            // 
            // ColourPickerDialog
            // 
            this.ClientSize = new System.Drawing.Size(979, 467);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ColourPickerDialog";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region Constants

        private static readonly object _eventPreviewColourChanged = new object();

        #endregion

        #region Fields

        private Brush _textureBrush;

        #endregion

        #region Events

        //[Category("Property Changed")]
        //public event EventHandler PreviewColourChanged
        //{
        //    //add { this.Events.AddHandler(_eventPreviewColorChanged, value); }
        //    //remove { this.Events.RemoveHandler(_eventPreviewColorChanged, value); }
        //}

        #endregion

        #region Properties

        public Color Colour
        {
            get { return cem.Colour; }
            set { cem.Colour = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowAlphaChannel { get; set; }

        #endregion

        private KryptonPanel kryptonPanel1;
        private ColourEditorManager cem;
        private ColourWheel colourWheel1;
    }
}