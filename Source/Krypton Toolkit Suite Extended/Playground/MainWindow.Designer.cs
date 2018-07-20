namespace Playground
{
    partial class MainWindow
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
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.colourComboBox1 = new ExtendedControls.ExtendedToolkit.Controls.ColourComboBox();
            this.kryptonColourComboBox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonColourComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonColourComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(377, 237);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // colourComboBox1
            // 
            this.colourComboBox1.FormattingEnabled = true;
            this.colourComboBox1.Location = new System.Drawing.Point(306, 139);
            this.colourComboBox1.Name = "colourComboBox1";
            this.colourComboBox1.Size = new System.Drawing.Size(121, 21);
            this.colourComboBox1.TabIndex = 1;
            // 
            // kryptonColourComboBox1
            // 
            this.kryptonColourComboBox1.DropDownWidth = 121;
            this.kryptonColourComboBox1.Location = new System.Drawing.Point(306, 186);
            this.kryptonColourComboBox1.Name = "kryptonColourComboBox1";
            this.kryptonColourComboBox1.Size = new System.Drawing.Size(121, 21);
            this.kryptonColourComboBox1.TabIndex = 2;
            this.kryptonColourComboBox1.Text = "kryptonColourComboBox1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonColourComboBox1);
            this.Controls.Add(this.colourComboBox1);
            this.Controls.Add(this.kryptonButton1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonColourComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ExtendedControls.ExtendedToolkit.Controls.ColourComboBox colourComboBox1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonColourComboBox kryptonColourComboBox1;
    }
}