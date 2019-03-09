using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaletteExplorer.UX
{
    public class SplashScreen : KryptonForm
    {
        #region Designer Code
        private System.Windows.Forms.PictureBox pictureBox1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonProgressBar kpbProgress;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kpbProgress = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.kpbProgress);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(571, 589);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kpbProgress
            // 
            this.kpbProgress.BackColor = System.Drawing.Color.Transparent;
            this.kpbProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpbProgress.EndColour = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(22)))), ((int)(((byte)(131)))));
            this.kpbProgress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kpbProgress.ForeColour = System.Drawing.Color.Empty;
            this.kpbProgress.Location = new System.Drawing.Point(0, 557);
            this.kpbProgress.Name = "kpbProgress";
            this.kpbProgress.Size = new System.Drawing.Size(571, 32);
            this.kpbProgress.StartColour = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(22)))), ((int)(((byte)(131)))));
            this.kpbProgress.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PaletteExplorer.Properties.Resources.PE_Icon_512_x_512;
            this.pictureBox1.Location = new System.Drawing.Point(31, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            this.ClientSize = new System.Drawing.Size(571, 589);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool _showPercentage;
        private Timer _updateTimer;
        #endregion

        #region Properties
        public bool ShowPercentage { get => _showPercentage; set => _showPercentage = value; }
        #endregion

        #region Constructor
        public SplashScreen(bool showPercentage = true)
        {
            InitializeComponent();

            ShowPercentage = showPercentage;

            _updateTimer = new Timer();

            _updateTimer.Interval = 250;

            _updateTimer.Enabled = true;

            _updateTimer.Tick += UpdateTimer_Tick;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            kpbProgress.Value = kpbProgress.Value + 1;

            if (ShowPercentage)
            {
                kpbProgress.DisplayText = $"{ kpbProgress.Value.ToString() }%";
            }

            if (kpbProgress.Value == 50)
            {
                kpbProgress.ForeColor = Color.White;
            }

            if (kpbProgress.Value == 100)
            {
                MainWindow window = new MainWindow();

                window.Show();

                Hide();

                _updateTimer.Enabled = false;
            }
        }
        #endregion
    }
}