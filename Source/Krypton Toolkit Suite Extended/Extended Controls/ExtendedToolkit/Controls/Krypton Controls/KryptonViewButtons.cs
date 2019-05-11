#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.ComponentModel;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [ToolboxItem(true)]
    [System.Drawing.ToolboxBitmap(typeof(Button))]
    public partial class KryptonViewButtons : UserControl
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
            this.components = new System.ComponentModel.Container();
            this.kcmdpercentage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcmdmiddleright = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kcmdmiddleleft = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kcheckset = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            this.kcmdleft = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kcmdright = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.SuspendLayout();
            // 
            // kcmdpercentage
            // 
            this.kcmdpercentage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kcmdpercentage.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.kcmdpercentage.Location = new System.Drawing.Point(77, 0);
            this.kcmdpercentage.Name = "kcmdpercentage";
            this.kcmdpercentage.Size = new System.Drawing.Size(40, 18);
            this.kcmdpercentage.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-4);
            this.kcmdpercentage.TabIndex = 14;
            this.kcmdpercentage.Text = "100%";
            this.kcmdpercentage.Values.ExtraText = "";
            this.kcmdpercentage.Values.Image = null;
            this.kcmdpercentage.Values.ImageStates.ImageCheckedNormal = null;
            this.kcmdpercentage.Values.ImageStates.ImageCheckedPressed = null;
            this.kcmdpercentage.Values.ImageStates.ImageCheckedTracking = null;
            this.kcmdpercentage.Values.Text = "100%";
            // 
            // kcmdmiddleright
            // 
            this.kcmdmiddleright.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kcmdmiddleright.Location = new System.Drawing.Point(37, 0);
            this.kcmdmiddleright.Name = "kcmdmiddleright";
            this.kcmdmiddleright.Size = new System.Drawing.Size(17, 18);
            this.kcmdmiddleright.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.kcmdmiddleright.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-2, -3, -4, -4);
            this.kcmdmiddleright.TabIndex = 13;
            this.kcmdmiddleright.Values.ExtraText = "";
            this.kcmdmiddleright.Values.Image = null;
            this.kcmdmiddleright.Values.Text = "";
            // 
            // kcmdmiddleleft
            // 
            this.kcmdmiddleleft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kcmdmiddleleft.Location = new System.Drawing.Point(19, 0);
            this.kcmdmiddleleft.Name = "kcmdmiddleleft";
            this.kcmdmiddleleft.Size = new System.Drawing.Size(17, 18);
            this.kcmdmiddleleft.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.kcmdmiddleleft.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-2, -3, -4, -4);
            this.kcmdmiddleleft.TabIndex = 12;
            this.kcmdmiddleleft.Values.ExtraText = "";
            this.kcmdmiddleleft.Values.Image = null;
            this.kcmdmiddleleft.Values.Text = "";
            // 
            // kcheckset
            // 
            this.kcheckset.AllowUncheck = true;
            this.kcheckset.CheckButtons.Add(this.kcmdmiddleright);
            this.kcheckset.CheckButtons.Add(this.kcmdmiddleleft);
            this.kcheckset.CheckButtons.Add(this.kcmdleft);
            this.kcheckset.CheckButtons.Add(this.kcmdright);
            this.kcheckset.CheckedButton = this.kcmdright;
            // 
            // kcmdleft
            // 
            this.kcmdleft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kcmdleft.Location = new System.Drawing.Point(0, 0);
            this.kcmdleft.Name = "kcmdleft";
            this.kcmdleft.Size = new System.Drawing.Size(18, 18);
            this.kcmdleft.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.kcmdleft.TabIndex = 11;
            this.kcmdleft.Values.ExtraText = "";
            this.kcmdleft.Values.Image = null;
            this.kcmdleft.Values.Text = "";
            // 
            // kcmdright
            // 
            this.kcmdright.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kcmdright.Checked = true;
            this.kcmdright.Location = new System.Drawing.Point(55, 0);
            this.kcmdright.Name = "kcmdright";
            this.kcmdright.Size = new System.Drawing.Size(18, 18);
            this.kcmdright.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kcmdright.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-2, -3, -4, -4);
            this.kcmdright.TabIndex = 10;
            this.kcmdright.Values.ExtraText = "";
            this.kcmdright.Values.Image = null;
            this.kcmdright.Values.Text = "";
            // 
            // KryptonViewButtons
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kcmdpercentage);
            this.Controls.Add(this.kcmdmiddleright);
            this.Controls.Add(this.kcmdmiddleleft);
            this.Controls.Add(this.kcmdleft);
            this.Controls.Add(this.kcmdright);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "KryptonViewButtons";
            this.Size = new System.Drawing.Size(117, 18);
            this.ResumeLayout(false);

        }

        #endregion

        internal ComponentFactory.Krypton.Toolkit.KryptonCheckSet kcheckset;
        public ComponentFactory.Krypton.Toolkit.KryptonButton kcmdpercentage;
        public ComponentFactory.Krypton.Toolkit.KryptonCheckButton kcmdmiddleright;
        public ComponentFactory.Krypton.Toolkit.KryptonCheckButton kcmdmiddleleft;
        public ComponentFactory.Krypton.Toolkit.KryptonCheckButton kcmdleft;
        public ComponentFactory.Krypton.Toolkit.KryptonCheckButton kcmdright;
        #endregion

        private string _percentageLabel = "100%";
        [Category("ViewButtons"), DefaultValue(typeof(string), "100%")]
        public string PercentageLabel
        {
            get { return _percentageLabel; }
            set
            {
                this.kcmdpercentage.Text = value;
                _percentageLabel = value;
                Invalidate();
            }
        }


        public KryptonViewButtons()
        {
            InitializeComponent();
            //(1) To remove flicker we use double buffering for drawing
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);

            //Set Back Color
            this.BackColor = System.Drawing.Color.Transparent;

            //Set Label Text
            this.kcmdpercentage.Text = _percentageLabel;
        }
    }
}