#region License and Copyright
/*
 
Copyright (c) Guifreaks - Jacob Mesu
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the Guifreaks nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

*/
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.NaviSuite.Main.Common;
using ExtendedControls.ExtendedToolkit.NaviSuite.Main.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedControls.ExtendedToolkit.NaviSuite.Main.Forms
{
    public class NaviOptionsForm : KryptonForm
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
            this.labelDesc = new System.Windows.Forms.Label();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkedListBoxBands = new ExtendedControls.ExtendedToolkit.NaviSuite.Main.Controls.NaviCheckedListBox();
            this.SuspendLayout();
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(12, 9);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(136, 13);
            this.labelDesc.TabIndex = 0;
            this.labelDesc.Text = "Display buttons in this order";
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveUp.Location = new System.Drawing.Point(208, 43);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveUp.TabIndex = 1;
            this.buttonMoveUp.Text = "Move up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(208, 101);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveDown.Location = new System.Drawing.Point(208, 72);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveDown.TabIndex = 3;
            this.buttonMoveDown.Text = "Move down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(124, 231);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(205, 231);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkedListBoxBands
            // 
            this.checkedListBoxBands.FormattingEnabled = true;
            this.checkedListBoxBands.Location = new System.Drawing.Point(12, 30);
            this.checkedListBoxBands.Name = "checkedListBoxBands";
            this.checkedListBoxBands.Size = new System.Drawing.Size(187, 184);
            this.checkedListBoxBands.TabIndex = 6;
            // 
            // NaviOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.checkedListBoxBands);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.labelDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NaviOptionsForm";
            this.Text = "Options of the Navigation Pane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private ExtendedToolkit.NaviSuite.Main.Controls.NaviCheckedListBox checkedListBoxBands;
        #endregion

        NaviBar bar;

        public NaviOptionsForm()
        {
            InitializeComponent();
        }

        public void Initialize(NaviBar bar)
        {
            this.bar = bar;
            checkedListBoxBands.Items.Clear();
            foreach (NaviBand band in bar.Bands)
            {
                checkedListBoxBands.Items.Add(band.Text, band.Visible);
            }
            Translate();
        }

        private void Translate()
        {
            ResourceManager rm = new ResourceManager(
               "ExtendedControls.ExtendedToolkit.NaviSuite.Main.Resources.Text", Assembly.GetExecutingAssembly());

            buttonCancel.Text = rm.GetString("OptionsCancel");
            buttonOk.Text = rm.GetString("OptionsOk");
            labelDesc.Text = rm.GetString("OptionsIntro");
            buttonMoveDown.Text = rm.GetString("OptionsMoveDown");
            buttonMoveUp.Text = rm.GetString("OptionsMoveUp");
            buttonReset.Text = rm.GetString("OptionsReset");
            Text = rm.GetString("OptionsTitle");
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // Set the new order
            for (int i = 0; i < bar.Bands.Count; i++)
            {
                int loc = checkedListBoxBands.Items.IndexOf(bar.Bands[i].Text);
                bar.Bands[i].Visible = checkedListBoxBands.CheckedItems.Contains(bar.Bands[i].Text);
                bar.Bands[i].Order = loc;
            }

            // And sort the list based on the new order
            bar.Bands.Sort(new NaviBandOrderComparer());
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            if (checkedListBoxBands.SelectedIndex > 0)
            {
                bool oldChecked = checkedListBoxBands.CheckedIndices.Contains(
                   checkedListBoxBands.SelectedIndex - 1);
                bool oldChecked2 = checkedListBoxBands.CheckedIndices.Contains(
                   checkedListBoxBands.SelectedIndex);

                object oldItem = checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex - 1];
                checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex - 1] =
                   checkedListBoxBands.SelectedItem;

                checkedListBoxBands.SetItemChecked(checkedListBoxBands.SelectedIndex,
                   oldChecked);
                checkedListBoxBands.SetItemChecked(checkedListBoxBands.SelectedIndex - 1,
                   oldChecked2);

                checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex] = oldItem;
                checkedListBoxBands.SelectedIndex -= 1;
            }
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            if ((checkedListBoxBands.SelectedIndex > 0)
            && (checkedListBoxBands.SelectedIndex < checkedListBoxBands.Items.Count - 1))
            {
                bool oldChecked = checkedListBoxBands.CheckedIndices.Contains(
                   checkedListBoxBands.SelectedIndex + 1);
                bool oldChecked2 = checkedListBoxBands.CheckedIndices.Contains(
                   checkedListBoxBands.SelectedIndex);

                object oldItem = checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex + 1];
                checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex + 1] =
                   checkedListBoxBands.SelectedItem;

                checkedListBoxBands.SetItemChecked(checkedListBoxBands.SelectedIndex,
                   oldChecked);
                checkedListBoxBands.SetItemChecked(checkedListBoxBands.SelectedIndex + 1,
                   oldChecked2);

                checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex] = oldItem;
                checkedListBoxBands.SelectedIndex += 1;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Sort list based on original order
            bar.Bands.Sort(new NaviBandOrgOrderComparer());
            Initialize(bar);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Reset ordering posibly caused by reset button
            bar.Bands.Sort(new NaviBandOrderComparer());
        }
    }
}
