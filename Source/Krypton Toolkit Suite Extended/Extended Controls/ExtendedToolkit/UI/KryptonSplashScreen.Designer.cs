namespace ExtendedControls.ExtendedToolkit.UI
{
    partial class KryptonSplashScreen
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
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kpnlBackground = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblCloseActive = new System.Windows.Forms.Label();
            this.lblMinimise = new System.Windows.Forms.Label();
            this.lblCloseInactive = new System.Windows.Forms.Label();
            this.pbLoad = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.lblCloseActive);
            this.kpnlBackground.Controls.Add(this.lblMinimise);
            this.kpnlBackground.Controls.Add(this.lblCloseInactive);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(814, 487);
            this.kpnlBackground.TabIndex = 0;
            // 
            // lblCloseActive
            // 
            this.lblCloseActive.AutoSize = true;
            this.lblCloseActive.BackColor = System.Drawing.Color.Transparent;
            this.lblCloseActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseActive.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseActive.ForeColor = System.Drawing.Color.Red;
            this.lblCloseActive.Location = new System.Drawing.Point(784, 9);
            this.lblCloseActive.Name = "lblCloseActive";
            this.lblCloseActive.Size = new System.Drawing.Size(18, 20);
            this.lblCloseActive.TabIndex = 3;
            this.lblCloseActive.Text = "X";
            this.lblCloseActive.Click += new System.EventHandler(this.lblCloseActive_Click);
            this.lblCloseActive.MouseLeave += new System.EventHandler(this.lblCloseActive_MouseLeave);
            // 
            // lblMinimise
            // 
            this.lblMinimise.AutoSize = true;
            this.lblMinimise.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimise.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMinimise.Location = new System.Drawing.Point(763, 9);
            this.lblMinimise.Name = "lblMinimise";
            this.lblMinimise.Size = new System.Drawing.Size(15, 20);
            this.lblMinimise.TabIndex = 2;
            this.lblMinimise.Text = "-";
            this.lblMinimise.Click += new System.EventHandler(this.lblMinimise_Click);
            // 
            // lblCloseInactive
            // 
            this.lblCloseInactive.AutoSize = true;
            this.lblCloseInactive.BackColor = System.Drawing.Color.Transparent;
            this.lblCloseInactive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseInactive.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseInactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCloseInactive.Location = new System.Drawing.Point(784, 9);
            this.lblCloseInactive.Name = "lblCloseInactive";
            this.lblCloseInactive.Size = new System.Drawing.Size(18, 20);
            this.lblCloseInactive.TabIndex = 1;
            this.lblCloseInactive.Text = "X";
            this.lblCloseInactive.MouseEnter += new System.EventHandler(this.lblCloseInactive_MouseEnter);
            // 
            // pbLoad
            // 
            this.pbLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbLoad.Location = new System.Drawing.Point(0, 473);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(814, 14);
            this.pbLoad.TabIndex = 1;
            // 
            // KryptonSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 487);
            this.ControlBox = false;
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.kpnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KryptonSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).EndInit();
            this.kpnlBackground.ResumeLayout(false);
            this.kpnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackground;
        private System.Windows.Forms.Label lblCloseActive;
        private System.Windows.Forms.Label lblMinimise;
        private System.Windows.Forms.Label lblCloseInactive;
        private System.Windows.Forms.ProgressBar pbLoad;
    }
}