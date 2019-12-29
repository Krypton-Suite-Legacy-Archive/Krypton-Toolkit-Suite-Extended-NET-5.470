#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground.MessageBox
{
    public class MessageBoxExtended : Form
    {
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.chkOption = new System.Windows.Forms.CheckBox();
            this.pbxErrorIcon = new System.Windows.Forms.PictureBox();
            this.pbxQuestionIcon = new System.Windows.Forms.PictureBox();
            this.pbxWarningIcon = new System.Windows.Forms.PictureBox();
            this.pbxInformationIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuestionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarningIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInformationIcon)).BeginInit();
            this.SuspendLayout();
            //
            // panel1
            //
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                         | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 54);
            this.panel1.TabIndex = 2;
            //
            // flowLayoutPanel1
            //
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                         | System.Windows.Forms.AnchorStyles.Left)
                         | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnNo);
            this.flowLayoutPanel1.Controls.Add(this.btnYes);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(276, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            //
            // btnOK
            //
            this.btnOK.Location = new System.Drawing.Point(198, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 29);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            //
            // btnCancel
            //
            this.btnCancel.Location = new System.Drawing.Point(117, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // btnNo
            //
            this.btnNo.Location = new System.Drawing.Point(36, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 29);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "&No";
            this.btnNo.UseVisualStyleBackColor = true;
            //
            // btnYes
            //
            this.btnYes.Location = new System.Drawing.Point(198, 38);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 29);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "&Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            //
            // flowLayoutPanel2
            //
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                         | System.Windows.Forms.AnchorStyles.Left)
                         | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.lblMessage);
            this.flowLayoutPanel2.Controls.Add(this.chkOption);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(68, 35);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(212, 86);
            this.flowLayoutPanel2.TabIndex = 3;
            //
            // lblMessage
            //
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                         | System.Windows.Forms.AnchorStyles.Left)
                         | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(3, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(80, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "label1";
            //
            // chkOption
            //
            this.chkOption.AutoSize = true;
            this.chkOption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOption.Location = new System.Drawing.Point(3, 36);
            this.chkOption.Name = "chkOption";
            this.chkOption.Size = new System.Drawing.Size(80, 17);
            this.chkOption.TabIndex = 5;
            this.chkOption.Text = "checkBox1";
            this.chkOption.UseVisualStyleBackColor = true;
            //
            // pbxErrorIcon
            //
            this.pbxErrorIcon.Location = new System.Drawing.Point(30, 35);
            this.pbxErrorIcon.Name = "pbxErrorIcon";
            this.pbxErrorIcon.Size = new System.Drawing.Size(32, 32);
            this.pbxErrorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxErrorIcon.TabIndex = 0;
            this.pbxErrorIcon.TabStop = false;
            this.pbxErrorIcon.Visible = false;
            //
            // pbxQuestionIcon
            //
            this.pbxQuestionIcon.Location = new System.Drawing.Point(30, 35);
            this.pbxQuestionIcon.Name = "pbxQuestionIcon";
            this.pbxQuestionIcon.Size = new System.Drawing.Size(32, 32);
            this.pbxQuestionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxQuestionIcon.TabIndex = 4;
            this.pbxQuestionIcon.TabStop = false;
            this.pbxQuestionIcon.Visible = false;
            //
            // pbxWarningIcon
            //
            this.pbxWarningIcon.Location = new System.Drawing.Point(30, 35);
            this.pbxWarningIcon.Name = "pbxWarningIcon";
            this.pbxWarningIcon.Size = new System.Drawing.Size(32, 32);
            this.pbxWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxWarningIcon.TabIndex = 5;
            this.pbxWarningIcon.TabStop = false;
            this.pbxWarningIcon.Visible = false;
            //
            // pbxInformationIcon
            //
            this.pbxInformationIcon.Location = new System.Drawing.Point(30, 35);
            this.pbxInformationIcon.Name = "pbxInformationIcon";
            this.pbxInformationIcon.Size = new System.Drawing.Size(32, 32);
            this.pbxInformationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxInformationIcon.TabIndex = 6;
            this.pbxInformationIcon.TabStop = false;
            this.pbxInformationIcon.Visible = false;
            //
            // frmMessageBoxWithCheckBox
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 183);
            this.Controls.Add(this.pbxInformationIcon);
            this.Controls.Add(this.pbxWarningIcon);
            this.Controls.Add(this.pbxQuestionIcon);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxErrorIcon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageBoxWithCheckBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessageBoxWithCheckBox";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuestionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarningIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInformationIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pbxErrorIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.CheckBox chkOption;
        private System.Windows.Forms.PictureBox pbxQuestionIcon;
        private System.Windows.Forms.PictureBox pbxWarningIcon;
        private System.Windows.Forms.PictureBox pbxInformationIcon;
    }
}