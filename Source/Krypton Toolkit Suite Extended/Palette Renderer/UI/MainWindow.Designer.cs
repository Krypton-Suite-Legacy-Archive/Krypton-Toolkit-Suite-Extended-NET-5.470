namespace PaletteRenderer.UI
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
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnToolkitAssembly = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblToolkitAssembly = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtToolkitAssembly = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNameSpace = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblNameSpace = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lstViewPalettes = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblChoose = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAssemblyPath = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCompose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblAssembly = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtOutputAssembly = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.outputAssemblyDialog = new System.Windows.Forms.SaveFileDialog();
            this.openPaletteDialog = new System.Windows.Forms.OpenFileDialog();
            this.openAssemblyDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.btnToolkitAssembly);
            this.kryptonPanel.Controls.Add(this.lblToolkitAssembly);
            this.kryptonPanel.Controls.Add(this.txtToolkitAssembly);
            this.kryptonPanel.Controls.Add(this.txtNameSpace);
            this.kryptonPanel.Controls.Add(this.lblNameSpace);
            this.kryptonPanel.Controls.Add(this.btnAdd);
            this.kryptonPanel.Controls.Add(this.btnRemove);
            this.kryptonPanel.Controls.Add(this.lstViewPalettes);
            this.kryptonPanel.Controls.Add(this.prgBar);
            this.kryptonPanel.Controls.Add(this.lblStatus);
            this.kryptonPanel.Controls.Add(this.lblChoose);
            this.kryptonPanel.Controls.Add(this.btnAssemblyPath);
            this.kryptonPanel.Controls.Add(this.btnCompose);
            this.kryptonPanel.Controls.Add(this.lblAssembly);
            this.kryptonPanel.Controls.Add(this.txtOutputAssembly);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(538, 437);
            this.kryptonPanel.TabIndex = 0;
            // 
            // btnToolkitAssembly
            // 
            this.btnToolkitAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToolkitAssembly.Location = new System.Drawing.Point(496, 351);
            this.btnToolkitAssembly.Name = "btnToolkitAssembly";
            this.btnToolkitAssembly.Size = new System.Drawing.Size(30, 25);
            this.btnToolkitAssembly.TabIndex = 14;
            this.btnToolkitAssembly.Values.Text = "...";
            this.btnToolkitAssembly.Click += new System.EventHandler(this.btnToolkitAssembly_Click);
            // 
            // lblToolkitAssembly
            // 
            this.lblToolkitAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblToolkitAssembly.Location = new System.Drawing.Point(12, 328);
            this.lblToolkitAssembly.Name = "lblToolkitAssembly";
            this.lblToolkitAssembly.Size = new System.Drawing.Size(104, 20);
            this.lblToolkitAssembly.TabIndex = 12;
            this.lblToolkitAssembly.Values.Text = "Toolkit assembly:";
            // 
            // txtToolkitAssembly
            // 
            this.txtToolkitAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolkitAssembly.Location = new System.Drawing.Point(12, 354);
            this.txtToolkitAssembly.Name = "txtToolkitAssembly";
            this.txtToolkitAssembly.Size = new System.Drawing.Size(478, 23);
            this.txtToolkitAssembly.TabIndex = 13;
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSpace.Location = new System.Drawing.Point(12, 302);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(514, 23);
            this.txtNameSpace.TabIndex = 8;
            // 
            // lblNameSpace
            // 
            this.lblNameSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNameSpace.Location = new System.Drawing.Point(12, 276);
            this.lblNameSpace.Name = "lblNameSpace";
            this.lblNameSpace.Size = new System.Drawing.Size(77, 20);
            this.lblNameSpace.TabIndex = 7;
            this.lblNameSpace.Values.Text = "Namespace:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Values.Text = "Add...";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(108, 177);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 25);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Values.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstViewPalettes
            // 
            this.lstViewPalettes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstViewPalettes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colFile,
            this.colVersion});
            this.lstViewPalettes.LabelEdit = true;
            this.lstViewPalettes.Location = new System.Drawing.Point(12, 38);
            this.lstViewPalettes.MultiSelect = false;
            this.lstViewPalettes.Name = "lstViewPalettes";
            this.lstViewPalettes.Size = new System.Drawing.Size(514, 133);
            this.lstViewPalettes.TabIndex = 1;
            this.lstViewPalettes.UseCompatibleStateImageBehavior = false;
            this.lstViewPalettes.View = System.Windows.Forms.View.Details;
            this.lstViewPalettes.SelectedIndexChanged += new System.EventHandler(this.lstViewPalettes_SelectedIndexChanged);
            this.lstViewPalettes.Click += new System.EventHandler(this.lstViewPalettes_Click);
            // 
            // colName
            // 
            this.colName.Text = "Palette Name";
            this.colName.Width = 120;
            // 
            // colFile
            // 
            this.colFile.Text = "File";
            this.colFile.Width = 350;
            // 
            // colVersion
            // 
            this.colVersion.Text = "Version";
            this.colVersion.Width = 30;
            // 
            // prgBar
            // 
            this.prgBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgBar.Location = new System.Drawing.Point(118, 393);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(408, 23);
            this.prgBar.TabIndex = 11;
            this.prgBar.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.Location = new System.Drawing.Point(118, 374);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Values.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // lblChoose
            // 
            this.lblChoose.Location = new System.Drawing.Point(12, 12);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(164, 20);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Values.Text = "Please choose your palettes:";
            // 
            // btnAssemblyPath
            // 
            this.btnAssemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssemblyPath.Location = new System.Drawing.Point(496, 242);
            this.btnAssemblyPath.Name = "btnAssemblyPath";
            this.btnAssemblyPath.Size = new System.Drawing.Size(30, 25);
            this.btnAssemblyPath.TabIndex = 6;
            this.btnAssemblyPath.Values.Text = "...";
            this.btnAssemblyPath.Click += new System.EventHandler(this.btnAssemblyPath_Click);
            // 
            // btnCompose
            // 
            this.btnCompose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompose.Location = new System.Drawing.Point(12, 393);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(90, 25);
            this.btnCompose.TabIndex = 9;
            this.btnCompose.Values.Text = "Compose!";
            this.btnCompose.Click += new System.EventHandler(this.btnCompose_Click);
            // 
            // lblAssembly
            // 
            this.lblAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAssembly.Location = new System.Drawing.Point(12, 219);
            this.lblAssembly.Name = "lblAssembly";
            this.lblAssembly.Size = new System.Drawing.Size(106, 20);
            this.lblAssembly.TabIndex = 4;
            this.lblAssembly.Values.Text = "Output assembly:";
            // 
            // txtOutputAssembly
            // 
            this.txtOutputAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputAssembly.Location = new System.Drawing.Point(12, 245);
            this.txtOutputAssembly.Name = "txtOutputAssembly";
            this.txtOutputAssembly.Size = new System.Drawing.Size(478, 23);
            this.txtOutputAssembly.TabIndex = 5;
            // 
            // outputAssemblyDialog
            // 
            this.outputAssemblyDialog.DefaultExt = "dll";
            this.outputAssemblyDialog.FileName = "styles.dll";
            this.outputAssemblyDialog.Filter = "Assemblies (*.dll)|*.dll";
            this.outputAssemblyDialog.Title = "Output Assembly";
            // 
            // openPaletteDialog
            // 
            this.openPaletteDialog.DefaultExt = "xml";
            this.openPaletteDialog.FileName = "*.xml";
            this.openPaletteDialog.Filter = "Palettes (*.xml)|*.xml|Any files (*.*)|*.*";
            this.openPaletteDialog.Multiselect = true;
            this.openPaletteDialog.Title = "Add palette";
            // 
            // openAssemblyDialog
            // 
            this.openAssemblyDialog.DefaultExt = "dll";
            this.openAssemblyDialog.Filter = "Assemblies (*.dll)|*.dll";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 437);
            this.Controls.Add(this.kryptonPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton Palettes Composer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.ListView lstViewPalettes;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ProgressBar prgBar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblChoose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAssemblyPath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCompose;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAssembly;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOutputAssembly;
        private System.Windows.Forms.SaveFileDialog outputAssemblyDialog;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemove;
        private System.Windows.Forms.OpenFileDialog openPaletteDialog;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNameSpace;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNameSpace;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnToolkitAssembly;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblToolkitAssembly;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtToolkitAssembly;
        private System.Windows.Forms.OpenFileDialog openAssemblyDialog;
        private System.Windows.Forms.ColumnHeader colVersion;
    }
}