#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

namespace KryptonApplicationUpdater.UI.Advanced.XMLBased
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtOptions = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pbWait = new System.Windows.Forms.ProgressBar();
            this.kbtnCheckForUpdates = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kuacsbtnCheckForUpdates = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.klblDetails = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tmrWaiting = new System.Windows.Forms.Timer(this.components);
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtOptions);
            this.kryptonPanel1.Controls.Add(this.pbWait);
            this.kryptonPanel1.Controls.Add(this.kbtnCheckForUpdates);
            this.kryptonPanel1.Controls.Add(this.kuacsbtnCheckForUpdates);
            this.kryptonPanel1.Controls.Add(this.klblDetails);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 233);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtOptions
            // 
            this.kbtOptions.Location = new System.Drawing.Point(12, 179);
            this.kbtOptions.Name = "kbtOptions";
            this.kbtOptions.Size = new System.Drawing.Size(111, 40);
            this.kbtOptions.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtOptions.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtOptions.TabIndex = 4;
            this.kbtOptions.Values.Text = "O&ptions...";
            this.kbtOptions.Click += new System.EventHandler(this.kbtOptions_Click);
            // 
            // pbWait
            // 
            this.pbWait.Location = new System.Drawing.Point(12, 80);
            this.pbWait.Name = "pbWait";
            this.pbWait.Size = new System.Drawing.Size(776, 31);
            this.pbWait.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbWait.TabIndex = 1;
            this.pbWait.Visible = false;
            // 
            // kbtnCheckForUpdates
            // 
            this.kbtnCheckForUpdates.Location = new System.Drawing.Point(482, 179);
            this.kbtnCheckForUpdates.Name = "kbtnCheckForUpdates";
            this.kbtnCheckForUpdates.Size = new System.Drawing.Size(211, 40);
            this.kbtnCheckForUpdates.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCheckForUpdates.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCheckForUpdates.TabIndex = 3;
            this.kbtnCheckForUpdates.Values.Text = "&Check for Updates...";
            this.kbtnCheckForUpdates.Click += new System.EventHandler(this.kbtnCheckForUpdates_Click);
            // 
            // kuacsbtnCheckForUpdates
            // 
            this.kuacsbtnCheckForUpdates.Location = new System.Drawing.Point(482, 179);
            this.kuacsbtnCheckForUpdates.Name = "kuacsbtnCheckForUpdates";
            this.kuacsbtnCheckForUpdates.Size = new System.Drawing.Size(211, 40);
            this.kuacsbtnCheckForUpdates.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuacsbtnCheckForUpdates.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuacsbtnCheckForUpdates.TabIndex = 2;
            this.kuacsbtnCheckForUpdates.Values.Image = ((System.Drawing.Image)(resources.GetObject("kuacsbtnCheckForUpdates.Values.Image")));
            this.kuacsbtnCheckForUpdates.Values.Text = "&Check for Updates...";
            this.kuacsbtnCheckForUpdates.Click += new System.EventHandler(this.kuacsbtnCheckForUpdates_Click);
            // 
            // klblDetails
            // 
            this.klblDetails.Location = new System.Drawing.Point(12, 12);
            this.klblDetails.Name = "klblDetails";
            this.klblDetails.Size = new System.Drawing.Size(285, 26);
            this.klblDetails.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDetails.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDetails.TabIndex = 1;
            this.klblDetails.Values.Text = "To start, click \'Check for Updates...\'";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(699, 179);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(89, 40);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 1;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // tmrWaiting
            // 
            this.tmrWaiting.Tick += new System.EventHandler(this.tmrWaiting_Tick);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 233);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StartupForm";
            this.UseDropShadow = true;
            this.Load += new System.EventHandler(this.StartupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton kuacsbtnCheckForUpdates;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCheckForUpdates;
        private System.Windows.Forms.ProgressBar pbWait;
        private System.Windows.Forms.Timer tmrWaiting;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtOptions;
    }
}