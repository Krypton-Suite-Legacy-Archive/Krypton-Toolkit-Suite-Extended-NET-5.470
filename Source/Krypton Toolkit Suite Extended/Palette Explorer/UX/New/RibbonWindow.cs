#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using PaletteExplorer.Classes;
using PaletteExplorer.Classes.Controllers;
using PaletteExplorer.Controls;
using PaletteExplorer.UX.Colour;
using PaletteExplorer.UX.Debugging;
using System;
using System.Reflection;
using System.Windows.Forms;
using ToolkitSettings.Classes.Global;
using ToolkitSettings.Classes.PaletteExplorer;
using ToolkitSettings.Classes.PaletteExplorer.Colours;

namespace PaletteExplorer.UX.New
{
    public class RibbonWindow : KryptonForm
    {
        #region Designer Code
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon krControls;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton krqatbNew;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton krqatbOpen;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton krqatbSave;
        private KryptonContextMenuItem kcmiNewPalette;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private KryptonContextMenuItem kcmiOpenPalette;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator2;
        private KryptonContextMenuItem kcmiSavePalette;
        private KryptonContextMenuItem kcmiSavePaletteAs;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator3;
        private KryptonContextMenuItem kcmiExit;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbNewPalette;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbOpenPalette;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbSavePalette;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbExportPalette;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup10;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple23;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbCut;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbCopy;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbPaste;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator15;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple24;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbUndo;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbRedo;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup5;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLabel kryptonRibbonGroupLabel1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupComboBox krgcbBasePaletteMode;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup8;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCheckBox kryptonRibbonGroupCheckBox1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCheckBox kryptonRibbonGroupCheckBox2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple krgtGenerate;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGenerateColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple7;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGetColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator5;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple8;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbBasicColourMixer;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krbViewPaletteFile;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator6;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGenerateContrastColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator krgsManageColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple9;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGetColourInformation;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator8;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple krgtManageColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbManageColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple11;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbInvert;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple12;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbUpdateColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator9;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple13;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbResetColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple14;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbDefineTypefaces;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator10;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple16;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbViewType;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator11;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple17;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbExperimental;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator12;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple19;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbShowHidePropertiesPane;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup6;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple20;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbExportConfigurationFiles;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator14;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple18;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbOptions;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup7;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple21;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbAbout;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator13;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple22;
        private KryptonManager kMan;
        private System.ComponentModel.IContainer components;
        private KryptonPanel kpnlStatusStrip;
        private System.Windows.Forms.StatusStrip ss;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnClose;
        private KryptonLabel lblColourOutput;
        private KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kdm;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbExpertMode;
        private ImageList ilImages;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbShowHideColourPane;
        private KryptonDockableNavigator kdnContentDisplay;
        private KryptonPage kryptonPage1;
        private KryptonPage kryptonPage2;
        private StandardPictureBoxControl spbcStandard;
        private ContextMenuStrip ctxViewTypes;
        private ToolStripMenuItem standardDisplayToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem circularDisplayToolStripMenuItem;
        private ContextMenuStrip ctxReset;
        private ToolStripMenuItem resetColourUIToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem resetColourSettingsToolStripMenuItem;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator16;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple15;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbInspireMe;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem resetColoursToolStripMenuItem;
        private ExtendedControls.ExtendedToolkit.Controls.Drawing.Controls.Office2007ColorPickerToolStripMenuItem cpResetColour;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbColourDebugConsole;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple6;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbColourContrastTool;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator17;
        private CircularPictureBoxControl cpbcPreview;
        private ToolStripStatusLabel tsslCurrentStatus;
        private ToolStripMenuItem customColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem customTextColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem noCustomColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem customColourToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem customTextColourToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripMenuItem noCustomColoursToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripMenuItem normalToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem9;
        private ToolStripMenuItem resetStandardViewToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem10;
        private ToolStripMenuItem resetCircularViewToolStripMenuItem;
        private ContextMenuStrip ctxManageColours;
        private ToolStripMenuItem mergeAllColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem11;
        private ToolStripMenuItem splitColoursToolStripMenuItem;
        private ToolStripMenuItem basicColoursToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem customColoursToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem12;
        private ToolStripMenuItem customTextColoursToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem13;
        private ToolStripMenuItem linkTextColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem14;
        private ToolStripMenuItem miscellaneousColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem15;
        private ToolStripMenuItem standardControlTextColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem16;
        private ToolStripMenuItem textColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem17;
        private ToolStripMenuItem exportColourConfigurationsToolStripMenuItem;
        private ToolStripMenuItem exportAllColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem18;
        private ToolStripMenuItem exportBasicColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem19;
        private ToolStripMenuItem exportCustomColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem20;
        private ToolStripMenuItem exportCustomTextColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem21;
        private ToolStripMenuItem exportLinkTextColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem22;
        private ToolStripMenuItem exportMiscellaneousColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem23;
        private ToolStripMenuItem exportStandardControlTextColoursToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem25;
        private ToolStripMenuItem exportTextColoursToolStripMenuItem;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbCheckForUpdates;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonWindow));
            this.krControls = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.krqatbNew = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.krqatbOpen = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.krqatbSave = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.kcmiNewPalette = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kcmiOpenPalette = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kcmiSavePalette = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kcmiSavePaletteAs = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kcmiExit = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbNewPalette = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbOpenPalette = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbSavePalette = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbExportPalette = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup10 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple23 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbCut = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbCopy = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbPaste = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator15 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple24 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbUndo = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbRedo = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines();
            this.kryptonRibbonGroupLabel1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLabel();
            this.krgcbBasePaletteMode = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupComboBox();
            this.kryptonRibbonGroup8 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines();
            this.kryptonRibbonGroupCheckBox1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCheckBox();
            this.kryptonRibbonGroupCheckBox2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCheckBox();
            this.kryptonRibbonTab2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.krgtGenerate = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGenerateColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator16 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple15 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbInspireMe = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple7 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGetColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbColourContrastTool = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator17 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple8 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbBasicColourMixer = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krbViewPaletteFile = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGenerateContrastColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgsManageColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.krgtManageColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbManageColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.ctxManageColours = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mergeAllColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.splitColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customColoursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.customTextColoursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.linkTextColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.miscellaneousColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripSeparator();
            this.standardControlTextColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripSeparator();
            this.textColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.exportColourConfigurationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.exportBasicColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripSeparator();
            this.exportCustomColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripSeparator();
            this.exportCustomTextColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripSeparator();
            this.exportLinkTextColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripSeparator();
            this.exportMiscellaneousColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripSeparator();
            this.exportStandardControlTextColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripSeparator();
            this.exportTextColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonRibbonGroupSeparator8 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple11 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbInvert = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple12 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbUpdateColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator9 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple13 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbResetColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.ctxReset = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetColourUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetColourSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.resetColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpResetColour = new ExtendedControls.ExtendedToolkit.Controls.Drawing.Controls.Office2007ColorPickerToolStripMenuItem();
            this.kryptonRibbonGroupTriple9 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGetColourInformation = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple14 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbDefineTypefaces = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator10 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroup4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple16 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbViewType = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.ctxViewTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.standardDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.customTextColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.noCustomColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.resetStandardViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.circularDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.customTextColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.noCustomColoursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.normalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.resetCircularViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonRibbonGroupSeparator11 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple17 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbExperimental = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator12 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple19 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbShowHidePropertiesPane = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbShowHideColourPane = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple20 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbExportConfigurationFiles = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator14 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple18 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbOptions = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbExpertMode = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbColourDebugConsole = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup7 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple21 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbAbout = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator13 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple22 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbCheckForUpdates = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kpnlStatusStrip = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tsslCurrentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblColourOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kdnContentDisplay = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.spbcStandard = new PaletteExplorer.Controls.StandardPictureBoxControl();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.cpbcPreview = new PaletteExplorer.Controls.CircularPictureBoxControl();
            this.kdm = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.ilImages = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.krControls)).BeginInit();
            this.ctxManageColours.SuspendLayout();
            this.ctxReset.SuspendLayout();
            this.ctxViewTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlStatusStrip)).BeginInit();
            this.kpnlStatusStrip.SuspendLayout();
            this.ss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdnContentDisplay)).BeginInit();
            this.kdnContentDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // krControls
            // 
            this.krControls.AllowFormIntegrate = true;
            this.krControls.InDesignHelperMode = true;
            this.krControls.Name = "krControls";
            this.krControls.QATButtons.AddRange(new System.ComponentModel.Component[] {
            this.krqatbNew,
            this.krqatbOpen,
            this.krqatbSave});
            this.krControls.RibbonAppButton.AppButtonImage = global::PaletteExplorer.Properties.Resources.PE_Icon_24_x_24;
            this.krControls.RibbonAppButton.AppButtonMenuItems.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kcmiNewPalette,
            this.kryptonContextMenuSeparator1,
            this.kcmiOpenPalette,
            this.kryptonContextMenuSeparator2,
            this.kcmiSavePalette,
            this.kcmiSavePaletteAs,
            this.kryptonContextMenuSeparator3,
            this.kcmiExit});
            this.krControls.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1,
            this.kryptonRibbonTab2,
            this.kryptonRibbonTab3,
            this.kryptonRibbonTab4});
            this.krControls.SelectedTab = this.kryptonRibbonTab2;
            this.krControls.Size = new System.Drawing.Size(1662, 115);
            this.krControls.TabIndex = 2;
            // 
            // krqatbNew
            // 
            this.krqatbNew.Image = ((System.Drawing.Image)(resources.GetObject("krqatbNew.Image")));
            // 
            // krqatbOpen
            // 
            this.krqatbOpen.Image = ((System.Drawing.Image)(resources.GetObject("krqatbOpen.Image")));
            // 
            // krqatbSave
            // 
            this.krqatbSave.Image = ((System.Drawing.Image)(resources.GetObject("krqatbSave.Image")));
            // 
            // kcmiNewPalette
            // 
            this.kcmiNewPalette.Text = "New Palette";
            // 
            // kcmiOpenPalette
            // 
            this.kcmiOpenPalette.Text = "Open Palette";
            // 
            // kcmiSavePalette
            // 
            this.kcmiSavePalette.Text = "Save Palette";
            // 
            // kcmiSavePaletteAs
            // 
            this.kcmiSavePaletteAs.Text = "Save Palette As";
            // 
            // kcmiExit
            // 
            this.kcmiExit.Text = "Exit";
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.kryptonRibbonGroup10,
            this.kryptonRibbonGroup5,
            this.kryptonRibbonGroup8});
            this.kryptonRibbonTab1.Text = "&General";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1,
            this.kryptonRibbonGroupSeparator1,
            this.kryptonRibbonGroupTriple2,
            this.kryptonRibbonGroupSeparator2,
            this.kryptonRibbonGroupTriple3});
            this.kryptonRibbonGroup1.TextLine1 = "File";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbNewPalette});
            // 
            // krgbNewPalette
            // 
            this.krgbNewPalette.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbNewPalette.ImageLarge")));
            this.krgbNewPalette.ImageSmall = ((System.Drawing.Image)(resources.GetObject("krgbNewPalette.ImageSmall")));
            this.krgbNewPalette.TextLine1 = "New";
            this.krgbNewPalette.TextLine2 = "Palette";
            this.krgbNewPalette.Click += new System.EventHandler(this.KrgbNewPalette_Click);
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbOpenPalette});
            // 
            // krgbOpenPalette
            // 
            this.krgbOpenPalette.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbOpenPalette.ImageLarge")));
            this.krgbOpenPalette.ImageSmall = ((System.Drawing.Image)(resources.GetObject("krgbOpenPalette.ImageSmall")));
            this.krgbOpenPalette.TextLine1 = "Open";
            this.krgbOpenPalette.TextLine2 = " Palette";
            this.krgbOpenPalette.Click += new System.EventHandler(this.KrgbOpenPalette_Click);
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbSavePalette,
            this.krgbExportPalette});
            // 
            // krgbSavePalette
            // 
            this.krgbSavePalette.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbSavePalette.ImageLarge")));
            this.krgbSavePalette.ImageSmall = ((System.Drawing.Image)(resources.GetObject("krgbSavePalette.ImageSmall")));
            this.krgbSavePalette.TextLine1 = "Save";
            this.krgbSavePalette.TextLine2 = "Palette";
            this.krgbSavePalette.Click += new System.EventHandler(this.KrgbSavePalette_Click);
            // 
            // krgbExportPalette
            // 
            this.krgbExportPalette.ImageLarge = global::PaletteExplorer.Properties.Resources.Export_32_x_32;
            this.krgbExportPalette.ImageSmall = global::PaletteExplorer.Properties.Resources.Export_16_x_16;
            this.krgbExportPalette.TextLine1 = "Export";
            // 
            // kryptonRibbonGroup10
            // 
            this.kryptonRibbonGroup10.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple23,
            this.kryptonRibbonGroupSeparator15,
            this.kryptonRibbonGroupTriple24});
            this.kryptonRibbonGroup10.TextLine1 = "General";
            this.kryptonRibbonGroup10.Visible = false;
            // 
            // kryptonRibbonGroupTriple23
            // 
            this.kryptonRibbonGroupTriple23.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbCut,
            this.krgbCopy,
            this.krgbPaste});
            // 
            // krgbCut
            // 
            this.krgbCut.TextLine1 = "Cut";
            // 
            // krgbCopy
            // 
            this.krgbCopy.TextLine1 = "Copy";
            // 
            // krgbPaste
            // 
            this.krgbPaste.Enabled = false;
            this.krgbPaste.TextLine1 = "Paste";
            // 
            // kryptonRibbonGroupTriple24
            // 
            this.kryptonRibbonGroupTriple24.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbUndo,
            this.krgbRedo});
            // 
            // krgbUndo
            // 
            this.krgbUndo.Enabled = false;
            this.krgbUndo.TextLine1 = "Undo";
            // 
            // krgbRedo
            // 
            this.krgbRedo.Enabled = false;
            this.krgbRedo.TextLine1 = "Redo";
            // 
            // kryptonRibbonGroup5
            // 
            this.kryptonRibbonGroup5.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines2});
            this.kryptonRibbonGroup5.TextLine1 = "Palette Mode";
            // 
            // kryptonRibbonGroupLines2
            // 
            this.kryptonRibbonGroupLines2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupLabel1,
            this.krgcbBasePaletteMode});
            // 
            // kryptonRibbonGroupLabel1
            // 
            this.kryptonRibbonGroupLabel1.TextLine1 = "Base Palette Mode:";
            // 
            // krgcbBasePaletteMode
            // 
            this.krgcbBasePaletteMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krgcbBasePaletteMode.DropDownWidth = 200;
            this.krgcbBasePaletteMode.FormattingEnabled = false;
            this.krgcbBasePaletteMode.ItemHeight = 15;
            this.krgcbBasePaletteMode.Text = "";
            // 
            // kryptonRibbonGroup8
            // 
            this.kryptonRibbonGroup8.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines1});
            this.kryptonRibbonGroup8.Visible = false;
            // 
            // kryptonRibbonGroupLines1
            // 
            this.kryptonRibbonGroupLines1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupCheckBox1,
            this.kryptonRibbonGroupCheckBox2});
            // 
            // kryptonRibbonTab2
            // 
            this.kryptonRibbonTab2.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup3,
            this.kryptonRibbonGroup2,
            this.kryptonRibbonGroup4});
            this.kryptonRibbonTab2.Text = "O&ptions";
            // 
            // kryptonRibbonGroup3
            // 
            this.kryptonRibbonGroup3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.krgtGenerate,
            this.kryptonRibbonGroupSeparator16,
            this.kryptonRibbonGroupTriple15,
            this.kryptonRibbonGroupSeparator4,
            this.kryptonRibbonGroupTriple7,
            this.kryptonRibbonGroupSeparator5,
            this.kryptonRibbonGroupTriple6,
            this.kryptonRibbonGroupSeparator17,
            this.kryptonRibbonGroupTriple8,
            this.kryptonRibbonGroupTriple4,
            this.kryptonRibbonGroupSeparator6,
            this.kryptonRibbonGroupTriple5,
            this.krgsManageColours,
            this.krgtManageColours,
            this.kryptonRibbonGroupSeparator8,
            this.kryptonRibbonGroupTriple11,
            this.kryptonRibbonGroupSeparator3,
            this.kryptonRibbonGroupTriple12,
            this.kryptonRibbonGroupSeparator9,
            this.kryptonRibbonGroupTriple13,
            this.kryptonRibbonGroupTriple9});
            this.kryptonRibbonGroup3.TextLine1 = "Colour Properties";
            // 
            // krgtGenerate
            // 
            this.krgtGenerate.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbGenerateColours});
            // 
            // krgbGenerateColours
            // 
            this.krgbGenerateColours.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbGenerateColours.ImageLarge")));
            this.krgbGenerateColours.ImageSmall = ((System.Drawing.Image)(resources.GetObject("krgbGenerateColours.ImageSmall")));
            this.krgbGenerateColours.TextLine1 = "Generate";
            this.krgbGenerateColours.TextLine2 = "Colours";
            this.krgbGenerateColours.ToolTipBody = "Generates the base palette colours.";
            this.krgbGenerateColours.ToolTipImage = global::PaletteExplorer.Properties.Resources.Generate_Colours_32_x_32;
            this.krgbGenerateColours.ToolTipTitle = "Generate Colours";
            this.krgbGenerateColours.Click += new System.EventHandler(this.KrgbGenerateColours_Click);
            // 
            // kryptonRibbonGroupTriple15
            // 
            this.kryptonRibbonGroupTriple15.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbInspireMe});
            // 
            // krgbInspireMe
            // 
            this.krgbInspireMe.ImageLarge = global::PaletteExplorer.Properties.Resources.light_bulb_32_x_32;
            this.krgbInspireMe.ImageSmall = global::PaletteExplorer.Properties.Resources.light_bulb_16_x_16;
            this.krgbInspireMe.TextLine1 = "Inspire";
            this.krgbInspireMe.TextLine2 = "Me";
            this.krgbInspireMe.ToolTipBody = "Randomise each colour.";
            this.krgbInspireMe.ToolTipImage = global::PaletteExplorer.Properties.Resources.light_bulb_32_x_32;
            this.krgbInspireMe.ToolTipTitle = "Inspire Me";
            this.krgbInspireMe.Click += new System.EventHandler(this.KrgbInspireMe_Click);
            // 
            // kryptonRibbonGroupTriple7
            // 
            this.kryptonRibbonGroupTriple7.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbGetColours});
            // 
            // krgbGetColours
            // 
            this.krgbGetColours.ImageLarge = global::PaletteExplorer.Properties.Resources.Colour_Wheel_32_x_32;
            this.krgbGetColours.ImageSmall = global::PaletteExplorer.Properties.Resources.Colour_Wheel_16_x_16;
            this.krgbGetColours.TextLine1 = "Get";
            this.krgbGetColours.TextLine2 = "Colours";
            this.krgbGetColours.Click += new System.EventHandler(this.KrgbGetColours_Click);
            // 
            // kryptonRibbonGroupTriple6
            // 
            this.kryptonRibbonGroupTriple6.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbColourContrastTool});
            // 
            // krgbColourContrastTool
            // 
            this.krgbColourContrastTool.ImageLarge = global::PaletteExplorer.Properties.Resources.Colour_Contrast_32_x_32;
            this.krgbColourContrastTool.ImageSmall = global::PaletteExplorer.Properties.Resources.Colour_Contrast_16_x_16;
            this.krgbColourContrastTool.TextLine1 = "Colour";
            this.krgbColourContrastTool.TextLine2 = "Contrast Tool";
            this.krgbColourContrastTool.Click += new System.EventHandler(this.KrgbColourContrastTool_Click);
            // 
            // kryptonRibbonGroupTriple8
            // 
            this.kryptonRibbonGroupTriple8.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbBasicColourMixer});
            this.kryptonRibbonGroupTriple8.Visible = false;
            // 
            // krgbBasicColourMixer
            // 
            this.krgbBasicColourMixer.TextLine1 = "Basic Colour";
            this.krgbBasicColourMixer.TextLine2 = "Mixer";
            this.krgbBasicColourMixer.Click += new System.EventHandler(this.KrgbBasicColourMixer_Click);
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krbViewPaletteFile});
            // 
            // krbViewPaletteFile
            // 
            this.krbViewPaletteFile.TextLine1 = "View";
            this.krbViewPaletteFile.TextLine2 = "Palette File";
            // 
            // kryptonRibbonGroupTriple5
            // 
            this.kryptonRibbonGroupTriple5.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbGenerateContrastColours});
            // 
            // krgbGenerateContrastColours
            // 
            this.krgbGenerateContrastColours.TextLine1 = "Generate";
            this.krgbGenerateContrastColours.TextLine2 = "Contrast Colours";
            // 
            // krgtManageColours
            // 
            this.krgtManageColours.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbManageColours});
            // 
            // krgbManageColours
            // 
            this.krgbManageColours.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.DropDown;
            this.krgbManageColours.ContextMenuStrip = this.ctxManageColours;
            this.krgbManageColours.TextLine1 = "Manage";
            this.krgbManageColours.TextLine2 = "Colours";
            // 
            // ctxManageColours
            // 
            this.ctxManageColours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxManageColours.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeAllColoursToolStripMenuItem,
            this.toolStripMenuItem11,
            this.splitColoursToolStripMenuItem,
            this.toolStripMenuItem17,
            this.exportColourConfigurationsToolStripMenuItem});
            this.ctxManageColours.Name = "ctxManageColours";
            this.ctxManageColours.Size = new System.Drawing.Size(230, 82);
            // 
            // mergeAllColoursToolStripMenuItem
            // 
            this.mergeAllColoursToolStripMenuItem.Name = "mergeAllColoursToolStripMenuItem";
            this.mergeAllColoursToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.mergeAllColoursToolStripMenuItem.Text = "Merge &All Colours";
            this.mergeAllColoursToolStripMenuItem.Click += new System.EventHandler(this.MergeAllColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(226, 6);
            // 
            // splitColoursToolStripMenuItem
            // 
            this.splitColoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicColoursToolStripMenuItem,
            this.toolStripSeparator2,
            this.customColoursToolStripMenuItem1,
            this.toolStripMenuItem12,
            this.customTextColoursToolStripMenuItem1,
            this.toolStripMenuItem13,
            this.linkTextColoursToolStripMenuItem,
            this.toolStripMenuItem14,
            this.miscellaneousColoursToolStripMenuItem,
            this.toolStripMenuItem15,
            this.standardControlTextColoursToolStripMenuItem,
            this.toolStripMenuItem16,
            this.textColoursToolStripMenuItem});
            this.splitColoursToolStripMenuItem.Name = "splitColoursToolStripMenuItem";
            this.splitColoursToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.splitColoursToolStripMenuItem.Text = "&Split Colours";
            // 
            // basicColoursToolStripMenuItem
            // 
            this.basicColoursToolStripMenuItem.Name = "basicColoursToolStripMenuItem";
            this.basicColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.basicColoursToolStripMenuItem.Text = "&Basic Colours";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // customColoursToolStripMenuItem1
            // 
            this.customColoursToolStripMenuItem1.Name = "customColoursToolStripMenuItem1";
            this.customColoursToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.customColoursToolStripMenuItem1.Text = "&Custom Colours";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(229, 6);
            // 
            // customTextColoursToolStripMenuItem1
            // 
            this.customTextColoursToolStripMenuItem1.Name = "customTextColoursToolStripMenuItem1";
            this.customTextColoursToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.customTextColoursToolStripMenuItem1.Text = "Custom &Text Colours";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(229, 6);
            // 
            // linkTextColoursToolStripMenuItem
            // 
            this.linkTextColoursToolStripMenuItem.Name = "linkTextColoursToolStripMenuItem";
            this.linkTextColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.linkTextColoursToolStripMenuItem.Text = "&Link Text Colours";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(229, 6);
            // 
            // miscellaneousColoursToolStripMenuItem
            // 
            this.miscellaneousColoursToolStripMenuItem.Name = "miscellaneousColoursToolStripMenuItem";
            this.miscellaneousColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.miscellaneousColoursToolStripMenuItem.Text = "&Miscellaneous Colours";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(229, 6);
            // 
            // standardControlTextColoursToolStripMenuItem
            // 
            this.standardControlTextColoursToolStripMenuItem.Name = "standardControlTextColoursToolStripMenuItem";
            this.standardControlTextColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.standardControlTextColoursToolStripMenuItem.Text = "&Standard Control Text Colours";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(229, 6);
            // 
            // textColoursToolStripMenuItem
            // 
            this.textColoursToolStripMenuItem.Name = "textColoursToolStripMenuItem";
            this.textColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.textColoursToolStripMenuItem.Text = "T&ext Colours";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(226, 6);
            // 
            // exportColourConfigurationsToolStripMenuItem
            // 
            this.exportColourConfigurationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAllColoursToolStripMenuItem,
            this.toolStripMenuItem18,
            this.exportBasicColoursToolStripMenuItem,
            this.toolStripMenuItem19,
            this.exportCustomColoursToolStripMenuItem,
            this.toolStripMenuItem20,
            this.exportCustomTextColoursToolStripMenuItem,
            this.toolStripMenuItem21,
            this.exportLinkTextColoursToolStripMenuItem,
            this.toolStripMenuItem22,
            this.exportMiscellaneousColoursToolStripMenuItem,
            this.toolStripMenuItem23,
            this.exportStandardControlTextColoursToolStripMenuItem,
            this.toolStripMenuItem25,
            this.exportTextColoursToolStripMenuItem});
            this.exportColourConfigurationsToolStripMenuItem.Name = "exportColourConfigurationsToolStripMenuItem";
            this.exportColourConfigurationsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.exportColourConfigurationsToolStripMenuItem.Text = "&Export Colour Configurations";
            // 
            // exportAllColoursToolStripMenuItem
            // 
            this.exportAllColoursToolStripMenuItem.Name = "exportAllColoursToolStripMenuItem";
            this.exportAllColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.exportAllColoursToolStripMenuItem.Text = "&All Colours";
            this.exportAllColoursToolStripMenuItem.Click += new System.EventHandler(this.ExportAllColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(229, 6);
            // 
            // exportBasicColoursToolStripMenuItem
            // 
            this.exportBasicColoursToolStripMenuItem.Name = "exportBasicColoursToolStripMenuItem";
            this.exportBasicColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.exportBasicColoursToolStripMenuItem.Text = "B&asic Colours";
            this.exportBasicColoursToolStripMenuItem.Click += new System.EventHandler(this.ExportBasicColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(229, 6);
            // 
            // exportCustomColoursToolStripMenuItem
            // 
            this.exportCustomColoursToolStripMenuItem.Name = "exportCustomColoursToolStripMenuItem";
            this.exportCustomColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.exportCustomColoursToolStripMenuItem.Text = "&Custom Colours";
            this.exportCustomColoursToolStripMenuItem.Click += new System.EventHandler(this.ExportCustomColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(229, 6);
            // 
            // exportCustomTextColoursToolStripMenuItem
            // 
            this.exportCustomTextColoursToolStripMenuItem.Name = "exportCustomTextColoursToolStripMenuItem";
            this.exportCustomTextColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.exportCustomTextColoursToolStripMenuItem.Text = "Custom &Text Colours";
            this.exportCustomTextColoursToolStripMenuItem.Click += new System.EventHandler(this.ExportCustomTextColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(229, 6);
            // 
            // exportLinkTextColoursToolStripMenuItem
            // 
            this.exportLinkTextColoursToolStripMenuItem.Name = "exportLinkTextColoursToolStripMenuItem";
            this.exportLinkTextColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.exportLinkTextColoursToolStripMenuItem.Text = "&Link Text Colours";
            this.exportLinkTextColoursToolStripMenuItem.Click += new System.EventHandler(this.ExportLinkTextColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(229, 6);
            // 
            // exportMiscellaneousColoursToolStripMenuItem
            // 
            this.exportMiscellaneousColoursToolStripMenuItem.Name = "exportMiscellaneousColoursToolStripMenuItem";
            this.exportMiscellaneousColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.exportMiscellaneousColoursToolStripMenuItem.Text = "&Miscellaneous Colours";
            this.exportMiscellaneousColoursToolStripMenuItem.Click += new System.EventHandler(this.ExportMiscellaneousColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(229, 6);
            // 
            // exportStandardControlTextColoursToolStripMenuItem
            // 
            this.exportStandardControlTextColoursToolStripMenuItem.Name = "exportStandardControlTextColoursToolStripMenuItem";
            this.exportStandardControlTextColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.exportStandardControlTextColoursToolStripMenuItem.Text = "&Standard Control Text Colours";
            this.exportStandardControlTextColoursToolStripMenuItem.Click += new System.EventHandler(this.ExportStandardControlTextColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(229, 6);
            // 
            // exportTextColoursToolStripMenuItem
            // 
            this.exportTextColoursToolStripMenuItem.Name = "exportTextColoursToolStripMenuItem";
            this.exportTextColoursToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.exportTextColoursToolStripMenuItem.Text = "T&ext Colours";
            this.exportTextColoursToolStripMenuItem.Click += new System.EventHandler(this.ExportTextColoursToolStripMenuItem_Click);
            // 
            // kryptonRibbonGroupTriple11
            // 
            this.kryptonRibbonGroupTriple11.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbInvert});
            // 
            // krgbInvert
            // 
            this.krgbInvert.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.krgbInvert.Enabled = false;
            this.krgbInvert.ImageLarge = global::PaletteExplorer.Properties.Resources.Invert_Colours_v1_32_x_32;
            this.krgbInvert.ImageSmall = global::PaletteExplorer.Properties.Resources.Invert_Colours_v1_16_x_16;
            this.krgbInvert.TextLine1 = "Invert";
            this.krgbInvert.TextLine2 = "Colours";
            // 
            // kryptonRibbonGroupTriple12
            // 
            this.kryptonRibbonGroupTriple12.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbUpdateColours});
            // 
            // krgbUpdateColours
            // 
            this.krgbUpdateColours.ImageLarge = global::PaletteExplorer.Properties.Resources.Refresh_32_x_32;
            this.krgbUpdateColours.ImageSmall = global::PaletteExplorer.Properties.Resources.Refresh_16_x_16;
            this.krgbUpdateColours.TextLine1 = "Update";
            this.krgbUpdateColours.TextLine2 = "Colours";
            // 
            // kryptonRibbonGroupTriple13
            // 
            this.kryptonRibbonGroupTriple13.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbResetColours});
            // 
            // krgbResetColours
            // 
            this.krgbResetColours.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Split;
            this.krgbResetColours.ContextMenuStrip = this.ctxReset;
            this.krgbResetColours.ImageLarge = global::PaletteExplorer.Properties.Resources.Reset_32_x_32;
            this.krgbResetColours.ImageSmall = global::PaletteExplorer.Properties.Resources.Reset_16_x_16;
            this.krgbResetColours.TextLine1 = "Reset";
            this.krgbResetColours.TextLine2 = "Colours";
            // 
            // ctxReset
            // 
            this.ctxReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxReset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetColourUIToolStripMenuItem,
            this.toolStripMenuItem2,
            this.resetColourSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.resetColoursToolStripMenuItem});
            this.ctxReset.Name = "ctxReset";
            this.ctxReset.Size = new System.Drawing.Size(187, 82);
            // 
            // resetColourUIToolStripMenuItem
            // 
            this.resetColourUIToolStripMenuItem.Name = "resetColourUIToolStripMenuItem";
            this.resetColourUIToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resetColourUIToolStripMenuItem.Text = "Reset Colour &UI";
            this.resetColourUIToolStripMenuItem.Click += new System.EventHandler(this.ResetColourUIToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // resetColourSettingsToolStripMenuItem
            // 
            this.resetColourSettingsToolStripMenuItem.Name = "resetColourSettingsToolStripMenuItem";
            this.resetColourSettingsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resetColourSettingsToolStripMenuItem.Text = "Reset Colour Settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // resetColoursToolStripMenuItem
            // 
            this.resetColoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cpResetColour});
            this.resetColoursToolStripMenuItem.Name = "resetColoursToolStripMenuItem";
            this.resetColoursToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resetColoursToolStripMenuItem.Text = "Reset &Colours";
            // 
            // cpResetColour
            // 
            this.cpResetColour.Name = "cpResetColour";
            // 
            // cpResetColour
            // 
            this.cpResetColour.Office2007ColourPickerControl.AccessibleName = "cpResetColour";
            this.cpResetColour.Office2007ColourPickerControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cpResetColour.Office2007ColourPickerControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpResetColour.Office2007ColourPickerControl.Items.AddRange(new object[] {
            "Color"});
            this.cpResetColour.Office2007ColourPickerControl.Location = new System.Drawing.Point(33, 3);
            this.cpResetColour.Office2007ColourPickerControl.Name = "office2007ColorPickerToolStripMenuItem1";
            this.cpResetColour.Office2007ColourPickerControl.SelectedColour = System.Drawing.Color.Black;
            this.cpResetColour.Office2007ColourPickerControl.Size = new System.Drawing.Size(121, 24);
            this.cpResetColour.Office2007ColourPickerControl.TabIndex = 2;
            this.cpResetColour.Office2007ColourPickerControl.SelectedColourChanged += new System.EventHandler(this.Office2007ColorPickerToolStripMenuItem1_Office2007ColourPickerControl_SelectedColourChanged);
            this.cpResetColour.Size = new System.Drawing.Size(121, 23);
            this.cpResetColour.Text = "Color";
            // 
            // kryptonRibbonGroupTriple9
            // 
            this.kryptonRibbonGroupTriple9.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbGetColourInformation});
            // 
            // krgbGetColourInformation
            // 
            this.krgbGetColourInformation.TextLine1 = "Get Colour";
            this.krgbGetColourInformation.TextLine2 = "Information";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple14,
            this.kryptonRibbonGroupSeparator10});
            this.kryptonRibbonGroup2.Visible = false;
            // 
            // kryptonRibbonGroupTriple14
            // 
            this.kryptonRibbonGroupTriple14.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbDefineTypefaces});
            // 
            // krgbDefineTypefaces
            // 
            this.krgbDefineTypefaces.TextLine1 = "Define";
            this.krgbDefineTypefaces.TextLine2 = "Typefaces";
            // 
            // kryptonRibbonGroup4
            // 
            this.kryptonRibbonGroup4.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple16,
            this.kryptonRibbonGroupSeparator11,
            this.kryptonRibbonGroupTriple17,
            this.kryptonRibbonGroupSeparator12,
            this.kryptonRibbonGroupTriple19});
            // 
            // kryptonRibbonGroupTriple16
            // 
            this.kryptonRibbonGroupTriple16.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbViewType});
            // 
            // krgbViewType
            // 
            this.krgbViewType.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Split;
            this.krgbViewType.ContextMenuStrip = this.ctxViewTypes;
            this.krgbViewType.TextLine1 = "View";
            this.krgbViewType.TextLine2 = "Type";
            // 
            // ctxViewTypes
            // 
            this.ctxViewTypes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxViewTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardDisplayToolStripMenuItem,
            this.toolStripMenuItem1,
            this.circularDisplayToolStripMenuItem});
            this.ctxViewTypes.Name = "ctxViewTypes";
            this.ctxViewTypes.Size = new System.Drawing.Size(163, 54);
            // 
            // standardDisplayToolStripMenuItem
            // 
            this.standardDisplayToolStripMenuItem.CheckOnClick = true;
            this.standardDisplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customColoursToolStripMenuItem,
            this.toolStripMenuItem3,
            this.customTextColoursToolStripMenuItem,
            this.toolStripMenuItem4,
            this.noCustomColoursToolStripMenuItem,
            this.toolStripMenuItem5,
            this.normalToolStripMenuItem,
            this.toolStripMenuItem9,
            this.resetStandardViewToolStripMenuItem});
            this.standardDisplayToolStripMenuItem.Name = "standardDisplayToolStripMenuItem";
            this.standardDisplayToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.standardDisplayToolStripMenuItem.Text = "&Standard Display";
            this.standardDisplayToolStripMenuItem.Click += new System.EventHandler(this.StandardDisplayToolStripMenuItem_Click);
            // 
            // customColoursToolStripMenuItem
            // 
            this.customColoursToolStripMenuItem.CheckOnClick = true;
            this.customColoursToolStripMenuItem.Name = "customColoursToolStripMenuItem";
            this.customColoursToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.customColoursToolStripMenuItem.Text = "&Custom Colours";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 6);
            // 
            // customTextColoursToolStripMenuItem
            // 
            this.customTextColoursToolStripMenuItem.CheckOnClick = true;
            this.customTextColoursToolStripMenuItem.Name = "customTextColoursToolStripMenuItem";
            this.customTextColoursToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.customTextColoursToolStripMenuItem.Text = "Custom &Text Colours";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 6);
            // 
            // noCustomColoursToolStripMenuItem
            // 
            this.noCustomColoursToolStripMenuItem.CheckOnClick = true;
            this.noCustomColoursToolStripMenuItem.Name = "noCustomColoursToolStripMenuItem";
            this.noCustomColoursToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.noCustomColoursToolStripMenuItem.Text = "N&o Custom Colours";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(181, 6);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Checked = true;
            this.normalToolStripMenuItem.CheckOnClick = true;
            this.normalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.normalToolStripMenuItem.Text = "&Normal";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(181, 6);
            // 
            // resetStandardViewToolStripMenuItem
            // 
            this.resetStandardViewToolStripMenuItem.Enabled = false;
            this.resetStandardViewToolStripMenuItem.Name = "resetStandardViewToolStripMenuItem";
            this.resetStandardViewToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.resetStandardViewToolStripMenuItem.Text = "Reset &Standard View";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // circularDisplayToolStripMenuItem
            // 
            this.circularDisplayToolStripMenuItem.CheckOnClick = true;
            this.circularDisplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customColourToolStripMenuItem,
            this.toolStripMenuItem6,
            this.customTextColourToolStripMenuItem,
            this.toolStripMenuItem7,
            this.noCustomColoursToolStripMenuItem1,
            this.toolStripMenuItem8,
            this.normalToolStripMenuItem1,
            this.toolStripMenuItem10,
            this.resetCircularViewToolStripMenuItem});
            this.circularDisplayToolStripMenuItem.Name = "circularDisplayToolStripMenuItem";
            this.circularDisplayToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.circularDisplayToolStripMenuItem.Text = "C&ircular Display";
            this.circularDisplayToolStripMenuItem.Click += new System.EventHandler(this.CircularDisplayToolStripMenuItem_Click);
            // 
            // customColourToolStripMenuItem
            // 
            this.customColourToolStripMenuItem.CheckOnClick = true;
            this.customColourToolStripMenuItem.Name = "customColourToolStripMenuItem";
            this.customColourToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.customColourToolStripMenuItem.Text = "&Custom Colours";
            this.customColourToolStripMenuItem.Click += new System.EventHandler(this.CustomColourToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(181, 6);
            // 
            // customTextColourToolStripMenuItem
            // 
            this.customTextColourToolStripMenuItem.CheckOnClick = true;
            this.customTextColourToolStripMenuItem.Name = "customTextColourToolStripMenuItem";
            this.customTextColourToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.customTextColourToolStripMenuItem.Text = "Custom &Text Colours";
            this.customTextColourToolStripMenuItem.Click += new System.EventHandler(this.CustomTextColourToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(181, 6);
            // 
            // noCustomColoursToolStripMenuItem1
            // 
            this.noCustomColoursToolStripMenuItem1.CheckOnClick = true;
            this.noCustomColoursToolStripMenuItem1.Name = "noCustomColoursToolStripMenuItem1";
            this.noCustomColoursToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.noCustomColoursToolStripMenuItem1.Text = "N&o Custom Colours";
            this.noCustomColoursToolStripMenuItem1.Click += new System.EventHandler(this.NoCustomColoursToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(181, 6);
            // 
            // normalToolStripMenuItem1
            // 
            this.normalToolStripMenuItem1.Checked = true;
            this.normalToolStripMenuItem1.CheckOnClick = true;
            this.normalToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalToolStripMenuItem1.Name = "normalToolStripMenuItem1";
            this.normalToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.normalToolStripMenuItem1.Text = "&Normal";
            this.normalToolStripMenuItem1.Click += new System.EventHandler(this.NormalToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(181, 6);
            // 
            // resetCircularViewToolStripMenuItem
            // 
            this.resetCircularViewToolStripMenuItem.Enabled = false;
            this.resetCircularViewToolStripMenuItem.Name = "resetCircularViewToolStripMenuItem";
            this.resetCircularViewToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.resetCircularViewToolStripMenuItem.Text = "Reset &Circular View";
            // 
            // kryptonRibbonGroupTriple17
            // 
            this.kryptonRibbonGroupTriple17.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbExperimental});
            // 
            // krgbExperimental
            // 
            this.krgbExperimental.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.DropDown;
            this.krgbExperimental.TextLine1 = "Experimental";
            // 
            // kryptonRibbonGroupTriple19
            // 
            this.kryptonRibbonGroupTriple19.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbShowHidePropertiesPane,
            this.krgbShowHideColourPane});
            // 
            // krgbShowHidePropertiesPane
            // 
            this.krgbShowHidePropertiesPane.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.krgbShowHidePropertiesPane.ImageLarge = global::PaletteExplorer.Properties.Resources.Property_32_x_32;
            this.krgbShowHidePropertiesPane.ImageSmall = global::PaletteExplorer.Properties.Resources.Property_16_x_16;
            this.krgbShowHidePropertiesPane.TextLine1 = "Show/Hide Palette";
            this.krgbShowHidePropertiesPane.TextLine2 = "Propertes Pane";
            this.krgbShowHidePropertiesPane.Click += new System.EventHandler(this.KrgbShowHidePropertiesPane_Click);
            // 
            // krgbShowHideColourPane
            // 
            this.krgbShowHideColourPane.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.krgbShowHideColourPane.ImageLarge = global::PaletteExplorer.Properties.Resources.Property_32_x_32;
            this.krgbShowHideColourPane.ImageSmall = global::PaletteExplorer.Properties.Resources.Property_16_x_16;
            this.krgbShowHideColourPane.TextLine1 = "Show/Hide Colour";
            this.krgbShowHideColourPane.TextLine2 = "Properties Pane";
            this.krgbShowHideColourPane.Click += new System.EventHandler(this.KrgbShowHideColourPane_Click);
            // 
            // kryptonRibbonTab3
            // 
            this.kryptonRibbonTab3.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup6});
            this.kryptonRibbonTab3.Text = "Utili&ties";
            // 
            // kryptonRibbonGroup6
            // 
            this.kryptonRibbonGroup6.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple20,
            this.kryptonRibbonGroupSeparator14,
            this.kryptonRibbonGroupTriple18});
            // 
            // kryptonRibbonGroupTriple20
            // 
            this.kryptonRibbonGroupTriple20.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbExportConfigurationFiles});
            // 
            // krgbExportConfigurationFiles
            // 
            this.krgbExportConfigurationFiles.ImageLarge = global::PaletteExplorer.Properties.Resources.Configration_32_x_32;
            this.krgbExportConfigurationFiles.ImageSmall = global::PaletteExplorer.Properties.Resources.Configration_16_x_16;
            this.krgbExportConfigurationFiles.TextLine1 = "Export Colours to";
            this.krgbExportConfigurationFiles.TextLine2 = "Configuration Files";
            this.krgbExportConfigurationFiles.Click += new System.EventHandler(this.KrgbExportConfigurationFiles_Click);
            // 
            // kryptonRibbonGroupTriple18
            // 
            this.kryptonRibbonGroupTriple18.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbOptions,
            this.krgbExpertMode,
            this.krgbColourDebugConsole});
            // 
            // krgbOptions
            // 
            this.krgbOptions.ImageLarge = global::PaletteExplorer.Properties.Resources.Settings_32_x_32;
            this.krgbOptions.ImageSmall = global::PaletteExplorer.Properties.Resources.Settings_16_x_16;
            this.krgbOptions.TextLine1 = "Options /";
            this.krgbOptions.TextLine2 = "Settings";
            this.krgbOptions.Click += new System.EventHandler(this.KrgbOptions_Click);
            // 
            // krgbExpertMode
            // 
            this.krgbExpertMode.TextLine1 = "Expert";
            this.krgbExpertMode.TextLine2 = "Mode";
            this.krgbExpertMode.Visible = false;
            this.krgbExpertMode.Click += new System.EventHandler(this.krgbExpertMode_Click);
            // 
            // krgbColourDebugConsole
            // 
            this.krgbColourDebugConsole.ImageLarge = global::PaletteExplorer.Properties.Resources.debug_icon_32_x_32;
            this.krgbColourDebugConsole.ImageSmall = global::PaletteExplorer.Properties.Resources.debug_icon_16_x_16;
            this.krgbColourDebugConsole.TextLine1 = "Colour Debug";
            this.krgbColourDebugConsole.TextLine2 = "Console";
            this.krgbColourDebugConsole.Click += new System.EventHandler(this.KrgbColourDebugConsole_Click);
            // 
            // kryptonRibbonTab4
            // 
            this.kryptonRibbonTab4.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup7});
            this.kryptonRibbonTab4.Text = "&Help";
            // 
            // kryptonRibbonGroup7
            // 
            this.kryptonRibbonGroup7.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple21,
            this.kryptonRibbonGroupSeparator13,
            this.kryptonRibbonGroupTriple22});
            // 
            // kryptonRibbonGroupTriple21
            // 
            this.kryptonRibbonGroupTriple21.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbAbout});
            // 
            // krgbAbout
            // 
            this.krgbAbout.ImageLarge = global::PaletteExplorer.Properties.Resources.About_Information_32_x_32;
            this.krgbAbout.ImageSmall = global::PaletteExplorer.Properties.Resources.About_Information_16_x_16;
            this.krgbAbout.TextLine1 = "About";
            // 
            // kryptonRibbonGroupTriple22
            // 
            this.kryptonRibbonGroupTriple22.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbCheckForUpdates});
            // 
            // krgbCheckForUpdates
            // 
            this.krgbCheckForUpdates.ImageLarge = global::PaletteExplorer.Properties.Resources.Software_Update_32_x_32;
            this.krgbCheckForUpdates.ImageSmall = global::PaletteExplorer.Properties.Resources.Software_Update_16_x_16;
            this.krgbCheckForUpdates.TextLine1 = "Check for";
            this.krgbCheckForUpdates.TextLine2 = "Updates";
            // 
            // kMan
            // 
            this.kMan.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kpnlStatusStrip
            // 
            this.kpnlStatusStrip.Controls.Add(this.ss);
            this.kpnlStatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlStatusStrip.Location = new System.Drawing.Point(0, 886);
            this.kpnlStatusStrip.Name = "kpnlStatusStrip";
            this.kpnlStatusStrip.Size = new System.Drawing.Size(1662, 22);
            this.kpnlStatusStrip.TabIndex = 3;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCurrentStatus});
            this.ss.Location = new System.Drawing.Point(0, 0);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(1662, 22);
            this.ss.TabIndex = 46;
            this.ss.Text = "statusStrip1";
            // 
            // tsslCurrentStatus
            // 
            this.tsslCurrentStatus.Name = "tsslCurrentStatus";
            this.tsslCurrentStatus.Size = new System.Drawing.Size(39, 17);
            this.tsslCurrentStatus.Text = "Ready";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnClose);
            this.kryptonPanel2.Controls.Add(this.lblColourOutput);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 832);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1662, 54);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kbtnClose
            // 
            this.kbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnClose.Location = new System.Drawing.Point(1599, 12);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(51, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 64;
            this.kbtnClose.Values.Text = "&Close";
            // 
            // lblColourOutput
            // 
            this.lblColourOutput.Location = new System.Drawing.Point(12, 13);
            this.lblColourOutput.Name = "lblColourOutput";
            this.lblColourOutput.Size = new System.Drawing.Size(6, 2);
            this.lblColourOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourOutput.TabIndex = 63;
            this.lblColourOutput.Values.Text = "";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kdnContentDisplay);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1662, 717);
            this.kryptonPanel3.TabIndex = 5;
            // 
            // kdnContentDisplay
            // 
            this.kdnContentDisplay.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kdnContentDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdnContentDisplay.Location = new System.Drawing.Point(0, 0);
            this.kdnContentDisplay.Name = "kdnContentDisplay";
            this.kdnContentDisplay.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kdnContentDisplay.SelectedIndex = 1;
            this.kdnContentDisplay.Size = new System.Drawing.Size(1662, 717);
            this.kdnContentDisplay.TabIndex = 0;
            this.kdnContentDisplay.Text = "kryptonDockableNavigator1";
            this.kdnContentDisplay.TabMoved += new System.EventHandler<ComponentFactory.Krypton.Navigator.TabMovedEventArgs>(this.KdnContentDisplay_TabMoved);
            this.kdnContentDisplay.TabIndexChanged += new System.EventHandler(this.KdnContentDisplay_TabIndexChanged);
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.spbcStandard);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(1660, 690);
            this.kryptonPage1.Text = "Standard Display";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "49be86230e1f4924a833e71209f61a78";
            // 
            // spbcStandard
            // 
            this.spbcStandard.BackColor = System.Drawing.Color.Transparent;
            this.spbcStandard.ColourDetailsLabel = this.lblColourOutput;
            this.spbcStandard.Location = new System.Drawing.Point(20, 16);
            this.spbcStandard.Name = "spbcStandard";
            this.spbcStandard.Size = new System.Drawing.Size(1625, 660);
            this.spbcStandard.TabIndex = 0;
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.cpbcPreview);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(1660, 690);
            this.kryptonPage2.Text = "Circular Display";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "c93c9b60d5274878be88f907b4809e18";
            // 
            // cpbcPreview
            // 
            this.cpbcPreview.BackColor = System.Drawing.Color.Transparent;
            this.cpbcPreview.LayoutType = PaletteExplorer.Enumerations.ViewLayoutType.CUSTOMCOLOURVIEW;
            this.cpbcPreview.Location = new System.Drawing.Point(11, 16);
            this.cpbcPreview.Name = "cpbcPreview";
            this.cpbcPreview.Size = new System.Drawing.Size(1625, 660);
            this.cpbcPreview.TabIndex = 0;
            // 
            // ilImages
            // 
            this.ilImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilImages.ImageSize = new System.Drawing.Size(16, 16);
            this.ilImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // RibbonWindow
            // 
            this.ClientSize = new System.Drawing.Size(1662, 908);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kpnlStatusStrip);
            this.Controls.Add(this.krControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RibbonWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{0} - Palette Explorer";
            this.UseDropShadow = false;
            this.Load += new System.EventHandler(this.RibbonWindow_Load);
            this.Shown += new System.EventHandler(this.RibbonWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.krControls)).EndInit();
            this.ctxManageColours.ResumeLayout(false);
            this.ctxReset.ResumeLayout(false);
            this.ctxViewTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlStatusStrip)).EndInit();
            this.kpnlStatusStrip.ResumeLayout(false);
            this.kpnlStatusStrip.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kdnContentDisplay)).EndInit();
            this.kdnContentDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Variables
        GeneralPaletteExplorerSettingsManager _generalPaletteExplorerSettingsManager = new GeneralPaletteExplorerSettingsManager();
        GlobalBooleanSettingsManager _globalBooleanSettingsManager = new GlobalBooleanSettingsManager();
        Timer _uiUpdateTimer, _colourUpdateTimer;
        KryptonPage _page;
        PalettePropertyGrid _palettePropertyGrid;
        PaletteMode _paletteMode;
        KryptonPalette _palette = new KryptonPalette(), _temporaryPalette = new KryptonPalette();
        Version _currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets and sets the custom palette implementation.
        /// </summary>
        public KryptonPalette Palette { get => _palette; set => _palette = value; }

        /// <summary>
        /// Gets or sets the temporary palette.
        /// </summary>
        /// <value>
        /// The temporary palette.
        /// </value>
        public KryptonPalette TemporaryPalette { get => _temporaryPalette; set => _temporaryPalette = value; }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        public PaletteMode Mode { get => _paletteMode; set => _paletteMode = value; }
        #endregion

        #region Constructor
        public RibbonWindow()
        {
            InitializeComponent();

            _uiUpdateTimer = new Timer();

            _uiUpdateTimer.Enabled = true;

            _uiUpdateTimer.Interval = 1000;

            _uiUpdateTimer.Tick += UIUpdateTimer_Tick;

            _uiUpdateTimer.Start();

            if (_globalBooleanSettingsManager.GetIsInDeveloperMode()) TextExtra = $"(Build: { _currentVersion.Build.ToString() })";
        }
        #endregion

        #region Event Handlers
        private void RibbonWindow_Load(object sender, EventArgs e)
        {
            InitialiseWindow();
        }

        private void krgbExpertMode_Click(object sender, EventArgs e)
        {
            PaletteExplorerWindow pew = new PaletteExplorerWindow();

            pew.Show();
        }

        private void RibbonWindow_Shown(object sender, EventArgs e)
        {

        }

        private void KrgbShowHidePropertiesPane_Click(object sender, EventArgs e)
        {
            if (krgbShowHidePropertiesPane.Checked)
            {
                KryptonPalettePropertiesWindow kryptonPalettePropertiesWindow = new KryptonPalettePropertiesWindow(Palette);

                kryptonPalettePropertiesWindow.Show();
            }
        }

        private void KrgbShowHideColourPane_Click(object sender, EventArgs e)
        {
            if (krgbShowHideColourPane.Checked)
            {
                KryptonColourPalettePropertiesWindow kryptonColourPalettePropertiesWindow = new KryptonColourPalettePropertiesWindow();

                kryptonColourPalettePropertiesWindow.Show();
            }
        }

        private void StandardDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _generalPaletteExplorerSettingsManager.SetDisplayIndex(0);

            circularDisplayToolStripMenuItem.Checked = false;
        }

        private void CircularDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _generalPaletteExplorerSettingsManager.SetDisplayIndex(1);

            standardDisplayToolStripMenuItem.Checked = false;
        }

        private void UIUpdateTimer_Tick(object sender, EventArgs e)
        {
            kdnContentDisplay.SelectedIndex = _generalPaletteExplorerSettingsManager.GetDisplayIndex();

            krgbShowHideColourPane.Checked = _generalPaletteExplorerSettingsManager.GetShowColourPropertiesPane();

            krgbShowHidePropertiesPane.Checked = _generalPaletteExplorerSettingsManager.GetShowPalettePropertiesPane();
        }

        private void KdnContentDisplay_TabIndexChanged(object sender, EventArgs e)
        {
            _generalPaletteExplorerSettingsManager.SetDisplayIndex(kdnContentDisplay.SelectedIndex);

            if (kdnContentDisplay.SelectedIndex == 0)
            {
                standardDisplayToolStripMenuItem.PerformClick();
            }
            else if (kdnContentDisplay.SelectedIndex == 1)
            {
                circularDisplayToolStripMenuItem.PerformClick();
            }
        }
        #endregion

        #region Methods
        private KryptonPage NewPage()
        {
            return NewPage("Colour Properties", 0, new KryptonPage());
        }

        private KryptonPage NewPage(string text, int image, Control content)
        {
            _page = new KryptonPage();

            _page.Name = text;

            _page.Text = text;

            _page.TextTitle = text;

            _page.TextDescription = text;

            _page.UniqueName = text;

            //_page.ToolTipImage = ilImages.Images

            _page.ToolTipStyle = LabelStyle.GroupBoxCaption;

            _page.ToolTipTitle = text;

            content.Dock = DockStyle.Fill;

            content.Controls.Add(GetPalettePropertyGrid());

            _page.Controls.Add(content);

            _page.ClearFlags(KryptonPageFlags.DockingAllowClose | KryptonPageFlags.DockingAllowDropDown | KryptonPageFlags.DockingAllowFloating);
            _page.AutoHiddenSlideSize = GetPalettePropertyGrid().Size;

            return _page;
        }

        private PalettePropertyGrid GetPalettePropertyGrid()
        {
            _palettePropertyGrid = new PalettePropertyGrid();

            _palettePropertyGrid.Name = "PalettePropertyGrid";

            return _palettePropertyGrid;
        }

        private void InspireMe()
        {
            if (kdnContentDisplay.SelectedIndex == 0)
            {

            }
            else if (kdnContentDisplay.SelectedIndex == 1)
            {
                cpbcPreview.InspireMe();
            }
        }

        private void InitialiseWindow()
        {
            circularDisplayToolStripMenuItem.Checked = _generalPaletteExplorerSettingsManager.GetShowCircularDisplay();

            standardDisplayToolStripMenuItem.Checked = _generalPaletteExplorerSettingsManager.GetShowStandardDisplay();

            foreach (PaletteMode mode in Enum.GetValues(typeof(PaletteMode)))
            {
                string value = mode.ToString();

                krgcbBasePaletteMode.Items.Add(value);
            }

            krgcbBasePaletteMode.SelectedIndex = 7;
        }
        #endregion

        private void KrgbOptions_Click(object sender, EventArgs e)
        {
            OptionsWindow window = new OptionsWindow();

            window.Show();
        }

        private void ResetColourUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cpbcPreview.ResetPaletteColours(_generalPaletteExplorerSettingsManager.GetDefaultColour());
        }

        private void KrgbGenerateColours_Click(object sender, EventArgs e)
        {
            ColourMixerAdvanced colourMixer = new ColourMixerAdvanced();

            colourMixer.Show();
        }

        private void KrgbBasicColourMixer_Click(object sender, EventArgs e)
        {
            ColourMixerBasic colourMixer = new ColourMixerBasic();

            colourMixer.Show();
        }

        private void KrgbInspireMe_Click(object sender, EventArgs e)
        {
            InspireMe();
        }

        private void KrgbGetColours_Click(object sender, EventArgs e)
        {
            if (kdnContentDisplay.SelectedIndex == 1)
            {

            }
            else if (kdnContentDisplay.SelectedIndex == 2)
            {
                cpbcPreview.RefreshColours();
            }
        }

        private void Office2007ColorPickerToolStripMenuItem1_Office2007ColourPickerControl_SelectedColourChanged(object sender, EventArgs e)
        {
            cpbcPreview.ResetPaletteColours(cpResetColour.Office2007ColourPickerControl.SelectedColour);
        }

        private void KdnContentDisplay_TabMoved(object sender, TabMovedEventArgs e)
        {

        }

        private void KrgbColourDebugConsole_Click(object sender, EventArgs e)
        {
            ColourDebugConsole debugConsole = new ColourDebugConsole();

            debugConsole.Show();
        }

        private void KrgbExportConfigurationFiles_Click(object sender, EventArgs e)
        {
            PaletteColourExporter exporter = new PaletteColourExporter();

            exporter.Show();
        }

        private void KrgbOpenPalette_Click(object sender, EventArgs e)
        {
            PaletteComposerEngine.PopulateColours(TemporaryPalette, Palette, true);
        }

        private void KrgbNewPalette_Click(object sender, EventArgs e)
        {

        }

        private void CpbcPreview_ChangeViewLayoutType(object sender, Enumerations.ViewLayoutType layoutType)
        {
            cpbcPreview.ChangeViewLayout(layoutType);
        }

        private void CustomColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIController.ControlCircularPictureBoxControlView(cpbcPreview, customColourToolStripMenuItem, customTextColourToolStripMenuItem, noCustomColoursToolStripMenuItem1, normalToolStripMenuItem1);
        }

        private void CustomTextColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIController.ControlCircularPictureBoxControlView(cpbcPreview, customColourToolStripMenuItem, customTextColourToolStripMenuItem, noCustomColoursToolStripMenuItem1, normalToolStripMenuItem1);
        }

        private void NoCustomColoursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UIController.ControlCircularPictureBoxControlView(cpbcPreview, customColourToolStripMenuItem, customTextColourToolStripMenuItem, noCustomColoursToolStripMenuItem1, normalToolStripMenuItem1);
        }

        private void NormalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UIController.ControlCircularPictureBoxControlView(cpbcPreview, customColourToolStripMenuItem, customTextColourToolStripMenuItem, noCustomColoursToolStripMenuItem1, normalToolStripMenuItem1);
        }

        private void ExportAllColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMergedColourSettingsManager.CreateARGBConfigurationFile();
        }

        private void ExportBasicColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicColourSettingsManager.CreateARGBConfigurationFile();
        }

        private void ExportCustomColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomColourSettingsManager.CreateARGBConfigurationFile();
        }

        private void ExportCustomTextColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExportLinkTextColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExportMiscellaneousColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExportStandardControlTextColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExportTextColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MergeAllColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllColourSettingsController.MergeAllColours();
        }

        private void KrgbSavePalette_Click(object sender, EventArgs e)
        {
            if (kdnContentDisplay.SelectedIndex == 0)
            {
                PaletteComposerEngine.ExportPaletteTheme(Palette, Mode, spbcStandard.GetBaseColourPreview(), spbcStandard.GetDarkColourPreview(), spbcStandard.GetMiddleColourPreview(), spbcStandard.GetLightColourPreview(), spbcStandard.GetLightestColourPreview(), spbcStandard.GetBorderColourPreview(), spbcStandard.GetAlternativeNormalTextColourPreview(), spbcStandard.GetNormalColourPreview(), spbcStandard.GetDisabledTextColourPreview(), spbcStandard.GetFocusedTextColourPreview(), spbcStandard.GetPressedTextColourPreview(), spbcStandard.GetDisabledControlColourPreview(), spbcStandard.GetLinkDisabledColourPreview(), spbcStandard.GetLinkNormalColourPreview(), spbcStandard.GetLinkFocusedColourPreview(), spbcStandard.GetLinkHoverColourPreview(), spbcStandard.GetLinkVisitedColourPreview(), spbcStandard.GetCustomColourOneColourPreview(), spbcStandard.GetCustomColourTwoColourPreview(), spbcStandard.GetCustomColourThreeColourPreview(), spbcStandard.GetCustomColourFourColourPreview(), spbcStandard.GetCustomColourFiveColourPreview(), spbcStandard.GetCustomColourSixColourPreview(), spbcStandard.GetCustomTextColourOneColourPreview(), spbcStandard.GetCustomTextColourTwoColourPreview(), spbcStandard.GetCustomTextColourThreeColourPreview(), spbcStandard.GetCustomTextColourFourColourPreview(), spbcStandard.GetCustomTextColourFiveColourPreview(), spbcStandard.GetCustomTextColourSixColourPreview(), spbcStandard.GetMenuTextColourPreview(), spbcStandard.GetStatusTextColourPreview(), spbcStandard.GetRibbonTabTextColourPreview(), tsslCurrentStatus);
            }
            else if (kdnContentDisplay.SelectedIndex == 1)
            {
                PaletteComposerEngine.ExportPaletteTheme(Palette, Mode, cpbcPreview.GetBaseColourPreview(), cpbcPreview.GetDarkColourPreview(), cpbcPreview.GetMiddleColourPreview(), cpbcPreview.GetLightColourPreview(), cpbcPreview.GetLightestColourPreview(), cpbcPreview.GetBorderColourPreview(), cpbcPreview.GetAlternativeNormalTextColourPreview(), cpbcPreview.GetNormalTextColourPreview(), cpbcPreview.GetDisabledTextColourPreview(), cpbcPreview.GetFocusedTextColourPreview(), cpbcPreview.GetPressedTextColourPreview(), cpbcPreview.GetDisabledControlColourPreview(), cpbcPreview.GetLinkDisabledColourPreview(), cpbcPreview.GetLinkNormalColourPreview(), cpbcPreview.GetLinkFocusedColourPreview(), cpbcPreview.GetLinkHoverColourPreview(), cpbcPreview.GetLinkVisitedColourPreview(), cpbcPreview.GetCustomColourOneColourPreview(), cpbcPreview.GetCustomColourTwoColourPreview(), cpbcPreview.GetCustomColourThreeColourPreview(), cpbcPreview.GetCustomColourFourColourPreview(), cpbcPreview.GetCustomColourFiveColourPreview(), cpbcPreview.GetCustomColourSixColourPreview(), cpbcPreview.GetCustomTextColourOneColourPreview(), cpbcPreview.GetCustomTextColourTwoColourPreview(), cpbcPreview.GetCustomTextColourThreeColourPreview(), cpbcPreview.GetCustomTextColourFourColourPreview(), cpbcPreview.GetCustomTextColourFiveColourPreview(), cpbcPreview.GetCustomTextColourSixColourPreview(), cpbcPreview.GetMenuTextColourPreview(), cpbcPreview.GetStatusTextColourPreview(), cpbcPreview.GetRibbonTabTextColourPreview(), tsslCurrentStatus);
            }
        }

        private void KrgbColourContrastTool_Click(object sender, EventArgs e)
        {
            ContrastColourSelector contrastColourSelector = new ContrastColourSelector();

            contrastColourSelector.Show();
        }
    }
}