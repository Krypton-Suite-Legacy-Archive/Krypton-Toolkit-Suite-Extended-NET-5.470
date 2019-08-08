using System.Windows.Forms;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;

namespace Playground
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ms = new System.Windows.Forms.MenuStrip();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIsAdminMode = new System.Windows.Forms.Label();
            this.rtbTextPad = new System.Windows.Forms.RichTextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.kuacsbElevate = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kPal = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recentDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.samplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adobeColourDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aeroWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton21 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.roundedTextbox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.RoundedTextbox();
            this.kryptonSearchBox1 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonSearchBox();
            this.modernProgressBar1 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.ModernProgressBar();
            this.circularPictureBox1 = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kryptonCommandLinkButton2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkButton();
            this.kryptonCommandLinkVersion21 = new ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkVersion2();
            this.kryptonPromptTextBox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kcmbGradientDirection = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tsAlignCentre = new System.Windows.Forms.ToolStripButton();
            this.tsAlignRight = new System.Windows.Forms.ToolStripButton();
            this.tsJustify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsInsertText = new System.Windows.Forms.ToolStripButton();
            this.rxrbTextPad = new ExtendedControls.ExtendedToolkit.Controls.KryptonRichTextBoxExtended();
            this.tsTest = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kryptonNumericUpDownToolStripItem1 = new ExtendedControls.ExtendedToolkit.ToolstripControls.KryptonNumericUpDownToolStripItem();
            this.toolStripMenuItemUACSheld1 = new KryptonExtendedToolkit.ExtendedToolkit.ToolstripControls.ToolStripMenuItemUACSheld();
            this.krtbEditor = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.klblAdminMode = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBoxExtended1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonRichTextBoxExtended();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.etslBlinkTest = new ExtendedControls.ExtendedToolkit.ToolstripControls.ExtendedToolStripStatusLabel();
            this.flashingLabel1 = new ExtendedControls.ExtendedToolkit.ToolstripControls.FlashingLabel();
            this.kryptonCheckSet1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonTextBoxExtended1 = new KryptonToolkitSuiteExtendedCore.KryptonTextBoxExtended();
            this.kryptonButtonExtended1 = new KryptonToolkitSuiteExtendedCore.KryptonButtonExtended();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbGradientDirection)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tsTest.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(1166, 24);
            this.ms.TabIndex = 1;
            this.ms.Text = "menuStrip1";
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(6, 6);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // lblIsAdminMode
            // 
            this.lblIsAdminMode.AutoSize = true;
            this.lblIsAdminMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsAdminMode.Location = new System.Drawing.Point(12, 543);
            this.lblIsAdminMode.Name = "lblIsAdminMode";
            this.lblIsAdminMode.Size = new System.Drawing.Size(267, 21);
            this.lblIsAdminMode.TabIndex = 6;
            this.lblIsAdminMode.Text = "Is running in Administrator mode: {0}";
            // 
            // rtbTextPad
            // 
            this.rtbTextPad.Location = new System.Drawing.Point(16, 45);
            this.rtbTextPad.Name = "rtbTextPad";
            this.rtbTextPad.Size = new System.Drawing.Size(475, 470);
            this.rtbTextPad.TabIndex = 7;
            this.rtbTextPad.Text = "";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(447, 543);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(88, 21);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "Version: {0}";
            // 
            // kuacsbElevate
            // 
            this.kuacsbElevate.Location = new System.Drawing.Point(14, 236);
            this.kuacsbElevate.Name = "kuacsbElevate";
            this.kuacsbElevate.Size = new System.Drawing.Size(135, 26);
            this.kuacsbElevate.TabIndex = 0;
            this.kuacsbElevate.Values.Image = ((System.Drawing.Image)(resources.GetObject("kuacsbElevate.Values.Image")));
            this.kuacsbElevate.Values.Text = "Elevate";
            this.kuacsbElevate.Click += new System.EventHandler(this.kuacsbElevate_Click);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010White;
            // 
            // kPal
            // 
            this.kPal.CustomisedKryptonPaletteFilePath = null;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(174, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem1,
            this.toolStripSeparator6,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1,
            this.recentDocumentsToolStripMenuItem,
            this.toolStripSeparator7,
            this.printToolStripMenuItem1,
            this.printPreviewToolStripMenuItem1,
            this.toolStripSeparator8,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
            this.newToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.newToolStripMenuItem1.Text = "&New";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
            this.openToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.openToolStripMenuItem1.Text = "&Open";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(171, 6);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.saveToolStripMenuItem1.Text = "&Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.saveAsToolStripMenuItem1.Text = "Save &As";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // recentDocumentsToolStripMenuItem
            // 
            this.recentDocumentsToolStripMenuItem.Name = "recentDocumentsToolStripMenuItem";
            this.recentDocumentsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.recentDocumentsToolStripMenuItem.Text = "Re&cent Documents";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(171, 6);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem1.Image")));
            this.printToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.printToolStripMenuItem1.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem1
            // 
            this.printPreviewToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem1.Image")));
            this.printPreviewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem1.Name = "printPreviewToolStripMenuItem1";
            this.printPreviewToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.printPreviewToolStripMenuItem1.Text = "Print Pre&view";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(171, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1,
            this.toolStripSeparator9,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.toolStripSeparator10,
            this.selectAllToolStripMenuItem1});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem1.Text = "&Undo";
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem1.Text = "&Redo";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem1.Image")));
            this.cutToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem1.Text = "Cu&t";
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem1.Image")));
            this.copyToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem1.Text = "&Copy";
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem1.Image")));
            this.pasteToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem1.Text = "&Paste";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem1.Text = "Select &All";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.samplesToolStripMenuItem});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem1.Text = "&Tools";
            // 
            // samplesToolStripMenuItem
            // 
            this.samplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adobeColourDialogToolStripMenuItem,
            this.aeroWizardToolStripMenuItem});
            this.samplesToolStripMenuItem.Name = "samplesToolStripMenuItem";
            this.samplesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.samplesToolStripMenuItem.Text = "&Samples";
            // 
            // adobeColourDialogToolStripMenuItem
            // 
            this.adobeColourDialogToolStripMenuItem.Name = "adobeColourDialogToolStripMenuItem";
            this.adobeColourDialogToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.adobeColourDialogToolStripMenuItem.Text = "Adobe Colour Dialog";
            // 
            // aeroWizardToolStripMenuItem
            // 
            this.aeroWizardToolStripMenuItem.Name = "aeroWizardToolStripMenuItem";
            this.aeroWizardToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.aeroWizardToolStripMenuItem.Text = "Aero Wizard";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem1,
            this.indexToolStripMenuItem1,
            this.searchToolStripMenuItem1,
            this.toolStripSeparator11,
            this.aboutToolStripMenuItem1,
            this.checkForUpdatesToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // contentsToolStripMenuItem1
            // 
            this.contentsToolStripMenuItem1.Name = "contentsToolStripMenuItem1";
            this.contentsToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.contentsToolStripMenuItem1.Text = "&Contents";
            // 
            // indexToolStripMenuItem1
            // 
            this.indexToolStripMenuItem1.Name = "indexToolStripMenuItem1";
            this.indexToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.indexToolStripMenuItem1.Text = "&Index";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.searchToolStripMenuItem1.Text = "&Search";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(168, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem1.Text = "&About...";
            // 
            // checkForUpdatesToolStripMenuItem1
            // 
            this.checkForUpdatesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testsToolStripMenuItem});
            this.checkForUpdatesToolStripMenuItem1.Name = "checkForUpdatesToolStripMenuItem1";
            this.checkForUpdatesToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem1.Text = "&Check for Updates";
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedToolStripMenuItem,
            this.basicToolStripMenuItem});
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.testsToolStripMenuItem.Text = "Tes&ts";
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.advancedToolStripMenuItem.Text = "Ad&vanced";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.basicToolStripMenuItem.Text = "&Basic";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButtonExtended1);
            this.kryptonPanel1.Controls.Add(this.kryptonTextBoxExtended1);
            this.kryptonPanel1.Controls.Add(this.kryptonTextBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonButton21);
            this.kryptonPanel1.Controls.Add(this.roundedTextbox1);
            this.kryptonPanel1.Controls.Add(this.kryptonSearchBox1);
            this.kryptonPanel1.Controls.Add(this.modernProgressBar1);
            this.kryptonPanel1.Controls.Add(this.circularPictureBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonCommandLinkButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonCommandLinkVersion21);
            this.kryptonPanel1.Controls.Add(this.kryptonPromptTextBox1);
            this.kryptonPanel1.Controls.Add(this.kcmbGradientDirection);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.toolStrip2);
            this.kryptonPanel1.Controls.Add(this.rxrbTextPad);
            this.kryptonPanel1.Controls.Add(this.kuacsbElevate);
            this.kryptonPanel1.Controls.Add(this.tsTest);
            this.kryptonPanel1.Controls.Add(this.toolStrip1);
            this.kryptonPanel1.Controls.Add(this.krtbEditor);
            this.kryptonPanel1.Controls.Add(this.klblAdminMode);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1166, 659);
            this.kryptonPanel1.TabIndex = 2;
            this.kryptonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.KryptonPanel1_Paint);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(23, 338);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(559, 23);
            this.kryptonTextBox1.TabIndex = 4;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(663, 308);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton1.TabIndex = 52;
            this.kryptonButton1.Values.Text = "Test Bench";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // kryptonButton21
            // 
            this.kryptonButton21.Location = new System.Drawing.Point(663, 237);
            this.kryptonButton21.Name = "kryptonButton21";
            this.kryptonButton21.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton21.TabIndex = 51;
            this.kryptonButton21.Values.Text = "Test Bench";
            this.kryptonButton21.Click += new System.EventHandler(this.kryptonButton21_Click);
            // 
            // roundedTextbox1
            // 
            this.roundedTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextbox1.Brush = System.Drawing.Color.White;
            this.roundedTextbox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.roundedTextbox1.ForeColor = System.Drawing.Color.DimGray;
            this.roundedTextbox1.Location = new System.Drawing.Point(827, 168);
            this.roundedTextbox1.Name = "roundedTextbox1";
            this.roundedTextbox1.Size = new System.Drawing.Size(197, 33);
            this.roundedTextbox1.TabIndex = 43;
            this.roundedTextbox1.Text = "Hello World!";
            // 
            // kryptonSearchBox1
            // 
            this.kryptonSearchBox1.Location = new System.Drawing.Point(313, 28);
            this.kryptonSearchBox1.Name = "kryptonSearchBox1";
            this.kryptonSearchBox1.Size = new System.Drawing.Size(250, 25);
            this.kryptonSearchBox1.TabIndex = 38;
            // 
            // modernProgressBar1
            // 
            this.modernProgressBar1.AutoSize = true;
            this.modernProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.modernProgressBar1.Location = new System.Drawing.Point(325, 236);
            this.modernProgressBar1.Name = "modernProgressBar1";
            this.modernProgressBar1.Size = new System.Drawing.Size(307, 10);
            this.modernProgressBar1.TabIndex = 37;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.Image = global::Playground.Properties.Resources.KR_32_x_32_Orange;
            this.circularPictureBox1.Location = new System.Drawing.Point(827, 28);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(69, 50);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 35;
            this.circularPictureBox1.TabStop = false;
            // 
            // kryptonCommandLinkButton2
            // 
            this.kryptonCommandLinkButton2.CommandLinkImageValue.Image = null;
            this.kryptonCommandLinkButton2.Location = new System.Drawing.Point(902, 23);
            this.kryptonCommandLinkButton2.Name = "kryptonCommandLinkButton2";
            this.kryptonCommandLinkButton2.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton2.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton2.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton2.Size = new System.Drawing.Size(250, 55);
            this.kryptonCommandLinkButton2.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton2.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCommandLinkButton2.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton2.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton2.TabIndex = 34;
            this.kryptonCommandLinkButton2.Click += new System.EventHandler(this.kryptonCommandLinkButton2_Click);
            // 
            // kryptonCommandLinkVersion21
            // 
            this.kryptonCommandLinkVersion21.Location = new System.Drawing.Point(902, 93);
            this.kryptonCommandLinkVersion21.Name = "kryptonCommandLinkVersion21";
            this.kryptonCommandLinkVersion21.ShowUACShield = true;
            this.kryptonCommandLinkVersion21.Size = new System.Drawing.Size(252, 55);
            this.kryptonCommandLinkVersion21.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCommandLinkVersion21.TabIndex = 33;
            this.kryptonCommandLinkVersion21.Values.ExtraText = "Here be the extra Text";
            this.kryptonCommandLinkVersion21.Values.Image = global::Playground.Properties.Resources.KR_32_x_32_Orange;
            this.kryptonCommandLinkVersion21.Values.Text = "Command Link V2";
            this.kryptonCommandLinkVersion21.Click += new System.EventHandler(this.KryptonCommandLinkVersion21_Click);
            // 
            // kryptonPromptTextBox1
            // 
            this.kryptonPromptTextBox1.DrawPrompt = true;
            this.kryptonPromptTextBox1.FocusSelect = true;
            this.kryptonPromptTextBox1.Location = new System.Drawing.Point(569, 28);
            this.kryptonPromptTextBox1.Name = "kryptonPromptTextBox1";
            this.kryptonPromptTextBox1.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kryptonPromptTextBox1.PromptText = "Some text...";
            this.kryptonPromptTextBox1.PromptTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPromptTextBox1.Size = new System.Drawing.Size(252, 20);
            this.kryptonPromptTextBox1.TabIndex = 4;
            // 
            // kcmbGradientDirection
            // 
            this.kcmbGradientDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbGradientDirection.DropDownWidth = 188;
            this.kcmbGradientDirection.IntegralHeight = false;
            this.kcmbGradientDirection.Location = new System.Drawing.Point(170, 287);
            this.kcmbGradientDirection.Name = "kcmbGradientDirection";
            this.kcmbGradientDirection.Size = new System.Drawing.Size(188, 27);
            this.kcmbGradientDirection.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbGradientDirection.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbGradientDirection.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbGradientDirection.TabIndex = 15;
            this.kcmbGradientDirection.SelectedIndexChanged += new System.EventHandler(this.kcmbGradientDirection_SelectedIndexChanged);
            this.kcmbGradientDirection.TextChanged += new System.EventHandler(this.kcmbGradientDirection_TextChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 287);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(149, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 14;
            this.kryptonLabel1.Values.Text = "Gradient Direction:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAlignLeft,
            this.tsAlignCentre,
            this.tsAlignRight,
            this.tsJustify,
            this.toolStripSeparator2,
            this.tsInsertText});
            this.toolStrip2.Location = new System.Drawing.Point(156, 28);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(133, 25);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsAlignLeft
            // 
            this.tsAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsAlignLeft.Image")));
            this.tsAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlignLeft.Name = "tsAlignLeft";
            this.tsAlignLeft.Size = new System.Drawing.Size(23, 22);
            this.tsAlignLeft.Text = "toolStripButton1";
            this.tsAlignLeft.Click += new System.EventHandler(this.tsAlignLeft_Click);
            // 
            // tsAlignCentre
            // 
            this.tsAlignCentre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAlignCentre.Image = ((System.Drawing.Image)(resources.GetObject("tsAlignCentre.Image")));
            this.tsAlignCentre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlignCentre.Name = "tsAlignCentre";
            this.tsAlignCentre.Size = new System.Drawing.Size(23, 22);
            this.tsAlignCentre.Text = "toolStripButton2";
            this.tsAlignCentre.Click += new System.EventHandler(this.tsAlignCentre_Click);
            // 
            // tsAlignRight
            // 
            this.tsAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tsAlignRight.Image")));
            this.tsAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlignRight.Name = "tsAlignRight";
            this.tsAlignRight.Size = new System.Drawing.Size(23, 22);
            this.tsAlignRight.Text = "toolStripButton3";
            this.tsAlignRight.Click += new System.EventHandler(this.tsAlignRight_Click);
            // 
            // tsJustify
            // 
            this.tsJustify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsJustify.Image = ((System.Drawing.Image)(resources.GetObject("tsJustify.Image")));
            this.tsJustify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsJustify.Name = "tsJustify";
            this.tsJustify.Size = new System.Drawing.Size(23, 22);
            this.tsJustify.Text = "toolStripButton4";
            this.tsJustify.Click += new System.EventHandler(this.tsJustify_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsInsertText
            // 
            this.tsInsertText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsInsertText.Image = ((System.Drawing.Image)(resources.GetObject("tsInsertText.Image")));
            this.tsInsertText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInsertText.Name = "tsInsertText";
            this.tsInsertText.Size = new System.Drawing.Size(23, 22);
            this.tsInsertText.Text = "Insert Text";
            // 
            // rxrbTextPad
            // 
            this.rxrbTextPad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rxrbTextPad.Location = new System.Drawing.Point(159, 56);
            this.rxrbTextPad.Name = "rxrbTextPad";
            this.rxrbTextPad.Size = new System.Drawing.Size(151, 117);
            this.rxrbTextPad.TabIndex = 6;
            this.rxrbTextPad.Text = "kryptonRichTextBoxExtended2";
            // 
            // tsTest
            // 
            this.tsTest.Dock = System.Windows.Forms.DockStyle.None;
            this.tsTest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.tsTest.Location = new System.Drawing.Point(656, 439);
            this.tsTest.Name = "tsTest";
            this.tsTest.Size = new System.Drawing.Size(208, 25);
            this.tsTest.TabIndex = 4;
            this.tsTest.Text = "toolStrip2";
            this.tsTest.Visible = false;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kryptonNumericUpDownToolStripItem1,
            this.toolStripMenuItemUACSheld1});
            this.toolStrip1.Location = new System.Drawing.Point(14, 208);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(251, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // kryptonNumericUpDownToolStripItem1
            // 
            this.kryptonNumericUpDownToolStripItem1.Name = "kryptonNumericUpDownToolStripItem1";
            this.kryptonNumericUpDownToolStripItem1.Size = new System.Drawing.Size(45, 22);
            this.kryptonNumericUpDownToolStripItem1.Text = "0";
            this.kryptonNumericUpDownToolStripItem1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // toolStripMenuItemUACSheld1
            // 
            this.toolStripMenuItemUACSheld1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemUACSheld1.Image")));
            this.toolStripMenuItemUACSheld1.Name = "toolStripMenuItemUACSheld1";
            this.toolStripMenuItemUACSheld1.Size = new System.Drawing.Size(194, 25);
            this.toolStripMenuItemUACSheld1.Text = "toolStripMenuItemUACSheld1";
            this.toolStripMenuItemUACSheld1.Click += new System.EventHandler(this.toolStripMenuItemUACSheld1_Click);
            // 
            // krtbEditor
            // 
            this.krtbEditor.Location = new System.Drawing.Point(13, 28);
            this.krtbEditor.Name = "krtbEditor";
            this.krtbEditor.Size = new System.Drawing.Size(140, 145);
            this.krtbEditor.TabIndex = 1;
            this.krtbEditor.Text = "";
            // 
            // klblAdminMode
            // 
            this.klblAdminMode.Location = new System.Drawing.Point(13, 179);
            this.klblAdminMode.Name = "klblAdminMode";
            this.klblAdminMode.Size = new System.Drawing.Size(283, 26);
            this.klblAdminMode.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblAdminMode.TabIndex = 0;
            this.klblAdminMode.Values.Text = "Is running in Administrator mode: No";
            // 
            // kryptonRichTextBoxExtended1
            // 
            this.kryptonRichTextBoxExtended1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonRichTextBoxExtended1.Location = new System.Drawing.Point(0, 0);
            this.kryptonRichTextBoxExtended1.Name = "kryptonRichTextBoxExtended1";
            this.kryptonRichTextBoxExtended1.Size = new System.Drawing.Size(100, 96);
            this.kryptonRichTextBoxExtended1.TabIndex = 0;
            this.kryptonRichTextBoxExtended1.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.etslBlinkTest,
            this.flashingLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1166, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // etslBlinkTest
            // 
            this.etslBlinkTest.BkClr = false;
            this.etslBlinkTest.BlinkDuration = ((long)(10));
            this.etslBlinkTest.BlinkState = ExtendedControls.Base.Enumerations.BlinkState.NormalBlink;
            this.etslBlinkTest.CycleInterval = ((short)(2000));
            this.etslBlinkTest.EnableBlinking = true;
            this.etslBlinkTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.etslBlinkTest.GradientColourOne = System.Drawing.Color.Lime;
            this.etslBlinkTest.GradientColourTwo = System.Drawing.Color.Red;
            this.etslBlinkTest.Name = "etslBlinkTest";
            this.etslBlinkTest.Size = new System.Drawing.Size(168, 17);
            this.etslBlinkTest.Text = "extendedToolStripStatusLabel2";
            // 
            // flashingLabel1
            // 
            this.flashingLabel1.EnableFlashing = true;
            this.flashingLabel1.FlashColour1 = System.Drawing.Color.Transparent;
            this.flashingLabel1.FlashColour2 = System.Drawing.Color.Red;
            this.flashingLabel1.FlashTimeout = 500;
            this.flashingLabel1.Name = "flashingLabel1";
            this.flashingLabel1.Size = new System.Drawing.Size(83, 20);
            this.flashingLabel1.Text = "flashingLabel1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kryptonTextBoxExtended1
            // 
            this.kryptonTextBoxExtended1.BackgroundColour = System.Drawing.Color.White;
            this.kryptonTextBoxExtended1.Location = new System.Drawing.Point(23, 419);
            this.kryptonTextBoxExtended1.Name = "kryptonTextBoxExtended1";
            this.kryptonTextBoxExtended1.Size = new System.Drawing.Size(559, 37);
            this.kryptonTextBoxExtended1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBoxExtended1.StateCommon.Content.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonTextBoxExtended1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxExtended1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonTextBoxExtended1.TabIndex = 4;
            this.kryptonTextBoxExtended1.Text = "hhhhhhhhh";
            this.kryptonTextBoxExtended1.TextColour = System.Drawing.SystemColors.ControlText;
            this.kryptonTextBoxExtended1.Typeface = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // kryptonButtonExtended1
            // 
            this.kryptonButtonExtended1.BackGroundColourOne = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonButtonExtended1.BackGroundColourTwo = System.Drawing.Color.Yellow;
            this.kryptonButtonExtended1.Image = null;
            this.kryptonButtonExtended1.Location = new System.Drawing.Point(599, 419);
            this.kryptonButtonExtended1.Name = "kryptonButtonExtended1";
            this.kryptonButtonExtended1.Size = new System.Drawing.Size(297, 37);
            this.kryptonButtonExtended1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonButtonExtended1.StateCommon.Back.Color2 = System.Drawing.Color.Yellow;
            this.kryptonButtonExtended1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.kryptonButtonExtended1.StateCommon.Content.LongText.Color2 = System.Drawing.Color.Yellow;
            this.kryptonButtonExtended1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButtonExtended1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonButtonExtended1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Yellow;
            this.kryptonButtonExtended1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButtonExtended1.TabIndex = 4;
            this.kryptonButtonExtended1.TextColourOne = System.Drawing.Color.Red;
            this.kryptonButtonExtended1.TextColourTwo = System.Drawing.Color.Yellow;
            this.kryptonButtonExtended1.Typeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButtonExtended1.Values.Text = "kryptonButtonExtended1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 659);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbGradientDirection)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tsTest.ResumeLayout(false);
            this.tsTest.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void KryptonCommandLinkButton1_Click(object sender, System.EventArgs e)
        {
            ExtendedKryptonMessageBox.Show(this, @"You just clicked the CommandLinkButton!", @"Clicked",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.Label lblIsAdminMode;
        private System.Windows.Forms.RichTextBox rtbTextPad;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.Label lblVersion;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton kuacsbElevate;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentDocumentsToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox krtbEditor;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblAdminMode;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ExtendedControls.ExtendedToolkit.ToolstripControls.KryptonNumericUpDownToolStripItem kryptonNumericUpDownToolStripItem1;
        private KryptonExtendedToolkit.ExtendedToolkit.ToolstripControls.ToolStripMenuItemUACSheld toolStripMenuItemUACSheld1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonRichTextBoxExtended kryptonRichTextBoxExtended1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kPal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip tsTest;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private ExtendedControls.ExtendedToolkit.ToolstripControls.ExtendedToolStripStatusLabel etslBlinkTest;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsAlignLeft;
        private System.Windows.Forms.ToolStripButton tsAlignCentre;
        private System.Windows.Forms.ToolStripButton tsAlignRight;
        private System.Windows.Forms.ToolStripButton tsJustify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsInsertText;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonRichTextBoxExtended rxrbTextPad;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbGradientDirection;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet kryptonCheckSet1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox kryptonPromptTextBox1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkVersion2 kryptonCommandLinkVersion21;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkButton kryptonCommandLinkButton2;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonSearchBox kryptonSearchBox1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.ModernProgressBar modernProgressBar1;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox circularPictureBox1;
        private Timer timer1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.RoundedTextbox roundedTextbox1;
        private ExtendedControls.ExtendedToolkit.ToolstripControls.FlashingLabel flashingLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton21;
        private ToolStripMenuItem samplesToolStripMenuItem;
        private ToolStripMenuItem adobeColourDialogToolStripMenuItem;
        private ToolStripMenuItem aeroWizardToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private KryptonToolkitSuiteExtendedCore.KryptonTextBoxExtended kryptonTextBoxExtended1;
        private KryptonToolkitSuiteExtendedCore.KryptonButtonExtended kryptonButtonExtended1;
    }
}

