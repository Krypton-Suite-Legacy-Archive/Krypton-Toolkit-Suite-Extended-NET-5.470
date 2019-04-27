using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Development;
using ExtendedControls.Base.Code.Settings;
using ExtendedControls.Base.Enumerations;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

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
        private KryptonCheckBox kcbSilent;
        private System.Windows.Forms.Panel panel1;

        private void InitializeComponent()
        {
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues2 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues4 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues5 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues6 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues7 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues8 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeChooser));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kcbSilent = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
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
            this.kryptonPanel1.Controls.Add(this.kcbSilent);
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
            // kcbSilent
            // 
            this.kcbSilent.Enabled = false;
            this.kcbSilent.Location = new System.Drawing.Point(505, 107);
            this.kcbSilent.Name = "kcbSilent";
            this.kcbSilent.Size = new System.Drawing.Size(62, 24);
            this.kcbSilent.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbSilent.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbSilent.TabIndex = 14;
            popupPositionValues1.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues1.PlacementTarget = null;
            this.kcbSilent.ToolTipValues.ToolTipPosition = popupPositionValues1;
            this.kcbSilent.Values.Text = "&Silent";
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
            popupPositionValues2.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues2.PlacementTarget = null;
            this.kbtnImport.ToolTipValues.ToolTipPosition = popupPositionValues2;
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
            popupPositionValues3.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues3.PlacementTarget = null;
            this.kbtnBrowse.ToolTipValues.ToolTipPosition = popupPositionValues3;
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
            popupPositionValues4.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues4.PlacementTarget = null;
            this.kcmbSelection.ToolTipValues.ToolTipPosition = popupPositionValues4;
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
            popupPositionValues5.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues5.PlacementTarget = null;
            this.klblPaletteStyle.ToolTipValues.ToolTipPosition = popupPositionValues5;
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
            popupPositionValues6.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues6.PlacementTarget = null;
            this.kbtnCreate.ToolTipValues.ToolTipPosition = popupPositionValues6;
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
            popupPositionValues7.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues7.PlacementTarget = null;
            this.kbtnApply.ToolTipValues.ToolTipPosition = popupPositionValues7;
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
            popupPositionValues8.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues8.PlacementTarget = null;
            this.kbtnCancel.ToolTipValues.ToolTipPosition = popupPositionValues8;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private KryptonManager _manager = new KryptonManager();
        private KryptonPalette _kryptonPalette = new KryptonPalette();
        private Version _currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
        #endregion

        #region Properties
        public bool DevelopmentMode { get => _developmentMode; set => _developmentMode = value; }

        public KryptonManager Manager { get => _manager; set => _manager = value; }

        public KryptonPalette KryptonPalette { get => _kryptonPalette; set => _kryptonPalette = value; }
        #endregion

        #region Constructors
        public ThemeChooser(bool devMode = false, int xCoordinate = 0, int yCoordinate = 0)
        {
            InitializeComponent();

            // Place the window at the position that we have given it
            Location = new Point(xCoordinate, yCoordinate);

            _styles = new ArrayList();

            Manager = new KryptonManager();

            ThemeManager.PropagateThemeSelector(kcmbSelection);
        }
        #endregion

        private void ThemeChooser_Load(object sender, EventArgs e)
        {
            if (SettingsManager.GetDebugMode())
            {
                DevelopmentInformation.SetBuildInformation(this, DevelopmentState.PREALPHA);
            }
        }

        private void kbtnApply_Click(object sender, EventArgs e)
        {
            if (kcmbSelection.Text != "")
            {
                ThemeManager.SetTheme(kcmbSelection.Text, Manager);
            }

            Debug.WriteLine($"[{ DateTime.Now.ToString() }]: Theme has changed to: { Manager.GlobalPaletteMode.ToString() }");
        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Open a Customised Theme File:";

            cofd.Filters.Add(new CommonFileDialogFilter("Krypton Theme Files", ".xml"));

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                kptxtCustomThemePath.Text = Path.GetFullPath(cofd.FileName);

                EnableImportItems(true);
            }
        }

        private void EnableImportItems(bool enabled)
        {
            kcbSilent.Enabled = enabled;

            kbtnImport.Enabled = enabled;
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Hide();
        }

        private void kbtnCreate_Click(object sender, EventArgs e)
        {
            ExtendedKryptonMessageBox.Show("This feature will be enabled once it is ready.", "Feature Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //if (SettingsManager.GetPaletteExplorerLocation() != string.Empty)
            //{
            //    Process.Start(SettingsManager.GetPaletteExplorerLocation());
            //}
            //else
            //{
            //    PaletteExplorerLocator locator = new PaletteExplorerLocator(SettingsManager.GetDebugMode());

            //    locator.Show();
            //}
        }

        private void kbtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(kptxtCustomThemePath.Text))
                {
                    _kryptonPalette.Import(kptxtCustomThemePath.Text, kcbSilent.Checked);

                    _manager.GlobalPalette = _kryptonPalette;

                    _manager.GlobalPaletteMode = PaletteModeManager.Custom;
                }
            }
            catch (Exception exc)
            {

                throw;
            }
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
        /// <summary>
        /// Enables the custom palette UI elements.
        /// </summary>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        private void EnableCustomPaletteUIElements(bool enabled = false)
        {
            kptxtCustomThemePath.Enabled = enabled;

            kcbSilent.Enabled = enabled;

            kbtnBrowse.Enabled = enabled;

            kbtnCreate.Enabled = enabled;
        }
        #endregion
    }
}