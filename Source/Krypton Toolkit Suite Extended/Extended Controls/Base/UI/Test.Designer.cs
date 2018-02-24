namespace ExtendedControls.Base.UI
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.kryptonUACShieldButton1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonUACShieldButton();
            this.SuspendLayout();
            // 
            // kryptonUACShieldButton1
            // 
            this.kryptonUACShieldButton1.Location = new System.Drawing.Point(398, 144);
            this.kryptonUACShieldButton1.Name = "kryptonUACShieldButton1";
            this.kryptonUACShieldButton1.Size = new System.Drawing.Size(208, 43);
            this.kryptonUACShieldButton1.TabIndex = 0;
            this.kryptonUACShieldButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonUACShieldButton1.Values.Image")));
            this.kryptonUACShieldButton1.Values.Text = "kryptonUACShieldButton1";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonUACShieldButton1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedToolkit.Controls.KryptonUACShieldButton kryptonUACShieldButton1;
    }
}