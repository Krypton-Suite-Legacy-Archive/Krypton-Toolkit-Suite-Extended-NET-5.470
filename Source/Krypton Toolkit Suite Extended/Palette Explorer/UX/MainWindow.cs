#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using Classes.Colours;
using ComponentFactory.Krypton.Toolkit;
using Core.Classes.Other;
using Core.UX;
using ExtendedControls.Base.Code.Development;
using ExtendedControls.Base.Enumerations;
using PaletteExplorer.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using ToolkitSettings.Classes.Global;
using ToolkitSettings.Classes.PaletteExplorer.Colours;

namespace PaletteExplorer.UX
{
    public partial class MainWindow : KryptonForm
    {
        #region Variables
        private bool _dirty, _loaded, _debugMode, _useCircularPictureBoxes;

        private string _fileName;

        private KryptonPalette _palette;

        private PaletteMode _paletteMode;
        private BasicColourSettingsManager _basicPaletteColourManager = new BasicColourSettingsManager();

        private ConversionMethods _conversionMethods = new ConversionMethods();

        private AllMergedColourSettingsManager _colourSettingsManager = new AllMergedColourSettingsManager();

        private Classes.GlobalMethods _globalMethods = new Classes.GlobalMethods();

        private GlobalStringSettingsManager _globalStringSettingsManager = new GlobalStringSettingsManager();

        private GlobalBooleanSettingsManager _globalBooleanSettingsManager = new GlobalBooleanSettingsManager();

        private Version _currentVersion = Assembly.GetExecutingAssembly().GetName().Version;

        private Timer _colourUpdateTimer;
        #endregion

        #region Properties
        public bool DebugMode { get { return _debugMode; } set { _debugMode = value; } }

        public bool Dirty { get { return _dirty; } set { _dirty = value; } }

        public bool Loaded { get { return _loaded; } set { _loaded = value; } }

        public bool UseCircularPictureBoxes { get { return _useCircularPictureBoxes; } set { _useCircularPictureBoxes = value; } }

        public string FileName { get { return _fileName; } set { _fileName = value; } }

        public new KryptonPalette Palette { get { return _palette; } set { _palette = value; } }

        public new PaletteMode PaletteMode { get { return _paletteMode; } set { _paletteMode = value; } }
        #endregion

        #region System Code
        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
        private KryptonContextMenuItem kcmiNewPalette;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private KryptonContextMenuItem kcmiOpenPalette;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator2;
        private KryptonContextMenuItem kcmiSavePalette;
        private KryptonContextMenuItem kcmiSavePaletteAs;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator3;
        private KryptonContextMenuItem kcmiExit;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton krqatbNew;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton krqatbOpen;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton krqatbSave;
        private KryptonContextMenuItem kryptonContextMenuItem1;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator4;
        private KryptonContextMenuItem kryptonContextMenuItem2;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator5;
        private KryptonContextMenuItem kryptonContextMenuItem3;
        private KryptonContextMenuItem kryptonContextMenuItem4;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator6;
        private KryptonContextMenuItem kryptonContextMenuItem5;
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
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple6;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGenerateColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple7;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGetColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator5;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple8;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbExport;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krbViewPaletteFile;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator6;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGenerateContrastColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator7;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple9;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGetColourInformation;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator8;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple10;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbImport;
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
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple15;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbDefineTypefaceColour;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple16;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbViewType;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator11;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple17;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbExperimental;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator12;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple19;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbShowHidePropertiesPane;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup9;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup6;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple20;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbLaunchPaletteDesigner;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator14;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple18;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbOptions;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup7;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple21;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbAbout;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator13;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple22;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbCheckForUpdates;
        private KryptonPanel kryptonPanel1;
        private System.Windows.Forms.StatusStrip ss;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnClose;
        private KryptonLabel lblColourOutput;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel3;
        private System.Windows.Forms.ContextMenuStrip ctxAlternativeNormalTextUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ContextMenuStrip ctxDisabledTextUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ContextMenuStrip ctxMiddleUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ContextMenuStrip ctxMenuTextColourUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem41;
        private System.Windows.Forms.ContextMenuStrip ctxCustomColourFiveUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem35;
        private System.Windows.Forms.ContextMenuStrip ctxLinkHoverUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem29;
        private System.Windows.Forms.ContextMenuStrip ctxNormalTextUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ContextMenuStrip ctxDarkUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ContextMenuStrip ctxCustomTextColourFourUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem39;
        private System.Windows.Forms.ContextMenuStrip ctxCustomColourThreeUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;
        private System.Windows.Forms.ContextMenuStrip ctxDisabledUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;
        private System.Windows.Forms.ContextMenuStrip ctxBorderUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ContextMenuStrip ctxCustomTextColourFiveUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem40;
        private System.Windows.Forms.ContextMenuStrip ctxLinkNormalUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem28;
        private System.Windows.Forms.ContextMenuStrip ctxBaseUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem utiliseAsBaseColourToolStripMenuItem;
        private System.Windows.Forms.Timer tmrUpdateUI;
        private System.Windows.Forms.ContextMenuStrip cmsViewType;
        private System.Windows.Forms.ToolStripMenuItem standardPictureboxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem circularPictureboxesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsExperinental;
        private System.Windows.Forms.ContextMenuStrip ctxLinkVisitedUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem30;
        private System.Windows.Forms.ContextMenuStrip ctxCustomColourFourUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem34;
        private System.Windows.Forms.ContextMenuStrip ctxCustomTextColourOneUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem36;
        private System.Windows.Forms.ToolTip ttInformation;
        private KryptonPalette palette;
        private KryptonContextMenu kcmViewType;
        private KryptonContextMenuItems kryptonContextMenuItems1;
        private KryptonContextMenuItem kryptonContextMenuItem7;
        private KryptonCommand kcStandardPictureboxes;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator7;
        private KryptonContextMenuItem kryptonContextMenuItem8;
        private KryptonCommand kcCircularPictureboxes;
        private KryptonContextMenu kcmExperimental;
        private KryptonCommand kcNewPalette;
        private KryptonCommand kcOpenPalette;
        private KryptonCommand kcSavePalette;
        private KryptonCommand kcSavePaletteAs;
        private KryptonCommand kcExitApplication;
        private System.Windows.Forms.ContextMenuStrip ctxCustomTextColourTwoUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem37;
        private System.Windows.Forms.ContextMenuStrip ctxLightestUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ContextMenuStrip ctxPressedTextUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ContextMenuStrip ctxCustomColourTwoUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem32;
        private System.Windows.Forms.ContextMenuStrip ctxCustomTextColourThreeUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem38;
        private System.Windows.Forms.ContextMenuStrip ctxCustomColourOneUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem31;
        private System.Windows.Forms.ContextMenuStrip ctxFoucusedTextUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ContextMenuStrip ctxStatusTextColourUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem42;
        private System.Windows.Forms.ContextMenuStrip ctxLightUtiliseAsBaseColour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private KryptonGroupBox kgbSquarePreviewPane;
        private System.Windows.Forms.PictureBox pbxLinkFocusedColourPreview;
        private System.Windows.Forms.PictureBox pbxStatusTextColourPreview;
        private System.Windows.Forms.PictureBox pbxMenuTextColourPreview;
        private System.Windows.Forms.PictureBox pbxCustomColourFourPreview;
        private System.Windows.Forms.PictureBox pbxCustomTextColourFivePreview;
        private System.Windows.Forms.PictureBox pbxCustomTextColourFourPreview;
        private System.Windows.Forms.PictureBox pbxCustomTextColourThreePreview;
        private System.Windows.Forms.PictureBox pbxCustomTextColourTwoPreview;
        private System.Windows.Forms.PictureBox pbxCustomTextColourOnePreview;
        private System.Windows.Forms.PictureBox pbxCustomColourFivePreview;
        private System.Windows.Forms.PictureBox pbxCustomColourThreePreview;
        private System.Windows.Forms.PictureBox pbxCustomColourTwoPreview;
        private System.Windows.Forms.PictureBox pbxCustomColourOnePreview;
        private System.Windows.Forms.PictureBox pbxLinkVisitedColourPreview;
        private System.Windows.Forms.PictureBox pbxLinkHoverColourPreview;
        private System.Windows.Forms.PictureBox pbxAlternativeNormalTextColourPreview;
        private System.Windows.Forms.PictureBox pbxLinkNormalColourPreview;
        private System.Windows.Forms.PictureBox pbxDisabledControlColourPreview;
        private System.Windows.Forms.PictureBox pbxPressedTextColourPreview;
        private System.Windows.Forms.PictureBox pbxFocusedTextColourPreview;
        private System.Windows.Forms.PictureBox pbxDisabledTextColourPreview;
        private System.Windows.Forms.PictureBox pbxNormalTextColourPreview;
        private System.Windows.Forms.PictureBox pbxBorderColourPreview;
        private System.Windows.Forms.PictureBox pbxBaseColourPreview;
        private System.Windows.Forms.PictureBox pbxLightestColourPreview;
        private System.Windows.Forms.PictureBox pbxDarkColourPreview;
        private System.Windows.Forms.PictureBox pbxLightColourPreview;
        private System.Windows.Forms.PictureBox pbxMiddleColourPreview;
        private KryptonGroupBox kgbPaletteProperties;
        private System.Windows.Forms.PropertyGrid labelGridNormal;
        private KryptonGroupBox kgbCircularColourPreviewPane;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLightestColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLightColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxMiddleColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxDarkColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxBaseColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxNormalTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxBorderColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxAlternativeNormalTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxPressedTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxFocusedTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxDisabledTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxDisabledControlColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLinkNormalColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLinkHoverColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomColourTwoPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomColourOnePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLinkVisitedColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomColourThreePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomColourFourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomTextColourOnePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomColourFivePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomTextColourThreePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomTextColourTwoPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxMenuTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomTextColourFourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomTextColourFivePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxStatusTextColourPreview;
        private KryptonContextMenu kcmUpdateColours;
        private KryptonContextMenuItems kryptonContextMenuItems3;
        private KryptonContextMenuItem kryptonContextMenuItem6;
        private KryptonContextMenuItems kryptonContextMenuItems2;
        private ToolStripStatusLabel tslCurrentStatus;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLinkFocusedColourPreview;
        private KryptonCommand kcUpdateColours;
        private KryptonContextMenu kcmGenerateColours;
        private KryptonContextMenuItems kryptonContextMenuItems4;
        private KryptonContextMenuItem kryptonContextMenuItem9;
        private KryptonCommand kcDefineIndividualColours;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxRibbonTabTextColourPreview;
        private PictureBox pbxRibbonTabTextColourPreview;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup11;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple25;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbMergeAllColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbFileEdit;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kcmiNewPalette = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kcmiOpenPalette = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kcmiSavePalette = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kcmiSavePaletteAs = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kcmiExit = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonRibbon1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.krqatbNew = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.krqatbOpen = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.krqatbSave = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator4 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator5 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuItem3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem4 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator6 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuItem5 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
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
            this.kryptonRibbonGroupTriple6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGenerateColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kcmGenerateColours = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems4 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem9 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kcDefineIndividualColours = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kryptonRibbonGroupSeparator4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple7 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGetColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple8 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbExport = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krbViewPaletteFile = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGenerateContrastColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator7 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple9 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGetColourInformation = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator8 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple10 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbImport = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple11 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbInvert = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple12 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbUpdateColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kcmUpdateColours = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem6 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kcUpdateColours = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kryptonRibbonGroupSeparator9 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple13 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbResetColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple14 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbDefineTypefaces = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator10 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple15 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbDefineTypefaceColour = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple16 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbViewType = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kcmViewType = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem7 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kcStandardPictureboxes = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kryptonContextMenuSeparator7 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuItem8 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kcCircularPictureboxes = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kryptonRibbonGroupSeparator11 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple17 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbExperimental = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kcmExperimental = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonRibbonGroupSeparator12 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple19 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbShowHidePropertiesPane = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup9 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonTab3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple20 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbLaunchPaletteDesigner = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator14 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple18 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbOptions = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup11 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple25 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbMergeAllColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbFileEdit = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup7 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple21 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbAbout = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator13 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple22 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbCheckForUpdates = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tslCurrentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblColourOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kgbCircularColourPreviewPane = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cbxRibbonTabTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxStatusTextColourUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem42 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxLinkFocusedColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxStatusTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomTextColourThreePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxCustomTextColourThreeUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCustomTextColourTwoPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxCustomTextColourTwoUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxMenuTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxMenuTextColourUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCustomTextColourFourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxCustomTextColourFourUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCustomTextColourFivePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxCustomTextColourFiveUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCustomTextColourOnePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxCustomTextColourOneUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCustomColourFivePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxCustomColourFiveUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCustomColourTwoPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxCustomColourTwoUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCustomColourOnePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxCustomColourOneUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxLinkVisitedColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxLinkVisitedUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCustomColourThreePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxCustomColourThreeUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCustomColourFourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxCustomColourFourUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxLinkHoverColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxLinkHoverUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxPressedTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxPressedTextUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxFocusedTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxFoucusedTextUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxDisabledTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxDisabledTextUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxDisabledControlColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxDisabledUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxLinkNormalColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxLinkNormalUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxNormalTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxNormalTextUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxBorderColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxBorderUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxAlternativeNormalTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxAlternativeNormalTextUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxLightestColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxLightestUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxLightColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxLightUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxMiddleColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxMiddleUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxDarkColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxDarkUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxBaseColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxBaseUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.utiliseAsBaseColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kgbPaletteProperties = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.labelGridNormal = new System.Windows.Forms.PropertyGrid();
            this.kgbSquarePreviewPane = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pbxRibbonTabTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxLinkFocusedColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxStatusTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxMenuTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxCustomColourFourPreview = new System.Windows.Forms.PictureBox();
            this.pbxCustomTextColourFivePreview = new System.Windows.Forms.PictureBox();
            this.pbxCustomTextColourFourPreview = new System.Windows.Forms.PictureBox();
            this.pbxCustomTextColourThreePreview = new System.Windows.Forms.PictureBox();
            this.pbxCustomTextColourTwoPreview = new System.Windows.Forms.PictureBox();
            this.pbxCustomTextColourOnePreview = new System.Windows.Forms.PictureBox();
            this.pbxCustomColourFivePreview = new System.Windows.Forms.PictureBox();
            this.pbxCustomColourThreePreview = new System.Windows.Forms.PictureBox();
            this.pbxCustomColourTwoPreview = new System.Windows.Forms.PictureBox();
            this.pbxCustomColourOnePreview = new System.Windows.Forms.PictureBox();
            this.pbxLinkVisitedColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxLinkHoverColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxAlternativeNormalTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxLinkNormalColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxDisabledControlColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxPressedTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxFocusedTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxDisabledTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxNormalTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxBorderColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxBaseColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxLightestColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxDarkColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxLightColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxMiddleColourPreview = new System.Windows.Forms.PictureBox();
            this.tmrUpdateUI = new System.Windows.Forms.Timer(this.components);
            this.cmsViewType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.standardPictureboxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.circularPictureboxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsExperinental = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ttInformation = new System.Windows.Forms.ToolTip(this.components);
            this.palette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kcNewPalette = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kcOpenPalette = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kcSavePalette = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kcSavePaletteAs = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kcExitApplication = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.ss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane.Panel)).BeginInit();
            this.kgbCircularColourPreviewPane.Panel.SuspendLayout();
            this.kgbCircularColourPreviewPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRibbonTabTextColourPreview)).BeginInit();
            this.ctxStatusTextColourUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkFocusedColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStatusTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourThreePreview)).BeginInit();
            this.ctxCustomTextColourThreeUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourTwoPreview)).BeginInit();
            this.ctxCustomTextColourTwoUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMenuTextColourPreview)).BeginInit();
            this.ctxMenuTextColourUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourFourPreview)).BeginInit();
            this.ctxCustomTextColourFourUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourFivePreview)).BeginInit();
            this.ctxCustomTextColourFiveUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourOnePreview)).BeginInit();
            this.ctxCustomTextColourOneUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourFivePreview)).BeginInit();
            this.ctxCustomColourFiveUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourTwoPreview)).BeginInit();
            this.ctxCustomColourTwoUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourOnePreview)).BeginInit();
            this.ctxCustomColourOneUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkVisitedColourPreview)).BeginInit();
            this.ctxLinkVisitedUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourThreePreview)).BeginInit();
            this.ctxCustomColourThreeUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourFourPreview)).BeginInit();
            this.ctxCustomColourFourUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkHoverColourPreview)).BeginInit();
            this.ctxLinkHoverUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPressedTextColourPreview)).BeginInit();
            this.ctxPressedTextUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFocusedTextColourPreview)).BeginInit();
            this.ctxFoucusedTextUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisabledTextColourPreview)).BeginInit();
            this.ctxDisabledTextUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisabledControlColourPreview)).BeginInit();
            this.ctxDisabledUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkNormalColourPreview)).BeginInit();
            this.ctxLinkNormalUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNormalTextColourPreview)).BeginInit();
            this.ctxNormalTextUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBorderColourPreview)).BeginInit();
            this.ctxBorderUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAlternativeNormalTextColourPreview)).BeginInit();
            this.ctxAlternativeNormalTextUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightestColourPreview)).BeginInit();
            this.ctxLightestUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightColourPreview)).BeginInit();
            this.ctxLightUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMiddleColourPreview)).BeginInit();
            this.ctxMiddleUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColourPreview)).BeginInit();
            this.ctxDarkUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBaseColourPreview)).BeginInit();
            this.ctxBaseUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPaletteProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPaletteProperties.Panel)).BeginInit();
            this.kgbPaletteProperties.Panel.SuspendLayout();
            this.kgbPaletteProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbSquarePreviewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbSquarePreviewPane.Panel)).BeginInit();
            this.kgbSquarePreviewPane.Panel.SuspendLayout();
            this.kgbSquarePreviewPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRibbonTabTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkFocusedColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatusTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourFourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourFivePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourFourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourThreePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourTwoPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourOnePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourFivePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourThreePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourTwoPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourOnePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkVisitedColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkHoverColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlternativeNormalTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkNormalColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledControlColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPressedTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFocusedTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNormalTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBorderColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightestColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDarkColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddleColourPreview)).BeginInit();
            this.cmsViewType.SuspendLayout();
            this.SuspendLayout();
            // 
            // kMan
            // 
            this.kMan.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
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
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.AllowFormIntegrate = true;
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.QATButtons.AddRange(new System.ComponentModel.Component[] {
            this.krqatbNew,
            this.krqatbOpen,
            this.krqatbSave});
            this.kryptonRibbon1.RibbonAppButton.AppButtonImage = global::PaletteExplorer.Properties.Resources.PE_Icon_24_x_24;
            this.kryptonRibbon1.RibbonAppButton.AppButtonMenuItems.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1,
            this.kryptonContextMenuSeparator4,
            this.kryptonContextMenuItem2,
            this.kryptonContextMenuSeparator5,
            this.kryptonContextMenuItem3,
            this.kryptonContextMenuItem4,
            this.kryptonContextMenuSeparator6,
            this.kryptonContextMenuItem5});
            this.kryptonRibbon1.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1,
            this.kryptonRibbonTab2,
            this.kryptonRibbonTab3,
            this.kryptonRibbonTab4});
            this.kryptonRibbon1.SelectedContext = null;
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab2;
            this.kryptonRibbon1.Size = new System.Drawing.Size(1437, 115);
            this.kryptonRibbon1.TabIndex = 1;
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
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Image = global::PaletteExplorer.Properties.Resources.New_File_32_x_32;
            this.kryptonContextMenuItem1.Text = "New Palette";
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Image = global::PaletteExplorer.Properties.Resources.Open_File_32_x_32;
            this.kryptonContextMenuItem2.Text = "Open Palette";
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.Image = global::PaletteExplorer.Properties.Resources.Hard_Drive_v1_32_x_32;
            this.kryptonContextMenuItem3.Text = "Save Palette";
            // 
            // kryptonContextMenuItem4
            // 
            this.kryptonContextMenuItem4.Text = "Save Palette As";
            // 
            // kryptonContextMenuItem5
            // 
            this.kryptonContextMenuItem5.Image = global::PaletteExplorer.Properties.Resources.Exit_32_x_32;
            this.kryptonContextMenuItem5.Text = "Exit";
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
            this.krgbOpenPalette.Click += new System.EventHandler(this.krgbOpenPalette_Click);
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbSavePalette});
            // 
            // krgbSavePalette
            // 
            this.krgbSavePalette.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbSavePalette.ImageLarge")));
            this.krgbSavePalette.ImageSmall = ((System.Drawing.Image)(resources.GetObject("krgbSavePalette.ImageSmall")));
            this.krgbSavePalette.TextLine1 = "Save";
            this.krgbSavePalette.TextLine2 = "Palette";
            this.krgbSavePalette.Click += new System.EventHandler(this.krgbSavePalette_Click);
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
            this.krgbCut.ImageLarge = global::PaletteExplorer.Properties.Resources.Cut_32_x_32;
            this.krgbCut.ImageSmall = global::PaletteExplorer.Properties.Resources.Cut_16_x_16;
            this.krgbCut.TextLine1 = "Cut";
            // 
            // krgbCopy
            // 
            this.krgbCopy.ImageLarge = global::PaletteExplorer.Properties.Resources.Copy_32_x_32;
            this.krgbCopy.ImageSmall = global::PaletteExplorer.Properties.Resources.Copy_16_x_16;
            this.krgbCopy.TextLine1 = "Copy";
            // 
            // krgbPaste
            // 
            this.krgbPaste.Enabled = false;
            this.krgbPaste.ImageLarge = global::PaletteExplorer.Properties.Resources.Paste_32_x_32;
            this.krgbPaste.ImageSmall = global::PaletteExplorer.Properties.Resources.Paste_16_x_16;
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
            this.krgbUndo.ImageLarge = global::PaletteExplorer.Properties.Resources.Undo_32_x_32;
            this.krgbUndo.ImageSmall = global::PaletteExplorer.Properties.Resources.Undo_16_x_16;
            this.krgbUndo.TextLine1 = "Undo";
            // 
            // krgbRedo
            // 
            this.krgbRedo.Enabled = false;
            this.krgbRedo.ImageLarge = global::PaletteExplorer.Properties.Resources.Redo_32_x_32;
            this.krgbRedo.ImageSmall = global::PaletteExplorer.Properties.Resources.Redo_16_x_16;
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
            this.krgcbBasePaletteMode.DropDownWidth = 121;
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
            this.kryptonRibbonGroup4,
            this.kryptonRibbonGroup9});
            this.kryptonRibbonTab2.Text = "O&ptions";
            // 
            // kryptonRibbonGroup3
            // 
            this.kryptonRibbonGroup3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple6,
            this.kryptonRibbonGroupSeparator4,
            this.kryptonRibbonGroupTriple7,
            this.kryptonRibbonGroupSeparator5,
            this.kryptonRibbonGroupTriple8,
            this.kryptonRibbonGroupTriple4,
            this.kryptonRibbonGroupSeparator6,
            this.kryptonRibbonGroupTriple5,
            this.kryptonRibbonGroupSeparator7,
            this.kryptonRibbonGroupTriple9,
            this.kryptonRibbonGroupSeparator8,
            this.kryptonRibbonGroupTriple10,
            this.kryptonRibbonGroupTriple11,
            this.kryptonRibbonGroupSeparator3,
            this.kryptonRibbonGroupTriple12,
            this.kryptonRibbonGroupSeparator9,
            this.kryptonRibbonGroupTriple13});
            this.kryptonRibbonGroup3.TextLine1 = "Colour Properties";
            // 
            // kryptonRibbonGroupTriple6
            // 
            this.kryptonRibbonGroupTriple6.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbGenerateColours});
            // 
            // krgbGenerateColours
            // 
            this.krgbGenerateColours.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Split;
            this.krgbGenerateColours.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbGenerateColours.ImageLarge")));
            this.krgbGenerateColours.ImageSmall = ((System.Drawing.Image)(resources.GetObject("krgbGenerateColours.ImageSmall")));
            this.krgbGenerateColours.KryptonContextMenu = this.kcmGenerateColours;
            this.krgbGenerateColours.TextLine1 = "Generate";
            this.krgbGenerateColours.TextLine2 = "Colours";
            this.krgbGenerateColours.Click += new System.EventHandler(this.krgbGenerateColours_Click);
            // 
            // kcmGenerateColours
            // 
            this.kcmGenerateColours.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems4});
            // 
            // kryptonContextMenuItems4
            // 
            this.kryptonContextMenuItems4.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem9});
            // 
            // kryptonContextMenuItem9
            // 
            this.kryptonContextMenuItem9.KryptonCommand = this.kcDefineIndividualColours;
            this.kryptonContextMenuItem9.Text = "&Define Individual Colours";
            // 
            // kcDefineIndividualColours
            // 
            this.kcDefineIndividualColours.Text = "Define Individual Colours";
            this.kcDefineIndividualColours.Execute += new System.EventHandler(this.kcDefineIndividualColours_Execute);
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
            this.krgbGetColours.Click += new System.EventHandler(this.krgbGetColours_Click);
            // 
            // kryptonRibbonGroupTriple8
            // 
            this.kryptonRibbonGroupTriple8.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbExport});
            this.kryptonRibbonGroupTriple8.Visible = false;
            // 
            // krgbExport
            // 
            this.krgbExport.TextLine1 = "Export Colour";
            this.krgbExport.TextLine2 = "Palette";
            this.krgbExport.Visible = false;
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
            this.krgbGenerateContrastColours.ImageLarge = global::PaletteExplorer.Properties.Resources.Generic_Colour_Icon_32_x_32;
            this.krgbGenerateContrastColours.ImageSmall = global::PaletteExplorer.Properties.Resources.Generic_Colour_Icon_16_x_16;
            this.krgbGenerateContrastColours.TextLine1 = "Generate";
            this.krgbGenerateContrastColours.TextLine2 = "Contrast Colours";
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
            // kryptonRibbonGroupTriple10
            // 
            this.kryptonRibbonGroupTriple10.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbImport});
            // 
            // krgbImport
            // 
            this.krgbImport.TextLine1 = "Import Colour";
            this.krgbImport.TextLine2 = "Scheme";
            this.krgbImport.Visible = false;
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
            this.krgbUpdateColours.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Split;
            this.krgbUpdateColours.KryptonContextMenu = this.kcmUpdateColours;
            this.krgbUpdateColours.TextLine1 = "Update";
            this.krgbUpdateColours.TextLine2 = "Colours";
            // 
            // kcmUpdateColours
            // 
            this.kcmUpdateColours.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems3});
            // 
            // kryptonContextMenuItems3
            // 
            this.kryptonContextMenuItems3.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem6});
            // 
            // kryptonContextMenuItem6
            // 
            this.kryptonContextMenuItem6.CheckOnClick = true;
            this.kryptonContextMenuItem6.KryptonCommand = this.kcUpdateColours;
            this.kryptonContextMenuItem6.Text = "Automatically &Update Colours";
            // 
            // kcUpdateColours
            // 
            this.kcUpdateColours.Text = "Update Colours";
            // 
            // kryptonRibbonGroupTriple13
            // 
            this.kryptonRibbonGroupTriple13.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbResetColours});
            // 
            // krgbResetColours
            // 
            this.krgbResetColours.TextLine1 = "Reset";
            this.krgbResetColours.TextLine2 = "Colours";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple14,
            this.kryptonRibbonGroupSeparator10,
            this.kryptonRibbonGroupTriple15});
            this.kryptonRibbonGroup2.TextLine1 = "Typeface Properties";
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
            // kryptonRibbonGroupTriple15
            // 
            this.kryptonRibbonGroupTriple15.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbDefineTypefaceColour});
            // 
            // krgbDefineTypefaceColour
            // 
            this.krgbDefineTypefaceColour.ImageLarge = global::PaletteExplorer.Properties.Resources.Text_Colour_v1_32_x_32;
            this.krgbDefineTypefaceColour.ImageSmall = global::PaletteExplorer.Properties.Resources.Text_Colour_v1_16_x_16;
            this.krgbDefineTypefaceColour.TextLine1 = "Define Typeface";
            this.krgbDefineTypefaceColour.TextLine2 = "Colour";
            // 
            // kryptonRibbonGroup4
            // 
            this.kryptonRibbonGroup4.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple16,
            this.kryptonRibbonGroupSeparator11,
            this.kryptonRibbonGroupTriple17,
            this.kryptonRibbonGroupSeparator12,
            this.kryptonRibbonGroupTriple19});
            this.kryptonRibbonGroup4.TextLine1 = "User Interface Management";
            // 
            // kryptonRibbonGroupTriple16
            // 
            this.kryptonRibbonGroupTriple16.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbViewType});
            // 
            // krgbViewType
            // 
            this.krgbViewType.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Split;
            this.krgbViewType.KryptonContextMenu = this.kcmViewType;
            this.krgbViewType.TextLine1 = "View";
            this.krgbViewType.TextLine2 = "Type";
            // 
            // kcmViewType
            // 
            this.kcmViewType.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1});
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem7,
            this.kryptonContextMenuSeparator7,
            this.kryptonContextMenuItem8});
            // 
            // kryptonContextMenuItem7
            // 
            this.kryptonContextMenuItem7.CheckOnClick = true;
            this.kryptonContextMenuItem7.KryptonCommand = this.kcStandardPictureboxes;
            this.kryptonContextMenuItem7.Text = "Standard Picturebox";
            // 
            // kcStandardPictureboxes
            // 
            this.kcStandardPictureboxes.Text = "Standard Pictureboxes";
            this.kcStandardPictureboxes.Execute += new System.EventHandler(this.kcStandardPictureboxes_Execute);
            // 
            // kryptonContextMenuItem8
            // 
            this.kryptonContextMenuItem8.CheckOnClick = true;
            this.kryptonContextMenuItem8.KryptonCommand = this.kcCircularPictureboxes;
            this.kryptonContextMenuItem8.Text = "Circular Picturebox";
            // 
            // kcCircularPictureboxes
            // 
            this.kcCircularPictureboxes.Text = "Circular Pictureboxes";
            this.kcCircularPictureboxes.Execute += new System.EventHandler(this.kcCircularPictureboxes_Execute);
            // 
            // kryptonRibbonGroupTriple17
            // 
            this.kryptonRibbonGroupTriple17.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbExperimental});
            // 
            // krgbExperimental
            // 
            this.krgbExperimental.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.DropDown;
            this.krgbExperimental.ImageLarge = global::PaletteExplorer.Properties.Resources.Warning_32_x_32;
            this.krgbExperimental.ImageSmall = global::PaletteExplorer.Properties.Resources.Warning_16_x_16;
            this.krgbExperimental.KryptonContextMenu = this.kcmExperimental;
            this.krgbExperimental.TextLine1 = "Experimental";
            // 
            // kryptonRibbonGroupTriple19
            // 
            this.kryptonRibbonGroupTriple19.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbShowHidePropertiesPane});
            // 
            // krgbShowHidePropertiesPane
            // 
            this.krgbShowHidePropertiesPane.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.krgbShowHidePropertiesPane.ImageLarge = global::PaletteExplorer.Properties.Resources.Property_New_32_x_32;
            this.krgbShowHidePropertiesPane.ImageSmall = global::PaletteExplorer.Properties.Resources.Property_New_16_x_16;
            this.krgbShowHidePropertiesPane.TextLine1 = "Show/Hide";
            this.krgbShowHidePropertiesPane.TextLine2 = "Propertes Pane";
            this.krgbShowHidePropertiesPane.Click += new System.EventHandler(this.krgbShowHidePropertiesPane_Click);
            // 
            // kryptonRibbonTab3
            // 
            this.kryptonRibbonTab3.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup6,
            this.kryptonRibbonGroup11});
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
            this.krgbLaunchPaletteDesigner});
            // 
            // krgbLaunchPaletteDesigner
            // 
            this.krgbLaunchPaletteDesigner.TextLine1 = "Launch Palette";
            this.krgbLaunchPaletteDesigner.TextLine2 = "Designer";
            // 
            // kryptonRibbonGroupTriple18
            // 
            this.kryptonRibbonGroupTriple18.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbOptions});
            // 
            // krgbOptions
            // 
            this.krgbOptions.TextLine1 = "Options /";
            this.krgbOptions.TextLine2 = "Settings";
            this.krgbOptions.Click += new System.EventHandler(this.krgbOptions_Click);
            // 
            // kryptonRibbonGroup11
            // 
            this.kryptonRibbonGroup11.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple25});
            // 
            // kryptonRibbonGroupTriple25
            // 
            this.kryptonRibbonGroupTriple25.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbMergeAllColours,
            this.krgbFileEdit});
            // 
            // krgbMergeAllColours
            // 
            this.krgbMergeAllColours.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.krgbMergeAllColours.TextLine1 = "Merge All";
            this.krgbMergeAllColours.TextLine2 = "Colours";
            this.krgbMergeAllColours.ToolTipTitle = "Merge all colours";
            // 
            // krgbFileEdit
            // 
            this.krgbFileEdit.TextLine1 = "Edit Palette";
            this.krgbFileEdit.TextLine2 = "File";
            this.krgbFileEdit.Click += new System.EventHandler(this.krgbFileEdit_Click);
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
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.ss);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 760);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1437, 22);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCurrentStatus});
            this.ss.Location = new System.Drawing.Point(0, 0);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(1437, 22);
            this.ss.TabIndex = 46;
            this.ss.Text = "statusStrip1";
            // 
            // tslCurrentStatus
            // 
            this.tslCurrentStatus.Name = "tslCurrentStatus";
            this.tslCurrentStatus.Size = new System.Drawing.Size(1422, 17);
            this.tslCurrentStatus.Spring = true;
            this.tslCurrentStatus.Text = "Ready";
            this.tslCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnClose);
            this.kryptonPanel2.Controls.Add(this.lblColourOutput);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 706);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1437, 54);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // kbtnClose
            // 
            this.kbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnClose.Location = new System.Drawing.Point(1357, 12);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(68, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 64;
            this.ttInformation.SetToolTip(this.kbtnClose, "Close");
            this.kbtnClose.Values.Image = global::PaletteExplorer.Properties.Resources.Exit_16_x_16;
            this.kbtnClose.Values.Text = "&Close";
            this.kbtnClose.Click += new System.EventHandler(this.kbtnClose_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 704);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1437, 2);
            this.panel1.TabIndex = 5;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kgbCircularColourPreviewPane);
            this.kryptonPanel3.Controls.Add(this.kgbPaletteProperties);
            this.kryptonPanel3.Controls.Add(this.kgbSquarePreviewPane);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1437, 589);
            this.kryptonPanel3.TabIndex = 6;
            // 
            // kgbCircularColourPreviewPane
            // 
            this.kgbCircularColourPreviewPane.Location = new System.Drawing.Point(12, 22);
            this.kgbCircularColourPreviewPane.Name = "kgbCircularColourPreviewPane";
            // 
            // kgbCircularColourPreviewPane.Panel
            // 
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxRibbonTabTextColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxLinkFocusedColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxStatusTextColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomTextColourThreePreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomTextColourTwoPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxMenuTextColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomTextColourFourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomTextColourFivePreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomTextColourOnePreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomColourFivePreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomColourTwoPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomColourOnePreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxLinkVisitedColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomColourThreePreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomColourFourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxLinkHoverColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxPressedTextColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxFocusedTextColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxDisabledTextColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxDisabledControlColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxLinkNormalColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxNormalTextColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxBorderColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxAlternativeNormalTextColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxLightestColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxLightColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxMiddleColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxDarkColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxBaseColourPreview);
            this.kgbCircularColourPreviewPane.Size = new System.Drawing.Size(882, 552);
            this.kgbCircularColourPreviewPane.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbCircularColourPreviewPane.TabIndex = 37;
            this.kgbCircularColourPreviewPane.Values.Heading = "Colour Preview";
            // 
            // cbxRibbonTabTextColourPreview
            // 
            this.cbxRibbonTabTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxRibbonTabTextColourPreview.ContextMenuStrip = this.ctxStatusTextColourUtiliseAsBaseColour;
            this.cbxRibbonTabTextColourPreview.Location = new System.Drawing.Point(19, 430);
            this.cbxRibbonTabTextColourPreview.Name = "cbxRibbonTabTextColourPreview";
            this.cbxRibbonTabTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxRibbonTabTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxRibbonTabTextColourPreview.TabIndex = 54;
            this.cbxRibbonTabTextColourPreview.TabStop = false;
            // 
            // ctxStatusTextColourUtiliseAsBaseColour
            // 
            this.ctxStatusTextColourUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxStatusTextColourUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem42});
            this.ctxStatusTextColourUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxStatusTextColourUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem42
            // 
            this.toolStripMenuItem42.Name = "toolStripMenuItem42";
            this.toolStripMenuItem42.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem42.Text = "&Utilise as Base Colour";
            // 
            // cbxLinkFocusedColourPreview
            // 
            this.cbxLinkFocusedColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkFocusedColourPreview.ContextMenuStrip = this.ctxStatusTextColourUtiliseAsBaseColour;
            this.cbxLinkFocusedColourPreview.Location = new System.Drawing.Point(799, 118);
            this.cbxLinkFocusedColourPreview.Name = "cbxLinkFocusedColourPreview";
            this.cbxLinkFocusedColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkFocusedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkFocusedColourPreview.TabIndex = 53;
            this.cbxLinkFocusedColourPreview.TabStop = false;
            // 
            // cbxStatusTextColourPreview
            // 
            this.cbxStatusTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxStatusTextColourPreview.ContextMenuStrip = this.ctxStatusTextColourUtiliseAsBaseColour;
            this.cbxStatusTextColourPreview.Location = new System.Drawing.Point(799, 326);
            this.cbxStatusTextColourPreview.Name = "cbxStatusTextColourPreview";
            this.cbxStatusTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxStatusTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxStatusTextColourPreview.TabIndex = 52;
            this.cbxStatusTextColourPreview.TabStop = false;
            // 
            // cbxCustomTextColourThreePreview
            // 
            this.cbxCustomTextColourThreePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourThreePreview.ContextMenuStrip = this.ctxCustomTextColourThreeUtiliseAsBaseColour;
            this.cbxCustomTextColourThreePreview.Location = new System.Drawing.Point(279, 326);
            this.cbxCustomTextColourThreePreview.Name = "cbxCustomTextColourThreePreview";
            this.cbxCustomTextColourThreePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourThreePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourThreePreview.TabIndex = 51;
            this.cbxCustomTextColourThreePreview.TabStop = false;
            // 
            // ctxCustomTextColourThreeUtiliseAsBaseColour
            // 
            this.ctxCustomTextColourThreeUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourThreeUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem38});
            this.ctxCustomTextColourThreeUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxCustomTextColourThreeUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem38
            // 
            this.toolStripMenuItem38.Name = "toolStripMenuItem38";
            this.toolStripMenuItem38.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem38.Text = "&Utilise as Base Colour";
            // 
            // cbxCustomTextColourTwoPreview
            // 
            this.cbxCustomTextColourTwoPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourTwoPreview.ContextMenuStrip = this.ctxCustomTextColourTwoUtiliseAsBaseColour;
            this.cbxCustomTextColourTwoPreview.Location = new System.Drawing.Point(149, 326);
            this.cbxCustomTextColourTwoPreview.Name = "cbxCustomTextColourTwoPreview";
            this.cbxCustomTextColourTwoPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourTwoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourTwoPreview.TabIndex = 50;
            this.cbxCustomTextColourTwoPreview.TabStop = false;
            // 
            // ctxCustomTextColourTwoUtiliseAsBaseColour
            // 
            this.ctxCustomTextColourTwoUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourTwoUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem37});
            this.ctxCustomTextColourTwoUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxCustomTextColourTwoUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem37
            // 
            this.toolStripMenuItem37.Name = "toolStripMenuItem37";
            this.toolStripMenuItem37.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem37.Text = "&Utilise as Base Colour";
            // 
            // cbxMenuTextColourPreview
            // 
            this.cbxMenuTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxMenuTextColourPreview.ContextMenuStrip = this.ctxMenuTextColourUtiliseAsBaseColour;
            this.cbxMenuTextColourPreview.Location = new System.Drawing.Point(669, 326);
            this.cbxMenuTextColourPreview.Name = "cbxMenuTextColourPreview";
            this.cbxMenuTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxMenuTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxMenuTextColourPreview.TabIndex = 49;
            this.cbxMenuTextColourPreview.TabStop = false;
            // 
            // ctxMenuTextColourUtiliseAsBaseColour
            // 
            this.ctxMenuTextColourUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxMenuTextColourUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem41});
            this.ctxMenuTextColourUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxMenuTextColourUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem41
            // 
            this.toolStripMenuItem41.Name = "toolStripMenuItem41";
            this.toolStripMenuItem41.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem41.Text = "&Utilise as Base Colour";
            // 
            // cbxCustomTextColourFourPreview
            // 
            this.cbxCustomTextColourFourPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourFourPreview.ContextMenuStrip = this.ctxCustomTextColourFourUtiliseAsBaseColour;
            this.cbxCustomTextColourFourPreview.Location = new System.Drawing.Point(409, 326);
            this.cbxCustomTextColourFourPreview.Name = "cbxCustomTextColourFourPreview";
            this.cbxCustomTextColourFourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourFourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourFourPreview.TabIndex = 48;
            this.cbxCustomTextColourFourPreview.TabStop = false;
            // 
            // ctxCustomTextColourFourUtiliseAsBaseColour
            // 
            this.ctxCustomTextColourFourUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourFourUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem39});
            this.ctxCustomTextColourFourUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxCustomTextColourFourUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem39
            // 
            this.toolStripMenuItem39.Name = "toolStripMenuItem39";
            this.toolStripMenuItem39.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem39.Text = "&Utilise as Base Colour";
            // 
            // cbxCustomTextColourFivePreview
            // 
            this.cbxCustomTextColourFivePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourFivePreview.ContextMenuStrip = this.ctxCustomTextColourFiveUtiliseAsBaseColour;
            this.cbxCustomTextColourFivePreview.Location = new System.Drawing.Point(539, 326);
            this.cbxCustomTextColourFivePreview.Name = "cbxCustomTextColourFivePreview";
            this.cbxCustomTextColourFivePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourFivePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourFivePreview.TabIndex = 47;
            this.cbxCustomTextColourFivePreview.TabStop = false;
            // 
            // ctxCustomTextColourFiveUtiliseAsBaseColour
            // 
            this.ctxCustomTextColourFiveUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourFiveUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem40});
            this.ctxCustomTextColourFiveUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxCustomTextColourFiveUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem40
            // 
            this.toolStripMenuItem40.Name = "toolStripMenuItem40";
            this.toolStripMenuItem40.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem40.Text = "&Utilise as Base Colour";
            // 
            // cbxCustomTextColourOnePreview
            // 
            this.cbxCustomTextColourOnePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourOnePreview.ContextMenuStrip = this.ctxCustomTextColourOneUtiliseAsBaseColour;
            this.cbxCustomTextColourOnePreview.Location = new System.Drawing.Point(19, 326);
            this.cbxCustomTextColourOnePreview.Name = "cbxCustomTextColourOnePreview";
            this.cbxCustomTextColourOnePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourOnePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourOnePreview.TabIndex = 46;
            this.cbxCustomTextColourOnePreview.TabStop = false;
            // 
            // ctxCustomTextColourOneUtiliseAsBaseColour
            // 
            this.ctxCustomTextColourOneUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourOneUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem36});
            this.ctxCustomTextColourOneUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxCustomTextColourOneUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem36
            // 
            this.toolStripMenuItem36.Name = "toolStripMenuItem36";
            this.toolStripMenuItem36.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem36.Text = "&Utilise as Base Colour";
            // 
            // cbxCustomColourFivePreview
            // 
            this.cbxCustomColourFivePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourFivePreview.ContextMenuStrip = this.ctxCustomColourFiveUtiliseAsBaseColour;
            this.cbxCustomColourFivePreview.Location = new System.Drawing.Point(799, 222);
            this.cbxCustomColourFivePreview.Name = "cbxCustomColourFivePreview";
            this.cbxCustomColourFivePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourFivePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourFivePreview.TabIndex = 45;
            this.cbxCustomColourFivePreview.TabStop = false;
            // 
            // ctxCustomColourFiveUtiliseAsBaseColour
            // 
            this.ctxCustomColourFiveUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourFiveUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem35});
            this.ctxCustomColourFiveUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxCustomColourFiveUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem35
            // 
            this.toolStripMenuItem35.Name = "toolStripMenuItem35";
            this.toolStripMenuItem35.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem35.Text = "&Utilise as Base Colour";
            // 
            // cbxCustomColourTwoPreview
            // 
            this.cbxCustomColourTwoPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourTwoPreview.ContextMenuStrip = this.ctxCustomColourTwoUtiliseAsBaseColour;
            this.cbxCustomColourTwoPreview.Location = new System.Drawing.Point(409, 222);
            this.cbxCustomColourTwoPreview.Name = "cbxCustomColourTwoPreview";
            this.cbxCustomColourTwoPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourTwoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourTwoPreview.TabIndex = 44;
            this.cbxCustomColourTwoPreview.TabStop = false;
            // 
            // ctxCustomColourTwoUtiliseAsBaseColour
            // 
            this.ctxCustomColourTwoUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourTwoUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem32});
            this.ctxCustomColourTwoUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxCustomColourTwoUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            this.toolStripMenuItem32.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem32.Text = "&Utilise as Base Colour";
            // 
            // cbxCustomColourOnePreview
            // 
            this.cbxCustomColourOnePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourOnePreview.ContextMenuStrip = this.ctxCustomColourOneUtiliseAsBaseColour;
            this.cbxCustomColourOnePreview.Location = new System.Drawing.Point(279, 222);
            this.cbxCustomColourOnePreview.Name = "cbxCustomColourOnePreview";
            this.cbxCustomColourOnePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourOnePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourOnePreview.TabIndex = 43;
            this.cbxCustomColourOnePreview.TabStop = false;
            // 
            // ctxCustomColourOneUtiliseAsBaseColour
            // 
            this.ctxCustomColourOneUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourOneUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem31});
            this.ctxCustomColourOneUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxCustomColourOneUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            this.toolStripMenuItem31.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem31.Text = "&Utilise as Base Colour";
            // 
            // cbxLinkVisitedColourPreview
            // 
            this.cbxLinkVisitedColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkVisitedColourPreview.ContextMenuStrip = this.ctxLinkVisitedUtiliseAsBaseColour;
            this.cbxLinkVisitedColourPreview.Location = new System.Drawing.Point(149, 222);
            this.cbxLinkVisitedColourPreview.Name = "cbxLinkVisitedColourPreview";
            this.cbxLinkVisitedColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkVisitedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkVisitedColourPreview.TabIndex = 42;
            this.cbxLinkVisitedColourPreview.TabStop = false;
            // 
            // ctxLinkVisitedUtiliseAsBaseColour
            // 
            this.ctxLinkVisitedUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLinkVisitedUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem30});
            this.ctxLinkVisitedUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxLinkVisitedUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem30
            // 
            this.toolStripMenuItem30.Name = "toolStripMenuItem30";
            this.toolStripMenuItem30.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem30.Text = "&Utilise as Base Colour";
            // 
            // cbxCustomColourThreePreview
            // 
            this.cbxCustomColourThreePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourThreePreview.ContextMenuStrip = this.ctxCustomColourThreeUtiliseAsBaseColour;
            this.cbxCustomColourThreePreview.Location = new System.Drawing.Point(539, 222);
            this.cbxCustomColourThreePreview.Name = "cbxCustomColourThreePreview";
            this.cbxCustomColourThreePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourThreePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourThreePreview.TabIndex = 41;
            this.cbxCustomColourThreePreview.TabStop = false;
            // 
            // ctxCustomColourThreeUtiliseAsBaseColour
            // 
            this.ctxCustomColourThreeUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourThreeUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem33});
            this.ctxCustomColourThreeUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxCustomColourThreeUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem33.Text = "&Utilise as Base Colour";
            // 
            // cbxCustomColourFourPreview
            // 
            this.cbxCustomColourFourPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourFourPreview.ContextMenuStrip = this.ctxCustomColourFourUtiliseAsBaseColour;
            this.cbxCustomColourFourPreview.Location = new System.Drawing.Point(669, 222);
            this.cbxCustomColourFourPreview.Name = "cbxCustomColourFourPreview";
            this.cbxCustomColourFourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourFourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourFourPreview.TabIndex = 40;
            this.cbxCustomColourFourPreview.TabStop = false;
            // 
            // ctxCustomColourFourUtiliseAsBaseColour
            // 
            this.ctxCustomColourFourUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourFourUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem34});
            this.ctxCustomColourFourUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxCustomColourFourUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            this.toolStripMenuItem34.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem34.Text = "&Utilise as Base Colour";
            // 
            // cbxLinkHoverColourPreview
            // 
            this.cbxLinkHoverColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkHoverColourPreview.ContextMenuStrip = this.ctxLinkHoverUtiliseAsBaseColour;
            this.cbxLinkHoverColourPreview.Location = new System.Drawing.Point(19, 222);
            this.cbxLinkHoverColourPreview.Name = "cbxLinkHoverColourPreview";
            this.cbxLinkHoverColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkHoverColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkHoverColourPreview.TabIndex = 39;
            this.cbxLinkHoverColourPreview.TabStop = false;
            // 
            // ctxLinkHoverUtiliseAsBaseColour
            // 
            this.ctxLinkHoverUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLinkHoverUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem29});
            this.ctxLinkHoverUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxLinkHoverUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            this.toolStripMenuItem29.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem29.Text = "&Utilise as Base Colour";
            // 
            // cbxPressedTextColourPreview
            // 
            this.cbxPressedTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxPressedTextColourPreview.ContextMenuStrip = this.ctxPressedTextUtiliseAsBaseColour;
            this.cbxPressedTextColourPreview.Location = new System.Drawing.Point(409, 118);
            this.cbxPressedTextColourPreview.Name = "cbxPressedTextColourPreview";
            this.cbxPressedTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxPressedTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxPressedTextColourPreview.TabIndex = 38;
            this.cbxPressedTextColourPreview.TabStop = false;
            // 
            // ctxPressedTextUtiliseAsBaseColour
            // 
            this.ctxPressedTextUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxPressedTextUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem26});
            this.ctxPressedTextUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxPressedTextUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem26.Text = "&Utilise as Base Colour";
            // 
            // cbxFocusedTextColourPreview
            // 
            this.cbxFocusedTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxFocusedTextColourPreview.ContextMenuStrip = this.ctxFoucusedTextUtiliseAsBaseColour;
            this.cbxFocusedTextColourPreview.Location = new System.Drawing.Point(279, 118);
            this.cbxFocusedTextColourPreview.Name = "cbxFocusedTextColourPreview";
            this.cbxFocusedTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxFocusedTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxFocusedTextColourPreview.TabIndex = 37;
            this.cbxFocusedTextColourPreview.TabStop = false;
            // 
            // ctxFoucusedTextUtiliseAsBaseColour
            // 
            this.ctxFoucusedTextUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxFoucusedTextUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem25});
            this.ctxFoucusedTextUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxFoucusedTextUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem25.Text = "&Utilise as Base Colour";
            // 
            // cbxDisabledTextColourPreview
            // 
            this.cbxDisabledTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxDisabledTextColourPreview.ContextMenuStrip = this.ctxDisabledTextUtiliseAsBaseColour;
            this.cbxDisabledTextColourPreview.Location = new System.Drawing.Point(149, 118);
            this.cbxDisabledTextColourPreview.Name = "cbxDisabledTextColourPreview";
            this.cbxDisabledTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxDisabledTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxDisabledTextColourPreview.TabIndex = 36;
            this.cbxDisabledTextColourPreview.TabStop = false;
            // 
            // ctxDisabledTextUtiliseAsBaseColour
            // 
            this.ctxDisabledTextUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxDisabledTextUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem24});
            this.ctxDisabledTextUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxDisabledTextUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem24.Text = "&Utilise as Base Colour";
            // 
            // cbxDisabledControlColourPreview
            // 
            this.cbxDisabledControlColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxDisabledControlColourPreview.ContextMenuStrip = this.ctxDisabledUtiliseAsBaseColour;
            this.cbxDisabledControlColourPreview.Location = new System.Drawing.Point(539, 118);
            this.cbxDisabledControlColourPreview.Name = "cbxDisabledControlColourPreview";
            this.cbxDisabledControlColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxDisabledControlColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxDisabledControlColourPreview.TabIndex = 35;
            this.cbxDisabledControlColourPreview.TabStop = false;
            // 
            // ctxDisabledUtiliseAsBaseColour
            // 
            this.ctxDisabledUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxDisabledUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem27});
            this.ctxDisabledUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxDisabledUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem27.Text = "&Utilise as Base Colour";
            // 
            // cbxLinkNormalColourPreview
            // 
            this.cbxLinkNormalColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkNormalColourPreview.ContextMenuStrip = this.ctxLinkNormalUtiliseAsBaseColour;
            this.cbxLinkNormalColourPreview.Location = new System.Drawing.Point(669, 118);
            this.cbxLinkNormalColourPreview.Name = "cbxLinkNormalColourPreview";
            this.cbxLinkNormalColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkNormalColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkNormalColourPreview.TabIndex = 34;
            this.cbxLinkNormalColourPreview.TabStop = false;
            // 
            // ctxLinkNormalUtiliseAsBaseColour
            // 
            this.ctxLinkNormalUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLinkNormalUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem28});
            this.ctxLinkNormalUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxLinkNormalUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem28.Text = "&Utilise as Base Colour";
            // 
            // cbxNormalTextColourPreview
            // 
            this.cbxNormalTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxNormalTextColourPreview.ContextMenuStrip = this.ctxNormalTextUtiliseAsBaseColour;
            this.cbxNormalTextColourPreview.Location = new System.Drawing.Point(19, 118);
            this.cbxNormalTextColourPreview.Name = "cbxNormalTextColourPreview";
            this.cbxNormalTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxNormalTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxNormalTextColourPreview.TabIndex = 33;
            this.cbxNormalTextColourPreview.TabStop = false;
            // 
            // ctxNormalTextUtiliseAsBaseColour
            // 
            this.ctxNormalTextUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxNormalTextUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem23});
            this.ctxNormalTextUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxNormalTextUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem23.Text = "&Utilise as Base Colour";
            // 
            // cbxBorderColourPreview
            // 
            this.cbxBorderColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxBorderColourPreview.ContextMenuStrip = this.ctxBorderUtiliseAsBaseColour;
            this.cbxBorderColourPreview.Location = new System.Drawing.Point(669, 18);
            this.cbxBorderColourPreview.Name = "cbxBorderColourPreview";
            this.cbxBorderColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxBorderColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxBorderColourPreview.TabIndex = 32;
            this.cbxBorderColourPreview.TabStop = false;
            // 
            // ctxBorderUtiliseAsBaseColour
            // 
            this.ctxBorderUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxBorderUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem21});
            this.ctxBorderUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxBorderUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem21.Text = "&Utilise as Base Colour";
            // 
            // cbxAlternativeNormalTextColourPreview
            // 
            this.cbxAlternativeNormalTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxAlternativeNormalTextColourPreview.ContextMenuStrip = this.ctxAlternativeNormalTextUtiliseAsBaseColour;
            this.cbxAlternativeNormalTextColourPreview.Location = new System.Drawing.Point(799, 18);
            this.cbxAlternativeNormalTextColourPreview.Name = "cbxAlternativeNormalTextColourPreview";
            this.cbxAlternativeNormalTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxAlternativeNormalTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxAlternativeNormalTextColourPreview.TabIndex = 31;
            this.cbxAlternativeNormalTextColourPreview.TabStop = false;
            // 
            // ctxAlternativeNormalTextUtiliseAsBaseColour
            // 
            this.ctxAlternativeNormalTextUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxAlternativeNormalTextUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem22});
            this.ctxAlternativeNormalTextUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxAlternativeNormalTextUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem22.Text = "&Utilise as Base Colour";
            // 
            // cbxLightestColourPreview
            // 
            this.cbxLightestColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLightestColourPreview.ContextMenuStrip = this.ctxLightestUtiliseAsBaseColour;
            this.cbxLightestColourPreview.Location = new System.Drawing.Point(539, 15);
            this.cbxLightestColourPreview.Name = "cbxLightestColourPreview";
            this.cbxLightestColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLightestColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLightestColourPreview.TabIndex = 30;
            this.cbxLightestColourPreview.TabStop = false;
            // 
            // ctxLightestUtiliseAsBaseColour
            // 
            this.ctxLightestUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLightestUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem20});
            this.ctxLightestUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxLightestUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem20.Text = "&Utilise as Base Colour";
            // 
            // cbxLightColourPreview
            // 
            this.cbxLightColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLightColourPreview.ContextMenuStrip = this.ctxLightUtiliseAsBaseColour;
            this.cbxLightColourPreview.Location = new System.Drawing.Point(409, 15);
            this.cbxLightColourPreview.Name = "cbxLightColourPreview";
            this.cbxLightColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLightColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLightColourPreview.TabIndex = 29;
            this.cbxLightColourPreview.TabStop = false;
            // 
            // ctxLightUtiliseAsBaseColour
            // 
            this.ctxLightUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLightUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem19});
            this.ctxLightUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxLightUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem19.Text = "&Utilise as Base Colour";
            // 
            // cbxMiddleColourPreview
            // 
            this.cbxMiddleColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxMiddleColourPreview.ContextMenuStrip = this.ctxMiddleUtiliseAsBaseColour;
            this.cbxMiddleColourPreview.Location = new System.Drawing.Point(279, 15);
            this.cbxMiddleColourPreview.Name = "cbxMiddleColourPreview";
            this.cbxMiddleColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxMiddleColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxMiddleColourPreview.TabIndex = 28;
            this.cbxMiddleColourPreview.TabStop = false;
            // 
            // ctxMiddleUtiliseAsBaseColour
            // 
            this.ctxMiddleUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxMiddleUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem18});
            this.ctxMiddleUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxMiddleUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem18.Text = "&Utilise as Base Colour";
            // 
            // cbxDarkColourPreview
            // 
            this.cbxDarkColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxDarkColourPreview.ContextMenuStrip = this.ctxDarkUtiliseAsBaseColour;
            this.cbxDarkColourPreview.Location = new System.Drawing.Point(149, 15);
            this.cbxDarkColourPreview.Name = "cbxDarkColourPreview";
            this.cbxDarkColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxDarkColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxDarkColourPreview.TabIndex = 27;
            this.cbxDarkColourPreview.TabStop = false;
            // 
            // ctxDarkUtiliseAsBaseColour
            // 
            this.ctxDarkUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxDarkUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem17});
            this.ctxDarkUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxDarkUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem17.Text = "&Utilise as Base Colour";
            // 
            // cbxBaseColourPreview
            // 
            this.cbxBaseColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxBaseColourPreview.ContextMenuStrip = this.ctxBaseUtiliseAsBaseColour;
            this.cbxBaseColourPreview.Location = new System.Drawing.Point(19, 14);
            this.cbxBaseColourPreview.Name = "cbxBaseColourPreview";
            this.cbxBaseColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxBaseColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxBaseColourPreview.TabIndex = 26;
            this.cbxBaseColourPreview.TabStop = false;
            // 
            // ctxBaseUtiliseAsBaseColour
            // 
            this.ctxBaseUtiliseAsBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxBaseUtiliseAsBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utiliseAsBaseColourToolStripMenuItem});
            this.ctxBaseUtiliseAsBaseColour.Name = "ctxUtiliseAsBaseColour";
            this.ctxBaseUtiliseAsBaseColour.Size = new System.Drawing.Size(187, 26);
            // 
            // utiliseAsBaseColourToolStripMenuItem
            // 
            this.utiliseAsBaseColourToolStripMenuItem.Name = "utiliseAsBaseColourToolStripMenuItem";
            this.utiliseAsBaseColourToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.utiliseAsBaseColourToolStripMenuItem.Text = "&Utilise as Base Colour";
            // 
            // kgbPaletteProperties
            // 
            this.kgbPaletteProperties.Location = new System.Drawing.Point(900, 22);
            this.kgbPaletteProperties.Name = "kgbPaletteProperties";
            // 
            // kgbPaletteProperties.Panel
            // 
            this.kgbPaletteProperties.Panel.Controls.Add(this.labelGridNormal);
            this.kgbPaletteProperties.Size = new System.Drawing.Size(525, 552);
            this.kgbPaletteProperties.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbPaletteProperties.TabIndex = 29;
            this.kgbPaletteProperties.Values.Heading = "Palette Properties";
            // 
            // labelGridNormal
            // 
            this.labelGridNormal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGridNormal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGridNormal.HelpVisible = false;
            this.labelGridNormal.Location = new System.Drawing.Point(17, 14);
            this.labelGridNormal.Name = "labelGridNormal";
            this.labelGridNormal.Size = new System.Drawing.Size(491, 487);
            this.labelGridNormal.TabIndex = 3;
            this.labelGridNormal.ToolbarVisible = false;
            // 
            // kgbSquarePreviewPane
            // 
            this.kgbSquarePreviewPane.Location = new System.Drawing.Point(12, 22);
            this.kgbSquarePreviewPane.Name = "kgbSquarePreviewPane";
            // 
            // kgbSquarePreviewPane.Panel
            // 
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxRibbonTabTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxLinkFocusedColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxStatusTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxMenuTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxCustomColourFourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxCustomTextColourFivePreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxCustomTextColourFourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxCustomTextColourThreePreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxCustomTextColourTwoPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxCustomTextColourOnePreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxCustomColourFivePreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxCustomColourThreePreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxCustomColourTwoPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxCustomColourOnePreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxLinkVisitedColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxLinkHoverColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxAlternativeNormalTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxLinkNormalColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxDisabledControlColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxPressedTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxFocusedTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxDisabledTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxNormalTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxBorderColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxBaseColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxLightestColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxDarkColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxLightColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxMiddleColourPreview);
            this.kgbSquarePreviewPane.Size = new System.Drawing.Size(1413, 552);
            this.kgbSquarePreviewPane.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbSquarePreviewPane.TabIndex = 36;
            this.kgbSquarePreviewPane.Values.Heading = "Colour Preview";
            // 
            // pbxRibbonTabTextColourPreview
            // 
            this.pbxRibbonTabTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxRibbonTabTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxRibbonTabTextColourPreview.ContextMenuStrip = this.ctxStatusTextColourUtiliseAsBaseColour;
            this.pbxRibbonTabTextColourPreview.Location = new System.Drawing.Point(799, 433);
            this.pbxRibbonTabTextColourPreview.Name = "pbxRibbonTabTextColourPreview";
            this.pbxRibbonTabTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxRibbonTabTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxRibbonTabTextColourPreview.TabIndex = 88;
            this.pbxRibbonTabTextColourPreview.TabStop = false;
            // 
            // pbxLinkFocusedColourPreview
            // 
            this.pbxLinkFocusedColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkFocusedColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkFocusedColourPreview.Location = new System.Drawing.Point(279, 225);
            this.pbxLinkFocusedColourPreview.Name = "pbxLinkFocusedColourPreview";
            this.pbxLinkFocusedColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLinkFocusedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkFocusedColourPreview.TabIndex = 87;
            this.pbxLinkFocusedColourPreview.TabStop = false;
            // 
            // pbxStatusTextColourPreview
            // 
            this.pbxStatusTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxStatusTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxStatusTextColourPreview.ContextMenuStrip = this.ctxStatusTextColourUtiliseAsBaseColour;
            this.pbxStatusTextColourPreview.Location = new System.Drawing.Point(667, 433);
            this.pbxStatusTextColourPreview.Name = "pbxStatusTextColourPreview";
            this.pbxStatusTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxStatusTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxStatusTextColourPreview.TabIndex = 84;
            this.pbxStatusTextColourPreview.TabStop = false;
            // 
            // pbxMenuTextColourPreview
            // 
            this.pbxMenuTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxMenuTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMenuTextColourPreview.ContextMenuStrip = this.ctxMenuTextColourUtiliseAsBaseColour;
            this.pbxMenuTextColourPreview.Location = new System.Drawing.Point(539, 433);
            this.pbxMenuTextColourPreview.Name = "pbxMenuTextColourPreview";
            this.pbxMenuTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxMenuTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxMenuTextColourPreview.TabIndex = 83;
            this.pbxMenuTextColourPreview.TabStop = false;
            // 
            // pbxCustomColourFourPreview
            // 
            this.pbxCustomColourFourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomColourFourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomColourFourPreview.ContextMenuStrip = this.ctxCustomColourFourUtiliseAsBaseColour;
            this.pbxCustomColourFourPreview.Location = new System.Drawing.Point(1059, 225);
            this.pbxCustomColourFourPreview.Name = "pbxCustomColourFourPreview";
            this.pbxCustomColourFourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomColourFourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomColourFourPreview.TabIndex = 82;
            this.pbxCustomColourFourPreview.TabStop = false;
            // 
            // pbxCustomTextColourFivePreview
            // 
            this.pbxCustomTextColourFivePreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomTextColourFivePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomTextColourFivePreview.ContextMenuStrip = this.ctxCustomTextColourFiveUtiliseAsBaseColour;
            this.pbxCustomTextColourFivePreview.Location = new System.Drawing.Point(409, 433);
            this.pbxCustomTextColourFivePreview.Name = "pbxCustomTextColourFivePreview";
            this.pbxCustomTextColourFivePreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomTextColourFivePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomTextColourFivePreview.TabIndex = 81;
            this.pbxCustomTextColourFivePreview.TabStop = false;
            // 
            // pbxCustomTextColourFourPreview
            // 
            this.pbxCustomTextColourFourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomTextColourFourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomTextColourFourPreview.ContextMenuStrip = this.ctxCustomTextColourFourUtiliseAsBaseColour;
            this.pbxCustomTextColourFourPreview.Location = new System.Drawing.Point(279, 434);
            this.pbxCustomTextColourFourPreview.Name = "pbxCustomTextColourFourPreview";
            this.pbxCustomTextColourFourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomTextColourFourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomTextColourFourPreview.TabIndex = 80;
            this.pbxCustomTextColourFourPreview.TabStop = false;
            // 
            // pbxCustomTextColourThreePreview
            // 
            this.pbxCustomTextColourThreePreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomTextColourThreePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomTextColourThreePreview.ContextMenuStrip = this.ctxCustomTextColourThreeUtiliseAsBaseColour;
            this.pbxCustomTextColourThreePreview.Location = new System.Drawing.Point(149, 434);
            this.pbxCustomTextColourThreePreview.Name = "pbxCustomTextColourThreePreview";
            this.pbxCustomTextColourThreePreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomTextColourThreePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomTextColourThreePreview.TabIndex = 79;
            this.pbxCustomTextColourThreePreview.TabStop = false;
            // 
            // pbxCustomTextColourTwoPreview
            // 
            this.pbxCustomTextColourTwoPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomTextColourTwoPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomTextColourTwoPreview.ContextMenuStrip = this.ctxCustomTextColourTwoUtiliseAsBaseColour;
            this.pbxCustomTextColourTwoPreview.Location = new System.Drawing.Point(19, 433);
            this.pbxCustomTextColourTwoPreview.Name = "pbxCustomTextColourTwoPreview";
            this.pbxCustomTextColourTwoPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomTextColourTwoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomTextColourTwoPreview.TabIndex = 78;
            this.pbxCustomTextColourTwoPreview.TabStop = false;
            // 
            // pbxCustomTextColourOnePreview
            // 
            this.pbxCustomTextColourOnePreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomTextColourOnePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomTextColourOnePreview.ContextMenuStrip = this.ctxCustomTextColourOneUtiliseAsBaseColour;
            this.pbxCustomTextColourOnePreview.Location = new System.Drawing.Point(1319, 224);
            this.pbxCustomTextColourOnePreview.Name = "pbxCustomTextColourOnePreview";
            this.pbxCustomTextColourOnePreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomTextColourOnePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomTextColourOnePreview.TabIndex = 77;
            this.pbxCustomTextColourOnePreview.TabStop = false;
            // 
            // pbxCustomColourFivePreview
            // 
            this.pbxCustomColourFivePreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomColourFivePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomColourFivePreview.ContextMenuStrip = this.ctxCustomColourFiveUtiliseAsBaseColour;
            this.pbxCustomColourFivePreview.Location = new System.Drawing.Point(1189, 224);
            this.pbxCustomColourFivePreview.Name = "pbxCustomColourFivePreview";
            this.pbxCustomColourFivePreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomColourFivePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomColourFivePreview.TabIndex = 76;
            this.pbxCustomColourFivePreview.TabStop = false;
            // 
            // pbxCustomColourThreePreview
            // 
            this.pbxCustomColourThreePreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomColourThreePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomColourThreePreview.ContextMenuStrip = this.ctxCustomColourThreeUtiliseAsBaseColour;
            this.pbxCustomColourThreePreview.Location = new System.Drawing.Point(929, 224);
            this.pbxCustomColourThreePreview.Name = "pbxCustomColourThreePreview";
            this.pbxCustomColourThreePreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomColourThreePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomColourThreePreview.TabIndex = 75;
            this.pbxCustomColourThreePreview.TabStop = false;
            // 
            // pbxCustomColourTwoPreview
            // 
            this.pbxCustomColourTwoPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomColourTwoPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomColourTwoPreview.ContextMenuStrip = this.ctxCustomColourTwoUtiliseAsBaseColour;
            this.pbxCustomColourTwoPreview.Location = new System.Drawing.Point(799, 224);
            this.pbxCustomColourTwoPreview.Name = "pbxCustomColourTwoPreview";
            this.pbxCustomColourTwoPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomColourTwoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomColourTwoPreview.TabIndex = 74;
            this.pbxCustomColourTwoPreview.TabStop = false;
            // 
            // pbxCustomColourOnePreview
            // 
            this.pbxCustomColourOnePreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomColourOnePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomColourOnePreview.ContextMenuStrip = this.ctxCustomColourOneUtiliseAsBaseColour;
            this.pbxCustomColourOnePreview.Location = new System.Drawing.Point(669, 225);
            this.pbxCustomColourOnePreview.Name = "pbxCustomColourOnePreview";
            this.pbxCustomColourOnePreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomColourOnePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomColourOnePreview.TabIndex = 73;
            this.pbxCustomColourOnePreview.TabStop = false;
            // 
            // pbxLinkVisitedColourPreview
            // 
            this.pbxLinkVisitedColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkVisitedColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkVisitedColourPreview.ContextMenuStrip = this.ctxLinkVisitedUtiliseAsBaseColour;
            this.pbxLinkVisitedColourPreview.Location = new System.Drawing.Point(539, 225);
            this.pbxLinkVisitedColourPreview.Name = "pbxLinkVisitedColourPreview";
            this.pbxLinkVisitedColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLinkVisitedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkVisitedColourPreview.TabIndex = 72;
            this.pbxLinkVisitedColourPreview.TabStop = false;
            // 
            // pbxLinkHoverColourPreview
            // 
            this.pbxLinkHoverColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkHoverColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkHoverColourPreview.ContextMenuStrip = this.ctxLinkHoverUtiliseAsBaseColour;
            this.pbxLinkHoverColourPreview.Location = new System.Drawing.Point(409, 225);
            this.pbxLinkHoverColourPreview.Name = "pbxLinkHoverColourPreview";
            this.pbxLinkHoverColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLinkHoverColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkHoverColourPreview.TabIndex = 71;
            this.pbxLinkHoverColourPreview.TabStop = false;
            // 
            // pbxAlternativeNormalTextColourPreview
            // 
            this.pbxAlternativeNormalTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxAlternativeNormalTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxAlternativeNormalTextColourPreview.ContextMenuStrip = this.ctxAlternativeNormalTextUtiliseAsBaseColour;
            this.pbxAlternativeNormalTextColourPreview.Location = new System.Drawing.Point(799, 15);
            this.pbxAlternativeNormalTextColourPreview.Name = "pbxAlternativeNormalTextColourPreview";
            this.pbxAlternativeNormalTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxAlternativeNormalTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAlternativeNormalTextColourPreview.TabIndex = 70;
            this.pbxAlternativeNormalTextColourPreview.TabStop = false;
            // 
            // pbxLinkNormalColourPreview
            // 
            this.pbxLinkNormalColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkNormalColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkNormalColourPreview.ContextMenuStrip = this.ctxLinkNormalUtiliseAsBaseColour;
            this.pbxLinkNormalColourPreview.Location = new System.Drawing.Point(149, 224);
            this.pbxLinkNormalColourPreview.Name = "pbxLinkNormalColourPreview";
            this.pbxLinkNormalColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLinkNormalColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkNormalColourPreview.TabIndex = 69;
            this.pbxLinkNormalColourPreview.TabStop = false;
            // 
            // pbxDisabledControlColourPreview
            // 
            this.pbxDisabledControlColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxDisabledControlColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxDisabledControlColourPreview.ContextMenuStrip = this.ctxDisabledUtiliseAsBaseColour;
            this.pbxDisabledControlColourPreview.Location = new System.Drawing.Point(19, 224);
            this.pbxDisabledControlColourPreview.Name = "pbxDisabledControlColourPreview";
            this.pbxDisabledControlColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxDisabledControlColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxDisabledControlColourPreview.TabIndex = 68;
            this.pbxDisabledControlColourPreview.TabStop = false;
            // 
            // pbxPressedTextColourPreview
            // 
            this.pbxPressedTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxPressedTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPressedTextColourPreview.ContextMenuStrip = this.ctxPressedTextUtiliseAsBaseColour;
            this.pbxPressedTextColourPreview.Location = new System.Drawing.Point(1319, 15);
            this.pbxPressedTextColourPreview.Name = "pbxPressedTextColourPreview";
            this.pbxPressedTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxPressedTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPressedTextColourPreview.TabIndex = 67;
            this.pbxPressedTextColourPreview.TabStop = false;
            // 
            // pbxFocusedTextColourPreview
            // 
            this.pbxFocusedTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxFocusedTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxFocusedTextColourPreview.ContextMenuStrip = this.ctxFoucusedTextUtiliseAsBaseColour;
            this.pbxFocusedTextColourPreview.Location = new System.Drawing.Point(1189, 15);
            this.pbxFocusedTextColourPreview.Name = "pbxFocusedTextColourPreview";
            this.pbxFocusedTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxFocusedTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxFocusedTextColourPreview.TabIndex = 66;
            this.pbxFocusedTextColourPreview.TabStop = false;
            // 
            // pbxDisabledTextColourPreview
            // 
            this.pbxDisabledTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxDisabledTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxDisabledTextColourPreview.ContextMenuStrip = this.ctxDisabledTextUtiliseAsBaseColour;
            this.pbxDisabledTextColourPreview.Location = new System.Drawing.Point(1059, 15);
            this.pbxDisabledTextColourPreview.Name = "pbxDisabledTextColourPreview";
            this.pbxDisabledTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxDisabledTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxDisabledTextColourPreview.TabIndex = 65;
            this.pbxDisabledTextColourPreview.TabStop = false;
            // 
            // pbxNormalTextColourPreview
            // 
            this.pbxNormalTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxNormalTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxNormalTextColourPreview.ContextMenuStrip = this.ctxNormalTextUtiliseAsBaseColour;
            this.pbxNormalTextColourPreview.Location = new System.Drawing.Point(929, 15);
            this.pbxNormalTextColourPreview.Name = "pbxNormalTextColourPreview";
            this.pbxNormalTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxNormalTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxNormalTextColourPreview.TabIndex = 64;
            this.pbxNormalTextColourPreview.TabStop = false;
            // 
            // pbxBorderColourPreview
            // 
            this.pbxBorderColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxBorderColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxBorderColourPreview.ContextMenuStrip = this.ctxBorderUtiliseAsBaseColour;
            this.pbxBorderColourPreview.Location = new System.Drawing.Point(669, 15);
            this.pbxBorderColourPreview.Name = "pbxBorderColourPreview";
            this.pbxBorderColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxBorderColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBorderColourPreview.TabIndex = 63;
            this.pbxBorderColourPreview.TabStop = false;
            // 
            // pbxBaseColourPreview
            // 
            this.pbxBaseColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxBaseColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxBaseColourPreview.ContextMenuStrip = this.ctxBaseUtiliseAsBaseColour;
            this.pbxBaseColourPreview.Location = new System.Drawing.Point(19, 15);
            this.pbxBaseColourPreview.Name = "pbxBaseColourPreview";
            this.pbxBaseColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxBaseColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBaseColourPreview.TabIndex = 4;
            this.pbxBaseColourPreview.TabStop = false;
            // 
            // pbxLightestColourPreview
            // 
            this.pbxLightestColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLightestColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLightestColourPreview.ContextMenuStrip = this.ctxLightestUtiliseAsBaseColour;
            this.pbxLightestColourPreview.Location = new System.Drawing.Point(539, 15);
            this.pbxLightestColourPreview.Name = "pbxLightestColourPreview";
            this.pbxLightestColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLightestColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLightestColourPreview.TabIndex = 8;
            this.pbxLightestColourPreview.TabStop = false;
            // 
            // pbxDarkColourPreview
            // 
            this.pbxDarkColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxDarkColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxDarkColourPreview.ContextMenuStrip = this.ctxDarkUtiliseAsBaseColour;
            this.pbxDarkColourPreview.Location = new System.Drawing.Point(149, 15);
            this.pbxDarkColourPreview.Name = "pbxDarkColourPreview";
            this.pbxDarkColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxDarkColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxDarkColourPreview.TabIndex = 5;
            this.pbxDarkColourPreview.TabStop = false;
            // 
            // pbxLightColourPreview
            // 
            this.pbxLightColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLightColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLightColourPreview.ContextMenuStrip = this.ctxLightUtiliseAsBaseColour;
            this.pbxLightColourPreview.Location = new System.Drawing.Point(409, 15);
            this.pbxLightColourPreview.Name = "pbxLightColourPreview";
            this.pbxLightColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLightColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLightColourPreview.TabIndex = 7;
            this.pbxLightColourPreview.TabStop = false;
            // 
            // pbxMiddleColourPreview
            // 
            this.pbxMiddleColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxMiddleColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMiddleColourPreview.ContextMenuStrip = this.ctxMiddleUtiliseAsBaseColour;
            this.pbxMiddleColourPreview.Location = new System.Drawing.Point(279, 15);
            this.pbxMiddleColourPreview.Name = "pbxMiddleColourPreview";
            this.pbxMiddleColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxMiddleColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxMiddleColourPreview.TabIndex = 6;
            this.pbxMiddleColourPreview.TabStop = false;
            // 
            // tmrUpdateUI
            // 
            this.tmrUpdateUI.Enabled = true;
            this.tmrUpdateUI.Interval = 250;
            this.tmrUpdateUI.Tick += new System.EventHandler(this.tmrUpdateUI_Tick);
            // 
            // cmsViewType
            // 
            this.cmsViewType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsViewType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardPictureboxesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.circularPictureboxesToolStripMenuItem});
            this.cmsViewType.Name = "cmsViewType";
            this.cmsViewType.Size = new System.Drawing.Size(192, 54);
            // 
            // standardPictureboxesToolStripMenuItem
            // 
            this.standardPictureboxesToolStripMenuItem.Name = "standardPictureboxesToolStripMenuItem";
            this.standardPictureboxesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.standardPictureboxesToolStripMenuItem.Text = "&Standard Pictureboxes";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // circularPictureboxesToolStripMenuItem
            // 
            this.circularPictureboxesToolStripMenuItem.Name = "circularPictureboxesToolStripMenuItem";
            this.circularPictureboxesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.circularPictureboxesToolStripMenuItem.Text = "Cir&cular Pictureboxes";
            // 
            // cmsExperinental
            // 
            this.cmsExperinental.Name = "cmsExperinental";
            this.cmsExperinental.Size = new System.Drawing.Size(61, 4);
            // 
            // palette
            // 
            this.palette.CustomisedKryptonPaletteFilePath = null;
            // 
            // kcNewPalette
            // 
            this.kcNewPalette.Text = "New Palette";
            this.kcNewPalette.Execute += new System.EventHandler(this.kcNewPalette_Execute);
            // 
            // kcOpenPalette
            // 
            this.kcOpenPalette.Text = "Open Palette";
            // 
            // kcSavePalette
            // 
            this.kcSavePalette.Text = "Save Palette";
            // 
            // kcSavePaletteAs
            // 
            this.kcSavePaletteAs.Text = "Save Palette As";
            // 
            // kcExitApplication
            // 
            this.kcExitApplication.Text = "Exit Application";
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1437, 782);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonRibbon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane.Panel)).EndInit();
            this.kgbCircularColourPreviewPane.Panel.ResumeLayout(false);
            this.kgbCircularColourPreviewPane.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane)).EndInit();
            this.kgbCircularColourPreviewPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxRibbonTabTextColourPreview)).EndInit();
            this.ctxStatusTextColourUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkFocusedColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStatusTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourThreePreview)).EndInit();
            this.ctxCustomTextColourThreeUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourTwoPreview)).EndInit();
            this.ctxCustomTextColourTwoUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxMenuTextColourPreview)).EndInit();
            this.ctxMenuTextColourUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourFourPreview)).EndInit();
            this.ctxCustomTextColourFourUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourFivePreview)).EndInit();
            this.ctxCustomTextColourFiveUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourOnePreview)).EndInit();
            this.ctxCustomTextColourOneUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourFivePreview)).EndInit();
            this.ctxCustomColourFiveUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourTwoPreview)).EndInit();
            this.ctxCustomColourTwoUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourOnePreview)).EndInit();
            this.ctxCustomColourOneUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkVisitedColourPreview)).EndInit();
            this.ctxLinkVisitedUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourThreePreview)).EndInit();
            this.ctxCustomColourThreeUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourFourPreview)).EndInit();
            this.ctxCustomColourFourUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkHoverColourPreview)).EndInit();
            this.ctxLinkHoverUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxPressedTextColourPreview)).EndInit();
            this.ctxPressedTextUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxFocusedTextColourPreview)).EndInit();
            this.ctxFoucusedTextUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisabledTextColourPreview)).EndInit();
            this.ctxDisabledTextUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisabledControlColourPreview)).EndInit();
            this.ctxDisabledUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkNormalColourPreview)).EndInit();
            this.ctxLinkNormalUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxNormalTextColourPreview)).EndInit();
            this.ctxNormalTextUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxBorderColourPreview)).EndInit();
            this.ctxBorderUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxAlternativeNormalTextColourPreview)).EndInit();
            this.ctxAlternativeNormalTextUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightestColourPreview)).EndInit();
            this.ctxLightestUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightColourPreview)).EndInit();
            this.ctxLightUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxMiddleColourPreview)).EndInit();
            this.ctxMiddleUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColourPreview)).EndInit();
            this.ctxDarkUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxBaseColourPreview)).EndInit();
            this.ctxBaseUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbPaletteProperties.Panel)).EndInit();
            this.kgbPaletteProperties.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbPaletteProperties)).EndInit();
            this.kgbPaletteProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbSquarePreviewPane.Panel)).EndInit();
            this.kgbSquarePreviewPane.Panel.ResumeLayout(false);
            this.kgbSquarePreviewPane.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbSquarePreviewPane)).EndInit();
            this.kgbSquarePreviewPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRibbonTabTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkFocusedColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatusTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourFourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourFivePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourFourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourThreePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourTwoPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourOnePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourFivePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourThreePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourTwoPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourOnePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkVisitedColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkHoverColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlternativeNormalTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkNormalColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledControlColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPressedTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFocusedTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNormalTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBorderColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightestColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDarkColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddleColourPreview)).EndInit();
            this.cmsViewType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void MainWindow_Load(object sender, EventArgs e)
        {
            InitialiseWindow();
        }

        private void kcNewPalette_Execute(object sender, EventArgs e)
        {
            New();
        }

        private void tmrUpdateUI_Tick(object sender, EventArgs e)
        {
            if (krgbShowHidePropertiesPane.Checked)
            {
                if (UseCircularPictureBoxes)
                {
                    UserInterfaceManager.CircularPictureboxHiddenPropertiesLocation(kgbCircularColourPreviewPane, cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledControlColourPreview, cbxLinkNormalColourPreview, cbxLinkFocusedColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview, cbxRibbonTabTextColourPreview);
                }
                else
                {
                    UserInterfaceManager.PictureboxHiddenPropertiesLocation(kgbSquarePreviewPane, pbxBaseColourPreview, pbxDarkColourPreview, pbxMiddleColourPreview, pbxLightColourPreview, pbxLightestColourPreview, pbxBorderColourPreview, pbxAlternativeNormalTextColourPreview, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledControlColourPreview, pbxLinkNormalColourPreview, pbxLinkFocusedColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, pbxCustomColourOnePreview, pbxCustomColourTwoPreview, pbxCustomColourThreePreview, pbxCustomColourFourPreview, pbxCustomColourFivePreview, pbxCustomTextColourOnePreview, pbxCustomTextColourTwoPreview, pbxCustomTextColourThreePreview, pbxCustomTextColourFourPreview, pbxCustomTextColourFivePreview, pbxMenuTextColourPreview, pbxStatusTextColourPreview, pbxRibbonTabTextColourPreview);
                }
            }
            else
            {
                UserInterfaceManager.FactoryCircularPictureboxLocation(kgbCircularColourPreviewPane, cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledControlColourPreview, cbxLinkNormalColourPreview, cbxLinkFocusedColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview);
            }
        }

        private void krgbSavePalette_Click(object sender, EventArgs e)
        {
            if (palette.GetCustomisedKryptonPaletteFilePath() != string.Empty)
            {
                if (File.Exists(palette.GetCustomisedKryptonPaletteFilePath()))
                {
                    Save();
                }
                else
                {
                    SaveAs();
                }
            }
            else
            {
                SaveAs();
            }
        }

        private void krgbOpenPalette_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void kbtnClose_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void kcStandardPictureboxes_Execute(object sender, EventArgs e)
        {
            UseCircularPictureBoxes = false;

            kcCircularPictureboxes.Checked = UseCircularPictureBoxes;

            kcStandardPictureboxes.Checked = true;

            SwitchLayouts(UseCircularPictureBoxes);
        }

        private void kcCircularPictureboxes_Execute(object sender, EventArgs e)
        {
            UseCircularPictureBoxes = true;

            kcCircularPictureboxes.Checked = UseCircularPictureBoxes;

            kcStandardPictureboxes.Checked = false;

            SwitchLayouts(UseCircularPictureBoxes);
        }

        private void krgbOptions_Click(object sender, EventArgs e)
        {
            OptionsWindow optionsWindow = new OptionsWindow();

            optionsWindow.Show();
        }

        private void kcDefineIndividualColours_Execute(object sender, EventArgs e)
        {
            DefineIndividualColoursDialog defineIndividualColoursDialog = new DefineIndividualColoursDialog();

            defineIndividualColoursDialog.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit();
        }

        private void krgbGenerateColours_Click(object sender, EventArgs e)
        {
            PaletteColourCreator paletteColourCreator = new PaletteColourCreator();

            paletteColourCreator.Show();
        }
        #endregion

        #region Operations
        private void New()
        {
            // If the current palette has been changed
            if (Dirty)
            {
                // Ask user if the current palette should be saved
                switch (KryptonMessageBox.Show(this,
                                        "Save changes to the current palette?",
                                        "Palette Changed",
                                        MessageBoxButtons.YesNoCancel,
                                        MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        // Use existing save method
                        Save();
                        break;
                    case DialogResult.Cancel:
                        // Cancel out entirely
                        return;
                }
            }

            // Generate a fresh palette from scratch
            CreateNewPalette();
        }

        private void Open()
        {
            _globalStringSettingsManager.SetFeedbackText("Attempting to import colours from selected palette. Please wait...");

            // If the current palette has been changed
            if (Dirty)
            {
                // Ask user if the current palette should be saved
                switch (KryptonMessageBox.Show(this,
                                        "Save changes to the current palette?",
                                        "Palette Changed",
                                        MessageBoxButtons.YesNoCancel,
                                        MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        // Use existing save method
                        Save();
                        break;
                    case DialogResult.Cancel:
                        // Cancel out entirely
                        return;
                }
            }

            // Create a fresh palette instance for loading into
            KryptonPalette palette = new KryptonPalette();

            // Get the name of the file we imported from
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            string filename = palette.Import();
            Cursor = Cursors.Default;

            // If the load succeeded
            if (filename.Length > 0)
            {
                // Need to unhook from any existing palette
                if (Palette != null)
                    Palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

                // Use the new instance instead
                Palette = palette;

                // We need to know when a change occurs to the palette settings
                Palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

                // Hook up the property grid to the palette
                labelGridNormal.SelectedObject = Palette;

                // Use the loaded filename
                FileName = filename;

                // Reset the state flags
                Loaded = true;
                Dirty = false;

                // Define the initial title bar string
                UpdateTitlebar();
            }

            PaletteImportManager paletteImportManager = new PaletteImportManager();

            paletteImportManager.ImportColourScheme(palette);

            krgbUpdateColours.Enabled = true;

            krgcbBasePaletteMode.Text = _globalStringSettingsManager.GetBasePaletteMode();

            tslCurrentStatus.Text = _globalStringSettingsManager.GetFeedbackText();

            krgbUpdateColours.Checked = true;

            krgbInvert.Enabled = true;

            _globalStringSettingsManager.SetFeedbackText("Import successful");
        }

        private void Save()
        {
            // If we already have a file associated with the palette...
            if (Loaded)
            {
                // ...then just save it straight away
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                Palette.Export(FileName, true, false);
                Cursor = Cursors.Default;

                // No longer dirty
                Dirty = false;

                // Define the initial title bar string
                UpdateTitlebar();
            }
            else
            {
                // No association and so perform a save as instead
                SaveAs();
            }
        }

        private void SaveAs()
        {
            // Get back the filename selected by the user
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            string filename = Palette.Export();
            Cursor = Cursors.Default;

            // If the save succeeded
            if (filename.Length > 0)
            {
                // Remember associated file details
                FileName = filename;
                Loaded = true;

                // No longer dirty
                Dirty = false;

                // Define the initial title bar string
                UpdateTitlebar();
            }

            ExportPaletteColours(UseCircularPictureBoxes);

            _globalStringSettingsManager.SetFeedbackText($"Saving palette file as: { FileName }");
        }

        private void Exit()
        {
            // If the current palette has been changed
            if (Dirty)
            {
                // Ask user if the current palette should be saved
                switch (KryptonMessageBox.Show(this,
                                        "Save changes to the current palette?",
                                        "Palette Changed",
                                        MessageBoxButtons.YesNoCancel,
                                        MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        // Use existing save method
                        Save();
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
            if (Palette != null)
                Palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            // Create a fresh palette instance
            Palette = new KryptonPalette();

            // We need to know when a change occurs to the palette settings
            Palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            // Hook up the property grid to the palette
            labelGridNormal.SelectedObject = Palette;

            // Does not have a filename as yet
            FileName = "(New Palette)";

            // Reset the state flags
            Dirty = false;
            Loaded = false;

            // Define the initial title bar string
            UpdateTitlebar();
        }

        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            // Only interested the first time the palette is changed
            if (!Dirty)
            {
                Dirty = true;
                UpdateTitlebar();
            }

        }
        #endregion

        #region Implementation
        private void UpdateTitlebar()
        {
            // Mark a changed file with a star
            Text = "Palette Editor - " + FileName + (Dirty ? "*" : string.Empty);
        }
        #endregion

        #region Miscellaneous
        /// <summary>
        /// Gets the current saved palette mode.
        /// </summary>
        private void GetCurrentSavedPaletteMode()
        {
            tslCurrentStatus.Text = $"The current palette mode is: { _globalMethods.GetSelectedPaletteMode() }";
        }

        private void ExportPaletteColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                //PaletteComposerEngine.ExportPaletteTheme(palette, _globalMethods.GetSelectedPaletteMode(), cbxBaseColourPreview.BackColor, cbxDarkColourPreview.BackColor, cbxMiddleColourPreview.BackColor, cbxLightColourPreview.BackColor, cbxLightestColourPreview.BackColor, cbxBorderColourPreview.BackColor, cbxAlternativeNormalTextColourPreview.BackColor, cbxNormalTextColourPreview.BackColor, cbxDisabledTextColourPreview.BackColor, cbxFocusedTextColourPreview.BackColor, cbxPressedTextColourPreview.BackColor, cbxDisabledControlColourPreview.BackColor, cbxLinkNormalColourPreview.BackColor, cbxLinkFocusedColourPreview.BackColor, cbxLinkHoverColourPreview.BackColor, cbxLinkVisitedColourPreview.BackColor, cbxCustomColourOnePreview.BackColor, cbxCustomColourTwoPreview.BackColor, cbxCustomColourThreePreview.BackColor, cbxCustomColourFourPreview.BackColor, cbxCustomColourFivePreview.BackColor, cbxCustomTextColourOnePreview.BackColor, cbxCustomTextColourTwoPreview.BackColor, cbxCustomTextColourThreePreview.BackColor, cbxCustomTextColourFourPreview.BackColor, cbxCustomTextColourFivePreview.BackColor, cbxMenuTextColourPreview.BackColor, cbxStatusTextColourPreview.BackColor, cbxRibbonTabTextColourPreview.BackColor, tslCurrentStatus);
            }
            else
            {
                //PaletteComposerEngine.ExportPaletteTheme(_globalMethods.GetSelectedPaletteMode(), pbxBaseColour, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour, pbxBorderColourPreview, pbxAlternativeNormalTextColour, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, pbxCustomColourOnePreview, pbxCustomColourTwoPreview, pbxCustomColourThreePreview, pbxCustomColourFourPreview, pbxCustomColourFivePreview, pbxCustomTextColourOnePreview, pbxCustomTextColourTwoPreview, pbxCustomTextColourThreePreview, pbxCustomTextColourFourPreview, pbxCustomTextColourFivePreview, pbxMenuTextColourPreview, pbxStatusTextColourPreview, tslStatus);
            }
        }

        private void ResetColours(bool useCircularPictureBoxes)
        {
            //if (useCircularPictureBoxes)
            //{
            //    kgbSquarePreviewPane.Visible = false;

            //    kgbCircularColourPreviewPane.Visible = true;

            //    ColourUtilities.ResetColourDefinitions(cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledControlColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview);
            //}
            //else
            //{
            //    kgbSquarePreviewPane.Visible = true;

            //    kgbCircularColourPreviewPane.Visible = false;

            //    ColourUtilities.ResetColourDefinitions(pbxBaseColourPreview, pbxDarkColourPreview, pbxMiddleColourPreview, pbxLightColourPreview, pbxLightestColourPreview, pbxBorderColourPreview, pbxAlternativeNormalTextColourPreview, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledControlColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, pbxCustomColourOnePreview, pbxCustomColourTwoPreview, pbxCustomColourThreePreview, pbxCustomColourFourPreview, pbxCustomColourFivePreview, pbxCustomTextColourOnePreview, pbxCustomTextColourTwoPreview, pbxCustomTextColourThreePreview, pbxCustomTextColourFourPreview, pbxCustomTextColourFivePreview, pbxMenuTextColourPreview, pbxStatusTextColourPreview);
            //}
        }

        private void RevertColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                //ColourUtilities.RevertColours(cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledControlColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview);

                krgbInvert.Checked = false;
            }
        }

        private void InvertColours(bool useCircularPictureBoxes)
        {
            //if (useCircularPictureBoxes)
            //{
            //    ColourUtilities.InvertColours(cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledControlColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview);

            //    krgbInvert.Checked = true;
            //}
            //else
            //{
            //    ColourUtilities.InvertColours(pbxBaseColourPreview, pbxDarkColourPreview, pbxMiddleColourPreview, pbxLightColourPreview, pbxLightestColourPreview, pbxBorderColourPreview, pbxAlternativeNormalTextColourPreview, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledControlColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, pbxCustomColourOnePreview, pbxCustomColourTwoPreview, pbxCustomColourThreePreview, pbxCustomColourFourPreview, pbxCustomColourFivePreview, pbxCustomTextColourOnePreview, pbxCustomTextColourTwoPreview, pbxCustomTextColourThreePreview, pbxCustomTextColourFourPreview, pbxCustomTextColourFivePreview, pbxMenuTextColourPreview, pbxStatusTextColourPreview);

            //    krgbInvert.Checked = true;
            //}
        }

        /// <summary>
        /// Updates the UI.
        /// </summary>
        private void UpdateUI()
        {
            if (krgcbBasePaletteMode.Text != string.Empty)
            {
                krqatbSave.Enabled = true;
            }
            else
            {
                krqatbSave.Enabled = false;
            }

            if (UseCircularPictureBoxes && krgbShowHidePropertiesPane.Checked)
            {
                //CircularPictureboxHiddenPropertiesLocation();
            }
            else if (UseCircularPictureBoxes && !krgbShowHidePropertiesPane.Checked)
            {
                //FactoryCircularPictureboxLocation();
            }

            if (_globalStringSettingsManager.GetFeedbackText() != string.Empty)
            {
                tslCurrentStatus.Text = _globalStringSettingsManager.GetFeedbackText();
            }
        }

        /// <summary>
        /// Updates the colour palette.
        /// </summary>
        /// <param name="useCircularPictureBoxes">if set to <c>true</c> [use circular picture boxes].</param>
        private void UpdateColourPalette(bool useCircularPictureBoxes)
        {
            //if (useCircularPictureBoxes)
            //{
            //    kgbSquarePreviewPane.Visible = false;

            //    kgbCircularColourPreviewPane.Visible = true;

            //    ColourUtilities.GrabColourDefinitions(cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledControlColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview);
            //}
            //else
            //{
            //    kgbSquarePreviewPane.Visible = true;

            //    kgbCircularColourPreviewPane.Visible = false;

            //    ColourUtilities.GrabColourDefinitions(pbxBaseColourPreview, pbxDarkColourPreview, pbxMiddleColourPreview, pbxLightColourPreview, pbxLightestColourPreview, pbxBorderColourPreview, pbxAlternativeNormalTextColourPreview, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledControlColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, pbxCustomColourOnePreview, pbxCustomColourTwoPreview, pbxCustomColourThreePreview, pbxCustomColourFourPreview, pbxCustomColourFivePreview, pbxCustomTextColourOnePreview, pbxCustomTextColourTwoPreview, pbxCustomTextColourThreePreview, pbxCustomTextColourFourPreview, pbxCustomTextColourFivePreview, pbxMenuTextColourPreview, pbxStatusTextColourPreview);
            //}
        }

        /// <summary>
        /// Shows or hides the circular preview boxes.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        private void ShowCircularPreviewBoxes(bool value)
        {
            GlobalBooleanSettingsManager globalBooleanSettingsManager = new GlobalBooleanSettingsManager();

            if (value)
            {
                kgbCircularColourPreviewPane.Visible = true;

                kgbSquarePreviewPane.Visible = false;

                standardPictureboxesToolStripMenuItem.Checked = false;

                circularPictureboxesToolStripMenuItem.Checked = true;
            }
            else
            {
                kgbCircularColourPreviewPane.Visible = false;

                kgbSquarePreviewPane.Visible = true;

                standardPictureboxesToolStripMenuItem.Checked = true;

                circularPictureboxesToolStripMenuItem.Checked = false;
            }

            _globalBooleanSettingsManager.SetUseCircularPictureBoxes(value);

            UseCircularPictureBoxes = _globalBooleanSettingsManager.GetUseCircularPictureBoxes();

            _globalBooleanSettingsManager.SaveBooleanSettings();
        }

        private void GenerateColourScheme(Color baseColour)
        {
            ColourMixer colourMixer = new ColourMixer(true, baseColour);

            colourMixer.Show();
        }

        private void SwitchPalette()
        {
            if (krgcbBasePaletteMode.Text == "Global")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Global);
            }
            else if (krgcbBasePaletteMode.Text == "ProfessionalSystem")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.ProfessionalSystem);
            }
            else if (krgcbBasePaletteMode.Text == "ProfessionalOffice2003")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.ProfessionalOffice2003);
            }
            else if (krgcbBasePaletteMode.Text == "Office2007Black")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2007Black);
            }
            else if (krgcbBasePaletteMode.Text == "Office2007Blue")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2007Blue);
            }
            else if (krgcbBasePaletteMode.Text == "Office2007Silver")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2007Silver);
            }
            else if (krgcbBasePaletteMode.Text == "Office2010Black")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2010Black);
            }
            else if (krgcbBasePaletteMode.Text == "Office2010Blue")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2010Blue);
            }
            else if (krgcbBasePaletteMode.Text == "Office2010Silver")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2010Silver);
            }
            else if (krgcbBasePaletteMode.Text == "Office2013")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2013);
            }
            else if (krgcbBasePaletteMode.Text == "Office2013White")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2013White);
            }
            else if (krgcbBasePaletteMode.Text == "SparkleBlue")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.SparkleBlue);
            }
            else if (krgcbBasePaletteMode.Text == "SparkleOrange")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.SparkleOrange);
            }
            else if (krgcbBasePaletteMode.Text == "SparklePurple")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.SparklePurple);
            }
            else if (krgcbBasePaletteMode.Text == "Custom")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Custom);
            }

            GetCurrentSavedPaletteMode();
        }

        private void krgbGetColours_Click(object sender, EventArgs e)
        {
            if (!BasicColourSettingsManager.AreBasicPaletteColoursEmpty())
            {
                cbxBaseColourPreview.BackColor = _basicPaletteColourManager.GetBaseColour();

                cbxDarkColourPreview.BackColor = _basicPaletteColourManager.GetDarkColour();

                cbxMiddleColourPreview.BackColor = _basicPaletteColourManager.GetMediumColour();

                cbxLightColourPreview.BackColor = _basicPaletteColourManager.GetLightColour();

                cbxLightestColourPreview.BackColor = _basicPaletteColourManager.GetLightestColour();
            }
        }

        private void krgbFileEdit_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(FileName))
            //{
            //    PaletteFileEditor pfeLoaded = new PaletteFileEditor(FileName);

            //    pfeLoaded.ShowDialog();
            //}
            //else if (Text.Contains("(New Palette)"))
            //{
            //    PaletteFileEditor pfe = new PaletteFileEditor();

            //    pfe.ShowDialog();
            //}
            //else
            //{
            PaletteFileEditor pfe = new PaletteFileEditor();

            pfe.ShowDialog();
            //}
        }

        private void krgbShowHidePropertiesPane_Click(object sender, EventArgs e)
        {
            if (krgbShowHidePropertiesPane.Checked)
            {
                if (UseCircularPictureBoxes)
                {
                    UserInterfaceManager.CircularPictureBoxPropertiesPaneVisibleLocation(kgbCircularColourPreviewPane, cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledControlColourPreview, cbxLinkNormalColourPreview, cbxLinkFocusedColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview, cbxRibbonTabTextColourPreview);
                }
                else
                {

                }
            }
            else
            {
                if (UseCircularPictureBoxes)
                {

                }
                else
                {

                }
            }
        }

        private void SwitchLayouts(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                kgbCircularColourPreviewPane.Visible = true;

                kgbSquarePreviewPane.Visible = false;
            }
            else
            {
                kgbCircularColourPreviewPane.Visible = false;

                kgbSquarePreviewPane.Visible = true;
            }
        }

        private void GrabPaletteColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                UpdateColourPalette(useCircularPictureBoxes);

                ShowCircularPreviewBoxes(true);
            }
        }

        private void InitialiseWindow(bool devMode = true)
        {
            New();

            ColourUtilities.PropagateBasePaletteModes(krgcbBasePaletteMode);

            _colourSettingsManager.ResetToDefaults(); // (DebugMode);

            if (UseCircularPictureBoxes)
            {
                ShowCircularPreviewBoxes(_globalBooleanSettingsManager.GetUseCircularPictureBoxes());
            }

            if (devMode)
            {
                DevelopmentInformation.SetBuildInformation(this, DevelopmentState.ALPHA);
            }

            if (Application.ExecutablePath.Contains("Palette Designer.exe"))
            {
                krgbLaunchPaletteDesigner.Enabled = true;
            }
            else
            {
                krgbLaunchPaletteDesigner.Enabled = false;
            }
        }
        #endregion
    }
}