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
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kcmbBasePaletteMode = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel32 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnExportPalette = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGetColours = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kgbPreviewPane = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pbxLinkVisitedColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxLinkHoverColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxAlternativeNormalTextColour = new System.Windows.Forms.PictureBox();
            this.pbxLinkNormalColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxDisabledColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxPressedTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxFocusedTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxDisabledTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxNormalTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxBorderColourPreview = new System.Windows.Forms.PictureBox();
            this.lblColourOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pbxBaseColour = new System.Windows.Forms.PictureBox();
            this.pbxLightestColour = new System.Windows.Forms.PictureBox();
            this.pbxDarkColour = new System.Windows.Forms.PictureBox();
            this.pbxLightColour = new System.Windows.Forms.PictureBox();
            this.pbxMiddleColour = new System.Windows.Forms.PictureBox();
            this.labelGridNormal = new System.Windows.Forms.PropertyGrid();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPaletteDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openExistingPaletteDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.savePaletteDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePaletteDefinitionAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttInformation = new System.Windows.Forms.ToolTip(this.components);
            this.palette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.ss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbBasePaletteMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane.Panel)).BeginInit();
            this.kgbPreviewPane.Panel.SuspendLayout();
            this.kgbPreviewPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkVisitedColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkHoverColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlternativeNormalTextColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkNormalColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPressedTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFocusedTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNormalTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBorderColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightestColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDarkColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddleColour)).BeginInit();
            this.ms.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.ss);
            this.kryptonPanel1.Controls.Add(this.kbtnClose);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 790);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1288, 75);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.ss.Location = new System.Drawing.Point(0, 53);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(1288, 22);
            this.ss.TabIndex = 45;
            this.ss.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(1273, 17);
            this.tslStatus.Spring = true;
            this.tslStatus.Text = "Ready";
            this.tslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kcmbBasePaletteMode);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel32);
            this.kryptonPanel2.Controls.Add(this.kbtnExportPalette);
            this.kryptonPanel2.Controls.Add(this.kbtnExport);
            this.kryptonPanel2.Controls.Add(this.kbtnGetColours);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerate);
            this.kryptonPanel2.Controls.Add(this.kgbPreviewPane);
            this.kryptonPanel2.Controls.Add(this.labelGridNormal);
            this.kryptonPanel2.Controls.Add(this.ms);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1288, 790);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kcmbBasePaletteMode
            // 
            this.kcmbBasePaletteMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbBasePaletteMode.DropDownWidth = 173;
            this.kcmbBasePaletteMode.Location = new System.Drawing.Point(501, 173);
            this.kcmbBasePaletteMode.Name = "kcmbBasePaletteMode";
            this.kcmbBasePaletteMode.Size = new System.Drawing.Size(173, 27);
            this.kcmbBasePaletteMode.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbBasePaletteMode.TabIndex = 111;
            // 
            // kryptonLabel32
            // 
            this.kryptonLabel32.Location = new System.Drawing.Point(335, 174);
            this.kryptonLabel32.Name = "kryptonLabel32";
            this.kryptonLabel32.Size = new System.Drawing.Size(160, 26);
            this.kryptonLabel32.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel32.TabIndex = 110;
            this.kryptonLabel32.Values.Text = "Base Palette Mode:";
            // 
            // kbtnExportPalette
            // 
            this.kbtnExportPalette.AutoSize = true;
            this.kbtnExportPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnExportPalette.Location = new System.Drawing.Point(156, 170);
            this.kbtnExportPalette.Name = "kbtnExportPalette";
            this.kbtnExportPalette.Size = new System.Drawing.Size(173, 30);
            this.kbtnExportPalette.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnExportPalette.TabIndex = 25;
            this.kbtnExportPalette.Values.Text = "Export &Palette Colours";
            this.kbtnExportPalette.Click += new System.EventHandler(this.kbtnExportPalette_Click);
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
            this.kbtnExport.Click += new System.EventHandler(this.kbtnExport_Click);
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
            this.kbtnGetColours.Click += new System.EventHandler(this.kbtnGetColours_Click);
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
            this.kbtnGenerate.Click += new System.EventHandler(this.kbtnGenerate_Click);
            // 
            // kgbPreviewPane
            // 
            this.kgbPreviewPane.Location = new System.Drawing.Point(12, 251);
            this.kgbPreviewPane.Name = "kgbPreviewPane";
            // 
            // kgbPreviewPane.Panel
            // 
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLinkVisitedColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLinkHoverColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxAlternativeNormalTextColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLinkNormalColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxDisabledColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxPressedTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxFocusedTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxDisabledTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxNormalTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxBorderColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.lblColourOutput);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxBaseColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLightestColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxDarkColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLightColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxMiddleColour);
            this.kgbPreviewPane.Size = new System.Drawing.Size(844, 513);
            this.kgbPreviewPane.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbPreviewPane.TabIndex = 9;
            this.kgbPreviewPane.Values.Heading = "Colour Preview";
            // 
            // pbxLinkVisitedColourPreview
            // 
            this.pbxLinkVisitedColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkVisitedColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkVisitedColourPreview.Location = new System.Drawing.Point(695, 283);
            this.pbxLinkVisitedColourPreview.Name = "pbxLinkVisitedColourPreview";
            this.pbxLinkVisitedColourPreview.Size = new System.Drawing.Size(128, 128);
            this.pbxLinkVisitedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkVisitedColourPreview.TabIndex = 72;
            this.pbxLinkVisitedColourPreview.TabStop = false;
            // 
            // pbxLinkHoverColourPreview
            // 
            this.pbxLinkHoverColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkHoverColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkHoverColourPreview.Location = new System.Drawing.Point(526, 283);
            this.pbxLinkHoverColourPreview.Name = "pbxLinkHoverColourPreview";
            this.pbxLinkHoverColourPreview.Size = new System.Drawing.Size(128, 128);
            this.pbxLinkHoverColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkHoverColourPreview.TabIndex = 71;
            this.pbxLinkHoverColourPreview.TabStop = false;
            // 
            // pbxAlternativeNormalTextColour
            // 
            this.pbxAlternativeNormalTextColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxAlternativeNormalTextColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxAlternativeNormalTextColour.Location = new System.Drawing.Point(188, 149);
            this.pbxAlternativeNormalTextColour.Name = "pbxAlternativeNormalTextColour";
            this.pbxAlternativeNormalTextColour.Size = new System.Drawing.Size(128, 128);
            this.pbxAlternativeNormalTextColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAlternativeNormalTextColour.TabIndex = 70;
            this.pbxAlternativeNormalTextColour.TabStop = false;
            // 
            // pbxLinkNormalColourPreview
            // 
            this.pbxLinkNormalColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkNormalColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkNormalColourPreview.Location = new System.Drawing.Point(357, 283);
            this.pbxLinkNormalColourPreview.Name = "pbxLinkNormalColourPreview";
            this.pbxLinkNormalColourPreview.Size = new System.Drawing.Size(128, 128);
            this.pbxLinkNormalColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkNormalColourPreview.TabIndex = 69;
            this.pbxLinkNormalColourPreview.TabStop = false;
            // 
            // pbxDisabledColourPreview
            // 
            this.pbxDisabledColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxDisabledColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxDisabledColourPreview.Location = new System.Drawing.Point(188, 283);
            this.pbxDisabledColourPreview.Name = "pbxDisabledColourPreview";
            this.pbxDisabledColourPreview.Size = new System.Drawing.Size(128, 128);
            this.pbxDisabledColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxDisabledColourPreview.TabIndex = 68;
            this.pbxDisabledColourPreview.TabStop = false;
            // 
            // pbxPressedTextColourPreview
            // 
            this.pbxPressedTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxPressedTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPressedTextColourPreview.Location = new System.Drawing.Point(19, 283);
            this.pbxPressedTextColourPreview.Name = "pbxPressedTextColourPreview";
            this.pbxPressedTextColourPreview.Size = new System.Drawing.Size(128, 128);
            this.pbxPressedTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPressedTextColourPreview.TabIndex = 67;
            this.pbxPressedTextColourPreview.TabStop = false;
            // 
            // pbxFocusedTextColourPreview
            // 
            this.pbxFocusedTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxFocusedTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxFocusedTextColourPreview.Location = new System.Drawing.Point(695, 149);
            this.pbxFocusedTextColourPreview.Name = "pbxFocusedTextColourPreview";
            this.pbxFocusedTextColourPreview.Size = new System.Drawing.Size(128, 128);
            this.pbxFocusedTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxFocusedTextColourPreview.TabIndex = 66;
            this.pbxFocusedTextColourPreview.TabStop = false;
            // 
            // pbxDisabledTextColourPreview
            // 
            this.pbxDisabledTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxDisabledTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxDisabledTextColourPreview.Location = new System.Drawing.Point(526, 149);
            this.pbxDisabledTextColourPreview.Name = "pbxDisabledTextColourPreview";
            this.pbxDisabledTextColourPreview.Size = new System.Drawing.Size(128, 128);
            this.pbxDisabledTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxDisabledTextColourPreview.TabIndex = 65;
            this.pbxDisabledTextColourPreview.TabStop = false;
            // 
            // pbxNormalTextColourPreview
            // 
            this.pbxNormalTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxNormalTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxNormalTextColourPreview.Location = new System.Drawing.Point(357, 149);
            this.pbxNormalTextColourPreview.Name = "pbxNormalTextColourPreview";
            this.pbxNormalTextColourPreview.Size = new System.Drawing.Size(128, 128);
            this.pbxNormalTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxNormalTextColourPreview.TabIndex = 64;
            this.pbxNormalTextColourPreview.TabStop = false;
            // 
            // pbxBorderColourPreview
            // 
            this.pbxBorderColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxBorderColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxBorderColourPreview.Location = new System.Drawing.Point(19, 149);
            this.pbxBorderColourPreview.Name = "pbxBorderColourPreview";
            this.pbxBorderColourPreview.Size = new System.Drawing.Size(128, 128);
            this.pbxBorderColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBorderColourPreview.TabIndex = 63;
            this.pbxBorderColourPreview.TabStop = false;
            // 
            // lblColourOutput
            // 
            this.lblColourOutput.Location = new System.Drawing.Point(19, 440);
            this.lblColourOutput.Name = "lblColourOutput";
            this.lblColourOutput.Size = new System.Drawing.Size(203, 26);
            this.lblColourOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourOutput.TabIndex = 62;
            this.lblColourOutput.Values.Text = "Colour Values for: {0} {1}";
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
            this.pbxBaseColour.MouseEnter += new System.EventHandler(this.pbxBaseColour_MouseEnter);
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
            this.pbxLightestColour.MouseEnter += new System.EventHandler(this.pbxLightestColour_MouseEnter);
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
            this.pbxDarkColour.MouseEnter += new System.EventHandler(this.pbxDarkColour_MouseEnter);
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
            this.pbxLightColour.MouseEnter += new System.EventHandler(this.pbxLightColour_MouseEnter);
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
            this.pbxMiddleColour.MouseEnter += new System.EventHandler(this.pbxMiddleColour_MouseEnter);
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
            this.savePaletteDefinitionAsToolStripMenuItem,
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
            this.newPaletteDefinitionToolStripMenuItem.Click += new System.EventHandler(this.newPaletteDefinitionToolStripMenuItem_Click);
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
            this.openExistingPaletteDefinitionToolStripMenuItem.Click += new System.EventHandler(this.openExistingPaletteDefinitionToolStripMenuItem_Click);
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
            this.savePaletteDefinitionToolStripMenuItem.Click += new System.EventHandler(this.savePaletteDefinitionToolStripMenuItem_Click);
            // 
            // savePaletteDefinitionAsToolStripMenuItem
            // 
            this.savePaletteDefinitionAsToolStripMenuItem.Name = "savePaletteDefinitionAsToolStripMenuItem";
            this.savePaletteDefinitionAsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.savePaletteDefinitionAsToolStripMenuItem.Text = "Save Palette Definition &As";
            this.savePaletteDefinitionAsToolStripMenuItem.Click += new System.EventHandler(this.savePaletteDefinitionAsToolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 788);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 2);
            this.panel1.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 865);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.ms;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbBasePaletteMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane.Panel)).EndInit();
            this.kgbPreviewPane.Panel.ResumeLayout(false);
            this.kgbPreviewPane.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane)).EndInit();
            this.kgbPreviewPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkVisitedColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkHoverColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlternativeNormalTextColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkNormalColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPressedTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFocusedTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNormalTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBorderColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightestColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDarkColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddleColour)).EndInit();
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
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
        private ComponentFactory.Krypton.Toolkit.KryptonPalette palette;
        private System.Windows.Forms.PictureBox pbxPressedTextColourPreview;
        private System.Windows.Forms.PictureBox pbxFocusedTextColourPreview;
        private System.Windows.Forms.PictureBox pbxDisabledTextColourPreview;
        private System.Windows.Forms.PictureBox pbxNormalTextColourPreview;
        private System.Windows.Forms.PictureBox pbxBorderColourPreview;
        private System.Windows.Forms.ToolStripMenuItem savePaletteDefinitionAsToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnExportPalette;
        private System.Windows.Forms.PictureBox pbxLinkNormalColourPreview;
        private System.Windows.Forms.PictureBox pbxDisabledColourPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbBasePaletteMode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel32;
        private System.Windows.Forms.PictureBox pbxAlternativeNormalTextColour;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.PictureBox pbxLinkVisitedColourPreview;
        private System.Windows.Forms.PictureBox pbxLinkHoverColourPreview;
        private System.Windows.Forms.Panel panel1;
    }
}