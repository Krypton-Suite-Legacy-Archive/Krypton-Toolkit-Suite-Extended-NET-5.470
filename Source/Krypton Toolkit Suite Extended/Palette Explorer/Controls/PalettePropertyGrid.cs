using ExtendedControls.ExtendedToolkit.Controls.KryptonControls;
using System.Windows.Forms;

namespace PaletteExplorer.Controls
{
    public class PalettePropertyGrid : UserControl
    {
        #region Designer Code
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid kpgPalette;

        private void InitializeComponent()
        {
            this.kpgPalette = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid();
            this.SuspendLayout();
            // 
            // kpgPalette
            // 
            this.kpgPalette.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.kpgPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpgPalette.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.kpgPalette.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.kpgPalette.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.kpgPalette.Location = new System.Drawing.Point(0, 0);
            this.kpgPalette.Name = "kpgPalette";
            this.kpgPalette.Size = new System.Drawing.Size(300, 254);
            this.kpgPalette.TabIndex = 0;
            // 
            // PalettePropertyGrid
            // 
            this.Controls.Add(this.kpgPalette);
            this.Name = "PalettePropertyGrid";
            this.Size = new System.Drawing.Size(300, 254);
            this.ResumeLayout(false);

        }
        #endregion

        #region Properties
        public KryptonPropertyGrid PalettePropertyGridControl { get => kpgPalette; }
        #endregion

        #region Constructors
        public PalettePropertyGrid()
        {
            InitializeComponent();
        }
        #endregion
    }
}