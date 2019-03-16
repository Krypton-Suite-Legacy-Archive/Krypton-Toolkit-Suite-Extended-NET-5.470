using Base.Code.Security;
using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Development;
using ExtendedControls.Base.Code.Settings;
using ExtendedControls.Base.Enumerations;
using ExtendedControls.ExtendedToolkit.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.Security
{
    public class RandomPasswordGenerator : KryptonForm
    {
        #region Designer Code
        private KryptonTextBox ktxtOutput;
        private KryptonLabel kryptonLabel2;
        private KryptonNumericUpDown knudPasswordLength;
        private KryptonLabel kryptonLabel1;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnGeneratePassword;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem copyPasswordToolStripMenuItem;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues2 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues4 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues5 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues6 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnGeneratePassword = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktxtOutput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knudPasswordLength = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnGeneratePassword);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Controls.Add(this.ktxtOutput);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.knudPasswordLength);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(763, 187);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnGeneratePassword
            // 
            this.kbtnGeneratePassword.Location = new System.Drawing.Point(472, 148);
            this.kbtnGeneratePassword.Name = "kbtnGeneratePassword";
            this.kbtnGeneratePassword.Size = new System.Drawing.Size(156, 29);
            this.kbtnGeneratePassword.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGeneratePassword.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGeneratePassword.TabIndex = 11;
            popupPositionValues1.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues1.PlacementTarget = null;
            this.kbtnGeneratePassword.ToolTipValues.ToolTipPosition = popupPositionValues1;
            this.kbtnGeneratePassword.Values.Text = "&Generate";
            this.kbtnGeneratePassword.Click += new System.EventHandler(this.kbtnGeneratePasword_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(634, 148);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 10;
            popupPositionValues2.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues2.PlacementTarget = null;
            this.kbtnCancel.ToolTipValues.ToolTipPosition = popupPositionValues2;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // ktxtOutput
            // 
            this.ktxtOutput.ContextMenuStrip = this.ctxMenu;
            this.ktxtOutput.Location = new System.Drawing.Point(12, 113);
            this.ktxtOutput.Name = "ktxtOutput";
            this.ktxtOutput.ReadOnly = true;
            this.ktxtOutput.Size = new System.Drawing.Size(739, 29);
            this.ktxtOutput.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtOutput.TabIndex = 4;
            this.ktxtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            popupPositionValues3.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues3.PlacementTarget = null;
            this.ktxtOutput.ToolTipValues.ToolTipPosition = popupPositionValues3;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPasswordToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(156, 26);
            // 
            // copyPasswordToolStripMenuItem
            // 
            this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
            this.copyPasswordToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.copyPasswordToolStripMenuItem.Text = "&Copy Password";
            this.copyPasswordToolStripMenuItem.Click += new System.EventHandler(this.copyPasswordToolStripMenuItem_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 70);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(150, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 3;
            popupPositionValues4.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues4.PlacementTarget = null;
            this.kryptonLabel2.ToolTipValues.ToolTipPosition = popupPositionValues4;
            this.kryptonLabel2.Values.Text = "Password Output:";
            // 
            // knudPasswordLength
            // 
            this.knudPasswordLength.Location = new System.Drawing.Point(166, 12);
            this.knudPasswordLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.knudPasswordLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.knudPasswordLength.Name = "knudPasswordLength";
            this.knudPasswordLength.Size = new System.Drawing.Size(120, 28);
            this.knudPasswordLength.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knudPasswordLength.TabIndex = 2;
            this.knudPasswordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            popupPositionValues5.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues5.PlacementTarget = null;
            this.knudPasswordLength.ToolTipValues.ToolTipPosition = popupPositionValues5;
            this.knudPasswordLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(148, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            popupPositionValues6.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues6.PlacementTarget = null;
            this.kryptonLabel1.ToolTipValues.ToolTipPosition = popupPositionValues6;
            this.kryptonLabel1.Values.Text = "Password Length:";
            // 
            // RandomPasswordGenerator
            // 
            this.ClientSize = new System.Drawing.Size(763, 187);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandomPasswordGenerator";
            this.Text = "Generate a Random Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RandomPasswordGenerator_FormClosing);
            this.Load += new System.EventHandler(this.RandomPasswordGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        public RandomPasswordGenerator()
        {
            InitializeComponent();
        }

        public RandomPasswordGenerator(int maximumPasswordLength = 20)
        {
            InitializeComponent();

            knudPasswordLength.Maximum = maximumPasswordLength;
        }

        public RandomPasswordGenerator(int minimumPasswordLength = 5, int maximumPasswordLength = 20, int defaultValue = 10)
        {
            InitializeComponent();

            knudPasswordLength.Minimum = minimumPasswordLength;

            knudPasswordLength.Maximum = maximumPasswordLength;

            knudPasswordLength.Value = defaultValue;
        }

        private void kbtnGeneratePasword_Click(object sender, EventArgs e)
        {
            if (ktxtOutput.Text == string.Empty)
            {
                ktxtOutput.Text = SecurityMethods.CreatePassword(Convert.ToInt32(knudPasswordLength.Value));
            }
            else
            {
                ktxtOutput.Text = "";

                ktxtOutput.Text = SecurityMethods.CreatePassword(Convert.ToInt32(knudPasswordLength.Value));
            }
        }

        private void copyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Clipboard.SetText(ktxtOutput.Text);
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RandomPasswordGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ktxtOutput.Text != null)
            {
                DialogResult result = KryptonMessageBoxExtended.Show($"There is a password of: '{ ktxtOutput.Text }' still in the field. Do you want to exit?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Information, messageboxTypeface: new Font("Segoe UI", 12));

                if (result == DialogResult.Yes)
                {
                    Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void RandomPasswordGenerator_Load(object sender, EventArgs e)
        {
            if (SettingsManager.GetDebugMode())
            {
                DevelopmentInformation.SetBuildInformation(this, DevelopmentState.PREALPHA);
            }
        }
    }
}
