using ComponentFactory.Krypton.Toolkit;
using GlobalUtilities.Classes;
using System;
using System.Windows.Forms;

namespace PaletteExplorer.UX
{
    public class OptionsWindow : KryptonForm
    {
        #region System Functions
        private KryptonManager kMan;
        private System.ComponentModel.IContainer components;
        private KryptonPalette kryptonPalette1;
        private KryptonPanel kryptonPanel1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton ksbApply;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnCancel;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kpGeneral;
        private ComponentFactory.Krypton.Navigator.KryptonPage kpTheme;
        private KryptonGroupBox kryptonGroupBox1;
        private KryptonComboBox kcbTheme;
        private KryptonLabel kryptonLabel1;
        private KryptonButton kbtnLoadTheme;
        private KryptonButton kbtnCustomThemeFileBrowse;
        private KryptonTextBox ktxtCustomThemePath;
        private KryptonLabel klblCustomThemeFilePath;
        private System.Windows.Forms.Panel panel1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsWindow));
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ksbApply = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kpGeneral = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kpTheme = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kbtnLoadTheme = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCustomThemeFileBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktxtCustomThemePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.klblCustomThemeFilePath = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcbTheme = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpTheme)).BeginInit();
            this.kpTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // kMan
            // 
            this.kMan.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.CustomisedKryptonPaletteFilePath = "";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Controls.Add(this.ksbApply);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 797);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(906, 55);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnCancel.Location = new System.Drawing.Point(757, 13);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(60, 30);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 1;
            this.kbtnCancel.Values.Text = "Can&cel";
            // 
            // ksbApply
            // 
            this.ksbApply.AutoSize = true;
            this.ksbApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ksbApply.Enabled = false;
            this.ksbApply.Location = new System.Drawing.Point(823, 13);
            this.ksbApply.Name = "ksbApply";
            this.ksbApply.Size = new System.Drawing.Size(71, 30);
            this.ksbApply.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ksbApply.TabIndex = 0;
            this.ksbApply.Values.Image = ((System.Drawing.Image)(resources.GetObject("ksbApply.Values.Image")));
            this.ksbApply.Values.Text = "&Apply";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonNavigator1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(906, 797);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kryptonNavigator1.Location = new System.Drawing.Point(12, 12);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kpGeneral,
            this.kpTheme});
            this.kryptonNavigator1.SelectedIndex = 1;
            this.kryptonNavigator1.Size = new System.Drawing.Size(882, 776);
            this.kryptonNavigator1.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kpGeneral
            // 
            this.kpGeneral.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpGeneral.Flags = 65534;
            this.kpGeneral.LastVisibleSet = true;
            this.kpGeneral.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpGeneral.Name = "kpGeneral";
            this.kpGeneral.Size = new System.Drawing.Size(880, 745);
            this.kpGeneral.Text = "General";
            this.kpGeneral.ToolTipTitle = "Page ToolTip";
            this.kpGeneral.UniqueName = "8CF4DE8AD8A6433C038CBF6707BB28B6";
            // 
            // kpTheme
            // 
            this.kpTheme.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpTheme.Controls.Add(this.kryptonGroupBox1);
            this.kpTheme.Flags = 65534;
            this.kpTheme.LastVisibleSet = true;
            this.kpTheme.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpTheme.Name = "kpTheme";
            this.kpTheme.Size = new System.Drawing.Size(880, 745);
            this.kpTheme.Text = "Theme";
            this.kpTheme.ToolTipTitle = "Page ToolTip";
            this.kpTheme.UniqueName = "A80439CDD42845E10BA62B98A827DD36";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(20, 16);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnLoadTheme);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnCustomThemeFileBrowse);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ktxtCustomThemePath);
            this.kryptonGroupBox1.Panel.Controls.Add(this.klblCustomThemeFilePath);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kcbTheme);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(840, 169);
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Theme Selector";
            // 
            // kbtnLoadTheme
            // 
            this.kbtnLoadTheme.AutoSize = true;
            this.kbtnLoadTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnLoadTheme.Enabled = false;
            this.kbtnLoadTheme.Location = new System.Drawing.Point(668, 97);
            this.kbtnLoadTheme.Name = "kbtnLoadTheme";
            this.kbtnLoadTheme.Size = new System.Drawing.Size(152, 28);
            this.kbtnLoadTheme.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.kbtnLoadTheme.TabIndex = 5;
            this.kbtnLoadTheme.Values.Text = "&Load Custom Theme";
            // 
            // kbtnCustomThemeFileBrowse
            // 
            this.kbtnCustomThemeFileBrowse.AutoSize = true;
            this.kbtnCustomThemeFileBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnCustomThemeFileBrowse.Enabled = false;
            this.kbtnCustomThemeFileBrowse.Location = new System.Drawing.Point(798, 53);
            this.kbtnCustomThemeFileBrowse.Name = "kbtnCustomThemeFileBrowse";
            this.kbtnCustomThemeFileBrowse.Size = new System.Drawing.Size(22, 28);
            this.kbtnCustomThemeFileBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.kbtnCustomThemeFileBrowse.TabIndex = 4;
            this.kbtnCustomThemeFileBrowse.Values.Text = ".&..";
            // 
            // ktxtCustomThemePath
            // 
            this.ktxtCustomThemePath.Enabled = false;
            this.ktxtCustomThemePath.Location = new System.Drawing.Point(231, 54);
            this.ktxtCustomThemePath.Name = "ktxtCustomThemePath";
            this.ktxtCustomThemePath.Size = new System.Drawing.Size(561, 27);
            this.ktxtCustomThemePath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ktxtCustomThemePath.TabIndex = 3;
            // 
            // klblCustomThemeFilePath
            // 
            this.klblCustomThemeFilePath.Enabled = false;
            this.klblCustomThemeFilePath.Location = new System.Drawing.Point(34, 55);
            this.klblCustomThemeFilePath.Name = "klblCustomThemeFilePath";
            this.klblCustomThemeFilePath.Size = new System.Drawing.Size(191, 24);
            this.klblCustomThemeFilePath.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCustomThemeFilePath.TabIndex = 2;
            this.klblCustomThemeFilePath.Values.Text = "Custom Theme File Path:";
            // 
            // kcbTheme
            // 
            this.kcbTheme.DropDownWidth = 182;
            this.kcbTheme.Location = new System.Drawing.Point(124, 12);
            this.kcbTheme.Name = "kcbTheme";
            this.kcbTheme.Size = new System.Drawing.Size(182, 25);
            this.kcbTheme.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbTheme.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(104, 24);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Theme Type:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 794);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 3);
            this.panel1.TabIndex = 2;
            // 
            // OptionsWindow
            // 
            this.ClientSize = new System.Drawing.Size(906, 852);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Palette Explorer Options";
            this.Load += new System.EventHandler(this.OptionsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpTheme)).EndInit();
            this.kpTheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcbTheme)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void OptionsWindow_Load(object sender, EventArgs e)
        {
            InitialiseWindow();
        }

        private void InitialiseWindow()
        {
            try
            {
                foreach (string themeValues in Enum.GetValues(typeof(PaletteModeManager)))
                {
                    kcbTheme.Items.Add(themeValues);
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.ThrowException(MessageBoxIcon.Error, $"Error: { exc.Message }", "Palette Explorer Options", MessageBoxButtons.OK);
            }
        }
    }
}