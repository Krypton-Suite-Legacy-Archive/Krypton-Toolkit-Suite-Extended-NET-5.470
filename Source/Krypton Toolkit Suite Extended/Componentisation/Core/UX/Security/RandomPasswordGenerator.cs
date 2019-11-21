using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitSuiteExtendedCore.Classes.Security;
using System;
using System.Drawing;
using System.Windows.Forms;
using ToolkitSettings.Classes.Global;

namespace KryptonToolkitSuiteExtendedCore.UX.Security
{
    public class RandomPasswordGenerator : KryptonForm
    {
        #region Designer Code
        private KryptonButton kbtnCopy;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnGeneratePassword;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonTextBox ktxtOutput;
        private KryptonLabel kryptonLabel2;
        private KryptonNumericUpDown knudPasswordLength;
        private KryptonLabel kryptonLabel1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnGeneratePassword = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCopy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ktxtOutput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knudPasswordLength = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnCopy);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Controls.Add(this.kbtnGeneratePassword);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 166);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(767, 50);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnGeneratePassword
            // 
            this.kbtnGeneratePassword.Location = new System.Drawing.Point(476, 9);
            this.kbtnGeneratePassword.Name = "kbtnGeneratePassword";
            this.kbtnGeneratePassword.Size = new System.Drawing.Size(156, 29);
            this.kbtnGeneratePassword.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGeneratePassword.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnGeneratePassword.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnGeneratePassword.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGeneratePassword.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnGeneratePassword.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnGeneratePassword.TabIndex = 13;
            this.kbtnGeneratePassword.Values.Text = "&Generate";
            this.kbtnGeneratePassword.Click += new System.EventHandler(this.kbtnGeneratePassword_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(638, 9);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnCancel.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnCancel.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnCancel.TabIndex = 12;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kbtnCopy
            // 
            this.kbtnCopy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCopy.Enabled = false;
            this.kbtnCopy.Location = new System.Drawing.Point(12, 9);
            this.kbtnCopy.Name = "kbtnCopy";
            this.kbtnCopy.Size = new System.Drawing.Size(117, 29);
            this.kbtnCopy.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCopy.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnCopy.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnCopy.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCopy.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnCopy.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnCopy.TabIndex = 14;
            this.kbtnCopy.Values.Text = "C&opy";
            this.kbtnCopy.Click += new System.EventHandler(this.kbtnCopy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.ktxtOutput);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.knudPasswordLength);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(767, 163);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // ktxtOutput
            // 
            this.ktxtOutput.Location = new System.Drawing.Point(12, 113);
            this.ktxtOutput.Name = "ktxtOutput";
            this.ktxtOutput.ReadOnly = true;
            this.ktxtOutput.Size = new System.Drawing.Size(739, 29);
            this.ktxtOutput.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtOutput.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtOutput.TabIndex = 8;
            this.ktxtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktxtOutput.TextChanged += new System.EventHandler(this.ktxtOutput_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 70);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(150, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel2.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel2.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel2.TabIndex = 7;
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
            this.knudPasswordLength.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knudPasswordLength.TabIndex = 6;
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
            this.kryptonLabel1.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel1.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel1.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Password Length:";
            // 
            // RandomPasswordGenerator
            // 
            this.ClientSize = new System.Drawing.Size(767, 216);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandomPasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Generate a Random Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RandomPasswordGenerator_FormClosing);
            this.Load += new System.EventHandler(this.RandomPasswordGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructors
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
        #endregion

        private void ktxtOutput_TextChanged(object sender, EventArgs e)
        {
            if (ktxtOutput.Text.Length > 0)
            {
                kbtnCopy.Enabled = true;
            }
            else
            {
                kbtnCopy.Enabled = false;
            }
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kbtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ktxtOutput.Text);
        }

        private void kbtnGeneratePassword_Click(object sender, EventArgs e)
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

        private void RandomPasswordGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ktxtOutput.Text != null)
            {
                DialogResult result = KryptonMessageBoxExtended.Show($"There is a password of: '{ ktxtOutput.Text }' still in the field. Do you want to exit?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Information, messageboxTypeface: new Font("Segoe UI", 12));

                if (result == DialogResult.Yes)
                {
                    Hide();
                }
            }
            else
            {
                Hide();
            }
        }

        private void RandomPasswordGenerator_Load(object sender, EventArgs e)
        {
            GlobalBooleanSettingsManager gbs = new GlobalBooleanSettingsManager();

            if (gbs.GetIsInDeveloperMode())
            {
                //DevelopmentInformation.SetBuildInformation(this, (DevelopmentState)DevelopmentState.ALPHA);
            }
        }
    }
}