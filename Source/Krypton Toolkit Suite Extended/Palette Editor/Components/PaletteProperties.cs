using ExtendedControls.ExtendedToolkit.Controls.KryptonControls;
using System.Windows.Forms;

namespace PaletteEditor.Components
{
    public class PaletteProperties : UserControl
    {
        #region Designer Code
        private KryptonPropertyGrid kpgPaletteProperties;

        private void InitializeComponent()
        {
            this.kpgPaletteProperties = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid();
            this.SuspendLayout();
            // 
            // kpgPaletteProperties
            // 
            this.kpgPaletteProperties.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgPaletteProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpgPaletteProperties.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kpgPaletteProperties.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kpgPaletteProperties.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgPaletteProperties.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpgPaletteProperties.Location = new System.Drawing.Point(0, 0);
            this.kpgPaletteProperties.Name = "kpgPaletteProperties";
            this.kpgPaletteProperties.Size = new System.Drawing.Size(422, 603);
            this.kpgPaletteProperties.TabIndex = 0;
            // 
            // PaletteProperties
            // 
            this.Controls.Add(this.kpgPaletteProperties);
            this.Name = "PaletteProperties";
            this.Size = new System.Drawing.Size(422, 603);
            this.ResumeLayout(false);

        }
        #endregion

        #region Properties
        public KryptonPropertyGrid PalettePropertyGrid { get => kpgPaletteProperties; }
        #endregion

        #region Constructor
        public PaletteProperties()
        {
            InitializeComponent();
        }
        #endregion
    }
}