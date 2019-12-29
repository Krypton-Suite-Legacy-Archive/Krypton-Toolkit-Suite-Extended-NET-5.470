#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using Common;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ExtendedDialogs.Dialogs.Theming
{
    public class ThemeSelector : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kpnlButtons;
        private KryptonButton kbtnRestoreToDefaults;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnOk;
        private System.Windows.Forms.Panel pnlSeperator;
        private KryptonPanel kpnlContent;
        private KryptonButton kbtnTry;
        private KryptonButton kbtnBrowse;
        private KryptonTextBox ktxtCustomPath;
        private KryptonLabel klblCustomTheme;
        private KryptonComboBox kcmbPaletteTheme;
        private KryptonLabel kryptonLabel1;
        private KryptonPalette palette;
        private System.ComponentModel.IContainer components;
        private KryptonManager kman;
        private KryptonButton kbtnApply;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeSelector));
            this.kpnlButtons = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnRestoreToDefaults = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnApply = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlSeperator = new System.Windows.Forms.Panel();
            this.kpnlContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnTry = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktxtCustomPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.klblCustomTheme = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcmbPaletteTheme = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.palette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kman = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).BeginInit();
            this.kpnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).BeginInit();
            this.kpnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbPaletteTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlButtons
            // 
            this.kpnlButtons.Controls.Add(this.kbtnRestoreToDefaults);
            this.kpnlButtons.Controls.Add(this.kbtnCancel);
            this.kpnlButtons.Controls.Add(this.kbtnOk);
            this.kpnlButtons.Controls.Add(this.kbtnApply);
            this.kpnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlButtons.Location = new System.Drawing.Point(0, 146);
            this.kpnlButtons.Name = "kpnlButtons";
            this.kpnlButtons.Size = new System.Drawing.Size(785, 54);
            this.kpnlButtons.TabIndex = 1;
            // 
            // kbtnRestoreToDefaults
            // 
            this.kbtnRestoreToDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnRestoreToDefaults.Enabled = false;
            this.kbtnRestoreToDefaults.Location = new System.Drawing.Point(16, 12);
            this.kbtnRestoreToDefaults.Name = "kbtnRestoreToDefaults";
            this.kbtnRestoreToDefaults.Size = new System.Drawing.Size(163, 30);
            this.kbtnRestoreToDefaults.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRestoreToDefaults.TabIndex = 3;
            this.kbtnRestoreToDefaults.Values.Text = "&Restore to Defaults";
            this.kbtnRestoreToDefaults.Click += new System.EventHandler(this.kbtnRestoreToDefaults_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(587, 12);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 30);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 2;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.Location = new System.Drawing.Point(491, 12);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(90, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 1;
            this.kbtnOk.Values.Text = "&Ok";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // kbtnApply
            // 
            this.kbtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnApply.Enabled = false;
            this.kbtnApply.Location = new System.Drawing.Point(683, 12);
            this.kbtnApply.Name = "kbtnApply";
            this.kbtnApply.Size = new System.Drawing.Size(90, 30);
            this.kbtnApply.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApply.TabIndex = 0;
            this.kbtnApply.Values.Text = "A&pply";
            this.kbtnApply.Click += new System.EventHandler(this.kbtnApply_Click);
            // 
            // pnlSeperator
            // 
            this.pnlSeperator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeperator.Location = new System.Drawing.Point(0, 143);
            this.pnlSeperator.Name = "pnlSeperator";
            this.pnlSeperator.Size = new System.Drawing.Size(785, 3);
            this.pnlSeperator.TabIndex = 3;
            // 
            // kpnlContent
            // 
            this.kpnlContent.Controls.Add(this.kbtnTry);
            this.kpnlContent.Controls.Add(this.kbtnBrowse);
            this.kpnlContent.Controls.Add(this.ktxtCustomPath);
            this.kpnlContent.Controls.Add(this.klblCustomTheme);
            this.kpnlContent.Controls.Add(this.kcmbPaletteTheme);
            this.kpnlContent.Controls.Add(this.kryptonLabel1);
            this.kpnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlContent.Location = new System.Drawing.Point(0, 0);
            this.kpnlContent.Name = "kpnlContent";
            this.kpnlContent.Size = new System.Drawing.Size(785, 143);
            this.kpnlContent.TabIndex = 4;
            // 
            // kbtnTry
            // 
            this.kbtnTry.AutoSize = true;
            this.kbtnTry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnTry.Enabled = false;
            this.kbtnTry.Location = new System.Drawing.Point(733, 87);
            this.kbtnTry.Name = "kbtnTry";
            this.kbtnTry.Size = new System.Drawing.Size(34, 30);
            this.kbtnTry.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTry.TabIndex = 5;
            this.kbtnTry.Values.Text = "T&ry";
            this.kbtnTry.Click += new System.EventHandler(this.kbtnTry_Click);
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.AutoSize = true;
            this.kbtnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnBrowse.Enabled = false;
            this.kbtnBrowse.Location = new System.Drawing.Point(744, 51);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(23, 30);
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 4;
            this.kbtnBrowse.Values.Text = ".&..";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // ktxtCustomPath
            // 
            this.ktxtCustomPath.Enabled = false;
            this.ktxtCustomPath.Location = new System.Drawing.Point(248, 52);
            this.ktxtCustomPath.Name = "ktxtCustomPath";
            this.ktxtCustomPath.Size = new System.Drawing.Size(490, 29);
            this.ktxtCustomPath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtCustomPath.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtCustomPath.TabIndex = 3;
            this.ktxtCustomPath.TextChanged += new System.EventHandler(this.ktxtCustomPath_TextChanged);
            // 
            // klblCustomTheme
            // 
            this.klblCustomTheme.Enabled = false;
            this.klblCustomTheme.Location = new System.Drawing.Point(38, 55);
            this.klblCustomTheme.Name = "klblCustomTheme";
            this.klblCustomTheme.Size = new System.Drawing.Size(204, 26);
            this.klblCustomTheme.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCustomTheme.TabIndex = 2;
            this.klblCustomTheme.Values.Text = "Custom Theme File Path:";
            // 
            // kcmbPaletteTheme
            // 
            this.kcmbPaletteTheme.DropDownWidth = 216;
            this.kcmbPaletteTheme.IntegralHeight = false;
            this.kcmbPaletteTheme.Location = new System.Drawing.Point(147, 12);
            this.kcmbPaletteTheme.Name = "kcmbPaletteTheme";
            this.kcmbPaletteTheme.Size = new System.Drawing.Size(216, 27);
            this.kcmbPaletteTheme.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbPaletteTheme.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbPaletteTheme.TabIndex = 1;
            this.kcmbPaletteTheme.TextChanged += new System.EventHandler(this.kcmbPaletteTheme_TextChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(128, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Palette Theme:";
            // 
            // palette
            // 
            this.palette.CustomisedKryptonPaletteFilePath = null;
            // 
            // ThemeSelector
            // 
            this.ClientSize = new System.Drawing.Size(785, 200);
            this.Controls.Add(this.kpnlContent);
            this.Controls.Add(this.pnlSeperator);
            this.Controls.Add(this.kpnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeSelector";
            this.Text = "Palette Theme Selector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemeSelector_FormClosing);
            this.Load += new System.EventHandler(this.ThemeSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).EndInit();
            this.kpnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).EndInit();
            this.kpnlContent.ResumeLayout(false);
            this.kpnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbPaletteTheme)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private ArrayList _themeList = null;

        private List<string> _themes = null;
        #endregion

        #region Properties
        public ArrayList ThemeList { get => _themeList; set => _themeList = value; }

        public List<string> Themes { get => _themes; set => _themes = value; }
        #endregion

        #region Constructor
        public ThemeSelector()
        {
            InitializeComponent();
        }
        #endregion

        private void ThemeSelector_Load(object sender, EventArgs e)
        {
            SetupWindow();
        }

        private void kcmbPaletteTheme_TextChanged(object sender, EventArgs e)
        {
            SwitchTheme(InterpretModeValue(kcmbPaletteTheme.Text));

            if (kcmbPaletteTheme.Text == "Custom" || kcmbPaletteTheme.Text == "Global")
            {
                EnableCustomUI(true);
            }
            else
            {
                EnableCustomUI(false);
            }
        }

        private void ktxtCustomPath_TextChanged(object sender, EventArgs e)
        {
            if (ktxtCustomPath.Text != "")
            {
                EnableButtons(true);
            }
            else
            {
                EnableButtons(false);
            }
        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Open a Custom Krypton Palette File:";

            cofd.Filters.Add(new CommonFileDialogFilter("Krypton Palette Files (*.xml)", "xml"));

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktxtCustomPath.Text = Path.GetFullPath(cofd.FileName);
            }
        }

        private void kbtnTry_Click(object sender, EventArgs e)
        {
            Timer tryTimer = new Timer() { Enabled = true, Interval = 500 };

            tryTimer.Start();

            tryTimer.Tick += TryTimer_Tick;

            palette.Import(Path.GetFullPath(ktxtCustomPath.Text), false);

            kman.GlobalPaletteMode = PaletteModeManager.Custom;

            kman.GlobalPalette = palette;
        }

        private void TryTimer_Tick(object sender, EventArgs e)
        {
            int timeOut = 10;

            //palette.Import(Path.GetFullPath(ktxtCustomPath.Text), false);

            //kman.GlobalPaletteMode = PaletteModeManager.Custom;

            //kman.GlobalPalette = palette;

            //do
            //{
            //    timeOut--;
            //} while (timeOut > 0);

            //if (timeOut == 0)
            //{
            //    kman.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            //}
        }

        private void kbtnRestoreToDefaults_Click(object sender, EventArgs e)
        {

        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {

        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kbtnApply_Click(object sender, EventArgs e)
        {

        }

        private void ThemeSelector_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #region Methods
        private void SetupWindow(bool sortThemeList = true)
        {
            ThemeList = new ArrayList();

            Themes = new List<string>();

            foreach (PaletteMode mode in Enum.GetValues(typeof(PaletteMode)))
            {
                ThemeList.Add(mode.ToString());

                if (sortThemeList)
                {
                    _themeList.Sort();
                }
            }

            if (ThemeList != null)
            {
                foreach (string item in ThemeList)
                {
                    Themes.Add(item);
                }
            }

            foreach (string item in Themes)
            {
                kcmbPaletteTheme.Items.Add(item);
            }
        }

        private void SwitchTheme(PaletteMode mode)
        {
            switch (mode)
            {
                case PaletteMode.Global:
                    kman.GlobalPaletteMode = PaletteModeManager.Custom;
                    break;
                case PaletteMode.ProfessionalSystem:
                    kman.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                    break;
                case PaletteMode.ProfessionalOffice2003:
                    kman.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
                    break;
                case PaletteMode.Office2007Blue:
                    kman.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                    break;
                case PaletteMode.Office2007Silver:
                    kman.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
                    break;
                case PaletteMode.Office2007White:
                    kman.GlobalPaletteMode = PaletteModeManager.Office2007White;
                    break;
                case PaletteMode.Office2007Black:
                    kman.GlobalPaletteMode = PaletteModeManager.Office2007Black;
                    break;
                case PaletteMode.Office2010Blue:
                    kman.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
                case PaletteMode.Office2010Silver:
                    kman.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
                    break;
                case PaletteMode.Office2010White:
                    kman.GlobalPaletteMode = PaletteModeManager.Office2010White;
                    break;
                case PaletteMode.Office2010Black:
                    kman.GlobalPaletteMode = PaletteModeManager.Office2010Black;
                    break;
                case PaletteMode.Office2013:
                    kman.GlobalPaletteMode = PaletteModeManager.Office2013;
                    break;
                case PaletteMode.Office2013White:
                    kman.GlobalPaletteMode = PaletteModeManager.Office2013White;
                    break;
                case PaletteMode.Office365Black:
                    kman.GlobalPaletteMode = PaletteModeManager.Office365Black;
                    break;
                case PaletteMode.Office365Blue:
                    kman.GlobalPaletteMode = PaletteModeManager.Office365Blue;
                    break;
                case PaletteMode.Office365Silver:
                    kman.GlobalPaletteMode = PaletteModeManager.Office365Silver;
                    break;
                case PaletteMode.Office365White:
                    kman.GlobalPaletteMode = PaletteModeManager.Office365White;
                    break;
                case PaletteMode.SparkleBlue:
                    kman.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                    break;
                case PaletteMode.SparkleOrange:
                    kman.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
                    break;
                case PaletteMode.SparklePurple:
                    kman.GlobalPaletteMode = PaletteModeManager.SparklePurple;
                    break;
                case PaletteMode.Custom:
                    kman.GlobalPaletteMode = PaletteModeManager.Custom;
                    break;
                default:
                    break;
            }
        }

        private void LoadCustomTheme(KryptonPalette palette, string customPalettePath)
        {
            try
            {
                if (palette != null)
                {
                    if (File.Exists(customPalettePath))
                    {
                        palette.Import(customPalettePath);

                        kman.GlobalPaletteMode = PaletteModeManager.Custom;

                        kman.GlobalPalette = palette;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    palette = new KryptonPalette();

                    kman.GlobalPaletteMode = PaletteModeManager.Custom;

                    kman.GlobalPalette = palette;
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }

        private void EnableButtons(bool enabled)
        {
            kbtnApply.Enabled = enabled;

            kbtnTry.Enabled = enabled;
        }

        private PaletteMode InterpretModeValue(string value) => (PaletteMode)Enum.Parse(typeof(PaletteMode), value);

        private void EnableCustomUI(bool enabled)
        {
            klblCustomTheme.Enabled = enabled;

            ktxtCustomPath.Enabled = enabled;

            kbtnBrowse.Enabled = enabled;
        }
        #endregion
    }
}