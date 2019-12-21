#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */

/************************************************************************************************
*                                                                                              *
* Author: Max Kleyzit.                                                                         *
* Developed for StresStimulus, free Fiddler extension for load testing of web applications     *
* http://stresstimulus.stimulustechnology.com/                                                 *
*                                                                                              *
***********************************************************************************************/
#endregion

using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitSuiteExtendedCore.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore
{
    public class KryptonMessageBoxAdvanced : KryptonForm
    {
        #region Designer Code
        private KryptonCheckBox kchkDoNotShowThisAgain;
        private KryptonButton kbtnButton2;
        private KryptonButton kbtnButton1;
        private KryptonButton kbtnButton3;
        private KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel1;
        private KryptonWrapLabel kwlMessage;
        private System.Windows.Forms.PictureBox pbxIcon;
        private KryptonPanel kpnlButtons;

        private void InitializeComponent()
        {
            this.kpnlButtons = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kbtnButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kchkDoNotShowThisAgain = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.kwlMessage = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).BeginInit();
            this.kpnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlButtons
            // 
            this.kpnlButtons.Controls.Add(this.kchkDoNotShowThisAgain);
            this.kpnlButtons.Controls.Add(this.kbtnButton2);
            this.kpnlButtons.Controls.Add(this.kbtnButton1);
            this.kpnlButtons.Controls.Add(this.kbtnButton3);
            this.kpnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlButtons.Location = new System.Drawing.Point(0, 121);
            this.kpnlButtons.Name = "kpnlButtons";
            this.kpnlButtons.Size = new System.Drawing.Size(547, 49);
            this.kpnlButtons.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kwlMessage);
            this.kryptonPanel1.Controls.Add(this.pbxIcon);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(547, 121);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 3);
            this.panel1.TabIndex = 0;
            // 
            // kbtnButton3
            // 
            this.kbtnButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnButton3.Location = new System.Drawing.Point(445, 12);
            this.kbtnButton3.Name = "kbtnButton3";
            this.kbtnButton3.Size = new System.Drawing.Size(90, 25);
            this.kbtnButton3.TabIndex = 0;
            this.kbtnButton3.Values.Text = "kryptonButton1";
            // 
            // kbtnButton1
            // 
            this.kbtnButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnButton1.Location = new System.Drawing.Point(253, 12);
            this.kbtnButton1.Name = "kbtnButton1";
            this.kbtnButton1.Size = new System.Drawing.Size(90, 25);
            this.kbtnButton1.TabIndex = 1;
            this.kbtnButton1.Values.Text = "kryptonButton1";
            // 
            // kbtnButton2
            // 
            this.kbtnButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnButton2.Location = new System.Drawing.Point(349, 12);
            this.kbtnButton2.Name = "kbtnButton2";
            this.kbtnButton2.Size = new System.Drawing.Size(90, 25);
            this.kbtnButton2.TabIndex = 2;
            this.kbtnButton2.Values.Text = "kryptonButton1";
            // 
            // kchkDoNotShowThisAgain
            // 
            this.kchkDoNotShowThisAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kchkDoNotShowThisAgain.Location = new System.Drawing.Point(12, 15);
            this.kchkDoNotShowThisAgain.Name = "kchkDoNotShowThisAgain";
            this.kchkDoNotShowThisAgain.Size = new System.Drawing.Size(141, 20);
            this.kchkDoNotShowThisAgain.TabIndex = 3;
            this.kchkDoNotShowThisAgain.Values.Text = "&Don\'t show this again";
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Location = new System.Drawing.Point(12, 12);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(64, 64);
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            // 
            // kwlMessage
            // 
            this.kwlMessage.AutoSize = false;
            this.kwlMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.kwlMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kwlMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kwlMessage.Location = new System.Drawing.Point(82, 0);
            this.kwlMessage.Name = "kwlMessage";
            this.kwlMessage.Size = new System.Drawing.Size(465, 121);
            this.kwlMessage.Text = "kryptonWrapLabel1";
            this.kwlMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KryptonMessageBoxAdvanced
            // 
            this.ClientSize = new System.Drawing.Size(547, 170);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kpnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonMessageBoxAdvanced";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KryptonMessageBoxAdvanced_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).EndInit();
            this.kpnlButtons.ResumeLayout(false);
            this.kpnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Enumerations
        public enum MessageBoxIcon
        {
            CUSTOM,
            OK,
            ERROR,
            EXCLAMATION,
            INFORMATION,
            QUESTION,
            NONE,
            STOP,
            HAND
        }

        public enum MessageBoxButtons
        {
            OK,
            OKCANCEL,
            YESNO,
            YESNOCANCEL
        }

        enum DialogBoxResult
        {
            Button1,
            Button2,
            Button3
        }
        #endregion

        #region Constants
        const int FORM_Y_MARGIN = 10;
        const int FORM_X_MARGIN = 16;
        const int BUTTON_SPACE = 5;
        const int CHECKBOX_SPACE = 15;
        const int TEXT_Y_MARGIN = 30;
        #endregion

        #region Variables
        int m_minButtonRowWidth, m_minWidth, m_minHeight;
        #endregion

        #region Constructors
        public KryptonMessageBoxAdvanced(string message, string title) : this(message, title, MessageBoxIcon.NONE)
        {

        }

        public KryptonMessageBoxAdvanced(string message, string title, MessageBoxIcon icon) : this(message, title, GetMessageBoxIcon(icon))
        {

        }

        public KryptonMessageBoxAdvanced(string message, string title, Icon icon)
        {
            InitializeComponent();

            kwlMessage.Text = message;

            Text = title;

            SetIcon(icon);
        }
        #endregion

        #region APIs
        /// <summary>Sets the minimum size.</summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        private void SetMinimumSize(int width, int height)
        {
            Width = width;

            Height = height;
        }

        /// <summary>Sets the buttons.</summary>
        /// <param name="names">The names.</param>
        private void SetButtons(params string[] names)
        {
            DialogResult[] results = new DialogResult[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                results[i] = DialogResult.None;
            }

            SetButtons(names, results);
        }

        /// <summary>Sets the buttons.</summary>
        /// <param name="names">The names.</param>
        /// <param name="results">The results.</param>
        private void SetButtons(string[] names, DialogResult[] results)
        {
            SetButtons(names, results, 1);
        }

        /// <summary>Sets the buttons.</summary>
        /// <param name="names">The names.</param>
        /// <param name="results">The results.</param>
        /// <param name="def">The definition.</param>
        /// <exception cref="ArgumentNullException">btnText - Button Text is null</exception>
        /// <exception cref="ArgumentException">Invalid number of buttons. Must be between 1 and 3.</exception>
        private void SetButtons(string[] names, DialogResult[] results, int def)
        {
            if (names == null)
                throw new ArgumentNullException("btnText", "Button Text is null");

            int count = names.Length;

            if (count < 1 || count > 3)
                throw new ArgumentException("Invalid number of buttons. Must be between 1 and 3.");

            //---- Set Button 1
            m_minButtonRowWidth += SetButtonParams(kbtnButton1, names[0], def == 1 ? 1 : 2, results[0]);

            //---- Set Button 2
            if (count > 1)
            {
                m_minButtonRowWidth += SetButtonParams(kbtnButton2, names[1], def == 2 ? 1 : 3, results[1]) + BUTTON_SPACE;
            }

            //---- Set Button 3
            if (count > 2)
            {
                m_minButtonRowWidth += SetButtonParams(kbtnButton3, names[2], def == 3 ? 1 : 4, results[2]) + BUTTON_SPACE;
            }
        }

        /// <summary>Sets the button parameters.</summary>
        /// <param name="button">The button.</param>
        /// <param name="text">The text.</param>
        /// <param name="tab">The tab.</param>
        /// <param name="dialogResult">The dialog result.</param>
        /// <returns></returns>
        private static int SetButtonParams(KryptonButton button, string text, int tab, DialogResult dialogResult)
        {
            button.Text = text;

            button.Visible = true;

            button.DialogResult = dialogResult;

            button.TabIndex = tab;

            return button.Size.Width;
        }

        /// <summary>Sets the checkbox.</summary>
        /// <param name="text">The text.</param>
        public void SetCheckbox(string text)
        {
            SetCheckbox(text, false);
        }

        /// <summary>Sets the checkbox.</summary>
        /// <param name="text">The text.</param>
        /// <param name="check">if set to <c>true</c> [check].</param>
        private void SetCheckbox(string text, bool check)
        {
            kchkDoNotShowThisAgain.Visible = true;

            kchkDoNotShowThisAgain.Text = text;

            kchkDoNotShowThisAgain.Checked = check;

            m_minButtonRowWidth += kchkDoNotShowThisAgain.Size.Width + CHECKBOX_SPACE;
        }
        #endregion

        private void KryptonMessageBoxAdvanced_Load(object sender, EventArgs e)
        {
            if (!kbtnButton1.Visible) SetButtons(new string[] { "&OK" }, new DialogResult[] { DialogResult.OK });

            m_minButtonRowWidth += 2 * FORM_X_MARGIN;

            SetDialogSize();

            SetButtonRowLoctions();
        }

        private void SetButtonRowLoctions()
        {
            int formWidth = this.ClientRectangle.Width;

            int x = formWidth - FORM_X_MARGIN;
            int y = kbtnButton1.Location.Y;

            if (kbtnButton3.Visible)
            {
                x -= kbtnButton3.Size.Width;
                kbtnButton3.Location = new Point(x, y);
                x -= BUTTON_SPACE;
            }

            if (kbtnButton2.Visible)
            {
                x -= kbtnButton2.Size.Width;
                kbtnButton2.Location = new Point(x, y);
                x -= BUTTON_SPACE;
            }

            x -= kbtnButton1.Size.Width;
            kbtnButton1.Location = new Point(x, y);

            if (this.kchkDoNotShowThisAgain.Visible) this.kchkDoNotShowThisAgain.Location = new Point(FORM_X_MARGIN, this.kchkDoNotShowThisAgain.Location.Y);

        }

        private void SetDialogSize()
        {
            int requiredWidth = kwlMessage.Location.X + kwlMessage.Size.Width + FORM_X_MARGIN;

            requiredWidth = requiredWidth > m_minButtonRowWidth ? requiredWidth : m_minButtonRowWidth;

            int requiredHeight = kwlMessage.Location.Y + kwlMessage.Size.Height - kbtnButton2.Location.Y + this.ClientSize.Height + TEXT_Y_MARGIN;

            int minSetWidth = this.ClientSize.Width > this.m_minWidth ? this.ClientSize.Width : this.m_minWidth;
            int minSetHeight = this.ClientSize.Height > this.m_minHeight ? this.ClientSize.Height : this.m_minHeight;

            Size s = new Size();
            s.Width = requiredWidth > minSetWidth ? requiredWidth : minSetWidth;
            s.Height = requiredHeight > minSetHeight ? requiredHeight : minSetHeight;
            this.ClientSize = s;
        }

        #region Methods
        /// <summary>Gets the message box icon.</summary>
        /// <param name="icon">The icon.</param>
        /// <param name="customIcon">The custom icon.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static Icon GetMessageBoxIcon(MessageBoxIcon icon, Image customIcon = null)
        {
            switch (icon)
            {
                case MessageBoxIcon.CUSTOM:
                    if (customIcon == null)
                    {
                        throw new ArgumentNullException();
                    }
                    else
                    {
                        Bitmap ci = new Bitmap(customIcon);

                        return Icon.FromHandle(ci.GetHicon());
                    }
                case MessageBoxIcon.OK:
                    Bitmap ok = new Bitmap(Resources.Input_Box_Ok_64_x_64);

                    return Icon.FromHandle(ok.GetHicon());
                case MessageBoxIcon.ERROR:
                    Bitmap error = new Bitmap(Resources.Input_Box_Critical_64_x_64);

                    return Icon.FromHandle(error.GetHicon());
                case MessageBoxIcon.EXCLAMATION:
                    Bitmap exc = new Bitmap(Resources.Input_Box_Warning_64_x_58);

                    return Icon.FromHandle(exc.GetHicon());
                case MessageBoxIcon.INFORMATION:
                    Bitmap info = new Bitmap(Resources.Input_Box_Information_64_x_64);

                    return Icon.FromHandle(info.GetHicon());
                case MessageBoxIcon.QUESTION:
                    Bitmap question = new Bitmap(Resources.Input_Box_Question_64_x_64);

                    return Icon.FromHandle(question.GetHicon());
                case MessageBoxIcon.NONE:
                    return null;
                case MessageBoxIcon.STOP:
                    Bitmap stop = new Bitmap(Resources.Input_Box_Stop_64_x_64);

                    return Icon.FromHandle(stop.GetHicon());
                case MessageBoxIcon.HAND:
                    Bitmap hand = new Bitmap(Resources.Input_Box_Hand_64_x_64);

                    return Icon.FromHandle(hand.GetHicon());
                default:
                    return null;
            }
        }

        private void SetIcon(MessageBoxIcon icon, Image image = null)
        {
            switch (icon)
            {
                case MessageBoxIcon.CUSTOM:
                    if (image == null)
                    {
                        throw new ArgumentNullException();
                    }
                    else
                    {
                        SetIcon(image);
                    }
                    break;
                case MessageBoxIcon.OK:
                    SetIcon(Resources.Input_Box_Ok_64_x_64);
                    break;
                case MessageBoxIcon.ERROR:
                    SetIcon(Resources.Input_Box_Critical_64_x_64);
                    break;
                case MessageBoxIcon.EXCLAMATION:
                    SetIcon(Resources.Input_Box_Warning_64_x_58);
                    break;
                case MessageBoxIcon.INFORMATION:
                    SetIcon(Resources.Input_Box_Information_64_x_64);
                    break;
                case MessageBoxIcon.QUESTION:
                    SetIcon(Resources.Input_Box_Question_64_x_64);
                    break;
                case MessageBoxIcon.NONE:
                    pbxIcon.Visible = false;
                    break;
                case MessageBoxIcon.STOP:
                    SetIcon(Resources.Input_Box_Stop_64_x_64);
                    break;
                case MessageBoxIcon.HAND:
                    SetIcon(Resources.Input_Box_Hand_64_x_64);
                    break;
            }
        }

        private void SetIcon(Image image) => pbxIcon.Image = image;

        /// <summary>Sets the icon.</summary>
        /// <param name="icon">The icon.</param>
        private void SetIcon(Icon icon) => pbxIcon.Image = icon.ToBitmap();

        private void SetIconVisibility(bool visible = true) => pbxIcon.Visible = visible;
        #endregion
    }
}