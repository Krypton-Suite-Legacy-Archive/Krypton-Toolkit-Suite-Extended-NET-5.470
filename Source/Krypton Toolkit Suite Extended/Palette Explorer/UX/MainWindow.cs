using ComponentFactory.Krypton.Toolkit;

namespace PaletteExplorer.UX
{
    public partial class MainWindow : KryptonForm
    {
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
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblColourOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ctxAlternativeNormalTextUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDisabledTextUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMiddleUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuTextColourUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourFiveUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLinkHoverUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxNormalTextUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDarkUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourFourUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourThreeUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDisabledUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBorderUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourFiveUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLinkNormalUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBaseUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.utiliseAsBaseColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrUpdateUI = new System.Windows.Forms.Timer(this.components);
            this.cmsViewType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.standardPictureboxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.circularPictureboxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsExperinental = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxLinkVisitedUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourFourUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourOneUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem();
            this.ttInformation = new System.Windows.Forms.ToolTip(this.components);
            this.palette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kcmViewType = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem7 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kcStandardPictureboxes = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kryptonContextMenuSeparator7 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuItem8 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kcCircularPictureboxes = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kcmExperimental = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kcNewPalette = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kcOpenPalette = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kcSavePalette = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kcSavePaletteAs = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kcExitApplication = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.ctxCustomTextColourTwoUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLightestUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPressedTextUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourTwoUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourThreeUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourOneUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFoucusedTextUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxStatusTextColourUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem42 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLightUtiliseAsBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.kgbSquarePreviewPane = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pbxLinkFocusedColourPreview = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.ctxAlternativeNormalTextUtiliseAsBaseColour.SuspendLayout();
            this.ctxDisabledTextUtiliseAsBaseColour.SuspendLayout();
            this.ctxMiddleUtiliseAsBaseColour.SuspendLayout();
            this.ctxMenuTextColourUtiliseAsBaseColour.SuspendLayout();
            this.ctxCustomColourFiveUtiliseAsBaseColour.SuspendLayout();
            this.ctxLinkHoverUtiliseAsBaseColour.SuspendLayout();
            this.ctxNormalTextUtiliseAsBaseColour.SuspendLayout();
            this.ctxDarkUtiliseAsBaseColour.SuspendLayout();
            this.ctxCustomTextColourFourUtiliseAsBaseColour.SuspendLayout();
            this.ctxCustomColourThreeUtiliseAsBaseColour.SuspendLayout();
            this.ctxDisabledUtiliseAsBaseColour.SuspendLayout();
            this.ctxBorderUtiliseAsBaseColour.SuspendLayout();
            this.ctxCustomTextColourFiveUtiliseAsBaseColour.SuspendLayout();
            this.ctxLinkNormalUtiliseAsBaseColour.SuspendLayout();
            this.ctxBaseUtiliseAsBaseColour.SuspendLayout();
            this.cmsViewType.SuspendLayout();
            this.ctxLinkVisitedUtiliseAsBaseColour.SuspendLayout();
            this.ctxCustomColourFourUtiliseAsBaseColour.SuspendLayout();
            this.ctxCustomTextColourOneUtiliseAsBaseColour.SuspendLayout();
            this.ctxCustomTextColourTwoUtiliseAsBaseColour.SuspendLayout();
            this.ctxLightestUtiliseAsBaseColour.SuspendLayout();
            this.ctxPressedTextUtiliseAsBaseColour.SuspendLayout();
            this.ctxCustomColourTwoUtiliseAsBaseColour.SuspendLayout();
            this.ctxCustomTextColourThreeUtiliseAsBaseColour.SuspendLayout();
            this.ctxCustomColourOneUtiliseAsBaseColour.SuspendLayout();
            this.ctxFoucusedTextUtiliseAsBaseColour.SuspendLayout();
            this.ctxStatusTextColourUtiliseAsBaseColour.SuspendLayout();
            this.ctxLightUtiliseAsBaseColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbSquarePreviewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbSquarePreviewPane.Panel)).BeginInit();
            this.kgbSquarePreviewPane.Panel.SuspendLayout();
            this.kgbSquarePreviewPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkFocusedColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.SuspendLayout();
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
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab1;
            this.kryptonRibbon1.Size = new System.Drawing.Size(1456, 115);
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
            this.kryptonContextMenuItem1.Text = "New Palette";
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Text = "Open Palette";
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.Text = "Save Palette";
            // 
            // kryptonContextMenuItem4
            // 
            this.kryptonContextMenuItem4.Text = "Save Palette As";
            // 
            // kryptonContextMenuItem5
            // 
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
            this.krgbOptions});
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
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.ss);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 806);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1456, 22);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Location = new System.Drawing.Point(0, 0);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(1456, 22);
            this.ss.TabIndex = 46;
            this.ss.Text = "statusStrip1";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnClose);
            this.kryptonPanel2.Controls.Add(this.lblColourOutput);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 752);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1456, 54);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // kbtnClose
            // 
            this.kbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnClose.Location = new System.Drawing.Point(1393, 12);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 750);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 2);
            this.panel1.TabIndex = 5;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kgbSquarePreviewPane);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1456, 635);
            this.kryptonPanel3.TabIndex = 6;
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
            // tmrUpdateUI
            // 
            this.tmrUpdateUI.Enabled = true;
            this.tmrUpdateUI.Interval = 250;
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
            // palette
            // 
            this.palette.FilePath = null;
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
            // 
            // kcNewPalette
            // 
            this.kcNewPalette.Text = "New Palette";
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
            // kgbSquarePreviewPane
            // 
            this.kgbSquarePreviewPane.Location = new System.Drawing.Point(12, 22);
            this.kgbSquarePreviewPane.Name = "kgbSquarePreviewPane";
            // 
            // kgbSquarePreviewPane.Panel
            // 
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxLinkFocusedColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pictureBox5);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pictureBox6);
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
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxAlternativeNormalTextColour);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxLinkNormalColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxDisabledColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxPressedTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxFocusedTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxDisabledTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxNormalTextColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxBorderColourPreview);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxBaseColour);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxLightestColour);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxDarkColour);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxLightColour);
            this.kgbSquarePreviewPane.Panel.Controls.Add(this.pbxMiddleColour);
            this.kgbSquarePreviewPane.Size = new System.Drawing.Size(708, 467);
            this.kgbSquarePreviewPane.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbSquarePreviewPane.TabIndex = 36;
            this.kgbSquarePreviewPane.Values.Heading = "Colour Preview";
            // 
            // pbxLinkFocusedColourPreview
            // 
            this.pbxLinkFocusedColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkFocusedColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkFocusedColourPreview.Location = new System.Drawing.Point(451, 127);
            this.pbxLinkFocusedColourPreview.Name = "pbxLinkFocusedColourPreview";
            this.pbxLinkFocusedColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLinkFocusedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkFocusedColourPreview.TabIndex = 87;
            this.pbxLinkFocusedColourPreview.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(451, 352);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 86;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Location = new System.Drawing.Point(365, 352);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 85;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pbxStatusTextColourPreview
            // 
            this.pbxStatusTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxStatusTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxStatusTextColourPreview.ContextMenuStrip = this.ctxStatusTextColourUtiliseAsBaseColour;
            this.pbxStatusTextColourPreview.Location = new System.Drawing.Point(279, 352);
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
            this.pbxMenuTextColourPreview.Location = new System.Drawing.Point(193, 352);
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
            this.pbxCustomColourFourPreview.Location = new System.Drawing.Point(279, 239);
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
            this.pbxCustomTextColourFivePreview.Location = new System.Drawing.Point(105, 351);
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
            this.pbxCustomTextColourFourPreview.Location = new System.Drawing.Point(19, 351);
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
            this.pbxCustomTextColourThreePreview.Location = new System.Drawing.Point(623, 239);
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
            this.pbxCustomTextColourTwoPreview.Location = new System.Drawing.Point(537, 239);
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
            this.pbxCustomTextColourOnePreview.Location = new System.Drawing.Point(451, 239);
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
            this.pbxCustomColourFivePreview.Location = new System.Drawing.Point(365, 239);
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
            this.pbxCustomColourThreePreview.Location = new System.Drawing.Point(193, 239);
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
            this.pbxCustomColourTwoPreview.Location = new System.Drawing.Point(107, 239);
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
            this.pbxCustomColourOnePreview.Location = new System.Drawing.Point(19, 239);
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
            this.pbxLinkVisitedColourPreview.Location = new System.Drawing.Point(623, 127);
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
            this.pbxLinkHoverColourPreview.Location = new System.Drawing.Point(537, 127);
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
            this.pbxAlternativeNormalTextColour.ContextMenuStrip = this.ctxAlternativeNormalTextUtiliseAsBaseColour;
            this.pbxAlternativeNormalTextColour.Location = new System.Drawing.Point(537, 16);
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
            this.pbxLinkNormalColourPreview.ContextMenuStrip = this.ctxLinkNormalUtiliseAsBaseColour;
            this.pbxLinkNormalColourPreview.Location = new System.Drawing.Point(365, 127);
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
            this.pbxDisabledColourPreview.ContextMenuStrip = this.ctxDisabledUtiliseAsBaseColour;
            this.pbxDisabledColourPreview.Location = new System.Drawing.Point(279, 127);
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
            this.pbxPressedTextColourPreview.ContextMenuStrip = this.ctxPressedTextUtiliseAsBaseColour;
            this.pbxPressedTextColourPreview.Location = new System.Drawing.Point(191, 127);
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
            this.pbxFocusedTextColourPreview.Location = new System.Drawing.Point(107, 127);
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
            this.pbxDisabledTextColourPreview.Location = new System.Drawing.Point(19, 127);
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
            this.pbxNormalTextColourPreview.Location = new System.Drawing.Point(623, 16);
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
            this.pbxBorderColourPreview.Location = new System.Drawing.Point(451, 16);
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
            this.pbxBaseColour.ContextMenuStrip = this.ctxBaseUtiliseAsBaseColour;
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
            this.pbxLightestColour.ContextMenuStrip = this.ctxLightestUtiliseAsBaseColour;
            this.pbxLightestColour.Location = new System.Drawing.Point(365, 16);
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
            this.pbxDarkColour.ContextMenuStrip = this.ctxDarkUtiliseAsBaseColour;
            this.pbxDarkColour.Location = new System.Drawing.Point(107, 16);
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
            this.pbxLightColour.ContextMenuStrip = this.ctxLightUtiliseAsBaseColour;
            this.pbxLightColour.Location = new System.Drawing.Point(279, 16);
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
            this.pbxMiddleColour.ContextMenuStrip = this.ctxMiddleUtiliseAsBaseColour;
            this.pbxMiddleColour.Location = new System.Drawing.Point(193, 16);
            this.pbxMiddleColour.Name = "pbxMiddleColour";
            this.pbxMiddleColour.Size = new System.Drawing.Size(64, 64);
            this.pbxMiddleColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxMiddleColour.TabIndex = 6;
            this.pbxMiddleColour.TabStop = false;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1456, 828);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonRibbon1);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.ctxAlternativeNormalTextUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxDisabledTextUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxMiddleUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxMenuTextColourUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxCustomColourFiveUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxLinkHoverUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxNormalTextUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxDarkUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxCustomTextColourFourUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxCustomColourThreeUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxDisabledUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxBorderUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxCustomTextColourFiveUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxLinkNormalUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxBaseUtiliseAsBaseColour.ResumeLayout(false);
            this.cmsViewType.ResumeLayout(false);
            this.ctxLinkVisitedUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxCustomColourFourUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxCustomTextColourOneUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxCustomTextColourTwoUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxLightestUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxPressedTextUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxCustomColourTwoUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxCustomTextColourThreeUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxCustomColourOneUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxFoucusedTextUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxStatusTextColourUtiliseAsBaseColour.ResumeLayout(false);
            this.ctxLightUtiliseAsBaseColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbSquarePreviewPane.Panel)).EndInit();
            this.kgbSquarePreviewPane.Panel.ResumeLayout(false);
            this.kgbSquarePreviewPane.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbSquarePreviewPane)).EndInit();
            this.kgbSquarePreviewPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkFocusedColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}