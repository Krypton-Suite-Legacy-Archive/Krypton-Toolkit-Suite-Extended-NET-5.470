#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common
{
    [ToolboxBitmap(typeof(RichTextBox)), ToolboxItem(false)]
    public partial class WatermarkedRichTextBox : RichTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion
        #endregion

        #region Members
        private string waterMarkTextField;
        private string originalTextField;
        private Font waterMarkFontField;
        private Font originalFontField;
        private Color waterMarkFontColorField = Color.LightBlue;
        private bool waterMarkedField;
        private bool watermarkUsePaletteFontColorField = false;
        #endregion

        #region Constructor

        // Constructor
        public WatermarkedRichTextBox()
        {
            InitializeComponent();

            // set the watermark font (standard: italic)
            this.originalFontField = base.Font;
            this.waterMarkFontField = new Font(base.Font, FontStyle.Italic);
        }

        #endregion

        #region Overrides

        // if the text changes, we need to set the originalText
        protected override void OnTextChanged(EventArgs e)
        {
            this.originalTextField = base.Text;
            base.OnTextChanged(e);
        }

        // the control gets the focus
        protected override void OnGotFocus(EventArgs e)
        {
            // clear the text of the controls, IF the text IS the watermark-text
            syncupText(true);
            base.OnGotFocus(e);
        }

        // the control loses the focus
        protected override void OnLostFocus(EventArgs e)
        {
            // insert the watermark-text, IF the control is empty
            syncupText(false);
            base.OnLostFocus(e);
        }

        #endregion

        #region Private Methods

        // sync the text, if the control gets or loses the focus
        private void syncupText(bool focused)
        {
            if (focused)
            {
                // get focus >> if the text is the watermark-text, then clear it!
                if (this.waterMarkedField)
                {
                    this.waterMarkedField = false;
                    base.Text = "";
                    base.Font = this.originalFontField;
                }
            }
            else
            {
                // lose focus >> if the control is empty, then insert the watermark
                if (String.IsNullOrEmpty(base.Text))
                {
                    // set watermark-flag
                    this.waterMarkedField = true;

                    // set the watermark-text
                    base.Text = this.waterMarkTextField;
                    base.Font = this.waterMarkFontField;

                    // set the font
                    setWaterMarkFont();
                }
            }
        }

        // apply the watermark-font
        private void setWaterMarkFont()
        {
            // select the text of the control (has to be the watermark-text)
            base.SelectAll();

            // set the font for the selection
            base.SelectionFont = this.waterMarkFontField;

            // set the font-color
            if (!this.watermarkUsePaletteFontColorField)
            {
                // use the font specified by the user/developer
                base.SelectionColor = this.waterMarkFontColorField;
            }
            else
            {
                // if the color isn't set, use a color relative to the palette
                // --> probably not the best way to get a color, but certainly worth a try
                //base.SelectionColor = base.StateCommon.Border.GetBorderColor1(PaletteState.Normal);
            }

            // reset the selection
            base.SelectionStart = 0;
            base.SelectionLength = 0;
        }

        // reset the watermark
        private void resetWaterMark()
        {
            base.Text = "";
            syncupText(false);
        }

        #endregion

        #region Properties

        // overridden Text-Property
        public override string Text
        {
            get
            {
                // if the control is watermarked, there is no text to return - even if the control has some watermark-text inserted
                return (this.waterMarkedField ? String.Empty : base.Text);
            }
            set
            {
                // if the value is empty, then show the watermark
                if (String.IsNullOrEmpty(value))
                {
                    base.Text = value;
                    syncupText(this.Focused);
                }
                else
                {
                    // if there is some text to show, reset the watermark and set the text
                    resetWaterMark();
                    syncupText(true);
                    base.Text = value;
                    base.Font = originalFontField;
                }
            }
        }

        /// <summary>
        /// This watermark will appear if the control loses the focus and has no Text
        /// </summary>
        [Category("Appearance-Extended")]
        public string WaterMarkText
        {
            get { return this.waterMarkTextField; }
            set
            {
                // set the property and refresh the control
                this.waterMarkTextField = value;
                resetWaterMark();
            }
        }

        /// <summary>
        /// The font, the watermark will be displayed with
        /// </summary>
        [Category("Appearance-Extended")]
        [Browsable(true)]
        public Font WaterMarkFont
        {
            get { return this.waterMarkFontField; }
            set
            {
                // set the property and refresh the control
                this.waterMarkFontField = value;
                resetWaterMark();
            }
        }

        /// <summary>
        /// The color, the watermark will be displayed with
        /// </summary>
        [Category("Appearance-Extended")]
        [Browsable(true)]
        public Color WaterMarkFontColour
        {
            get { return this.waterMarkFontColorField; }
            set
            {
                // set the property and refresh the control
                this.waterMarkFontColorField = value;
                resetWaterMark();
            }
        }

        /// <summary>
        /// If set, the font-color watermark will be relative to the used palette
        /// </summary>
        [Category("Appearance-Extended")]
        [Browsable(true)]
        public bool WaterMarkUsePaletteFontColour
        {
            get { return this.watermarkUsePaletteFontColorField; }
            set
            {
                // set the property and refresh the control
                this.watermarkUsePaletteFontColorField = value;
                setWaterMarkFont();
            }
        }

        #endregion
    }
}