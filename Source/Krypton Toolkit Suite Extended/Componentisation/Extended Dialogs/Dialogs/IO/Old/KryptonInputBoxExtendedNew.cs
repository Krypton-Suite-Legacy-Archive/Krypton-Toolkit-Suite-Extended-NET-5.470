#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedDialogs.Enumerations;
using ExtendedDialogs.Miscellaneous;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedDialogs.Dialogs.IO.Old
{
    public class KryptonInputBoxExtendedNew : KryptonForm
    {
        #region Designer Code
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnAbort;
        private KryptonButton kbtnYes;
        private KryptonButton kbtnNo;
        private System.Windows.Forms.Panel panel1;
        private KryptonButton kbtnOk;
        private KryptonPanel kryptonPanel2;
        private System.Windows.Forms.PictureBox pbxIcon;
        private KryptonComboBox kcmbUserChoice;
        private KryptonLabel klblMessage;
        private KryptonTextBox ktxtUserResponse;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnAbort = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnYes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnNo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ktxtUserResponse = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kcmbUserChoice = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.klblMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbUserChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Controls.Add(this.kbtnAbort);
            this.kryptonPanel1.Controls.Add(this.kbtnYes);
            this.kryptonPanel1.Controls.Add(this.kbtnNo);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 210);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(576, 51);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.Location = new System.Drawing.Point(378, 8);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(90, 31);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 4;
            this.kbtnOk.Values.Text = "&OK";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.Location = new System.Drawing.Point(474, 8);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 31);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 3;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kbtnAbort
            // 
            this.kbtnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnAbort.Location = new System.Drawing.Point(474, 8);
            this.kbtnAbort.Name = "kbtnAbort";
            this.kbtnAbort.Size = new System.Drawing.Size(90, 31);
            this.kbtnAbort.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnAbort.TabIndex = 2;
            this.kbtnAbort.Values.Text = "&Abort";
            this.kbtnAbort.Click += new System.EventHandler(this.kbtnAbort_Click);
            // 
            // kbtnYes
            // 
            this.kbtnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnYes.Location = new System.Drawing.Point(378, 8);
            this.kbtnYes.Name = "kbtnYes";
            this.kbtnYes.Size = new System.Drawing.Size(90, 31);
            this.kbtnYes.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnYes.TabIndex = 1;
            this.kbtnYes.Values.Text = "&Yes";
            this.kbtnYes.Click += new System.EventHandler(this.kbtnYes_Click);
            // 
            // kbtnNo
            // 
            this.kbtnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnNo.Location = new System.Drawing.Point(474, 8);
            this.kbtnNo.Name = "kbtnNo";
            this.kbtnNo.Size = new System.Drawing.Size(90, 31);
            this.kbtnNo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnNo.TabIndex = 0;
            this.kbtnNo.Values.Text = "&No";
            this.kbtnNo.Click += new System.EventHandler(this.kbtnNo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 3);
            this.panel1.TabIndex = 8;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.ktxtUserResponse);
            this.kryptonPanel2.Controls.Add(this.kcmbUserChoice);
            this.kryptonPanel2.Controls.Add(this.klblMessage);
            this.kryptonPanel2.Controls.Add(this.pbxIcon);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(576, 207);
            this.kryptonPanel2.TabIndex = 9;
            // 
            // ktxtUserResponse
            // 
            this.ktxtUserResponse.Location = new System.Drawing.Point(180, 150);
            this.ktxtUserResponse.Name = "ktxtUserResponse";
            this.ktxtUserResponse.Size = new System.Drawing.Size(269, 25);
            this.ktxtUserResponse.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtUserResponse.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtUserResponse.TabIndex = 12;
            this.ktxtUserResponse.ToolTipValues.Description = "Type your response here...";
            this.ktxtUserResponse.ToolTipValues.EnableToolTips = true;
            this.ktxtUserResponse.ToolTipValues.Heading = "User Response";
            this.ktxtUserResponse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ktxtUserResponse_KeyDown);
            // 
            // kcmbUserChoice
            // 
            this.kcmbUserChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbUserChoice.DropDownWidth = 269;
            this.kcmbUserChoice.IntegralHeight = false;
            this.kcmbUserChoice.Location = new System.Drawing.Point(180, 150);
            this.kcmbUserChoice.Name = "kcmbUserChoice";
            this.kcmbUserChoice.Size = new System.Drawing.Size(269, 23);
            this.kcmbUserChoice.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbUserChoice.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbUserChoice.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbUserChoice.TabIndex = 11;
            // 
            // klblMessage
            // 
            this.klblMessage.AutoSize = false;
            this.klblMessage.Location = new System.Drawing.Point(82, 12);
            this.klblMessage.Name = "klblMessage";
            this.klblMessage.Size = new System.Drawing.Size(482, 132);
            this.klblMessage.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMessage.TabIndex = 10;
            this.klblMessage.Values.Text = "{0}";
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Location = new System.Drawing.Point(12, 12);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(64, 64);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxIcon.TabIndex = 4;
            this.pbxIcon.TabStop = false;
            // 
            // KryptonInputBoxExtended
            // 
            this.ClientSize = new System.Drawing.Size(576, 261);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonInputBoxExtended";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KryptonInputBoxExtended_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbUserChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private static DialogResult _userResponse;

        private static string[] _buttonTextArray = new string[4];

        private Image[] _inputBoxDefaultImages = new Image[8];
        #endregion

        #region Properties
        /// <summary>Gets or sets the user response.</summary>
        /// <value>The user response.</value>
        public static DialogResult UserResponse { get => _userResponse; set => _userResponse = value; }

        /// <summary>Gets the input box default images.</summary>
        /// <value>The input box default images.</value>
        public Image[] InputBoxDefaultImages { get => _inputBoxDefaultImages; private set { _inputBoxDefaultImages = value; Invalidate(); } }
        #endregion

        #region Constructors
        public KryptonInputBoxExtendedNew(string message, string title, Language language = Language.ENGLISH)
        {
            InitializeComponent();

            SetIcon(InputBoxIcon.NONE);

            AdaptButtons(InputBoxButtons.OK);

            SetMessage(message);

            SetTitle(title);
        }

        public KryptonInputBoxExtendedNew(string message, string title, InputBoxButtons buttons, Language language = Language.ENGLISH, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel")
        {

        }

        public KryptonInputBoxExtendedNew(string message, string title, InputBoxType type = InputBoxType.NOTHING, Language language = Language.ENGLISH)
        {

        }

        /// <summary>Initializes a new instance of the <see cref="KryptonInputBoxExtendedNew"/> class.</summary>
        /// <param name="message">The message.</param>
        /// <param name="title">The title.</param>
        /// <param name="imageSize">Size of the image.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="image">The image.</param>
        /// <param name="language">The language.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="type">The type.</param>
        /// <param name="listItems">The list items.</param>
        /// <param name="showInTaskBar">if set to <c>true</c> [show in task bar].</param>
        /// <param name="controlTypeface">The control typeface.</param>
        /// <param name="messageTypeface">The message typeface.</param>
        /// <param name="okText">The ok text.</param>
        /// <param name="yesText">The yes text.</param>
        /// <param name="noText">The no text.</param>
        /// <param name="cancelText">The cancel text.</param>
        /// <param name="hintText">The hint text.</param>
        /// <param name="messageTextAlignment">The message text alignment.</param>
        /// <param name="userInputTextAlignment">The user input text alignment.</param>
        /// <param name="userSelectionTextAlignment">The user selection text alignment.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="ownerStartPosition">The owner start position.</param>
        /// <param name="startPosition">The start position.</param>
        /// <param name="rightToLeft">The right to left.</param>
        /// <param name="showOnTop">if set to <c>true</c> [show on top].</param>
        public KryptonInputBoxExtendedNew(string message, string title, InputBoxIconImageSize imageSize = InputBoxIconImageSize.ONEHUNDREDANDTWENTYEIGHT, InputBoxIcon icon = InputBoxIcon.INFORMATION, Image image = null, Language language = Language.ENGLISH, InputBoxButtons buttons = InputBoxButtons.OK, InputBoxType type = InputBoxType.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "", InputBoxMessageTextAlignment messageTextAlignment = InputBoxMessageTextAlignment.LEFT, InputBoxUserInputTextAlignment userInputTextAlignment = InputBoxUserInputTextAlignment.LEFT, InputBoxUserSelectionTextAlignment userSelectionTextAlignment = InputBoxUserSelectionTextAlignment.LEFT, KryptonForm owner = null, FormStartPosition ownerStartPosition = FormStartPosition.WindowsDefaultLocation, FormStartPosition startPosition = FormStartPosition.CenterScreen, InputBoxMessageRightToLeft rightToLeft = InputBoxMessageRightToLeft.NO, bool showOnTop = false)
        {
            InitializeComponent();

            SetMessage(message);

            SetTitle(title);

            SetStartPosition(startPosition);

            SetOwnerStartPosition(owner, ownerStartPosition);

            SetShowInTaskbar(showInTaskBar);

            SetOwner(owner);

            SetIcon(icon, image);

            SetImageSize(imageSize);

            AdaptIcon(icon, imageSize, image);

            SetLanguage(language, okText, yesText, noText, cancelText);

            AdaptButtons(buttons);

            AdaptUI(type, listItems);

            SetControlTypeface(controlTypeface);

            SetMessageTypeface(messageTypeface);

            SetHint(hintText);
        }
        #endregion

        #region Setters/Getters
        /// <summary>
        /// Sets the UserResponse.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetUserDialogResponse(DialogResult value) => UserResponse = value;

        /// <summary>
        /// Gets the UserResponse.
        /// </summary>
        /// <returns>The value of UserResponse.</returns>
        public DialogResult GetUserDialogResponse() => UserResponse;

        /// <summary>
        /// Sets the InputBoxDefaultImages.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetInputBoxDefaultImages(Image[] value) => InputBoxDefaultImages = value;

        /// <summary>
        /// Gets the InputBoxDefaultImages.
        /// </summary>
        /// <returns>The value of InputBoxDefaultImages.</returns>
        public Image[] GetInputBoxDefaultImages() => InputBoxDefaultImages;
        #endregion

        #region Methods
        /// <summary>
        /// Sets the message.
        /// </summary>
        /// <param name="message">The message.</param>
        private void SetMessage(string message) => klblMessage.Text = message;

        /// <summary>Sets the message typeface.</summary>
        /// <param name="typeface">The typeface.</param>
        private void SetMessageTypeface(Font typeface) => klblMessage.StateCommon.ShortText.Font = typeface;

        /// <summary>
        /// Sets the hint.
        /// </summary>
        /// <param name="hintText">The hint text.</param>
        private void SetHint(string hintText) => ktxtUserResponse.Hint = hintText;

        /// <summary>Sets the title.</summary>
        /// <param name="title">The title.</param>
        private void SetTitle(string title) => Text = title;

        /// <summary>Sets the control typeface.</summary>
        /// <param name="typeface">The typeface.</param>
        private void SetControlTypeface(Font typeface)
        {
            kbtnCancel.StateCommon.Content.ShortText.Font = typeface;

            kbtnNo.StateCommon.Content.ShortText.Font = typeface;

            kbtnOk.StateCommon.Content.ShortText.Font = typeface;

            kbtnYes.StateCommon.Content.ShortText.Font = typeface;
        }

        /// <summary>Sets the language.</summary>
        /// <param name="language">The language.</param>
        /// <param name="okText">The ok text.</param>
        /// <param name="yesText">The yes text.</param>
        /// <param name="noText">The no text.</param>
        /// <param name="cancelText">The cancel text.</param>
        private void SetLanguage(Language language, string okText = "", string yesText = "", string noText = "", string cancelText = "")
        {
            switch (language)
            {
                case Language.CZECH:
                    _buttonTextArray = "OK,Ano,Ne,Storno".Split(',');
                    break;
                case Language.FRANÇAIS:
                    _buttonTextArray = "OK,Oui,Non,Annuler".Split(',');
                    break;
                case Language.DEUTSCH:
                    _buttonTextArray = "OK,Ja,Nein,Abbrechen".Split(',');
                    break;
                case Language.SLOVAKIAN:
                    _buttonTextArray = "OK,Áno,Nie,Zrušiť".Split(',');
                    break;
                case Language.ESPAÑOL:
                    _buttonTextArray = "OK,Sí,No,Cancelar".Split(',');
                    break;
                case Language.CUSTOM:
                    _buttonTextArray = SetCustomText(okText, yesText, noText, cancelText);
                    break;
                default:
                    _buttonTextArray = "OK,Yes,No,Cancel".Split(',');
                    break;
            }
        }

        /// <summary>
        /// Sets the custom text.
        /// </summary>
        /// <param name="okText">The ok text.</param>
        /// <param name="yesText">The yes text.</param>
        /// <param name="noText">The no text.</param>
        /// <param name="cancelText">The cancel text.</param>
        /// <returns></returns>
        private static string[] SetCustomText(string okText, string yesText, string noText, string cancelText)
        {
            string[] tempArray = new string[4];

            tempArray = $"{ okText },{ yesText },{ noText },{ cancelText }".Split(',');

            return tempArray;
        }

        /// <summary>Sets the icon.</summary>
        /// <param name="icon">The icon.</param>
        /// <param name="customImage">The custom image.</param>
        private void SetIcon(InputBoxIcon icon, Image customImage = null)
        {
            if (GetInputBoxDefaultImages().Length > 0)
            {
                switch (icon)
                {
                    case InputBoxIcon.CUSTOM:
                        NormalIconLayout();

                        if (customImage != null)
                        {
                            pbxIcon.Image = customImage;
                        }
                        break;
                    case InputBoxIcon.OK:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxDefaultImages[3];
                        break;
                    case InputBoxIcon.ERROR:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxDefaultImages[0];
                        break;
                    case InputBoxIcon.EXCLAMATION:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxDefaultImages[6];
                        break;
                    case InputBoxIcon.INFORMATION:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxDefaultImages[2];
                        break;
                    case InputBoxIcon.QUESTION:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxDefaultImages[4];
                        break;
                    case InputBoxIcon.NONE:
                        SetNoIconLayout();
                        break;
                    case InputBoxIcon.STOP:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxDefaultImages[5];
                        break;
                    case InputBoxIcon.HAND:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxDefaultImages[1];
                        break;
                }
            }
            else
            {
                switch (icon)
                {
                    case InputBoxIcon.CUSTOM:
                        NormalIconLayout();

                        if (customImage != null)
                        {
                            pbxIcon.Image = customImage;
                        }
                        break;
                    case InputBoxIcon.OK:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxResources.Input_Box_Ok_64_x_64;
                        break;
                    case InputBoxIcon.ERROR:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxResources.Input_Box_Critical_64_x_64;
                        break;
                    case InputBoxIcon.EXCLAMATION:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxResources.Input_Box_Warning_64_x_58;
                        break;
                    case InputBoxIcon.INFORMATION:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxResources.Input_Box_Information_64_x_64;
                        break;
                    case InputBoxIcon.QUESTION:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxResources.Input_Box_Question_64_x_64;
                        break;
                    case InputBoxIcon.NONE:
                        SetNoIconLayout();
                        break;
                    case InputBoxIcon.STOP:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxResources.Input_Box_Stop_64_x_64;
                        break;
                    case InputBoxIcon.HAND:
                        NormalIconLayout();

                        pbxIcon.Image = InputBoxResources.Input_Box_Hand_64_x_64;
                        break;
                }
            }
        }

        /// <summary>Sets the no icon layout.</summary>
        private void SetNoIconLayout()
        {
            pbxIcon.Visible = false;

            klblMessage.Size = new Size(552, 132);

            ktxtUserResponse.Location = new Point(146, 150);

            kcmbUserChoice.Location = new Point(146, 150);
        }

        /// <summary>Normals the icon layout.</summary>
        private void NormalIconLayout()
        {
            pbxIcon.Visible = true;

            klblMessage.Size = new Size(482, 132);

            ktxtUserResponse.Location = new Point(180, 150);

            kcmbUserChoice.Location = new Point(180, 150);
        }

        /// <summary>Gets the height of the image.</summary>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        private int GetImageHeight(Image image) => image.Height;

        /// <summary>Gets the width of the image.</summary>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        private int GetImageWidth(Image image) => image.Width;

        /// <summary>
        /// Adapts the buttons.
        /// </summary>
        /// <param name="buttons">The buttons.</param>
        /// <returns></returns>
        private KryptonButton[] AdaptButtons(InputBoxButtons buttons)
        {
            KryptonButton[] buttonArray = new KryptonButton[3];

            #region Set Button Text
            kbtnOk.Text = _buttonTextArray[0];

            kbtnYes.Text = _buttonTextArray[1];

            kbtnNo.Text = _buttonTextArray[2];

            kbtnCancel.Text = _buttonTextArray[3];
            #endregion

            switch (buttons)
            {
                case InputBoxButtons.OK:
                    kbtnOk.Location = new Point(474, 8);

                    buttonArray[0] = kbtnOk;
                    break;
                case InputBoxButtons.OKCANCEL:
                    kbtnOk.Location = new Point(378, 8);

                    buttonArray[0] = kbtnOk;

                    kbtnCancel.Location = new Point(474, 8);

                    buttonArray[1] = kbtnCancel;
                    break;
                case InputBoxButtons.YESNO:
                    kbtnYes.Location = new Point(378, 8);

                    buttonArray[0] = kbtnYes;

                    kbtnNo.Location = new Point(474, 8);

                    buttonArray[1] = kbtnNo;
                    break;
                case InputBoxButtons.YESNOCANCEL:
                    kbtnYes.Location = new Point(282, 8);

                    buttonArray[0] = kbtnYes;

                    kbtnNo.Location = new Point(378, 8);

                    buttonArray[1] = kbtnNo;

                    kbtnCancel.Location = new Point(474, 8);

                    buttonArray[2] = kbtnCancel;
                    break;
            }

            foreach (KryptonButton button in buttonArray)
            {
                if (button != null)
                {
                    button.Size = new Size(90, 31);

                    //button.Click += Button_Click;
                }
            }

            return buttonArray;
        }

        /// <summary>Adapts the UI.</summary>
        /// <param name="type">The type.</param>
        /// <param name="items">The items.</param>
        private void AdaptUI(InputBoxType type, string[] items)
        {
            if (items != null)
            {
                foreach (string item in items)
                {
                    kcmbUserChoice.Items.Add(item);
                }

                kcmbUserChoice.SelectedIndex = 0;
            }

            switch (type)
            {
                case InputBoxType.COMBOBOX:
                    ktxtUserResponse.Visible = false;

                    kcmbUserChoice.Visible = true;
                    break;
                case InputBoxType.TEXTBOX:
                    ktxtUserResponse.Visible = true;

                    kcmbUserChoice.Visible = false;
                    break;
            }
        }

        /// <summary>Changes the button visibility.</summary>
        /// <param name="buttons">The buttons.</param>
        private void ChangeButtonVisibility(InputBoxButtons buttons)
        {
            switch (buttons)
            {
                case InputBoxButtons.OK:
                    break;
                case InputBoxButtons.OKCANCEL:
                    break;
                case InputBoxButtons.YESNO:
                    break;
                case InputBoxButtons.YESNOCANCEL:
                    break;
                default:
                    break;
            }
        }

        /// <summary>Changes the input box message text alignment.</summary>
        /// <param name="alignment">The alignment.</param>
        private void ChangeInputBoxMessageTextAlignment(InputBoxMessageTextAlignment alignment)
        {
            switch (alignment)
            {
                case InputBoxMessageTextAlignment.LEFT:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Near;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Near;
                    break;
                case InputBoxMessageTextAlignment.CENTRE:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
                    break;
                case InputBoxMessageTextAlignment.RIGHT:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Far;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Far;
                    break;
                case InputBoxMessageTextAlignment.INHERIT:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Inherit;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Inherit;
                    break;
            }
        }

        /// <summary>Changes the input box user input text alignment.</summary>
        /// <param name="alignment">The alignment.</param>
        private void ChangeInputBoxUserInputTextAlignment(PaletteRelativeAlign alignment) => ktxtUserResponse.StateCommon.Content.TextH = alignment;

        /// <summary>Changes the input box user selection text alignment.</summary>
        /// <param name="alignment">The alignment.</param>
        private void ChangeInputBoxUserSelectionTextAlignment(PaletteRelativeAlign alignment) => kcmbUserChoice.StateCommon.ComboBox.Content.TextH = alignment;

        /// <summary>Relocates the buttons.</summary>
        /// <param name="buttons">The buttons.</param>
        /// <param name="buttonOneLocation">The first button location.</param>
        /// <param name="buttonTwoLocation">The second button location.</param>
        /// <param name="buttonThreeLocation">The third button location.</param>
        private void RelocateButtons(InputBoxButtons buttons, Point buttonOneLocation, Point buttonTwoLocation, Point buttonThreeLocation)
        {
            switch (buttons)
            {
                case InputBoxButtons.OK:
                    kbtnOk.Location = buttonThreeLocation;
                    break;
                case InputBoxButtons.OKCANCEL:
                    kbtnOk.Location = buttonTwoLocation;

                    kbtnCancel.Location = buttonThreeLocation;
                    break;
                case InputBoxButtons.YESNO:
                    kbtnYes.Location = buttonTwoLocation;

                    kbtnNo.Location = buttonThreeLocation;
                    break;
                case InputBoxButtons.YESNOCANCEL:
                    kbtnYes.Location = buttonOneLocation;

                    kbtnNo.Location = buttonTwoLocation;

                    kbtnCancel.Location = buttonThreeLocation;
                    break;
            }
        }

        /// <summary>Relocates the buttons.</summary>
        /// <param name="buttonOne">The first one.</param>
        /// <param name="buttonTwo">The second two.</param>
        /// <param name="buttonThree">The third three.</param>
        /// <param name="buttonOneLocation">The first button location.</param>
        /// <param name="buttonTwoLocation">The second button location.</param>
        /// <param name="buttonThreeLocation">The third button location.</param>
        private void RelocateButtons(KryptonButton buttonOne, KryptonButton buttonTwo, KryptonButton buttonThree, Point buttonOneLocation, Point buttonTwoLocation, Point buttonThreeLocation)
        {
            buttonOne.Location = buttonOneLocation;

            buttonTwo.Location = buttonTwoLocation;

            buttonThree.Location = buttonThreeLocation;
        }

        /// <summary>Changes the input box message right to left layout.</summary>
        /// <param name="rightToLeft">The right to left.</param>
        private void ChangeInputBoxMessageRightToLeftLayout(InputBoxMessageRightToLeft rightToLeft)
        {
            SwapLayout(rightToLeft);

            switch (rightToLeft)
            {
                case InputBoxMessageRightToLeft.NO:
                    klblMessage.RightToLeft = RightToLeft.No;

                    ktxtUserResponse.RightToLeft = RightToLeft.No;

                    kcmbUserChoice.RightToLeft = RightToLeft.No;

                    kbtnAbort.RightToLeft = RightToLeft.No;

                    kbtnCancel.RightToLeft = RightToLeft.No;

                    kbtnNo.RightToLeft = RightToLeft.No;

                    kbtnOk.RightToLeft = RightToLeft.No;

                    kbtnYes.RightToLeft = RightToLeft.No;
                    break;
                case InputBoxMessageRightToLeft.YES:
                    klblMessage.RightToLeft = RightToLeft.Yes;

                    ktxtUserResponse.RightToLeft = RightToLeft.Yes;

                    kcmbUserChoice.RightToLeft = RightToLeft.Yes;

                    kbtnAbort.RightToLeft = RightToLeft.Yes;

                    kbtnCancel.RightToLeft = RightToLeft.Yes;

                    kbtnNo.RightToLeft = RightToLeft.Yes;

                    kbtnOk.RightToLeft = RightToLeft.Yes;

                    kbtnYes.RightToLeft = RightToLeft.Yes;
                    break;
                case InputBoxMessageRightToLeft.INHERIT:
                    klblMessage.RightToLeft = RightToLeft.Inherit;

                    ktxtUserResponse.RightToLeft = RightToLeft.Inherit;

                    kcmbUserChoice.RightToLeft = RightToLeft.Inherit;

                    kbtnAbort.RightToLeft = RightToLeft.Inherit;

                    kbtnCancel.RightToLeft = RightToLeft.Inherit;

                    kbtnNo.RightToLeft = RightToLeft.Inherit;

                    kbtnOk.RightToLeft = RightToLeft.Inherit;

                    kbtnYes.RightToLeft = RightToLeft.Inherit;
                    break;
            }
        }

        /// <summary>Swaps the layout.</summary>
        /// <param name="rightToLeft">The right to left.</param>
        private void SwapLayout(InputBoxMessageRightToLeft rightToLeft)
        {
            switch (rightToLeft)
            {
                case InputBoxMessageRightToLeft.NO:
                    RelocateControls(new Point(12, 12), new Point(82, 12), new Point(180, 150), new Point(180, 150), new Point(474, 8), new Point(474, 8), new Point(378, 8), new Point(378, 8), new Point(474, 8));
                    break;
                case InputBoxMessageRightToLeft.YES:
                    RelocateControls(new Point(500, 12), new Point(12, 12), new Point(126, 150), new Point(126, 150), new Point(12, 8), new Point(12, 8), new Point(108, 8), new Point(108, 8), new Point(108, 8));
                    break;
                case InputBoxMessageRightToLeft.INHERIT:
                    break;
            }
        }

        /// <summary>Relocates the controls.</summary>
        /// <param name="pictureBoxLocation">The picture box location.</param>
        /// <param name="messageLabelLocation">The message label location.</param>
        /// <param name="userInputLocation">The user input location.</param>
        /// <param name="userSelectionBoxLocation">The user selection box location.</param>
        /// <param name="abortButtonLocation">The abort button location.</param>
        /// <param name="cancelButtonLocation">The cancel button location.</param>
        /// <param name="okButtonLocation">The ok button location.</param>
        /// <param name="yesButtonLocation">The yes button location.</param>
        /// <param name="noButtonLocation">The no button location.</param>
        private void RelocateControls(Point pictureBoxLocation, Point messageLabelLocation, Point userInputLocation, Point userSelectionBoxLocation, Point abortButtonLocation, Point cancelButtonLocation, Point okButtonLocation, Point yesButtonLocation, Point noButtonLocation)
        {
            pbxIcon.Location = pictureBoxLocation;

            klblMessage.Location = messageLabelLocation;

            ktxtUserResponse.Location = userInputLocation;

            kcmbUserChoice.Location = userSelectionBoxLocation;

            kbtnAbort.Location = abortButtonLocation;

            kbtnCancel.Location = cancelButtonLocation;

            kbtnNo.Location = noButtonLocation;

            kbtnOk.Location = okButtonLocation;

            kbtnYes.Location = yesButtonLocation;
        }

        /// <summary>Gets the user response.</summary>
        /// <returns></returns>
        public string GetUserResponse() => ktxtUserResponse.Text;

        /// <summary>Gets the user selection.</summary>
        /// <returns></returns>
        public string GetUserSelection() => kcmbUserChoice.Text;

        /// <summary>Populates the image array.</summary>
        /// <param name="images">The images.</param>
        /// <returns></returns>
        private Image[] PopulateImageArray(Image[] images)
        {
            images[0] = InputBoxResources.Input_Box_Critical_64_x_64;

            images[1] = InputBoxResources.Input_Box_Hand_64_x_64;

            images[2] = InputBoxResources.Input_Box_Information_64_x_64;

            images[3] = InputBoxResources.Input_Box_Ok_64_x_64;

            images[4] = InputBoxResources.Input_Box_Question_64_x_64;

            images[5] = InputBoxResources.Input_Box_Stop_64_x_64;

            images[6] = InputBoxResources.Input_Box_Warning_64_x_58;

            return images;
        }

        private void SetOwner(KryptonForm owner)
        {
            throw new NotImplementedException();
        }

        private void SetShowInTaskbar(bool showInTaskBar) => ShowInTaskbar = showInTaskBar;

        private void SetOwnerStartPosition(KryptonForm owner, FormStartPosition ownerStartPosition)
        {
            throw new NotImplementedException();
        }

        private void SetStartPosition(FormStartPosition startPosition) => StartPosition = startPosition;

        private void SetImageSize(InputBoxIconImageSize imageSize, int width = 0, int height = 0)
        {
            switch (imageSize)
            {
                case InputBoxIconImageSize.CUSTOM:
                    pbxIcon.Size = new Size(width, height);
                    break;
                case InputBoxIconImageSize.THIRTYTWO:
                    break;
                case InputBoxIconImageSize.FOURTYEIGHT:
                    break;
                case InputBoxIconImageSize.SIXTYFOUR:
                    break;
                case InputBoxIconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                    break;
            }
        }

        private void AdaptIcon(InputBoxIcon icon, InputBoxIconImageSize imageSize, Image image = null)
        {
            if (imageSize == InputBoxIconImageSize.CUSTOM)
            {
                AdaptIconSize(icon, imageSize, image);
            }
            else
            {
                AdaptIconSize(icon, imageSize);
            }
        }

        private void AdaptIconSize(InputBoxIcon icon, InputBoxIconImageSize imageSize, Image customImage = null)
        {
            switch (icon)
            {
                case InputBoxIcon.CUSTOM:
                    switch (imageSize)
                    {
                        case InputBoxIconImageSize.CUSTOM:
                            AssignImage(customImage);

                            AdaptInputBoxIconContainerSize(InputBoxIconImageSize.CUSTOM, GetImageWidth(customImage), GetImageHeight(customImage));
                            break;
                        case InputBoxIconImageSize.THIRTYTWO:
                            AssignImage(customImage);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.FOURTYEIGHT:
                            AssignImage(customImage);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.SIXTYFOUR:
                            AssignImage(customImage);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(customImage);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case InputBoxIcon.OK:
                    switch (imageSize)
                    {
                        case InputBoxIconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Ok_32_x_32);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Ok_48_x_48);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Ok_64_x_64);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Ok_128_x_128);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case InputBoxIcon.ERROR:
                    switch (imageSize)
                    {
                        case InputBoxIconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Critical_32_x_32);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Critical_48_x_48);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Critical_64_x_64);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Critical_128_x_128);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case InputBoxIcon.EXCLAMATION:
                    switch (imageSize)
                    {
                        case InputBoxIconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Warning_32_x_29);

                            AdaptInputBoxIconContainerSize(InputBoxIconImageSize.CUSTOM, GetImageWidth(InputBoxResources.Input_Box_Warning_32_x_29), GetImageHeight(InputBoxResources.Input_Box_Warning_32_x_29));
                            break;
                        case InputBoxIconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Warning_48_x_43);

                            AdaptInputBoxIconContainerSize(InputBoxIconImageSize.CUSTOM, GetImageWidth(InputBoxResources.Input_Box_Warning_48_x_43), GetImageHeight(InputBoxResources.Input_Box_Warning_48_x_43));
                            break;
                        case InputBoxIconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Warning_64_x_58);

                            AdaptInputBoxIconContainerSize(InputBoxIconImageSize.CUSTOM, GetImageWidth(InputBoxResources.Input_Box_Warning_64_x_58), GetImageHeight(InputBoxResources.Input_Box_Warning_64_x_58));
                            break;
                        case InputBoxIconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Warning_128_x_115);

                            AdaptInputBoxIconContainerSize(InputBoxIconImageSize.CUSTOM, GetImageWidth(InputBoxResources.Input_Box_Warning_128_x_115), GetImageHeight(InputBoxResources.Input_Box_Warning_128_x_115));
                            break;
                    }
                    break;
                case InputBoxIcon.INFORMATION:
                    switch (imageSize)
                    {
                        case InputBoxIconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Information_32_x_32);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Information_48_x_48);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Information_64_x_64);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Information_128_x_128);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case InputBoxIcon.QUESTION:
                    switch (imageSize)
                    {
                        case InputBoxIconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Question_32_x_32);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Question_48_x_48);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Question_64_x_64);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Question_128_x_128);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case InputBoxIcon.STOP:
                    switch (imageSize)
                    {
                        case InputBoxIconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Stop_32_x_32);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Stop_48_x_48);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Stop_64_x_64);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Stop_128_x_128);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case InputBoxIcon.HAND:
                    switch (imageSize)
                    {
                        case InputBoxIconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Hand_32_x_32);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Hand_48_x_48);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Hand_64_x_64);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                        case InputBoxIconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Hand_128_x_128);

                            AdaptInputBoxIconContainerSize(imageSize);
                            break;
                    }
                    break;
            }
        }

        private void AssignImage(Image customImage) => pbxIcon.Image = customImage;

        private void AdaptInputBoxIconContainerSize(InputBoxIconImageSize imageSize, int width = 0, int height = 0)
        {
            switch (imageSize)
            {
                case InputBoxIconImageSize.CUSTOM:
                    pbxIcon.Size = new Size(width, height);
                    break;
                case InputBoxIconImageSize.THIRTYTWO:
                    pbxIcon.Size = new Size(32, 32);
                    break;
                case InputBoxIconImageSize.FOURTYEIGHT:
                    pbxIcon.Size = new Size(48, 48);
                    break;
                case InputBoxIconImageSize.SIXTYFOUR:
                    pbxIcon.Size = new Size(64, 64);
                    break;
                case InputBoxIconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                    pbxIcon.Size = new Size(128, 128);
                    break;
            }
        }
        #endregion

        #region Event Handlers
        private void kbtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void kbtnAbort_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void kbtnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void KryptonInputBoxExtended_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = _userResponse;
        }

        private void ktxtUserResponse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }
        #endregion
    }
}