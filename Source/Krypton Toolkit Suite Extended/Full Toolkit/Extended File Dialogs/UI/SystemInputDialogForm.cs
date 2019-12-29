#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedFileDialogs.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ExtendedFileDialogs.UI
{
    internal partial class SystemInputDialogForm : ExtendedSystemForm
    {
        #region Designer Code
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemInputDialogForm));
            this._primaryPanel = new System.Windows.Forms.Panel();
            this._inputTextBox = new System.Windows.Forms.TextBox();
            this._secondaryPanel = new System.Windows.Forms.Panel();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this._primaryPanel.SuspendLayout();
            this._secondaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _primaryPanel
            // 
            this._primaryPanel.Controls.Add(this._inputTextBox);
            resources.ApplyResources(this._primaryPanel, "_primaryPanel");
            this._primaryPanel.Name = "_primaryPanel";
            this._primaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this._primaryPanel_Paint);
            // 
            // _inputTextBox
            // 
            resources.ApplyResources(this._inputTextBox, "_inputTextBox");
            this._inputTextBox.Name = "_inputTextBox";
            // 
            // _secondaryPanel
            // 
            this._secondaryPanel.Controls.Add(this._cancelButton);
            this._secondaryPanel.Controls.Add(this._okButton);
            resources.ApplyResources(this._secondaryPanel, "_secondaryPanel");
            this._secondaryPanel.Name = "_secondaryPanel";
            this._secondaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this._secondaryPanel_Paint);
            // 
            // _cancelButton
            // 
            resources.ApplyResources(this._cancelButton, "_cancelButton");
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            resources.ApplyResources(this._okButton, "_okButton");
            this._okButton.Name = "_okButton";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // InputDialogForm
            // 
            this.AcceptButton = this._okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.Controls.Add(this._primaryPanel);
            this.Controls.Add(this._secondaryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputDialogForm";
            this.ShowInTaskbar = false;
            this.UseSystemFont = true;
            this.Load += new System.EventHandler(this.NewInputBoxForm_Load);
            this._primaryPanel.ResumeLayout(false);
            this._primaryPanel.PerformLayout();
            this._secondaryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _primaryPanel;
        private System.Windows.Forms.Panel _secondaryPanel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.TextBox _inputTextBox;
        #endregion

        private SizeF _textMargin = new SizeF(12, 9);
        private string _mainInstruction;
        private string _content;

        public event EventHandler<OkButtonClickedEventArgs> OkButtonClicked;

        public SystemInputDialogForm()
        {
            InitializeComponent();
        }

        public string MainInstruction
        {
            get { return _mainInstruction; }
            set { _mainInstruction = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public string Input
        {
            get { return _inputTextBox.Text; }
            set { _inputTextBox.Text = value; }
        }

        public int MaxLength
        {
            get { return _inputTextBox.MaxLength; }
            set { _inputTextBox.MaxLength = value; }
        }

        public bool UsePasswordMasking
        {
            get { return _inputTextBox.UseSystemPasswordChar; }
            set { _inputTextBox.UseSystemPasswordChar = value; }
        }

        protected virtual void OnOkButtonClicked(OkButtonClickedEventArgs e)
        {
            if (OkButtonClicked != null)
                OkButtonClicked(this, e);
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            _textMargin = new SizeF(_textMargin.Width * factor.Width, _textMargin.Height * factor.Height);
            base.ScaleControl(factor, specified);
        }

        private void SizeDialog()
        {
            int horizontalSpacing = (int)_textMargin.Width * 2;
            int verticalSpacing = ClientSize.Height - _inputTextBox.Top + (int)_textMargin.Height * 3;
            using (Graphics graphics = _primaryPanel.CreateGraphics())
            {
                ClientSize = DialogHelper.SizeDialog(graphics, MainInstruction, Content, Screen.FromControl(this), new Font(Font, FontStyle.Bold), Font, horizontalSpacing, verticalSpacing, ClientSize.Width, 0);
            }
        }

        private static void DrawThemeBackground(IDeviceContext dc, VisualStyleElement element, Rectangle bounds, Rectangle clipRectangle)
        {
            if (DialogHelper.IsTaskDialogThemeSupported)
            {
                VisualStyleRenderer renderer = new VisualStyleRenderer(element);
                renderer.DrawBackground(dc, bounds, clipRectangle);
            }
        }

        private void DrawText(IDeviceContext dc, ref Point location, bool measureOnly, int width)
        {
            DialogHelper.DrawText(dc, MainInstruction, Content, ref location, new Font(Font, FontStyle.Bold), Font, measureOnly, width);
        }

        private void _primaryPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawThemeBackground(e.Graphics, AdditionalVisualStyleElements.TaskDialog.PrimaryPanel, _primaryPanel.ClientRectangle, e.ClipRectangle);
            Point location = new Point((int)_textMargin.Width, (int)_textMargin.Height);
            DrawText(e.Graphics, ref location, false, ClientSize.Width - (int)_textMargin.Width * 2);
        }

        private void _secondaryPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawThemeBackground(e.Graphics, AdditionalVisualStyleElements.TaskDialog.SecondaryPanel, _secondaryPanel.ClientRectangle, e.ClipRectangle);
        }

        private void NewInputBoxForm_Load(object sender, EventArgs e)
        {
            SizeDialog();
            CenterToScreen();
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            OkButtonClickedEventArgs okButtonClickedEventArgs = new OkButtonClickedEventArgs(_inputTextBox.Text, this);
            OnOkButtonClicked(okButtonClickedEventArgs);
            if (!okButtonClickedEventArgs.Cancel)
                DialogResult = DialogResult.OK;
        }
    }
}