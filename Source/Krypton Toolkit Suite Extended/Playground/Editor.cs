#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;

namespace Playground
{
    public class Editor : KryptonForm
    {
        private ExtendedControls.ExtendedToolkit.Controls.Charting.KryptonLxLedControl kryptonLxLedControl1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel kryptonBorderedLabel1;
        private KryptonToolkitSuiteExtendedCore.Components.Controls.KryptonSplitButton kryptonSplitButton1;
        #region Designer Code

        private void InitializeComponent()
        {
            this.kryptonSplitButton1 = new KryptonToolkitSuiteExtendedCore.Components.Controls.KryptonSplitButton();
            this.kryptonLxLedControl1 = new ExtendedControls.ExtendedToolkit.Controls.Charting.KryptonLxLedControl();
            this.kryptonBorderedLabel1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLxLedControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonSplitButton1
            // 
            this.kryptonSplitButton1.AutoSize = true;
            this.kryptonSplitButton1.CornerRadius = 15;
            this.kryptonSplitButton1.Image = null;
            this.kryptonSplitButton1.Location = new System.Drawing.Point(12, 12);
            this.kryptonSplitButton1.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonSplitButton1.Name = "kryptonSplitButton1";
            this.kryptonSplitButton1.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonSplitButton1.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonSplitButton1.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonSplitButton1.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonSplitButton1.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonSplitButton1.ShowSplitOption = true;
            this.kryptonSplitButton1.Size = new System.Drawing.Size(293, 38);
            this.kryptonSplitButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSplitButton1.StateCommon.Border.Rounding = 15;
            this.kryptonSplitButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonSplitButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonSplitButton1.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonSplitButton1.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonSplitButton1.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonSplitButton1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonSplitButton1.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonSplitButton1.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonSplitButton1.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonSplitButton1.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonSplitButton1.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonSplitButton1.TabIndex = 0;
            this.kryptonSplitButton1.Values.Text = "kryptonSplitButton1";
            // 
            // kryptonLxLedControl1
            // 
            this.kryptonLxLedControl1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonLxLedControl1.BackColour_1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kryptonLxLedControl1.BackColour_2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kryptonLxLedControl1.BevelRate = 0.5F;
            this.kryptonLxLedControl1.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.kryptonLxLedControl1.FadedColour = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.kryptonLxLedControl1.FocusedBorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.kryptonLxLedControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonLxLedControl1.HighlightOpaque = ((byte)(75));
            this.kryptonLxLedControl1.Location = new System.Drawing.Point(585, 238);
            this.kryptonLxLedControl1.Name = "kryptonLxLedControl1";
            this.kryptonLxLedControl1.Size = new System.Drawing.Size(444, 182);
            this.kryptonLxLedControl1.TabIndex = 1;
            this.kryptonLxLedControl1.Text = "08:00";
            // 
            // kryptonBorderedLabel1
            // 
            this.kryptonBorderedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonBorderedLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(214)))));
            this.kryptonBorderedLabel1.Location = new System.Drawing.Point(618, 155);
            this.kryptonBorderedLabel1.Name = "kryptonBorderedLabel1";
            this.kryptonBorderedLabel1.Size = new System.Drawing.Size(139, 20);
            this.kryptonBorderedLabel1.TabIndex = 2;
            this.kryptonBorderedLabel1.Values.Text = "kryptonBorderedLabel1";
            // 
            // Editor
            // 
            this.ClientSize = new System.Drawing.Size(1410, 690);
            this.Controls.Add(this.kryptonBorderedLabel1);
            this.Controls.Add(this.kryptonLxLedControl1);
            this.Controls.Add(this.kryptonSplitButton1);
            this.Name = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLxLedControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public Editor()
        {
            InitializeComponent();
        }
    }
}