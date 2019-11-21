//--------------------------------------------------------------------------------
// Copyright (C) 2013-2015 JDH Software - <support@jdhsoftware.com>
//
// This program is provided to you under the terms of the Microsoft Public
// License (Ms-PL) as published at https://kryptonoutlookgrid.codeplex.com/license
//
// Visit http://www.jdhsoftware.com and follow @jdhsoftware on Twitter
//
//--------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

using KryptonOutlookGrid.Utilities.Language;

namespace KryptonOutlookGrid.Formatting
{
    public partial class CustomFormatRule : KryptonForm
    {
        /// <summary>
        /// The colours
        /// </summary>
        public Color colMin, colMedium, colMax;

        /// <summary>
        /// The Conditional Formatting type
        /// </summary>
        public EnumConditionalFormatType mode;

        private void CustomFormatRule_Load(object sender, EventArgs e)
        {
            kcolMin.SelectedColor = colMin;

            kcolMed.SelectedColor = colMedium;

            kcolMax.SelectedColor = colMax;

            int selectedIndex = -1;

            string[] names = Enum.GetNames(typeof(EnumConditionalFormatType));

            for (int i = 0; i < names.Length; i++)
            {
                if (mode.ToString().Equals(names[i]))
                {
                    selectedIndex = i;
                }

                kcmbFormat.Items.Add(new KryptonListItem(LanguageManager.Instance.GetStringGB(names[i])) { Tag = names[i] });
            }

            kcmbFormat.SelectedIndex = selectedIndex;
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void pbxPreview_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            switch (mode)
            {
                case EnumConditionalFormatType.TWOCOLOURSRANGE:
                    // Draw the background gradient.
                    using (LinearGradientBrush lgbr = new LinearGradientBrush(e.ClipRectangle, colMin, colMax, LinearGradientMode.Horizontal))
                    {
                        e.Graphics.FillRectangle(lgbr, e.ClipRectangle);
                    }
                    break;
                case EnumConditionalFormatType.THREECOLOURSRANGE:
                    // Draw the background gradient.
                    using (LinearGradientBrush lgbr = new LinearGradientBrush(e.ClipRectangle, colMin, colMax, LinearGradientMode.Horizontal))
                    {
                        ColorBlend colourBlend = new ColorBlend();

                        colourBlend.Colors = new Color[] { colMin, colMedium, colMax };

                        colourBlend.Positions = new float[] { 0f, 0.5f, 1.0f };

                        lgbr.InterpolationColors = colourBlend;

                        e.Graphics.FillRectangle(lgbr, e.ClipRectangle);
                    }
                    break;
                case EnumConditionalFormatType.BAR:
                    if (gradient)
                    {
                        using (LinearGradientBrush lgbr = new LinearGradientBrush(e.ClipRectangle, colMin, Color.White, LinearGradientMode.Horizontal))
                        {
                            e.Graphics.FillRectangle(lgbr, e.ClipRectangle);
                        }
                    }
                    else
                    {
                        using (SolidBrush sbr = new SolidBrush(colMin))
                        {
                            e.Graphics.FillRectangle(sbr, e.ClipRectangle);
                        }
                    }
                    using (Pen pen = new Pen(colMin)) //Color.FromArgb(255, 140, 197, 66)))
                    {
                        Rectangle rect = e.ClipRectangle;
                        rect.Inflate(-1, -1);
                        e.Graphics.DrawRectangle(pen, rect);
                    }
                    break;
                default:
                    break;
            }
        }

        private void kcolMin_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            colMin = kcolMin.SelectedColor;

            pbxPreview.Invalidate();
        }

        private void kcolMed_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            colMedium = kcolMed.SelectedColor;

            pbxPreview.Invalidate();
        }

        private void kcolMax_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            colMax = kcolMax.SelectedColor;

            pbxPreview.Invalidate();
        }

        private void kcmbFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            gradient = kcmbFill.SelectedIndex == 1;

            UpdateUI();
        }

        private void kcmbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = (EnumConditionalFormatType)Enum.Parse(typeof(EnumConditionalFormatType), ((KryptonListItem)kcmbFill.Items[kcmbFill.SelectedIndex]).Tag.ToString());

            UpdateUI();
        }

        /// <summary>
        /// Gradient boolean
        /// </summary>
        public bool gradient;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormatRule"/> class.
        /// </summary>
        /// <param name="initialmode">The  Conditional Formatting type.</param>
        public CustomFormatRule(EnumConditionalFormatType initialmode)
        {
            InitializeComponent();

            kcmbFill.SelectedIndex = 0;

            kcmbFormat.SelectedIndex = -1;

            mode = initialmode;

            colMin = Color.FromArgb(84, 179, 112);

            colMedium = Color.FromArgb(252, 229, 130);

            colMax = Color.FromArgb(243, 120, 97);
        }

        private void UpdateUI()
        {
            switch (mode)
            {
                case EnumConditionalFormatType.TWOCOLOURSRANGE:
                    klblFill.Enabled = true;

                    kcmbFill.Enabled = true;

                    kcolMin.Enabled = true;

                    kcolMed.Enabled = false;

                    kcolMax.Enabled = true;
                    break;
                case EnumConditionalFormatType.THREECOLOURSRANGE:
                    klblFill.Enabled = false;

                    kcmbFill.Enabled = false;

                    kcolMin.Enabled = true;

                    kcolMed.Enabled = true;

                    kcolMax.Enabled = true;
                    break;
                case EnumConditionalFormatType.BAR:
                    klblFill.Enabled = true;

                    kcmbFill.Enabled = true;

                    kcmbFormat.Enabled = true;

                    kcolMin.Enabled = true;

                    kcolMed.Enabled = false;

                    kcolMax.Enabled = false;
                    break;
                default:
                    break;
            }

            pbxPreview.Invalidate();
        }
    }
}
