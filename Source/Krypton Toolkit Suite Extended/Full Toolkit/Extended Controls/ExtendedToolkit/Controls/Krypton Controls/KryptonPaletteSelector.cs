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
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    public class KryptonPaletteSelector : UserControl
    {
        #region Designer Code
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnApplyTheme;
        private KryptonManager kryptonManager1;
        private System.ComponentModel.IContainer components;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbSelection;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblPaletteStyle;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.klblPaletteStyle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnApplyTheme = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kcmbSelection = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // klblPaletteStyle
            // 
            this.klblPaletteStyle.Location = new System.Drawing.Point(16, 13);
            this.klblPaletteStyle.Name = "klblPaletteStyle";
            this.klblPaletteStyle.Size = new System.Drawing.Size(154, 24);
            this.klblPaletteStyle.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblPaletteStyle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblPaletteStyle.TabIndex = 0;
            this.klblPaletteStyle.Values.Text = "Select Palette Style:";
            // 
            // kbtnApplyTheme
            // 
            this.kbtnApplyTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnApplyTheme.Enabled = false;
            this.kbtnApplyTheme.Location = new System.Drawing.Point(383, 13);
            this.kbtnApplyTheme.Name = "kbtnApplyTheme";
            this.kbtnApplyTheme.Size = new System.Drawing.Size(90, 25);
            this.kbtnApplyTheme.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApplyTheme.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApplyTheme.TabIndex = 2;
            this.kbtnApplyTheme.Values.Text = "&Apply";
            this.kbtnApplyTheme.Click += new System.EventHandler(this.kbtnApplyTheme_Click);
            // 
            // kcmbSelection
            // 
            this.kcmbSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kcmbSelection.DropDownWidth = 255;
            this.kcmbSelection.Location = new System.Drawing.Point(166, 13);
            this.kcmbSelection.Name = "kcmbSelection";
            this.kcmbSelection.Size = new System.Drawing.Size(211, 25);
            this.kcmbSelection.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbSelection.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbSelection.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbSelection.TabIndex = 3;
            this.kcmbSelection.SelectedIndexChanged += new System.EventHandler(this.kcmbSelection_SelectedIndexChanged);
            // 
            // KryptonPaletteSelector
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kcmbSelection);
            this.Controls.Add(this.kbtnApplyTheme);
            this.Controls.Add(this.klblPaletteStyle);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KryptonPaletteSelector";
            this.Size = new System.Drawing.Size(492, 54);
            this.Load += new System.EventHandler(this.KryptonPaletteSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Variables
        private ArrayList _styles = new ArrayList();
        private KryptonManager _hostManager;
        private Font _labelTypeface;
        #endregion

        #region Properties
        public KryptonManager ParentKryptonManager { get => _hostManager; set => _hostManager = value; }

        public Font LabelTypeface { get => _labelTypeface; set => _labelTypeface = value; }
        #endregion

        #region Constructors
        public KryptonPaletteSelector()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);

            DoubleBuffered = true;

            LabelTypeface = new Font("Segoe UI", 10f, FontStyle.Bold);
        }
        #endregion

        private void KryptonPaletteSelector_Load(object sender, EventArgs e)
        {
            PropagateStylesArray(_styles);

            if (ParentKryptonManager != null)
            {
                ParentKryptonManager = new KryptonManager();

                kcmbSelection.Text = ParentKryptonManager.GlobalPaletteMode.ToString();
            }

            if (_styles.Count != 0)
            {
                foreach (string style in _styles)
                {
                    kcmbSelection.Items.Add(style);

                    kcmbSelection.AutoCompleteCustomSource.Add(style);
                }
            }

            kcmbSelection.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void kbtnApplyTheme_Click(object sender, EventArgs e)
        {
            SwitchThemeStyle(GetPaletteMode(kcmbSelection.Text), new KryptonManager());

            kbtnApplyTheme.Enabled = false;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            klblPaletteStyle.StateCommon.LongText.Font = LabelTypeface;

            klblPaletteStyle.StateCommon.ShortText.Font = LabelTypeface;

            kcmbSelection.StateCommon.ComboBox.Content.Font = Font;

            kcmbSelection.StateCommon.Item.Content.LongText.Font = Font;

            kcmbSelection.StateCommon.Item.Content.ShortText.Font = Font;

            kbtnApplyTheme.StateCommon.Content.LongText.Font = Font;

            kbtnApplyTheme.StateCommon.Content.ShortText.Font = Font;

            base.OnFontChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            EventArgs args = null;

            OnFontChanged(args);

            base.OnPaint(e);
        }

        #region Methods
        private void PropagateStylesArray(ArrayList list = null)
        {
            if (list == null)
            {
                throw new ArgumentNullException();
            }

            list.Add("Professional - System");

            list.Add("Professional - Office 2003");

            list.Add("Office 2007 - Black");

            list.Add("Office 2007 - Blue");

            list.Add("Office 2007 - Silver");

            list.Add("Office 2007 - White");

            list.Add("Office 2010 - Black");

            list.Add("Office 2010 - Blue");

            list.Add("Office 2010 - Silver");

            list.Add("Office 2010 - White");

            list.Add("Office 2013");

            list.Add("Office 2013 - White");

            list.Add("Office 365 - Black");

            list.Add("Office 365 - Blue");

            list.Add("Office 365 - Silver");

            list.Add("Office 365 - White");

            list.Add("Sparkle - Blue");

            list.Add("Sparkle - Orange");

            list.Add("Sparkle - Purple");

            list.Add("Custom");

            //list.Sort()
        }

        public static string GetCurrentStyleItemText()
        {
            KryptonPaletteSelector paletteSelector = new KryptonPaletteSelector();

            return paletteSelector.kcmbSelection.Text;
        }

        public static void SwitchThemeStyle(PaletteMode mode, KryptonManager manager)
        {
            switch (mode)
            {
                case PaletteMode.Global:
                    manager.GlobalPaletteMode = (PaletteModeManager)PaletteMode.Global;
                    break;
                case PaletteMode.ProfessionalSystem:
                    manager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                    break;
                case PaletteMode.ProfessionalOffice2003:
                    manager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
                    break;
                case PaletteMode.Office2007Blue:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                    break;
                case PaletteMode.Office2007Silver:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
                    break;
                case PaletteMode.Office2007White:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2007White;
                    break;
                case PaletteMode.Office2007Black:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
                    break;
                case PaletteMode.Office2010Blue:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
                case PaletteMode.Office2010Silver:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
                    break;
                case PaletteMode.Office2010White:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2010White;
                    break;
                case PaletteMode.Office2010Black:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
                    break;
                case PaletteMode.Office2013:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2013;
                    break;
                case PaletteMode.Office2013White:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2013White;
                    break;
                case PaletteMode.Office365Black:
                    manager.GlobalPaletteMode = PaletteModeManager.Office365Black;
                    break;
                case PaletteMode.Office365Blue:
                    manager.GlobalPaletteMode = PaletteModeManager.Office365Blue;
                    break;
                case PaletteMode.Office365Silver:
                    manager.GlobalPaletteMode = PaletteModeManager.Office365Silver;
                    break;
                case PaletteMode.Office365White:
                    manager.GlobalPaletteMode = PaletteModeManager.Office365White;
                    break;
                case PaletteMode.SparkleBlue:
                    manager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                    break;
                case PaletteMode.SparkleOrange:
                    manager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
                    break;
                case PaletteMode.SparklePurple:
                    manager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
                    break;
                case PaletteMode.Custom:
                    manager.GlobalPaletteMode = PaletteModeManager.Custom;
                    break;
            }
        }

        private PaletteMode GetPaletteMode(string themeName)
        {
            if (themeName == "Custom")
            {
                return PaletteMode.Custom;
            }
            else if (themeName == "Global")
            {
                return PaletteMode.Global;
            }
            else if (themeName == "Professional - System")
            {
                return PaletteMode.ProfessionalSystem;
            }
            else if (themeName == "Professional - Office 2003")
            {
                return PaletteMode.ProfessionalOffice2003;
            }
            else if (themeName == "Office 2007 - Black")
            {
                return PaletteMode.Office2007Black;
            }
            else if (themeName == "Office 2007 - Blue")
            {
                return PaletteMode.Office2007Blue;
            }
            else if (themeName == "Office 2007 - Silver")
            {
                return PaletteMode.Office2007Silver;
            }
            else if (themeName == "Office 2007 - White")
            {
                return PaletteMode.Office2007White;
            }
            else if (themeName == "Office 2010 - Black")
            {
                return PaletteMode.Office2010Black;
            }
            else if (themeName == "Office 2010 - Blue")
            {
                return PaletteMode.Office2010Blue;
            }
            else if (themeName == "Office 2010 - Silver")
            {
                return PaletteMode.Office2010Silver;
            }
            else if (themeName == "Office 2010 - White")
            {
                return PaletteMode.Office2010White;
            }
            else if (themeName == "Office 2013")
            {
                return PaletteMode.Office2013;
            }
            else if (themeName == "Office 2013 - White")
            {
                return PaletteMode.Office2013White;
            }
            else if (themeName == "Office 365 - Black")
            {
                return PaletteMode.Office365Black;
            }
            else if (themeName == "Office 365 - Blue")
            {
                return PaletteMode.Office365Blue;
            }
            else if (themeName == "Office 365 - Silver")
            {
                return PaletteMode.Office365Silver;
            }
            else if (themeName == "Office 365 - White")
            {
                return PaletteMode.Office365White;
            }
            else if (themeName == "Sparkle - Blue")
            {
                return PaletteMode.SparkleBlue;
            }
            else if (themeName == "Sparkle - Orange")
            {
                return PaletteMode.SparkleOrange;
            }
            else if (themeName == "Sparkle - Purple")
            {
                return PaletteMode.SparklePurple;
            }

            return PaletteMode.Office2010Blue;
        }
        #endregion

        private void kcmbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kcmbSelection.Text == "")
            {
                kbtnApplyTheme.Enabled = false;
            }
            else
            {
                kbtnApplyTheme.Enabled = true;
            }
        }
    }
}