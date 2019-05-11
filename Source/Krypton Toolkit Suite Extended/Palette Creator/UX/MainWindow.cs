#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using KryptonExtendedToolkit.Base.Code;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PaletteCreator.UX
{
    public partial class MainWindow : KryptonForm
    {
        #region Variables
        private bool _dirty, _loaded;

        private string _fileName;

        private KryptonPalette _paletteTheme;

        private TMSChromeForm _tmsChrome;

        private RibbonChromeForm _ribbonChrome;

        Assembly _assembly = Assembly.GetExecutingAssembly();

        Version _version = Assembly.GetExecutingAssembly().GetName().Version;

        MostRecentlyUsedFileManager _mostRecentlyUsedFileManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = $"Palette Composer - Developer Edition - Version: { _version.ToString() } - Build: { _version.Build.ToString() }";

            WindowState = FormWindowState.Maximized;

            _mostRecentlyUsedFileManager = new MostRecentlyUsedFileManager(openRecentToolStripMenuItem, "Palette Creator", MyOwnRecentFileGotClicked_Handler, MyOwnRecentFilesGotCleared_Handler);

            #region Palette Creator Stuff
            // Populate the sample data set
            dataTable1.Rows.Add("One", "Two", "Three");
            dataTable1.Rows.Add("Uno", "Dos", "Tres");
            dataTable1.Rows.Add("Un", "Deux", "Trios");

            // Add the chrome window to the Chrome + Strips page
            _tmsChrome = new TMSChromeForm();
            _tmsChrome.TopLevel = false;
            _tmsChrome.Parent = pageDesignChromeTMS;
            _tmsChrome.Dock = DockStyle.Fill;
            _tmsChrome.InertForm = true;
            _tmsChrome.Show();

            // Add the chrome window with embedded Ribbon
            _ribbonChrome = new RibbonChromeForm();
            _ribbonChrome.TopLevel = false;
            _ribbonChrome.Parent = pageDesignRibbon;
            _ribbonChrome.Dock = DockStyle.Fill;
            _ribbonChrome.InertForm = true;
            _ribbonChrome.Show();

            // Button fixed states
            buttonDisabled.SetFixedState(PaletteState.Disabled);
            buttonDefaultFocus.SetFixedState(PaletteState.NormalDefaultOverride);
            buttonNormal.SetFixedState(PaletteState.Normal);
            buttonTracking.SetFixedState(PaletteState.Tracking);
            buttonPressed.SetFixedState(PaletteState.Pressed);
            buttonCheckedNormal.SetFixedState(PaletteState.CheckedNormal);
            buttonCheckedTracking.SetFixedState(PaletteState.CheckedTracking);
            buttonCheckedPressed.SetFixedState(PaletteState.CheckedPressed);

            // CheckBox fixed states
            cbFocus.SetFixedState(true, true, false, false);
            cbUncheckedDisabled.SetFixedState(false, false, false, false);
            cbUncheckedNormal.SetFixedState(false, true, false, false);
            cbUncheckedTracking.SetFixedState(false, true, true, false);
            cbUncheckedPressed.SetFixedState(false, true, false, true);
            cbCheckedDisabled.SetFixedState(false, false, false, false);
            cbCheckedNormal.SetFixedState(false, true, false, false);
            cbCheckedTracking.SetFixedState(false, true, true, false);
            cbCheckedPressed.SetFixedState(false, true, false, true);
            cbIndeterminateDisabled.SetFixedState(false, false, false, false);
            cbIndeterminateNormal.SetFixedState(false, true, false, false);
            cbIndeterminateTracking.SetFixedState(false, true, true, false);
            cbIndeterminatePressed.SetFixedState(false, true, false, true);

            // RadioButton fixed states
            rbFocus.SetFixedState(true, true, false, false);
            rbCheckedDisabled.SetFixedState(false, false, false, false);
            rbCheckedNormal.SetFixedState(false, true, false, false);
            rbCheckedTracking.SetFixedState(false, true, true, false);
            rbCheckedPressed.SetFixedState(false, true, false, true);
            rbUncheckedDisabled.SetFixedState(false, false, false, false);
            rbUncheckedNormal.SetFixedState(false, true, false, false);
            rbUncheckedTracking.SetFixedState(false, true, true, false);
            rbUncheckedPressed.SetFixedState(false, true, false, true);

            // Control fixed states
            control1Disabled.SetFixedState(PaletteState.Disabled);
            control1Normal.SetFixedState(PaletteState.Normal);

            // HeaderGroup fixed states
            headerGroup1Disabled.SetFixedState(PaletteState.Disabled);
            headerGroup1Normal.SetFixedState(PaletteState.Normal);

            // Headers fixed states
            header1Disabled.SetFixedState(PaletteState.Disabled);
            header1Normal.SetFixedState(PaletteState.Normal);

            // Input controls fixed states
            textBoxNormal.SetFixedState(false);
            textBoxActive.SetFixedState(true);
            comboBoxNormal.SetFixedState(false);
            comboBoxActive.SetFixedState(true);
            numericNormal.SetFixedState(false);
            numericActive.SetFixedState(true);

            // Labels fixed states
            label1Disabled.SetFixedState(PaletteState.Disabled);
            label1Normal.SetFixedState(PaletteState.Normal);
            label1Visited.SetFixedState(PaletteState.Normal);
            label1NotVisited.SetFixedState(PaletteState.Normal);
            label1Pressed.SetFixedState(PaletteState.Pressed);

            // Panel fixed states
            panel1Disabled.SetFixedState(PaletteState.Disabled);
            panel1Normal.SetFixedState(PaletteState.Normal);

            // Separator fixed states
            separator1Disabled.SetFixedState(PaletteState.Disabled, PaletteState.Disabled);
            separator1Normal.SetFixedState(PaletteState.Normal, PaletteState.Normal);
            separator1Tracking.SetFixedState(PaletteState.Normal, PaletteState.Tracking);
            separator1Pressed.SetFixedState(PaletteState.Normal, PaletteState.Pressed);

            // TrackBar fixed states
            kryptonTrackBar1.SetFixedState(PaletteState.Normal);
            kryptonTrackBar5.SetFixedState(PaletteState.Normal);
            kryptonTrackBar2.SetFixedState(PaletteState.Tracking);
            kryptonTrackBar6.SetFixedState(PaletteState.Tracking);
            kryptonTrackBar3.SetFixedState(PaletteState.Pressed);
            kryptonTrackBar7.SetFixedState(PaletteState.Pressed);
            kryptonTrackBar4.SetFixedState(PaletteState.Disabled);
            kryptonTrackBar8.SetFixedState(PaletteState.Disabled);

            // Remove the context menu from the design navigator, we only show this
            // during design time to make it easier to switch around pages for updating
            // the design. At runtime it should always be in sync with the top navigator.
            kryptonNavigatorDesign.Button.ButtonDisplayLogic = ButtonDisplayLogic.None;

            // Define initial display pages
            kryptonNavigatorTop.SelectedPage = pageTopButtons;
            kryptonNavigatorDesign.SelectedPage = pageDesignButtons;

            CreateNewPalette();
            #endregion
        }

        private void MyOwnRecentFileGotClicked_Handler(object sender, EventArgs e)
        {
            string paletteFileName = (sender as ToolStripItem).Text;

            if (!File.Exists(paletteFileName))
            {
                if (KryptonMessageBox.Show($"{ paletteFileName } doesn't exist. Remove from recent workspaces?", "File not found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _mostRecentlyUsedFileManager.RemoveRecentFile(paletteFileName);
                }
                else
                {
                    return;
                }
            }

            OpenPaletteFile(paletteFileName);
        }

        private void MyOwnRecentFilesGotCleared_Handler(object sender, EventArgs e)
        {

        }

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                openRecentToolStripMenuItem.PerformClick();
            }
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            SavePalette();
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void kryptonNavigatorTop_SelectedPageChanged(object sender, EventArgs e)
        {
            kryptonNavigatorDesign.SelectedIndex = kryptonNavigatorTop.SelectedIndex;
        }

        private void kryptonNavigatorDesign_SelectedPageChanged(object sender, EventArgs e)
        {
            kryptonNavigatorTop.SelectedIndex = kryptonNavigatorDesign.SelectedIndex;
        }

        private void kryptonNavigatorDesignButtons_SelectedPageChanged(object sender, EventArgs e)
        {
            // Update the design page text with the selected style information
            pageDesignButtons.TextTitle = kryptonNavigatorDesignButtons.SelectedPage.Text;
            pageDesignButtons.TextDescription = kryptonNavigatorDesignButtons.SelectedPage.TextDescription;

            ButtonStyle bs;

            // Work out the button style to be used
            switch (kryptonNavigatorDesignButtons.SelectedIndex)
            {
                default:
                case 0:
                    bs = ButtonStyle.Standalone;
                    break;
                case 1:
                    bs = ButtonStyle.Alternate;
                    break;
                case 2:
                    bs = ButtonStyle.LowProfile;
                    break;
                case 3:
                    bs = ButtonStyle.BreadCrumb;
                    break;
                case 4:
                    bs = ButtonStyle.CalendarDay;
                    break;
                case 5:
                    bs = ButtonStyle.ButtonSpec;
                    break;
                case 6:
                    bs = ButtonStyle.Cluster;
                    break;
                case 7:
                    bs = ButtonStyle.NavigatorStack;
                    break;
                case 8:
                    bs = ButtonStyle.NavigatorOverflow;
                    break;
                case 9:
                    bs = ButtonStyle.NavigatorMini;
                    break;
                case 10:
                    bs = ButtonStyle.InputControl;
                    break;
                case 11:
                    bs = ButtonStyle.ListItem;
                    break;
                case 12:
                    bs = ButtonStyle.Gallery;
                    break;
                case 13:
                    bs = ButtonStyle.Form;
                    break;
                case 14:
                    bs = ButtonStyle.FormClose;
                    break;
                case 15:
                    bs = ButtonStyle.Command;
                    break;
                case 16:
                    bs = ButtonStyle.Custom1;
                    break;
                case 17:
                    bs = ButtonStyle.Custom2;
                    break;
                case 18:
                    bs = ButtonStyle.Custom3;
                    break;
            }

            // Update all the displayed buttons with the new style
            buttonDisabled.ButtonStyle = bs;
            buttonDefaultFocus.ButtonStyle = bs;
            buttonNormal.ButtonStyle = bs;
            buttonTracking.ButtonStyle = bs;
            buttonPressed.ButtonStyle = bs;
            buttonCheckedNormal.ButtonStyle = bs;
            buttonCheckedTracking.ButtonStyle = bs;
            buttonCheckedPressed.ButtonStyle = bs;
            buttonLive.ButtonStyle = bs;
        }

        private void kryptonNavigatorDesignControls_SelectedPageChanged(object sender, EventArgs e)
        {
            // Update the design page text with the selected style information
            pageDesignControls.TextTitle = kryptonNavigatorDesignControls.SelectedPage.Text;
            pageDesignControls.TextDescription = kryptonNavigatorDesignControls.SelectedPage.TextDescription;

            PaletteBackStyle backStyle;
            PaletteBorderStyle borderStyle;

            // Work out the group styles to be used
            switch (kryptonNavigatorDesignControls.SelectedIndex)
            {
                default:
                case 0:
                    backStyle = PaletteBackStyle.ControlClient;
                    borderStyle = PaletteBorderStyle.ControlClient;
                    break;
                case 1:
                    backStyle = PaletteBackStyle.ControlAlternate;
                    borderStyle = PaletteBorderStyle.ControlAlternate;
                    break;
                case 2:
                    backStyle = PaletteBackStyle.ControlGroupBox;
                    borderStyle = PaletteBorderStyle.ControlGroupBox;
                    break;
                case 3:
                    backStyle = PaletteBackStyle.ControlToolTip;
                    borderStyle = PaletteBorderStyle.ControlToolTip;
                    break;
                case 4:
                    backStyle = PaletteBackStyle.ControlRibbon;
                    borderStyle = PaletteBorderStyle.ControlRibbon;
                    break;
                case 5:
                    backStyle = PaletteBackStyle.ControlCustom1;
                    borderStyle = PaletteBorderStyle.ControlCustom1;
                    break;
            }

            // Update all the displayed controls with the new styles
            control1Disabled.GroupBackStyle = backStyle;
            control1Disabled.GroupBorderStyle = borderStyle;
            control1Normal.GroupBackStyle = backStyle;
            control1Normal.GroupBorderStyle = borderStyle;
        }

        private void kryptonNavigatorDesignInputControls_SelectedPageChanged(object sender, EventArgs e)
        {
            // Update the design page text with the selected style information
            pageDesignInputControls.TextTitle = kryptonNavigatorDesignInputControls.SelectedPage.Text;
            pageDesignInputControls.TextDescription = kryptonNavigatorDesignInputControls.SelectedPage.TextDescription;

            InputControlStyle inputControlStyle;
            bool alwaysActive = true;

            // Work out the input control style to be used
            switch (kryptonNavigatorDesignInputControls.SelectedIndex)
            {
                default:
                case 0:
                    inputControlStyle = InputControlStyle.Standalone;
                    break;
                case 1:
                    inputControlStyle = InputControlStyle.Ribbon;
                    alwaysActive = false;
                    break;
                case 2:
                    inputControlStyle = InputControlStyle.Custom1;
                    break;
            }

            // Update all the displayed controls with the new styles
            textBoxDisabled.InputControlStyle = inputControlStyle;
            textBoxNormal.InputControlStyle = inputControlStyle;
            textBoxActive.InputControlStyle = inputControlStyle;
            comboBoxDisabled.InputControlStyle = inputControlStyle;
            comboBoxNormal.InputControlStyle = inputControlStyle;
            comboBoxActive.InputControlStyle = inputControlStyle;
            numericDisabled.InputControlStyle = inputControlStyle;
            numericNormal.InputControlStyle = inputControlStyle;
            numericActive.InputControlStyle = inputControlStyle;
            textBoxDisabled.AlwaysActive = alwaysActive;
            textBoxNormal.AlwaysActive = alwaysActive;
            textBoxActive.AlwaysActive = alwaysActive;
            comboBoxDisabled.AlwaysActive = alwaysActive;
            comboBoxNormal.AlwaysActive = alwaysActive;
            comboBoxActive.AlwaysActive = alwaysActive;
            numericDisabled.AlwaysActive = alwaysActive;
            numericNormal.AlwaysActive = alwaysActive;
            numericActive.AlwaysActive = alwaysActive;
        }

        private void kryptonNavigatorDesignHeaders_SelectedPageChanged(object sender, EventArgs e)
        {
            // Update the design page text with the selected style information
            pageDesignHeaders.TextTitle = kryptonNavigatorDesignHeaders.SelectedPage.Text;
            pageDesignHeaders.TextDescription = kryptonNavigatorDesignHeaders.SelectedPage.TextDescription;

            HeaderStyle hs;

            // Work out the header style to be used
            switch (kryptonNavigatorDesignHeaders.SelectedIndex)
            {
                default:
                case 0:
                    hs = HeaderStyle.Primary;
                    break;
                case 1:
                    hs = HeaderStyle.Secondary;
                    break;
                case 2:
                    hs = HeaderStyle.DockActive;
                    break;
                case 3:
                    hs = HeaderStyle.DockInactive;
                    break;
                case 4:
                    hs = HeaderStyle.Calendar;
                    break;
                case 5:
                    hs = HeaderStyle.Form;
                    break;
                case 6:
                    hs = HeaderStyle.Custom1;
                    break;
                case 7:
                    hs = HeaderStyle.Custom2;
                    break;
            }

            // Update all the displayed controls with the new styles
            header1Disabled.HeaderStyle = hs;
            header1Normal.HeaderStyle = hs;
        }

        private void kryptonNavigatorDesignLabels_SelectedPageChanged(object sender, EventArgs e)
        {
            // Update the design page text with the selected style information
            pageDesignLabels.TextTitle = kryptonNavigatorDesignLabels.SelectedPage.Text;
            pageDesignLabels.TextDescription = kryptonNavigatorDesignLabels.SelectedPage.TextDescription;

            LabelStyle ls;

            // Work out the label style to be used
            switch (kryptonNavigatorDesignLabels.SelectedIndex)
            {
                default:
                case 0:
                    ls = LabelStyle.NormalControl;
                    break;
                case 1:
                    ls = LabelStyle.BoldControl;
                    break;
                case 2:
                    ls = LabelStyle.ItalicControl;
                    break;
                case 3:
                    ls = LabelStyle.TitleControl;
                    break;
                case 4:
                    ls = LabelStyle.NormalPanel;
                    break;
                case 5:
                    ls = LabelStyle.BoldPanel;
                    break;
                case 6:
                    ls = LabelStyle.ItalicPanel;
                    break;
                case 7:
                    ls = LabelStyle.TitlePanel;
                    break;
                case 8:
                    ls = LabelStyle.GroupBoxCaption;
                    break;
                case 9:
                    ls = LabelStyle.ToolTip;
                    break;
                case 10:
                    ls = LabelStyle.SuperTip;
                    break;
                case 11:
                    ls = LabelStyle.KeyTip;
                    break;
                case 12:
                    ls = LabelStyle.Custom1;
                    break;
                case 13:
                    ls = LabelStyle.Custom2;
                    break;
                case 14:
                    ls = LabelStyle.Custom3;
                    break;
            }

            // Update all the displayed controls with the new styles
            label1Disabled.LabelStyle = ls;
            label1Normal.LabelStyle = ls;
            label1Visited.LabelStyle = ls;
            label1NotVisited.LabelStyle = ls;
            label1Pressed.LabelStyle = ls;
            label1Live.LabelStyle = ls;
        }

        private void kryptonCheckSetLabels_CheckedButtonChanged(object sender, EventArgs e)
        {
            switch (kryptonCheckSetLabels.CheckedIndex)
            {
                case 0:
                    panelLabelsBackground.PanelBackStyle = PaletteBackStyle.PanelClient;
                    break;
                case 1:
                    panelLabelsBackground.PanelBackStyle = PaletteBackStyle.PanelAlternate;
                    break;
                case 2:
                    panelLabelsBackground.PanelBackStyle = PaletteBackStyle.PanelCustom1;
                    break;
                case 3:
                    panelLabelsBackground.PanelBackStyle = PaletteBackStyle.ControlClient;
                    break;
                case 4:
                    panelLabelsBackground.PanelBackStyle = PaletteBackStyle.ControlAlternate;
                    break;
                case 5:
                    panelLabelsBackground.PanelBackStyle = PaletteBackStyle.ControlCustom1;
                    break;
                case 6:
                    panelLabelsBackground.PanelBackStyle = PaletteBackStyle.ControlToolTip;
                    break;
            }

            panelLabelsBackground.Refresh();
        }

        private void kryptonNavigatorDesignTabs_SelectedPageChanged(object sender, EventArgs e)
        {
            // Update the design page text with the selected style information
            pageDesignTabs.TextTitle = kryptonNavigatorDesignTabs.SelectedPage.Text;
            pageDesignTabs.TextDescription = kryptonNavigatorDesignTabs.SelectedPage.TextDescription;

            // Work out the tab style to show in the navigator
            switch (kryptonNavigatorDesignTabs.SelectedIndex)
            {
                default:
                case 0:
                    kryptonNavigatorTabs.Bar.TabStyle = TabStyle.HighProfile;
                    break;
                case 1:
                    kryptonNavigatorTabs.Bar.TabStyle = TabStyle.StandardProfile;
                    break;
                case 2:
                    kryptonNavigatorTabs.Bar.TabStyle = TabStyle.LowProfile;
                    break;
                case 3:
                    kryptonNavigatorTabs.Bar.TabStyle = TabStyle.OneNote;
                    break;
                case 4:
                    kryptonNavigatorTabs.Bar.TabStyle = TabStyle.Dock;
                    break;
                case 5:
                    kryptonNavigatorTabs.Bar.TabStyle = TabStyle.DockAutoHidden;
                    break;
                case 6:
                    kryptonNavigatorTabs.Bar.TabStyle = TabStyle.Custom1;
                    break;
                case 7:
                    kryptonNavigatorTabs.Bar.TabStyle = TabStyle.Custom2;
                    break;
                case 8:
                    kryptonNavigatorTabs.Bar.TabStyle = TabStyle.Custom3;
                    break;
            }
        }

        private void kryptonNavigatorDesignNavigator_SelectedPageChanged(object sender, EventArgs e)
        {
            // Update the design page text with the selected style information
            pageDesignNavigator.TextTitle = kryptonNavigatorDesignNavigator.SelectedPage.Text;
            pageDesignNavigator.TextDescription = kryptonNavigatorDesignNavigator.SelectedPage.TextDescription;

            // Work out the navigator mode required
            switch (kryptonNavigatorDesignNavigator.SelectedIndex)
            {
                default:
                case 0:
                    kryptonNavigator.NavigatorMode = NavigatorMode.BarCheckButtonGroupOutside;
                    break;
                case 1:
                    kryptonNavigator.NavigatorMode = NavigatorMode.BarCheckButtonGroupInside;
                    break;
                case 2:
                    kryptonNavigator.NavigatorMode = NavigatorMode.BarCheckButtonGroupOnly;
                    break;
            }
        }

        private void kryptonNavigatorDesignPanels_SelectedPageChanged(object sender, EventArgs e)
        {
            // Update the design page text with the selected style information
            pageDesignPanels.TextTitle = kryptonNavigatorDesignPanels.SelectedPage.Text;
            pageDesignPanels.TextDescription = kryptonNavigatorDesignPanels.SelectedPage.TextDescription;

            PaletteBackStyle backStyle;

            // Work out the panel style to be used
            switch (kryptonNavigatorDesignPanels.SelectedIndex)
            {
                default:
                case 0:
                    backStyle = PaletteBackStyle.PanelClient;
                    break;
                case 1:
                    backStyle = PaletteBackStyle.PanelAlternate;
                    break;
                case 2:
                    backStyle = PaletteBackStyle.PanelRibbonInactive;
                    break;
                case 3:
                    backStyle = PaletteBackStyle.PanelCustom1;
                    break;
            }

            // Update all the displayed controls with the new styles
            panel1Disabled.PanelBackStyle = backStyle;
            panel1Normal.PanelBackStyle = backStyle;
        }

        private void kryptonNavigatorDesignSeparators_SelectedPageChanged(object sender, EventArgs e)
        {
            // Update the design page text with the selected style information
            pageDesignSeparators.TextTitle = kryptonNavigatorDesignSeparators.SelectedPage.Text;
            pageDesignSeparators.TextDescription = kryptonNavigatorDesignSeparators.SelectedPage.TextDescription;

            SeparatorStyle separatorStyle;

            // Work out the navigator mode required
            switch (kryptonNavigatorDesignSeparators.SelectedIndex)
            {
                default:
                case 0:
                    separatorStyle = SeparatorStyle.LowProfile;
                    break;
                case 1:
                    separatorStyle = SeparatorStyle.HighProfile;
                    break;
                case 2:
                    separatorStyle = SeparatorStyle.HighInternalProfile;
                    break;
                case 3:
                    separatorStyle = SeparatorStyle.Custom1;
                    break;
            }

            // Update all the displayed controls with the new styles
            separator1Disabled.SeparatorStyle = separatorStyle;
            separator1Normal.SeparatorStyle = separatorStyle;
            separator1Tracking.SeparatorStyle = separatorStyle;
            separator1Pressed.SeparatorStyle = separatorStyle;
            separator1Live.SeparatorStyle = separatorStyle;
        }

        private void kryptonNavigatorDesignGrids_SelectedPageChanged(object sender, EventArgs e)
        {
            // Update the design page text with the selected style information
            pageDesignGrid.TextTitle = kryptonNavigatorDesignGrids.SelectedPage.Text;
            pageDesignGrid.TextDescription = kryptonNavigatorDesignGrids.SelectedPage.TextDescription;

            DataGridViewStyle gridStyle;

            // Work out the navigator mode required
            switch (kryptonNavigatorDesignGrids.SelectedIndex)
            {
                default:
                case 0:
                    gridStyle = DataGridViewStyle.List;
                    break;
                case 1:
                    gridStyle = DataGridViewStyle.Sheet;
                    break;
                case 2:
                    gridStyle = DataGridViewStyle.Custom1;
                    break;
            }

            // Update all the displayed controls with the new styles
            dataGridViewDisabled.GridStyles.Style = gridStyle;
            dataGridViewNormal.GridStyles.Style = gridStyle;
        }
        #endregion

        #region Methods
        private void New()
        {
            if (_dirty)
            {
                switch (KryptonMessageBox.Show(this, "Save changes to the current palette?", "Palette Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        SavePalette();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }

            CreateNewPalette();
        }

        private void Open()
        {
            if (_dirty)
            {
                // Ask user if the current palette should be saved
                switch (KryptonMessageBox.Show(this, "Save changes to the current palette?", "Palette Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        // Use existing save method
                        SavePalette();
                        break;
                    case DialogResult.Cancel:
                        // Cancel out entirely
                        return;
                }
            }

            KryptonPalette _palette = new KryptonPalette();

            Cursor = Cursors.WaitCursor;

            Application.DoEvents();

            string fileName = _paletteTheme.Import();

            Cursor = Cursors.Default;

            if (fileName.Length > 0)
            {
                if (_paletteTheme != null)
                {
                    _paletteTheme.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                }

                _paletteTheme = _palette;

                _tmsChrome.Palette = _paletteTheme;

                _ribbonChrome.OverridePalette = _paletteTheme;

                _paletteTheme.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

                labelGridNormal.SelectedObject = _paletteTheme;

                _fileName = fileName;

                _loaded = true;

                _dirty = false;

                ApplyPalette();

                UpdateTitleBar();
            }

            _mostRecentlyUsedFileManager.AddRecentFile(fileName);
        }

        private void OpenPaletteFile(string paletteFilePath)
        {

        }

        private void SavePalette()
        {
            if (_loaded)
            {
                Cursor = Cursors.WaitCursor;

                Application.DoEvents();

                _paletteTheme.Export(_fileName, true, false);

                _mostRecentlyUsedFileManager.AddRecentFile(_fileName);

                Cursor = Cursors.Default;

                _dirty = false;

                UpdateTitleBar();
            }
            else
            {
                SaveAs();
            }
        }

        private void SaveAs()
        {
            Cursor = Cursors.WaitCursor;

            Application.DoEvents();

            string fileName = _paletteTheme.Export();

            Cursor = Cursors.Default;

            // If the save succeeded
            if (fileName.Length > 0)
            {
                // Remember associated file details
                _fileName = fileName;

                _loaded = true;

                // No longer dirty
                _dirty = false;

                // Define the initial title bar string
                UpdateTitleBar();
            }

            _mostRecentlyUsedFileManager.AddRecentFile(fileName);
        }

        private void Exit()
        {
            // If the current palette has been changed
            if (_dirty)
            {
                // Ask user if the current palette should be saved
                switch (KryptonMessageBox.Show(this, "Save changes to the current palette?", "Palette Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        // Use existing save method
                        SavePalette();
                        break;
                    case DialogResult.Cancel:
                        // Cancel out entirely
                        return;
                }
            }

            Close();
        }
        #endregion

        #region Palettes
        private void CreateNewPalette()
        {
            // Need to unhook from any existing palette
            if (_paletteTheme != null)
            {
                _paletteTheme.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
            }

            // Create a fresh palette instance
            _paletteTheme = new KryptonPalette();

            _tmsChrome.Palette = _paletteTheme;

            _ribbonChrome.OverridePalette = _paletteTheme;

            // We need to know when a change occurs to the palette settings
            _paletteTheme.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            // Hook up the property grid to the palette
            labelGridNormal.SelectedObject = _paletteTheme;

            // Does not have a filename as yet
            _fileName = "(New Palette)";

            // Reset the state flags
            _dirty = false;

            _loaded = false;

            // Apply the new palette to the design controls
            ApplyPalette();

            // Define the initial title bar string
            UpdateTitleBar();
        }

        private void ApplyPalette()
        {
            buttonSpecT1.Palette = _paletteTheme;
            buttonSpecT2.Palette = _paletteTheme;
            buttonSpecT3.Palette = _paletteTheme;
            buttonSpecT4.Palette = _paletteTheme;
            buttonSpecG1.Palette = _paletteTheme;
            buttonSpecG2.Palette = _paletteTheme;
            buttonSpecG3.Palette = _paletteTheme;
            buttonSpecG4.Palette = _paletteTheme;
            buttonDisabled.Palette = _paletteTheme;
            buttonDefaultFocus.Palette = _paletteTheme;
            buttonNormal.Palette = _paletteTheme;
            buttonTracking.Palette = _paletteTheme;
            buttonPressed.Palette = _paletteTheme;
            buttonCheckedNormal.Palette = _paletteTheme;
            buttonCheckedTracking.Palette = _paletteTheme;
            buttonCheckedPressed.Palette = _paletteTheme;
            buttonLive.Palette = _paletteTheme;
            control1Disabled.Palette = _paletteTheme;
            control1Normal.Palette = _paletteTheme;
            textBoxDisabled.Palette = _paletteTheme;
            textBoxNormal.Palette = _paletteTheme;
            textBoxActive.Palette = _paletteTheme;
            comboBoxDisabled.Palette = _paletteTheme;
            comboBoxNormal.Palette = _paletteTheme;
            comboBoxActive.Palette = _paletteTheme;
            numericDisabled.Palette = _paletteTheme;
            numericNormal.Palette = _paletteTheme;
            numericActive.Palette = _paletteTheme;
            headerGroup1Disabled.Palette = _paletteTheme;
            headerGroup1Normal.Palette = _paletteTheme;
            header1Disabled.Palette = _paletteTheme;
            header1Normal.Palette = _paletteTheme;
            cbLive.Palette = _paletteTheme;
            cbFocus.Palette = _paletteTheme;
            cbUncheckedDisabled.Palette = _paletteTheme;
            cbUncheckedNormal.Palette = _paletteTheme;
            cbUncheckedTracking.Palette = _paletteTheme;
            cbUncheckedPressed.Palette = _paletteTheme;
            cbCheckedDisabled.Palette = _paletteTheme;
            cbCheckedNormal.Palette = _paletteTheme;
            cbCheckedTracking.Palette = _paletteTheme;
            cbCheckedPressed.Palette = _paletteTheme;
            cbIndeterminateDisabled.Palette = _paletteTheme;
            cbIndeterminateNormal.Palette = _paletteTheme;
            cbIndeterminateTracking.Palette = _paletteTheme;
            cbIndeterminatePressed.Palette = _paletteTheme;
            rbFocus.Palette = _paletteTheme;
            rbLive1.Palette = _paletteTheme;
            rbLive2.Palette = _paletteTheme;
            rbCheckedNormal.Palette = _paletteTheme;
            rbCheckedTracking.Palette = _paletteTheme;
            rbCheckedPressed.Palette = _paletteTheme;
            rbUncheckedDisabled.Palette = _paletteTheme;
            rbUncheckedNormal.Palette = _paletteTheme;
            rbUncheckedTracking.Palette = _paletteTheme;
            rbUncheckedPressed.Palette = _paletteTheme;
            label1Disabled.Palette = _paletteTheme;
            label1Normal.Palette = _paletteTheme;
            label1Visited.Palette = _paletteTheme;
            label1NotVisited.Palette = _paletteTheme;
            label1Pressed.Palette = _paletteTheme;
            label1Live.Palette = _paletteTheme;
            panelLabelsBackground.Palette = _paletteTheme;
            kryptonNavigatorTabs.Palette = _paletteTheme;
            kryptonNavigator.Palette = _paletteTheme;
            panel1Disabled.Palette = _paletteTheme;
            panel1Normal.Palette = _paletteTheme;
            separator1Disabled.Palette = _paletteTheme;
            separator1Normal.Palette = _paletteTheme;
            separator1Tracking.Palette = _paletteTheme;
            separator1Pressed.Palette = _paletteTheme;
            separator1Live.Palette = _paletteTheme;
            dataGridViewDisabled.Palette = _paletteTheme;
            dataGridViewNormal.Palette = _paletteTheme;
            monthCalendarEnabled.Palette = _paletteTheme;
            monthCalendarDisabled.Palette = _paletteTheme;
            kryptonTrackBar1.Palette = _paletteTheme;
            kryptonTrackBar2.Palette = _paletteTheme;
            kryptonTrackBar3.Palette = _paletteTheme;
            kryptonTrackBar4.Palette = _paletteTheme;
            kryptonTrackBar5.Palette = _paletteTheme;
            kryptonTrackBar6.Palette = _paletteTheme;
            kryptonTrackBar7.Palette = _paletteTheme;
            kryptonTrackBar8.Palette = _paletteTheme;
            UpdateChromeTMS();
        }

        private void UpdateChromeTMS()
        {
            // Get the global renderer
            IRenderer renderer = _paletteTheme.GetRenderer();

            // Get the new toolstrip renderer based on the design palette
            _tmsChrome.OverrideToolStripRenderer = renderer.RenderToolStrip(_paletteTheme);
        }
        #endregion

        #region Events
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            // Only interested the first time the palette is changed
            if (!_dirty)
            {
                _dirty = true;
                UpdateTitleBar();
            }

            // Do we need to setup a new renderer for the ToolMenuStatus page?
            if (e.NeedColorTable)
                UpdateChromeTMS();
        }
        #endregion

        #region Methods
        private void UpdateTitleBar()
        {
            Text = $"Palette Composer - Developer Edition - Version: { _version.ToString() } - Build: { _version.Build.ToString() } - " + _fileName + (_dirty ? "*" : string.Empty);
        }
        #endregion
    }
}