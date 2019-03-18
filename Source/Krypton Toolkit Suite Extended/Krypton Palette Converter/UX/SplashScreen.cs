using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptonPaletteConverter.UX
{
    public class SplashScreen : KryptonForm
    {
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonProgressBar kpbProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kpbProgress = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.kpbProgress);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(561, 582);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kpbProgress
            // 
            this.kpbProgress.BackColor = System.Drawing.Color.Transparent;
            this.kpbProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpbProgress.EndColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.kpbProgress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kpbProgress.ForeColour = System.Drawing.Color.Empty;
            this.kpbProgress.GlowColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(130)))));
            this.kpbProgress.Location = new System.Drawing.Point(0, 550);
            this.kpbProgress.Name = "kpbProgress";
            this.kpbProgress.Size = new System.Drawing.Size(561, 32);
            this.kpbProgress.StartColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.kpbProgress.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            this.ClientSize = new System.Drawing.Size(561, 582);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}