namespace Playground
{
    partial class Scrollbars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonScrollBar1 = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.kryptonScrollBar2 = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonScrollBar1
            // 
            this.kryptonScrollBar1.Location = new System.Drawing.Point(12, 12);
            this.kryptonScrollBar1.Name = "kryptonScrollBar1";
            this.kryptonScrollBar1.Size = new System.Drawing.Size(19, 200);
            this.kryptonScrollBar1.TabIndex = 0;
            // 
            // kryptonScrollBar2
            // 
            this.kryptonScrollBar2.Location = new System.Drawing.Point(52, 12);
            this.kryptonScrollBar2.Name = "kryptonScrollBar2";
            this.kryptonScrollBar2.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.kryptonScrollBar2.Size = new System.Drawing.Size(200, 19);
            this.kryptonScrollBar2.TabIndex = 1;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 450);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.SparkleBlue;
            // 
            // Scrollbars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonScrollBar2);
            this.Controls.Add(this.kryptonScrollBar1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Scrollbars";
            this.Text = "Scrollbars";
            this.Load += new System.EventHandler(this.Scrollbars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar kryptonScrollBar1;
        private ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar kryptonScrollBar2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}