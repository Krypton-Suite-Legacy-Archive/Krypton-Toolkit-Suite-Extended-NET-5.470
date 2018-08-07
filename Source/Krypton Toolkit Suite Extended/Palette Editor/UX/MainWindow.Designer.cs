namespace PaletteEditor.UX
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
            this.components = new System.ComponentModel.Container();
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.labelGridNormal = new System.Windows.Forms.PropertyGrid();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPaletteDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openExistingPaletteDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.savePaletteDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pbxBaseColour = new System.Windows.Forms.PictureBox();
            this.pbxDarkColour = new System.Windows.Forms.PictureBox();
            this.pbxMiddleColour = new System.Windows.Forms.PictureBox();
            this.pbxLightColour = new System.Windows.Forms.PictureBox();
            this.pbxLightestColour = new System.Windows.Forms.PictureBox();
            this.kgbPreviewPane = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lblColourOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ttInformation = new System.Windows.Forms.ToolTip(this.components);
            this.kbtnGenerate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGetColours = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.ms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDarkColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddleColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightestColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane.Panel)).BeginInit();
            this.kgbPreviewPane.Panel.SuspendLayout();
            this.kgbPreviewPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnClose);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 792);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1288, 48);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnExport);
            this.kryptonPanel2.Controls.Add(this.kbtnGetColours);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerate);
            this.kryptonPanel2.Controls.Add(this.kgbPreviewPane);
            this.kryptonPanel2.Controls.Add(this.labelGridNormal);
            this.kryptonPanel2.Controls.Add(this.ms);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1288, 792);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // labelGridNormal
            // 
            this.labelGridNormal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGridNormal.HelpVisible = false;
            this.labelGridNormal.Location = new System.Drawing.Point(862, 44);
            this.labelGridNormal.Name = "labelGridNormal";
            this.labelGridNormal.Size = new System.Drawing.Size(414, 720);
            this.labelGridNormal.TabIndex = 2;
            this.labelGridNormal.ToolbarVisible = false;
            // 
            // ms
            // 
            this.ms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(1288, 24);
            this.ms.TabIndex = 3;
            this.ms.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPaletteDefinitionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openExistingPaletteDefinitionToolStripMenuItem,
            this.toolStripMenuItem2,
            this.savePaletteDefinitionToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newPaletteDefinitionToolStripMenuItem
            // 
            this.newPaletteDefinitionToolStripMenuItem.Name = "newPaletteDefinitionToolStripMenuItem";
            this.newPaletteDefinitionToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.newPaletteDefinitionToolStripMenuItem.Text = "N&ew Palette Definition";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // openExistingPaletteDefinitionToolStripMenuItem
            // 
            this.openExistingPaletteDefinitionToolStripMenuItem.Name = "openExistingPaletteDefinitionToolStripMenuItem";
            this.openExistingPaletteDefinitionToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.openExistingPaletteDefinitionToolStripMenuItem.Text = "Open E&xisting Palette Definition";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 6);
            // 
            // savePaletteDefinitionToolStripMenuItem
            // 
            this.savePaletteDefinitionToolStripMenuItem.Name = "savePaletteDefinitionToolStripMenuItem";
            this.savePaletteDefinitionToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.savePaletteDefinitionToolStripMenuItem.Text = "&Save Palette Definition";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(237, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // kbtnClose
            // 
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnClose.Location = new System.Drawing.Point(1225, 6);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(51, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 44;
            this.kbtnClose.Values.Text = "&Close";
            // 
            // pbxBaseColour
            // 
            this.pbxBaseColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxBaseColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxBaseColour.Location = new System.Drawing.Point(19, 15);
            this.pbxBaseColour.Name = "pbxBaseColour";
            this.pbxBaseColour.Size = new System.Drawing.Size(128, 128);
            this.pbxBaseColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBaseColour.TabIndex = 4;
            this.pbxBaseColour.TabStop = false;
            // 
            // pbxDarkColour
            // 
            this.pbxDarkColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxDarkColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxDarkColour.Location = new System.Drawing.Point(188, 15);
            this.pbxDarkColour.Name = "pbxDarkColour";
            this.pbxDarkColour.Size = new System.Drawing.Size(128, 128);
            this.pbxDarkColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxDarkColour.TabIndex = 5;
            this.pbxDarkColour.TabStop = false;
            // 
            // pbxMiddleColour
            // 
            this.pbxMiddleColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxMiddleColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMiddleColour.Location = new System.Drawing.Point(357, 15);
            this.pbxMiddleColour.Name = "pbxMiddleColour";
            this.pbxMiddleColour.Size = new System.Drawing.Size(128, 128);
            this.pbxMiddleColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxMiddleColour.TabIndex = 6;
            this.pbxMiddleColour.TabStop = false;
            // 
            // pbxLightColour
            // 
            this.pbxLightColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxLightColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLightColour.Location = new System.Drawing.Point(526, 15);
            this.pbxLightColour.Name = "pbxLightColour";
            this.pbxLightColour.Size = new System.Drawing.Size(128, 128);
            this.pbxLightColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLightColour.TabIndex = 7;
            this.pbxLightColour.TabStop = false;
            // 
            // pbxLightestColour
            // 
            this.pbxLightestColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxLightestColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLightestColour.Location = new System.Drawing.Point(695, 15);
            this.pbxLightestColour.Name = "pbxLightestColour";
            this.pbxLightestColour.Size = new System.Drawing.Size(128, 128);
            this.pbxLightestColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLightestColour.TabIndex = 8;
            this.pbxLightestColour.TabStop = false;
            // 
            // kgbPreviewPane
            // 
            this.kgbPreviewPane.Location = new System.Drawing.Point(12, 546);
            this.kgbPreviewPane.Name = "kgbPreviewPane";
            // 
            // kgbPreviewPane.Panel
            // 
            this.kgbPreviewPane.Panel.Controls.Add(this.lblColourOutput);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxBaseColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLightestColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxDarkColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLightColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxMiddleColour);
            this.kgbPreviewPane.Size = new System.Drawing.Size(844, 218);
            this.kgbPreviewPane.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbPreviewPane.TabIndex = 9;
            this.kgbPreviewPane.Values.Heading = "Colour Preview";
            // 
            // lblColourOutput
            // 
            this.lblColourOutput.Location = new System.Drawing.Point(19, 149);
            this.lblColourOutput.Name = "lblColourOutput";
            this.lblColourOutput.Size = new System.Drawing.Size(203, 26);
            this.lblColourOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourOutput.TabIndex = 62;
            this.lblColourOutput.Values.Text = "Colour Values for: {0} {1}";
            // 
            // kbtnGenerate
            // 
            this.kbtnGenerate.AutoSize = true;
            this.kbtnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerate.Location = new System.Drawing.Point(12, 44);
            this.kbtnGenerate.Name = "kbtnGenerate";
            this.kbtnGenerate.Size = new System.Drawing.Size(138, 30);
            this.kbtnGenerate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerate.TabIndex = 22;
            this.kbtnGenerate.Values.Text = "Gener&ate Colours";
            // 
            // kbtnGetColours
            // 
            this.kbtnGetColours.AutoSize = true;
            this.kbtnGetColours.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGetColours.Location = new System.Drawing.Point(12, 105);
            this.kbtnGetColours.Name = "kbtnGetColours";
            this.kbtnGetColours.Size = new System.Drawing.Size(97, 30);
            this.kbtnGetColours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetColours.TabIndex = 23;
            this.kbtnGetColours.Values.Text = "&Get Colours";
            // 
            // kbtnExport
            // 
            this.kbtnExport.AutoSize = true;
            this.kbtnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnExport.Location = new System.Drawing.Point(12, 170);
            this.kbtnExport.Name = "kbtnExport";
            this.kbtnExport.Size = new System.Drawing.Size(118, 30);
            this.kbtnExport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnExport.TabIndex = 24;
            this.kbtnExport.Values.Text = "&Export Colours";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 840);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.MainMenuStrip = this.ms;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDarkColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddleColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightestColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane.Panel)).EndInit();
            this.kgbPreviewPane.Panel.ResumeLayout(false);
            this.kgbPreviewPane.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane)).EndInit();
            this.kgbPreviewPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.PropertyGrid labelGridNormal;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPaletteDefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openExistingPaletteDefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem savePaletteDefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnClose;
        private System.Windows.Forms.PictureBox pbxBaseColour;
        private System.Windows.Forms.PictureBox pbxDarkColour;
        private System.Windows.Forms.PictureBox pbxMiddleColour;
        private System.Windows.Forms.PictureBox pbxLightColour;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbPreviewPane;
        private System.Windows.Forms.PictureBox pbxLightestColour;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblColourOutput;
        private System.Windows.Forms.ToolTip ttInformation;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGenerate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGetColours;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnExport;
    }
}