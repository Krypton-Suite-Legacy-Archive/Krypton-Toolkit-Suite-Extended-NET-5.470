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
            this.kcmbThemeSelector = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbThemeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
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
            // kcmbThemeSelector
            // 
            this.kcmbThemeSelector.DropDownWidth = 121;
            this.kcmbThemeSelector.Location = new System.Drawing.Point(188, 88);
            this.kcmbThemeSelector.Name = "kcmbThemeSelector";
            this.kcmbThemeSelector.Size = new System.Drawing.Size(288, 27);
            this.kcmbThemeSelector.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbThemeSelector.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbThemeSelector.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbThemeSelector.TabIndex = 2;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kcmbThemeSelector);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 450);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(52, 88);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(130, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Chosen Theme:";
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
            ((System.ComponentModel.ISupportInitialize)(this.kcmbThemeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar kryptonScrollBar1;
        private ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar kryptonScrollBar2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbThemeSelector;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}