namespace KryptonOutlookGrid.Formatting
{
    partial class CustomFormatRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomFormatRule));
            this.kpnlBackdrop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcolMin = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.kcolMed = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.kcolMax = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.kcmbFill = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pbxPreview = new System.Windows.Forms.PictureBox();
            this.kcmbFormat = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.klblFill = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblPreview = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblFormat = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).BeginInit();
            this.kpnlBackdrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbFormat)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlBackdrop
            // 
            this.kpnlBackdrop.Controls.Add(this.kbtnCancel);
            this.kpnlBackdrop.Controls.Add(this.kryptonButton1);
            this.kpnlBackdrop.Controls.Add(this.kcolMin);
            this.kpnlBackdrop.Controls.Add(this.kcolMed);
            this.kpnlBackdrop.Controls.Add(this.kcolMax);
            this.kpnlBackdrop.Controls.Add(this.kcmbFill);
            this.kpnlBackdrop.Controls.Add(this.pbxPreview);
            this.kpnlBackdrop.Controls.Add(this.kcmbFormat);
            this.kpnlBackdrop.Controls.Add(this.klblFill);
            this.kpnlBackdrop.Controls.Add(this.klblPreview);
            this.kpnlBackdrop.Controls.Add(this.klblFormat);
            resources.ApplyResources(this.kpnlBackdrop, "kpnlBackdrop");
            this.kpnlBackdrop.Name = "kpnlBackdrop";
            // 
            // kbtnCancel
            // 
            resources.ApplyResources(this.kbtnCancel, "kbtnCancel");
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.Values.Image = global::KryptonOutlookGrid.Properties.Resources._18795___critical_messagebox;
            this.kbtnCancel.Values.Text = resources.GetString("kbtnCancel.Values.Text");
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kryptonButton1
            // 
            resources.ApplyResources(this.kryptonButton1, "kryptonButton1");
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.Values.Image = global::KryptonOutlookGrid.Properties.Resources._18850___ok;
            this.kryptonButton1.Values.Text = resources.GetString("kryptonButton1.Values.Text");
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kcolMin
            // 
            resources.ApplyResources(this.kcolMin, "kcolMin");
            this.kcolMin.Name = "kcolMin";
            this.kcolMin.SelectedColor = System.Drawing.Color.White;
            this.kcolMin.Splitter = false;
            this.kcolMin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcolMin.Values.Text = resources.GetString("kcolMin.Values.Text");
            this.kcolMin.VisibleNoColor = false;
            this.kcolMin.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.kcolMin_SelectedColorChanged);
            // 
            // kcolMed
            // 
            resources.ApplyResources(this.kcolMed, "kcolMed");
            this.kcolMed.Name = "kcolMed";
            this.kcolMed.SelectedColor = System.Drawing.Color.White;
            this.kcolMed.Splitter = false;
            this.kcolMed.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcolMed.Values.Text = resources.GetString("kcolMed.Values.Text");
            this.kcolMed.VisibleNoColor = false;
            this.kcolMed.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.kcolMed_SelectedColorChanged);
            // 
            // kcolMax
            // 
            resources.ApplyResources(this.kcolMax, "kcolMax");
            this.kcolMax.Name = "kcolMax";
            this.kcolMax.SelectedColor = System.Drawing.Color.White;
            this.kcolMax.Splitter = false;
            this.kcolMax.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcolMax.Values.Text = resources.GetString("kcolMax.Values.Text");
            this.kcolMax.VisibleNoColor = false;
            this.kcolMax.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.kcolMax_SelectedColorChanged);
            // 
            // kcmbFill
            // 
            this.kcmbFill.DropDownWidth = 692;
            resources.ApplyResources(this.kcmbFill, "kcmbFill");
            this.kcmbFill.Name = "kcmbFill";
            this.kcmbFill.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbFill.SelectedIndexChanged += new System.EventHandler(this.kcmbFill_SelectedIndexChanged);
            // 
            // pbxPreview
            // 
            this.pbxPreview.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pbxPreview, "pbxPreview");
            this.pbxPreview.Name = "pbxPreview";
            this.pbxPreview.TabStop = false;
            this.pbxPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxPreview_Paint);
            // 
            // kcmbFormat
            // 
            this.kcmbFormat.DropDownWidth = 692;
            resources.ApplyResources(this.kcmbFormat, "kcmbFormat");
            this.kcmbFormat.Name = "kcmbFormat";
            this.kcmbFormat.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbFormat.SelectedIndexChanged += new System.EventHandler(this.kcmbFormat_SelectedIndexChanged);
            // 
            // klblFill
            // 
            resources.ApplyResources(this.klblFill, "klblFill");
            this.klblFill.Name = "klblFill";
            this.klblFill.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFill.Values.Text = resources.GetString("klblFill.Values.Text");
            // 
            // klblPreview
            // 
            resources.ApplyResources(this.klblPreview, "klblPreview");
            this.klblPreview.Name = "klblPreview";
            this.klblPreview.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblPreview.Values.Text = resources.GetString("klblPreview.Values.Text");
            // 
            // klblFormat
            // 
            resources.ApplyResources(this.klblFormat, "klblFormat");
            this.klblFormat.Name = "klblFormat";
            this.klblFormat.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFormat.Values.Text = resources.GetString("klblFormat.Values.Text");
            // 
            // CustomFormatRule
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kpnlBackdrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomFormatRule";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.CustomFormatRule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).EndInit();
            this.kpnlBackdrop.ResumeLayout(false);
            this.kpnlBackdrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbFormat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackdrop;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton kcolMin;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton kcolMed;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton kcolMax;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbFill;
        private System.Windows.Forms.PictureBox pbxPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbFormat;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblFill;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblFormat;
    }
}