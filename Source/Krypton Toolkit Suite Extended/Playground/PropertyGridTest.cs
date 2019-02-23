using ComponentFactory.Krypton.Toolkit;
using System;

namespace Playground
{
    public class PropertyGridTest : KryptonForm
    {
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid kpgControlDetails;
        private ExtendedControls.ExtendedToolkit.Controls.Charting.KryptonKnobControl kryptonKnobControl1;
        private ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar kryptonScrollBar1;
        private System.ComponentModel.IContainer components;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.PromptRoundedTextbox promptRoundedTextbox1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonToggleSwitch kryptonToggleSwitch1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonToggleSwitch1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonToggleSwitch();
            this.kryptonKnobControl1 = new ExtendedControls.ExtendedToolkit.Controls.Charting.KryptonKnobControl();
            this.kryptonScrollBar1 = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.promptRoundedTextbox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.PromptRoundedTextbox();
            this.kpgControlDetails = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonToggleSwitch1);
            this.kryptonPanel1.Controls.Add(this.kryptonKnobControl1);
            this.kryptonPanel1.Controls.Add(this.kryptonScrollBar1);
            this.kryptonPanel1.Controls.Add(this.promptRoundedTextbox1);
            this.kryptonPanel1.Controls.Add(this.kpgControlDetails);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1068, 666);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonToggleSwitch1
            // 
            this.kryptonToggleSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonToggleSwitch1.BorderColour = System.Drawing.Color.LightGray;
            this.kryptonToggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonToggleSwitch1.DisabledBackColour = System.Drawing.Color.Red;
            this.kryptonToggleSwitch1.DisabledControlColour = System.Drawing.Color.LightGray;
            this.kryptonToggleSwitch1.EnabledBackColour = System.Drawing.Color.LightGreen;
            this.kryptonToggleSwitch1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonToggleSwitch1.GradientEndColour = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.kryptonToggleSwitch1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.kryptonToggleSwitch1.GradientStartColour = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kryptonToggleSwitch1.IsOn = true;
            this.kryptonToggleSwitch1.KnobColour = System.Drawing.Color.White;
            this.kryptonToggleSwitch1.Location = new System.Drawing.Point(336, 58);
            this.kryptonToggleSwitch1.Name = "kryptonToggleSwitch1";
            this.kryptonToggleSwitch1.OffText = "Off";
            this.kryptonToggleSwitch1.OnText = "On";
            this.kryptonToggleSwitch1.PenColour = System.Drawing.Color.LightGray;
            this.kryptonToggleSwitch1.Size = new System.Drawing.Size(178, 91);
            this.kryptonToggleSwitch1.TabIndex = 91;
            this.kryptonToggleSwitch1.Text = "kryptonToggleSwitch1";
            this.kryptonToggleSwitch1.TextDisabledForeColour = System.Drawing.Color.White;
            this.kryptonToggleSwitch1.TextEnabled = true;
            this.kryptonToggleSwitch1.TextEnabledForeColour = System.Drawing.Color.Gray;
            this.kryptonToggleSwitch1.UseGradientOnKnob = true;
            this.kryptonToggleSwitch1.Click += new System.EventHandler(this.kryptonToggleSwitch1_Click);
            // 
            // kryptonKnobControl1
            // 
            this.kryptonKnobControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonKnobControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kryptonKnobControl1.LargeChange = 20;
            this.kryptonKnobControl1.Location = new System.Drawing.Point(230, 188);
            this.kryptonKnobControl1.Maximum = 100;
            this.kryptonKnobControl1.Minimum = 0;
            this.kryptonKnobControl1.Name = "kryptonKnobControl1";
            this.kryptonKnobControl1.ShowLargeScale = true;
            this.kryptonKnobControl1.ShowSmallScale = false;
            this.kryptonKnobControl1.Size = new System.Drawing.Size(269, 300);
            this.kryptonKnobControl1.SizeLargeScaleMarker = 6;
            this.kryptonKnobControl1.SizeSmallScaleMarker = 3;
            this.kryptonKnobControl1.SmallChange = 5;
            this.kryptonKnobControl1.TabIndex = 90;
            this.kryptonKnobControl1.Value = 0;
            this.kryptonKnobControl1.Click += new System.EventHandler(this.kryptonKnobControl1_Click);
            // 
            // kryptonScrollBar1
            // 
            this.kryptonScrollBar1.Location = new System.Drawing.Point(12, 188);
            this.kryptonScrollBar1.Name = "kryptonScrollBar1";
            this.kryptonScrollBar1.Size = new System.Drawing.Size(19, 200);
            this.kryptonScrollBar1.TabIndex = 89;
            this.kryptonScrollBar1.Click += new System.EventHandler(this.kryptonScrollBar1_Click);
            // 
            // promptRoundedTextbox1
            // 
            this.promptRoundedTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.promptRoundedTextbox1.Brush = System.Drawing.Color.White;
            this.promptRoundedTextbox1.DrawPrompt = true;
            this.promptRoundedTextbox1.FocusSelect = true;
            this.promptRoundedTextbox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.promptRoundedTextbox1.ForeColor = System.Drawing.Color.DimGray;
            this.promptRoundedTextbox1.Location = new System.Drawing.Point(12, 12);
            this.promptRoundedTextbox1.Name = "promptRoundedTextbox1";
            this.promptRoundedTextbox1.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.promptRoundedTextbox1.PromptText = "123";
            this.promptRoundedTextbox1.PromptTypeface = new System.Drawing.Font("Segoe UI", 11F);
            this.promptRoundedTextbox1.Size = new System.Drawing.Size(318, 33);
            this.promptRoundedTextbox1.TabIndex = 88;
            this.promptRoundedTextbox1.Text = "promptRoundedTextbox1";
            this.promptRoundedTextbox1.Click += new System.EventHandler(this.promptRoundedTextbox1_Click);
            // 
            // kpgControlDetails
            // 
            this.kpgControlDetails.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgControlDetails.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kpgControlDetails.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgControlDetails.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpgControlDetails.Location = new System.Drawing.Point(653, 12);
            this.kpgControlDetails.Name = "kpgControlDetails";
            this.kpgControlDetails.Size = new System.Drawing.Size(403, 468);
            this.kpgControlDetails.TabIndex = 1;
            // 
            // PropertyGridTest
            // 
            this.ClientSize = new System.Drawing.Size(1068, 666);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "PropertyGridTest";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public PropertyGridTest()
        {
            InitializeComponent();
        }

        private void kryptonToggleSwitch1_Click(object sender, EventArgs e)
        {
            kpgControlDetails.SelectedObject = kryptonToggleSwitch1;
        }

        private void kryptonKnobControl1_Click(object sender, EventArgs e)
        {
            kpgControlDetails.SelectedObject = kryptonKnobControl1;
        }

        private void promptRoundedTextbox1_Click(object sender, EventArgs e)
        {
            kpgControlDetails.SelectedObject = promptRoundedTextbox1;
        }

        private void kryptonScrollBar1_Click(object sender, EventArgs e)
        {
            kpgControlDetails.SelectedObject = kryptonScrollBar1;
        }
    }
}