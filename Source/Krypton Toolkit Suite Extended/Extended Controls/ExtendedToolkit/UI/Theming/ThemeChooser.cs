using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Development;
using ExtendedControls.Base.Enumerations;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace ExtendedControls.ExtendedToolkit.UI.Theming
{
    public class ThemeChooser : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnCreate;
        private KryptonButton kbtnApply;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnImport;
        private KryptonButton kbtnBrowse;
        private Controls.KryptonPromptTextBox kptxtCustomThemePath;
        private KryptonComboBox kcmbSelection;
        private KryptonLabel klblPaletteStyle;
        private System.Windows.Forms.Panel panel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnImport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kptxtCustomThemePath = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kcmbSelection = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.klblPaletteStyle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnCreate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnApply = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnImport);
            this.kryptonPanel1.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel1.Controls.Add(this.kptxtCustomThemePath);
            this.kryptonPanel1.Controls.Add(this.kcmbSelection);
            this.kryptonPanel1.Controls.Add(this.klblPaletteStyle);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(702, 150);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnImport
            // 
            this.kbtnImport.Enabled = false;
            this.kbtnImport.Location = new System.Drawing.Point(573, 104);
            this.kbtnImport.Name = "kbtnImport";
            this.kbtnImport.Size = new System.Drawing.Size(117, 29);
            this.kbtnImport.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnImport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnImport.TabIndex = 13;
            this.kbtnImport.Values.Text = "Im&port...";
            this.kbtnImport.Click += new System.EventHandler(this.kbtnImport_Click);
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Enabled = false;
            this.kbtnBrowse.Location = new System.Drawing.Point(659, 60);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(31, 27);
            this.kbtnBrowse.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 12;
            this.kbtnBrowse.Values.Text = ".&..";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // kptxtCustomThemePath
            // 
            this.kptxtCustomThemePath.DrawPrompt = true;
            this.kptxtCustomThemePath.Enabled = false;
            this.kptxtCustomThemePath.FocusSelect = true;
            this.kptxtCustomThemePath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtCustomThemePath.Location = new System.Drawing.Point(26, 60);
            this.kptxtCustomThemePath.Name = "kptxtCustomThemePath";
            this.kptxtCustomThemePath.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kptxtCustomThemePath.PromptText = "Enter custom theme path here...";
            this.kptxtCustomThemePath.PromptTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtCustomThemePath.Size = new System.Drawing.Size(627, 27);
            this.kptxtCustomThemePath.TabIndex = 6;
            this.kptxtCustomThemePath.TextChanged += new System.EventHandler(this.kptxtCustomThemePath_TextChanged);
            // 
            // kcmbSelection
            // 
            this.kcmbSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kcmbSelection.DropDownWidth = 255;
            this.kcmbSelection.Location = new System.Drawing.Point(172, 12);
            this.kcmbSelection.Name = "kcmbSelection";
            this.kcmbSelection.Size = new System.Drawing.Size(518, 25);
            this.kcmbSelection.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbSelection.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbSelection.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbSelection.TabIndex = 5;
            this.kcmbSelection.SelectedIndexChanged += new System.EventHandler(this.kcmbSelection_SelectedIndexChanged);
            // 
            // klblPaletteStyle
            // 
            this.klblPaletteStyle.Location = new System.Drawing.Point(12, 12);
            this.klblPaletteStyle.Name = "klblPaletteStyle";
            this.klblPaletteStyle.Size = new System.Drawing.Size(154, 24);
            this.klblPaletteStyle.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblPaletteStyle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblPaletteStyle.TabIndex = 4;
            this.klblPaletteStyle.Values.Text = "Select Palette Style:";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnCreate);
            this.kryptonPanel2.Controls.Add(this.kbtnApply);
            this.kryptonPanel2.Controls.Add(this.kbtnCancel);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 152);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(702, 52);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // kbtnCreate
            // 
            this.kbtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kbtnCreate.Enabled = false;
            this.kbtnCreate.Location = new System.Drawing.Point(12, 11);
            this.kbtnCreate.Name = "kbtnCreate";
            this.kbtnCreate.Size = new System.Drawing.Size(180, 29);
            this.kbtnCreate.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCreate.TabIndex = 13;
            this.kbtnCreate.Values.Text = "Create &Custom Theme";
            this.kbtnCreate.Click += new System.EventHandler(this.kbtnCreate_Click);
            // 
            // kbtnApply
            // 
            this.kbtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnApply.Enabled = false;
            this.kbtnApply.Location = new System.Drawing.Point(450, 11);
            this.kbtnApply.Name = "kbtnApply";
            this.kbtnApply.Size = new System.Drawing.Size(117, 29);
            this.kbtnApply.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApply.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApply.TabIndex = 12;
            this.kbtnApply.Values.Text = "A&pply";
            this.kbtnApply.Click += new System.EventHandler(this.kbtnApply_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(573, 11);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 11;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 54);
            this.panel1.TabIndex = 0;
            // 
            // ThemeChooser
            // 
            this.ClientSize = new System.Drawing.Size(702, 204);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeChooser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Choose a Theme";
            this.Load += new System.EventHandler(this.ThemeChooser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private ArrayList _styles;
        private bool _developmentMode;
        private KryptonPalette _kryptonPalette;
        private Version _currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
        #endregion

        #region Properties
        public bool DevelopmentMode { get => _developmentMode; set => _developmentMode = value; }

        public KryptonPalette KryptonPalette { get => _kryptonPalette; set => _kryptonPalette = value; }
        #endregion

        #region Constructors
        public ThemeChooser(int xCoordinate = 0, int yCoordinate = 0, bool devMode = true)
        {
            InitializeComponent();

            // Place the window at the position that we have given it
            Location = new Point(xCoordinate, yCoordinate);

            // Set development mode
            DevelopmentMode = devMode;

            _styles = new ArrayList();

            PropagateStylesArray(_styles);

            foreach (string style in _styles)
            {
                kcmbSelection.Items.Add(style);
            }
        }
        #endregion

        private void ThemeChooser_Load(object sender, EventArgs e)
        {
            if (DevelopmentMode)
            {
                DevelopmentInformation.SetBuildInformation(this, DevelopmentStates.PREALPHA);
            }
        }

        private void kbtnApply_Click(object sender, EventArgs e)
        {

        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Open Palette File:";

            cofd.Filters.Add(new CommonFileDialogFilter("Palette Files", "*.xml"));

            cofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                kptxtCustomThemePath.Text = Path.GetFullPath(cofd.FileName);
            }
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void kbtnCreate_Click(object sender, EventArgs e)
        {

        }

        private void kbtnImport_Click(object sender, EventArgs e)
        {
            KryptonPalette = new KryptonPalette();

            KryptonPalette.Import(kptxtCustomThemePath.Text);

            kbtnImport.Enabled = false;
        }

        private void kcmbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kcmbSelection.Text == "")
            {
                kbtnApply.Enabled = false;
            }
            else
            {
                kbtnApply.Enabled = true;
            }

            if (kcmbSelection.Text == "Custom")
            {
                EnableCustomPaletteUIElements(true);
            }
            else
            {
                EnableCustomPaletteUIElements(false);
            }
        }

        private void kptxtCustomThemePath_TextChanged(object sender, EventArgs e)
        {
            if (kptxtCustomThemePath.Text != "")
            {
                kbtnImport.Enabled = true;
            }
            else
            {
                kbtnImport.Enabled = false;
            }
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
            ThemeChooser themeChooser = new ThemeChooser();

            return themeChooser.kcmbSelection.Text;
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
            PaletteMode result;

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

        private void EnableCustomPaletteUIElements(bool enabled = false)
        {
            kptxtCustomThemePath.Enabled = enabled;

            kbtnBrowse.Enabled = enabled;
        }
        #endregion
    }
}