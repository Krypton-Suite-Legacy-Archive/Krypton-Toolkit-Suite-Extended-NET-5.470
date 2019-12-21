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

namespace ExtendedDialogs.Dialogs.IO
{
    public class KryptonInputBoxExtended : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kpnlContent;
        private KryptonPanel kpnlButtons;
        private KryptonLabel klblMessage;
        private System.Windows.Forms.PictureBox pbxInfoboxIcon;
        private KryptonComboBox kcmbUserSelection;
        private KryptonTextBox ktxtUserInput;
        private KryptonButton kbtnNo;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnYes;
        private KryptonButton kbtnOk;
        private KryptonMaskedTextBox kmtxtUserInput;
        private KryptonWrapLabel kwlMessage;
        private System.Windows.Forms.Panel pnlSplitter;

        private void InitializeComponent()
        {
            this.kpnlContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ktxtUserInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kmtxtUserInput = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.kcmbUserSelection = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.klblMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kwlMessage = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.pbxInfoboxIcon = new System.Windows.Forms.PictureBox();
            this.kpnlButtons = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnYes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnNo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).BeginInit();
            this.kpnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbUserSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfoboxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).BeginInit();
            this.kpnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlContent
            // 
            this.kpnlContent.Controls.Add(this.ktxtUserInput);
            this.kpnlContent.Controls.Add(this.kmtxtUserInput);
            this.kpnlContent.Controls.Add(this.kcmbUserSelection);
            this.kpnlContent.Controls.Add(this.klblMessage);
            this.kpnlContent.Controls.Add(this.kwlMessage);
            this.kpnlContent.Controls.Add(this.pbxInfoboxIcon);
            this.kpnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlContent.Location = new System.Drawing.Point(0, 0);
            this.kpnlContent.Name = "kpnlContent";
            this.kpnlContent.Size = new System.Drawing.Size(584, 292);
            this.kpnlContent.TabIndex = 0;
            // 
            // ktxtUserInput
            // 
            this.ktxtUserInput.Location = new System.Drawing.Point(213, 192);
            this.ktxtUserInput.Name = "ktxtUserInput";
            this.ktxtUserInput.Size = new System.Drawing.Size(241, 27);
            this.ktxtUserInput.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtUserInput.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtUserInput.TabIndex = 2;
            this.ktxtUserInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ktxtUserInput_KeyDown);
            // 
            // kmtxtUserInput
            // 
            this.kmtxtUserInput.Location = new System.Drawing.Point(213, 191);
            this.kmtxtUserInput.Name = "kmtxtUserInput";
            this.kmtxtUserInput.Size = new System.Drawing.Size(241, 27);
            this.kmtxtUserInput.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmtxtUserInput.StateActive.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kmtxtUserInput.TabIndex = 2;
            // 
            // kcmbUserSelection
            // 
            this.kcmbUserSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbUserSelection.DropDownWidth = 241;
            this.kcmbUserSelection.IntegralHeight = false;
            this.kcmbUserSelection.Location = new System.Drawing.Point(213, 194);
            this.kcmbUserSelection.Name = "kcmbUserSelection";
            this.kcmbUserSelection.Size = new System.Drawing.Size(241, 25);
            this.kcmbUserSelection.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbUserSelection.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbUserSelection.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbUserSelection.TabIndex = 2;
            // 
            // klblMessage
            // 
            this.klblMessage.AutoSize = false;
            this.klblMessage.Location = new System.Drawing.Point(82, 13);
            this.klblMessage.Name = "klblMessage";
            this.klblMessage.Size = new System.Drawing.Size(490, 175);
            this.klblMessage.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMessage.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.klblMessage.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblMessage.TabIndex = 1;
            this.klblMessage.Values.Text = "kryptonLabel1";
            // 
            // kwlMessage
            // 
            this.kwlMessage.AutoSize = false;
            this.kwlMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kwlMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kwlMessage.Location = new System.Drawing.Point(82, 12);
            this.kwlMessage.Name = "kwlMessage";
            this.kwlMessage.Size = new System.Drawing.Size(490, 176);
            this.kwlMessage.StateCommon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kwlMessage.Text = "kryptonWrapLabel1";
            // 
            // pbxInfoboxIcon
            // 
            this.pbxInfoboxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxInfoboxIcon.Location = new System.Drawing.Point(12, 67);
            this.pbxInfoboxIcon.Name = "pbxInfoboxIcon";
            this.pbxInfoboxIcon.Size = new System.Drawing.Size(64, 64);
            this.pbxInfoboxIcon.TabIndex = 0;
            this.pbxInfoboxIcon.TabStop = false;
            // 
            // kpnlButtons
            // 
            this.kpnlButtons.Controls.Add(this.kbtnOk);
            this.kpnlButtons.Controls.Add(this.kbtnYes);
            this.kpnlButtons.Controls.Add(this.kbtnCancel);
            this.kpnlButtons.Controls.Add(this.kbtnNo);
            this.kpnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlButtons.Location = new System.Drawing.Point(0, 243);
            this.kpnlButtons.Name = "kpnlButtons";
            this.kpnlButtons.Size = new System.Drawing.Size(584, 49);
            this.kpnlButtons.TabIndex = 0;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.Location = new System.Drawing.Point(293, 9);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(89, 28);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 6;
            this.kbtnOk.Values.Text = "&Ok";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // kbtnYes
            // 
            this.kbtnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnYes.AutoSize = true;
            this.kbtnYes.Location = new System.Drawing.Point(388, 9);
            this.kbtnYes.Name = "kbtnYes";
            this.kbtnYes.Size = new System.Drawing.Size(89, 28);
            this.kbtnYes.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnYes.TabIndex = 5;
            this.kbtnYes.Values.Text = "&Yes";
            this.kbtnYes.Click += new System.EventHandler(this.kbtnYes_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(483, 9);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(89, 28);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 4;
            this.kbtnCancel.Values.Text = "C&ancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kbtnNo
            // 
            this.kbtnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnNo.AutoSize = true;
            this.kbtnNo.Location = new System.Drawing.Point(483, 9);
            this.kbtnNo.Name = "kbtnNo";
            this.kbtnNo.Size = new System.Drawing.Size(89, 28);
            this.kbtnNo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnNo.TabIndex = 1;
            this.kbtnNo.Values.Text = "&No";
            this.kbtnNo.Click += new System.EventHandler(this.kbtnNo_Click);
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 240);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(584, 3);
            this.pnlSplitter.TabIndex = 1;
            // 
            // KryptonInputBoxExtended
            // 
            this.ClientSize = new System.Drawing.Size(584, 292);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kpnlButtons);
            this.Controls.Add(this.kpnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonInputBoxExtended";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KryptonInputBoxExtended_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).EndInit();
            this.kpnlContent.ResumeLayout(false);
            this.kpnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbUserSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfoboxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).EndInit();
            this.kpnlButtons.ResumeLayout(false);
            this.kpnlButtons.PerformLayout();
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

        public enum MessageTextAlignment
        {
            INHERIT,
            NEARNEAR,
            NEARCENTRE,
            NEARFAR,
            CENTRENEAR,
            CENTRECENTRE,
            CENTREFAR,
            FARNEAR,
            FARCENTRE,
            FARFAR,
            INHERITNEAR,
            INHERITCENTRE,
            INHERITFAR,
            NEARINHERIT,
            CENTREINHERIT,
            FARINHERIT
        }

        public enum MessageDisplayType
        {
            LABEL,
            WRAPPEDLABEL
        }
        #endregion

        #region Properties
        public static DialogResult UserResponse { get => _userResponse; set => _userResponse = value; }
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="KryptonInputBoxExtended"/> class.</summary>
        /// <param name="message">The message.</param>
        /// <param name="title">The title.</param>
        /// <param name="language">The language.</param>
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
        public KryptonInputBoxExtended(string message, string title = "", Language language = Language.ENGLISH, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "")
        {
            InitializeComponent();

            SetMessage(message);

            SetTitle(title);

            SetIconType(Icon.NOTHING);

            SetLanguage(language, okText, yesText, noText, cancelText);

            AdaptButtons(Buttons.OK, language);

            ChangeButtonVisibility(Buttons.OK);

            AdaptUI(type, listItems);

            SetShowInTaskbar(showInTaskBar);

            SetControlTypeface(controlTypeface);

            SetMessageTypeface(messageTypeface);

            SetHint(hintText);
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
        /// <param name="controlTypeface">The control typeface.</param>
        /// <param name="messageTypeface">The message typeface.</param>
        /// <param name="okText">The ok text.</param>
        /// <param name="yesText">The yes text.</param>
        /// <param name="noText">The no text.</param>
        /// <param name="cancelText">The cancel text.</param>
        /// <param name="hintText">The hint text.</param>
        public KryptonInputBoxExtended(string message, string title = "", Icon icon = Icon.NONE, Image image = null, Language language = Language.ENGLISH, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "")
        {
            InitializeComponent();

            SetMessage(message);

            SetTitle(title);

            SetIconType(icon, image);

            SetLanguage(language, okText, yesText, noText, cancelText);

            AdaptButtons(Buttons.OK, language);

            ChangeButtonVisibility(Buttons.OK);

            AdaptUI(type, listItems);

            SetShowInTaskbar(showInTaskBar);

            SetControlTypeface(controlTypeface);

            SetMessageTypeface(messageTypeface);

            SetHint(hintText);
        }

        /// <summary>Initializes a new instance of the <see cref="KryptonInputBoxExtended"/> class.</summary>
        /// <param name="message">The message.</param>
        /// <param name="title">The title.</param>
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
        public KryptonInputBoxExtended(string message, string title = "", Icon icon = Icon.INFORMATION, Image image = null, Language language = Language.ENGLISH, Buttons buttons = Buttons.OK, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "")
        {
            InitializeComponent();

            SetMessage(message);

            SetTitle(title);

            SetIconType(icon, image);

            SetLanguage(language, okText, yesText, noText, cancelText);

            AdaptButtons(buttons, language);

            ChangeButtonVisibility(buttons);

            AdaptUI(type, listItems);

            SetShowInTaskbar(showInTaskBar);

            SetControlTypeface(controlTypeface);

            SetMessageTypeface(messageTypeface);

            SetHint(hintText);
        }

        /// <summary>Initializes a new instance of the <see cref="KryptonInputBoxExtended"/> class.</summary>
        /// <param name="message">The message.</param>
        /// <param name="title">The title.</param>
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
        /// <param name="startPosition">The start position.</param>
        public KryptonInputBoxExtended(string message, string title = "", Icon icon = Icon.INFORMATION, Image image = null, Language language = Language.ENGLISH, Buttons buttons = Buttons.OK, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "", FormStartPosition startPosition = FormStartPosition.WindowsDefaultLocation)
        {
            InitializeComponent();

            SetMessage(message);

            SetTitle(title);

            SetIconType(icon, image);

            SetLanguage(language, okText, yesText, noText, cancelText);

            AdaptButtons(buttons, language);

            ChangeButtonVisibility(buttons);

            AdaptUI(type, listItems);

            SetShowInTaskbar(showInTaskBar);

            SetControlTypeface(controlTypeface);

            SetMessageTypeface(messageTypeface);

            SetHint(hintText);

            SetStartPosition(startPosition);
        }

        /// <summary>Initializes a new instance of the <see cref="KryptonInputBoxExtended"/> class.</summary>
        /// <param name="message">The message.</param>
        /// <param name="title">The title.</param>
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
        /// <param name="textAlignment">The text alignment.</param>
        public KryptonInputBoxExtended(string message, string title = "", Icon icon = Icon.INFORMATION, Image image = null, Language language = Language.ENGLISH, Buttons buttons = Buttons.OK, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "", TextAlignment textAlignment = TextAlignment.LEFT)
        {
            InitializeComponent();

            SetMessage(message);

            SetTitle(title);

            SetIconType(icon, image);

            SetLanguage(language, okText, yesText, noText, cancelText);

            AdaptButtons(buttons, language);

            ChangeButtonVisibility(buttons);

            AdaptUI(type, listItems);

            SetShowInTaskbar(showInTaskBar);

            SetControlTypeface(controlTypeface);

            SetMessageTypeface(messageTypeface);

            SetHint(hintText);

            SetTextAlignment(textAlignment);
        }


        /// <summary>Initializes a new instance of the <see cref="KryptonInputBoxExtended"/> class.</summary>
        /// <param name="iconLocation">The icon location. (Please ensure that you set 12 as your default X coordinate.)</param>
        /// <param name="message">The message.</param>
        /// <param name="title">The title.</param>
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
        /// <param name="startPosition">The start position.</param>
        /// <param name="textAlignment">The text alignment.</param>
        public KryptonInputBoxExtended(Point iconLocation, string message, string title = "", Icon icon = Icon.INFORMATION, Image image = null, Language language = Language.ENGLISH, Buttons buttons = Buttons.OK, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "", FormStartPosition startPosition = FormStartPosition.WindowsDefaultLocation, TextAlignment textAlignment = TextAlignment.LEFT)
        {
            InitializeComponent();

            SetMessage(message);

            SetTitle(title);

            SetIconType(icon, image);

            SetLanguage(language, okText, yesText, noText, cancelText);

            AdaptButtons(buttons, language);

            ChangeButtonVisibility(buttons);

            AdaptUI(type, listItems);

            SetShowInTaskbar(showInTaskBar);

            SetControlTypeface(controlTypeface);

            SetMessageTypeface(messageTypeface);

            SetHint(hintText);

            RelocateIcon(iconLocation);

            SetTextAlignment(textAlignment);

            SetStartPosition(startPosition);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Sets the message.
        /// </summary>
        /// <param name="message">The message.</param>
        private void SetMessage(string message) => klblMessage.Text = message;

        /// <summary>Sets the title.</summary>
        /// <param name="title">The title.</param>
        private void SetTitle(string title) => Text = title;

        /// <summary>Sets the message typeface.</summary>
        /// <param name="typeface">The typeface.</param>
        private void SetMessageTypeface(Font typeface) => klblMessage.StateCommon.ShortText.Font = typeface;

        /// <summary>Sets the show in taskbar.</summary>
        /// <param name="showInTaskbar">if set to <c>true</c> [show in taskbar].</param>
        private void SetShowInTaskbar(bool showInTaskbar) => ShowInTaskbar = showInTaskbar;

        /// <summary>
        /// Sets the hint.
        /// </summary>
        /// <param name="hintText">The hint text.</param>
        private void SetHint(string hintText) => ktxtUserInput.Hint = hintText;

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

        /// <summary>Sets the type of the icon.</summary>
        /// <param name="icon">The icon.</param>
        /// <param name="image">The image.</param>
        /// <exception cref="ArgumentNullException"></exception>
        private void SetIconType(Icon icon, Image image = null)
        {
            switch (icon)
            {
                case Icon.CUSTOM:
                    if (image != null)
                    {
                        AdaptUI(true);

                        SetIconImage(image);
                    }
                    else
                    {
                        throw new ArgumentNullException();
                    }
                    break;
                case Icon.OK:
                    AdaptUI(true);

                    SetIconImage(InputBoxResources.Input_Box_Ok_64_x_64);
                    break;
                case Icon.ERROR:
                    AdaptUI(true);

                    SetIconImage(InputBoxResources.Input_Box_Critical_64_x_64);
                    break;
                case Icon.EXCLAMATION:
                    AdaptUI(true);

                    SetIconImage(InputBoxResources.Input_Box_Warning_64_x_58);
                    break;
                case Icon.INFORMATION:
                    AdaptUI(true);

                    SetIconImage(InputBoxResources.Input_Box_Information_64_x_64);
                    break;
                case Icon.QUESTION:
                    AdaptUI(true);

                    SetIconImage(InputBoxResources.Input_Box_Question_64_x_64);
                    break;
                case Icon.NOTHING:
                    AdaptUI(false);
                    break;
                case Icon.NONE:
                    AdaptUI(false);
                    break;
                case Icon.STOP:
                    AdaptUI(true);

                    SetIconImage(InputBoxResources.Input_Box_Stop_64_x_64);
                    break;
                case Icon.HAND:
                    AdaptUI(true);

                    SetIconImage(InputBoxResources.Input_Box_Hand_64_x_64);
                    break;
            }
        }

        /// <summary>Sets the icon image.</summary>
        /// <param name="image">The image.</param>
        private void SetIconImage(Image image) => pbxInfoboxIcon.Image = image;

        /// <summary>Adapts the buttons.</summary>
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
                    kbtnOk.Location = new Point(483, 9);

                    buttonArray[0] = kbtnOk;
                    break;
                case Buttons.OKCANCEL:
                    kbtnOk.Location = new Point(388, 9);

                    buttonArray[0] = kbtnOk;

                    kbtnCancel.Location = new Point(483, 9);

                    buttonArray[1] = kbtnCancel;
                    break;
                case Buttons.YESNO:
                    kbtnYes.Location = new Point(388, 9);

                    buttonArray[0] = kbtnYes;

                    kbtnNo.Location = new Point(483, 9);

                    buttonArray[1] = kbtnNo;
                    break;
                case Buttons.YESNOCANCEL:
                    kbtnYes.Location = new Point(293, 9);

                    buttonArray[0] = kbtnYes;

                    kbtnNo.Location = new Point(388, 9);

                    buttonArray[1] = kbtnNo;

                    kbtnCancel.Location = new Point(483, 9);

                    buttonArray[2] = kbtnCancel;
                    break;
                default:
                    break;
            }

            foreach (KryptonButton button in buttonArray)
            {
                if (button != null)
                {
                    button.Size = new Size(89, 28);

                    button.Click += Button_Click;
                }
            }

            return buttonArray;
        }

        /// <summary>Adapts the UI.</summary>
        /// <param name="showIconBox">if set to <c>true</c> [show icon box].</param>
        private void AdaptUI(bool showIconBox)
        {
            if (showIconBox)
            {
                pbxInfoboxIcon.Visible = true;

                ResizeControls(new Size(489, 175), new Point(213, 192), new Point(213, 192));
            }
            else
            {
                pbxInfoboxIcon.Visible = false;

                ResizeControls(new Size(560, 175), new Point(180, 192), new Point(180, 192));
            }
        }

        /// <summary>Adapts the UI.</summary>
        /// <param name="type">The type.</param>
        /// <param name="itemList">The item list.</param>
        private void AdaptUI(Type type, string[] itemList)
        {
            if (itemList != null)
            {
                foreach (string item in itemList)
                {
                    kcmbUserSelection.Items.Add(item);
                }

                kcmbUserSelection.SelectedIndex = 0;
            }

            switch (type)
            {
                case Type.COMBOBOX:
                    ktxtUserInput.Visible = false;

                    kmtxtUserInput.Visible = false;

                    kcmbUserSelection.Visible = true;
                    break;
                case Type.TEXTBOX:
                    ktxtUserInput.Visible = true;

                    kmtxtUserInput.Visible = false;

                    kcmbUserSelection.Visible = false;
                    break;
                case Type.MASKEDTEXTBOX:
                    ktxtUserInput.Visible = false;

                    kmtxtUserInput.Visible = true;

                    kcmbUserSelection.Visible = false;
                    break;
            }
        }

        /// <summary>Adapts the display type of the message.</summary>
        /// <param name="displayType">The display type.</param>
        private void AdaptMessageDisplayType(MessageDisplayType displayType)
        {
            switch (displayType)
            {
                case MessageDisplayType.LABEL:
                    klblMessage.Visible = true;

                    kwlMessage.Visible = false;
                    break;
                case MessageDisplayType.WRAPPEDLABEL:
                    klblMessage.Visible = false;

                    kwlMessage.Visible = true;
                    break;
            }
        }

        /// <summary>Resizes the controls.</summary>
        /// <param name="messageLabelSize">Size of the message label.</param>
        /// <param name="userSelectionLocation">The user selection location.</param>
        /// <param name="userInputLocation">The user input location.</param>
        private void ResizeControls(Size messageLabelSize, Point userSelectionLocation, Point userInputLocation)
        {
            klblMessage.Size = messageLabelSize;

            kcmbUserSelection.Location = userSelectionLocation;

            ktxtUserInput.Location = userInputLocation;
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
                    ktxtUserInput.TextAlign = HorizontalAlignment.Left;
                    break;
                case TextAlignment.CENTRE:
                    ktxtUserInput.TextAlign = HorizontalAlignment.Center;
                    break;
                case TextAlignment.RIGHT:
                    ktxtUserInput.TextAlign = HorizontalAlignment.Right;
                    break;
            }
        }

        /// <summary>
        /// Gets the user response.
        /// </summary>
        /// <returns></returns>
        public string GetUserResponse() => ktxtUserInput.Text;

        /// <summary>
        /// Gets the user choice.
        /// </summary>
        /// <returns></returns>
        public string GetUserChoice() => kcmbUserSelection.Text;

        /// <summary>Relocates the icon.</summary>
        /// <param name="newPoint">The new point.</param>
        private void RelocateIcon(Point newPoint) => pbxInfoboxIcon.Location = newPoint;

        private void SetStartPosition(FormStartPosition startPosition) => StartPosition = startPosition;

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

        /// <summary>Sets the mask.</summary>
        /// <param name="maskText">The mask text.</param>
        private void SetMask(string maskText) => kmtxtUserInput.Mask = maskText;

        /// <summary>Sets the masked textbox text alignment.</summary>
        /// <param name="alignment">The alignment.</param>
        private void SetMaskedTextboxTextAlignment(TextAlignment alignment)
        {
            switch (alignment)
            {
                case TextAlignment.LEFT:
                    kmtxtUserInput.TextAlign = HorizontalAlignment.Left;
                    break;
                case TextAlignment.CENTRE:
                    kmtxtUserInput.TextAlign = HorizontalAlignment.Center;
                    break;
                case TextAlignment.RIGHT:
                    kmtxtUserInput.TextAlign = HorizontalAlignment.Right;
                    break;
            }
        }

        /// <summary>Sets the message text alignment.</summary>
        /// <param name="alignment">The alignment.</param>
        private void SetMessageTextAlignment(MessageTextAlignment alignment)
        {
            switch (alignment)
            {
                case MessageTextAlignment.INHERIT:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Inherit;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Inherit;
                    break;
                case MessageTextAlignment.NEARNEAR:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Near;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Near;
                    break;
                case MessageTextAlignment.NEARCENTRE:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Near;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
                    break;
                case MessageTextAlignment.NEARFAR:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Near;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Far;
                    break;
                case MessageTextAlignment.CENTRENEAR:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Near;
                    break;
                case MessageTextAlignment.CENTRECENTRE:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
                    break;
                case MessageTextAlignment.CENTREFAR:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Far;
                    break;
                case MessageTextAlignment.FARNEAR:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Far;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Near;
                    break;
                case MessageTextAlignment.FARCENTRE:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Far;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
                    break;
                case MessageTextAlignment.FARFAR:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Far;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Far;
                    break;
                case MessageTextAlignment.INHERITNEAR:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Inherit;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Near;
                    break;
                case MessageTextAlignment.INHERITCENTRE:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Inherit;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
                    break;
                case MessageTextAlignment.INHERITFAR:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Inherit;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Far;
                    break;
                case MessageTextAlignment.NEARINHERIT:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Near;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Inherit;
                    break;
                case MessageTextAlignment.CENTREINHERIT:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Center;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Inherit;
                    break;
                case MessageTextAlignment.FARINHERIT:
                    klblMessage.StateCommon.ShortText.TextH = PaletteRelativeAlign.Far;

                    klblMessage.StateCommon.ShortText.TextV = PaletteRelativeAlign.Inherit;
                    break;
            }
        }
        #endregion

        #region Event Handlers
        private void KryptonInputBoxExtended_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != null)
            {

            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void ktxtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }

        private void kbtnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        private void kbtnNo_Click(object sender, EventArgs e) => DialogResult = DialogResult.No;

        private void kbtnYes_Click(object sender, EventArgs e) => DialogResult = DialogResult.Yes;

        private void kbtnOk_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
        #endregion

        #region Show

        #region Internal Show
        private static string InternalShow(string message, string title = "", Language language = Language.ENGLISH, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "")
        {
            using (KryptonInputBoxExtended ib = new KryptonInputBoxExtended(message, title, language, type, listItems, showInTaskBar, controlTypeface, messageTypeface, okText, yesText, noText, cancelText, hintText))
            {
                return ib.ShowDialog() == DialogResult.OK ? ib.GetUserResponse() : string.Empty;
            }
        }

        private static string InternalShow(string message, string title = "", Icon icon = Icon.INFORMATION, Image image = null, Language language = Language.ENGLISH, Buttons buttons = Buttons.OK, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "", FormStartPosition startPosition = FormStartPosition.WindowsDefaultLocation, TextAlignment textAlignment = TextAlignment.LEFT, Point iconLocation = new Point())
        {
            using (KryptonInputBoxExtended inputBoxExtended = new KryptonInputBoxExtended(iconLocation, message, title, icon, image, language, buttons, type, listItems, showInTaskBar, controlTypeface, messageTypeface, okText, yesText, noText, cancelText, hintText, startPosition, textAlignment))
            {
                inputBoxExtended.StartPosition = startPosition;

                return inputBoxExtended.ShowDialog() == DialogResult.OK ? inputBoxExtended.GetUserResponse() : string.Empty;
            }
        }

        private static string InternalShow(IWin32Window owner, string message, string title = "", Icon icon = Icon.INFORMATION, Image image = null, Language language = Language.ENGLISH, Buttons buttons = Buttons.OK, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "", FormStartPosition startPosition = FormStartPosition.WindowsDefaultLocation, TextAlignment textAlignment = TextAlignment.LEFT, Point iconLocation = new Point())
        {
            IWin32Window showOwner = owner ?? FromHandle(Classes.PI.GetActiveWindow());

            string result;

            using (KryptonInputBoxExtended inputBoxExtended = new KryptonInputBoxExtended(iconLocation, message, title, icon, image, language, buttons, type, listItems, showInTaskBar, controlTypeface, messageTypeface, okText, yesText, noText, cancelText, hintText, startPosition, textAlignment))
            {
                inputBoxExtended.StartPosition = startPosition;

                switch (type)
                {
                    case Type.COMBOBOX:
                        break;
                    case Type.TEXTBOX:
                        break;
                    case Type.MASKEDTEXTBOX:
                        break;
                    case Type.NOTHING:
                        break;
                    default:
                        result = inputBoxExtended.ShowDialog(showOwner) == DialogResult.OK ? inputBoxExtended.GetUserResponse() : string.Empty;
                        break;
                }

                return inputBoxExtended.ShowDialog(showOwner) == DialogResult.OK ? inputBoxExtended.GetUserResponse() : string.Empty;
            }
        }
        #endregion

        public static string Show(string message, string title = "", Language language = Language.ENGLISH, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "") => InternalShow(message, title, language, type, listItems, showInTaskBar, controlTypeface, messageTypeface, okText, yesText, noText, cancelText, hintText);

        public static string Show(string message, string title = "", Icon icon = Icon.INFORMATION, Image image = null, Language language = Language.ENGLISH, Buttons buttons = Buttons.OK, Type type = Type.NOTHING, string[] listItems = null, bool showInTaskBar = false, Font controlTypeface = null, Font messageTypeface = null, string okText = "&Ok", string yesText = "&Yes", string noText = "N&o", string cancelText = "&Cancel", string hintText = "", FormStartPosition startPosition = FormStartPosition.WindowsDefaultLocation, TextAlignment textAlignment = TextAlignment.LEFT, Point iconLocation = new Point()) => InternalShow(message, title, icon, image, language, buttons, type, listItems, showInTaskBar, controlTypeface, messageTypeface, okText, yesText, noText, cancelText, hintText, startPosition, textAlignment, iconLocation);
        #endregion
    }
}