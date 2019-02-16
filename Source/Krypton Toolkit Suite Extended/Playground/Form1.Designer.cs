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
            this.customizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.kryptonButton19 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPropertyGrid1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid();
            this.kryptonRichTextBoxExtended1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonRichTextBoxExtended();
            this.kryptonButton18 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton17 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton16 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton15 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.roundedTextbox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.RoundedTextbox();
            this.kryptonButton14 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton13 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton12 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonSearchBox1 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonSearchBox();
            this.modernProgressBar1 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.ModernProgressBar();
            this.kryptonSlideButton1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonSlideButton();
            this.circularPictureBox1 = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kryptonCommandLinkButton2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkButton();
            this.kryptonCommandLinkVersion21 = new ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkVersion2();
            this.kryptonButton11 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton10 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPromptTextBox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kryptonButton9 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton8 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton7 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnPaletteEditor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnMessageboxTest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcbtnBackwardDiagonal = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kcbtnForwardDiagonal = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kcbtnVertical = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kcbtnHorizontal = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kcmbGradientDirection = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcbtnTextColour = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.kcbtnGradientColour2 = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.kcbtnGradientColour1 = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.kbtnColourCreator = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnColourMixer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnHexToRGB = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tsAlignCentre = new System.Windows.Forms.ToolStripButton();
            this.tsAlignRight = new System.Windows.Forms.ToolStripButton();
            this.tsJustify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsInsertText = new System.Windows.Forms.ToolStripButton();
            this.rxrbTextPad = new ExtendedControls.ExtendedToolkit.Controls.KryptonRichTextBoxExtended();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.etslBlinkTest = new ExtendedControls.ExtendedToolkit.ToolstripControls.ExtendedToolStripStatusLabel();
            this.flashingLabel1 = new ExtendedControls.ExtendedToolkit.ToolstripControls.FlashingLabel();
            this.kryptonCheckSet1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.menuStrip2.Size = new System.Drawing.Size(175, 24);
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
            this.customizeToolStripMenuItem1,
            this.optionsToolStripMenuItem1});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem1.Text = "&Tools";
            // 
            // customizeToolStripMenuItem1
            // 
            this.customizeToolStripMenuItem1.Name = "customizeToolStripMenuItem1";
            this.customizeToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem1.Text = "&Customize";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem1.Text = "&Options";
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
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
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
            this.kryptonPanel1.Controls.Add(this.kryptonButton19);
            this.kryptonPanel1.Controls.Add(this.kryptonPropertyGrid1);
            this.kryptonPanel1.Controls.Add(this.kryptonButton18);
            this.kryptonPanel1.Controls.Add(this.kryptonButton17);
            this.kryptonPanel1.Controls.Add(this.kryptonButton16);
            this.kryptonPanel1.Controls.Add(this.kryptonButton15);
            this.kryptonPanel1.Controls.Add(this.roundedTextbox1);
            this.kryptonPanel1.Controls.Add(this.kryptonButton14);
            this.kryptonPanel1.Controls.Add(this.kryptonButton13);
            this.kryptonPanel1.Controls.Add(this.kryptonButton12);
            this.kryptonPanel1.Controls.Add(this.kryptonSearchBox1);
            this.kryptonPanel1.Controls.Add(this.modernProgressBar1);
            this.kryptonPanel1.Controls.Add(this.kryptonSlideButton1);
            this.kryptonPanel1.Controls.Add(this.circularPictureBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonCommandLinkButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonCommandLinkVersion21);
            this.kryptonPanel1.Controls.Add(this.kryptonButton11);
            this.kryptonPanel1.Controls.Add(this.kryptonButton10);
            this.kryptonPanel1.Controls.Add(this.kryptonPromptTextBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonButton9);
            this.kryptonPanel1.Controls.Add(this.kryptonButton8);
            this.kryptonPanel1.Controls.Add(this.kryptonButton7);
            this.kryptonPanel1.Controls.Add(this.kryptonButton6);
            this.kryptonPanel1.Controls.Add(this.kryptonButton5);
            this.kryptonPanel1.Controls.Add(this.kryptonButton4);
            this.kryptonPanel1.Controls.Add(this.kryptonButton3);
            this.kryptonPanel1.Controls.Add(this.kbtnPaletteEditor);
            this.kryptonPanel1.Controls.Add(this.kbtnMessageboxTest);
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Controls.Add(this.kcbtnBackwardDiagonal);
            this.kryptonPanel1.Controls.Add(this.kcbtnForwardDiagonal);
            this.kryptonPanel1.Controls.Add(this.kcbtnVertical);
            this.kryptonPanel1.Controls.Add(this.kcbtnHorizontal);
            this.kryptonPanel1.Controls.Add(this.kcmbGradientDirection);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kcbtnTextColour);
            this.kryptonPanel1.Controls.Add(this.kcbtnGradientColour2);
            this.kryptonPanel1.Controls.Add(this.kcbtnGradientColour1);
            this.kryptonPanel1.Controls.Add(this.kbtnColourCreator);
            this.kryptonPanel1.Controls.Add(this.kbtnColourMixer);
            this.kryptonPanel1.Controls.Add(this.kbtnHexToRGB);
            this.kryptonPanel1.Controls.Add(this.toolStrip2);
            this.kryptonPanel1.Controls.Add(this.rxrbTextPad);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
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
            // 
            // kryptonButton19
            // 
            this.kryptonButton19.Location = new System.Drawing.Point(481, 557);
            this.kryptonButton19.Name = "kryptonButton19";
            this.kryptonButton19.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton19.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton19.TabIndex = 49;
            this.kryptonButton19.Values.Text = "Property Grid";
            this.kryptonButton19.Click += new System.EventHandler(this.kryptonButton19_Click);
            // 
            // kryptonPropertyGrid1
            // 
            this.kryptonPropertyGrid1.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonPropertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kryptonPropertyGrid1.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonPropertyGrid1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kryptonPropertyGrid1.Location = new System.Drawing.Point(934, 207);
            this.kryptonPropertyGrid1.Name = "kryptonPropertyGrid1";
            this.kryptonPropertyGrid1.SelectedObject = this.kryptonRichTextBoxExtended1;
            this.kryptonPropertyGrid1.Size = new System.Drawing.Size(220, 384);
            this.kryptonPropertyGrid1.TabIndex = 48;
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
            // kryptonButton18
            // 
            this.kryptonButton18.Location = new System.Drawing.Point(481, 518);
            this.kryptonButton18.Name = "kryptonButton18";
            this.kryptonButton18.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton18.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton18.TabIndex = 47;
            this.kryptonButton18.Values.Text = "Messagebox Test 2";
            this.kryptonButton18.Click += new System.EventHandler(this.kryptonButton18_Click);
            // 
            // kryptonButton17
            // 
            this.kryptonButton17.Location = new System.Drawing.Point(481, 479);
            this.kryptonButton17.Name = "kryptonButton17";
            this.kryptonButton17.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton17.TabIndex = 46;
            this.kryptonButton17.Values.Text = "File Explorer";
            this.kryptonButton17.Click += new System.EventHandler(this.kryptonButton17_Click);
            // 
            // kryptonButton16
            // 
            this.kryptonButton16.Location = new System.Drawing.Point(481, 440);
            this.kryptonButton16.Name = "kryptonButton16";
            this.kryptonButton16.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton16.TabIndex = 45;
            this.kryptonButton16.Values.Text = "File Browser";
            this.kryptonButton16.Click += new System.EventHandler(this.kryptonButton16_Click);
            // 
            // kryptonButton15
            // 
            this.kryptonButton15.Location = new System.Drawing.Point(482, 401);
            this.kryptonButton15.Name = "kryptonButton15";
            this.kryptonButton15.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton15.TabIndex = 44;
            this.kryptonButton15.Values.Text = "Adobe Colour Dialog";
            this.kryptonButton15.Click += new System.EventHandler(this.kryptonButton15_Click);
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
            // kryptonButton14
            // 
            this.kryptonButton14.Location = new System.Drawing.Point(482, 362);
            this.kryptonButton14.Name = "kryptonButton14";
            this.kryptonButton14.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton14.TabIndex = 42;
            this.kryptonButton14.Values.Text = "Colour Wheel";
            this.kryptonButton14.Click += new System.EventHandler(this.kryptonButton14_Click);
            // 
            // kryptonButton13
            // 
            this.kryptonButton13.Location = new System.Drawing.Point(482, 323);
            this.kryptonButton13.Name = "kryptonButton13";
            this.kryptonButton13.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton13.TabIndex = 40;
            this.kryptonButton13.Values.Text = "More Controls...";
            this.kryptonButton13.Click += new System.EventHandler(this.kryptonButton13_Click);
            // 
            // kryptonButton12
            // 
            this.kryptonButton12.Location = new System.Drawing.Point(482, 284);
            this.kryptonButton12.Name = "kryptonButton12";
            this.kryptonButton12.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton12.TabIndex = 39;
            this.kryptonButton12.Values.Text = "Wizard";
            this.kryptonButton12.Click += new System.EventHandler(this.kryptonButton12_Click);
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
            // kryptonSlideButton1
            // 
            this.kryptonSlideButton1.Location = new System.Drawing.Point(915, 28);
            this.kryptonSlideButton1.Name = "kryptonSlideButton1";
            this.kryptonSlideButton1.Size = new System.Drawing.Size(158, 38);
            this.kryptonSlideButton1.TabIndex = 36;
            this.kryptonSlideButton1.Text = "kryptonSlideButton1";
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
            this.kryptonCommandLinkButton2.Location = new System.Drawing.Point(678, 208);
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
            this.kryptonCommandLinkVersion21.Location = new System.Drawing.Point(821, 106);
            this.kryptonCommandLinkVersion21.Name = "kryptonCommandLinkVersion21";
            this.kryptonCommandLinkVersion21.ShowUACShield = true;
            this.kryptonCommandLinkVersion21.Size = new System.Drawing.Size(252, 55);
            this.kryptonCommandLinkVersion21.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCommandLinkVersion21.TabIndex = 33;
            this.kryptonCommandLinkVersion21.Values.ExtraText = "Here be the extra Text";
            this.kryptonCommandLinkVersion21.Values.Image = global::Playground.Properties.Resources.KR_32_x_32_Orange;
            this.kryptonCommandLinkVersion21.Values.Text = "Command Link V2";
            // 
            // kryptonButton11
            // 
            this.kryptonButton11.Location = new System.Drawing.Point(257, 362);
            this.kryptonButton11.Name = "kryptonButton11";
            this.kryptonButton11.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton11.TabIndex = 31;
            this.kryptonButton11.Values.Text = "Convert Colour (Hex to RGB)";
            this.kryptonButton11.Click += new System.EventHandler(this.kryptonButton11_Click);
            // 
            // kryptonButton10
            // 
            this.kryptonButton10.Location = new System.Drawing.Point(14, 557);
            this.kryptonButton10.Name = "kryptonButton10";
            this.kryptonButton10.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton10.TabIndex = 30;
            this.kryptonButton10.Values.Text = "Global Options";
            this.kryptonButton10.Click += new System.EventHandler(this.kryptonButton10_Click);
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
            // kryptonButton9
            // 
            this.kryptonButton9.Location = new System.Drawing.Point(257, 557);
            this.kryptonButton9.Name = "kryptonButton9";
            this.kryptonButton9.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton9.TabIndex = 29;
            this.kryptonButton9.Values.Text = "Theme Options";
            this.kryptonButton9.Click += new System.EventHandler(this.kryptonButton9_Click);
            // 
            // kryptonButton8
            // 
            this.kryptonButton8.Location = new System.Drawing.Point(14, 518);
            this.kryptonButton8.Name = "kryptonButton8";
            this.kryptonButton8.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton8.TabIndex = 28;
            this.kryptonButton8.Values.Text = "Settings Options";
            this.kryptonButton8.Click += new System.EventHandler(this.kryptonButton8_Click);
            // 
            // kryptonButton7
            // 
            this.kryptonButton7.Location = new System.Drawing.Point(14, 479);
            this.kryptonButton7.Name = "kryptonButton7";
            this.kryptonButton7.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton7.TabIndex = 27;
            this.kryptonButton7.Values.Text = "Colour Chooser 1";
            this.kryptonButton7.Click += new System.EventHandler(this.kryptonButton7_Click);
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.Location = new System.Drawing.Point(257, 518);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton6.TabIndex = 26;
            this.kryptonButton6.Values.Text = "Colour Chooser 2";
            this.kryptonButton6.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.Location = new System.Drawing.Point(14, 401);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton5.TabIndex = 25;
            this.kryptonButton5.Values.Text = "Scrollbars";
            this.kryptonButton5.Click += new System.EventHandler(this.kryptonButton5_Click);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(14, 440);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton4.TabIndex = 24;
            this.kryptonButton4.Values.Text = "Toolstrips";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(257, 479);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton3.TabIndex = 23;
            this.kryptonButton3.Values.Text = "Typeface Selection Dialogue";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kbtnPaletteEditor
            // 
            this.kbtnPaletteEditor.Location = new System.Drawing.Point(14, 362);
            this.kbtnPaletteEditor.Name = "kbtnPaletteEditor";
            this.kbtnPaletteEditor.Size = new System.Drawing.Size(218, 25);
            this.kbtnPaletteEditor.TabIndex = 22;
            this.kbtnPaletteEditor.Values.Text = "Palette Editor";
            this.kbtnPaletteEditor.Click += new System.EventHandler(this.kbtnPaletteEditor_Click);
            // 
            // kbtnMessageboxTest
            // 
            this.kbtnMessageboxTest.Location = new System.Drawing.Point(14, 323);
            this.kbtnMessageboxTest.Name = "kbtnMessageboxTest";
            this.kbtnMessageboxTest.Size = new System.Drawing.Size(218, 25);
            this.kbtnMessageboxTest.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnMessageboxTest.TabIndex = 21;
            this.kbtnMessageboxTest.Values.Text = "Messagebox Test";
            this.kbtnMessageboxTest.Click += new System.EventHandler(this.kbtnMessageboxTest_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(14, 284);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton2.TabIndex = 20;
            this.kryptonButton2.Values.Text = "File Creator";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kcbtnBackwardDiagonal
            // 
            this.kcbtnBackwardDiagonal.Location = new System.Drawing.Point(326, 199);
            this.kcbtnBackwardDiagonal.Name = "kcbtnBackwardDiagonal";
            this.kcbtnBackwardDiagonal.Size = new System.Drawing.Size(150, 25);
            this.kcbtnBackwardDiagonal.TabIndex = 19;
            this.kcbtnBackwardDiagonal.Values.Text = "&Backward Diagonal";
            this.kcbtnBackwardDiagonal.Click += new System.EventHandler(this.kcbtnBackwardDiagonal_Click);
            // 
            // kcbtnForwardDiagonal
            // 
            this.kcbtnForwardDiagonal.Checked = true;
            this.kcbtnForwardDiagonal.Location = new System.Drawing.Point(637, 168);
            this.kcbtnForwardDiagonal.Name = "kcbtnForwardDiagonal";
            this.kcbtnForwardDiagonal.Size = new System.Drawing.Size(150, 25);
            this.kcbtnForwardDiagonal.TabIndex = 18;
            this.kcbtnForwardDiagonal.Values.Text = "&Forward Diagonal";
            this.kcbtnForwardDiagonal.Click += new System.EventHandler(this.kcbtnForwardDiagonal_Click);
            // 
            // kcbtnVertical
            // 
            this.kcbtnVertical.Location = new System.Drawing.Point(481, 168);
            this.kcbtnVertical.Name = "kcbtnVertical";
            this.kcbtnVertical.Size = new System.Drawing.Size(150, 25);
            this.kcbtnVertical.TabIndex = 17;
            this.kcbtnVertical.Values.Text = "Ver&tical";
            this.kcbtnVertical.Click += new System.EventHandler(this.kcbtnVertical_Click);
            // 
            // kcbtnHorizontal
            // 
            this.kcbtnHorizontal.Location = new System.Drawing.Point(325, 168);
            this.kcbtnHorizontal.Name = "kcbtnHorizontal";
            this.kcbtnHorizontal.Size = new System.Drawing.Size(150, 25);
            this.kcbtnHorizontal.TabIndex = 16;
            this.kcbtnHorizontal.Values.Text = "&Horizontal";
            this.kcbtnHorizontal.Click += new System.EventHandler(this.kcbtnHorizontal_Click);
            // 
            // kcmbGradientDirection
            // 
            this.kcmbGradientDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbGradientDirection.DropDownWidth = 188;
            this.kcmbGradientDirection.Location = new System.Drawing.Point(482, 135);
            this.kcmbGradientDirection.Name = "kcmbGradientDirection";
            this.kcmbGradientDirection.Size = new System.Drawing.Size(188, 27);
            this.kcmbGradientDirection.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbGradientDirection.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbGradientDirection.TabIndex = 15;
            this.kcmbGradientDirection.SelectedIndexChanged += new System.EventHandler(this.kcmbGradientDirection_SelectedIndexChanged);
            this.kcmbGradientDirection.TextChanged += new System.EventHandler(this.kcmbGradientDirection_TextChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(326, 135);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(149, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 14;
            this.kryptonLabel1.Values.Text = "Gradient Direction:";
            // 
            // kcbtnTextColour
            // 
            this.kcbtnTextColour.AutoSize = true;
            this.kcbtnTextColour.Location = new System.Drawing.Point(609, 93);
            this.kcbtnTextColour.Name = "kcbtnTextColour";
            this.kcbtnTextColour.Size = new System.Drawing.Size(136, 25);
            this.kcbtnTextColour.TabIndex = 13;
            this.kcbtnTextColour.Values.Text = "Text Colour";
            this.kcbtnTextColour.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.kcbtnTextColour_SelectedColorChanged);
            // 
            // kcbtnGradientColour2
            // 
            this.kcbtnGradientColour2.AutoSize = true;
            this.kcbtnGradientColour2.Location = new System.Drawing.Point(467, 93);
            this.kcbtnGradientColour2.Name = "kcbtnGradientColour2";
            this.kcbtnGradientColour2.Size = new System.Drawing.Size(136, 25);
            this.kcbtnGradientColour2.TabIndex = 12;
            this.kcbtnGradientColour2.Values.Text = "Gradient Colour 2";
            this.kcbtnGradientColour2.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.kcbtnGradientColour2_SelectedColorChanged);
            // 
            // kcbtnGradientColour1
            // 
            this.kcbtnGradientColour1.AutoSize = true;
            this.kcbtnGradientColour1.Location = new System.Drawing.Point(325, 93);
            this.kcbtnGradientColour1.Name = "kcbtnGradientColour1";
            this.kcbtnGradientColour1.Size = new System.Drawing.Size(136, 25);
            this.kcbtnGradientColour1.TabIndex = 11;
            this.kcbtnGradientColour1.Values.Text = "Gradient Colour 1";
            this.kcbtnGradientColour1.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.kcbtnGradientColour1_SelectedColorChanged);
            // 
            // kbtnColourCreator
            // 
            this.kbtnColourCreator.Location = new System.Drawing.Point(257, 440);
            this.kbtnColourCreator.Name = "kbtnColourCreator";
            this.kbtnColourCreator.Size = new System.Drawing.Size(218, 25);
            this.kbtnColourCreator.TabIndex = 10;
            this.kbtnColourCreator.Values.Text = "Colour Creator";
            this.kbtnColourCreator.Click += new System.EventHandler(this.kbtnColourCreator_Click);
            // 
            // kbtnColourMixer
            // 
            this.kbtnColourMixer.Location = new System.Drawing.Point(257, 401);
            this.kbtnColourMixer.Name = "kbtnColourMixer";
            this.kbtnColourMixer.Size = new System.Drawing.Size(218, 25);
            this.kbtnColourMixer.TabIndex = 9;
            this.kbtnColourMixer.Values.Text = "Colour Mixer";
            this.kbtnColourMixer.Click += new System.EventHandler(this.kbtnColourMixer_Click);
            // 
            // kbtnHexToRGB
            // 
            this.kbtnHexToRGB.Location = new System.Drawing.Point(257, 323);
            this.kbtnHexToRGB.Name = "kbtnHexToRGB";
            this.kbtnHexToRGB.Size = new System.Drawing.Size(218, 25);
            this.kbtnHexToRGB.TabIndex = 8;
            this.kbtnHexToRGB.Values.Text = "Convert Colour (Hex to RGB)";
            this.kbtnHexToRGB.Click += new System.EventHandler(this.kbtnHexToRGB_Click);
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
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(257, 284);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton1.TabIndex = 5;
            this.kryptonButton1.Values.Text = "Convert Colour";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
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
            // kryptonCheckSet1
            // 
            this.kryptonCheckSet1.CheckButtons.Add(this.kcbtnHorizontal);
            this.kryptonCheckSet1.CheckButtons.Add(this.kcbtnVertical);
            this.kryptonCheckSet1.CheckButtons.Add(this.kcbtnForwardDiagonal);
            this.kryptonCheckSet1.CheckButtons.Add(this.kcbtnBackwardDiagonal);
            this.kryptonCheckSet1.CheckedButton = this.kcbtnForwardDiagonal;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsAlignLeft;
        private System.Windows.Forms.ToolStripButton tsAlignCentre;
        private System.Windows.Forms.ToolStripButton tsAlignRight;
        private System.Windows.Forms.ToolStripButton tsJustify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsInsertText;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonRichTextBoxExtended rxrbTextPad;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnHexToRGB;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnColourMixer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnColourCreator;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton kcbtnTextColour;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton kcbtnGradientColour2;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton kcbtnGradientColour1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbGradientDirection;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kcbtnBackwardDiagonal;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kcbtnForwardDiagonal;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kcbtnVertical;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kcbtnHorizontal;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet kryptonCheckSet1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnMessageboxTest;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnPaletteEditor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton7;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton8;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton9;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox kryptonPromptTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton10;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton11;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkVersion2 kryptonCommandLinkVersion21;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkButton kryptonCommandLinkButton2;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonSearchBox kryptonSearchBox1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.ModernProgressBar modernProgressBar1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonSlideButton kryptonSlideButton1;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox circularPictureBox1;
        private Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton12;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton13;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton14;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.RoundedTextbox roundedTextbox1;
        private ExtendedControls.ExtendedToolkit.ToolstripControls.FlashingLabel flashingLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton15;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton16;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton17;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton18;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid kryptonPropertyGrid1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton19;
    }
}

