using ComponentFactory.Krypton.Toolkit;
using GlobalUtilities.Classes.SpecialEffects;
using PaletteEditor.UX.New;
using System;
using System.Reflection;
using System.Windows.Forms;
using Tooling.Settings.Classes;

namespace PaletteEditor.UX
{
    public class PaletteEditorSplash : KryptonForm
    {
        #region Variables
        private Timer _tmrUpdate;

        private FadeEffects _fadeEffects = new FadeEffects();

        private Version _currentVersion = Assembly.GetExecutingAssembly().GetName().Version;

        private GlobalBooleanSettingsManager _globalBooleanSettingsManager = new GlobalBooleanSettingsManager();
        #endregion

        #region Components
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pbProgress;
        private KryptonLabel klblBetaInformation;
        private KryptonLabel klblCloseDisabled;
        private KryptonLabel klblCloseEnabled;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaletteEditorSplash));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblCloseDisabled = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblCloseEnabled = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblBetaInformation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.klblCloseDisabled);
            this.kryptonPanel1.Controls.Add(this.klblCloseEnabled);
            this.kryptonPanel1.Controls.Add(this.klblBetaInformation);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1012, 577);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // klblCloseDisabled
            // 
            this.klblCloseDisabled.Location = new System.Drawing.Point(977, 12);
            this.klblCloseDisabled.Name = "klblCloseDisabled";
            this.klblCloseDisabled.Size = new System.Drawing.Size(23, 26);
            this.klblCloseDisabled.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.klblCloseDisabled.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.klblCloseDisabled.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCloseDisabled.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblCloseDisabled.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblCloseDisabled.TabIndex = 2;
            this.klblCloseDisabled.Values.Text = "X";
            this.klblCloseDisabled.MouseEnter += new System.EventHandler(this.klblCloseDisabled_MouseEnter);
            // 
            // klblCloseEnabled
            // 
            this.klblCloseEnabled.Location = new System.Drawing.Point(977, 12);
            this.klblCloseEnabled.Name = "klblCloseEnabled";
            this.klblCloseEnabled.Size = new System.Drawing.Size(23, 26);
            this.klblCloseEnabled.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.klblCloseEnabled.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.klblCloseEnabled.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCloseEnabled.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblCloseEnabled.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblCloseEnabled.TabIndex = 3;
            this.klblCloseEnabled.Values.Text = "X";
            this.klblCloseEnabled.Click += new System.EventHandler(this.klblCloseEnabled_Click);
            this.klblCloseEnabled.MouseLeave += new System.EventHandler(this.klblCloseEnabled_MouseLeave);
            // 
            // klblBetaInformation
            // 
            this.klblBetaInformation.AutoSize = false;
            this.klblBetaInformation.Location = new System.Drawing.Point(251, 522);
            this.klblBetaInformation.Name = "klblBetaInformation";
            this.klblBetaInformation.Size = new System.Drawing.Size(512, 25);
            this.klblBetaInformation.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBetaInformation.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblBetaInformation.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblBetaInformation.TabIndex = 1;
            this.klblBetaInformation.Values.Text = "Palette Explorer - Beta (Build: {0})";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PaletteEditor.Properties.Resources.PE_Icon_512_x_512;
            this.pictureBox1.Location = new System.Drawing.Point(251, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbProgress
            // 
            this.pbProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbProgress.Location = new System.Drawing.Point(0, 554);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(1012, 23);
            this.pbProgress.TabIndex = 1;
            // 
            // PaletteEditorSplash
            // 
            this.ClientSize = new System.Drawing.Size(1012, 577);
            this.ControlBox = false;
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaletteEditorSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaletteEditorSplash_FormClosing);
            this.Load += new System.EventHandler(this.PaletteEditorSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        public PaletteEditorSplash()
        {
            InitializeComponent();

            _tmrUpdate = new Timer();

            _tmrUpdate.Interval = 250;

            _tmrUpdate.Enabled = true;

            _tmrUpdate.Tick += Update_Tick;

            _fadeEffects.FadeInWindow(this);
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            pbProgress.Increment(1);

            if (pbProgress.Value == 100)
            {
                if (_globalBooleanSettingsManager.GetIsInBetaMode())
                {
                    New.MainWindow mainWindow = new New.MainWindow();

                    //_fadeEffects.FadeOutWindow(this, mainWindow);

                    Hide();

                    mainWindow.Show();

                    _tmrUpdate.Stop();
                }
                else
                {
                    MainWindow mainWindow = new MainWindow();

                    //_fadeEffects.FadeOutWindow(this, mainWindow);

                    Hide();

                    mainWindow.Show();

                    _tmrUpdate.Stop();
                }
            }
        }

        private void PaletteEditorSplash_Load(object sender, EventArgs e)
        {
            klblBetaInformation.Text = $"Palette Explorer - Beta (Build: { _currentVersion.Build.ToString() })";
        }

        private void PaletteEditorSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_fadeEffects.FadeOutWindow(this);
        }

        private void klblCloseDisabled_MouseEnter(object sender, EventArgs e)
        {
            klblCloseDisabled.Visible = false;

            klblCloseEnabled.Visible = true;
        }

        private void klblCloseEnabled_Click(object sender, EventArgs e)
        {
            _tmrUpdate.Stop();

            DialogResult result = KryptonMessageBox.Show("This will exit the running application. Do you want to proceed?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                _tmrUpdate.Start();
            }
        }

        private void klblCloseEnabled_MouseLeave(object sender, EventArgs e)
        {
            klblCloseEnabled.Visible = false;

            klblCloseDisabled.Visible = true;
        }
    }
}