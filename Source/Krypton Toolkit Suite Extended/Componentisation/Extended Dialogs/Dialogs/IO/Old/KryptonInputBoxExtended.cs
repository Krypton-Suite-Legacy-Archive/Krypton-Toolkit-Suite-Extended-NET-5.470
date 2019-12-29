#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedDialogs.Miscellaneous;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedDialogs.Dialogs.IO.Old
{
    public class KryptonInputBoxExtended : KryptonForm
    {
        #region Old Code

        /*
        #region Variables
        private static KryptonForm _owner = new KryptonForm();

        public static string _resultValue;

        private static DialogResult _dialogResult;

        private static string[] _buttonTextArray = new string[4];
        #endregion

        #region Enumerations
        public enum Icon
        {
            ERROR,
            EXCLAMATION,
            INFORMATION,
            QUESTION,
            NOTHING
        }

        public enum Type
        {
            COMBOBOX,
            TEXTBOX,
            NOTHING
        }

        public enum Buttons
        {
            OK,
            OKCANCEL,
            YESNO,
            YESNOCANCEL
        }

        public enum Language
        {
            CZECH,
            ENGLISH,
            FRENCH,
            GERMAN,
            SLOVAKIAN,
            SPANISH
        }
        #endregion

        #region Methods
        public static DialogResult ShowDialog(string Message, string Title = "", Icon icon = Icon.INFORMATION, Buttons buttons = Buttons.OK, Type type = Type.NOTHING, string[] ListItems = null, bool ShowInTaskBar = false, Font FormFont = null)
        {
            #region Setup
            _owner.Controls.Clear();

            _resultValue = "";

            _owner.MinimizeBox = false;

            _owner.MaximizeBox = false;

            _owner.FormBorderStyle = FormBorderStyle.FixedDialog;

            _owner.Size = new Size(350, 170);

            _owner.ShowIcon = false;

            _owner.ShowInTaskbar = ShowInTaskBar;

            _owner.FormClosing += Owner_FormClosing;

            _owner.StartPosition = FormStartPosition.CenterParent;

            KryptonPanel panelContent = new KryptonPanel();

            panelContent.Location = new Point(0, 0);

            panelContent.Size = new Size(340, 97);

            panelContent.Dock = DockStyle.Top;

            _owner.Controls.Add(panelContent);


            panelContent.Controls.Add(Picture(icon));

            KryptonLabel kryptonLabel = new KryptonLabel();

            kryptonLabel.Text = Message;

            kryptonLabel.Size = new Size(245, 60);

            kryptonLabel.Location = new Point(90, 10);

            kryptonLabel.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;

            kryptonLabel.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;

            panelContent.Dock = DockStyle.Fill;

            panelContent.Controls.Add(kryptonLabel);

            Panel pnlSplitter = new Panel();

            pnlSplitter.BackColor = SystemColors.ControlDarkDark;

            KryptonPanel panelButtons = new KryptonPanel();

            panelButtons.Size = new Size(350, 57);

            pnlSplitter.Size = new Size(300, 3);

            pnlSplitter.Dock = DockStyle.Bottom;

            _owner.Controls.Add(pnlSplitter);

            panelButtons.Dock = DockStyle.Bottom;

            _owner.Controls.Add(panelButtons);

            foreach (KryptonButton item in ButtonCollection(buttons))
            {
                panelButtons.Controls.Add(item);
            }

            Control ctrl = Controls(type, ListItems);

            panelContent.Controls.Add(ctrl);

            if (ctrl.Name == "textBox")
                _owner.ActiveControl = ctrl;

            //Set label font
            if (FormFont != null)
                kryptonLabel.StateCommon.ShortText.Font = FormFont;

            _owner.ShowDialog();

            //Return text value
            switch (type)
            {
                case Type.NOTHING:
                    break;
                default:
                    if (_dialogResult == DialogResult.OK || _dialogResult == DialogResult.Yes)
                    { _resultValue = ctrl.Text; }
                    else _resultValue = "";
                    break;
            }
            #endregion

            return _dialogResult;
        }

        private static Control Controls(Type type, string[] listItems)
        {
            KryptonComboBox comboBox = new KryptonComboBox();

            comboBox.Size = new Size(180, 22);

            comboBox.Location = new Point(90, 70);

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox.Name = "comboBox";

            if (listItems != null)
            {
                foreach (string item in listItems)
                {
                    comboBox.Items.Add(item);
                }

                comboBox.SelectedIndex = 0;
            }

            KryptonTextBox textBox = new KryptonTextBox();

            textBox.Size = new Size(180, 23);

            textBox.Location = new Point(90, 70);

            textBox.KeyDown += new KeyEventHandler(textBox_KeyDown);

            textBox.Name = "textBox";

            Control returnControl = new Control();

            switch (type)
            {
                case Type.COMBOBOX:
                    returnControl = comboBox;
                    break;
                case Type.TEXTBOX:
                    returnControl = textBox;
                    break;
            }

            return returnControl;
        }

        private static KryptonButton[] ButtonCollection(Buttons buttons)
        {
            KryptonButton[] returnChoices = new KryptonButton[3];

            KryptonButton kbtnOk = new KryptonButton(), kbtnCancel = new KryptonButton(), kbtnYes = new KryptonButton(), kbtnNo = new KryptonButton();

            kbtnOk.Text = _buttonTextArray[0];

            kbtnOk.Name = "kbtnOk";

            kbtnYes.Text = _buttonTextArray[1];

            kbtnYes.Name = "kbtnYes";

            kbtnNo.Text = _buttonTextArray[2];

            kbtnNo.Name = "kbtnNo";

            kbtnCancel.Text = _buttonTextArray[3];

            kbtnCancel.Name = "kbtnCancel";

            switch (buttons)
            {
                case Buttons.OK:
                    kbtnOk.Location = new Point(250, 101);

                    returnChoices[0] = kbtnOk;
                    break;

                case Buttons.OKCANCEL:
                    kbtnOk.Location = new Point(170, 101);

                    returnChoices[0] = kbtnOk;

                    kbtnCancel.Location = new Point(250, 101);

                    returnChoices[1] = kbtnCancel;
                    break;

                case Buttons.YESNO:
                    kbtnYes.Location = new Point(170, 101);

                    returnChoices[0] = kbtnYes;

                    kbtnNo.Location = new Point(250, 101);

                    returnChoices[1] = kbtnNo;
                    break;

                case Buttons.YESNOCANCEL:
                    kbtnYes.Location = new Point(90, 101);

                    returnChoices[0] = kbtnYes;

                    kbtnNo.Location = new Point(170, 101);

                    returnChoices[1] = kbtnNo;

                    kbtnCancel.Location = new Point(250, 101);

                    returnChoices[2] = kbtnCancel;
                    break;
            }

            foreach (KryptonButton button in returnChoices)
            {
                if (button != null)
                {
                    button.Size = new Size(75, 23);

                    button.Click += button_Click;
                }
            }

            return returnChoices;
        }

        private static PictureBox Picture(Icon icon)
        {
            PictureBox picture = new PictureBox();
            var assembly = Assembly.GetExecutingAssembly();     //Get integrated sources
            System.IO.Stream stream = null;

            //Set icon
            switch (icon)
            {
                case Icon.ERROR:
                    //stream = assembly.GetManifestResourceStream(@"MsgBox.error.png");

                    picture.Image = Resources.InputBoxError;
                    break;
                case Icon.EXCLAMATION:
                    //stream = assembly.GetManifestResourceStream(@"MsgBox.exclamation.png");

                    picture.Image = Resources.InputBoxExclamation;
                    break;
                case Icon.INFORMATION:
                    //stream = assembly.GetManifestResourceStream(@"MsgBox.information.png");

                    picture.Image = Resources.InputBoxInformation;
                    break;
                case Icon.QUESTION:
                    //stream = assembly.GetManifestResourceStream(@"MsgBox.question.png");

                    picture.Image = Resources.InputBoxQuestion;
                    break;
                case Icon.NOTHING:
                    //stream = assembly.GetManifestResourceStream(@"MsgBox.nic80x80.png");

                    picture.Image = Resources.nic80x80;
                    break;
            }
            picture.Image = System.Drawing.Image.FromStream(stream);
            picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picture.Size = new System.Drawing.Size(60, 60);
            picture.Location = new System.Drawing.Point(10, 10);
            return picture;
        }

        private static void button_Click(object sender, EventArgs e)
        {
            KryptonButton button = (KryptonButton)sender;

            switch (button.Name)
            {
                case "kbtnYes":
                    _dialogResult = DialogResult.Yes;
                    break;
                case "kbtnNo":
                    _dialogResult = DialogResult.No;
                    break;
                case "kbtnCancel":
                    _dialogResult = DialogResult.Cancel;
                    break;
                default:
                    _dialogResult = DialogResult.OK;
                    break;
            }

            _owner.Close();
        }

        private static void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _dialogResult = DialogResult.OK;
                _owner.Close();
            }
        }

        private static void Owner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dialogResult != null)
            {

            }
            else
            {
                _dialogResult = DialogResult.None;
            }
        }

        public static void SetLanguage(Language lang)
        {
            switch (lang)
            {
                case Language.CZECH:
                    _buttonTextArray = "OK,Ano,Ne,Storno".Split(',');
                    break;
                case Language.FRENCH:
                    _buttonTextArray = "OK,Oui,Non,Annuler".Split(',');
                    break;
                case Language.GERMAN:
                    _buttonTextArray = "OK,Ja,Nein,Stornieren".Split(',');
                    break;
                case Language.SLOVAKIAN:
                    _buttonTextArray = "OK,Áno,Nie,Zrušiť".Split(',');
                    break;
                case Language.SPANISH:
                    _buttonTextArray = "OK,Sí,No,Cancelar".Split(',');
                    break;
                default:
                    _buttonTextArray = "OK,Yes,No,Cancel".Split(',');
                    break;
            }
        }
        #endregion
    */

        #endregion

        #region Designer Code
        private KryptonPanel kpnlButtons;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private System.Windows.Forms.PictureBox pbxIcon;
        private KryptonTextBox ktxtInput;
        private KryptonComboBox kcmbChoices;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnOk;
        private KryptonButton kbtnYes;
        private KryptonButton kbtnNo;
        private KryptonLabel klblMessage;

        private void InitializeComponent()
        {
            this.kpnlButtons = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnYes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnNo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.ktxtInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kcmbChoices = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.klblMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).BeginInit();
            this.kpnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbChoices)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlButtons
            // 
            this.kpnlButtons.Controls.Add(this.kbtnCancel);
            this.kpnlButtons.Controls.Add(this.kbtnOk);
            this.kpnlButtons.Controls.Add(this.kbtnYes);
            this.kpnlButtons.Controls.Add(this.kbtnNo);
            this.kpnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlButtons.Location = new System.Drawing.Point(0, 161);
            this.kpnlButtons.Name = "kpnlButtons";
            this.kpnlButtons.Size = new System.Drawing.Size(523, 51);
            this.kpnlButtons.TabIndex = 5;
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(422, 13);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(89, 26);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kbtnCancel.TabIndex = 3;
            this.kbtnCancel.Values.Text = "C&ancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.Location = new System.Drawing.Point(232, 13);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(89, 26);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kbtnOk.TabIndex = 2;
            this.kbtnOk.Values.Text = "&Ok";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // kbtnYes
            // 
            this.kbtnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnYes.AutoSize = true;
            this.kbtnYes.Location = new System.Drawing.Point(327, 13);
            this.kbtnYes.Name = "kbtnYes";
            this.kbtnYes.Size = new System.Drawing.Size(89, 26);
            this.kbtnYes.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kbtnYes.TabIndex = 1;
            this.kbtnYes.Values.Text = "&Yes";
            this.kbtnYes.Click += new System.EventHandler(this.kbtnYes_Click);
            // 
            // kbtnNo
            // 
            this.kbtnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnNo.AutoSize = true;
            this.kbtnNo.Location = new System.Drawing.Point(327, 13);
            this.kbtnNo.Name = "kbtnNo";
            this.kbtnNo.Size = new System.Drawing.Size(89, 26);
            this.kbtnNo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kbtnNo.TabIndex = 0;
            this.kbtnNo.Values.Text = "&No";
            this.kbtnNo.Click += new System.EventHandler(this.kbtnNo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 3);
            this.panel1.TabIndex = 7;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.pbxIcon);
            this.kryptonPanel2.Controls.Add(this.ktxtInput);
            this.kryptonPanel2.Controls.Add(this.kcmbChoices);
            this.kryptonPanel2.Controls.Add(this.klblMessage);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(523, 158);
            this.kryptonPanel2.TabIndex = 8;
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Location = new System.Drawing.Point(13, 13);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(64, 64);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxIcon.TabIndex = 3;
            this.pbxIcon.TabStop = false;
            // 
            // ktxtInput
            // 
            this.ktxtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ktxtInput.Location = new System.Drawing.Point(200, 111);
            this.ktxtInput.Name = "ktxtInput";
            this.ktxtInput.Size = new System.Drawing.Size(200, 25);
            this.ktxtInput.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtInput.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtInput.TabIndex = 2;
            this.ktxtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ktxtInput_KeyDown);
            // 
            // kcmbChoices
            // 
            this.kcmbChoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kcmbChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbChoices.DropDownWidth = 121;
            this.kcmbChoices.IntegralHeight = false;
            this.kcmbChoices.Location = new System.Drawing.Point(200, 113);
            this.kcmbChoices.Name = "kcmbChoices";
            this.kcmbChoices.Size = new System.Drawing.Size(200, 23);
            this.kcmbChoices.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kcmbChoices.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbChoices.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kcmbChoices.TabIndex = 1;
            // 
            // klblMessage
            // 
            this.klblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.klblMessage.AutoSize = false;
            this.klblMessage.Location = new System.Drawing.Point(83, 12);
            this.klblMessage.Name = "klblMessage";
            this.klblMessage.Size = new System.Drawing.Size(428, 93);
            this.klblMessage.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMessage.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblMessage.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblMessage.TabIndex = 0;
            this.klblMessage.Values.Text = "kryptonLabel1";
            // 
            // KryptonInputBoxExtendedOld
            // 
            this.ClientSize = new System.Drawing.Size(523, 212);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kpnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonInputBoxExtendedOld";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KryptonInputBoxExtended_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).EndInit();
            this.kpnlButtons.ResumeLayout(false);
            this.kpnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbChoices)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private static DialogResult _userResponse;

        private static string[] _buttonTextArray = new string[4];
        #endregion

        #region Enumerations
        public enum Icon
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

        public enum IconImageSize
        {
            CUSTOM,
            THIRTYTWO,
            FOURTYEIGHT,
            SIXTYFOUR,
            ONEHUNDREDANDTWENTYEIGHT
        }

        public enum Type
        {
            COMBOBOX,
            TEXTBOX,
            MASKEDTEXTBOX,
            NOTHING
        }

        public enum Buttons
        {
            OK,
            OKCANCEL,
            YESNO,
            YESNOCANCEL
        }

        public enum Language
        {
            CZECH,
            ENGLISH,
            FRENCH,
            GERMAN,
            SLOVAKIAN,
            SPANISH,
            CUSTOM
        }

        public enum TextAlignment
        {
            LEFT,
            CENTRE,
            RIGHT
        }
        #endregion

        #region Properties
        public static DialogResult UserResponse { get => _userResponse; set => _userResponse = value; }
        #endregion

        #region Constructors        
        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonInputBoxExtended"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="title">The title.</param>
        /// <param name="language">The language.</param>
        /// <param name="type">The type.</param>
        /// <param name="listItems">The list items.</param>
        /// <param name="showInTaskBar">if set to <c>true</c> [show in task bar].</param>
        /// <param name="controlTypeface">The form font.</param>
        /// <param name="messageTypeface">The header typeface.</param>
        /// <param name="okText">The ok text.</param>
        /// <param name="yesText">The yes text.</param>
        /// <param name="noText">The no text.</param>
        /// <param name="cancelText">The cancel text.</param>
        /// <param name="hintText">The hint text.</param>
        public KryptonInputBoxExtended(string message, string title = "", Language language = Language.ENGLISH, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "")
        {
            InitializeComponent();

            Text = title;

            AdaptIcon(Icon.NONE, IconImageSize.THIRTYTWO);

            SetMessage(message);

            SetLanguage(language, okText, yesText, noText, cancelText);

            AdaptButtons(Buttons.OK, language);

            ChangeButtonVisibility(Buttons.OK);

            AdaptUI(type, listItems);

            ShowInTaskbar = showInTaskBar;

            SetControlTypeface(controlTypeface);

            SetHint(hintText);

            SetMessageTypeface(messageTypeface);

            AdaptContentLayout(Icon.NONE, type);
        }

        /// <summary>Initializes a new instance of the <see cref="KryptonInputBoxExtended"/> class.</summary>
        /// <param name="message">The message.</param>
        /// <param name="title">The title.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="image">The image.</param>
        /// <param name="language">The language.</param>
        /// <param name="type">The type.</param>
        /// <param name="listItems">The list items.</param>
        /// <param name="showInTaskBar">if set to <c>true</c> [show in task bar].</param>
        /// <param name="formFont">The form font.</param>
        /// <param name="headerTypeface">The header typeface.</param>
        /// <param name="okText">The ok text.</param>
        /// <param name="yesText">The yes text.</param>
        /// <param name="noText">The no text.</param>
        /// <param name="cancelText">The cancel text.</param>
        /// <param name="hintText">The hint text.</param>
        public KryptonInputBoxExtended(string message, string title = "", IconImageSize imageSize = IconImageSize.ONEHUNDREDANDTWENTYEIGHT, Icon icon = Icon.NONE, Image image = null, Language language = Language.ENGLISH, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "")
        {
            InitializeComponent();

            Text = title;

            //AdaptIconContainerSize(imageSize, GetImageWidth(image), GetImageHeight(image));

            AdaptIcon(icon, imageSize, image);

            SetMessage(message);

            SetLanguage(language, okText, yesText, noText, cancelText);

            AdaptButtons(Buttons.OK, language);

            ChangeButtonVisibility(Buttons.OK);

            AdaptUI(type, listItems);

            ShowInTaskbar = showInTaskBar;

            SetControlTypeface(controlTypeface);

            SetHint(hintText);

            SetMessageTypeface(messageTypeface);

            AdaptContentLayout(icon, type);
        }

        public KryptonInputBoxExtended(string message, string title = "", IconImageSize imageSize = IconImageSize.ONEHUNDREDANDTWENTYEIGHT, Icon icon = Icon.INFORMATION, Image image = null, Language language = Language.ENGLISH, Buttons buttons = Buttons.OK, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "", TextAlignment textAlignment = TextAlignment.LEFT)
        {
            InitializeComponent();

            SetMessage(message);

            Text = title;

            //AdaptIconContainerSize(imageSize, GetImageWidth(image), GetImageHeight(image));

            AdaptIcon(icon, imageSize, image);

            SetLanguage(language, okText, yesText, noText, cancelText);

            AdaptButtons(buttons, language);

            ChangeButtonVisibility(buttons);

            AdaptUI(type, listItems);

            ShowInTaskbar = showInTaskBar;

            SetControlTypeface(controlTypeface);

            SetHint(hintText);

            SetMessageTypeface(messageTypeface);

            SetTextAlignment(textAlignment);

            AdaptContentLayout(icon, type);

            RelocateIcon(new Point(13, 13));
        }


        /// <summary>Initializes a new instance of the <see cref="KryptonInputBoxExtended"/> class.</summary>
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
        /// <param name="formFont">The form font.</param>
        /// <param name="headerTypeface">The header typeface.</param>
        /// <param name="okText">The ok text.</param>
        /// <param name="yesText">The yes text.</param>
        /// <param name="noText">The no text.</param>
        /// <param name="cancelText">The cancel text.</param>
        /// <param name="hintText">The hint text.</param>
        /// <param name="textAlignment">The text alignment.</param>
        public KryptonInputBoxExtended(Point iconLocation, string message, string title = "", IconImageSize imageSize = IconImageSize.ONEHUNDREDANDTWENTYEIGHT, Icon icon = Icon.INFORMATION, Image image = null, Language language = Language.ENGLISH, Buttons buttons = Buttons.OK, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "", TextAlignment textAlignment = TextAlignment.LEFT)
        {
            InitializeComponent();

            SetMessage(message);

            Text = title;

            //AdaptIconContainerSize(imageSize, GetImageWidth(image), GetImageHeight(image));

            AdaptIcon(icon, imageSize, image);

            SetLanguage(language, okText, yesText, noText, cancelText);

            AdaptButtons(buttons, language);

            ChangeButtonVisibility(buttons);

            AdaptUI(type, listItems);

            ShowInTaskbar = showInTaskBar;

            SetControlTypeface(controlTypeface);

            SetHint(hintText);

            SetMessageTypeface(messageTypeface);

            SetTextAlignment(textAlignment);

            AdaptContentLayout(icon, type);

            RelocateIcon(iconLocation);
        }
        #endregion

        #region Setters/Getters

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
        private void SetHint(string hintText) => ktxtInput.Hint = hintText;

        /// <summary>Sets the control typeface.</summary>
        /// <param name="typeface">The typeface.</param>
        private void SetControlTypeface(Font typeface)
        {
            kbtnCancel.StateCommon.Content.ShortText.Font = typeface;

            kbtnNo.StateCommon.Content.ShortText.Font = typeface;

            kbtnOk.StateCommon.Content.ShortText.Font = typeface;

            kbtnYes.StateCommon.Content.ShortText.Font = typeface;
        }

        /// <summary>
        /// Sets the language.
        /// </summary>
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
                case Language.FRENCH:
                    _buttonTextArray = "OK,Oui,Non,Annuler".Split(',');
                    break;
                case Language.GERMAN:
                    _buttonTextArray = "OK,Ja,Nein,Stornieren".Split(',');
                    break;
                case Language.SLOVAKIAN:
                    _buttonTextArray = "OK,Áno,Nie,Zrušiť".Split(',');
                    break;
                case Language.SPANISH:
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

        /// <summary>
        /// Handles the Click event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Button_Click(object sender, EventArgs e)
        {
            KryptonButton button = (KryptonButton)sender;

            switch (button.Name)
            {
                case "kbtnChoiceOne":
                    UserResponse = DialogResult.Yes;
                    break;
                case "kbtnChoiceTwo":
                    UserResponse = DialogResult.No;
                    break;
                case "kbtnChoiceThree":
                    UserResponse = DialogResult.Cancel;
                    break;
                default:
                    UserResponse = DialogResult.OK;
                    break;
            }
        }

        /// <summary>Adapts the icon.</summary>
        /// <param name="icon">The icon.</param>
        /// <param name="image">The image.</param>
        private void AdaptIcon(Icon icon, IconImageSize imageSize, Image image = null)
        {
            //switch (icon)
            //{
            //    case Icon.CUSTOM:
            //        if (image != null)
            //        {
            //            pbxIcon.Image = image;
            //        }
            //        break;
            //    case Icon.OK:
            //        break;
            //    case Icon.ERROR:
            //        pbxIcon.Image = Resources.Critical_128_x_128;
            //        break;
            //    case Icon.EXCLAMATION:
            //        pbxIcon.Image = Resources.Warning_128_x_128;
            //        break;
            //    case Icon.INFORMATION:
            //        pbxIcon.Image = Resources.Information_128_x_128;
            //        break;
            //    case Icon.QUESTION:
            //        pbxIcon.Image = Resources.Question_128_x_128;
            //        break;
            //    case Icon.NOTHING:
            //        pbxIcon.Image = null;
            //        break;
            //    case Icon.STOP:
            //        break;
            //    case Icon.HAND:
            //        break;
            //}

            if (icon == Icon.CUSTOM)
            {
                AdaptIconSize(icon, imageSize, image);
            }
            else
            {
                AdaptIconSize(icon, imageSize);
            }
        }

        /// <summary>Adapts the size of the icon container.</summary>
        /// <param name="iconImageSize">Size of the icon image.</param>
        /// <param name="containerWidth">Width of the container.</param>
        /// <param name="containerHeight">Height of the container.</param>
        private void AdaptIconContainerSize(IconImageSize iconImageSize, int containerWidth = 0, int containerHeight = 0)
        {
            switch (iconImageSize)
            {
                case IconImageSize.CUSTOM:
                    pbxIcon.Size = new Size(containerWidth, containerHeight);
                    break;
                case IconImageSize.THIRTYTWO:
                    pbxIcon.Size = new Size(32, 32);
                    break;
                case IconImageSize.FOURTYEIGHT:
                    pbxIcon.Size = new Size(48, 48);
                    break;
                case IconImageSize.SIXTYFOUR:
                    pbxIcon.Size = new Size(64, 64);
                    break;
                case IconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                    pbxIcon.Size = new Size(128, 128);
                    break;
            }
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
        /// <param name="language">The language.</param>
        /// <returns></returns>
        private KryptonButton[] AdaptButtons(Buttons buttons, Language language)
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
                case Buttons.OK:
                    kbtnOk.Location = new Point(552, 6);

                    buttonArray[0] = kbtnOk;
                    break;
                case Buttons.OKCANCEL:
                    kbtnOk.Location = new Point(423, 6);

                    buttonArray[0] = kbtnOk;

                    kbtnCancel.Location = new Point(552, 6);

                    buttonArray[1] = kbtnCancel;
                    break;
                case Buttons.YESNO:
                    kbtnYes.Location = new Point(423, 6);

                    buttonArray[0] = kbtnYes;

                    kbtnNo.Location = new Point(552, 6);

                    buttonArray[1] = kbtnNo;
                    break;
                case Buttons.YESNOCANCEL:
                    kbtnYes.Location = new Point(294, 6);

                    buttonArray[0] = kbtnYes;

                    kbtnNo.Location = new Point(423, 6);

                    buttonArray[1] = kbtnNo;

                    kbtnCancel.Location = new Point(552, 6);

                    buttonArray[2] = kbtnCancel;
                    break;
                default:
                    break;
            }

            foreach (KryptonButton button in buttonArray)
            {
                if (button != null)
                {
                    button.Size = new Size(123, 39);

                    button.Click += Button_Click;
                }
            }

            return buttonArray;
        }

        /// <summary>
        /// Adapts the UI.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="items">The items.</param>
        private void AdaptUI(Type type, string[] items)
        {
            if (items != null)
            {
                foreach (string item in items)
                {
                    kcmbChoices.Items.Add(item);
                }

                kcmbChoices.SelectedIndex = 0;
            }

            switch (type)
            {
                case Type.COMBOBOX:
                    ktxtInput.Visible = false;

                    kcmbChoices.Visible = true;
                    break;
                case Type.TEXTBOX:
                    ktxtInput.Visible = true;

                    kcmbChoices.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Sets the button text.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="okText">The ok text.</param>
        /// <param name="yesText">The yes text.</param>
        /// <param name="noText">The no text.</param>
        /// <param name="cancelText">The cancel text.</param>
        public void SetButtonText(Language language, Buttons buttons, string okText = "", string yesText = "", string noText = "", string cancelText = "")
        {
            string[] buttonTextArray = new string[3];

            switch (language)
            {
                case Language.CZECH:
                    buttonTextArray = "OK,Ano,Ne,Storno".Split(',');
                    break;
                case Language.FRENCH:
                    buttonTextArray = "OK,Oui,Non,Annuler".Split(',');
                    break;
                case Language.GERMAN:
                    buttonTextArray = "OK,Ja,Nein,Stornieren".Split(',');
                    break;
                case Language.SLOVAKIAN:
                    buttonTextArray = "OK,Áno,Nie,Zrušiť".Split(',');
                    break;
                case Language.SPANISH:
                    buttonTextArray = "OK,Sí,No,Cancelar".Split(',');
                    break;
                case Language.CUSTOM:
                    buttonTextArray = SetCustomText(okText, yesText, noText, cancelText);
                    break;
                default:
                    buttonTextArray = "OK,Yes,No,Cancel".Split(',');
                    break;
            }

            kbtnOk.Text = buttonTextArray[0];

            kbtnYes.Text = buttonTextArray[1];

            kbtnNo.Text = buttonTextArray[2];

            kbtnCancel.Text = buttonTextArray[3];

            AdjustButtonPositions(buttons);
        }

        /// <summary>
        /// Adjusts the button positions.
        /// </summary>
        /// <param name="buttons">The buttons.</param>
        private void AdjustButtonPositions(Buttons buttons)
        {
            ChangeButtonVisibility(buttons);

            switch (buttons)
            {
                case Buttons.OK:
                    kbtnOk.Location = new Point(552, 6);
                    break;
                case Buttons.OKCANCEL:
                    kbtnOk.Location = new Point(423, 6);

                    kbtnCancel.Location = new Point(552, 6);
                    break;
                case Buttons.YESNO:
                    kbtnYes.Location = new Point(423, 6);

                    kbtnNo.Location = new Point(552, 6);
                    break;
                case Buttons.YESNOCANCEL:
                    kbtnYes.Location = new Point(294, 6);

                    kbtnNo.Location = new Point(423, 6);

                    kbtnCancel.Location = new Point(552, 6);
                    break;
            }
        }

        /// <summary>
        /// Changes the button visibility.
        /// </summary>
        /// <param name="buttons">The buttons.</param>
        private void ChangeButtonVisibility(Buttons buttons)
        {
            switch (buttons)
            {
                case Buttons.OK:
                    kbtnOk.Visible = true;

                    kbtnCancel.Visible = false;

                    kbtnNo.Visible = false;

                    kbtnYes.Visible = false;
                    break;
                case Buttons.OKCANCEL:
                    kbtnOk.Visible = true;

                    kbtnCancel.Visible = true;

                    kbtnNo.Visible = false;

                    kbtnYes.Visible = false;
                    break;
                case Buttons.YESNO:
                    kbtnOk.Visible = false;

                    kbtnCancel.Visible = false;

                    kbtnNo.Visible = true;

                    kbtnYes.Visible = true;
                    break;
                case Buttons.YESNOCANCEL:
                    kbtnOk.Visible = false;

                    kbtnCancel.Visible = true;

                    kbtnNo.Visible = true;

                    kbtnYes.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Sets the text alignment.
        /// </summary>
        /// <param name="textAlignment">The text alignment.</param>
        private void SetTextAlignment(TextAlignment textAlignment)
        {
            switch (textAlignment)
            {
                case TextAlignment.LEFT:
                    ktxtInput.TextAlign = HorizontalAlignment.Left;
                    break;
                case TextAlignment.CENTRE:
                    ktxtInput.TextAlign = HorizontalAlignment.Center;
                    break;
                case TextAlignment.RIGHT:
                    ktxtInput.TextAlign = HorizontalAlignment.Right;
                    break;
            }
        }

        /// <summary>
        /// Gets the user response.
        /// </summary>
        /// <returns></returns>
        public string GetUserResponse() => ktxtInput.Text;

        /// <summary>
        /// Gets the user choice.
        /// </summary>
        /// <returns></returns>
        public string GetUserChoice() => kcmbChoices.Text;

        /// <summary>
        /// Adapts the content layout.
        /// </summary>
        /// <param name="icon">The icon.</param>
        /// <param name="type">The type.</param>
        private void AdaptContentLayout(Icon icon, Type type)
        {
            if (icon == Icon.NONE)
            {
                pbxIcon.Visible = false;

                klblMessage.Size = new Size(663, 128);

                if (type == Type.COMBOBOX)
                {
                    kcmbChoices.Location = new Point(189, 145);
                }
                else if (type == Type.TEXTBOX)
                {
                    ktxtInput.Location = new Point(189, 145);
                }
            }
            else
            {
                pbxIcon.Visible = true;

                klblMessage.Size = new Size(528, 128);

                if (type == Type.COMBOBOX)
                {
                    kcmbChoices.Location = new Point(264, 145);
                }
                else if (type == Type.TEXTBOX)
                {
                    ktxtInput.Location = new Point(264, 145);
                }
            }
        }

        /// <summary>Adapts the size of the icon. (A little bit messy, but does the job!)</summary>
        /// <param name="icon">The icon.</param>
        /// <param name="imageSize">Size of the image.</param>
        /// <param name="customImage">The custom image.</param>
        private void AdaptIconSize(Icon icon, IconImageSize imageSize, Image customImage = null)
        {
            switch (icon)
            {
                case Icon.CUSTOM:
                    switch (imageSize)
                    {
                        case IconImageSize.CUSTOM:
                            AssignImage(customImage);

                            AdaptIconContainerSize(IconImageSize.CUSTOM, GetImageWidth(customImage), GetImageHeight(customImage));
                            break;
                        case IconImageSize.THIRTYTWO:
                            AssignImage(customImage);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.FOURTYEIGHT:
                            AssignImage(customImage);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.SIXTYFOUR:
                            AssignImage(customImage);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(customImage);

                            AdaptIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case Icon.OK:
                    switch (imageSize)
                    {
                        case IconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Ok_32_x_32);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Ok_48_x_48);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Ok_64_x_64);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Ok_128_x_128);

                            AdaptIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case Icon.ERROR:
                    switch (imageSize)
                    {
                        case IconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Critical_32_x_32);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Critical_48_x_48);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Critical_64_x_64);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Critical_128_x_128);

                            AdaptIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case Icon.EXCLAMATION:
                    switch (imageSize)
                    {
                        case IconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Warning_32_x_29);

                            AdaptIconContainerSize(IconImageSize.CUSTOM, GetImageWidth(InputBoxResources.Input_Box_Warning_32_x_29), GetImageHeight(InputBoxResources.Input_Box_Warning_32_x_29));
                            break;
                        case IconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Warning_48_x_43);

                            AdaptIconContainerSize(IconImageSize.CUSTOM, GetImageWidth(InputBoxResources.Input_Box_Warning_48_x_43), GetImageHeight(InputBoxResources.Input_Box_Warning_48_x_43));
                            break;
                        case IconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Warning_64_x_58);

                            AdaptIconContainerSize(IconImageSize.CUSTOM, GetImageWidth(InputBoxResources.Input_Box_Warning_64_x_58), GetImageHeight(InputBoxResources.Input_Box_Warning_64_x_58));
                            break;
                        case IconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Warning_128_x_115);

                            AdaptIconContainerSize(IconImageSize.CUSTOM, GetImageWidth(InputBoxResources.Input_Box_Warning_128_x_115), GetImageHeight(InputBoxResources.Input_Box_Warning_128_x_115));
                            break;
                    }
                    break;
                case Icon.INFORMATION:
                    switch (imageSize)
                    {
                        case IconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Information_32_x_32);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Information_48_x_48);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Information_64_x_64);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Information_128_x_128);

                            AdaptIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case Icon.QUESTION:
                    switch (imageSize)
                    {
                        case IconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Question_32_x_32);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Question_48_x_48);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Question_64_x_64);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Question_128_x_128);

                            AdaptIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case Icon.STOP:
                    switch (imageSize)
                    {
                        case IconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Stop_32_x_32);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Stop_48_x_48);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Stop_64_x_64);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Stop_128_x_128);

                            AdaptIconContainerSize(imageSize);
                            break;
                    }
                    break;
                case Icon.HAND:
                    switch (imageSize)
                    {
                        case IconImageSize.THIRTYTWO:
                            AssignImage(InputBoxResources.Input_Box_Hand_32_x_32);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.FOURTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Hand_48_x_48);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.SIXTYFOUR:
                            AssignImage(InputBoxResources.Input_Box_Hand_64_x_64);

                            AdaptIconContainerSize(imageSize);
                            break;
                        case IconImageSize.ONEHUNDREDANDTWENTYEIGHT:
                            AssignImage(InputBoxResources.Input_Box_Hand_128_x_128);

                            AdaptIconContainerSize(imageSize);
                            break;
                    }
                    break;
            }
        }

        private void AssignImage(Image image) => pbxIcon.Image = image;

        private void RelocateIcon(Point newPoint) => pbxIcon.Location = newPoint;

        private void StoreDefaultValues()
        {
            Size = new Size(707, 301);

            pbxIcon.Location = new Point(13, 13);

            pbxIcon.Size = new Size(128, 128);

            klblMessage.Location = new Point(147, 13);

            klblMessage.Size = new Size(528, 128);

            ktxtInput.Location = new Point(264, 145);

            ktxtInput.Size = new Size(313, 29);

            kcmbChoices.Location = new Point(264, 145);

            kcmbChoices.Size = new Size(313, 29);

            kbtnCancel.Location = new Point(552, 6);

            kbtnCancel.Size = new Size(123, 39);

            kbtnOk.Location = new Point(423, 6);

            kbtnOk.Size = new Size(123, 39);

            kbtnYes.Location = new Point(294, 6);

            kbtnYes.Size = new Size(123, 39);

            kbtnNo.Location = new Point(423, 6);

            kbtnNo.Size = new Size(123, 39);

            kpnlButtons.Size = new Size(687, 57);

            SetMessageTypeface(new Font("Segoe UI", 14f, FontStyle.Bold));

            SetControlTypeface(new Font("Segoe UI", 12f));
        }
        #endregion

        private void ktxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserResponse = DialogResult.OK;

                Close();
            }
        }

        private void KryptonInputBoxExtended_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserResponse != null)
            {

            }
            else
            {
                UserResponse = DialogResult.None;
            }
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void kbtnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void kbtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}