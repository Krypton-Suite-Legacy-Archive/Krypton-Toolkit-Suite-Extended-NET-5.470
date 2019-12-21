#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion


namespace ExtendedDialogs.Dialogs.Toast
{
    /*
    public class KryptonToastNotificationDialog : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private KryptonButton kbtnLaunchProcess;
        private KryptonButton kbtnBrowse;
        private System.Windows.Forms.Panel pnlSplitter;
        private System.Windows.Forms.PictureBox pbxInfoboxIcon;
        private KryptonLabel klblMessage;
        private KryptonLabel klblTitle;
        private KryptonPanel kryptonPanel2;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnLaunchProcess = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pbxInfoboxIcon = new System.Windows.Forms.PictureBox();
            this.klblTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfoboxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnLaunchProcess);
            this.kryptonPanel1.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 278);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(720, 49);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbtnLaunchProcess
            // 
            this.kbtnLaunchProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kbtnLaunchProcess.AutoSize = true;
            this.kbtnLaunchProcess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnLaunchProcess.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnLaunchProcess.Enabled = false;
            this.kbtnLaunchProcess.Location = new System.Drawing.Point(12, 9);
            this.kbtnLaunchProcess.Name = "kbtnLaunchProcess";
            this.kbtnLaunchProcess.Size = new System.Drawing.Size(29, 28);
            this.kbtnLaunchProcess.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLaunchProcess.TabIndex = 8;
            this.kbtnLaunchProcess.Values.Text = "{0}";
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnBrowse.AutoSize = true;
            this.kbtnBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnBrowse.Location = new System.Drawing.Point(515, 9);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(193, 28);
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 7;
            this.kbtnBrowse.Values.Text = "&Dismiss ({0})";
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 275);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(720, 3);
            this.pnlSplitter.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.klblMessage);
            this.kryptonPanel2.Controls.Add(this.klblTitle);
            this.kryptonPanel2.Controls.Add(this.pbxInfoboxIcon);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(720, 275);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // pbxInfoboxIcon
            // 
            this.pbxInfoboxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxInfoboxIcon.Location = new System.Drawing.Point(12, 12);
            this.pbxInfoboxIcon.Name = "pbxInfoboxIcon";
            this.pbxInfoboxIcon.Size = new System.Drawing.Size(64, 64);
            this.pbxInfoboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxInfoboxIcon.TabIndex = 4;
            this.pbxInfoboxIcon.TabStop = false;
            // 
            // klblTitle
            // 
            this.klblTitle.AutoSize = false;
            this.klblTitle.Location = new System.Drawing.Point(83, 12);
            this.klblTitle.Name = "klblTitle";
            this.klblTitle.Size = new System.Drawing.Size(625, 64);
            this.klblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTitle.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblTitle.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblTitle.TabIndex = 5;
            this.klblTitle.Values.Text = "kryptonLabel1";
            // 
            // klblMessage
            // 
            this.klblMessage.AutoSize = false;
            this.klblMessage.Location = new System.Drawing.Point(83, 82);
            this.klblMessage.Name = "klblMessage";
            this.klblMessage.Size = new System.Drawing.Size(625, 187);
            this.klblMessage.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMessage.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.klblMessage.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblMessage.TabIndex = 6;
            this.klblMessage.Values.Text = "kryptonLabel1";
            // 
            // KryptonToastNotificationDialog
            // 
            this.ClientSize = new System.Drawing.Size(720, 327);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonToastNotificationDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.KryptonToastNotificationDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfoboxIcon)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        #region Enumerations
        public enum IconType
        {
            CUSTOM,
            OK,
            ERROR,
            EXCLAMATION,
            INFORMATION,
            QUESTION,
            NOTHING,
            NONE,
            STOP,
            HAND
        }

        public enum ProgressBarOrientation
        {
            VERTICAL,
            HORIZONTAL
        }

        public enum RightToLeftSupport
        {
            LEFTTORIGHT,
            RIGHTTOLEFT
        }

        public enum ActionType
        {
            LAUCHPROCESS,
            OPEN
        }
        #endregion

        #region Variables
        private ActionType _actionType;
        private bool _fade, _showActionButton;
        private string _headerText, _contentText, _processName;
        private Image _image;
        private int _time, _cornerRadius;
        private Timer _timer;
        private SoundPlayer _player;
        private IconType _iconType;
        private RightToLeftSupport _rightToLeftSupport;
        private PaletteDrawBorders _drawBorders;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets the type of the action.
        /// </summary>
        /// <value>
        /// The type of the action.
        /// </value>
        public ActionType Action { get => _actionType; set => _actionType = value; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="KryptonToastNotificationDialog"/> is fade.
        /// </summary>
        /// <value>
        ///   <c>true</c> if fade; otherwise, <c>false</c>.
        /// </value>
        public bool Fade { get => _fade; set => _fade = value; }

        /// <summary>
        /// Gets or sets a value indicating whether [show action button].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show action button]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowActionButton { get => _showActionButton; set => _showActionButton = value; }

        /// <summary>
        /// Gets or sets the sound path.
        /// </summary>
        /// <value>
        /// The sound path.
        /// </value>
        public string SoundPath { get; set; }

        /// <summary>
        /// Gets or sets the sound stream.
        /// </summary>
        /// <value>
        /// The sound stream.
        /// </value>
        public Stream SoundStream { get; set; }

        /// <summary>
        /// Gets or sets the header text.
        /// </summary>
        /// <value>
        /// The header text.
        /// </value>
        public string HeaderText { get => _headerText; set => _headerText = value; }

        /// <summary>
        /// Gets or sets the content text.
        /// </summary>
        /// <value>
        /// The content text.
        /// </value>
        public string ContentText { get => _contentText; set => _contentText = value; }

        /// <summary>
        /// Gets or sets the name of the process.
        /// </summary>
        /// <value>
        /// The name of the process.
        /// </value>
        public string ProcessName { get => _processName; set => _processName = value; }

        /// <summary>
        /// Gets or sets the icon image.
        /// </summary>
        /// <value>
        /// The icon image.
        /// </value>
        public Image IconImage
        {
            get => _image; set { _image = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the seconds.
        /// </summary>
        /// <value>
        /// The seconds.
        /// </value>
        public int Seconds { get; set; }

        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = value; Invalidate(); } }

        public PaletteDrawBorders PaletteDrawBorders { get => _drawBorders; set { _drawBorders = value; Invalidate(); } }

        public IconType Type { get => _iconType; set => _iconType = value; }

        /// <summary>
        /// Gets or sets the right to left support.
        /// </summary>
        /// <value>
        /// The right to left support.
        /// </value>
        public RightToLeftSupport RightToLeft { get => _rightToLeftSupport; set { _rightToLeftSupport = value; Invalidate(); } }
        #endregion

        #region Constructors                
        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonToastNotificationDialog" /> class.
        /// </summary>
        /// <param name="fade">if set to <c>true</c> [fade].</param>
        /// <param name="icon">The icon.</param>
        /// <param name="headerText">The header text.</param>
        /// <param name="contentText">The content text.</param>
        /// <param name="showControlBox">if set to <c>true</c> [show control box].</param>
        //public KryptonToastNotificationDialog(bool fade, Image image, string headerText, string contentText, bool showControlBox = true, RightToLeftSupport rightToLeftSupport = RightToLeftSupport.LEFTTORIGHT)
        //{
        //    InitializeComponent();

        //    Fade = fade;

        //    IconImage = image;

        //    HeaderText = headerText;

        //    ContentText = contentText;

        //    TopMost = true;

        //    Resize += KryptonToastNotificationDialog_Resize;

        //    GotFocus += KryptonToastNotificationDialog_GotFocus;

        //    DoubleBuffered = true;

        //    ControlBox = showControlBox;

        //    RightToLeftSupport = rightToLeftSupport;
        //}

        public KryptonToastNotificationDialog(bool fade, Image icon, string headerText, string contentText, bool showControlBox = true)
        {
            InitializeComponent();

            Fade = fade;

            pbxInfoboxIcon.Image = icon;

            HeaderText = headerText;

            ContentText = contentText;

            TopMost = true;

            Resize += KryptonToastNotificationDialog_Resize;

            GotFocus += KryptonToastNotificationDialog_GotFocus;

            DoubleBuffered = true;

            ControlBox = showControlBox;
        }

        public KryptonToastNotificationDialog(bool fade, IconType iconType, string headerText, string contentText, bool showControlBox = true)
        {
            InitializeComponent();

            Fade = fade;

            Type = iconType;

            #region Update Icons
            if (iconType == IconType.NONE)
            {
                pbxInfoboxIcon.Image = null;

                pbxInfoboxIcon.Visible = false;
            }
            else if (iconType == IconType.QUESTION)
            {
                pbxInfoboxIcon.Image = BitmapToImage(Properties.Resources.Question_128_x_128);
            }
            else if (iconType == IconType.INFORMATION)
            {
                pbxInfoboxIcon.Image = BitmapToImage(Properties.Resources.Information_128_x_128);
            }
            else if (iconType == IconType.WARNING)
            {
                pbxInfoboxIcon.Image = BitmapToImage(Properties.Resources.Warning_128_x_128);
            }
            else if (iconType == IconType.ERROR)
            {
                pbxInfoboxIcon.Image = BitmapToImage(Properties.Resources.Critical_128_x_128);
            }
            else if (iconType == IconType.HAND)
            {
                pbxInfoboxIcon.Image = BitmapToImage(Properties.Resources.Hand_128_x_128);
            }
            else if (iconType == IconType.STOP)
            {
                pbxInfoboxIcon.Image = BitmapToImage(Properties.Resources.Stop_128_x_128);
            }
            else if (iconType == IconType.OK)
            {
                pbxInfoboxIcon.Image = BitmapToImage(Properties.Resources.Ok_128_x_128);
            }
            #endregion

            HeaderText = headerText;

            ContentText = contentText;

            TopMost = true;

            Resize += KryptonToastNotificationDialog_Resize;

            GotFocus += KryptonToastNotificationDialog_GotFocus;

            DoubleBuffered = true;

            ControlBox = showControlBox;
        }

        private void KryptonToastNotificationDialog_Resize(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void KryptonToastNotificationDialog_GotFocus(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private Image BitmapToImage(Bitmap bitmap)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonToastNotificationDialog"/> class.
        /// </summary>
        /// <param name="fade">if set to <c>true</c> [fade].</param>
        /// <param name="image">The image.</param>
        /// <param name="headerText">The header text.</param>
        /// <param name="contentText">The content text.</param>
        /// <param name="seconds">The seconds.</param>
        public KryptonToastNotificationDialog(bool fade, Image image, string headerText, string contentText, int seconds, bool showControlBox = true) : this(fade, image, headerText, contentText, showControlBox)
        {
            Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonToastNotificationDialog"/> class.
        /// </summary>
        /// <param name="fade">if set to <c>true</c> [fade].</param>
        /// <param name="image">The image.</param>
        /// <param name="headerText">The header text.</param>
        /// <param name="contentText">The content text.</param>
        /// <param name="seconds">The seconds.</param>
        /// <param name="soundPath">The sound path.</param>
        public KryptonToastNotificationDialog(bool fade, Image image, string headerText, string contentText, int seconds, string soundPath, bool showControlBox = true) : this(fade, image, headerText, contentText, seconds, showControlBox)
        {
            SoundPath = soundPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonToastNotificationDialog"/> class.
        /// </summary>
        /// <param name="fade">if set to <c>true</c> [fade].</param>
        /// <param name="image">The image.</param>
        /// <param name="headerText">The header text.</param>
        /// <param name="contentText">The content text.</param>
        /// <param name="soundPath">The sound path.</param>
        public KryptonToastNotificationDialog(bool fade, Image image, string headerText, string contentText, string soundPath, bool showControlBox = true) : this(fade, image, headerText, contentText, showControlBox)
        {
            SoundPath = soundPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonToastNotificationDialog"/> class.
        /// </summary>
        /// <param name="fade">if set to <c>true</c> [fade].</param>
        /// <param name="image">The image.</param>
        /// <param name="headerText">The header text.</param>
        /// <param name="contentText">The content text.</param>
        /// <param name="soundStream">The sound stream.</param>
        public KryptonToastNotificationDialog(bool fade, Image image, string headerText, string contentText, Stream soundStream, bool showControlBox = true) : this(fade, image, headerText, contentText, showControlBox)
        {
            SoundStream = soundStream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonToastNotificationDialog"/> class.
        /// </summary>
        /// <param name="fade">if set to <c>true</c> [fade].</param>
        /// <param name="image">The image.</param>
        /// <param name="headerText">The header text.</param>
        /// <param name="contentText">The content text.</param>
        /// <param name="seconds">The seconds.</param>
        /// <param name="soundStream">The sound stream.</param>
        public KryptonToastNotificationDialog(bool fade, Image image, string headerText, string contentText, int seconds, Stream soundStream, bool showControlBox = true) : this(fade, image, headerText, contentText, seconds, showControlBox)
        {
            SoundStream = soundStream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonToastNotificationDialog"/> class.
        /// </summary>
        /// <param name="fade">if set to <c>true</c> [fade].</param>
        /// <param name="image">The image.</param>
        /// <param name="headerText">The header text.</param>
        /// <param name="contentText">The content text.</param>
        /// <param name="showActionButton">if set to <c>true</c> [show action button].</param>
        /// <param name="actionType">Type of the action.</param>
        /// <param name="processName">Name of the process.</param>
        /// <param name="showControlBox">if set to <c>true</c> [show control box].</param>
        public KryptonToastNotificationDialog(bool fade, Image image, string headerText, string contentText, bool showActionButton, ActionType actionType, string processName, bool showControlBox = true) : this(fade, image, headerText, contentText, showControlBox)
        {
            ShowActionButton = showActionButton;

            ActionType = actionType;

            ProcessName = processName;

            SetActionText(actionType);
        }

        /// <summary>Initializes a new instance of the <see cref="KryptonToastNotificationDialog"/> class.</summary>
        /// <param name="fade">if set to <c>true</c> [fade].</param>
        /// <param name="image">The image.</param>
        /// <param name="headerText">The header text.</param>
        /// <param name="contentText">The content text.</param>
        /// <param name="showActionButton">if set to <c>true</c> [show action button].</param>
        /// <param name="actionType">Type of the action.</param>
        /// <param name="processName">Name of the process.</param>
        /// <param name="showControlBox">if set to <c>true</c> [show control box].</param>
        /// <param name="cornerRadius">The corner radius.</param>
        public KryptonToastNotificationDialog(bool fade, Image image, string headerText, string contentText, bool showActionButton, ActionType actionType, string processName, bool showControlBox = true, int cornerRadius = -1) : this(fade, image, headerText, contentText, showControlBox)
        {
            CornerRadius = cornerRadius;
        }

        /// <summary>Initializes a new instance of the <see cref="KryptonToastNotificationDialog"/> class.</summary>
        /// <param name="fade">if set to <c>true</c> [fade].</param>
        /// <param name="image">The image.</param>
        /// <param name="headerText">The header text.</param>
        /// <param name="contentText">The content text.</param>
        /// <param name="showActionButton">if set to <c>true</c> [show action button].</param>
        /// <param name="actionType">Type of the action.</param>
        /// <param name="processName">Name of the process.</param>
        /// <param name="showControlBox">if set to <c>true</c> [show control box].</param>
        /// <param name="cornerRadius">The corner radius.</param>
        /// <param name="borders">The borders.</param>
        public KryptonToastNotificationDialog(bool fade, Image image, string headerText, string contentText, bool showActionButton, ActionType actionType, string processName, bool showControlBox = true, int cornerRadius = -1, PaletteDrawBorders borders = PaletteDrawBorders.All) : this(fade, image, headerText, contentText, showControlBox)
        {
            PaletteDrawBorders = borders;
        }
        #endregion

        private void KryptonToastNotificationDialog_Load(object sender, EventArgs e)
        {

        }
    }
    */
}