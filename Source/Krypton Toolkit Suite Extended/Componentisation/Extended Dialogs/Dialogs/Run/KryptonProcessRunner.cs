#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using Common;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace ExtendedDialogs.Dialogs.Run
{
    public class KryptonProcessRunner : KryptonForm
    {
        #region Designer Code
        private System.Windows.Forms.Panel pnlSplitter;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnBrowse;
        private KryptonButton kbtnRun;
        private KryptonButton kbtnCancel;
        private KryptonLabel klblMessage;
        private KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pbxInfoboxIcon;
        private KryptonTextBox ktxtUserInput;
        private KryptonComboBox kcmbPath;
        private System.Windows.Forms.PictureBox pbxApplicationIcon;
        private KryptonButton kbtnLocate;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnRun = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pbxInfoboxIcon = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktxtUserInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kcmbPath = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pbxApplicationIcon = new System.Windows.Forms.PictureBox();
            this.kbtnLocate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfoboxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxApplicationIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnLocate);
            this.kryptonPanel1.Controls.Add(this.kbtnRun);
            this.kryptonPanel1.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 212);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(696, 49);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 209);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(696, 3);
            this.pnlSplitter.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.ktxtUserInput);
            this.kryptonPanel2.Controls.Add(this.pbxApplicationIcon);
            this.kryptonPanel2.Controls.Add(this.kcmbPath);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.pbxInfoboxIcon);
            this.kryptonPanel2.Controls.Add(this.klblMessage);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(696, 209);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(500, 9);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(89, 28);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 5;
            this.kbtnCancel.Values.Text = "C&ancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kbtnRun
            // 
            this.kbtnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnRun.AutoSize = true;
            this.kbtnRun.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnRun.Enabled = false;
            this.kbtnRun.Location = new System.Drawing.Point(405, 9);
            this.kbtnRun.Name = "kbtnRun";
            this.kbtnRun.Size = new System.Drawing.Size(89, 28);
            this.kbtnRun.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRun.TabIndex = 6;
            this.kbtnRun.Values.Text = "&Run";
            this.kbtnRun.Click += new System.EventHandler(this.kbtnRun_Click);
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnBrowse.AutoSize = true;
            this.kbtnBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnBrowse.Location = new System.Drawing.Point(595, 9);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(89, 28);
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 7;
            this.kbtnBrowse.Values.Text = "&Browse...";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // klblMessage
            // 
            this.klblMessage.AutoSize = false;
            this.klblMessage.Location = new System.Drawing.Point(82, 12);
            this.klblMessage.Name = "klblMessage";
            this.klblMessage.Size = new System.Drawing.Size(602, 126);
            this.klblMessage.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMessage.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.klblMessage.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblMessage.TabIndex = 2;
            this.klblMessage.Values.Text = "Type the name of a application, file, directory or internet\r\nresource, and Window" +
    "s will open it for you.";
            // 
            // pbxInfoboxIcon
            // 
            this.pbxInfoboxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxInfoboxIcon.Image = global::ExtendedDialogs.Properties.Resources.Run_481;
            this.pbxInfoboxIcon.Location = new System.Drawing.Point(12, 49);
            this.pbxInfoboxIcon.Name = "pbxInfoboxIcon";
            this.pbxInfoboxIcon.Size = new System.Drawing.Size(48, 48);
            this.pbxInfoboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxInfoboxIcon.TabIndex = 3;
            this.pbxInfoboxIcon.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 165);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(52, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonLabel1.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Path:";
            // 
            // ktxtUserInput
            // 
            this.ktxtUserInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ktxtUserInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.ktxtUserInput.Location = new System.Drawing.Point(70, 163);
            this.ktxtUserInput.Name = "ktxtUserInput";
            this.ktxtUserInput.Size = new System.Drawing.Size(576, 27);
            this.ktxtUserInput.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtUserInput.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtUserInput.TabIndex = 5;
            this.ktxtUserInput.TextChanged += new System.EventHandler(this.ktxtUserInput_TextChanged);
            // 
            // kcmbPath
            // 
            this.kcmbPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.kcmbPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.kcmbPath.DropDownWidth = 241;
            this.kcmbPath.IntegralHeight = false;
            this.kcmbPath.Location = new System.Drawing.Point(70, 165);
            this.kcmbPath.Name = "kcmbPath";
            this.kcmbPath.Size = new System.Drawing.Size(576, 25);
            this.kcmbPath.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbPath.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbPath.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbPath.TabIndex = 6;
            this.kcmbPath.TextUpdate += new System.EventHandler(this.kmbPath_TextUpdate);
            this.kcmbPath.TextChanged += new System.EventHandler(this.kmbPath_TextChanged);
            // 
            // pbxApplicationIcon
            // 
            this.pbxApplicationIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxApplicationIcon.Location = new System.Drawing.Point(652, 165);
            this.pbxApplicationIcon.Name = "pbxApplicationIcon";
            this.pbxApplicationIcon.Size = new System.Drawing.Size(32, 32);
            this.pbxApplicationIcon.TabIndex = 7;
            this.pbxApplicationIcon.TabStop = false;
            // 
            // kbtnLocate
            // 
            this.kbtnLocate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnLocate.AutoSize = true;
            this.kbtnLocate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnLocate.Enabled = false;
            this.kbtnLocate.Location = new System.Drawing.Point(12, 9);
            this.kbtnLocate.Name = "kbtnLocate";
            this.kbtnLocate.Size = new System.Drawing.Size(89, 28);
            this.kbtnLocate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLocate.TabIndex = 8;
            this.kbtnLocate.Values.Text = "L&ocate";
            this.kbtnLocate.Click += new System.EventHandler(this.kbtnLocate_Click);
            // 
            // KryptonProcessRunner
            // 
            this.ClientSize = new System.Drawing.Size(696, 261);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonProcessRunner";
            this.Load += new System.EventHandler(this.KryptonProcessRunner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfoboxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxApplicationIcon)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Enumerations
        public enum Type
        {
            COMBOBOX,
            TEXTBOX
        }

        public enum IconVisibility
        {
            HIDDEN,
            VISIBLE
        }
        #endregion

        #region Variables
        private Type _type;

        private IconVisibility _iconVisibility;
        #endregion

        #region Constructors
        public KryptonProcessRunner(Type type = Type.TEXTBOX, IconVisibility iconVisibility = IconVisibility.VISIBLE)
        {
            InitializeComponent();

            SetInputType(type);

            SetIconVisibility(iconVisibility);

            AdaptUI(type, iconVisibility);
        }
        #endregion

        private void KryptonProcessRunner_Load(object sender, EventArgs e)
        {

        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Browse for a Process:";

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (GetInputType() == Type.COMBOBOX)
                {
                    kcmbPath.Text = Path.GetFullPath(cofd.FileName);
                }
                else if (GetInputType() == Type.TEXTBOX)
                {
                    ktxtUserInput.Text = Path.GetFullPath(cofd.FileName);
                }
            }
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kbtnRun_Click(object sender, EventArgs e)
        {
            if (GetInputType() == Type.COMBOBOX)
            {
                RunProcess(kcmbPath.Text);
            }
            else if (GetInputType() == KryptonProcessRunner.Type.TEXTBOX)
            {
                RunProcess(ktxtUserInput.Text);
            }
        }

        private void ktxtUserInput_TextChanged(object sender, EventArgs e)
        {
            if (HasFileExtension(ktxtUserInput.Text))
            {
                EnableLocateButton(IsTextBoxStringEmpty());

                EnableRunButton(IsTextBoxStringEmpty());
            }

            if (GetIconVisibility() == IconVisibility.VISIBLE && IsTextBoxStringEmpty()) GetApplicationIcon(ktxtUserInput.Text);
        }

        private void kmbPath_TextChanged(object sender, EventArgs e)
        {
            if (HasFileExtension(kcmbPath.Text))
            {
                EnableLocateButton(IsComboBoxStringEmpty());

                EnableRunButton(IsComboBoxStringEmpty());
            }

            if (GetIconVisibility() == IconVisibility.VISIBLE && IsComboBoxStringEmpty()) GetApplicationIcon(ktxtUserInput.Text);
        }

        private void kmbPath_TextUpdate(object sender, EventArgs e)
        {
            if (HasFileExtension(kcmbPath.Text))
            {
                EnableLocateButton(IsComboBoxStringEmpty());

                EnableRunButton(IsComboBoxStringEmpty());
            }

            if (GetIconVisibility() == IconVisibility.VISIBLE && IsComboBoxStringEmpty()) GetApplicationIcon(ktxtUserInput.Text);
        }

        private void kbtnLocate_Click(object sender, EventArgs e)
        {
            if (GetInputType() == Type.COMBOBOX)
            {
                LaunchProcess(kcmbPath.Text);
            }
            else if (GetInputType() == Type.TEXTBOX)
            {
                LaunchProcess(ktxtUserInput.Text);
            }
        }

        #region Methods
        private bool HasFileExtension(string path)
        {
            if (Path.HasExtension(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsTextBoxStringEmpty() => string.IsNullOrEmpty(ktxtUserInput.Text);

        private bool IsComboBoxStringEmpty() => string.IsNullOrEmpty(kcmbPath.Text);

        private void RunProcess(string path)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo(path);

                Process.Start(psi);

                Close();
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }

        private Image GetApplicationIcon(string path) => Icon.ExtractAssociatedIcon(path).ToBitmap();

        private void LaunchProcess(string path) => Process.Start("explorer.exe", path);

        private void EnableRunButton(bool value) => kbtnRun.Enabled = value;

        private void EnableLocateButton(bool value) => kbtnLocate.Enabled = value;

        public void AdaptUI(Type type, IconVisibility iconVisibility)
        {
            switch (iconVisibility)
            {
                case IconVisibility.HIDDEN:
                    pbxApplicationIcon.Visible = false;

                    switch (type)
                    {
                        case Type.COMBOBOX:
                            kcmbPath.Visible = true;

                            kcmbPath.Size = new Size(614, 25);

                            ktxtUserInput.Visible = false;
                            break;
                        case Type.TEXTBOX:
                            kcmbPath.Visible = false;

                            ktxtUserInput.Visible = true;

                            ktxtUserInput.Size = new Size(614, 25);
                            break;
                    }
                    break;
                case IconVisibility.VISIBLE:
                    pbxApplicationIcon.Visible = true;

                    switch (type)
                    {
                        case Type.COMBOBOX:
                            kcmbPath.Visible = true;

                            kcmbPath.Size = new Size(576, 25);

                            ktxtUserInput.Visible = false;
                            break;
                        case Type.TEXTBOX:
                            kcmbPath.Visible = false;

                            ktxtUserInput.Visible = true;

                            ktxtUserInput.Size = new Size(576, 25);
                            break;
                    }
                    break;

            }
        }
        #endregion

        #region Setters/Getters
        /// <summary>
        /// Sets the InputType.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetInputType(Type value) => _type = value;

        /// <summary>
        /// Gets the InputType.
        /// </summary>
        /// <returns>The value of _type.</returns>
        public Type GetInputType() => _type;

        /// <summary>
        /// Sets the IconVisibility.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetIconVisibility(IconVisibility value) => _iconVisibility = value;

        /// <summary>
        /// Gets the IconVisibility.
        /// </summary>
        /// <returns>The value of _iconVisibility.</returns>
        public IconVisibility GetIconVisibility() => _iconVisibility;
        #endregion
    }
}