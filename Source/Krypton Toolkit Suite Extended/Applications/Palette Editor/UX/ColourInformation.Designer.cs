namespace PaletteEditor.UX
{
    partial class ColourInformation
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
            KryptonOutlookGrid.Classes.OutlookGridGroupCollection outlookGridGroupCollection1 = new KryptonOutlookGrid.Classes.OutlookGridGroupCollection();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnGetColourInformation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klbColourInformation = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.ctxColourOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.useAsBaseColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvColourInformation = new System.Windows.Forms.ListView();
            this.clmnColourDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnColourValues = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kogColourInformation = new KryptonOutlookGrid.Classes.KryptonOutlookGrid();
            this.krbUseKryptonListBox = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbUseSystemListBox = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbUseDatagridView = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.tmrUpgradeUI = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.ss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.ctxColourOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kogColourInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.krbUseDatagridView);
            this.kryptonPanel1.Controls.Add(this.krbUseSystemListBox);
            this.kryptonPanel1.Controls.Add(this.krbUseKryptonListBox);
            this.kryptonPanel1.Controls.Add(this.kbtnGetColourInformation);
            this.kryptonPanel1.Controls.Add(this.ss);
            this.kryptonPanel1.Controls.Add(this.kbtnClose);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 736);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(939, 75);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnGetColourInformation
            // 
            this.kbtnGetColourInformation.AutoSize = true;
            this.kbtnGetColourInformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGetColourInformation.Location = new System.Drawing.Point(690, 6);
            this.kbtnGetColourInformation.Name = "kbtnGetColourInformation";
            this.kbtnGetColourInformation.Size = new System.Drawing.Size(180, 30);
            this.kbtnGetColourInformation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetColourInformation.TabIndex = 48;
            this.kbtnGetColourInformation.Values.Text = "Get Colour &Information";
            this.kbtnGetColourInformation.Click += new System.EventHandler(this.kbtnGetColourInformation_Click);
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.ss.Location = new System.Drawing.Point(0, 53);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(939, 22);
            this.ss.TabIndex = 47;
            this.ss.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(924, 17);
            this.tslStatus.Spring = true;
            this.tslStatus.Text = "Ready";
            this.tslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kbtnClose
            // 
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnClose.Location = new System.Drawing.Point(876, 6);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(51, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 46;
            this.kbtnClose.Values.Text = "&Close";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 734);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 2);
            this.panel1.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.klbColourInformation);
            this.kryptonPanel2.Controls.Add(this.lvColourInformation);
            this.kryptonPanel2.Controls.Add(this.kogColourInformation);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(939, 734);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // klbColourInformation
            // 
            this.klbColourInformation.ContextMenuStrip = this.ctxColourOptions;
            this.klbColourInformation.Location = new System.Drawing.Point(12, 12);
            this.klbColourInformation.Name = "klbColourInformation";
            this.klbColourInformation.Size = new System.Drawing.Size(915, 703);
            this.klbColourInformation.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbColourInformation.TabIndex = 0;
            // 
            // ctxColourOptions
            // 
            this.ctxColourOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxColourOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useAsBaseColourToolStripMenuItem});
            this.ctxColourOptions.Name = "ctxColourOptions";
            this.ctxColourOptions.Size = new System.Drawing.Size(174, 26);
            // 
            // useAsBaseColourToolStripMenuItem
            // 
            this.useAsBaseColourToolStripMenuItem.Name = "useAsBaseColourToolStripMenuItem";
            this.useAsBaseColourToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.useAsBaseColourToolStripMenuItem.Text = "&Use as Base Colour";
            this.useAsBaseColourToolStripMenuItem.Click += new System.EventHandler(this.useAsBaseColourToolStripMenuItem_Click);
            // 
            // lvColourInformation
            // 
            this.lvColourInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnColourDescription,
            this.clmnColourValues});
            this.lvColourInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvColourInformation.Location = new System.Drawing.Point(12, 12);
            this.lvColourInformation.Name = "lvColourInformation";
            this.lvColourInformation.Size = new System.Drawing.Size(915, 703);
            this.lvColourInformation.TabIndex = 6;
            this.lvColourInformation.UseCompatibleStateImageBehavior = false;
            this.lvColourInformation.View = System.Windows.Forms.View.Details;
            // 
            // clmnColourDescription
            // 
            this.clmnColourDescription.Text = "Colour Description";
            this.clmnColourDescription.Width = 226;
            // 
            // clmnColourValues
            // 
            this.clmnColourValues.Text = "Colour Values";
            this.clmnColourValues.Width = 259;
            // 
            // kogColourInformation
            // 
            this.kogColourInformation.FillMode = KryptonOutlookGrid.Classes.FillMode.GROUPSONLY;
            this.kogColourInformation.GroupCollection = outlookGridGroupCollection1;
            this.kogColourInformation.Location = new System.Drawing.Point(12, 12);
            this.kogColourInformation.Name = "kogColourInformation";
            this.kogColourInformation.PreviousSelectedGroupRow = -1;
            this.kogColourInformation.ShowLines = false;
            this.kogColourInformation.Size = new System.Drawing.Size(915, 701);
            this.kogColourInformation.TabIndex = 5;
            // 
            // krbUseKryptonListBox
            // 
            this.krbUseKryptonListBox.Checked = true;
            this.krbUseKryptonListBox.Location = new System.Drawing.Point(12, 10);
            this.krbUseKryptonListBox.Name = "krbUseKryptonListBox";
            this.krbUseKryptonListBox.Size = new System.Drawing.Size(168, 26);
            this.krbUseKryptonListBox.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbUseKryptonListBox.TabIndex = 49;
            this.krbUseKryptonListBox.Values.Text = "Use &Krypton ListBox";
            // 
            // krbUseSystemListBox
            // 
            this.krbUseSystemListBox.Location = new System.Drawing.Point(186, 10);
            this.krbUseSystemListBox.Name = "krbUseSystemListBox";
            this.krbUseSystemListBox.Size = new System.Drawing.Size(163, 26);
            this.krbUseSystemListBox.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbUseSystemListBox.TabIndex = 50;
            this.krbUseSystemListBox.Values.Text = "Use &System ListBox";
            // 
            // krbUseDatagridView
            // 
            this.krbUseDatagridView.Location = new System.Drawing.Point(355, 10);
            this.krbUseDatagridView.Name = "krbUseDatagridView";
            this.krbUseDatagridView.Size = new System.Drawing.Size(158, 26);
            this.krbUseDatagridView.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbUseDatagridView.TabIndex = 51;
            this.krbUseDatagridView.Values.Text = "Use &Datagrid View";
            // 
            // tmrUpgradeUI
            // 
            this.tmrUpgradeUI.Enabled = true;
            this.tmrUpgradeUI.Interval = 250;
            this.tmrUpgradeUI.Tick += new System.EventHandler(this.tmrUpgradeUI_Tick);
            // 
            // ColourInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 811);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColourInformation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colour Information";
            this.Load += new System.EventHandler(this.ColourInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ctxColourOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kogColourInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGetColourInformation;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox klbColourInformation;
        private KryptonOutlookGrid.Classes.KryptonOutlookGrid kogColourInformation;
        private System.Windows.Forms.ListView lvColourInformation;
        private System.Windows.Forms.ColumnHeader clmnColourDescription;
        private System.Windows.Forms.ColumnHeader clmnColourValues;
        private System.Windows.Forms.ContextMenuStrip ctxColourOptions;
        private System.Windows.Forms.ToolStripMenuItem useAsBaseColourToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton krbUseDatagridView;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton krbUseSystemListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton krbUseKryptonListBox;
        private System.Windows.Forms.Timer tmrUpgradeUI;
    }
}