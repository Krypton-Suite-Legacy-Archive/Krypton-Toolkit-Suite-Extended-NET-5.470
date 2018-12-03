using ExtendedControls.Base.Code.Colours;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Colours
{
    public partial class CustomColourEditorUserControl : UserControl
    {
        #region System

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomColourEditorUserControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bControl = new KryptonExtendedNumericUpDownControl();
            this.gControl = new KryptonExtendedNumericUpDownControl();
            this.rControl = new KryptonExtendedNumericUpDownControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lControl = new KryptonExtendedNumericUpDownControl();
            this.sControl = new KryptonExtendedNumericUpDownControl();
            this.hControl = new KryptonExtendedNumericUpDownControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.htmlTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.currentColorPanel = new System.Windows.Forms.Panel();
            this.colourControl = new ColourAreaAndSliderUserControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rControl)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hControl)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.bControl);
            this.groupBox1.Controls.Add(this.gControl);
            this.groupBox1.Controls.Add(this.rControl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // bControl
            // 
            resources.ApplyResources(this.bControl, "bControl");
            this.bControl.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bControl.Name = "bControl";
            this.bControl.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bControl.ValueChanged += new System.EventHandler(this.BControl_ValueChanged);
            // 
            // gControl
            // 
            resources.ApplyResources(this.gControl, "gControl");
            this.gControl.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gControl.Name = "gControl";
            this.gControl.ValueChanged += new System.EventHandler(this.GControl_ValueChanged);
            // 
            // rControl
            // 
            resources.ApplyResources(this.rControl, "rControl");
            this.rControl.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rControl.Name = "rControl";
            this.rControl.ValueChanged += new System.EventHandler(this.RControl_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.lControl);
            this.groupBox2.Controls.Add(this.sControl);
            this.groupBox2.Controls.Add(this.hControl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lControl
            // 
            resources.ApplyResources(this.lControl, "lControl");
            this.lControl.Name = "lControl";
            this.lControl.ValueChanged += new System.EventHandler(this.LControl_ValueChanged);
            // 
            // sControl
            // 
            resources.ApplyResources(this.sControl, "sControl");
            this.sControl.Name = "sControl";
            this.sControl.ValueChanged += new System.EventHandler(this.SControl_ValueChanged);
            // 
            // hControl
            // 
            resources.ApplyResources(this.hControl, "hControl");
            this.hControl.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.hControl.Name = "hControl";
            this.hControl.ValueChanged += new System.EventHandler(this.HControl_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // htmlTextBox
            // 
            resources.ApplyResources(this.htmlTextBox, "htmlTextBox");
            this.htmlTextBox.Name = "htmlTextBox";
            this.htmlTextBox.TextChanged += new System.EventHandler(this.HTMLTextBox_TextChanged);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.htmlTextBox);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // currentColorPanel
            // 
            resources.ApplyResources(this.currentColorPanel, "currentColorPanel");
            this.currentColorPanel.Name = "currentColorPanel";
            // 
            // colorControl
            // 
            resources.ApplyResources(this.colourControl, "colourControl");
            this.colourControl.Name = "colourControl";
            this.colourControl.SelectedColour = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colourControl.ColorChanged += new System.EventHandler(this.ColourControl_ColourChanged);
            this.colourControl.ValueChangedByUser += new System.EventHandler(this.ColourControl_ValueChangedByUser);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.currentColorPanel);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // CustomColorEditorUserControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colourControl);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomColorEditorUserControl";
            this.Load += new System.EventHandler(this.CustomColourEditorUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rControl)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hControl)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private KryptonExtendedNumericUpDownControl rControl;
        private KryptonExtendedNumericUpDownControl bControl;
        private KryptonExtendedNumericUpDownControl gControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private KryptonExtendedNumericUpDownControl lControl;
        private KryptonExtendedNumericUpDownControl sControl;
        private KryptonExtendedNumericUpDownControl hControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox htmlTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel currentColorPanel;
        private ColourAreaAndSliderUserControl colourControl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;

        #endregion

        /// <summary>
		/// To get rid of rounding inaccuracies etc.
		/// </summary>
		private enum LeadingInputElement
        {
            UNKNOWN,
            COLOURAREAANDSLIDER,
            RGBINPUT,
            HSLINPUT,
            HTMLINPUT
        }

        private bool _ignoreTextFieldChange;
        private bool _ignoreColourChangeEvents;

        private Control _changingControl;

        private LeadingInputElement _currentLeadingInputElement =
            LeadingInputElement.UNKNOWN;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColourEditorUserControl"/> class.
        /// </summary>
        public CustomColourEditorUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the <see cref="CustomColourEditorUserControl"/> control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance 
        /// containing the event data.</param>
        private void CustomColourEditorUserControl_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the ColorChanged event of the colorSliderControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance 
        /// containing the event data.</param>
        private void ColourControl_ColourChanged(object sender, EventArgs e)
        {
            if (!_ignoreColourChangeEvents)
            {
                UpdateTextFields();

                if (NeedUpdateUI != null)
                {
                    NeedUpdateUI(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Occurs when the parent needs to update command states.
        /// </summary>
        public event EventHandler NeedUpdateUI;

        /// <summary>
        /// Updates the text fields.
        /// </summary>
        private void UpdateTextFields()
        {
            _ignoreTextFieldChange = true;
            try
            {
                currentColorPanel.BackColor = colourControl.SelectedColour;

                var colour = colourControl.SelectedColour;

                var hslColour = HSLColour.FromColour(colour);

                if (_currentLeadingInputElement != LeadingInputElement.HTMLINPUT)
                {
                    if (_changingControl != htmlTextBox)
                    {
                        htmlTextBox.Text = ToHTML(colour);
                    }
                }

                if (_currentLeadingInputElement != LeadingInputElement.RGBINPUT)
                {
                    if (_changingControl != rControl)
                    {
                        rControl.Value = colour.R;
                    }
                    if (_changingControl != gControl)
                    {
                        gControl.Value = colour.G;
                    }
                    if (_changingControl != bControl)
                    {
                        bControl.Value = colour.B;
                    }
                }

                if (_currentLeadingInputElement != LeadingInputElement.HSLINPUT)
                {
                    if (_changingControl != hControl)
                    {
                        hControl.Value = (decimal)hslColour.PreciseHue;
                    }
                    if (_changingControl != sControl)
                    {
                        sControl.Value = (decimal)hslColour.PreciseSaturation;
                    }
                    if (_changingControl != lControl)
                    {
                        lControl.Value = (decimal)hslColour.PreciseLight;
                    }
                }
            }
            finally
            {
                _ignoreTextFieldChange = false;
            }
        }

        private static string ToHTML(Color colour)
        {
            return string.Format(@"#{0:X2}{1:X2}{2:X2}", colour.R, colour.G, colour.B);
        }

        private void SetColour(HSLColour colour)
        {
            SetColour(colour.ToRGBColour());
        }

        private void SetColour(RGBColour colour)
        {
            Color c = colour.ToColour();
            colourControl.SelectedColour = c;

            if (NeedUpdateUI != null)
            {
                NeedUpdateUI(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the selected color.
        /// </summary>
        /// <value>The color of the selected.</value>
        [Browsable(false)]
        public Color SelectedColour
        {
            get
            {
                if (DesignMode)
                {
                    return Color.Empty;
                }
                else
                {
                    switch (_currentLeadingInputElement)
                    {
                        case LeadingInputElement.HTMLINPUT:
                            {
                                string html = htmlTextBox.Text.Trim('#', ' ');

                                if (html.Length == 6)
                                {
                                    return RGBColour.FromColour(ColorTranslator.FromHtml(@"#" + html)).ToColour();
                                }
                                else
                                {
                                    // Fallback.
                                    return colourControl.SelectedColour;
                                }
                            }

                        case LeadingInputElement.COLOURAREAANDSLIDER:
                            {
                                return colourControl.SelectedColour;
                            }

                        case LeadingInputElement.HSLINPUT:
                            {
                                return new HSLColour((double)hControl.Value, (double)sControl.Value, (double)lControl.Value).ToColour();
                            }

                        default:
                            {
                                return new RGBColour((int)rControl.Value, (int)gControl.Value, (int)bControl.Value).ToColour();
                            }
                    }
                }
            }
            set
            {
                if (!DesignMode)
                {
                    _ignoreTextFieldChange = true;
                    _ignoreColourChangeEvents = true;
                    try
                    {
                        HSLColour hslColour = HSLColour.FromColour(value);

                        rControl.Value = value.R;
                        gControl.Value = value.G;
                        bControl.Value = value.B;

                        hControl.Value = (decimal)hslColour.PreciseHue;
                        sControl.Value = (decimal)hslColour.PreciseSaturation;
                        lControl.Value = (decimal)hslColour.PreciseLight;

                        htmlTextBox.Text = ToHTML(value);
                        currentColorPanel.BackColor = value;

                        SetColour(RGBColour.FromColour(value));
                    }
                    finally
                    {
                        _ignoreColourChangeEvents = false;
                        _ignoreTextFieldChange = false;
                    }

                    if (NeedUpdateUI != null)
                    {
                        NeedUpdateUI(this, EventArgs.Empty);
                    }

                    //	setColor( RgbColor.FromColor( value ) );
                }
            }
        }

        private void RControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreTextFieldChange)
            {
                if (rControl.Value >= 0 && rControl.Value <= 255)
                {
                    _changingControl = (Control)sender;
                    NotifyValueChangedByUser(LeadingInputElement.RGBINPUT);

                    SetColour(new RGBColour((int)rControl.Value, (int)gControl.Value, (int)bControl.Value));

                    _changingControl = null;
                }
            }
        }

        private void GControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreTextFieldChange)
            {
                if (gControl.Value >= 0 && gControl.Value <= 255)
                {
                    _changingControl = (Control)sender;
                    NotifyValueChangedByUser(LeadingInputElement.RGBINPUT);

                    SetColour(new RGBColour((int)rControl.Value, (int)gControl.Value, (int)bControl.Value));

                    _changingControl = null;
                }
            }
        }

        private void BControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreTextFieldChange)
            {
                if (bControl.Value >= 0 && bControl.Value <= 255)
                {
                    _changingControl = (Control)sender;
                    NotifyValueChangedByUser(LeadingInputElement.RGBINPUT);

                    SetColour(new RGBColour((int)rControl.Value, (int)gControl.Value, (int)bControl.Value));

                    _changingControl = null;
                }
            }
        }

        private void HControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreTextFieldChange)
            {
                if (hControl.Value >= 0 && hControl.Value <= 360)
                {
                    _changingControl = (Control)sender;
                    NotifyValueChangedByUser(LeadingInputElement.HSLINPUT);

                    SetColour(new HSLColour((double)hControl.Value, (double)sControl.Value, (double)lControl.Value));

                    _changingControl = null;
                }
            }
        }

        private void SControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreTextFieldChange)
            {
                if (sControl.Value >= 0 && sControl.Value <= 100)
                {
                    _changingControl = (Control)sender;
                    NotifyValueChangedByUser(LeadingInputElement.HSLINPUT);

                    SetColour(new HSLColour((double)hControl.Value, (double)sControl.Value, (double)lControl.Value));

                    _changingControl = null;
                }
            }
        }

        private void LControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreTextFieldChange)
            {
                if (lControl.Value >= 0 && lControl.Value <= 100)
                {
                    _changingControl = (Control)sender;
                    NotifyValueChangedByUser(LeadingInputElement.HSLINPUT);

                    SetColour(new HSLColour((double)hControl.Value, (double)sControl.Value, (double)lControl.Value));

                    _changingControl = null;
                }
            }
        }

        private void HTMLTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!_ignoreTextFieldChange)
            {
                string html = htmlTextBox.Text.Trim('#', ' ');

                if (html.Length == 6)
                {
                    _changingControl = (Control)sender;
                    NotifyValueChangedByUser(LeadingInputElement.HTMLINPUT);

                    SetColour(RGBColour.FromColour(ColorTranslator.FromHtml(@"#" + html)));
                    _changingControl = null;
                }
            }
        }

        private void ColourControl_ValueChangedByUser(object sender, EventArgs e)
        {
            NotifyValueChangedByUser(LeadingInputElement.COLOURAREAANDSLIDER);
        }

        /// <summary>
        /// Notifies that the value has been changed by the user.
        /// </summary>
        /// <param name="inputElement">The input element.</param>
        private void NotifyValueChangedByUser(LeadingInputElement inputElement)
        {
            _currentLeadingInputElement = inputElement;
        }
    }
}