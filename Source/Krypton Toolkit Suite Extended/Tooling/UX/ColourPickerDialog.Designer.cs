namespace Tooling.UX
{
    partial class ColourPickerDialog
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
            this.kpnlBackdrop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.circularPictureBox1 = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).BeginInit();
            this.kpnlBackdrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlBackdrop
            // 
            this.kpnlBackdrop.Controls.Add(this.circularPictureBox1);
            this.kpnlBackdrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackdrop.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackdrop.Name = "kpnlBackdrop";
            this.kpnlBackdrop.Size = new System.Drawing.Size(800, 450);
            this.kpnlBackdrop.TabIndex = 0;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.circularPictureBox1.Location = new System.Drawing.Point(370, 77);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(134, 127);
            this.circularPictureBox1.TabIndex = 1;
            this.circularPictureBox1.TabStop = false;
            // 
            // ColourPickerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kpnlBackdrop);
            this.Name = "ColourPickerDialog";
            this.Text = "ColourPickerDialog";
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).EndInit();
            this.kpnlBackdrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackdrop;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox circularPictureBox1;
    }
}