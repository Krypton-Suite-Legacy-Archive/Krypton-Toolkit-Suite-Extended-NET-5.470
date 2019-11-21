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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletteExplorer.UX.New
{
    public class PaletteExplorerWindow : KryptonForm
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
        private KryptonPanel kpnlStatusStrip;
        private System.Windows.Forms.StatusStrip ss;
        private KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator kdnPaletteExplorer;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private KryptonHeader buttonSpecG4;
        private ButtonSpecAny buttonSpecGeneric1;
        private ButtonSpecAny buttonSpecGeneric2;
        private KryptonHeader buttonSpecG3;
        private KryptonHeader buttonSpecG2;
        private KryptonHeader buttonSpecG1;
        private KryptonHeader buttonSpecT4;
        private ButtonSpecAny buttonSpecAny32;
        private ButtonSpecAny buttonSpecAny31;
        private ButtonSpecAny buttonSpecAny30;
        private ButtonSpecAny buttonSpecAny29;
        private ButtonSpecAny buttonSpecAny13;
        private ButtonSpecAny buttonSpecAny14;
        private ButtonSpecAny buttonSpecAny15;
        private ButtonSpecAny buttonSpecAny16;
        private ButtonSpecAny buttonSpecAny63;
        private ButtonSpecAny buttonSpecAny64;
        private ButtonSpecAny buttonSpecAny48;
        private ButtonSpecAny buttonSpecAny49;
        private ButtonSpecAny buttonSpecAny50;
        private ButtonSpecAny buttonSpecAny51;
        private ButtonSpecAny buttonSpecAny55;
        private ButtonSpecAny buttonSpecAny56;
        private KryptonHeader buttonSpecT3;
        private ButtonSpecAny buttonSpecAny28;
        private ButtonSpecAny buttonSpecAny27;
        private ButtonSpecAny buttonSpecAny26;
        private ButtonSpecAny buttonSpecAny25;
        private ButtonSpecAny buttonSpecAny9;
        private ButtonSpecAny buttonSpecAny10;
        private ButtonSpecAny buttonSpecAny11;
        private ButtonSpecAny buttonSpecAny12;
        private ButtonSpecAny buttonSpecAny61;
        private ButtonSpecAny buttonSpecAny62;
        private ButtonSpecAny buttonSpecAny41;
        private ButtonSpecAny buttonSpecAny42;
        private ButtonSpecAny buttonSpecAny43;
        private ButtonSpecAny buttonSpecAny44;
        private ButtonSpecAny buttonSpecAny53;
        private ButtonSpecAny buttonSpecAny54;
        private KryptonHeader buttonSpecT2;
        private ButtonSpecAny buttonSpecAny24;
        private ButtonSpecAny buttonSpecAny23;
        private ButtonSpecAny buttonSpecAny22;
        private ButtonSpecAny buttonSpecAny21;
        private ButtonSpecAny buttonSpecAny5;
        private ButtonSpecAny buttonSpecAny6;
        private ButtonSpecAny buttonSpecAny7;
        private ButtonSpecAny buttonSpecAny8;
        private ButtonSpecAny buttonSpecAny59;
        private ButtonSpecAny buttonSpecAny60;
        private ButtonSpecAny buttonSpecAny33;
        private ButtonSpecAny buttonSpecAny38;
        private ButtonSpecAny buttonSpecAny39;
        private ButtonSpecAny buttonSpecAny40;
        private ButtonSpecAny buttonSpecAny47;
        private ButtonSpecAny buttonSpecAny52;
        private KryptonHeader buttonSpecT1;
        private ButtonSpecAny buttonSpecAny20;
        private ButtonSpecAny buttonSpecAny19;
        private ButtonSpecAny buttonSpecAny18;
        private ButtonSpecAny buttonSpecAny17;
        private ButtonSpecAny buttonSpecAny4;
        private ButtonSpecAny buttonSpecAny3;
        private ButtonSpecAny buttonSpecAny2;
        private ButtonSpecAny buttonSpecAny1;
        private ButtonSpecAny buttonSpecAny57;
        private ButtonSpecAny buttonSpecAny58;
        private ButtonSpecAny buttonSpecAny34;
        private ButtonSpecAny buttonSpecAny35;
        private ButtonSpecAny buttonSpecAny36;
        private ButtonSpecAny buttonSpecAny37;
        private ButtonSpecAny buttonSpecAny46;
        private ButtonSpecAny buttonSpecAny45;
        private KryptonLabel labelButtonSpecsGeneric;
        private KryptonLabel labelButtonSpecsTyped;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private KryptonCheckButton buttonLive;
        private KryptonCheckButton buttonCheckedPressed;
        private KryptonCheckButton buttonCheckedTracking;
        private KryptonCheckButton buttonCheckedNormal;
        private KryptonCheckButton buttonDisabled;
        private KryptonCheckButton buttonPressed;
        private KryptonCheckButton buttonNormal;
        private KryptonCheckButton buttonTracking;
        private KryptonCheckButton buttonDefaultFocus;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigatorDesignButtons;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsStandalone;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsAlternate;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsLowProfile;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsBreadCrumb;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonCalendarDay;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsButtonSpec;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsRibbonCluster;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsNavigatorStack;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsNavigatorOverflow;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsNavigatorMini;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsInputControl;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsListItem;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsGallery;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsForm;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsFormClose;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsCommand;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsCustom1;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsCustom2;
        private ComponentFactory.Krypton.Navigator.KryptonPage pageButtonsCustom3;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage3;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage4;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage5;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage6;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage7;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage8;
        private KryptonCheckBox cbLive;
        private KryptonCheckBox cbFocus;
        private KryptonCheckBox cbIndeterminateTracking;
        private KryptonCheckBox cbIndeterminatePressed;
        private KryptonCheckBox cbIndeterminateNormal;
        private KryptonCheckBox cbIndeterminateDisabled;
        private KryptonCheckBox cbCheckedTracking;
        private KryptonCheckBox cbCheckedPressed;
        private KryptonCheckBox cbCheckedNormal;
        private KryptonCheckBox cbCheckedDisabled;
        private KryptonCheckBox cbUncheckedTracking;
        private KryptonCheckBox cbUncheckedPressed;
        private KryptonCheckBox cbUncheckedNormal;
        private KryptonCheckBox cbUncheckedDisabled;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbCheckForUpdates;

        private void InitializeComponent()
        {
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaletteExplorerWindow));
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues36 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues2 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues4 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues5 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues6 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues7 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues8 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues9 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues10 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues11 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues12 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues13 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues14 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues15 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues16 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues17 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues18 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues19 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues20 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues21 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues22 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues23 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues24 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues25 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues26 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues27 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues28 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues29 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues30 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues31 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues32 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues33 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues34 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues35 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
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
            this.kpnlStatusStrip = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kdnPaletteExplorer = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.buttonSpecG4 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecGeneric1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecGeneric2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecG3 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecG2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecG1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecT4 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecAny32 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny31 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny30 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny29 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny13 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny14 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny15 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny16 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny63 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny64 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny48 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny49 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny50 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny51 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny55 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny56 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecT3 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecAny28 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny27 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny26 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny25 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny9 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny10 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny11 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny12 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny61 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny62 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny41 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny42 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny43 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny44 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny53 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny54 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecT2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecAny24 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny23 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny22 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny21 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny6 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny7 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny8 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny59 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny60 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny33 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny38 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny39 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny40 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny47 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny52 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecT1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecAny20 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny19 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny18 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny17 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny57 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny58 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny34 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny35 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny36 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny37 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny46 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny45 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.labelButtonSpecsGeneric = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.labelButtonSpecsTyped = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.buttonLive = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.buttonCheckedPressed = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.buttonCheckedTracking = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.buttonCheckedNormal = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.buttonDisabled = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.buttonPressed = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.buttonNormal = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.buttonTracking = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.buttonDefaultFocus = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonNavigatorDesignButtons = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.pageButtonsStandalone = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsAlternate = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsLowProfile = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsBreadCrumb = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonCalendarDay = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsButtonSpec = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsRibbonCluster = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsNavigatorStack = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsNavigatorOverflow = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsNavigatorMini = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsInputControl = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsListItem = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsGallery = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsForm = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsFormClose = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsCommand = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsCustom1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsCustom2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pageButtonsCustom3 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage3 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.cbLive = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbFocus = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbIndeterminateTracking = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbIndeterminatePressed = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbIndeterminateNormal = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbIndeterminateDisabled = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbCheckedTracking = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbCheckedPressed = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbCheckedNormal = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbCheckedDisabled = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbUncheckedTracking = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbUncheckedPressed = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbUncheckedNormal = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbUncheckedDisabled = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonPage4 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage5 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage6 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage7 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage8 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            ((System.ComponentModel.ISupportInitialize)(this.krControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlStatusStrip)).BeginInit();
            this.kpnlStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdnPaletteExplorer)).BeginInit();
            this.kdnPaletteExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigatorDesignButtons)).BeginInit();
            this.kryptonNavigatorDesignButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsStandalone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsAlternate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsLowProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsBreadCrumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonCalendarDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsButtonSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsRibbonCluster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsNavigatorStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsNavigatorOverflow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsNavigatorMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsInputControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsGallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsFormClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsCustom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsCustom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsCustom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).BeginInit();
            this.kryptonPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage8)).BeginInit();
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
            this.krControls.SelectedContext = null;
            this.krControls.SelectedTab = this.kryptonRibbonTab2;
            this.krControls.Size = new System.Drawing.Size(1085, 115);
            this.krControls.TabIndex = 3;
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
            // kpnlStatusStrip
            // 
            this.kpnlStatusStrip.Controls.Add(this.ss);
            this.kpnlStatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlStatusStrip.Location = new System.Drawing.Point(0, 811);
            this.kpnlStatusStrip.Name = "kpnlStatusStrip";
            this.kpnlStatusStrip.Size = new System.Drawing.Size(1085, 22);
            this.kpnlStatusStrip.TabIndex = 4;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Location = new System.Drawing.Point(0, 0);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(1085, 22);
            this.ss.TabIndex = 46;
            this.ss.Text = "statusStrip1";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kdnPaletteExplorer);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1085, 696);
            this.kryptonPanel3.TabIndex = 6;
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
            this.kryptonPage2,
            this.kryptonPage3,
            this.kryptonPage4,
            this.kryptonPage5,
            this.kryptonPage6,
            this.kryptonPage7,
            this.kryptonPage8});
            this.kdnPaletteExplorer.SelectedIndex = 0;
            this.kdnPaletteExplorer.Size = new System.Drawing.Size(1085, 696);
            this.kdnPaletteExplorer.TabIndex = 6;
            this.kdnPaletteExplorer.Text = "kryptonDockableNavigator1";
            popupPositionValues36.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues36.PlacementTarget = null;
            this.kdnPaletteExplorer.ToolTipValues.ToolTipPosition = popupPositionValues36;
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.buttonSpecG4);
            this.kryptonPage1.Controls.Add(this.buttonSpecG3);
            this.kryptonPage1.Controls.Add(this.buttonSpecG2);
            this.kryptonPage1.Controls.Add(this.buttonSpecG1);
            this.kryptonPage1.Controls.Add(this.buttonSpecT4);
            this.kryptonPage1.Controls.Add(this.buttonSpecT3);
            this.kryptonPage1.Controls.Add(this.buttonSpecT2);
            this.kryptonPage1.Controls.Add(this.buttonSpecT1);
            this.kryptonPage1.Controls.Add(this.labelButtonSpecsGeneric);
            this.kryptonPage1.Controls.Add(this.labelButtonSpecsTyped);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(1083, 669);
            this.kryptonPage1.Text = "Button Specs";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "bd8fdfd429164bb7a1b81a29ae3a5ff8";
            // 
            // buttonSpecG4
            // 
            this.buttonSpecG4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonSpecG4.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecGeneric1,
            this.buttonSpecGeneric2});
            this.buttonSpecG4.Enabled = false;
            this.buttonSpecG4.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.buttonSpecG4.Location = new System.Drawing.Point(31, 615);
            this.buttonSpecG4.Name = "buttonSpecG4";
            this.buttonSpecG4.Size = new System.Drawing.Size(263, 28);
            this.buttonSpecG4.TabIndex = 38;
            popupPositionValues2.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues2.PlacementTarget = null;
            this.buttonSpecG4.ToolTipValues.ToolTipPosition = popupPositionValues2;
            this.buttonSpecG4.Values.Description = "";
            this.buttonSpecG4.Values.Heading = "Disabled";
            this.buttonSpecG4.Values.Image = null;
            // 
            // buttonSpecGeneric1
            // 
            this.buttonSpecGeneric1.UniqueName = "E3ECD10B03184164E3ECD10B03184164";
            // 
            // buttonSpecGeneric2
            // 
            this.buttonSpecGeneric2.UniqueName = "E2BD1D4F0EE64328E2BD1D4F0EE64328";
            // 
            // buttonSpecG3
            // 
            this.buttonSpecG3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonSpecG3.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecGeneric1,
            this.buttonSpecGeneric2});
            this.buttonSpecG3.Enabled = false;
            this.buttonSpecG3.Location = new System.Drawing.Point(31, 568);
            this.buttonSpecG3.Name = "buttonSpecG3";
            this.buttonSpecG3.Size = new System.Drawing.Size(263, 31);
            this.buttonSpecG3.TabIndex = 37;
            popupPositionValues3.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues3.PlacementTarget = null;
            this.buttonSpecG3.ToolTipValues.ToolTipPosition = popupPositionValues3;
            this.buttonSpecG3.Values.Description = "";
            this.buttonSpecG3.Values.Heading = "Disabled";
            this.buttonSpecG3.Values.Image = null;
            // 
            // buttonSpecG2
            // 
            this.buttonSpecG2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonSpecG2.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecGeneric1,
            this.buttonSpecGeneric2});
            this.buttonSpecG2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.buttonSpecG2.Location = new System.Drawing.Point(31, 524);
            this.buttonSpecG2.Name = "buttonSpecG2";
            this.buttonSpecG2.Size = new System.Drawing.Size(263, 28);
            this.buttonSpecG2.TabIndex = 36;
            popupPositionValues4.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues4.PlacementTarget = null;
            this.buttonSpecG2.ToolTipValues.ToolTipPosition = popupPositionValues4;
            this.buttonSpecG2.Values.Description = "";
            this.buttonSpecG2.Values.Heading = "Header2";
            this.buttonSpecG2.Values.Image = null;
            // 
            // buttonSpecG1
            // 
            this.buttonSpecG1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonSpecG1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecGeneric1,
            this.buttonSpecGeneric2});
            this.buttonSpecG1.Location = new System.Drawing.Point(31, 477);
            this.buttonSpecG1.Name = "buttonSpecG1";
            this.buttonSpecG1.Size = new System.Drawing.Size(263, 31);
            this.buttonSpecG1.TabIndex = 35;
            popupPositionValues5.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues5.PlacementTarget = null;
            this.buttonSpecG1.ToolTipValues.ToolTipPosition = popupPositionValues5;
            this.buttonSpecG1.Values.Description = "";
            this.buttonSpecG1.Values.Heading = "Header1";
            this.buttonSpecG1.Values.Image = null;
            // 
            // buttonSpecT4
            // 
            this.buttonSpecT4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonSpecT4.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny32,
            this.buttonSpecAny31,
            this.buttonSpecAny30,
            this.buttonSpecAny29,
            this.buttonSpecAny13,
            this.buttonSpecAny14,
            this.buttonSpecAny15,
            this.buttonSpecAny16,
            this.buttonSpecAny63,
            this.buttonSpecAny64,
            this.buttonSpecAny48,
            this.buttonSpecAny49,
            this.buttonSpecAny50,
            this.buttonSpecAny51,
            this.buttonSpecAny55,
            this.buttonSpecAny56});
            this.buttonSpecT4.Enabled = false;
            this.buttonSpecT4.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.buttonSpecT4.Location = new System.Drawing.Point(31, 332);
            this.buttonSpecT4.Name = "buttonSpecT4";
            this.buttonSpecT4.Size = new System.Drawing.Size(427, 31);
            this.buttonSpecT4.TabIndex = 34;
            popupPositionValues6.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues6.PlacementTarget = null;
            this.buttonSpecT4.ToolTipValues.ToolTipPosition = popupPositionValues6;
            this.buttonSpecT4.Values.Description = "";
            this.buttonSpecT4.Values.Heading = "Disabled";
            this.buttonSpecT4.Values.Image = null;
            // 
            // buttonSpecAny32
            // 
            this.buttonSpecAny32.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown;
            this.buttonSpecAny32.UniqueName = "D966DA3688534126D966DA3688534126";
            // 
            // buttonSpecAny31
            // 
            this.buttonSpecAny31.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.buttonSpecAny31.UniqueName = "24881A5C3CD7484F24881A5C3CD7484F";
            // 
            // buttonSpecAny30
            // 
            this.buttonSpecAny30.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowRight;
            this.buttonSpecAny30.UniqueName = "9E75280CB89B46CA9E75280CB89B46CA";
            // 
            // buttonSpecAny29
            // 
            this.buttonSpecAny29.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft;
            this.buttonSpecAny29.UniqueName = "AA43031B0FEC4AF8AA43031B0FEC4AF8";
            // 
            // buttonSpecAny13
            // 
            this.buttonSpecAny13.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Previous;
            this.buttonSpecAny13.UniqueName = "7846E1DEE7074BB27846E1DEE7074BB2";
            // 
            // buttonSpecAny14
            // 
            this.buttonSpecAny14.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Next;
            this.buttonSpecAny14.UniqueName = "3AB250A5C5A345C13AB250A5C5A345C1";
            // 
            // buttonSpecAny15
            // 
            this.buttonSpecAny15.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny15.UniqueName = "441CC54390784327441CC54390784327";
            // 
            // buttonSpecAny16
            // 
            this.buttonSpecAny16.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny16.UniqueName = "277B00322C984668277B00322C984668";
            // 
            // buttonSpecAny63
            // 
            this.buttonSpecAny63.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.RibbonExpand;
            this.buttonSpecAny63.UniqueName = "4870673740E54FC3508C587FBCC6C0B5";
            // 
            // buttonSpecAny64
            // 
            this.buttonSpecAny64.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.RibbonMinimize;
            this.buttonSpecAny64.UniqueName = "20657E8FABC04EEED2AF1A185670DE36";
            // 
            // buttonSpecAny48
            // 
            this.buttonSpecAny48.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormMin;
            this.buttonSpecAny48.UniqueName = "D382E33950F648BFD382E33950F648BF";
            // 
            // buttonSpecAny49
            // 
            this.buttonSpecAny49.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormMax;
            this.buttonSpecAny49.UniqueName = "DDB1428C84944F88DDB1428C84944F88";
            // 
            // buttonSpecAny50
            // 
            this.buttonSpecAny50.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormRestore;
            this.buttonSpecAny50.UniqueName = "0DEC427FE55A40100DEC427FE55A4010";
            // 
            // buttonSpecAny51
            // 
            this.buttonSpecAny51.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAny51.UniqueName = "D8FD73FF3B1144CED8FD73FF3B1144CE";
            // 
            // buttonSpecAny55
            // 
            this.buttonSpecAny55.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PinVertical;
            this.buttonSpecAny55.UniqueName = "ADE166B708AA4F7DADE166B708AA4F7D";
            // 
            // buttonSpecAny56
            // 
            this.buttonSpecAny56.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PinHorizontal;
            this.buttonSpecAny56.UniqueName = "D1A2751D743A4671D1A2751D743A4671";
            // 
            // buttonSpecT3
            // 
            this.buttonSpecT3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonSpecT3.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny28,
            this.buttonSpecAny27,
            this.buttonSpecAny26,
            this.buttonSpecAny25,
            this.buttonSpecAny9,
            this.buttonSpecAny10,
            this.buttonSpecAny11,
            this.buttonSpecAny12,
            this.buttonSpecAny61,
            this.buttonSpecAny62,
            this.buttonSpecAny41,
            this.buttonSpecAny42,
            this.buttonSpecAny43,
            this.buttonSpecAny44,
            this.buttonSpecAny53,
            this.buttonSpecAny54});
            this.buttonSpecT3.Enabled = false;
            this.buttonSpecT3.Location = new System.Drawing.Point(31, 242);
            this.buttonSpecT3.Name = "buttonSpecT3";
            this.buttonSpecT3.Size = new System.Drawing.Size(427, 31);
            this.buttonSpecT3.TabIndex = 33;
            popupPositionValues7.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues7.PlacementTarget = null;
            this.buttonSpecT3.ToolTipValues.ToolTipPosition = popupPositionValues7;
            this.buttonSpecT3.Values.Description = "";
            this.buttonSpecT3.Values.Heading = "Disabled";
            this.buttonSpecT3.Values.Image = null;
            // 
            // buttonSpecAny28
            // 
            this.buttonSpecAny28.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown;
            this.buttonSpecAny28.UniqueName = "5C9E40DBFF67470B5C9E40DBFF67470B";
            // 
            // buttonSpecAny27
            // 
            this.buttonSpecAny27.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.buttonSpecAny27.UniqueName = "D083298345F74B62D083298345F74B62";
            // 
            // buttonSpecAny26
            // 
            this.buttonSpecAny26.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowRight;
            this.buttonSpecAny26.UniqueName = "18769F9D74FB47A118769F9D74FB47A1";
            // 
            // buttonSpecAny25
            // 
            this.buttonSpecAny25.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft;
            this.buttonSpecAny25.UniqueName = "3E7909E2B5C64C4A3E7909E2B5C64C4A";
            // 
            // buttonSpecAny9
            // 
            this.buttonSpecAny9.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Previous;
            this.buttonSpecAny9.UniqueName = "9C7B8F356F214F419C7B8F356F214F41";
            // 
            // buttonSpecAny10
            // 
            this.buttonSpecAny10.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Next;
            this.buttonSpecAny10.UniqueName = "8BF5656D58804D618BF5656D58804D61";
            // 
            // buttonSpecAny11
            // 
            this.buttonSpecAny11.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny11.UniqueName = "D9FC19B53D634F19D9FC19B53D634F19";
            // 
            // buttonSpecAny12
            // 
            this.buttonSpecAny12.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny12.UniqueName = "C34EAD69BFAF4CD4C34EAD69BFAF4CD4";
            // 
            // buttonSpecAny61
            // 
            this.buttonSpecAny61.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.RibbonExpand;
            this.buttonSpecAny61.UniqueName = "B14387545DF641EEFEA7734ED77BAFA2";
            // 
            // buttonSpecAny62
            // 
            this.buttonSpecAny62.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.RibbonMinimize;
            this.buttonSpecAny62.UniqueName = "7F6783F61FEF4D2F01BC70A81AF20DF4";
            // 
            // buttonSpecAny41
            // 
            this.buttonSpecAny41.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormMin;
            this.buttonSpecAny41.UniqueName = "28C3C35837724C5E28C3C35837724C5E";
            // 
            // buttonSpecAny42
            // 
            this.buttonSpecAny42.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormMax;
            this.buttonSpecAny42.UniqueName = "33FE2E62F13B445E33FE2E62F13B445E";
            // 
            // buttonSpecAny43
            // 
            this.buttonSpecAny43.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormRestore;
            this.buttonSpecAny43.UniqueName = "4E04DE795D1C43FF4E04DE795D1C43FF";
            // 
            // buttonSpecAny44
            // 
            this.buttonSpecAny44.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAny44.UniqueName = "DCFF5679445B46E0DCFF5679445B46E0";
            // 
            // buttonSpecAny53
            // 
            this.buttonSpecAny53.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PinVertical;
            this.buttonSpecAny53.UniqueName = "3C6A9576CC634DA73C6A9576CC634DA7";
            // 
            // buttonSpecAny54
            // 
            this.buttonSpecAny54.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PinHorizontal;
            this.buttonSpecAny54.UniqueName = "697C060DC92C491D697C060DC92C491D";
            // 
            // buttonSpecT2
            // 
            this.buttonSpecT2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonSpecT2.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny24,
            this.buttonSpecAny23,
            this.buttonSpecAny22,
            this.buttonSpecAny21,
            this.buttonSpecAny5,
            this.buttonSpecAny6,
            this.buttonSpecAny7,
            this.buttonSpecAny8,
            this.buttonSpecAny59,
            this.buttonSpecAny60,
            this.buttonSpecAny33,
            this.buttonSpecAny38,
            this.buttonSpecAny39,
            this.buttonSpecAny40,
            this.buttonSpecAny47,
            this.buttonSpecAny52});
            this.buttonSpecT2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.buttonSpecT2.Location = new System.Drawing.Point(31, 152);
            this.buttonSpecT2.Name = "buttonSpecT2";
            this.buttonSpecT2.Size = new System.Drawing.Size(427, 31);
            this.buttonSpecT2.TabIndex = 32;
            popupPositionValues8.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues8.PlacementTarget = null;
            this.buttonSpecT2.ToolTipValues.ToolTipPosition = popupPositionValues8;
            this.buttonSpecT2.Values.Description = "";
            this.buttonSpecT2.Values.Heading = "Header2";
            this.buttonSpecT2.Values.Image = null;
            // 
            // buttonSpecAny24
            // 
            this.buttonSpecAny24.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown;
            this.buttonSpecAny24.UniqueName = "DCE3DBB8ECB948C9DCE3DBB8ECB948C9";
            // 
            // buttonSpecAny23
            // 
            this.buttonSpecAny23.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.buttonSpecAny23.UniqueName = "E3137CCE36FF4E11E3137CCE36FF4E11";
            // 
            // buttonSpecAny22
            // 
            this.buttonSpecAny22.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowRight;
            this.buttonSpecAny22.UniqueName = "1DD7F90A3C0A494C1DD7F90A3C0A494C";
            // 
            // buttonSpecAny21
            // 
            this.buttonSpecAny21.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft;
            this.buttonSpecAny21.UniqueName = "2E2FC7337157478F2E2FC7337157478F";
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Previous;
            this.buttonSpecAny5.UniqueName = "064B5F1CCCC24795064B5F1CCCC24795";
            // 
            // buttonSpecAny6
            // 
            this.buttonSpecAny6.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Next;
            this.buttonSpecAny6.UniqueName = "519EBD952A024210519EBD952A024210";
            // 
            // buttonSpecAny7
            // 
            this.buttonSpecAny7.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny7.UniqueName = "C7D28483934446A6C7D28483934446A6";
            // 
            // buttonSpecAny8
            // 
            this.buttonSpecAny8.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny8.UniqueName = "1B2D8870C92F453F1B2D8870C92F453F";
            // 
            // buttonSpecAny59
            // 
            this.buttonSpecAny59.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.RibbonExpand;
            this.buttonSpecAny59.UniqueName = "B2E349E046DE4EFDE0A61BF0F55DF83C";
            // 
            // buttonSpecAny60
            // 
            this.buttonSpecAny60.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.RibbonMinimize;
            this.buttonSpecAny60.UniqueName = "E11D4FD39CFF46FEC3859CFE529C0B20";
            // 
            // buttonSpecAny33
            // 
            this.buttonSpecAny33.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormMin;
            this.buttonSpecAny33.UniqueName = "D8799F9F897E4AE4D8799F9F897E4AE4";
            // 
            // buttonSpecAny38
            // 
            this.buttonSpecAny38.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormMax;
            this.buttonSpecAny38.UniqueName = "B6D5E93171BF47A4B6D5E93171BF47A4";
            // 
            // buttonSpecAny39
            // 
            this.buttonSpecAny39.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormRestore;
            this.buttonSpecAny39.UniqueName = "72C99E766FCF4E2072C99E766FCF4E20";
            // 
            // buttonSpecAny40
            // 
            this.buttonSpecAny40.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAny40.UniqueName = "2C9A72BD23954DD82C9A72BD23954DD8";
            // 
            // buttonSpecAny47
            // 
            this.buttonSpecAny47.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PinVertical;
            this.buttonSpecAny47.UniqueName = "B5F9E4469C2846FDB5F9E4469C2846FD";
            // 
            // buttonSpecAny52
            // 
            this.buttonSpecAny52.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PinHorizontal;
            this.buttonSpecAny52.UniqueName = "0EFF1D41CC604FD00EFF1D41CC604FD0";
            // 
            // buttonSpecT1
            // 
            this.buttonSpecT1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonSpecT1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny20,
            this.buttonSpecAny19,
            this.buttonSpecAny18,
            this.buttonSpecAny17,
            this.buttonSpecAny4,
            this.buttonSpecAny3,
            this.buttonSpecAny2,
            this.buttonSpecAny1,
            this.buttonSpecAny57,
            this.buttonSpecAny58,
            this.buttonSpecAny34,
            this.buttonSpecAny35,
            this.buttonSpecAny36,
            this.buttonSpecAny37,
            this.buttonSpecAny46,
            this.buttonSpecAny45});
            this.buttonSpecT1.Location = new System.Drawing.Point(31, 62);
            this.buttonSpecT1.Name = "buttonSpecT1";
            this.buttonSpecT1.Size = new System.Drawing.Size(427, 31);
            this.buttonSpecT1.TabIndex = 31;
            popupPositionValues9.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues9.PlacementTarget = null;
            this.buttonSpecT1.ToolTipValues.ToolTipPosition = popupPositionValues9;
            this.buttonSpecT1.Values.Description = "";
            this.buttonSpecT1.Values.Heading = "Header1";
            this.buttonSpecT1.Values.Image = null;
            // 
            // buttonSpecAny20
            // 
            this.buttonSpecAny20.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown;
            this.buttonSpecAny20.UniqueName = "AF08F29D8981468DAF08F29D8981468D";
            // 
            // buttonSpecAny19
            // 
            this.buttonSpecAny19.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.buttonSpecAny19.UniqueName = "F74ABC1CB84F4403F74ABC1CB84F4403";
            // 
            // buttonSpecAny18
            // 
            this.buttonSpecAny18.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowRight;
            this.buttonSpecAny18.UniqueName = "DB5F0890BC944C98DB5F0890BC944C98";
            // 
            // buttonSpecAny17
            // 
            this.buttonSpecAny17.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft;
            this.buttonSpecAny17.UniqueName = "F53F319649A04B9AF53F319649A04B9A";
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Previous;
            this.buttonSpecAny4.UniqueName = "FF0A19FAD5324D8DFF0A19FAD5324D8D";
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Next;
            this.buttonSpecAny3.UniqueName = "F73579B2DA6348C5F73579B2DA6348C5";
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny2.UniqueName = "30AB8A391A3D474930AB8A391A3D4749";
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "AF4C13CF1AA14B78AF4C13CF1AA14B78";
            // 
            // buttonSpecAny57
            // 
            this.buttonSpecAny57.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.RibbonExpand;
            this.buttonSpecAny57.UniqueName = "7D09362B81C6477B638F653E2A5E0A75";
            // 
            // buttonSpecAny58
            // 
            this.buttonSpecAny58.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.RibbonMinimize;
            this.buttonSpecAny58.UniqueName = "98A4817C07FE4AC3E2A1235FA4CD6FD8";
            // 
            // buttonSpecAny34
            // 
            this.buttonSpecAny34.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormMin;
            this.buttonSpecAny34.UniqueName = "0318BFE0697946700318BFE069794670";
            // 
            // buttonSpecAny35
            // 
            this.buttonSpecAny35.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormMax;
            this.buttonSpecAny35.UniqueName = "2161BA5EA78E40872161BA5EA78E4087";
            // 
            // buttonSpecAny36
            // 
            this.buttonSpecAny36.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormRestore;
            this.buttonSpecAny36.UniqueName = "6576F4A3796842596576F4A379684259";
            // 
            // buttonSpecAny37
            // 
            this.buttonSpecAny37.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAny37.UniqueName = "6869A67401AF4E146869A67401AF4E14";
            // 
            // buttonSpecAny46
            // 
            this.buttonSpecAny46.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PinHorizontal;
            this.buttonSpecAny46.UniqueName = "633E45685BE04C5C633E45685BE04C5C";
            // 
            // buttonSpecAny45
            // 
            this.buttonSpecAny45.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PinVertical;
            this.buttonSpecAny45.UniqueName = "800E16C661F74C02800E16C661F74C02";
            // 
            // labelButtonSpecsGeneric
            // 
            this.labelButtonSpecsGeneric.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.labelButtonSpecsGeneric.Location = new System.Drawing.Point(31, 432);
            this.labelButtonSpecsGeneric.Name = "labelButtonSpecsGeneric";
            this.labelButtonSpecsGeneric.Size = new System.Drawing.Size(184, 29);
            this.labelButtonSpecsGeneric.TabIndex = 39;
            popupPositionValues10.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues10.PlacementTarget = null;
            this.labelButtonSpecsGeneric.ToolTipValues.ToolTipPosition = popupPositionValues10;
            this.labelButtonSpecsGeneric.Values.Text = "Generic ButtonSpec";
            // 
            // labelButtonSpecsTyped
            // 
            this.labelButtonSpecsTyped.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.labelButtonSpecsTyped.Location = new System.Drawing.Point(31, 27);
            this.labelButtonSpecsTyped.Name = "labelButtonSpecsTyped";
            this.labelButtonSpecsTyped.Size = new System.Drawing.Size(172, 29);
            this.labelButtonSpecsTyped.TabIndex = 30;
            popupPositionValues11.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues11.PlacementTarget = null;
            this.labelButtonSpecsTyped.ToolTipValues.ToolTipPosition = popupPositionValues11;
            this.labelButtonSpecsTyped.Values.Text = "Typed ButtonSpec";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.buttonLive);
            this.kryptonPage2.Controls.Add(this.buttonCheckedPressed);
            this.kryptonPage2.Controls.Add(this.buttonCheckedTracking);
            this.kryptonPage2.Controls.Add(this.buttonCheckedNormal);
            this.kryptonPage2.Controls.Add(this.buttonDisabled);
            this.kryptonPage2.Controls.Add(this.buttonPressed);
            this.kryptonPage2.Controls.Add(this.buttonNormal);
            this.kryptonPage2.Controls.Add(this.buttonTracking);
            this.kryptonPage2.Controls.Add(this.buttonDefaultFocus);
            this.kryptonPage2.Controls.Add(this.kryptonNavigatorDesignButtons);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(1083, 669);
            this.kryptonPage2.Text = "Buttons";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "e28d96407cc9443db3730ebba94f9380";
            // 
            // buttonLive
            // 
            this.buttonLive.AutoSize = true;
            this.buttonLive.Location = new System.Drawing.Point(502, 609);
            this.buttonLive.Name = "buttonLive";
            this.buttonLive.Size = new System.Drawing.Size(90, 34);
            this.buttonLive.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLive.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLive.TabIndex = 25;
            popupPositionValues12.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues12.PlacementTarget = null;
            this.buttonLive.ToolTipValues.ToolTipPosition = popupPositionValues12;
            this.buttonLive.Values.Image = ((System.Drawing.Image)(resources.GetObject("buttonLive.Values.Image")));
            this.buttonLive.Values.Text = "Live";
            // 
            // buttonCheckedPressed
            // 
            this.buttonCheckedPressed.AutoSize = true;
            this.buttonCheckedPressed.Enabled = false;
            this.buttonCheckedPressed.Location = new System.Drawing.Point(571, 553);
            this.buttonCheckedPressed.Name = "buttonCheckedPressed";
            this.buttonCheckedPressed.Size = new System.Drawing.Size(175, 34);
            this.buttonCheckedPressed.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckedPressed.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckedPressed.TabIndex = 24;
            popupPositionValues13.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues13.PlacementTarget = null;
            this.buttonCheckedPressed.ToolTipValues.ToolTipPosition = popupPositionValues13;
            this.buttonCheckedPressed.Values.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheckedPressed.Values.Image")));
            this.buttonCheckedPressed.Values.Text = "Checked Pressed";
            // 
            // buttonCheckedTracking
            // 
            this.buttonCheckedTracking.AutoSize = true;
            this.buttonCheckedTracking.Enabled = false;
            this.buttonCheckedTracking.Location = new System.Drawing.Point(571, 372);
            this.buttonCheckedTracking.Name = "buttonCheckedTracking";
            this.buttonCheckedTracking.Size = new System.Drawing.Size(182, 34);
            this.buttonCheckedTracking.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckedTracking.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckedTracking.TabIndex = 23;
            popupPositionValues14.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues14.PlacementTarget = null;
            this.buttonCheckedTracking.ToolTipValues.ToolTipPosition = popupPositionValues14;
            this.buttonCheckedTracking.Values.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheckedTracking.Values.Image")));
            this.buttonCheckedTracking.Values.Text = "Checked Tracking";
            // 
            // buttonCheckedNormal
            // 
            this.buttonCheckedNormal.AutoSize = true;
            this.buttonCheckedNormal.Enabled = false;
            this.buttonCheckedNormal.Location = new System.Drawing.Point(571, 192);
            this.buttonCheckedNormal.Name = "buttonCheckedNormal";
            this.buttonCheckedNormal.Size = new System.Drawing.Size(174, 34);
            this.buttonCheckedNormal.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckedNormal.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckedNormal.TabIndex = 22;
            popupPositionValues15.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues15.PlacementTarget = null;
            this.buttonCheckedNormal.ToolTipValues.ToolTipPosition = popupPositionValues15;
            this.buttonCheckedNormal.Values.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheckedNormal.Values.Image")));
            this.buttonCheckedNormal.Values.Text = "Checked Normal";
            // 
            // buttonDisabled
            // 
            this.buttonDisabled.AutoSize = true;
            this.buttonDisabled.Enabled = false;
            this.buttonDisabled.Location = new System.Drawing.Point(407, 12);
            this.buttonDisabled.Name = "buttonDisabled";
            this.buttonDisabled.Size = new System.Drawing.Size(119, 34);
            this.buttonDisabled.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisabled.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisabled.TabIndex = 17;
            popupPositionValues16.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues16.PlacementTarget = null;
            this.buttonDisabled.ToolTipValues.ToolTipPosition = popupPositionValues16;
            this.buttonDisabled.Values.Image = ((System.Drawing.Image)(resources.GetObject("buttonDisabled.Values.Image")));
            this.buttonDisabled.Values.Text = "Disabled";
            // 
            // buttonPressed
            // 
            this.buttonPressed.AutoSize = true;
            this.buttonPressed.Enabled = false;
            this.buttonPressed.Location = new System.Drawing.Point(407, 552);
            this.buttonPressed.Name = "buttonPressed";
            this.buttonPressed.Size = new System.Drawing.Size(119, 34);
            this.buttonPressed.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPressed.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPressed.TabIndex = 21;
            popupPositionValues17.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues17.PlacementTarget = null;
            this.buttonPressed.ToolTipValues.ToolTipPosition = popupPositionValues17;
            this.buttonPressed.Values.Image = ((System.Drawing.Image)(resources.GetObject("buttonPressed.Values.Image")));
            this.buttonPressed.Values.Text = "Pressed";
            // 
            // buttonNormal
            // 
            this.buttonNormal.AutoSize = true;
            this.buttonNormal.Enabled = false;
            this.buttonNormal.Location = new System.Drawing.Point(407, 192);
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.Size = new System.Drawing.Size(119, 34);
            this.buttonNormal.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNormal.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNormal.TabIndex = 18;
            popupPositionValues18.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues18.PlacementTarget = null;
            this.buttonNormal.ToolTipValues.ToolTipPosition = popupPositionValues18;
            this.buttonNormal.Values.Image = ((System.Drawing.Image)(resources.GetObject("buttonNormal.Values.Image")));
            this.buttonNormal.Values.Text = "Normal";
            // 
            // buttonTracking
            // 
            this.buttonTracking.AutoSize = true;
            this.buttonTracking.Enabled = false;
            this.buttonTracking.Location = new System.Drawing.Point(407, 372);
            this.buttonTracking.Name = "buttonTracking";
            this.buttonTracking.Size = new System.Drawing.Size(119, 34);
            this.buttonTracking.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTracking.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTracking.TabIndex = 20;
            popupPositionValues19.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues19.PlacementTarget = null;
            this.buttonTracking.ToolTipValues.ToolTipPosition = popupPositionValues19;
            this.buttonTracking.Values.Image = ((System.Drawing.Image)(resources.GetObject("buttonTracking.Values.Image")));
            this.buttonTracking.Values.Text = "Tracking";
            // 
            // buttonDefaultFocus
            // 
            this.buttonDefaultFocus.AutoSize = true;
            this.buttonDefaultFocus.Enabled = false;
            this.buttonDefaultFocus.Location = new System.Drawing.Point(571, 12);
            this.buttonDefaultFocus.Name = "buttonDefaultFocus";
            this.buttonDefaultFocus.Size = new System.Drawing.Size(166, 34);
            this.buttonDefaultFocus.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefaultFocus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefaultFocus.TabIndex = 19;
            popupPositionValues20.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues20.PlacementTarget = null;
            this.buttonDefaultFocus.ToolTipValues.ToolTipPosition = popupPositionValues20;
            this.buttonDefaultFocus.Values.Image = ((System.Drawing.Image)(resources.GetObject("buttonDefaultFocus.Values.Image")));
            this.buttonDefaultFocus.Values.Text = "Default + Focus";
            // 
            // kryptonNavigatorDesignButtons
            // 
            this.kryptonNavigatorDesignButtons.AutoSize = true;
            this.kryptonNavigatorDesignButtons.Bar.BarOrientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.kryptonNavigatorDesignButtons.Bar.CheckButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.kryptonNavigatorDesignButtons.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            this.kryptonNavigatorDesignButtons.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidthAndHeight;
            this.kryptonNavigatorDesignButtons.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigatorDesignButtons.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigatorDesignButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonNavigatorDesignButtons.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigatorDesignButtons.Name = "kryptonNavigatorDesignButtons";
            this.kryptonNavigatorDesignButtons.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarCheckButtonOnly;
            this.kryptonNavigatorDesignButtons.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pageButtonsStandalone,
            this.pageButtonsAlternate,
            this.pageButtonsLowProfile,
            this.pageButtonsBreadCrumb,
            this.pageButtonCalendarDay,
            this.pageButtonsButtonSpec,
            this.pageButtonsRibbonCluster,
            this.pageButtonsNavigatorStack,
            this.pageButtonsNavigatorOverflow,
            this.pageButtonsNavigatorMini,
            this.pageButtonsInputControl,
            this.pageButtonsListItem,
            this.pageButtonsGallery,
            this.pageButtonsForm,
            this.pageButtonsFormClose,
            this.pageButtonsCommand,
            this.pageButtonsCustom1,
            this.pageButtonsCustom2,
            this.pageButtonsCustom3});
            this.kryptonNavigatorDesignButtons.Panel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kryptonNavigatorDesignButtons.SelectedIndex = 0;
            this.kryptonNavigatorDesignButtons.Size = new System.Drawing.Size(94, 669);
            this.kryptonNavigatorDesignButtons.StateCommon.Bar.BarPaddingOnly = new System.Windows.Forms.Padding(5);
            this.kryptonNavigatorDesignButtons.TabIndex = 1;
            this.kryptonNavigatorDesignButtons.Text = "kryptonNavigator1";
            popupPositionValues21.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues21.PlacementTarget = null;
            this.kryptonNavigatorDesignButtons.ToolTipValues.ToolTipPosition = popupPositionValues21;
            // 
            // pageButtonsStandalone
            // 
            this.pageButtonsStandalone.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsStandalone.Flags = 65535;
            this.pageButtonsStandalone.ImageLarge = ((System.Drawing.Image)(resources.GetObject("pageButtonsStandalone.ImageLarge")));
            this.pageButtonsStandalone.ImageMedium = ((System.Drawing.Image)(resources.GetObject("pageButtonsStandalone.ImageMedium")));
            this.pageButtonsStandalone.LastVisibleSet = true;
            this.pageButtonsStandalone.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsStandalone.Name = "pageButtonsStandalone";
            this.pageButtonsStandalone.Size = new System.Drawing.Size(50, 490);
            this.pageButtonsStandalone.Text = "Standalone";
            this.pageButtonsStandalone.TextDescription = "Standalone is the main button style and intended for individual button instances." +
    "";
            this.pageButtonsStandalone.ToolTipTitle = "Page ToolTip";
            this.pageButtonsStandalone.UniqueName = "37C6B25023EE41AD37C6B25023EE41AD";
            // 
            // pageButtonsAlternate
            // 
            this.pageButtonsAlternate.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsAlternate.Flags = 65535;
            this.pageButtonsAlternate.LastVisibleSet = true;
            this.pageButtonsAlternate.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsAlternate.Name = "pageButtonsAlternate";
            this.pageButtonsAlternate.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsAlternate.Text = "Alternate";
            this.pageButtonsAlternate.TextDescription = "Alternate is the alternative standalone button style.";
            this.pageButtonsAlternate.ToolTipTitle = "Page ToolTip";
            this.pageButtonsAlternate.UniqueName = "69A8A8D80810484369A8A8D808104843";
            // 
            // pageButtonsLowProfile
            // 
            this.pageButtonsLowProfile.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsLowProfile.Flags = 65535;
            this.pageButtonsLowProfile.ImageLarge = ((System.Drawing.Image)(resources.GetObject("pageButtonsLowProfile.ImageLarge")));
            this.pageButtonsLowProfile.ImageMedium = ((System.Drawing.Image)(resources.GetObject("pageButtonsLowProfile.ImageMedium")));
            this.pageButtonsLowProfile.LastVisibleSet = true;
            this.pageButtonsLowProfile.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsLowProfile.Name = "pageButtonsLowProfile";
            this.pageButtonsLowProfile.Size = new System.Drawing.Size(50, 490);
            this.pageButtonsLowProfile.Text = "Low Profile";
            this.pageButtonsLowProfile.TextDescription = "Low Profile style is a less prominent variation for individual button instances.";
            this.pageButtonsLowProfile.ToolTipTitle = "Page ToolTip";
            this.pageButtonsLowProfile.UniqueName = "CEF16160BF1146BFCEF16160BF1146BF";
            // 
            // pageButtonsBreadCrumb
            // 
            this.pageButtonsBreadCrumb.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsBreadCrumb.Flags = 65535;
            this.pageButtonsBreadCrumb.LastVisibleSet = true;
            this.pageButtonsBreadCrumb.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsBreadCrumb.Name = "pageButtonsBreadCrumb";
            this.pageButtonsBreadCrumb.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsBreadCrumb.Text = "Bread Crumb";
            this.pageButtonsBreadCrumb.TextDescription = "Bread Crumb is used to draw each individual crumb inside the KryptonBreadCrumb.";
            this.pageButtonsBreadCrumb.ToolTipTitle = "Page ToolTip";
            this.pageButtonsBreadCrumb.UniqueName = "9083C1AC254644EE9083C1AC254644EE";
            // 
            // pageButtonCalendarDay
            // 
            this.pageButtonCalendarDay.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonCalendarDay.Flags = 65535;
            this.pageButtonCalendarDay.LastVisibleSet = true;
            this.pageButtonCalendarDay.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonCalendarDay.Name = "pageButtonCalendarDay";
            this.pageButtonCalendarDay.Size = new System.Drawing.Size(100, 100);
            this.pageButtonCalendarDay.Text = "Calendar Day";
            this.pageButtonCalendarDay.TextDescription = "Calendar Day is used for drawing each day entry within the calendar.";
            this.pageButtonCalendarDay.ToolTipTitle = "Page ToolTip";
            this.pageButtonCalendarDay.UniqueName = "1C1B572BB01A40641C1B572BB01A4064";
            // 
            // pageButtonsButtonSpec
            // 
            this.pageButtonsButtonSpec.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsButtonSpec.Flags = 65535;
            this.pageButtonsButtonSpec.ImageLarge = ((System.Drawing.Image)(resources.GetObject("pageButtonsButtonSpec.ImageLarge")));
            this.pageButtonsButtonSpec.ImageMedium = ((System.Drawing.Image)(resources.GetObject("pageButtonsButtonSpec.ImageMedium")));
            this.pageButtonsButtonSpec.LastVisibleSet = true;
            this.pageButtonsButtonSpec.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsButtonSpec.Name = "pageButtonsButtonSpec";
            this.pageButtonsButtonSpec.Size = new System.Drawing.Size(50, 490);
            this.pageButtonsButtonSpec.Text = "ButtonSpec";
            this.pageButtonsButtonSpec.TextDescription = "ButtonSpec is the default style for buttons created via ButtonSpec collections.";
            this.pageButtonsButtonSpec.ToolTipTitle = "Page ToolTip";
            this.pageButtonsButtonSpec.UniqueName = "31198AD4E0DB40BF31198AD4E0DB40BF";
            // 
            // pageButtonsRibbonCluster
            // 
            this.pageButtonsRibbonCluster.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsRibbonCluster.Flags = 65535;
            this.pageButtonsRibbonCluster.LastVisibleSet = true;
            this.pageButtonsRibbonCluster.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsRibbonCluster.Name = "pageButtonsRibbonCluster";
            this.pageButtonsRibbonCluster.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsRibbonCluster.Text = "Cluster";
            this.pageButtonsRibbonCluster.TextDescription = "Buttons inside a Ribbon cluster have their own style.";
            this.pageButtonsRibbonCluster.ToolTipTitle = "Page ToolTip";
            this.pageButtonsRibbonCluster.UniqueName = "40D019DF2E9A467340D019DF2E9A4673";
            // 
            // pageButtonsNavigatorStack
            // 
            this.pageButtonsNavigatorStack.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsNavigatorStack.Flags = 65535;
            this.pageButtonsNavigatorStack.LastVisibleSet = true;
            this.pageButtonsNavigatorStack.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsNavigatorStack.Name = "pageButtonsNavigatorStack";
            this.pageButtonsNavigatorStack.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsNavigatorStack.Text = "Nav Stack";
            this.pageButtonsNavigatorStack.TextDescription = "Navigator Stack is the default style for stack buttons in the KryptonNavigator.";
            this.pageButtonsNavigatorStack.ToolTipTitle = "Page ToolTip";
            this.pageButtonsNavigatorStack.UniqueName = "4AFE01312A0D4DBB4AFE01312A0D4DBB";
            // 
            // pageButtonsNavigatorOverflow
            // 
            this.pageButtonsNavigatorOverflow.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsNavigatorOverflow.Flags = 65535;
            this.pageButtonsNavigatorOverflow.LastVisibleSet = true;
            this.pageButtonsNavigatorOverflow.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsNavigatorOverflow.Name = "pageButtonsNavigatorOverflow";
            this.pageButtonsNavigatorOverflow.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsNavigatorOverflow.Text = "Nav Overflow";
            this.pageButtonsNavigatorOverflow.TextDescription = "Navigator Overflow is the style for buttons placed on the overflow area of the Ou" +
    "tlook modes.";
            this.pageButtonsNavigatorOverflow.ToolTipTitle = "Page ToolTip";
            this.pageButtonsNavigatorOverflow.UniqueName = "B2269535DD084621B2269535DD084621";
            // 
            // pageButtonsNavigatorMini
            // 
            this.pageButtonsNavigatorMini.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsNavigatorMini.Flags = 65535;
            this.pageButtonsNavigatorMini.LastVisibleSet = true;
            this.pageButtonsNavigatorMini.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsNavigatorMini.Name = "pageButtonsNavigatorMini";
            this.pageButtonsNavigatorMini.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsNavigatorMini.Text = "Nav Mini";
            this.pageButtonsNavigatorMini.TextDescription = "Navigator Mini is the default style for the mini button used in the KryptonNaviga" +
    "tor.";
            this.pageButtonsNavigatorMini.ToolTipTitle = "Page ToolTip";
            this.pageButtonsNavigatorMini.UniqueName = "AD5F157B621F4B10AD5F157B621F4B10";
            // 
            // pageButtonsInputControl
            // 
            this.pageButtonsInputControl.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsInputControl.Flags = 65535;
            this.pageButtonsInputControl.LastVisibleSet = true;
            this.pageButtonsInputControl.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsInputControl.Name = "pageButtonsInputControl";
            this.pageButtonsInputControl.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsInputControl.Text = "Input Control";
            this.pageButtonsInputControl.TextDescription = "Input Control is used as the drop down button inside input controls.";
            this.pageButtonsInputControl.ToolTipTitle = "Page ToolTip";
            this.pageButtonsInputControl.UniqueName = "563FAF44653F46E5563FAF44653F46E5";
            // 
            // pageButtonsListItem
            // 
            this.pageButtonsListItem.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsListItem.Flags = 65535;
            this.pageButtonsListItem.LastVisibleSet = true;
            this.pageButtonsListItem.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsListItem.Name = "pageButtonsListItem";
            this.pageButtonsListItem.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsListItem.Text = "List Item";
            this.pageButtonsListItem.TextDescription = "List Item is used as the display of items inside lists.";
            this.pageButtonsListItem.ToolTipTitle = "Page ToolTip";
            this.pageButtonsListItem.UniqueName = "31BB921AEA374D7E31BB921AEA374D7E";
            // 
            // pageButtonsGallery
            // 
            this.pageButtonsGallery.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsGallery.Flags = 65535;
            this.pageButtonsGallery.LastVisibleSet = true;
            this.pageButtonsGallery.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsGallery.Name = "pageButtonsGallery";
            this.pageButtonsGallery.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsGallery.Text = "Gallery";
            this.pageButtonsGallery.TextDescription = "Gallery is the button style for the three up/down/dropdown control buttons.";
            this.pageButtonsGallery.ToolTipTitle = "Page ToolTip";
            this.pageButtonsGallery.UniqueName = "EF0BB7D061A34A41EF0BB7D061A34A41";
            // 
            // pageButtonsForm
            // 
            this.pageButtonsForm.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsForm.Flags = 65535;
            this.pageButtonsForm.LastVisibleSet = true;
            this.pageButtonsForm.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsForm.Name = "pageButtonsForm";
            this.pageButtonsForm.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsForm.Text = "Form";
            this.pageButtonsForm.TextDescription = "Form style is used as the default for min/max/restore buttons on a KryptonForm.";
            this.pageButtonsForm.ToolTipTitle = "Page ToolTip";
            this.pageButtonsForm.UniqueName = "76C0F19D5CAC4E6B76C0F19D5CAC4E6B";
            // 
            // pageButtonsFormClose
            // 
            this.pageButtonsFormClose.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsFormClose.Flags = 65534;
            this.pageButtonsFormClose.LastVisibleSet = true;
            this.pageButtonsFormClose.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsFormClose.Name = "pageButtonsFormClose";
            this.pageButtonsFormClose.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsFormClose.Text = "Form Close";
            this.pageButtonsFormClose.TextDescription = "Form Close style is used as the default for close buttons on a KryptonForm.";
            this.pageButtonsFormClose.ToolTipTitle = "Page ToolTip";
            this.pageButtonsFormClose.UniqueName = "0655DBDF14BD48A3CEA6FBAEC14F3E64";
            // 
            // pageButtonsCommand
            // 
            this.pageButtonsCommand.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsCommand.Flags = 65534;
            this.pageButtonsCommand.LastVisibleSet = true;
            this.pageButtonsCommand.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsCommand.Name = "pageButtonsCommand";
            this.pageButtonsCommand.Size = new System.Drawing.Size(100, 100);
            this.pageButtonsCommand.Text = "Command";
            this.pageButtonsCommand.TextDescription = "Command style is used for the custom command buttons inside the KryponTaskDialog." +
    "";
            this.pageButtonsCommand.ToolTipTitle = "Page ToolTip";
            this.pageButtonsCommand.UniqueName = "BDF278722644422EF29A3E5CDD9CC5BA";
            // 
            // pageButtonsCustom1
            // 
            this.pageButtonsCustom1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsCustom1.Flags = 65535;
            this.pageButtonsCustom1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("pageButtonsCustom1.ImageLarge")));
            this.pageButtonsCustom1.ImageMedium = ((System.Drawing.Image)(resources.GetObject("pageButtonsCustom1.ImageMedium")));
            this.pageButtonsCustom1.LastVisibleSet = true;
            this.pageButtonsCustom1.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsCustom1.Name = "pageButtonsCustom1";
            this.pageButtonsCustom1.Size = new System.Drawing.Size(50, 490);
            this.pageButtonsCustom1.Text = "Custom 1";
            this.pageButtonsCustom1.TextDescription = "Custom 1 style inherits from Standalone and is intended for your own custom use.";
            this.pageButtonsCustom1.ToolTipTitle = "Page ToolTip";
            this.pageButtonsCustom1.UniqueName = "D5D960581C2941EAD5D960581C2941EA";
            // 
            // pageButtonsCustom2
            // 
            this.pageButtonsCustom2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsCustom2.Flags = 65535;
            this.pageButtonsCustom2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("pageButtonsCustom2.ImageLarge")));
            this.pageButtonsCustom2.ImageMedium = ((System.Drawing.Image)(resources.GetObject("pageButtonsCustom2.ImageMedium")));
            this.pageButtonsCustom2.LastVisibleSet = true;
            this.pageButtonsCustom2.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsCustom2.Name = "pageButtonsCustom2";
            this.pageButtonsCustom2.Size = new System.Drawing.Size(50, 490);
            this.pageButtonsCustom2.Text = "Custom 2";
            this.pageButtonsCustom2.TextDescription = "Custom 2 style inherits from Standalone and is intended for your own custom use.";
            this.pageButtonsCustom2.ToolTipTitle = "Page ToolTip";
            this.pageButtonsCustom2.UniqueName = "B41A275F5EFB4B41B41A275F5EFB4B41";
            // 
            // pageButtonsCustom3
            // 
            this.pageButtonsCustom3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageButtonsCustom3.Flags = 65535;
            this.pageButtonsCustom3.ImageLarge = ((System.Drawing.Image)(resources.GetObject("pageButtonsCustom3.ImageLarge")));
            this.pageButtonsCustom3.ImageMedium = ((System.Drawing.Image)(resources.GetObject("pageButtonsCustom3.ImageMedium")));
            this.pageButtonsCustom3.LastVisibleSet = true;
            this.pageButtonsCustom3.MinimumSize = new System.Drawing.Size(50, 50);
            this.pageButtonsCustom3.Name = "pageButtonsCustom3";
            this.pageButtonsCustom3.Size = new System.Drawing.Size(50, 490);
            this.pageButtonsCustom3.Text = "Custom 3";
            this.pageButtonsCustom3.TextDescription = "Custom 3 style inherits from Standalone and is intended for your own custom use.";
            this.pageButtonsCustom3.ToolTipTitle = "Page ToolTip";
            this.pageButtonsCustom3.UniqueName = "C2E105865C8444A2C2E105865C8444A2";
            // 
            // kryptonPage3
            // 
            this.kryptonPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage3.Controls.Add(this.cbLive);
            this.kryptonPage3.Controls.Add(this.cbFocus);
            this.kryptonPage3.Controls.Add(this.cbIndeterminateTracking);
            this.kryptonPage3.Controls.Add(this.cbIndeterminatePressed);
            this.kryptonPage3.Controls.Add(this.cbIndeterminateNormal);
            this.kryptonPage3.Controls.Add(this.cbIndeterminateDisabled);
            this.kryptonPage3.Controls.Add(this.cbCheckedTracking);
            this.kryptonPage3.Controls.Add(this.cbCheckedPressed);
            this.kryptonPage3.Controls.Add(this.cbCheckedNormal);
            this.kryptonPage3.Controls.Add(this.cbCheckedDisabled);
            this.kryptonPage3.Controls.Add(this.cbUncheckedTracking);
            this.kryptonPage3.Controls.Add(this.cbUncheckedPressed);
            this.kryptonPage3.Controls.Add(this.cbUncheckedNormal);
            this.kryptonPage3.Controls.Add(this.cbUncheckedDisabled);
            this.kryptonPage3.Flags = 65534;
            this.kryptonPage3.LastVisibleSet = true;
            this.kryptonPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage3.Name = "kryptonPage3";
            this.kryptonPage3.Size = new System.Drawing.Size(1083, 669);
            this.kryptonPage3.Text = "Checkbox";
            this.kryptonPage3.ToolTipTitle = "Page ToolTip";
            this.kryptonPage3.UniqueName = "6ae6ebe2e91e4d37b3f0838c2f55fcc5";
            // 
            // cbLive
            // 
            this.cbLive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLive.Checked = true;
            this.cbLive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLive.Location = new System.Drawing.Point(886, 611);
            this.cbLive.Name = "cbLive";
            this.cbLive.Size = new System.Drawing.Size(59, 30);
            this.cbLive.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLive.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLive.TabIndex = 28;
            this.cbLive.ThreeState = true;
            popupPositionValues22.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues22.PlacementTarget = null;
            this.cbLive.ToolTipValues.ToolTipPosition = popupPositionValues22;
            this.cbLive.Values.Text = "Live";
            // 
            // cbFocus
            // 
            this.cbFocus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFocus.Location = new System.Drawing.Point(886, 494);
            this.cbFocus.Name = "cbFocus";
            this.cbFocus.Size = new System.Drawing.Size(75, 30);
            this.cbFocus.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFocus.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFocus.TabIndex = 27;
            popupPositionValues23.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues23.PlacementTarget = null;
            this.cbFocus.ToolTipValues.ToolTipPosition = popupPositionValues23;
            this.cbFocus.Values.Text = "Focus";
            // 
            // cbIndeterminateTracking
            // 
            this.cbIndeterminateTracking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbIndeterminateTracking.Checked = true;
            this.cbIndeterminateTracking.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbIndeterminateTracking.Location = new System.Drawing.Point(373, 417);
            this.cbIndeterminateTracking.Name = "cbIndeterminateTracking";
            this.cbIndeterminateTracking.Size = new System.Drawing.Size(226, 30);
            this.cbIndeterminateTracking.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndeterminateTracking.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndeterminateTracking.TabIndex = 26;
            popupPositionValues24.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues24.PlacementTarget = null;
            this.cbIndeterminateTracking.ToolTipValues.ToolTipPosition = popupPositionValues24;
            this.cbIndeterminateTracking.Values.Text = "Indeterminate Tracking";
            // 
            // cbIndeterminatePressed
            // 
            this.cbIndeterminatePressed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbIndeterminatePressed.Checked = true;
            this.cbIndeterminatePressed.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbIndeterminatePressed.Location = new System.Drawing.Point(373, 613);
            this.cbIndeterminatePressed.Name = "cbIndeterminatePressed";
            this.cbIndeterminatePressed.Size = new System.Drawing.Size(219, 30);
            this.cbIndeterminatePressed.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndeterminatePressed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndeterminatePressed.TabIndex = 25;
            popupPositionValues25.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues25.PlacementTarget = null;
            this.cbIndeterminatePressed.ToolTipValues.ToolTipPosition = popupPositionValues25;
            this.cbIndeterminatePressed.Values.Text = "Indeterminate Pressed";
            // 
            // cbIndeterminateNormal
            // 
            this.cbIndeterminateNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbIndeterminateNormal.Checked = true;
            this.cbIndeterminateNormal.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbIndeterminateNormal.Location = new System.Drawing.Point(373, 222);
            this.cbIndeterminateNormal.Name = "cbIndeterminateNormal";
            this.cbIndeterminateNormal.Size = new System.Drawing.Size(217, 30);
            this.cbIndeterminateNormal.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndeterminateNormal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndeterminateNormal.TabIndex = 24;
            popupPositionValues26.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues26.PlacementTarget = null;
            this.cbIndeterminateNormal.ToolTipValues.ToolTipPosition = popupPositionValues26;
            this.cbIndeterminateNormal.Values.Text = "Indeterminate Normal";
            // 
            // cbIndeterminateDisabled
            // 
            this.cbIndeterminateDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbIndeterminateDisabled.Checked = true;
            this.cbIndeterminateDisabled.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbIndeterminateDisabled.Location = new System.Drawing.Point(373, 27);
            this.cbIndeterminateDisabled.Name = "cbIndeterminateDisabled";
            this.cbIndeterminateDisabled.Size = new System.Drawing.Size(227, 30);
            this.cbIndeterminateDisabled.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndeterminateDisabled.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndeterminateDisabled.TabIndex = 23;
            popupPositionValues27.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues27.PlacementTarget = null;
            this.cbIndeterminateDisabled.ToolTipValues.ToolTipPosition = popupPositionValues27;
            this.cbIndeterminateDisabled.Values.Text = "Indeterminate Disabled";
            // 
            // cbCheckedTracking
            // 
            this.cbCheckedTracking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCheckedTracking.Checked = true;
            this.cbCheckedTracking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCheckedTracking.Location = new System.Drawing.Point(886, 260);
            this.cbCheckedTracking.Name = "cbCheckedTracking";
            this.cbCheckedTracking.Size = new System.Drawing.Size(178, 30);
            this.cbCheckedTracking.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckedTracking.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckedTracking.TabIndex = 22;
            popupPositionValues28.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues28.PlacementTarget = null;
            this.cbCheckedTracking.ToolTipValues.ToolTipPosition = popupPositionValues28;
            this.cbCheckedTracking.Values.Text = "Checked Tracking";
            // 
            // cbCheckedPressed
            // 
            this.cbCheckedPressed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCheckedPressed.Checked = true;
            this.cbCheckedPressed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCheckedPressed.Location = new System.Drawing.Point(886, 377);
            this.cbCheckedPressed.Name = "cbCheckedPressed";
            this.cbCheckedPressed.Size = new System.Drawing.Size(171, 30);
            this.cbCheckedPressed.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckedPressed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckedPressed.TabIndex = 21;
            popupPositionValues29.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues29.PlacementTarget = null;
            this.cbCheckedPressed.ToolTipValues.ToolTipPosition = popupPositionValues29;
            this.cbCheckedPressed.Values.Text = "Checked Pressed";
            // 
            // cbCheckedNormal
            // 
            this.cbCheckedNormal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCheckedNormal.Checked = true;
            this.cbCheckedNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCheckedNormal.Location = new System.Drawing.Point(886, 143);
            this.cbCheckedNormal.Name = "cbCheckedNormal";
            this.cbCheckedNormal.Size = new System.Drawing.Size(170, 30);
            this.cbCheckedNormal.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckedNormal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckedNormal.TabIndex = 20;
            popupPositionValues30.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues30.PlacementTarget = null;
            this.cbCheckedNormal.ToolTipValues.ToolTipPosition = popupPositionValues30;
            this.cbCheckedNormal.Values.Text = "Checked Normal";
            // 
            // cbCheckedDisabled
            // 
            this.cbCheckedDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCheckedDisabled.Checked = true;
            this.cbCheckedDisabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCheckedDisabled.Location = new System.Drawing.Point(886, 26);
            this.cbCheckedDisabled.Name = "cbCheckedDisabled";
            this.cbCheckedDisabled.Size = new System.Drawing.Size(180, 30);
            this.cbCheckedDisabled.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckedDisabled.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckedDisabled.TabIndex = 19;
            popupPositionValues31.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues31.PlacementTarget = null;
            this.cbCheckedDisabled.ToolTipValues.ToolTipPosition = popupPositionValues31;
            this.cbCheckedDisabled.Values.Text = "Checked Disabled";
            // 
            // cbUncheckedTracking
            // 
            this.cbUncheckedTracking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbUncheckedTracking.Location = new System.Drawing.Point(31, 417);
            this.cbUncheckedTracking.Name = "cbUncheckedTracking";
            this.cbUncheckedTracking.Size = new System.Drawing.Size(200, 30);
            this.cbUncheckedTracking.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUncheckedTracking.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUncheckedTracking.TabIndex = 18;
            popupPositionValues32.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues32.PlacementTarget = null;
            this.cbUncheckedTracking.ToolTipValues.ToolTipPosition = popupPositionValues32;
            this.cbUncheckedTracking.Values.Text = "Unchecked Tracking";
            // 
            // cbUncheckedPressed
            // 
            this.cbUncheckedPressed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbUncheckedPressed.Location = new System.Drawing.Point(31, 612);
            this.cbUncheckedPressed.Name = "cbUncheckedPressed";
            this.cbUncheckedPressed.Size = new System.Drawing.Size(193, 30);
            this.cbUncheckedPressed.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUncheckedPressed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUncheckedPressed.TabIndex = 17;
            popupPositionValues33.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues33.PlacementTarget = null;
            this.cbUncheckedPressed.ToolTipValues.ToolTipPosition = popupPositionValues33;
            this.cbUncheckedPressed.Values.Text = "Unchecked Pressed";
            // 
            // cbUncheckedNormal
            // 
            this.cbUncheckedNormal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbUncheckedNormal.Location = new System.Drawing.Point(31, 222);
            this.cbUncheckedNormal.Name = "cbUncheckedNormal";
            this.cbUncheckedNormal.Size = new System.Drawing.Size(191, 30);
            this.cbUncheckedNormal.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUncheckedNormal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUncheckedNormal.TabIndex = 16;
            popupPositionValues34.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues34.PlacementTarget = null;
            this.cbUncheckedNormal.ToolTipValues.ToolTipPosition = popupPositionValues34;
            this.cbUncheckedNormal.Values.Text = "Unchecked Normal";
            // 
            // cbUncheckedDisabled
            // 
            this.cbUncheckedDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbUncheckedDisabled.Location = new System.Drawing.Point(31, 27);
            this.cbUncheckedDisabled.Name = "cbUncheckedDisabled";
            this.cbUncheckedDisabled.Size = new System.Drawing.Size(201, 30);
            this.cbUncheckedDisabled.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUncheckedDisabled.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUncheckedDisabled.TabIndex = 15;
            popupPositionValues35.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues35.PlacementTarget = null;
            this.cbUncheckedDisabled.ToolTipValues.ToolTipPosition = popupPositionValues35;
            this.cbUncheckedDisabled.Values.Text = "Unchecked Disabled";
            // 
            // kryptonPage4
            // 
            this.kryptonPage4.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage4.Flags = 65534;
            this.kryptonPage4.LastVisibleSet = true;
            this.kryptonPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage4.Name = "kryptonPage4";
            this.kryptonPage4.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage4.Text = "kryptonPage4";
            this.kryptonPage4.ToolTipTitle = "Page ToolTip";
            this.kryptonPage4.UniqueName = "fc604ee1daa04251889d3f8bf2251f77";
            // 
            // kryptonPage5
            // 
            this.kryptonPage5.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage5.Flags = 65534;
            this.kryptonPage5.LastVisibleSet = true;
            this.kryptonPage5.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage5.Name = "kryptonPage5";
            this.kryptonPage5.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage5.Text = "kryptonPage5";
            this.kryptonPage5.ToolTipTitle = "Page ToolTip";
            this.kryptonPage5.UniqueName = "8ebe0a6079094b1581fcafb9b8dd11db";
            // 
            // kryptonPage6
            // 
            this.kryptonPage6.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage6.Flags = 65534;
            this.kryptonPage6.LastVisibleSet = true;
            this.kryptonPage6.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage6.Name = "kryptonPage6";
            this.kryptonPage6.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage6.Text = "kryptonPage6";
            this.kryptonPage6.ToolTipTitle = "Page ToolTip";
            this.kryptonPage6.UniqueName = "193d44e36ecf40999ebc062df1c0a805";
            // 
            // kryptonPage7
            // 
            this.kryptonPage7.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage7.Flags = 65534;
            this.kryptonPage7.LastVisibleSet = true;
            this.kryptonPage7.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage7.Name = "kryptonPage7";
            this.kryptonPage7.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage7.Text = "kryptonPage7";
            this.kryptonPage7.ToolTipTitle = "Page ToolTip";
            this.kryptonPage7.UniqueName = "05e3ab6a09624a2795856d71db795cbf";
            // 
            // kryptonPage8
            // 
            this.kryptonPage8.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage8.Flags = 65534;
            this.kryptonPage8.LastVisibleSet = true;
            this.kryptonPage8.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage8.Name = "kryptonPage8";
            this.kryptonPage8.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage8.Text = "kryptonPage8";
            this.kryptonPage8.ToolTipTitle = "Page ToolTip";
            this.kryptonPage8.UniqueName = "b5955dae8ee84876962e3fdc71d42b95";
            // 
            // PaletteExplorerWindow
            // 
            this.ClientSize = new System.Drawing.Size(1085, 833);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kpnlStatusStrip);
            this.Controls.Add(this.krControls);
            this.Name = "PaletteExplorerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.krControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlStatusStrip)).EndInit();
            this.kpnlStatusStrip.ResumeLayout(false);
            this.kpnlStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kdnPaletteExplorer)).EndInit();
            this.kdnPaletteExplorer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.kryptonPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            this.kryptonPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigatorDesignButtons)).EndInit();
            this.kryptonNavigatorDesignButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsStandalone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsAlternate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsLowProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsBreadCrumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonCalendarDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsButtonSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsRibbonCluster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsNavigatorStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsNavigatorOverflow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsNavigatorMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsInputControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsGallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsFormClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsCustom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsCustom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageButtonsCustom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).EndInit();
            this.kryptonPage3.ResumeLayout(false);
            this.kryptonPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}