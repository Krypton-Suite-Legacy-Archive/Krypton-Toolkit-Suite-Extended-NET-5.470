namespace CircularPictureBoxExample
{
    partial class CircularPictureBoxExample
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
            this.cbxExample = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbxExample)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxExample
            // 
            this.cbxExample.BackColor = System.Drawing.SystemColors.Control;
            this.cbxExample.Location = new System.Drawing.Point(391, 126);
            this.cbxExample.Name = "cbxExample";
            this.cbxExample.Size = new System.Drawing.Size(332, 323);
            this.cbxExample.TabIndex = 3;
            this.cbxExample.TabStop = false;
            // 
            // CircularPictureBoxExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 709);
            this.Controls.Add(this.cbxExample);
            this.Name = "CircularPictureBoxExample";
            this.SelectedControl = this.cbxExample;
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.cbxExample, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cbxExample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cbxExample;
    }
}

