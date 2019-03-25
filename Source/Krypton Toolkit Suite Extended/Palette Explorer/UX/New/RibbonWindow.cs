using ComponentFactory.Krypton.Toolkit;
using System;

namespace PaletteExplorer.UX.New
{
    public class RibbonWindow : KryptonForm
    {
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
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
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
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator kdnPaletteExplorer;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kdm;
        private KryptonGroupBox kgbPreviewPane;
        private System.Windows.Forms.PictureBox pbxLinkFocusedColourPreview;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pbxRibbonTabTextColourPreview;
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
        private System.Windows.Forms.PictureBox pbxAlternativeNormalTextColour;
        private System.Windows.Forms.PictureBox pbxLinkNormalColourPreview;
        private System.Windows.Forms.PictureBox pbxDisabledColourPreview;
        private System.Windows.Forms.PictureBox pbxPressedTextColourPreview;
        private System.Windows.Forms.PictureBox pbxFocusedTextColourPreview;
        private System.Windows.Forms.PictureBox pbxDisabledTextColourPreview;
        private System.Windows.Forms.PictureBox pbxNormalTextColourPreview;
        private System.Windows.Forms.PictureBox pbxBorderColourPreview;
        private System.Windows.Forms.PictureBox pbxBaseColour;
        private System.Windows.Forms.PictureBox pbxLightestColour;
        private System.Windows.Forms.PictureBox pbxDarkColour;
        private System.Windows.Forms.PictureBox pbxLightColour;
        private System.Windows.Forms.PictureBox pbxMiddleColour;
        private KryptonGroupBox kgbCircularColourPreviewPane;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxRibbonTabTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLinkFocusedColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxStatusTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomTextColourThreePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomTextColourTwoPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxMenuTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomTextColourFourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomTextColourFivePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomTextColourOnePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomColourFivePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomColourTwoPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomColourOnePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLinkVisitedColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomColourThreePreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomColourFourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLinkHoverColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxPressedTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxFocusedTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxDisabledTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxDisabledControlColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLinkNormalColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxNormalTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxBorderColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxAlternativeNormalTextColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLightestColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLightColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxMiddleColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxDarkColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxBaseColourPreview;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbExpertMode;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbCheckForUpdates;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonWindow));
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues2 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues6 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues4 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues5 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
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
            this.kryptonRibbonGroupTriple6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGenerateColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
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
            this.kryptonRibbonGroupSeparator11 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple17 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbExperimental = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator12 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple19 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbShowHidePropertiesPane = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup9 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonTab3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple20 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator14 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple18 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbOptions = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
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
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblColourOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kdnPaletteExplorer = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kgbPreviewPane = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pbxLinkFocusedColourPreview = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbxRibbonTabTextColourPreview = new System.Windows.Forms.PictureBox();
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
            this.pbxAlternativeNormalTextColour = new System.Windows.Forms.PictureBox();
            this.pbxLinkNormalColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxDisabledColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxPressedTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxFocusedTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxDisabledTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxNormalTextColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxBorderColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxBaseColour = new System.Windows.Forms.PictureBox();
            this.pbxLightestColour = new System.Windows.Forms.PictureBox();
            this.pbxDarkColour = new System.Windows.Forms.PictureBox();
            this.pbxLightColour = new System.Windows.Forms.PictureBox();
            this.pbxMiddleColour = new System.Windows.Forms.PictureBox();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kgbCircularColourPreviewPane = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cbxRibbonTabTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxLinkFocusedColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxStatusTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomTextColourThreePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomTextColourTwoPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxMenuTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomTextColourFourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomTextColourFivePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomTextColourOnePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomColourFivePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomColourTwoPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomColourOnePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxLinkVisitedColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomColourThreePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomColourFourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxLinkHoverColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxPressedTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxFocusedTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxDisabledTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxDisabledControlColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxLinkNormalColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxNormalTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxBorderColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxAlternativeNormalTextColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxLightestColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxLightColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxMiddleColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxDarkColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxBaseColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kdm = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.krgbExpertMode = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            ((System.ComponentModel.ISupportInitialize)(this.krControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlStatusStrip)).BeginInit();
            this.kpnlStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdnPaletteExplorer)).BeginInit();
            this.kdnPaletteExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane.Panel)).BeginInit();
            this.kgbPreviewPane.Panel.SuspendLayout();
            this.kgbPreviewPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkFocusedColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRibbonTabTextColourPreview)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlternativeNormalTextColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkNormalColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPressedTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFocusedTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNormalTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBorderColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightestColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDarkColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddleColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane.Panel)).BeginInit();
            this.kgbCircularColourPreviewPane.Panel.SuspendLayout();
            this.kgbCircularColourPreviewPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRibbonTabTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkFocusedColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStatusTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourThreePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourTwoPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMenuTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourFourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourFivePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourOnePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourFivePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourTwoPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourOnePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkVisitedColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourThreePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourFourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkHoverColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPressedTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFocusedTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisabledTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisabledControlColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkNormalColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNormalTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBorderColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAlternativeNormalTextColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightestColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMiddleColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBaseColourPreview)).BeginInit();
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
            this.krControls.SelectedTab = this.kryptonRibbonTab3;
            this.krControls.Size = new System.Drawing.Size(1649, 115);
            this.krControls.TabIndex = 2;
            popupPositionValues1.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues1.PlacementTarget = null;
            this.krControls.ToolTipValues.ToolTipPosition = popupPositionValues1;
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
            // 
            // krgbExportPalette
            // 
            this.krgbExportPalette.TextLine1 = "Export";
            // 
            // kryptonRibbonGroup10
            // 
            this.kryptonRibbonGroup10.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple23,
            this.kryptonRibbonGroupSeparator15,
            this.kryptonRibbonGroupTriple24});
            this.kryptonRibbonGroup10.TextLine1 = "General";
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
            this.krgbGenerateColours.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbGenerateColours.ImageLarge")));
            this.krgbGenerateColours.ImageSmall = ((System.Drawing.Image)(resources.GetObject("krgbGenerateColours.ImageSmall")));
            this.krgbGenerateColours.TextLine1 = "Generate";
            this.krgbGenerateColours.TextLine2 = "Colours";
            // 
            // kryptonRibbonGroupTriple7
            // 
            this.kryptonRibbonGroupTriple7.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbGetColours});
            // 
            // krgbGetColours
            // 
            this.krgbGetColours.TextLine1 = "Get";
            this.krgbGetColours.TextLine2 = "Colours";
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
            this.krgbResetColours.TextLine1 = "Reset";
            this.krgbResetColours.TextLine2 = "Colours";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple14,
            this.kryptonRibbonGroupSeparator10,
            this.kryptonRibbonGroupTriple15});
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
            // 
            // kryptonRibbonGroupTriple16
            // 
            this.kryptonRibbonGroupTriple16.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbViewType});
            // 
            // krgbViewType
            // 
            this.krgbViewType.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Split;
            this.krgbViewType.TextLine1 = "View";
            this.krgbViewType.TextLine2 = "Type";
            this.krgbViewType.Visible = false;
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
            this.krgbShowHidePropertiesPane});
            // 
            // krgbShowHidePropertiesPane
            // 
            this.krgbShowHidePropertiesPane.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.krgbShowHidePropertiesPane.TextLine1 = "Show/Hide";
            this.krgbShowHidePropertiesPane.TextLine2 = "Propertes Pane";
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
            this.kryptonRibbonGroupButton3});
            // 
            // kryptonRibbonGroupTriple18
            // 
            this.kryptonRibbonGroupTriple18.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbOptions,
            this.krgbExpertMode});
            // 
            // krgbOptions
            // 
            this.krgbOptions.TextLine1 = "Options /";
            this.krgbOptions.TextLine2 = "Settings";
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
            this.krgbAbout.TextLine1 = "About";
            // 
            // kryptonRibbonGroupTriple22
            // 
            this.kryptonRibbonGroupTriple22.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbCheckForUpdates});
            // 
            // krgbCheckForUpdates
            // 
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
            this.kpnlStatusStrip.Size = new System.Drawing.Size(1649, 22);
            this.kpnlStatusStrip.TabIndex = 3;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Location = new System.Drawing.Point(0, 0);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(1649, 22);
            this.ss.TabIndex = 46;
            this.ss.Text = "statusStrip1";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnClose);
            this.kryptonPanel2.Controls.Add(this.lblColourOutput);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 832);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1649, 54);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kbtnClose
            // 
            this.kbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnClose.Location = new System.Drawing.Point(1586, 12);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(51, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 64;
            popupPositionValues2.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues2.PlacementTarget = null;
            this.kbtnClose.ToolTipValues.ToolTipPosition = popupPositionValues2;
            this.kbtnClose.Values.Text = "&Close";
            // 
            // lblColourOutput
            // 
            this.lblColourOutput.Location = new System.Drawing.Point(12, 13);
            this.lblColourOutput.Name = "lblColourOutput";
            this.lblColourOutput.Size = new System.Drawing.Size(6, 2);
            this.lblColourOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourOutput.TabIndex = 63;
            popupPositionValues3.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues3.PlacementTarget = null;
            this.lblColourOutput.ToolTipValues.ToolTipPosition = popupPositionValues3;
            this.lblColourOutput.Values.Text = "";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kdnPaletteExplorer);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1649, 717);
            this.kryptonPanel3.TabIndex = 5;
            // 
            // kdnPaletteExplorer
            // 
            this.kdnPaletteExplorer.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.NextPrevious;
            this.kdnPaletteExplorer.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kdnPaletteExplorer.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kdnPaletteExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdnPaletteExplorer.Location = new System.Drawing.Point(0, 0);
            this.kdnPaletteExplorer.Name = "kdnPaletteExplorer";
            this.kdnPaletteExplorer.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kdnPaletteExplorer.SelectedIndex = 1;
            this.kdnPaletteExplorer.Size = new System.Drawing.Size(1649, 717);
            this.kdnPaletteExplorer.TabIndex = 6;
            this.kdnPaletteExplorer.Text = "kryptonDockableNavigator1";
            popupPositionValues6.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues6.PlacementTarget = null;
            this.kdnPaletteExplorer.ToolTipValues.ToolTipPosition = popupPositionValues6;
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.kgbPreviewPane);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(1647, 690);
            this.kryptonPage1.Text = "Standard View";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "bd8fdfd429164bb7a1b81a29ae3a5ff8";
            // 
            // kgbPreviewPane
            // 
            this.kgbPreviewPane.Location = new System.Drawing.Point(11, 15);
            this.kgbPreviewPane.Name = "kgbPreviewPane";
            // 
            // kgbPreviewPane.Panel
            // 
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLinkFocusedColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pictureBox5);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxRibbonTabTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxStatusTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxMenuTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomColourFourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomTextColourFivePreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomTextColourFourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomTextColourThreePreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomTextColourTwoPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomTextColourOnePreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomColourFivePreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomColourThreePreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomColourTwoPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomColourOnePreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLinkVisitedColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLinkHoverColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxAlternativeNormalTextColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLinkNormalColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxDisabledColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxPressedTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxFocusedTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxDisabledTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxNormalTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxBorderColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxBaseColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLightestColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxDarkColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLightColour);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxMiddleColour);
            this.kgbPreviewPane.Size = new System.Drawing.Size(1625, 661);
            this.kgbPreviewPane.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbPreviewPane.TabIndex = 12;
            popupPositionValues4.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues4.PlacementTarget = null;
            this.kgbPreviewPane.ToolTipValues.ToolTipPosition = popupPositionValues4;
            this.kgbPreviewPane.Values.Heading = "Colour Preview";
            // 
            // pbxLinkFocusedColourPreview
            // 
            this.pbxLinkFocusedColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkFocusedColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkFocusedColourPreview.Location = new System.Drawing.Point(1104, 193);
            this.pbxLinkFocusedColourPreview.Name = "pbxLinkFocusedColourPreview";
            this.pbxLinkFocusedColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLinkFocusedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkFocusedColourPreview.TabIndex = 87;
            this.pbxLinkFocusedColourPreview.TabStop = false;
            this.pbxLinkFocusedColourPreview.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(1104, 549);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 86;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pbxRibbonTabTextColourPreview
            // 
            this.pbxRibbonTabTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxRibbonTabTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxRibbonTabTextColourPreview.Location = new System.Drawing.Point(887, 549);
            this.pbxRibbonTabTextColourPreview.Name = "pbxRibbonTabTextColourPreview";
            this.pbxRibbonTabTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxRibbonTabTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxRibbonTabTextColourPreview.TabIndex = 85;
            this.pbxRibbonTabTextColourPreview.TabStop = false;
            // 
            // pbxStatusTextColourPreview
            // 
            this.pbxStatusTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxStatusTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxStatusTextColourPreview.Location = new System.Drawing.Point(670, 549);
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
            this.pbxMenuTextColourPreview.Location = new System.Drawing.Point(453, 549);
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
            this.pbxCustomColourFourPreview.Location = new System.Drawing.Point(670, 371);
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
            this.pbxCustomTextColourFivePreview.Location = new System.Drawing.Point(236, 549);
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
            this.pbxCustomTextColourFourPreview.Location = new System.Drawing.Point(19, 549);
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
            this.pbxCustomTextColourThreePreview.Location = new System.Drawing.Point(1538, 371);
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
            this.pbxCustomTextColourTwoPreview.Location = new System.Drawing.Point(1321, 371);
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
            this.pbxCustomTextColourOnePreview.Location = new System.Drawing.Point(1104, 371);
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
            this.pbxCustomColourFivePreview.Location = new System.Drawing.Point(887, 371);
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
            this.pbxCustomColourThreePreview.Location = new System.Drawing.Point(453, 371);
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
            this.pbxCustomColourTwoPreview.Location = new System.Drawing.Point(236, 371);
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
            this.pbxCustomColourOnePreview.Location = new System.Drawing.Point(19, 371);
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
            this.pbxLinkVisitedColourPreview.Location = new System.Drawing.Point(1538, 193);
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
            this.pbxLinkHoverColourPreview.Location = new System.Drawing.Point(1321, 193);
            this.pbxLinkHoverColourPreview.Name = "pbxLinkHoverColourPreview";
            this.pbxLinkHoverColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLinkHoverColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkHoverColourPreview.TabIndex = 71;
            this.pbxLinkHoverColourPreview.TabStop = false;
            // 
            // pbxAlternativeNormalTextColour
            // 
            this.pbxAlternativeNormalTextColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxAlternativeNormalTextColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxAlternativeNormalTextColour.Location = new System.Drawing.Point(1321, 16);
            this.pbxAlternativeNormalTextColour.Name = "pbxAlternativeNormalTextColour";
            this.pbxAlternativeNormalTextColour.Size = new System.Drawing.Size(64, 64);
            this.pbxAlternativeNormalTextColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAlternativeNormalTextColour.TabIndex = 70;
            this.pbxAlternativeNormalTextColour.TabStop = false;
            // 
            // pbxLinkNormalColourPreview
            // 
            this.pbxLinkNormalColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkNormalColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkNormalColourPreview.Location = new System.Drawing.Point(887, 193);
            this.pbxLinkNormalColourPreview.Name = "pbxLinkNormalColourPreview";
            this.pbxLinkNormalColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLinkNormalColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkNormalColourPreview.TabIndex = 69;
            this.pbxLinkNormalColourPreview.TabStop = false;
            // 
            // pbxDisabledColourPreview
            // 
            this.pbxDisabledColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxDisabledColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxDisabledColourPreview.Location = new System.Drawing.Point(670, 193);
            this.pbxDisabledColourPreview.Name = "pbxDisabledColourPreview";
            this.pbxDisabledColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxDisabledColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxDisabledColourPreview.TabIndex = 68;
            this.pbxDisabledColourPreview.TabStop = false;
            // 
            // pbxPressedTextColourPreview
            // 
            this.pbxPressedTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxPressedTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPressedTextColourPreview.Location = new System.Drawing.Point(453, 193);
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
            this.pbxFocusedTextColourPreview.Location = new System.Drawing.Point(236, 193);
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
            this.pbxDisabledTextColourPreview.Location = new System.Drawing.Point(19, 193);
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
            this.pbxNormalTextColourPreview.Location = new System.Drawing.Point(1538, 16);
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
            this.pbxBorderColourPreview.Location = new System.Drawing.Point(1104, 16);
            this.pbxBorderColourPreview.Name = "pbxBorderColourPreview";
            this.pbxBorderColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxBorderColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBorderColourPreview.TabIndex = 63;
            this.pbxBorderColourPreview.TabStop = false;
            // 
            // pbxBaseColour
            // 
            this.pbxBaseColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxBaseColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxBaseColour.Location = new System.Drawing.Point(19, 15);
            this.pbxBaseColour.Name = "pbxBaseColour";
            this.pbxBaseColour.Size = new System.Drawing.Size(64, 64);
            this.pbxBaseColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBaseColour.TabIndex = 4;
            this.pbxBaseColour.TabStop = false;
            // 
            // pbxLightestColour
            // 
            this.pbxLightestColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxLightestColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLightestColour.Location = new System.Drawing.Point(887, 16);
            this.pbxLightestColour.Name = "pbxLightestColour";
            this.pbxLightestColour.Size = new System.Drawing.Size(64, 64);
            this.pbxLightestColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLightestColour.TabIndex = 8;
            this.pbxLightestColour.TabStop = false;
            // 
            // pbxDarkColour
            // 
            this.pbxDarkColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxDarkColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxDarkColour.Location = new System.Drawing.Point(236, 16);
            this.pbxDarkColour.Name = "pbxDarkColour";
            this.pbxDarkColour.Size = new System.Drawing.Size(64, 64);
            this.pbxDarkColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxDarkColour.TabIndex = 5;
            this.pbxDarkColour.TabStop = false;
            // 
            // pbxLightColour
            // 
            this.pbxLightColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxLightColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLightColour.Location = new System.Drawing.Point(670, 16);
            this.pbxLightColour.Name = "pbxLightColour";
            this.pbxLightColour.Size = new System.Drawing.Size(64, 64);
            this.pbxLightColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLightColour.TabIndex = 7;
            this.pbxLightColour.TabStop = false;
            // 
            // pbxMiddleColour
            // 
            this.pbxMiddleColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxMiddleColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMiddleColour.Location = new System.Drawing.Point(453, 16);
            this.pbxMiddleColour.Name = "pbxMiddleColour";
            this.pbxMiddleColour.Size = new System.Drawing.Size(64, 64);
            this.pbxMiddleColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxMiddleColour.TabIndex = 6;
            this.pbxMiddleColour.TabStop = false;
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.kgbCircularColourPreviewPane);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(1647, 690);
            this.kryptonPage2.Text = "Circular View";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "e28d96407cc9443db3730ebba94f9380";
            // 
            // kgbCircularColourPreviewPane
            // 
            this.kgbCircularColourPreviewPane.Location = new System.Drawing.Point(11, 15);
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
            this.kgbCircularColourPreviewPane.Size = new System.Drawing.Size(1625, 661);
            this.kgbCircularColourPreviewPane.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbCircularColourPreviewPane.TabIndex = 38;
            popupPositionValues5.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues5.PlacementTarget = null;
            this.kgbCircularColourPreviewPane.ToolTipValues.ToolTipPosition = popupPositionValues5;
            this.kgbCircularColourPreviewPane.Values.Heading = "Colour Preview";
            // 
            // cbxRibbonTabTextColourPreview
            // 
            this.cbxRibbonTabTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxRibbonTabTextColourPreview.Location = new System.Drawing.Point(19, 546);
            this.cbxRibbonTabTextColourPreview.Name = "cbxRibbonTabTextColourPreview";
            this.cbxRibbonTabTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxRibbonTabTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxRibbonTabTextColourPreview.TabIndex = 54;
            this.cbxRibbonTabTextColourPreview.TabStop = false;
            // 
            // cbxLinkFocusedColourPreview
            // 
            this.cbxLinkFocusedColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkFocusedColourPreview.Location = new System.Drawing.Point(1537, 147);
            this.cbxLinkFocusedColourPreview.Name = "cbxLinkFocusedColourPreview";
            this.cbxLinkFocusedColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkFocusedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkFocusedColourPreview.TabIndex = 53;
            this.cbxLinkFocusedColourPreview.TabStop = false;
            // 
            // cbxStatusTextColourPreview
            // 
            this.cbxStatusTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxStatusTextColourPreview.Location = new System.Drawing.Point(1537, 413);
            this.cbxStatusTextColourPreview.Name = "cbxStatusTextColourPreview";
            this.cbxStatusTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxStatusTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxStatusTextColourPreview.TabIndex = 52;
            this.cbxStatusTextColourPreview.TabStop = false;
            // 
            // cbxCustomTextColourThreePreview
            // 
            this.cbxCustomTextColourThreePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourThreePreview.Location = new System.Drawing.Point(525, 413);
            this.cbxCustomTextColourThreePreview.Name = "cbxCustomTextColourThreePreview";
            this.cbxCustomTextColourThreePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourThreePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourThreePreview.TabIndex = 51;
            this.cbxCustomTextColourThreePreview.TabStop = false;
            // 
            // cbxCustomTextColourTwoPreview
            // 
            this.cbxCustomTextColourTwoPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourTwoPreview.Location = new System.Drawing.Point(272, 413);
            this.cbxCustomTextColourTwoPreview.Name = "cbxCustomTextColourTwoPreview";
            this.cbxCustomTextColourTwoPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourTwoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourTwoPreview.TabIndex = 50;
            this.cbxCustomTextColourTwoPreview.TabStop = false;
            // 
            // cbxMenuTextColourPreview
            // 
            this.cbxMenuTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxMenuTextColourPreview.Location = new System.Drawing.Point(1284, 413);
            this.cbxMenuTextColourPreview.Name = "cbxMenuTextColourPreview";
            this.cbxMenuTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxMenuTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxMenuTextColourPreview.TabIndex = 49;
            this.cbxMenuTextColourPreview.TabStop = false;
            // 
            // cbxCustomTextColourFourPreview
            // 
            this.cbxCustomTextColourFourPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourFourPreview.Location = new System.Drawing.Point(778, 413);
            this.cbxCustomTextColourFourPreview.Name = "cbxCustomTextColourFourPreview";
            this.cbxCustomTextColourFourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourFourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourFourPreview.TabIndex = 48;
            this.cbxCustomTextColourFourPreview.TabStop = false;
            // 
            // cbxCustomTextColourFivePreview
            // 
            this.cbxCustomTextColourFivePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourFivePreview.Location = new System.Drawing.Point(1031, 413);
            this.cbxCustomTextColourFivePreview.Name = "cbxCustomTextColourFivePreview";
            this.cbxCustomTextColourFivePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourFivePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourFivePreview.TabIndex = 47;
            this.cbxCustomTextColourFivePreview.TabStop = false;
            // 
            // cbxCustomTextColourOnePreview
            // 
            this.cbxCustomTextColourOnePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourOnePreview.Location = new System.Drawing.Point(19, 413);
            this.cbxCustomTextColourOnePreview.Name = "cbxCustomTextColourOnePreview";
            this.cbxCustomTextColourOnePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourOnePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourOnePreview.TabIndex = 46;
            this.cbxCustomTextColourOnePreview.TabStop = false;
            // 
            // cbxCustomColourFivePreview
            // 
            this.cbxCustomColourFivePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourFivePreview.Location = new System.Drawing.Point(1538, 280);
            this.cbxCustomColourFivePreview.Name = "cbxCustomColourFivePreview";
            this.cbxCustomColourFivePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourFivePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourFivePreview.TabIndex = 45;
            this.cbxCustomColourFivePreview.TabStop = false;
            // 
            // cbxCustomColourTwoPreview
            // 
            this.cbxCustomColourTwoPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourTwoPreview.Location = new System.Drawing.Point(778, 280);
            this.cbxCustomColourTwoPreview.Name = "cbxCustomColourTwoPreview";
            this.cbxCustomColourTwoPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourTwoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourTwoPreview.TabIndex = 44;
            this.cbxCustomColourTwoPreview.TabStop = false;
            // 
            // cbxCustomColourOnePreview
            // 
            this.cbxCustomColourOnePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourOnePreview.Location = new System.Drawing.Point(525, 280);
            this.cbxCustomColourOnePreview.Name = "cbxCustomColourOnePreview";
            this.cbxCustomColourOnePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourOnePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourOnePreview.TabIndex = 43;
            this.cbxCustomColourOnePreview.TabStop = false;
            // 
            // cbxLinkVisitedColourPreview
            // 
            this.cbxLinkVisitedColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkVisitedColourPreview.Location = new System.Drawing.Point(272, 280);
            this.cbxLinkVisitedColourPreview.Name = "cbxLinkVisitedColourPreview";
            this.cbxLinkVisitedColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkVisitedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkVisitedColourPreview.TabIndex = 42;
            this.cbxLinkVisitedColourPreview.TabStop = false;
            // 
            // cbxCustomColourThreePreview
            // 
            this.cbxCustomColourThreePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourThreePreview.Location = new System.Drawing.Point(1031, 280);
            this.cbxCustomColourThreePreview.Name = "cbxCustomColourThreePreview";
            this.cbxCustomColourThreePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourThreePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourThreePreview.TabIndex = 41;
            this.cbxCustomColourThreePreview.TabStop = false;
            // 
            // cbxCustomColourFourPreview
            // 
            this.cbxCustomColourFourPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourFourPreview.Location = new System.Drawing.Point(1284, 280);
            this.cbxCustomColourFourPreview.Name = "cbxCustomColourFourPreview";
            this.cbxCustomColourFourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourFourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourFourPreview.TabIndex = 40;
            this.cbxCustomColourFourPreview.TabStop = false;
            // 
            // cbxLinkHoverColourPreview
            // 
            this.cbxLinkHoverColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkHoverColourPreview.Location = new System.Drawing.Point(19, 280);
            this.cbxLinkHoverColourPreview.Name = "cbxLinkHoverColourPreview";
            this.cbxLinkHoverColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkHoverColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkHoverColourPreview.TabIndex = 39;
            this.cbxLinkHoverColourPreview.TabStop = false;
            // 
            // cbxPressedTextColourPreview
            // 
            this.cbxPressedTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxPressedTextColourPreview.Location = new System.Drawing.Point(778, 147);
            this.cbxPressedTextColourPreview.Name = "cbxPressedTextColourPreview";
            this.cbxPressedTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxPressedTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxPressedTextColourPreview.TabIndex = 38;
            this.cbxPressedTextColourPreview.TabStop = false;
            // 
            // cbxFocusedTextColourPreview
            // 
            this.cbxFocusedTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxFocusedTextColourPreview.Location = new System.Drawing.Point(525, 147);
            this.cbxFocusedTextColourPreview.Name = "cbxFocusedTextColourPreview";
            this.cbxFocusedTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxFocusedTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxFocusedTextColourPreview.TabIndex = 37;
            this.cbxFocusedTextColourPreview.TabStop = false;
            // 
            // cbxDisabledTextColourPreview
            // 
            this.cbxDisabledTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxDisabledTextColourPreview.Location = new System.Drawing.Point(272, 147);
            this.cbxDisabledTextColourPreview.Name = "cbxDisabledTextColourPreview";
            this.cbxDisabledTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxDisabledTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxDisabledTextColourPreview.TabIndex = 36;
            this.cbxDisabledTextColourPreview.TabStop = false;
            // 
            // cbxDisabledControlColourPreview
            // 
            this.cbxDisabledControlColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxDisabledControlColourPreview.Location = new System.Drawing.Point(1031, 147);
            this.cbxDisabledControlColourPreview.Name = "cbxDisabledControlColourPreview";
            this.cbxDisabledControlColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxDisabledControlColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxDisabledControlColourPreview.TabIndex = 35;
            this.cbxDisabledControlColourPreview.TabStop = false;
            // 
            // cbxLinkNormalColourPreview
            // 
            this.cbxLinkNormalColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkNormalColourPreview.Location = new System.Drawing.Point(1284, 147);
            this.cbxLinkNormalColourPreview.Name = "cbxLinkNormalColourPreview";
            this.cbxLinkNormalColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkNormalColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkNormalColourPreview.TabIndex = 34;
            this.cbxLinkNormalColourPreview.TabStop = false;
            // 
            // cbxNormalTextColourPreview
            // 
            this.cbxNormalTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxNormalTextColourPreview.Location = new System.Drawing.Point(19, 147);
            this.cbxNormalTextColourPreview.Name = "cbxNormalTextColourPreview";
            this.cbxNormalTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxNormalTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxNormalTextColourPreview.TabIndex = 33;
            this.cbxNormalTextColourPreview.TabStop = false;
            // 
            // cbxBorderColourPreview
            // 
            this.cbxBorderColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxBorderColourPreview.Location = new System.Drawing.Point(1284, 18);
            this.cbxBorderColourPreview.Name = "cbxBorderColourPreview";
            this.cbxBorderColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxBorderColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxBorderColourPreview.TabIndex = 32;
            this.cbxBorderColourPreview.TabStop = false;
            // 
            // cbxAlternativeNormalTextColourPreview
            // 
            this.cbxAlternativeNormalTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxAlternativeNormalTextColourPreview.Location = new System.Drawing.Point(1537, 18);
            this.cbxAlternativeNormalTextColourPreview.Name = "cbxAlternativeNormalTextColourPreview";
            this.cbxAlternativeNormalTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxAlternativeNormalTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxAlternativeNormalTextColourPreview.TabIndex = 31;
            this.cbxAlternativeNormalTextColourPreview.TabStop = false;
            // 
            // cbxLightestColourPreview
            // 
            this.cbxLightestColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLightestColourPreview.Location = new System.Drawing.Point(1031, 15);
            this.cbxLightestColourPreview.Name = "cbxLightestColourPreview";
            this.cbxLightestColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLightestColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLightestColourPreview.TabIndex = 30;
            this.cbxLightestColourPreview.TabStop = false;
            // 
            // cbxLightColourPreview
            // 
            this.cbxLightColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLightColourPreview.Location = new System.Drawing.Point(778, 15);
            this.cbxLightColourPreview.Name = "cbxLightColourPreview";
            this.cbxLightColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLightColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLightColourPreview.TabIndex = 29;
            this.cbxLightColourPreview.TabStop = false;
            // 
            // cbxMiddleColourPreview
            // 
            this.cbxMiddleColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxMiddleColourPreview.Location = new System.Drawing.Point(525, 15);
            this.cbxMiddleColourPreview.Name = "cbxMiddleColourPreview";
            this.cbxMiddleColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxMiddleColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxMiddleColourPreview.TabIndex = 28;
            this.cbxMiddleColourPreview.TabStop = false;
            // 
            // cbxDarkColourPreview
            // 
            this.cbxDarkColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxDarkColourPreview.Location = new System.Drawing.Point(272, 15);
            this.cbxDarkColourPreview.Name = "cbxDarkColourPreview";
            this.cbxDarkColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxDarkColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxDarkColourPreview.TabIndex = 27;
            this.cbxDarkColourPreview.TabStop = false;
            // 
            // cbxBaseColourPreview
            // 
            this.cbxBaseColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxBaseColourPreview.Location = new System.Drawing.Point(19, 14);
            this.cbxBaseColourPreview.Name = "cbxBaseColourPreview";
            this.cbxBaseColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxBaseColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxBaseColourPreview.TabIndex = 26;
            this.cbxBaseColourPreview.TabStop = false;
            // 
            // krgbExpertMode
            // 
            this.krgbExpertMode.TextLine1 = "Expert";
            this.krgbExpertMode.TextLine2 = "Mode";
            this.krgbExpertMode.Click += new System.EventHandler(this.krgbExpertMode_Click);
            // 
            // RibbonWindow
            // 
            this.ClientSize = new System.Drawing.Size(1649, 908);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kpnlStatusStrip);
            this.Controls.Add(this.krControls);
            this.Name = "RibbonWindow";
            this.Load += new System.EventHandler(this.RibbonWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.krControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlStatusStrip)).EndInit();
            this.kpnlStatusStrip.ResumeLayout(false);
            this.kpnlStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kdnPaletteExplorer)).EndInit();
            this.kdnPaletteExplorer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane.Panel)).EndInit();
            this.kgbPreviewPane.Panel.ResumeLayout(false);
            this.kgbPreviewPane.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane)).EndInit();
            this.kgbPreviewPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkFocusedColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRibbonTabTextColourPreview)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlternativeNormalTextColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkNormalColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPressedTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFocusedTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisabledTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNormalTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBorderColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightestColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDarkColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddleColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane.Panel)).EndInit();
            this.kgbCircularColourPreviewPane.Panel.ResumeLayout(false);
            this.kgbCircularColourPreviewPane.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane)).EndInit();
            this.kgbCircularColourPreviewPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxRibbonTabTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkFocusedColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStatusTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourThreePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourTwoPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMenuTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourFourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourFivePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourOnePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourFivePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourTwoPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourOnePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkVisitedColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourThreePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourFourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkHoverColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPressedTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFocusedTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisabledTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisabledControlColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkNormalColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNormalTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBorderColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAlternativeNormalTextColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightestColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMiddleColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBaseColourPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RibbonWindow_Load(object sender, EventArgs e)
        {

        }

        private void krgbExpertMode_Click(object sender, EventArgs e)
        {
            PaletteExplorerWindow pew = new PaletteExplorerWindow();

            pew.Show();
        }
    }
}