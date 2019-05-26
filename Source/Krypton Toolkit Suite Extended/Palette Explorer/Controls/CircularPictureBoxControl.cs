using Core;
using ExtendedControls.ExtendedToolkit.Controls;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using PaletteExplorer.Classes;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using ToolkitSettings.Classes.PaletteExplorer.Colours;

namespace PaletteExplorer.Controls
{
    public class CircularPictureBoxControl : UserControl
    {
        #region Designer Code
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbCircularColourPreviewPane;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomTextColourSixPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxCustomColourSixPreview;
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
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxMediumColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxDarkColourPreview;
        private ContextMenuStrip ctxBaseColour;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem useBaseColourAsBaseToolStripMenuItem;
        private ContextMenuStrip ctxMediumColour;
        private ToolStripMenuItem tsmiMediumColour;
        private ContextMenuStrip ctxLightColour;
        private ToolStripMenuItem tsmiLightColour;
        private ContextMenuStrip ctxLightestColour;
        private ToolStripMenuItem tsmiLightestColour;
        private ContextMenuStrip ctxAlternativeNormalTextColour;
        private ToolStripMenuItem tsmiAlternativeNormalTextColour;
        private ContextMenuStrip ctxBorderColour;
        private ToolStripMenuItem tsmiBorderColour;
        private ContextMenuStrip ctxNormalTextColour;
        private ToolStripMenuItem tsmiNormalTextColour;
        private ContextMenuStrip ctxLinkNormalTextColour;
        private ToolStripMenuItem tsmiLinkNormalTextColour;
        private ContextMenuStrip ctxDisabledControlColour;
        private ToolStripMenuItem tsmiDisabledControlColour;
        private ContextMenuStrip ctxDisabedTextColour;
        private ToolStripMenuItem tsmiDisabledTextColour;
        private ContextMenuStrip ctxFocusedTextColour;
        private ToolStripMenuItem tsmiFocusedTextColour;
        private ContextMenuStrip ctxPressedTextColour;
        private ToolStripMenuItem tsmiPressedTextColour;
        private ContextMenuStrip ctxLinkHoverTextColour;
        private ToolStripMenuItem tsmiLinkHoverTextColour;
        private ContextMenuStrip ctxCustomColourFourColour;
        private ToolStripMenuItem tsmiCustomColourFourColour;
        private ContextMenuStrip ctxDarkColour;
        private ToolStripMenuItem tsiDarkColour;
        private ContextMenuStrip ctxCustomColourThreeColour;
        private ToolStripMenuItem tsmiCustomColourThreeColour;
        private ContextMenuStrip ctxCustomColourOneColour;
        private ToolStripMenuItem tsmiCustomColourOneColour;
        private ContextMenuStrip ctxCustomColourTwoColour;
        private ToolStripMenuItem tsmiCustomColourTwoColour;
        private ContextMenuStrip ctxCustomColourFiveColour;
        private ToolStripMenuItem tsmlCustomColourFiveColour;
        private ContextMenuStrip ctxCustomTextColourOneColour;
        private ToolStripMenuItem tsmiCustomTextColourOneColour;
        private ContextMenuStrip ctxCustomTextColourFiveColour;
        private ToolStripMenuItem tsmiCustomTextColourFiveColour;
        private ContextMenuStrip ctxCustomTextColourFourColour;
        private ToolStripMenuItem tsmiCustomTextColourFourColour;
        private ContextMenuStrip ctxMenuTextColour;
        private ToolStripMenuItem tsmiMenuTextColour;
        private ContextMenuStrip ctxCustomTextColourTwoColour;
        private ToolStripMenuItem tsmiCustomTextColourTwoColour;
        private ContextMenuStrip ctxCustomTextColourThreeColour;
        private ToolStripMenuItem tsmiCustomTextColourThreeColour;
        private ContextMenuStrip ctxStatusStripTextColour;
        private ToolStripMenuItem tsmiStatusStripTextColour;
        private ContextMenuStrip ctxLinkFocusedTextColour;
        private ToolStripMenuItem tsmiLinkFocusedTextColour;
        private ContextMenuStrip ctxRibbonTabTextColour;
        private ToolStripMenuItem tsmiRibbonTabTextColour;
        private ContextMenuStrip ctxCustomColourSixColour;
        private ToolStripMenuItem tsmiCustomColourSixColour;
        private ContextMenuStrip ctxLinkVisitedTextColour;
        private ToolStripMenuItem tsmiLinkVisitedTextColour;
        private ContextMenuStrip ctxCustomTextColourSixColour;
        private ToolStripMenuItem tsmiCustomTextColourSixColour;
        private CircularPictureBox cbxLinkDisabledColourPreview;
        private ContextMenuStrip ctxLinkDisabledTextColour;
        private ToolStripMenuItem useLinkDisabledTextColourAsBaseToolStripMenuItem;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxBaseColourPreview;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kgbCircularColourPreviewPane = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cbxLinkDisabledColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxLinkDisabledTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.useLinkDisabledTextColourAsBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCustomTextColourSixPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxCustomColourSixPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
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
            this.cbxMediumColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxDarkColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxBaseColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ctxBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.useBaseColourAsBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMediumColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMediumColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLightColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLightColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLightestColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLightestColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxAlternativeNormalTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAlternativeNormalTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBorderColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBorderColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxNormalTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNormalTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLinkNormalTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLinkNormalTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDisabledControlColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDisabledControlColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDisabedTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDisabledTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFocusedTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFocusedTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPressedTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPressedTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLinkHoverTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLinkHoverTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourFourColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomColourFourColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDarkColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiDarkColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourThreeColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomColourThreeColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourOneColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomColourOneColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourTwoColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomColourTwoColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourFiveColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmlCustomColourFiveColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourOneColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourOneColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourFiveColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourFiveColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourFourColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourFourColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMenuTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourTwoColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourTwoColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourThreeColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourThreeColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxStatusStripTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiStatusStripTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLinkFocusedTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLinkFocusedTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxRibbonTabTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRibbonTabTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourSixColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomColourSixColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLinkVisitedTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLinkVisitedTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourSixColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourSixColour = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane.Panel)).BeginInit();
            this.kgbCircularColourPreviewPane.Panel.SuspendLayout();
            this.kgbCircularColourPreviewPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkDisabledColourPreview)).BeginInit();
            this.ctxLinkDisabledTextColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourSixPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourSixPreview)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbxMediumColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBaseColourPreview)).BeginInit();
            this.ctxBaseColour.SuspendLayout();
            this.ctxMediumColour.SuspendLayout();
            this.ctxLightColour.SuspendLayout();
            this.ctxLightestColour.SuspendLayout();
            this.ctxAlternativeNormalTextColour.SuspendLayout();
            this.ctxBorderColour.SuspendLayout();
            this.ctxNormalTextColour.SuspendLayout();
            this.ctxLinkNormalTextColour.SuspendLayout();
            this.ctxDisabledControlColour.SuspendLayout();
            this.ctxDisabedTextColour.SuspendLayout();
            this.ctxFocusedTextColour.SuspendLayout();
            this.ctxPressedTextColour.SuspendLayout();
            this.ctxLinkHoverTextColour.SuspendLayout();
            this.ctxCustomColourFourColour.SuspendLayout();
            this.ctxDarkColour.SuspendLayout();
            this.ctxCustomColourThreeColour.SuspendLayout();
            this.ctxCustomColourOneColour.SuspendLayout();
            this.ctxCustomColourTwoColour.SuspendLayout();
            this.ctxCustomColourFiveColour.SuspendLayout();
            this.ctxCustomTextColourOneColour.SuspendLayout();
            this.ctxCustomTextColourFiveColour.SuspendLayout();
            this.ctxCustomTextColourFourColour.SuspendLayout();
            this.ctxMenuTextColour.SuspendLayout();
            this.ctxCustomTextColourTwoColour.SuspendLayout();
            this.ctxCustomTextColourThreeColour.SuspendLayout();
            this.ctxStatusStripTextColour.SuspendLayout();
            this.ctxLinkFocusedTextColour.SuspendLayout();
            this.ctxRibbonTabTextColour.SuspendLayout();
            this.ctxCustomColourSixColour.SuspendLayout();
            this.ctxLinkVisitedTextColour.SuspendLayout();
            this.ctxCustomTextColourSixColour.SuspendLayout();
            this.SuspendLayout();
            // 
            // kgbCircularColourPreviewPane
            // 
            this.kgbCircularColourPreviewPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kgbCircularColourPreviewPane.Location = new System.Drawing.Point(0, 0);
            this.kgbCircularColourPreviewPane.Name = "kgbCircularColourPreviewPane";
            // 
            // kgbCircularColourPreviewPane.Panel
            // 
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxLinkDisabledColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomTextColourSixPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxCustomColourSixPreview);
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
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxMediumColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxDarkColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxBaseColourPreview);
            this.kgbCircularColourPreviewPane.Size = new System.Drawing.Size(1625, 660);
            this.kgbCircularColourPreviewPane.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbCircularColourPreviewPane.TabIndex = 40;
            this.kgbCircularColourPreviewPane.Values.Heading = "Colour Preview";
            // 
            // cbxLinkDisabledColourPreview
            // 
            this.cbxLinkDisabledColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkDisabledColourPreview.ContextMenuStrip = this.ctxLinkDisabledTextColour;
            this.cbxLinkDisabledColourPreview.Location = new System.Drawing.Point(1284, 147);
            this.cbxLinkDisabledColourPreview.Name = "cbxLinkDisabledColourPreview";
            this.cbxLinkDisabledColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkDisabledColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkDisabledColourPreview.TabIndex = 57;
            this.cbxLinkDisabledColourPreview.TabStop = false;
            this.cbxLinkDisabledColourPreview.MouseEnter += new System.EventHandler(this.CbxLinkDisabledColourPreview_MouseEnter);
            // 
            // ctxLinkDisabledTextColour
            // 
            this.ctxLinkDisabledTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLinkDisabledTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useLinkDisabledTextColourAsBaseToolStripMenuItem});
            this.ctxLinkDisabledTextColour.Name = "ctxLinkDisabledTextColour";
            this.ctxLinkDisabledTextColour.Size = new System.Drawing.Size(271, 26);
            // 
            // useLinkDisabledTextColourAsBaseToolStripMenuItem
            // 
            this.useLinkDisabledTextColourAsBaseToolStripMenuItem.Name = "useLinkDisabledTextColourAsBaseToolStripMenuItem";
            this.useLinkDisabledTextColourAsBaseToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.useLinkDisabledTextColourAsBaseToolStripMenuItem.Text = "Use Lin&k Disabled Text Colour as Base";
            // 
            // cbxCustomTextColourSixPreview
            // 
            this.cbxCustomTextColourSixPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourSixPreview.Location = new System.Drawing.Point(19, 549);
            this.cbxCustomTextColourSixPreview.Name = "cbxCustomTextColourSixPreview";
            this.cbxCustomTextColourSixPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourSixPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourSixPreview.TabIndex = 56;
            this.cbxCustomTextColourSixPreview.TabStop = false;
            this.cbxCustomTextColourSixPreview.MouseEnter += new System.EventHandler(this.CbxCustomTextColourSixPreview_MouseEnter);
            // 
            // cbxCustomColourSixPreview
            // 
            this.cbxCustomColourSixPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourSixPreview.Location = new System.Drawing.Point(272, 413);
            this.cbxCustomColourSixPreview.Name = "cbxCustomColourSixPreview";
            this.cbxCustomColourSixPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourSixPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourSixPreview.TabIndex = 55;
            this.cbxCustomColourSixPreview.TabStop = false;
            this.cbxCustomColourSixPreview.MouseEnter += new System.EventHandler(this.CbxCustomColourSixPreview_MouseEnter);
            // 
            // cbxRibbonTabTextColourPreview
            // 
            this.cbxRibbonTabTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxRibbonTabTextColourPreview.Location = new System.Drawing.Point(778, 549);
            this.cbxRibbonTabTextColourPreview.Name = "cbxRibbonTabTextColourPreview";
            this.cbxRibbonTabTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxRibbonTabTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxRibbonTabTextColourPreview.TabIndex = 54;
            this.cbxRibbonTabTextColourPreview.TabStop = false;
            this.cbxRibbonTabTextColourPreview.MouseEnter += new System.EventHandler(this.CbxRibbonTabTextColourPreview_MouseEnter);
            // 
            // cbxLinkFocusedColourPreview
            // 
            this.cbxLinkFocusedColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkFocusedColourPreview.Location = new System.Drawing.Point(19, 280);
            this.cbxLinkFocusedColourPreview.Name = "cbxLinkFocusedColourPreview";
            this.cbxLinkFocusedColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkFocusedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkFocusedColourPreview.TabIndex = 53;
            this.cbxLinkFocusedColourPreview.TabStop = false;
            this.cbxLinkFocusedColourPreview.MouseEnter += new System.EventHandler(this.CbxLinkFocusedColourPreview_MouseEnter);
            // 
            // cbxStatusTextColourPreview
            // 
            this.cbxStatusTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxStatusTextColourPreview.Location = new System.Drawing.Point(525, 549);
            this.cbxStatusTextColourPreview.Name = "cbxStatusTextColourPreview";
            this.cbxStatusTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxStatusTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxStatusTextColourPreview.TabIndex = 52;
            this.cbxStatusTextColourPreview.TabStop = false;
            this.cbxStatusTextColourPreview.MouseEnter += new System.EventHandler(this.CbxStatusTextColourPreview_MouseEnter);
            // 
            // cbxCustomTextColourThreePreview
            // 
            this.cbxCustomTextColourThreePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourThreePreview.Location = new System.Drawing.Point(1031, 413);
            this.cbxCustomTextColourThreePreview.Name = "cbxCustomTextColourThreePreview";
            this.cbxCustomTextColourThreePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourThreePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourThreePreview.TabIndex = 51;
            this.cbxCustomTextColourThreePreview.TabStop = false;
            this.cbxCustomTextColourThreePreview.MouseEnter += new System.EventHandler(this.CbxCustomTextColourThreePreview_MouseEnter);
            // 
            // cbxCustomTextColourTwoPreview
            // 
            this.cbxCustomTextColourTwoPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourTwoPreview.Location = new System.Drawing.Point(778, 413);
            this.cbxCustomTextColourTwoPreview.Name = "cbxCustomTextColourTwoPreview";
            this.cbxCustomTextColourTwoPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourTwoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourTwoPreview.TabIndex = 50;
            this.cbxCustomTextColourTwoPreview.TabStop = false;
            this.cbxCustomTextColourTwoPreview.MouseEnter += new System.EventHandler(this.CbxCustomTextColourTwoPreview_MouseEnter);
            // 
            // cbxMenuTextColourPreview
            // 
            this.cbxMenuTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxMenuTextColourPreview.Location = new System.Drawing.Point(272, 549);
            this.cbxMenuTextColourPreview.Name = "cbxMenuTextColourPreview";
            this.cbxMenuTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxMenuTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxMenuTextColourPreview.TabIndex = 49;
            this.cbxMenuTextColourPreview.TabStop = false;
            this.cbxMenuTextColourPreview.MouseEnter += new System.EventHandler(this.CbxMenuTextColourPreview_MouseEnter);
            // 
            // cbxCustomTextColourFourPreview
            // 
            this.cbxCustomTextColourFourPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourFourPreview.Location = new System.Drawing.Point(1284, 413);
            this.cbxCustomTextColourFourPreview.Name = "cbxCustomTextColourFourPreview";
            this.cbxCustomTextColourFourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourFourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourFourPreview.TabIndex = 48;
            this.cbxCustomTextColourFourPreview.TabStop = false;
            this.cbxCustomTextColourFourPreview.MouseEnter += new System.EventHandler(this.CbxCustomTextColourFourPreview_MouseEnter);
            // 
            // cbxCustomTextColourFivePreview
            // 
            this.cbxCustomTextColourFivePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourFivePreview.Location = new System.Drawing.Point(1537, 413);
            this.cbxCustomTextColourFivePreview.Name = "cbxCustomTextColourFivePreview";
            this.cbxCustomTextColourFivePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourFivePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourFivePreview.TabIndex = 47;
            this.cbxCustomTextColourFivePreview.TabStop = false;
            this.cbxCustomTextColourFivePreview.MouseEnter += new System.EventHandler(this.CbxCustomTextColourFivePreview_MouseEnter);
            // 
            // cbxCustomTextColourOnePreview
            // 
            this.cbxCustomTextColourOnePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourOnePreview.Location = new System.Drawing.Point(525, 413);
            this.cbxCustomTextColourOnePreview.Name = "cbxCustomTextColourOnePreview";
            this.cbxCustomTextColourOnePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourOnePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourOnePreview.TabIndex = 46;
            this.cbxCustomTextColourOnePreview.TabStop = false;
            this.cbxCustomTextColourOnePreview.MouseEnter += new System.EventHandler(this.CbxCustomTextColourOnePreview_MouseEnter);
            // 
            // cbxCustomColourFivePreview
            // 
            this.cbxCustomColourFivePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourFivePreview.Location = new System.Drawing.Point(19, 413);
            this.cbxCustomColourFivePreview.Name = "cbxCustomColourFivePreview";
            this.cbxCustomColourFivePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourFivePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourFivePreview.TabIndex = 45;
            this.cbxCustomColourFivePreview.TabStop = false;
            this.cbxCustomColourFivePreview.MouseEnter += new System.EventHandler(this.CbxCustomColourFivePreview_MouseEnter);
            // 
            // cbxCustomColourTwoPreview
            // 
            this.cbxCustomColourTwoPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourTwoPreview.Location = new System.Drawing.Point(1031, 280);
            this.cbxCustomColourTwoPreview.Name = "cbxCustomColourTwoPreview";
            this.cbxCustomColourTwoPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourTwoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourTwoPreview.TabIndex = 44;
            this.cbxCustomColourTwoPreview.TabStop = false;
            this.cbxCustomColourTwoPreview.MouseEnter += new System.EventHandler(this.CbxCustomColourTwoPreview_MouseEnter);
            // 
            // cbxCustomColourOnePreview
            // 
            this.cbxCustomColourOnePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourOnePreview.Location = new System.Drawing.Point(778, 280);
            this.cbxCustomColourOnePreview.Name = "cbxCustomColourOnePreview";
            this.cbxCustomColourOnePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourOnePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourOnePreview.TabIndex = 43;
            this.cbxCustomColourOnePreview.TabStop = false;
            this.cbxCustomColourOnePreview.MouseEnter += new System.EventHandler(this.CbxCustomColourOnePreview_MouseEnter);
            // 
            // cbxLinkVisitedColourPreview
            // 
            this.cbxLinkVisitedColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkVisitedColourPreview.Location = new System.Drawing.Point(525, 280);
            this.cbxLinkVisitedColourPreview.Name = "cbxLinkVisitedColourPreview";
            this.cbxLinkVisitedColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkVisitedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkVisitedColourPreview.TabIndex = 42;
            this.cbxLinkVisitedColourPreview.TabStop = false;
            this.cbxLinkVisitedColourPreview.MouseEnter += new System.EventHandler(this.CbxLinkVisitedColourPreview_MouseEnter);
            // 
            // cbxCustomColourThreePreview
            // 
            this.cbxCustomColourThreePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourThreePreview.Location = new System.Drawing.Point(1284, 280);
            this.cbxCustomColourThreePreview.Name = "cbxCustomColourThreePreview";
            this.cbxCustomColourThreePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourThreePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourThreePreview.TabIndex = 41;
            this.cbxCustomColourThreePreview.TabStop = false;
            this.cbxCustomColourThreePreview.MouseEnter += new System.EventHandler(this.CbxCustomColourThreePreview_MouseEnter);
            // 
            // cbxCustomColourFourPreview
            // 
            this.cbxCustomColourFourPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourFourPreview.Location = new System.Drawing.Point(1537, 280);
            this.cbxCustomColourFourPreview.Name = "cbxCustomColourFourPreview";
            this.cbxCustomColourFourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourFourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourFourPreview.TabIndex = 40;
            this.cbxCustomColourFourPreview.TabStop = false;
            this.cbxCustomColourFourPreview.MouseEnter += new System.EventHandler(this.CbxCustomColourFourPreview_MouseEnter);
            // 
            // cbxLinkHoverColourPreview
            // 
            this.cbxLinkHoverColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkHoverColourPreview.Location = new System.Drawing.Point(272, 280);
            this.cbxLinkHoverColourPreview.Name = "cbxLinkHoverColourPreview";
            this.cbxLinkHoverColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkHoverColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkHoverColourPreview.TabIndex = 39;
            this.cbxLinkHoverColourPreview.TabStop = false;
            this.cbxLinkHoverColourPreview.MouseEnter += new System.EventHandler(this.CbxLinkHoverColourPreview_MouseEnter);
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
            this.cbxPressedTextColourPreview.MouseEnter += new System.EventHandler(this.CbxPressedTextColourPreview_MouseEnter);
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
            this.cbxFocusedTextColourPreview.MouseEnter += new System.EventHandler(this.CbxFocusedTextColourPreview_MouseEnter);
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
            this.cbxDisabledTextColourPreview.MouseEnter += new System.EventHandler(this.CbxDisabledTextColourPreview_MouseEnter);
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
            this.cbxDisabledControlColourPreview.MouseEnter += new System.EventHandler(this.CbxDisabledControlColourPreview_MouseEnter);
            // 
            // cbxLinkNormalColourPreview
            // 
            this.cbxLinkNormalColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxLinkNormalColourPreview.Location = new System.Drawing.Point(1537, 147);
            this.cbxLinkNormalColourPreview.Name = "cbxLinkNormalColourPreview";
            this.cbxLinkNormalColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxLinkNormalColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxLinkNormalColourPreview.TabIndex = 34;
            this.cbxLinkNormalColourPreview.TabStop = false;
            this.cbxLinkNormalColourPreview.MouseEnter += new System.EventHandler(this.CbxLinkNormalColourPreview_MouseEnter);
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
            this.cbxNormalTextColourPreview.MouseEnter += new System.EventHandler(this.CbxNormalTextColourPreview_MouseEnter);
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
            this.cbxBorderColourPreview.MouseEnter += new System.EventHandler(this.CbxBorderColourPreview_MouseEnter);
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
            this.cbxAlternativeNormalTextColourPreview.MouseEnter += new System.EventHandler(this.CbxAlternativeNormalTextColourPreview_MouseEnter);
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
            this.cbxLightestColourPreview.MouseEnter += new System.EventHandler(this.CbxLightestColourPreview_MouseEnter);
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
            this.cbxLightColourPreview.MouseEnter += new System.EventHandler(this.CbxLightColourPreview_MouseEnter);
            // 
            // cbxMediumColourPreview
            // 
            this.cbxMediumColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxMediumColourPreview.Location = new System.Drawing.Point(525, 15);
            this.cbxMediumColourPreview.Name = "cbxMediumColourPreview";
            this.cbxMediumColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxMediumColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxMediumColourPreview.TabIndex = 28;
            this.cbxMediumColourPreview.TabStop = false;
            this.cbxMediumColourPreview.MouseEnter += new System.EventHandler(this.CbxMediumColourPreview_MouseEnter);
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
            this.cbxDarkColourPreview.MouseEnter += new System.EventHandler(this.CbxDarkColourPreview_MouseEnter);
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
            this.cbxBaseColourPreview.MouseEnter += new System.EventHandler(this.CbxBaseColourPreview_MouseEnter);
            // 
            // ctxBaseColour
            // 
            this.ctxBaseColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxBaseColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useBaseColourAsBaseToolStripMenuItem});
            this.ctxBaseColour.Name = "ctxBaseColour";
            this.ctxBaseColour.Size = new System.Drawing.Size(201, 26);
            // 
            // useBaseColourAsBaseToolStripMenuItem
            // 
            this.useBaseColourAsBaseToolStripMenuItem.Name = "useBaseColourAsBaseToolStripMenuItem";
            this.useBaseColourAsBaseToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.useBaseColourAsBaseToolStripMenuItem.Text = "Use &Base Colour as Base";
            this.useBaseColourAsBaseToolStripMenuItem.Click += new System.EventHandler(this.UseBaseColourAsBaseToolStripMenuItem_Click);
            // 
            // ctxMediumColour
            // 
            this.ctxMediumColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxMediumColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMediumColour});
            this.ctxMediumColour.Name = "ctxBaseColour";
            this.ctxMediumColour.Size = new System.Drawing.Size(222, 26);
            // 
            // tsmiMediumColour
            // 
            this.tsmiMediumColour.Name = "tsmiMediumColour";
            this.tsmiMediumColour.Size = new System.Drawing.Size(221, 22);
            this.tsmiMediumColour.Text = "Use &Medium Colour as Base";
            this.tsmiMediumColour.Click += new System.EventHandler(this.TsmiMediumColour_Click);
            // 
            // ctxLightColour
            // 
            this.ctxLightColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLightColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLightColour});
            this.ctxLightColour.Name = "ctxBaseColour";
            this.ctxLightColour.Size = new System.Drawing.Size(204, 26);
            // 
            // tsmiLightColour
            // 
            this.tsmiLightColour.Name = "tsmiLightColour";
            this.tsmiLightColour.Size = new System.Drawing.Size(203, 22);
            this.tsmiLightColour.Text = "Use &Light Colour as Base";
            this.tsmiLightColour.Click += new System.EventHandler(this.TsmiLightColour_Click);
            // 
            // ctxLightestColour
            // 
            this.ctxLightestColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLightestColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLightestColour});
            this.ctxLightestColour.Name = "ctxBaseColour";
            this.ctxLightestColour.Size = new System.Drawing.Size(219, 26);
            // 
            // tsmiLightestColour
            // 
            this.tsmiLightestColour.Name = "tsmiLightestColour";
            this.tsmiLightestColour.Size = new System.Drawing.Size(218, 22);
            this.tsmiLightestColour.Text = "Use &Lightest Colour as Base";
            this.tsmiLightestColour.Click += new System.EventHandler(this.TsmiLightestColour_Click);
            // 
            // ctxAlternativeNormalTextColour
            // 
            this.ctxAlternativeNormalTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxAlternativeNormalTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAlternativeNormalTextColour});
            this.ctxAlternativeNormalTextColour.Name = "ctxBaseColour";
            this.ctxAlternativeNormalTextColour.Size = new System.Drawing.Size(301, 26);
            // 
            // tsmiAlternativeNormalTextColour
            // 
            this.tsmiAlternativeNormalTextColour.Name = "tsmiAlternativeNormalTextColour";
            this.tsmiAlternativeNormalTextColour.Size = new System.Drawing.Size(300, 22);
            this.tsmiAlternativeNormalTextColour.Text = "Use &Alternative Normal Text Colour as Base";
            this.tsmiAlternativeNormalTextColour.Click += new System.EventHandler(this.TsmiAlternativeNormalTextColour_Click);
            // 
            // ctxBorderColour
            // 
            this.ctxBorderColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxBorderColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBorderColour});
            this.ctxBorderColour.Name = "ctxBaseColour";
            this.ctxBorderColour.Size = new System.Drawing.Size(212, 26);
            // 
            // tsmiBorderColour
            // 
            this.tsmiBorderColour.Name = "tsmiBorderColour";
            this.tsmiBorderColour.Size = new System.Drawing.Size(211, 22);
            this.tsmiBorderColour.Text = "Use &Border Colour as Base";
            this.tsmiBorderColour.Click += new System.EventHandler(this.TsmiBorderColour_Click);
            // 
            // ctxNormalTextColour
            // 
            this.ctxNormalTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxNormalTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNormalTextColour});
            this.ctxNormalTextColour.Name = "ctxBaseColour";
            this.ctxNormalTextColour.Size = new System.Drawing.Size(241, 26);
            // 
            // tsmiNormalTextColour
            // 
            this.tsmiNormalTextColour.Name = "tsmiNormalTextColour";
            this.tsmiNormalTextColour.Size = new System.Drawing.Size(240, 22);
            this.tsmiNormalTextColour.Text = "Use &Normal Text Colour as Base";
            this.tsmiNormalTextColour.Click += new System.EventHandler(this.TsmiNormalTextColour_Click);
            // 
            // ctxLinkNormalTextColour
            // 
            this.ctxLinkNormalTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLinkNormalTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLinkNormalTextColour});
            this.ctxLinkNormalTextColour.Name = "ctxBaseColour";
            this.ctxLinkNormalTextColour.Size = new System.Drawing.Size(266, 26);
            // 
            // tsmiLinkNormalTextColour
            // 
            this.tsmiLinkNormalTextColour.Name = "tsmiLinkNormalTextColour";
            this.tsmiLinkNormalTextColour.Size = new System.Drawing.Size(265, 22);
            this.tsmiLinkNormalTextColour.Text = "Use Link &Normal Text Colour as Base";
            this.tsmiLinkNormalTextColour.Click += new System.EventHandler(this.TsmiLinkNormalTextColour_Click);
            // 
            // ctxDisabledControlColour
            // 
            this.ctxDisabledControlColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxDisabledControlColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDisabledControlColour});
            this.ctxDisabledControlColour.Name = "ctxBaseColour";
            this.ctxDisabledControlColour.Size = new System.Drawing.Size(265, 26);
            // 
            // tsmiDisabledControlColour
            // 
            this.tsmiDisabledControlColour.Name = "tsmiDisabledControlColour";
            this.tsmiDisabledControlColour.Size = new System.Drawing.Size(264, 22);
            this.tsmiDisabledControlColour.Text = "Use &Disabled Control Colour as Base";
            this.tsmiDisabledControlColour.Click += new System.EventHandler(this.TsmiDisabledControlColour_Click);
            // 
            // ctxDisabedTextColour
            // 
            this.ctxDisabedTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxDisabedTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDisabledTextColour});
            this.ctxDisabedTextColour.Name = "ctxBaseColour";
            this.ctxDisabedTextColour.Size = new System.Drawing.Size(246, 26);
            // 
            // tsmiDisabledTextColour
            // 
            this.tsmiDisabledTextColour.Name = "tsmiDisabledTextColour";
            this.tsmiDisabledTextColour.Size = new System.Drawing.Size(245, 22);
            this.tsmiDisabledTextColour.Text = "Use &Disabled Text Colour as Base";
            this.tsmiDisabledTextColour.Click += new System.EventHandler(this.TsmiDisabledTextColour_Click);
            // 
            // ctxFocusedTextColour
            // 
            this.ctxFocusedTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxFocusedTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFocusedTextColour});
            this.ctxFocusedTextColour.Name = "ctxBaseColour";
            this.ctxFocusedTextColour.Size = new System.Drawing.Size(245, 26);
            // 
            // tsmiFocusedTextColour
            // 
            this.tsmiFocusedTextColour.Name = "tsmiFocusedTextColour";
            this.tsmiFocusedTextColour.Size = new System.Drawing.Size(244, 22);
            this.tsmiFocusedTextColour.Text = "Use &Focused Text Colour as Base";
            this.tsmiFocusedTextColour.Click += new System.EventHandler(this.TsmiFocusedTextColour_Click);
            // 
            // ctxPressedTextColour
            // 
            this.ctxPressedTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxPressedTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPressedTextColour});
            this.ctxPressedTextColour.Name = "ctxBaseColour";
            this.ctxPressedTextColour.Size = new System.Drawing.Size(241, 26);
            // 
            // tsmiPressedTextColour
            // 
            this.tsmiPressedTextColour.Name = "tsmiPressedTextColour";
            this.tsmiPressedTextColour.Size = new System.Drawing.Size(240, 22);
            this.tsmiPressedTextColour.Text = "Use &Pressed Text Colour as Base";
            this.tsmiPressedTextColour.Click += new System.EventHandler(this.TsmiPressedTextColour_Click);
            // 
            // ctxLinkHoverTextColour
            // 
            this.ctxLinkHoverTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLinkHoverTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLinkHoverTextColour});
            this.ctxLinkHoverTextColour.Name = "ctxBaseColour";
            this.ctxLinkHoverTextColour.Size = new System.Drawing.Size(258, 26);
            // 
            // tsmiLinkHoverTextColour
            // 
            this.tsmiLinkHoverTextColour.Name = "tsmiLinkHoverTextColour";
            this.tsmiLinkHoverTextColour.Size = new System.Drawing.Size(257, 22);
            this.tsmiLinkHoverTextColour.Text = "Use Link &Hover Text Colour as Base";
            this.tsmiLinkHoverTextColour.Click += new System.EventHandler(this.TsmiLinkHoverTextColour_Click);
            // 
            // ctxCustomColourFourColour
            // 
            this.ctxCustomColourFourColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourFourColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomColourFourColour});
            this.ctxCustomColourFourColour.Name = "ctxBaseColour";
            this.ctxCustomColourFourColour.Size = new System.Drawing.Size(285, 26);
            // 
            // tsmiCustomColourFourColour
            // 
            this.tsmiCustomColourFourColour.Name = "tsmiCustomColourFourColour";
            this.tsmiCustomColourFourColour.Size = new System.Drawing.Size(284, 22);
            this.tsmiCustomColourFourColour.Text = "Use Custom Colour &Four Colour as Base";
            this.tsmiCustomColourFourColour.Click += new System.EventHandler(this.TsmiCustomColourFourColour_Click);
            // 
            // ctxDarkColour
            // 
            this.ctxDarkColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxDarkColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiDarkColour});
            this.ctxDarkColour.Name = "ctxBaseColour";
            this.ctxDarkColour.Size = new System.Drawing.Size(201, 26);
            // 
            // tsiDarkColour
            // 
            this.tsiDarkColour.Name = "tsiDarkColour";
            this.tsiDarkColour.Size = new System.Drawing.Size(200, 22);
            this.tsiDarkColour.Text = "Use &Dark Colour as Base";
            this.tsiDarkColour.Click += new System.EventHandler(this.TsiDarkColour_Click);
            // 
            // ctxCustomColourThreeColour
            // 
            this.ctxCustomColourThreeColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourThreeColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomColourThreeColour});
            this.ctxCustomColourThreeColour.Name = "ctxBaseColour";
            this.ctxCustomColourThreeColour.Size = new System.Drawing.Size(290, 26);
            // 
            // tsmiCustomColourThreeColour
            // 
            this.tsmiCustomColourThreeColour.Name = "tsmiCustomColourThreeColour";
            this.tsmiCustomColourThreeColour.Size = new System.Drawing.Size(289, 22);
            this.tsmiCustomColourThreeColour.Text = "Use Custom Colour &Three Colour as Base";
            this.tsmiCustomColourThreeColour.Click += new System.EventHandler(this.TsmiCustomColourThreeColour_Click);
            // 
            // ctxCustomColourOneColour
            // 
            this.ctxCustomColourOneColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourOneColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomColourOneColour});
            this.ctxCustomColourOneColour.Name = "ctxBaseColour";
            this.ctxCustomColourOneColour.Size = new System.Drawing.Size(283, 26);
            // 
            // tsmiCustomColourOneColour
            // 
            this.tsmiCustomColourOneColour.Name = "tsmiCustomColourOneColour";
            this.tsmiCustomColourOneColour.Size = new System.Drawing.Size(282, 22);
            this.tsmiCustomColourOneColour.Text = "Use Custom Colour &One Colour as Base";
            this.tsmiCustomColourOneColour.Click += new System.EventHandler(this.TsmiCustomColourOneColour_Click);
            // 
            // ctxCustomColourTwoColour
            // 
            this.ctxCustomColourTwoColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourTwoColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomColourTwoColour});
            this.ctxCustomColourTwoColour.Name = "ctxBaseColour";
            this.ctxCustomColourTwoColour.Size = new System.Drawing.Size(282, 26);
            // 
            // tsmiCustomColourTwoColour
            // 
            this.tsmiCustomColourTwoColour.Name = "tsmiCustomColourTwoColour";
            this.tsmiCustomColourTwoColour.Size = new System.Drawing.Size(281, 22);
            this.tsmiCustomColourTwoColour.Text = "Use Custom Colour &Two Colour as Base";
            this.tsmiCustomColourTwoColour.Click += new System.EventHandler(this.TsmiCustomColourTwoColour_Click);
            // 
            // ctxCustomColourFiveColour
            // 
            this.ctxCustomColourFiveColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourFiveColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlCustomColourFiveColour});
            this.ctxCustomColourFiveColour.Name = "ctxBaseColour";
            this.ctxCustomColourFiveColour.Size = new System.Drawing.Size(282, 26);
            // 
            // tsmlCustomColourFiveColour
            // 
            this.tsmlCustomColourFiveColour.Name = "tsmlCustomColourFiveColour";
            this.tsmlCustomColourFiveColour.Size = new System.Drawing.Size(281, 22);
            this.tsmlCustomColourFiveColour.Text = "Use Custom Colour &Five Colour as Base";
            this.tsmlCustomColourFiveColour.Click += new System.EventHandler(this.TsmlCustomColourFiveColour_Click);
            // 
            // ctxCustomTextColourOneColour
            // 
            this.ctxCustomTextColourOneColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourOneColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomTextColourOneColour});
            this.ctxCustomTextColourOneColour.Name = "ctxBaseColour";
            this.ctxCustomTextColourOneColour.Size = new System.Drawing.Size(307, 26);
            // 
            // tsmiCustomTextColourOneColour
            // 
            this.tsmiCustomTextColourOneColour.Name = "tsmiCustomTextColourOneColour";
            this.tsmiCustomTextColourOneColour.Size = new System.Drawing.Size(306, 22);
            this.tsmiCustomTextColourOneColour.Text = "Use Custom Text Colour &One Colour as Base";
            this.tsmiCustomTextColourOneColour.Click += new System.EventHandler(this.TsmiCustomTextColourOneColour_Click);
            // 
            // ctxCustomTextColourFiveColour
            // 
            this.ctxCustomTextColourFiveColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourFiveColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomTextColourFiveColour});
            this.ctxCustomTextColourFiveColour.Name = "ctxBaseColour";
            this.ctxCustomTextColourFiveColour.Size = new System.Drawing.Size(306, 26);
            // 
            // tsmiCustomTextColourFiveColour
            // 
            this.tsmiCustomTextColourFiveColour.Name = "tsmiCustomTextColourFiveColour";
            this.tsmiCustomTextColourFiveColour.Size = new System.Drawing.Size(305, 22);
            this.tsmiCustomTextColourFiveColour.Text = "Use Custom Text Colour &Five Colour as Base";
            this.tsmiCustomTextColourFiveColour.Click += new System.EventHandler(this.TsmiCustomTextColourFiveColour_Click);
            // 
            // ctxCustomTextColourFourColour
            // 
            this.ctxCustomTextColourFourColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourFourColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomTextColourFourColour});
            this.ctxCustomTextColourFourColour.Name = "ctxBaseColour";
            this.ctxCustomTextColourFourColour.Size = new System.Drawing.Size(309, 26);
            // 
            // tsmiCustomTextColourFourColour
            // 
            this.tsmiCustomTextColourFourColour.Name = "tsmiCustomTextColourFourColour";
            this.tsmiCustomTextColourFourColour.Size = new System.Drawing.Size(308, 22);
            this.tsmiCustomTextColourFourColour.Text = "Use Custom Text Colour &Four Colour as Base";
            this.tsmiCustomTextColourFourColour.Click += new System.EventHandler(this.TsmiCustomTextColourFourColour_Click);
            // 
            // ctxMenuTextColour
            // 
            this.ctxMenuTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxMenuTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenuTextColour});
            this.ctxMenuTextColour.Name = "ctxBaseColour";
            this.ctxMenuTextColour.Size = new System.Drawing.Size(232, 26);
            // 
            // tsmiMenuTextColour
            // 
            this.tsmiMenuTextColour.Name = "tsmiMenuTextColour";
            this.tsmiMenuTextColour.Size = new System.Drawing.Size(231, 22);
            this.tsmiMenuTextColour.Text = "Use &Menu Text Colour as Base";
            this.tsmiMenuTextColour.Click += new System.EventHandler(this.TsmiMenuTextColour_Click);
            // 
            // ctxCustomTextColourTwoColour
            // 
            this.ctxCustomTextColourTwoColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourTwoColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomTextColourTwoColour});
            this.ctxCustomTextColourTwoColour.Name = "ctxBaseColour";
            this.ctxCustomTextColourTwoColour.Size = new System.Drawing.Size(306, 26);
            // 
            // tsmiCustomTextColourTwoColour
            // 
            this.tsmiCustomTextColourTwoColour.Name = "tsmiCustomTextColourTwoColour";
            this.tsmiCustomTextColourTwoColour.Size = new System.Drawing.Size(305, 22);
            this.tsmiCustomTextColourTwoColour.Text = "Use Custom Text Colour &Two Colour as Base";
            this.tsmiCustomTextColourTwoColour.Click += new System.EventHandler(this.TsmiCustomTextColourTwoColour_Click);
            // 
            // ctxCustomTextColourThreeColour
            // 
            this.ctxCustomTextColourThreeColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourThreeColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomTextColourThreeColour});
            this.ctxCustomTextColourThreeColour.Name = "ctxBaseColour";
            this.ctxCustomTextColourThreeColour.Size = new System.Drawing.Size(314, 26);
            // 
            // tsmiCustomTextColourThreeColour
            // 
            this.tsmiCustomTextColourThreeColour.Name = "tsmiCustomTextColourThreeColour";
            this.tsmiCustomTextColourThreeColour.Size = new System.Drawing.Size(313, 22);
            this.tsmiCustomTextColourThreeColour.Text = "Use Custom Text Colour &Three Colour as Base";
            this.tsmiCustomTextColourThreeColour.Click += new System.EventHandler(this.TsmiCustomTextColourThreeColour_Click);
            // 
            // ctxStatusStripTextColour
            // 
            this.ctxStatusStripTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxStatusStripTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStatusStripTextColour});
            this.ctxStatusStripTextColour.Name = "ctxBaseColour";
            this.ctxStatusStripTextColour.Size = new System.Drawing.Size(260, 26);
            // 
            // tsmiStatusStripTextColour
            // 
            this.tsmiStatusStripTextColour.Name = "tsmiStatusStripTextColour";
            this.tsmiStatusStripTextColour.Size = new System.Drawing.Size(259, 22);
            this.tsmiStatusStripTextColour.Text = "Use &Status Strip Text Colour as Base";
            this.tsmiStatusStripTextColour.Click += new System.EventHandler(this.TsmiStatusStripTextColour_Click);
            // 
            // ctxLinkFocusedTextColour
            // 
            this.ctxLinkFocusedTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLinkFocusedTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLinkFocusedTextColour});
            this.ctxLinkFocusedTextColour.Name = "ctxBaseColour";
            this.ctxLinkFocusedTextColour.Size = new System.Drawing.Size(270, 26);
            // 
            // tsmiLinkFocusedTextColour
            // 
            this.tsmiLinkFocusedTextColour.Name = "tsmiLinkFocusedTextColour";
            this.tsmiLinkFocusedTextColour.Size = new System.Drawing.Size(269, 22);
            this.tsmiLinkFocusedTextColour.Text = "Use Link &Focused Text Colour as Base";
            this.tsmiLinkFocusedTextColour.Click += new System.EventHandler(this.TsmiLinkFocusedTextColour_Click);
            // 
            // ctxRibbonTabTextColour
            // 
            this.ctxRibbonTabTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxRibbonTabTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRibbonTabTextColour});
            this.ctxRibbonTabTextColour.Name = "ctxBaseColour";
            this.ctxRibbonTabTextColour.Size = new System.Drawing.Size(260, 26);
            // 
            // tsmiRibbonTabTextColour
            // 
            this.tsmiRibbonTabTextColour.Name = "tsmiRibbonTabTextColour";
            this.tsmiRibbonTabTextColour.Size = new System.Drawing.Size(259, 22);
            this.tsmiRibbonTabTextColour.Text = "Use &Ribbon Tab Text Colour as Base";
            this.tsmiRibbonTabTextColour.Click += new System.EventHandler(this.TsmiRibbonTabTextColour_Click);
            // 
            // ctxCustomColourSixColour
            // 
            this.ctxCustomColourSixColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourSixColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomColourSixColour});
            this.ctxCustomColourSixColour.Name = "ctxBaseColour";
            this.ctxCustomColourSixColour.Size = new System.Drawing.Size(276, 26);
            // 
            // tsmiCustomColourSixColour
            // 
            this.tsmiCustomColourSixColour.Name = "tsmiCustomColourSixColour";
            this.tsmiCustomColourSixColour.Size = new System.Drawing.Size(275, 22);
            this.tsmiCustomColourSixColour.Text = "Use Custom Colour &Six Colour as Base";
            this.tsmiCustomColourSixColour.Click += new System.EventHandler(this.TsmiCustomColourSixColour_Click);
            // 
            // ctxLinkVisitedTextColour
            // 
            this.ctxLinkVisitedTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLinkVisitedTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLinkVisitedTextColour});
            this.ctxLinkVisitedTextColour.Name = "ctxBaseColour";
            this.ctxLinkVisitedTextColour.Size = new System.Drawing.Size(261, 26);
            // 
            // tsmiLinkVisitedTextColour
            // 
            this.tsmiLinkVisitedTextColour.Name = "tsmiLinkVisitedTextColour";
            this.tsmiLinkVisitedTextColour.Size = new System.Drawing.Size(260, 22);
            this.tsmiLinkVisitedTextColour.Text = "Use Link &Visited Text Colour as Base";
            this.tsmiLinkVisitedTextColour.Click += new System.EventHandler(this.TsmiLinkVisitedTextColour_Click);
            // 
            // ctxCustomTextColourSixColour
            // 
            this.ctxCustomTextColourSixColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourSixColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomTextColourSixColour});
            this.ctxCustomTextColourSixColour.Name = "ctxBaseColour";
            this.ctxCustomTextColourSixColour.Size = new System.Drawing.Size(300, 26);
            // 
            // tsmiCustomTextColourSixColour
            // 
            this.tsmiCustomTextColourSixColour.Name = "tsmiCustomTextColourSixColour";
            this.tsmiCustomTextColourSixColour.Size = new System.Drawing.Size(299, 22);
            this.tsmiCustomTextColourSixColour.Text = "Use Custom Text Colour &Six Colour as Base";
            this.tsmiCustomTextColourSixColour.Click += new System.EventHandler(this.TsmiCustomTextColourSixColour_Click);
            // 
            // CircularPictureBoxControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kgbCircularColourPreviewPane);
            this.Name = "CircularPictureBoxControl";
            this.Size = new System.Drawing.Size(1625, 660);
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane.Panel)).EndInit();
            this.kgbCircularColourPreviewPane.Panel.ResumeLayout(false);
            this.kgbCircularColourPreviewPane.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane)).EndInit();
            this.kgbCircularColourPreviewPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxLinkDisabledColourPreview)).EndInit();
            this.ctxLinkDisabledTextColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomTextColourSixPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomColourSixPreview)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbxMediumColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBaseColourPreview)).EndInit();
            this.ctxBaseColour.ResumeLayout(false);
            this.ctxMediumColour.ResumeLayout(false);
            this.ctxLightColour.ResumeLayout(false);
            this.ctxLightestColour.ResumeLayout(false);
            this.ctxAlternativeNormalTextColour.ResumeLayout(false);
            this.ctxBorderColour.ResumeLayout(false);
            this.ctxNormalTextColour.ResumeLayout(false);
            this.ctxLinkNormalTextColour.ResumeLayout(false);
            this.ctxDisabledControlColour.ResumeLayout(false);
            this.ctxDisabedTextColour.ResumeLayout(false);
            this.ctxFocusedTextColour.ResumeLayout(false);
            this.ctxPressedTextColour.ResumeLayout(false);
            this.ctxLinkHoverTextColour.ResumeLayout(false);
            this.ctxCustomColourFourColour.ResumeLayout(false);
            this.ctxDarkColour.ResumeLayout(false);
            this.ctxCustomColourThreeColour.ResumeLayout(false);
            this.ctxCustomColourOneColour.ResumeLayout(false);
            this.ctxCustomColourTwoColour.ResumeLayout(false);
            this.ctxCustomColourFiveColour.ResumeLayout(false);
            this.ctxCustomTextColourOneColour.ResumeLayout(false);
            this.ctxCustomTextColourFiveColour.ResumeLayout(false);
            this.ctxCustomTextColourFourColour.ResumeLayout(false);
            this.ctxMenuTextColour.ResumeLayout(false);
            this.ctxCustomTextColourTwoColour.ResumeLayout(false);
            this.ctxCustomTextColourThreeColour.ResumeLayout(false);
            this.ctxStatusStripTextColour.ResumeLayout(false);
            this.ctxLinkFocusedTextColour.ResumeLayout(false);
            this.ctxRibbonTabTextColour.ResumeLayout(false);
            this.ctxCustomColourSixColour.ResumeLayout(false);
            this.ctxLinkVisitedTextColour.ResumeLayout(false);
            this.ctxCustomTextColourSixColour.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private ArrayList _boxListCollection = new ArrayList();

        private CircularPictureBox baseColourPreview, darkColourPreview, middleColourPreview, lightColourPreview, lightestColourPreview, borderColourPreview, alternativeNormalTextColourPreview, normalTextColourPreview, disabledTextColourPreview, focusedTextColourPreview, pressedTextColourPreview, disabledControlColourPreview, linkDisabledColourPreview, linkNormalColourPreview, linkFocusedColourPreview, linkHoverColourPreview, linkVisitedColourPreview, customColourOnePreview, customColourTwoPreview, customColourThreePreview, customColourFourPreview, customColourFivePreview, customColourSixPreview, customTextColourOnePreview, customTextColourTwoPreview, customTextColourThreePreview, customTextColourFourPreview, customTextColourFivePreview, customTextColourSixPreview, menuTextColourPreview, statusTextColourPreview, ribbonTabTextColourPreview;

        private ContextMenuStrip baseColourMenu, darkColourMenu, middleColourMenu, lightColourMenu, lightestColourMenu, borderColourMenu, alternativeNormalTextColourMenu, normalTextColourMenu, disabledTextColourMenu, focusedTextColourMenu, pressedTextColourMenu, disabledControlColourMenu, linkDisabledColourMenu, linkNormalColourMenu, linkFocusedColourMenu, linkHoverColourMenu, linkVisitedColourMenu, customColourOneMenu, customColourTwoMenu, customColourThreeMenu, customColourFourMenu, customColourFiveMenu, customColourSixMenu, customTextColourOneMenu, customTextColourTwoMenu, customTextColourThreeMenu, customTextColourFourMenu, customTextColourFiveMenu, customTextColourSixMenu, menuTextColourMenu, statusTextColourMenu, ribbonTabTextColourMenu;

        private CircularPictureBox[] _circularPictureBoxCollection;
        #endregion

        #region Properties

        #region Circular Picture Box
        /// <summary>
        /// Gets or sets the base colour preview.
        /// </summary>
        /// <value>
        /// The base colour preview.
        /// </value>
        public CircularPictureBox BaseColourPreview { get => baseColourPreview; set => baseColourPreview = value; }

        /// <summary>
        /// Gets or sets the dark colour preview.
        /// </summary>
        /// <value>
        /// The dark colour preview.
        /// </value>
        public CircularPictureBox DarkColourPreview { get => darkColourPreview; set => darkColourPreview = value; }

        /// <summary>
        /// Gets or sets the middle colour preview.
        /// </summary>
        /// <value>
        /// The middle colour preview.
        /// </value>
        public CircularPictureBox MiddleColourPreview { get => middleColourPreview; set => middleColourPreview = value; }

        /// <summary>
        /// Gets or sets the light colour preview.
        /// </summary>
        /// <value>
        /// The light colour preview.
        /// </value>
        public CircularPictureBox LightColourPreview { get => lightColourPreview; set => lightColourPreview = value; }

        /// <summary>
        /// Gets or sets the lightest colour preview.
        /// </summary>
        /// <value>
        /// The lightest colour preview.
        /// </value>
        public CircularPictureBox LightestColourPreview { get => lightestColourPreview; set => lightestColourPreview = value; }

        /// <summary>
        /// Gets or sets the border colour preview.
        /// </summary>
        /// <value>
        /// The border colour preview.
        /// </value>
        public CircularPictureBox BorderColourPreview { get => borderColourPreview; set => borderColourPreview = value; }

        /// <summary>
        /// Gets or sets the alternative normal text colour preview.
        /// </summary>
        /// <value>
        /// The alternative normal text colour preview.
        /// </value>
        public CircularPictureBox AlternativeNormalTextColourPreview { get => alternativeNormalTextColourPreview; set => alternativeNormalTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the normal text colour preview.
        /// </summary>
        /// <value>
        /// The normal text colour preview.
        /// </value>
        public CircularPictureBox NormalTextColourPreview { get => normalTextColourPreview; set => normalTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the disabled text colour preview.
        /// </summary>
        /// <value>
        /// The disabled text colour preview.
        /// </value>
        public CircularPictureBox DisabledTextColourPreview { get => disabledTextColourPreview; set => disabledTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the focused text colour preview.
        /// </summary>
        /// <value>
        /// The focused text colour preview.
        /// </value>
        public CircularPictureBox FocusedTextColourPreview { get => focusedTextColourPreview; set => focusedTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the pressed text colour preview.
        /// </summary>
        /// <value>
        /// The pressed text colour preview.
        /// </value>
        public CircularPictureBox PressedTextColourPreview { get => pressedTextColourPreview; set => pressedTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the disabled control colour preview.
        /// </summary>
        /// <value>
        /// The disabled colour control preview.
        /// </value>
        public CircularPictureBox DisabledControlColourPreview { get => disabledControlColourPreview; set => disabledControlColourPreview = value; }

        /// <summary>
        /// Gets or sets the link disabed colour preview.
        /// </summary>
        /// <value>
        /// The link disabed colour preview.
        /// </value>
        public CircularPictureBox LinkDisabedColourPreview { get => linkDisabledColourPreview; set => linkDisabledColourPreview = value; }

        /// <summary>
        /// Gets or sets the link normal colour preview.
        /// </summary>
        /// <value>
        /// The link normal colour preview.
        /// </value>
        public CircularPictureBox LinkNormalColourPreview { get => linkNormalColourPreview; set => linkNormalColourPreview = value; }

        /// <summary>
        /// Gets or sets the link focused colour preview.
        /// </summary>
        /// <value>
        /// The link focused colour preview.
        /// </value>
        public CircularPictureBox LinkFocusedColourPreview { get => linkFocusedColourPreview; set => linkFocusedColourPreview = value; }

        /// <summary>
        /// Gets or sets the link hover colour preview.
        /// </summary>
        /// <value>
        /// The link hover colour preview.
        /// </value>
        public CircularPictureBox LinkHoverColourPreview { get => linkHoverColourPreview; set => linkHoverColourPreview = value; }

        /// <summary>
        /// Gets or sets the link visited colour preview.
        /// </summary>
        /// <value>
        /// The link visited colour preview.
        /// </value>
        public CircularPictureBox LinkVisitedColourPreview { get => linkVisitedColourPreview; set => linkVisitedColourPreview = value; }

        /// <summary>
        /// Gets or sets the custom colour one preview.
        /// </summary>
        /// <value>
        /// The custom colour one preview.
        /// </value>
        public CircularPictureBox CustomColourOnePreview { get => customColourOnePreview; set => customColourOnePreview = value; }

        /// <summary>
        /// Gets or sets the custom colour two preview.
        /// </summary>
        /// <value>
        /// The custom colour two preview.
        /// </value>
        public CircularPictureBox CustomColourTwoPreview { get => customColourTwoPreview; set => customColourTwoPreview = value; }

        /// <summary>
        /// Gets or sets the custom colour three preview.
        /// </summary>
        /// <value>
        /// The custom colour three preview.
        /// </value>
        public CircularPictureBox CustomColourThreePreview { get => customColourThreePreview; set => customColourThreePreview = value; }

        /// <summary>
        /// Gets or sets the custom colour four preview.
        /// </summary>
        /// <value>
        /// The custom colour four preview.
        /// </value>
        public CircularPictureBox CustomColourFourPreview { get => customColourFourPreview; set => customColourFourPreview = value; }

        /// <summary>
        /// Gets or sets the custom colour five preview.
        /// </summary>
        /// <value>
        /// The custom colour five preview.
        /// </value>
        public CircularPictureBox CustomColourFivePreview { get => customColourFivePreview; set => customColourFivePreview = value; }

        /// <summary>
        /// Gets or sets the custom colour six preview.
        /// </summary>
        /// <value>
        /// The custom colour six preview.
        /// </value>
        public CircularPictureBox CustomColourSixPreview { get => customColourSixPreview; set => customColourSixPreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour one preview.
        /// </summary>
        /// <value>
        /// The custom text colour one preview.
        /// </value>
        public CircularPictureBox CustomTextColourOnePreview { get => customTextColourOnePreview; set => customTextColourOnePreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour two preview.
        /// </summary>
        /// <value>
        /// The custom text colour two preview.
        /// </value>
        public CircularPictureBox CustomTextColourTwoPreview { get => customTextColourTwoPreview; set => customTextColourTwoPreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour three preview.
        /// </summary>
        /// <value>
        /// The custom text colour three preview.
        /// </value>
        public CircularPictureBox CustomTextColourThreePreview { get => customTextColourThreePreview; set => customTextColourThreePreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour four preview.
        /// </summary>
        /// <value>
        /// The custom text colour four preview.
        /// </value>
        public CircularPictureBox CustomTextColourFourPreview { get => customTextColourFourPreview; set => customTextColourFourPreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour five preview.
        /// </summary>
        /// <value>
        /// The custom text colour five preview.
        /// </value>
        public CircularPictureBox CustomTextColourFivePreview { get => customTextColourFivePreview; set => customTextColourFivePreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour six preview.
        /// </summary>
        /// <value>
        /// The custom text colour six preview.
        /// </value>
        public CircularPictureBox CustomTextColourSixPreview { get => customTextColourSixPreview; set => customTextColourSixPreview = value; }

        /// <summary>
        /// Gets or sets the menu text colour preview.
        /// </summary>
        /// <value>
        /// The menu text colour preview.
        /// </value>
        public CircularPictureBox MenuTextColourPreview { get => menuTextColourPreview; set => menuTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the status text colour preview.
        /// </summary>
        /// <value>
        /// The status text colour preview.
        /// </value>
        public CircularPictureBox StatusTextColourPreview { get => statusTextColourPreview; set => statusTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the ribbon tab text colour.
        /// </summary>
        /// <value>
        /// The ribbon tab text colour.
        /// </value>
        public CircularPictureBox RibbonTabTextColourPreview { get => ribbonTabTextColourPreview; set => ribbonTabTextColourPreview = value; }
        #endregion

        #region Context Menu Strips        
        /// <summary>
        /// Gets or sets the base colour menu.
        /// </summary>
        /// <value>
        /// The base colour menu.
        /// </value>
        public ContextMenuStrip BaseColourMenu { get => baseColourMenu; set => baseColourMenu = value; }

        /// <summary>
        /// Gets or sets the dark colour menu.
        /// </summary>
        /// <value>
        /// The dark colour menu.
        /// </value>
        public ContextMenuStrip DarkColourMenu { get => darkColourMenu; set => darkColourMenu = value; }

        /// <summary>
        /// Gets or sets the middle colour menu.
        /// </summary>
        /// <value>
        /// The middle colour menu.
        /// </value>
        public ContextMenuStrip MiddleColourMenu { get => middleColourMenu; set => middleColourMenu = value; }

        /// <summary>
        /// Gets or sets the light colour menu.
        /// </summary>
        /// <value>
        /// The light colour menu.
        /// </value>
        public ContextMenuStrip LightColourMenu { get => lightColourMenu; set => lightColourMenu = value; }

        /// <summary>
        /// Gets or sets the lightest colour menu.
        /// </summary>
        /// <value>
        /// The lightest colour menu.
        /// </value>
        public ContextMenuStrip LightestColourMenu { get => lightestColourMenu; set => lightestColourMenu = value; }

        /// <summary>
        /// Gets or sets the border colour menu.
        /// </summary>
        /// <value>
        /// The border colour menu.
        /// </value>
        public ContextMenuStrip BorderColourMenu { get => borderColourMenu; set => borderColourMenu = value; }

        /// <summary>
        /// Gets or sets the alternative normal text colour menu.
        /// </summary>
        /// <value>
        /// The alternative normal text colour menu.
        /// </value>
        public ContextMenuStrip AlternativeNormalTextColourMenu { get => alternativeNormalTextColourMenu; set => alternativeNormalTextColourMenu = value; }

        /// <summary>
        /// Gets or sets the normal text colour menu.
        /// </summary>
        /// <value>
        /// The normal text colour menu.
        /// </value>
        public ContextMenuStrip NormalTextColourMenu { get => normalTextColourMenu; set => normalTextColourMenu = value; }

        /// <summary>
        /// Gets or sets the disabled text colour menu.
        /// </summary>
        /// <value>
        /// The disabled text colour menu.
        /// </value>
        public ContextMenuStrip DisabledTextColourMenu { get => disabledTextColourMenu; set => disabledTextColourMenu = value; }

        /// <summary>
        /// Gets or sets the focused text colour menu.
        /// </summary>
        /// <value>
        /// The focused text colour menu.
        /// </value>
        public ContextMenuStrip FocusedTextColourMenu { get => focusedTextColourMenu; set => focusedTextColourMenu = value; }

        /// <summary>
        /// Gets or sets the pressed text colour menu.
        /// </summary>
        /// <value>
        /// The pressed text colour menu.
        /// </value>
        public ContextMenuStrip PressedTextColourMenu { get => pressedTextColourMenu; set => pressedTextColourMenu = value; }

        /// <summary>
        /// Gets or sets the disabled control colour menu.
        /// </summary>
        /// <value>
        /// The disabled control colour menu.
        /// </value>
        public ContextMenuStrip DisabledControlColourMenu { get => disabledControlColourMenu; set => disabledControlColourMenu = value; }

        /// <summary>
        /// Gets or sets the link disabed colour menu.
        /// </summary>
        /// <value>
        /// The link disabed colour menu.
        /// </value>
        public ContextMenuStrip LinkDisabedColourMenu { get => linkDisabledColourMenu; set => linkDisabledColourMenu = value; }

        /// <summary>
        /// Gets or sets the link normal colour menu.
        /// </summary>
        /// <value>
        /// The link normal colour menu.
        /// </value>
        public ContextMenuStrip LinkNormalColourMenu { get => linkNormalColourMenu; set => linkNormalColourMenu = value; }

        /// <summary>
        /// Gets or sets the link focused colour menu.
        /// </summary>
        /// <value>
        /// The link focused colour menu.
        /// </value>
        public ContextMenuStrip LinkFocusedColourMenu { get => linkFocusedColourMenu; set => linkFocusedColourMenu = value; }

        /// <summary>
        /// Gets or sets the link hover colour menu.
        /// </summary>
        /// <value>
        /// The link hover colour menu.
        /// </value>
        public ContextMenuStrip LinkHoverColourMenu { get => linkHoverColourMenu; set => linkHoverColourMenu = value; }

        /// <summary>
        /// Gets or sets the link visited colour menu.
        /// </summary>
        /// <value>
        /// The link visited colour menu.
        /// </value>
        public ContextMenuStrip LinkVisitedColourMenu { get => linkVisitedColourMenu; set => linkVisitedColourMenu = value; }

        /// <summary>
        /// Gets or sets the custom colour one menu.
        /// </summary>
        /// <value>
        /// The custom colour one menu.
        /// </value>
        public ContextMenuStrip CustomColourOneMenu { get => customColourOneMenu; set => customColourOneMenu = value; }

        /// <summary>
        /// Gets or sets the custom colour two menu.
        /// </summary>
        /// <value>
        /// The custom colour two menu.
        /// </value>
        public ContextMenuStrip CustomColourTwoMenu { get => customColourTwoMenu; set => customColourTwoMenu = value; }

        /// <summary>
        /// Gets or sets the custom colour three menu.
        /// </summary>
        /// <value>
        /// The custom colour three menu.
        /// </value>
        public ContextMenuStrip CustomColourThreeMenu { get => customColourThreeMenu; set => customColourThreeMenu = value; }

        /// <summary>
        /// Gets or sets the custom colour four menu.
        /// </summary>
        /// <value>
        /// The custom colour four menu.
        /// </value>
        public ContextMenuStrip CustomColourFourMenu { get => customColourFourMenu; set => customColourFourMenu = value; }

        /// <summary>
        /// Gets or sets the custom colour five menu.
        /// </summary>
        /// <value>
        /// The custom colour five menu.
        /// </value>
        public ContextMenuStrip CustomColourFiveMenu { get => customColourFiveMenu; set => customColourFiveMenu = value; }

        /// <summary>
        /// Gets or sets the custom colour six menu.
        /// </summary>
        /// <value>
        /// The custom colour six menu.
        /// </value>
        public ContextMenuStrip CustomColourSixMenu { get => customColourSixMenu; set => customColourSixMenu = value; }

        /// <summary>
        /// Gets or sets the custom text colour one menu.
        /// </summary>
        /// <value>
        /// The custom text colour one menu.
        /// </value>
        public ContextMenuStrip CustomTextColourOneMenu { get => customTextColourOneMenu; set => customTextColourOneMenu = value; }

        /// <summary>
        /// Gets or sets the custom text colour two menu.
        /// </summary>
        /// <value>
        /// The custom text colour two menu.
        /// </value>
        public ContextMenuStrip CustomTextColourTwoMenu { get => customTextColourTwoMenu; set => customTextColourTwoMenu = value; }

        /// <summary>
        /// Gets or sets the custom text colour three menu.
        /// </summary>
        /// <value>
        /// The custom text colour three menu.
        /// </value>
        public ContextMenuStrip CustomTextColourThreeMenu { get => customTextColourThreeMenu; set => customTextColourThreeMenu = value; }

        /// <summary>
        /// Gets or sets the custom text colour four menu.
        /// </summary>
        /// <value>
        /// The custom text colour four menu.
        /// </value>
        public ContextMenuStrip CustomTextColourFourMenu { get => customTextColourFourMenu; set => customTextColourFourMenu = value; }

        /// <summary>
        /// Gets or sets the custom text colour five menu.
        /// </summary>
        /// <value>
        /// The custom text colour five menu.
        /// </value>
        public ContextMenuStrip CustomTextColourFiveMenu { get => customTextColourFiveMenu; set => customTextColourFiveMenu = value; }

        /// <summary>
        /// Gets or sets the custom text colour six menu.
        /// </summary>
        /// <value>
        /// The custom text colour six menu.
        /// </value>
        public ContextMenuStrip CustomTextColourSixMenu { get => customTextColourSixMenu; set => customTextColourSixMenu = value; }

        /// <summary>
        /// Gets or sets the menu text colour menu.
        /// </summary>
        /// <value>
        /// The menu text colour menu.
        /// </value>
        public ContextMenuStrip MenuTextColourMenu { get => menuTextColourMenu; set => menuTextColourMenu = value; }

        /// <summary>
        /// Gets or sets the status text colour menu.
        /// </summary>
        /// <value>
        /// The status text colour menu.
        /// </value>
        public ContextMenuStrip StatusTextColourMenu { get => statusTextColourMenu; set => statusTextColourMenu = value; }

        /// <summary>
        /// Gets or sets the ribbon tab text colour menu.
        /// </summary>
        /// <value>
        /// The ribbon tab text colour menu.
        /// </value>
        public ContextMenuStrip RibbonTabTextColourMenu { get => ribbonTabTextColourMenu; set => ribbonTabTextColourMenu = value; }
        #endregion

        #endregion

        #region Constructor
        public CircularPictureBoxControl()
        {
            InitializeComponent();

            #region Picture Boxes
            SetBaseColourPreview(cbxBaseColourPreview);

            SetDarkColourPreview(cbxDarkColourPreview);

            SetMiddleColourPreview(cbxMediumColourPreview);

            SetLightColourPreview(cbxLightColourPreview);

            SetLightestColourPreview(cbxLightestColourPreview);

            SetBorderColourPreview(cbxBorderColourPreview);

            SetAlternativeNormalTextColourPreview(cbxAlternativeNormalTextColourPreview);

            SetNormalTextColourPreview(cbxNormalTextColourPreview);

            SetDisabledTextColourPreview(cbxDisabledTextColourPreview);

            SetFocusedTextColourPreview(cbxFocusedTextColourPreview);

            SetPressedTextColourPreview(cbxPressedTextColourPreview);

            SetDisabledControlColourPreview(cbxDisabledControlColourPreview);

            SetLinkDisabedColourPreview(cbxLinkDisabledColourPreview);

            SetLinkNormalColourPreview(cbxLinkNormalColourPreview);

            SetLinkFocusedColourPreview(cbxLinkFocusedColourPreview);

            SetLinkHoverColourPreview(cbxLinkHoverColourPreview);

            SetLinkVisitedColourPreview(cbxLinkVisitedColourPreview);

            SetCustomColourOneColourPreview(cbxCustomColourOnePreview);

            SetCustomColourTwoColourPreview(cbxCustomColourTwoPreview);

            SetCustomColourThreeColourPreview(cbxCustomColourThreePreview);

            SetCustomColourFourColourPreview(cbxCustomColourFourPreview);

            SetCustomColourFiveColourPreview(cbxCustomColourFivePreview);

            SetCustomColourSixColourPreview(cbxCustomColourSixPreview);

            SetCustomTextColourOneColourPreview(cbxCustomTextColourOnePreview);

            SetCustomTextColourTwoColourPreview(cbxCustomTextColourTwoPreview);

            SetCustomTextColourThreeColourPreview(cbxCustomTextColourThreePreview);

            SetCustomTextColourFourColourPreview(cbxCustomTextColourFourPreview);

            SetCustomTextColourFiveColourPreview(cbxCustomTextColourFivePreview);

            SetCustomTextColourSixColourPreview(cbxCustomTextColourSixPreview);

            SetMenuTextColourPreview(cbxMenuTextColourPreview);

            SetStatusTextColourPreview(cbxStatusTextColourPreview);

            SetRibbonTabTextColourPreview(cbxRibbonTabTextColourPreview);
            #endregion

            #region Context Menu Strips
            SetBaseColourMenu(ctxBaseColour);

            SetDarkColourMenu(ctxDarkColour);

            SetMiddleColourMenu(ctxMediumColour);

            SetLightColourMenu(ctxLightColour);

            SetLightestColourMenu(ctxLightestColour);

            SetBorderColourMenu(ctxBorderColour);

            SetAlternativeNormalTextColourMenu(ctxAlternativeNormalTextColour);

            SetNormalTextColourMenu(ctxNormalTextColour);

            SetDisabledTextColourMenu(ctxDisabedTextColour);

            SetFocusedTextColourMenu(ctxFocusedTextColour);

            SetPressedTextColourMenu(ctxPressedTextColour);

            SetDisabledControlColourMenu(ctxDisabledControlColour);

            SetLinkNormalColourMenu(ctxLinkNormalTextColour);

            SetLinkDisabedColourMenu(ctxLinkDisabledTextColour);

            SetLinkHoverColourMenu(ctxLinkHoverTextColour);

            SetLinkFocusedColourMenu(ctxLinkFocusedTextColour);

            SetLinkVisitedColourMenu(ctxLinkVisitedTextColour);

            SetCustomColourOneColourMenu(ctxCustomColourOneColour);

            SetCustomColourTwoColourMenu(ctxCustomColourTwoColour);

            SetCustomColourThreeColourMenu(ctxCustomColourThreeColour);

            SetCustomColourFourColourMenu(ctxCustomColourFourColour);

            SetCustomColourFiveColourMenu(ctxCustomColourFiveColour);

            SetCustomColourSixColourMenu(ctxCustomColourSixColour);

            SetCustomTextColourOneColourMenu(ctxCustomTextColourOneColour);

            SetCustomTextColourTwoColourMenu(ctxCustomTextColourTwoColour);

            SetCustomTextColourThreeColourMenu(ctxCustomTextColourThreeColour);

            SetCustomTextColourFourColourMenu(ctxCustomTextColourFourColour);

            SetCustomTextColourFiveColourMenu(ctxCustomTextColourFiveColour);

            SetCustomTextColourSixColourMenu(ctxCustomTextColourSixColour);

            SetMenuTextColourMenu(ctxMenuTextColour);

            SetStatusTextColourMenu(ctxStatusStripTextColour);

            SetRibbonTabTextColourMenu(ctxRibbonTabTextColour);
            #endregion

            #region Context Menu Assign
            AssignContextMenuToControl(GetBaseColourPreview(), GetBaseColourMenu());

            AssignContextMenuToControl(GetDarkColourPreview(), GetDarkColourMenu());

            AssignContextMenuToControl(GetMiddleColourPreview(), GetMiddleColourMenu());

            AssignContextMenuToControl(GetLightColourPreview(), GetLightColourMenu());

            AssignContextMenuToControl(GetLightestColourPreview(), GetLightestColourMenu());

            AssignContextMenuToControl(GetBorderColourPreview(), GetBorderColourMenu());

            AssignContextMenuToControl(GetAlternativeNormalTextColourPreview(), GetAlternativeNormalTextColourMenu());

            AssignContextMenuToControl(GetNormalTextColourPreview(), GetNormalTextColourMenu());

            AssignContextMenuToControl(GetDisabledTextColourPreview(), GetDisabledTextColourMenu());

            AssignContextMenuToControl(GetFocusedTextColourPreview(), GetFocusedTextColourMenu());

            AssignContextMenuToControl(GetPressedTextColourPreview(), GetPressedTextColourMenu());

            AssignContextMenuToControl(GetDisabledControlColourPreview(), GetDisabledControlColourMenu());

            AssignContextMenuToControl(GetLinkDisabedColourPreview(), GetLinkDisabedColourMenu());

            AssignContextMenuToControl(GetLinkNormalColourPreview(), GetLinkNormalColourMenu());

            AssignContextMenuToControl(GetLinkFocusedColourPreview(), GetLinkFocusedColourMenu());

            AssignContextMenuToControl(GetLinkHoverColourPreview(), GetLinkHoverColourMenu());

            AssignContextMenuToControl(GetLinkVisitedColourPreview(), GetLinkVisitedColourMenu());

            AssignContextMenuToControl(GetCustomColourOneColourPreview(), GetCustomColourOneColourMenu());

            AssignContextMenuToControl(GetCustomColourTwoColourPreview(), GetCustomColourTwoColourMenu());

            AssignContextMenuToControl(GetCustomColourThreeColourPreview(), GetCustomColourThreeColourMenu());

            AssignContextMenuToControl(GetCustomColourFourColourPreview(), GetCustomColourFourColourMenu());

            AssignContextMenuToControl(GetCustomColourFiveColourPreview(), GetCustomColourFiveColourMenu());

            AssignContextMenuToControl(GetCustomColourSixColourPreview(), GetCustomColourSixColourMenu());

            AssignContextMenuToControl(GetCustomTextColourOneColourPreview(), GetCustomTextColourOneColourMenu());

            AssignContextMenuToControl(GetCustomTextColourTwoColourPreview(), GetCustomTextColourTwoColourMenu());

            AssignContextMenuToControl(GetCustomTextColourThreeColourPreview(), GetCustomTextColourThreeColourMenu());

            AssignContextMenuToControl(GetCustomTextColourFourColourPreview(), GetCustomTextColourFourColourMenu());

            AssignContextMenuToControl(GetCustomTextColourFiveColourPreview(), GetCustomTextColourFiveColourMenu());

            AssignContextMenuToControl(GetCustomTextColourSixColourPreview(), GetCustomTextColourSixColourMenu());

            AssignContextMenuToControl(GetMenuTextColourPreview(), GetMenuTextColourMenu());

            AssignContextMenuToControl(GetStatusTextColourPreview(), GetStatusTextColourMenu());

            AssignContextMenuToControl(GetRibbonTabTextColourPreview(), GetRibbonTabTextColourMenu());
            #endregion

            #region Fill ArrayList
            AddToBoxListCollection(GetBaseColourPreview());

            AddToBoxListCollection(GetDarkColourPreview());

            AddToBoxListCollection(GetMiddleColourPreview());

            AddToBoxListCollection(GetLightColourPreview());

            AddToBoxListCollection(GetLightestColourPreview());

            AddToBoxListCollection(GetBorderColourPreview());

            AddToBoxListCollection(GetAlternativeNormalTextColourPreview());

            AddToBoxListCollection(GetNormalTextColourPreview());

            AddToBoxListCollection(GetDisabledTextColourPreview());

            AddToBoxListCollection(GetFocusedTextColourPreview());

            AddToBoxListCollection(GetPressedTextColourPreview());

            AddToBoxListCollection(GetDisabledControlColourPreview());

            AddToBoxListCollection(GetLinkDisabedColourPreview());

            AddToBoxListCollection(GetLinkNormalColourPreview());

            AddToBoxListCollection(GetLinkFocusedColourPreview());

            AddToBoxListCollection(GetLinkHoverColourPreview());

            AddToBoxListCollection(GetLinkVisitedColourPreview());

            AddToBoxListCollection(GetCustomColourOneColourPreview());

            AddToBoxListCollection(GetCustomColourTwoColourPreview());

            AddToBoxListCollection(GetCustomColourThreeColourPreview());

            AddToBoxListCollection(GetCustomColourFourColourPreview());

            AddToBoxListCollection(GetCustomColourFiveColourPreview());

            AddToBoxListCollection(GetCustomColourSixColourPreview());

            AddToBoxListCollection(GetCustomTextColourOneColourPreview());

            AddToBoxListCollection(GetCustomTextColourTwoColourPreview());

            AddToBoxListCollection(GetCustomTextColourThreeColourPreview());

            AddToBoxListCollection(GetCustomTextColourFourColourPreview());

            AddToBoxListCollection(GetCustomTextColourFiveColourPreview());

            AddToBoxListCollection(GetCustomTextColourSixColourPreview());

            AddToBoxListCollection(GetMenuTextColourPreview());

            AddToBoxListCollection(GetStatusTextColourPreview());

            AddToBoxListCollection(GetRibbonTabTextColourPreview());
            #endregion
        }
        #endregion

        #region Event Handlers

        #region ToolTips
        private void CbxBaseColourPreview_MouseEnter(object sender, EventArgs e)
        {
            UserInterfaceManager.DisplayToolTipInformation(GetBaseColourPreview(), GetBaseColourPreview().BackColor, "Base", true);
        }

        private void CbxDarkColourPreview_MouseEnter(object sender, EventArgs e)
        {
            UserInterfaceManager.DisplayToolTipInformation(GetDarkColourPreview(), GetDarkColourPreview().BackColor, "Dark", true);
        }

        private void CbxMediumColourPreview_MouseEnter(object sender, EventArgs e)
        {
            UserInterfaceManager.DisplayToolTipInformation(GetMiddleColourPreview(), GetMiddleColourPreview().BackColor, "Middle", true);
        }

        private void CbxLightColourPreview_MouseEnter(object sender, EventArgs e)
        {
            UserInterfaceManager.DisplayToolTipInformation(GetLightColourPreview(), GetLightColourPreview().BackColor, "Light", true);
        }

        private void CbxLightestColourPreview_MouseEnter(object sender, EventArgs e)
        {
            UserInterfaceManager.DisplayToolTipInformation(GetLightestColourPreview(), GetLightestColourPreview().BackColor, "Lightest", true);
        }

        private void CbxBorderColourPreview_MouseEnter(object sender, EventArgs e)
        {
            UserInterfaceManager.DisplayToolTipInformation(GetBorderColourPreview(), GetBorderColourPreview().BackColor, "Border", true);
        }

        private void CbxAlternativeNormalTextColourPreview_MouseEnter(object sender, EventArgs e)
        {
            UserInterfaceManager.DisplayToolTipInformation(GetAlternativeNormalTextColourPreview(), GetAlternativeNormalTextColourPreview().BackColor, "Alternative Normal Text", true);
        }

        private void CbxNormalTextColourPreview_MouseEnter(object sender, EventArgs e)
        {
            UserInterfaceManager.DisplayToolTipInformation(GetNormalTextColourPreview(), GetNormalTextColourPreview().BackColor, "Normal Text", true);
        }

        private void CbxDisabledTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxFocusedTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxPressedTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxDisabledControlColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxLinkDisabledColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxLinkNormalColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxLinkFocusedColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxLinkHoverColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxLinkVisitedColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomColourOnePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomColourTwoPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomColourThreePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomColourFourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomColourFivePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomColourSixPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomTextColourOnePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomTextColourTwoPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomTextColourThreePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomTextColourFourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomTextColourFivePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxCustomTextColourSixPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxMenuTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxStatusTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbxRibbonTabTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        #region Colour Handlers
        private void UseBaseColourAsBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetBaseColourPreview());
        }

        private void TsmiMediumColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetMiddleColourPreview());
        }

        private void TsmiLightColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetLightColourPreview());
        }

        private void TsmiLightestColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetLightestColourPreview());
        }

        private void TsmiAlternativeNormalTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetAlternativeNormalTextColourPreview());
        }

        private void TsmiBorderColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetBorderColourPreview());
        }

        private void TsmiNormalTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetNormalTextColourPreview());
        }

        private void TsmiLinkNormalTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetLinkNormalColourPreview());
        }

        private void TsmiDisabledControlColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetDisabledControlColourPreview());
        }

        private void TsmiDisabledTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetDisabledTextColourPreview());
        }

        private void TsmiFocusedTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetFocusedTextColourPreview());
        }

        private void TsmiPressedTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetPressedTextColourPreview());
        }

        private void TsmiLinkHoverTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetLinkHoverColourPreview());
        }

        private void TsmiCustomColourFourColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomColourFourColourPreview());
        }

        private void TsiDarkColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetDarkColourPreview());
        }

        private void TsmiCustomColourThreeColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomColourThreeColourPreview());
        }

        private void TsmiCustomColourOneColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomColourOneColourPreview());
        }

        private void TsmiCustomColourTwoColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomColourTwoColourPreview());
        }

        private void TsmlCustomColourFiveColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomColourFiveColourPreview());
        }

        private void TsmiCustomTextColourOneColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomTextColourOneColourPreview());
        }

        private void TsmiCustomTextColourFiveColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomTextColourFiveColourPreview());
        }

        private void TsmiCustomTextColourFourColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomTextColourFourColourPreview());
        }

        private void TsmiMenuTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetMenuTextColourPreview());
        }

        private void TsmiCustomTextColourTwoColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomTextColourTwoColourPreview());
        }

        private void TsmiCustomTextColourThreeColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomTextColourThreeColourPreview());
        }

        private void TsmiStatusStripTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetStatusTextColourPreview());
        }

        private void TsmiLinkFocusedTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetLinkFocusedColourPreview());
        }

        private void TsmiRibbonTabTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetRibbonTabTextColourPreview());
        }

        private void TsmiCustomColourSixColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomColourSixColourPreview());
        }

        private void TsmiLinkVisitedTextColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetLinkVisitedColourPreview());
        }

        private void TsmiCustomTextColourSixColour_Click(object sender, EventArgs e)
        {
            ColourHelpers.RecreatePaletteColours(GetCustomTextColourSixColourPreview());
        }
        #endregion

        #region Setters and Getters

        #region Circular Picture Box
        /// <summary>
        /// Sets the value of BaseColourPreview to value.
        /// </summary>
        /// <param name="value">The value of BaseColourPreview.</param>
        public void SetBaseColourPreview(CircularPictureBox value)
        {
            BaseColourPreview = value;
        }

        /// <summary>
        /// Returns the value of BaseColourPreview.
        /// </summary>
        /// <returns>The value of BaseColourPreview.</returns>
        public CircularPictureBox GetBaseColourPreview()
        {
            return BaseColourPreview;
        }

        /// <summary>
        /// Sets the value of DarkColourPreview to value.
        /// </summary>
        /// <param name="value">The value of DarkColourPreview.</param>
        public void SetDarkColourPreview(CircularPictureBox value)
        {
            DarkColourPreview = value;
        }

        /// <summary>
        /// Returns the value of DarkColourPreview.
        /// </summary>
        /// <returns>The value of DarkColourPreview.</returns>
        public CircularPictureBox GetDarkColourPreview()
        {
            return DarkColourPreview;
        }

        /// <summary>
        /// Sets the value of MiddleColourPreview to value.
        /// </summary>
        /// <param name="value">The value of MiddleColourPreview.</param>
        public void SetMiddleColourPreview(CircularPictureBox value)
        {
            MiddleColourPreview = value;
        }

        /// <summary>
        /// Returns the value of MiddleColourPreview.
        /// </summary>
        /// <returns>The value of MiddleColourPreview.</returns>
        public CircularPictureBox GetMiddleColourPreview()
        {
            return MiddleColourPreview;
        }

        /// <summary>
        /// Sets the value of LightColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LightColourPreview.</param>
        public void SetLightColourPreview(CircularPictureBox value)
        {
            LightColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LightColourPreview.
        /// </summary>
        /// <returns>The value of LightColourPreview.</returns>
        public CircularPictureBox GetLightColourPreview()
        {
            return LightColourPreview;
        }

        /// <summary>
        /// Sets the value of LightestColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LightestColourPreview.</param>
        public void SetLightestColourPreview(CircularPictureBox value)
        {
            LightestColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LightestColourPreview.
        /// </summary>
        /// <returns>The value of LightestColourPreview.</returns>
        public CircularPictureBox GetLightestColourPreview()
        {
            return LightestColourPreview;
        }

        /// <summary>
        /// Sets the value of BorderColourPreview to value.
        /// </summary>
        /// <param name="value">The value of BorderColourPreview.</param>
        public void SetBorderColourPreview(CircularPictureBox value)
        {
            BorderColourPreview = value;
        }

        /// <summary>
        /// Returns the value of BorderColourPreview.
        /// </summary>
        /// <returns>The value of BorderColourPreview.</returns>
        public CircularPictureBox GetBorderColourPreview()
        {
            return BorderColourPreview;
        }

        /// <summary>
        /// Sets the value of AlternativeNormalTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of AlternativeNormalTextColourPreview.</param>
        public void SetAlternativeNormalTextColourPreview(CircularPictureBox value)
        {
            AlternativeNormalTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of AlternativeNormalTextColourPreview.
        /// </summary>
        /// <returns>The value of AlternativeNormalTextColourPreview.</returns>
        public CircularPictureBox GetAlternativeNormalTextColourPreview()
        {
            return AlternativeNormalTextColourPreview;
        }

        /// <summary>
        /// Sets the value of NormalTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of NormalTextColourPreview.</param>
        public void SetNormalTextColourPreview(CircularPictureBox value)
        {
            NormalTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of NormalTextColourPreview.
        /// </summary>
        /// <returns>The value of NormalTextColourPreview.</returns>
        public CircularPictureBox GetNormalTextColourPreview()
        {
            return NormalTextColourPreview;
        }

        /// <summary>
        /// Sets the value of DisabledTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of DisabledTextColourPreview.</param>
        public void SetDisabledTextColourPreview(CircularPictureBox value)
        {
            DisabledTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of DisabledTextColourPreview.
        /// </summary>
        /// <returns>The value of DisabledTextColourPreview.</returns>
        public CircularPictureBox GetDisabledTextColourPreview()
        {
            return DisabledTextColourPreview;
        }

        /// <summary>
        /// Sets the value of FocusedTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of FocusedTextColourPreview.</param>
        public void SetFocusedTextColourPreview(CircularPictureBox value)
        {
            FocusedTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of FocusedTextColourPreview.
        /// </summary>
        /// <returns>The value of FocusedTextColourPreview.</returns>
        public CircularPictureBox GetFocusedTextColourPreview()
        {
            return FocusedTextColourPreview;
        }

        /// <summary>
        /// Sets the value of PressedTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of PressedTextColourPreview.</param>
        public void SetPressedTextColourPreview(CircularPictureBox value)
        {
            PressedTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of PressedTextColourPreview.
        /// </summary>
        /// <returns>The value of PressedTextColourPreview.</returns>
        public CircularPictureBox GetPressedTextColourPreview()
        {
            return PressedTextColourPreview;
        }

        /// <summary>
        /// Sets the value of DisabledControlColourPreview to value.
        /// </summary>
        /// <param name="value">The value of DisabledControlColourPreview.</param>
        public void SetDisabledControlColourPreview(CircularPictureBox value)
        {
            DisabledControlColourPreview = value;
        }

        /// <summary>
        /// Returns the value of DisabledControlColourPreview.
        /// </summary>
        /// <returns>The value of DisabledControlColourPreview.</returns>
        public CircularPictureBox GetDisabledControlColourPreview()
        {
            return DisabledControlColourPreview;
        }

        /// <summary>
        /// Sets the value of LinkDisabedColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LinkDisabedColourPreview.</param>
        public void SetLinkDisabedColourPreview(CircularPictureBox value)
        {
            LinkDisabedColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LinkDisabedColourPreview.
        /// </summary>
        /// <returns>The value of LinkDisabedColourPreview.</returns>
        public CircularPictureBox GetLinkDisabedColourPreview()
        {
            return LinkDisabedColourPreview;
        }

        /// <summary>
        /// Sets the value of LinkNormalColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LinkNormalColourPreview.</param>
        public void SetLinkNormalColourPreview(CircularPictureBox value)
        {
            LinkNormalColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LinkNormalColourPreview.
        /// </summary>
        /// <returns>The value of LinkNormalColourPreview.</returns>
        public CircularPictureBox GetLinkNormalColourPreview()
        {
            return LinkNormalColourPreview;
        }

        /// <summary>
        /// Sets the value of LinkFocusedColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LinkFocusedColourPreview.</param>
        public void SetLinkFocusedColourPreview(CircularPictureBox value)
        {
            LinkFocusedColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LinkFocusedColourPreview.
        /// </summary>
        /// <returns>The value of LinkFocusedColourPreview.</returns>
        public CircularPictureBox GetLinkFocusedColourPreview()
        {
            return LinkFocusedColourPreview;
        }

        /// <summary>
        /// Sets the value of LinkHoverColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LinkHoverColourPreview.</param>
        public void SetLinkHoverColourPreview(CircularPictureBox value)
        {
            LinkHoverColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LinkHoverColourPreview.
        /// </summary>
        /// <returns>The value of LinkHoverColourPreview.</returns>
        public CircularPictureBox GetLinkHoverColourPreview()
        {
            return LinkHoverColourPreview;
        }

        /// <summary>
        /// Sets the value of LinkVisitedColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LinkVisitedColourPreview.</param>
        public void SetLinkVisitedColourPreview(CircularPictureBox value)
        {
            LinkVisitedColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LinkVisitedColourPreview.
        /// </summary>
        /// <returns>The value of LinkVisitedColourPreview.</returns>
        public CircularPictureBox GetLinkVisitedColourPreview()
        {
            return LinkVisitedColourPreview;
        }

        /// <summary>
        /// Sets the value of CustomColourOneColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourOneColourPreview.</param>
        public void SetCustomColourOneColourPreview(CircularPictureBox value)
        {
            CustomColourOnePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourOneColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourOneColourPreview.</returns>
        public CircularPictureBox GetCustomColourOneColourPreview()
        {
            return CustomColourOnePreview;
        }

        /// <summary>
        /// Sets the value of CustomColourTwoColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourTwoColourPreview.</param>
        public void SetCustomColourTwoColourPreview(CircularPictureBox value)
        {
            CustomColourTwoPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourTwoColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourTwoColourPreview.</returns>
        public CircularPictureBox GetCustomColourTwoColourPreview()
        {
            return CustomColourTwoPreview;
        }

        /// <summary>
        /// Sets the value of CustomColourThreeColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourThreeColourPreview.</param>
        public void SetCustomColourThreeColourPreview(CircularPictureBox value)
        {
            CustomColourThreePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourThreeColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourThreeColourPreview.</returns>
        public CircularPictureBox GetCustomColourThreeColourPreview()
        {
            return CustomColourThreePreview;
        }

        /// <summary>
        /// Sets the value of CustomColourFourColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourFourColourPreview.</param>
        public void SetCustomColourFourColourPreview(CircularPictureBox value)
        {
            CustomColourFourPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourFourColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourFourColourPreview.</returns>
        public CircularPictureBox GetCustomColourFourColourPreview()
        {
            return CustomColourFourPreview;
        }

        /// <summary>
        /// Sets the value of CustomColourFiveColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourFiveColourPreview.</param>
        public void SetCustomColourFiveColourPreview(CircularPictureBox value)
        {
            CustomColourFivePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourFiveColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourFiveColourPreview.</returns>
        public CircularPictureBox GetCustomColourFiveColourPreview()
        {
            return CustomColourFivePreview;
        }

        /// <summary>
        /// Sets the value of CustomColourSixColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourSixColourPreview.</param>
        public void SetCustomColourSixColourPreview(CircularPictureBox value)
        {
            CustomColourSixPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourSixColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourSixColourPreview.</returns>
        public CircularPictureBox GetCustomColourSixColourPreview()
        {
            return CustomColourSixPreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourOneColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourOneColourPreview.</param>
        public void SetCustomTextColourOneColourPreview(CircularPictureBox value)
        {
            CustomTextColourOnePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourOneColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourOneColourPreview.</returns>
        public CircularPictureBox GetCustomTextColourOneColourPreview()
        {
            return CustomTextColourOnePreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourTwoColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourTwoColourPreview.</param>
        public void SetCustomTextColourTwoColourPreview(CircularPictureBox value)
        {
            CustomTextColourTwoPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourTwoColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourTwoColourPreview.</returns>
        public CircularPictureBox GetCustomTextColourTwoColourPreview()
        {
            return CustomTextColourTwoPreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourThreeColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourThreeColourPreview.</param>
        public void SetCustomTextColourThreeColourPreview(CircularPictureBox value)
        {
            CustomTextColourThreePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourThreeColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourThreeColourPreview.</returns>
        public CircularPictureBox GetCustomTextColourThreeColourPreview()
        {
            return CustomTextColourThreePreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFourColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourFourColourPreview.</param>
        public void SetCustomTextColourFourColourPreview(CircularPictureBox value)
        {
            CustomTextColourFourPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourFourColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourFourColourPreview.</returns>
        public CircularPictureBox GetCustomTextColourFourColourPreview()
        {
            return CustomTextColourFourPreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFiveColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourFiveColourPreview.</param>
        public void SetCustomTextColourFiveColourPreview(CircularPictureBox value)
        {
            CustomTextColourFivePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourFiveColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourFiveColourPreview.</returns>
        public CircularPictureBox GetCustomTextColourFiveColourPreview()
        {
            return CustomTextColourFivePreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourSixColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourSixColourPreview.</param>
        public void SetCustomTextColourSixColourPreview(CircularPictureBox value)
        {
            CustomTextColourSixPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourSixColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourSixColourPreview.</returns>
        public CircularPictureBox GetCustomTextColourSixColourPreview()
        {
            return CustomTextColourSixPreview;
        }

        /// <summary>
        /// Sets the value of MenuTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of MenuTextColourPreview.</param>
        public void SetMenuTextColourPreview(CircularPictureBox value)
        {
            MenuTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of MenuTextColourPreview.
        /// </summary>
        /// <returns>The value of MenuTextColourPreview.</returns>
        public CircularPictureBox GetMenuTextColourPreview()
        {
            return MenuTextColourPreview;
        }

        /// <summary>
        /// Sets the value of StatusTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of StatusTextColourPreview.</param>
        public void SetStatusTextColourPreview(CircularPictureBox value)
        {
            StatusTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of StatusTextColourPreview.
        /// </summary>
        /// <returns>The value of StatusTextColourPreview.</returns>
        public CircularPictureBox GetStatusTextColourPreview()
        {
            return StatusTextColourPreview;
        }

        /// <summary>
        /// Sets the value of RibbonTabTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of RibbonTabTextColourPreview.</param>
        public void SetRibbonTabTextColourPreview(CircularPictureBox value)
        {
            RibbonTabTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of RibbonTabTextColourPreview.
        /// </summary>
        /// <returns>The value of RibbonTabTextColourPreview.</returns>
        public CircularPictureBox GetRibbonTabTextColourPreview()
        {
            return RibbonTabTextColourPreview;
        }
        #endregion

        #region Context Menu Strips
        /// <summary>
        /// Sets the value of BaseColourMenu to value.
        /// </summary>
        /// <param name="value">The value of BaseColourMenu.</param>
        public void SetBaseColourMenu(ContextMenuStrip value)
        {
            BaseColourMenu = value;
        }

        /// <summary>
        /// Returns the value of BaseColourMenu.
        /// </summary>
        /// <returns>The value of BaseColourMenu.</returns>
        public ContextMenuStrip GetBaseColourMenu()
        {
            return BaseColourMenu;
        }

        /// <summary>
        /// Sets the value of DarkColourMenu to value.
        /// </summary>
        /// <param name="value">The value of DarkColourMenu.</param>
        public void SetDarkColourMenu(ContextMenuStrip value)
        {
            DarkColourMenu = value;
        }

        /// <summary>
        /// Returns the value of DarkColourMenu.
        /// </summary>
        /// <returns>The value of DarkColourMenu.</returns>
        public ContextMenuStrip GetDarkColourMenu()
        {
            return DarkColourMenu;
        }

        /// <summary>
        /// Sets the value of MiddleColourMenu to value.
        /// </summary>
        /// <param name="value">The value of MiddleColourMenu.</param>
        public void SetMiddleColourMenu(ContextMenuStrip value)
        {
            MiddleColourMenu = value;
        }

        /// <summary>
        /// Returns the value of MiddleColourMenu.
        /// </summary>
        /// <returns>The value of MiddleColourMenu.</returns>
        public ContextMenuStrip GetMiddleColourMenu()
        {
            return MiddleColourMenu;
        }

        /// <summary>
        /// Sets the value of LightColourMenu to value.
        /// </summary>
        /// <param name="value">The value of LightColourMenu.</param>
        public void SetLightColourMenu(ContextMenuStrip value)
        {
            LightColourMenu = value;
        }

        /// <summary>
        /// Returns the value of LightColourMenu.
        /// </summary>
        /// <returns>The value of LightColourMenu.</returns>
        public ContextMenuStrip GetLightColourMenu()
        {
            return LightColourMenu;
        }

        /// <summary>
        /// Sets the value of LightestColourMenu to value.
        /// </summary>
        /// <param name="value">The value of LightestColourMenu.</param>
        public void SetLightestColourMenu(ContextMenuStrip value)
        {
            LightestColourMenu = value;
        }

        /// <summary>
        /// Returns the value of LightestColourMenu.
        /// </summary>
        /// <returns>The value of LightestColourMenu.</returns>
        public ContextMenuStrip GetLightestColourMenu()
        {
            return LightestColourMenu;
        }

        /// <summary>
        /// Sets the value of BorderColourMenu to value.
        /// </summary>
        /// <param name="value">The value of BorderColourMenu.</param>
        public void SetBorderColourMenu(ContextMenuStrip value)
        {
            BorderColourMenu = value;
        }

        /// <summary>
        /// Returns the value of BorderColourMenu.
        /// </summary>
        /// <returns>The value of BorderColourMenu.</returns>
        public ContextMenuStrip GetBorderColourMenu()
        {
            return BorderColourMenu;
        }

        /// <summary>
        /// Sets the value of AlternativeNormalTextColourMenu to value.
        /// </summary>
        /// <param name="value">The value of AlternativeNormalTextColourMenu.</param>
        public void SetAlternativeNormalTextColourMenu(ContextMenuStrip value)
        {
            AlternativeNormalTextColourMenu = value;
        }

        /// <summary>
        /// Returns the value of AlternativeNormalTextColourMenu.
        /// </summary>
        /// <returns>The value of AlternativeNormalTextColourMenu.</returns>
        public ContextMenuStrip GetAlternativeNormalTextColourMenu()
        {
            return AlternativeNormalTextColourMenu;
        }

        /// <summary>
        /// Sets the value of NormalTextColourMenu to value.
        /// </summary>
        /// <param name="value">The value of NormalTextColourMenu.</param>
        public void SetNormalTextColourMenu(ContextMenuStrip value)
        {
            NormalTextColourMenu = value;
        }

        /// <summary>
        /// Returns the value of NormalTextColourMenu.
        /// </summary>
        /// <returns>The value of NormalTextColourMenu.</returns>
        public ContextMenuStrip GetNormalTextColourMenu()
        {
            return NormalTextColourMenu;
        }

        /// <summary>
        /// Sets the value of DisabledTextColourMenu to value.
        /// </summary>
        /// <param name="value">The value of DisabledTextColourMenu.</param>
        public void SetDisabledTextColourMenu(ContextMenuStrip value)
        {
            DisabledTextColourMenu = value;
        }

        /// <summary>
        /// Returns the value of DisabledTextColourMenu.
        /// </summary>
        /// <returns>The value of DisabledTextColourMenu.</returns>
        public ContextMenuStrip GetDisabledTextColourMenu()
        {
            return DisabledTextColourMenu;
        }

        /// <summary>
        /// Sets the value of FocusedTextColourMenu to value.
        /// </summary>
        /// <param name="value">The value of FocusedTextColourMenu.</param>
        public void SetFocusedTextColourMenu(ContextMenuStrip value)
        {
            FocusedTextColourMenu = value;
        }

        /// <summary>
        /// Returns the value of FocusedTextColourMenu.
        /// </summary>
        /// <returns>The value of FocusedTextColourMenu.</returns>
        public ContextMenuStrip GetFocusedTextColourMenu()
        {
            return FocusedTextColourMenu;
        }

        /// <summary>
        /// Sets the value of PressedTextColourMenu to value.
        /// </summary>
        /// <param name="value">The value of PressedTextColourMenu.</param>
        public void SetPressedTextColourMenu(ContextMenuStrip value)
        {
            PressedTextColourMenu = value;
        }

        /// <summary>
        /// Returns the value of PressedTextColourMenu.
        /// </summary>
        /// <returns>The value of PressedTextColourMenu.</returns>
        public ContextMenuStrip GetPressedTextColourMenu()
        {
            return PressedTextColourMenu;
        }

        /// <summary>
        /// Sets the value of DisabledControlColourMenu to value.
        /// </summary>
        /// <param name="value">The value of DisabledControlColourMenu.</param>
        public void SetDisabledControlColourMenu(ContextMenuStrip value)
        {
            DisabledControlColourMenu = value;
        }

        /// <summary>
        /// Returns the value of DisabledControlColourMenu.
        /// </summary>
        /// <returns>The value of DisabledControlColourMenu.</returns>
        public ContextMenuStrip GetDisabledControlColourMenu()
        {
            return DisabledControlColourMenu;
        }

        /// <summary>
        /// Sets the value of LinkDisabedColourMenu to value.
        /// </summary>
        /// <param name="value">The value of LinkDisabedColourMenu.</param>
        public void SetLinkDisabedColourMenu(ContextMenuStrip value)
        {
            LinkDisabedColourMenu = value;
        }

        /// <summary>
        /// Returns the value of LinkDisabedColourMenu.
        /// </summary>
        /// <returns>The value of LinkDisabedColourMenu.</returns>
        public ContextMenuStrip GetLinkDisabedColourMenu()
        {
            return LinkDisabedColourMenu;
        }

        /// <summary>
        /// Sets the value of LinkNormalColourMenu to value.
        /// </summary>
        /// <param name="value">The value of LinkNormalColourMenu.</param>
        public void SetLinkNormalColourMenu(ContextMenuStrip value)
        {
            LinkNormalColourMenu = value;
        }

        /// <summary>
        /// Returns the value of LinkNormalColourMenu.
        /// </summary>
        /// <returns>The value of LinkNormalColourMenu.</returns>
        public ContextMenuStrip GetLinkNormalColourMenu()
        {
            return LinkNormalColourMenu;
        }

        /// <summary>
        /// Sets the value of LinkFocusedColourMenu to value.
        /// </summary>
        /// <param name="value">The value of LinkFocusedColourMenu.</param>
        public void SetLinkFocusedColourMenu(ContextMenuStrip value)
        {
            LinkFocusedColourMenu = value;
        }

        /// <summary>
        /// Returns the value of LinkFocusedColourMenu.
        /// </summary>
        /// <returns>The value of LinkFocusedColourMenu.</returns>
        public ContextMenuStrip GetLinkFocusedColourMenu()
        {
            return LinkFocusedColourMenu;
        }

        /// <summary>
        /// Sets the value of LinkHoverColourMenu to value.
        /// </summary>
        /// <param name="value">The value of LinkHoverColourMenu.</param>
        public void SetLinkHoverColourMenu(ContextMenuStrip value)
        {
            LinkHoverColourMenu = value;
        }

        /// <summary>
        /// Returns the value of LinkHoverColourMenu.
        /// </summary>
        /// <returns>The value of LinkHoverColourMenu.</returns>
        public ContextMenuStrip GetLinkHoverColourMenu()
        {
            return LinkHoverColourMenu;
        }

        /// <summary>
        /// Sets the value of LinkVisitedColourMenu to value.
        /// </summary>
        /// <param name="value">The value of LinkVisitedColourMenu.</param>
        public void SetLinkVisitedColourMenu(ContextMenuStrip value)
        {
            LinkVisitedColourMenu = value;
        }

        /// <summary>
        /// Returns the value of LinkVisitedColourMenu.
        /// </summary>
        /// <returns>The value of LinkVisitedColourMenu.</returns>
        public ContextMenuStrip GetLinkVisitedColourMenu()
        {
            return LinkVisitedColourMenu;
        }

        /// <summary>
        /// Sets the value of CustomColourOneColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomColourOneColourMenu.</param>
        public void SetCustomColourOneColourMenu(ContextMenuStrip value)
        {
            CustomColourOneMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomColourOneColourMenu.
        /// </summary>
        /// <returns>The value of CustomColourOneColourMenu.</returns>
        public ContextMenuStrip GetCustomColourOneColourMenu()
        {
            return CustomColourOneMenu;
        }

        /// <summary>
        /// Sets the value of CustomColourTwoColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomColourTwoColourMenu.</param>
        public void SetCustomColourTwoColourMenu(ContextMenuStrip value)
        {
            CustomColourTwoMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomColourTwoColourMenu.
        /// </summary>
        /// <returns>The value of CustomColourTwoColourMenu.</returns>
        public ContextMenuStrip GetCustomColourTwoColourMenu()
        {
            return CustomColourTwoMenu;
        }

        /// <summary>
        /// Sets the value of CustomColourThreeColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomColourThreeColourMenu.</param>
        public void SetCustomColourThreeColourMenu(ContextMenuStrip value)
        {
            CustomColourThreeMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomColourThreeColourMenu.
        /// </summary>
        /// <returns>The value of CustomColourThreeColourMenu.</returns>
        public ContextMenuStrip GetCustomColourThreeColourMenu()
        {
            return CustomColourThreeMenu;
        }

        /// <summary>
        /// Sets the value of CustomColourFourColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomColourFourColourMenu.</param>
        public void SetCustomColourFourColourMenu(ContextMenuStrip value)
        {
            CustomColourFourMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomColourFourColourMenu.
        /// </summary>
        /// <returns>The value of CustomColourFourColourMenu.</returns>
        public ContextMenuStrip GetCustomColourFourColourMenu()
        {
            return CustomColourFourMenu;
        }

        /// <summary>
        /// Sets the value of CustomColourFiveColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomColourFiveColourMenu.</param>
        public void SetCustomColourFiveColourMenu(ContextMenuStrip value)
        {
            CustomColourFiveMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomColourFiveColourMenu.
        /// </summary>
        /// <returns>The value of CustomColourFiveColourMenu.</returns>
        public ContextMenuStrip GetCustomColourFiveColourMenu()
        {
            return CustomColourFiveMenu;
        }

        /// <summary>
        /// Sets the value of CustomColourSixColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomColourSixColourMenu.</param>
        public void SetCustomColourSixColourMenu(ContextMenuStrip value)
        {
            CustomColourSixMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomColourSixColourMenu.
        /// </summary>
        /// <returns>The value of CustomColourSixColourMenu.</returns>
        public ContextMenuStrip GetCustomColourSixColourMenu()
        {
            return CustomColourSixMenu;
        }

        /// <summary>
        /// Sets the value of CustomTextColourOneColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourOneColourMenu.</param>
        public void SetCustomTextColourOneColourMenu(ContextMenuStrip value)
        {
            CustomTextColourOneMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourOneColourMenu.
        /// </summary>
        /// <returns>The value of CustomTextColourOneColourMenu.</returns>
        public ContextMenuStrip GetCustomTextColourOneColourMenu()
        {
            return CustomTextColourOneMenu;
        }

        /// <summary>
        /// Sets the value of CustomTextColourTwoColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourTwoColourMenu.</param>
        public void SetCustomTextColourTwoColourMenu(ContextMenuStrip value)
        {
            CustomTextColourTwoMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourTwoColourMenu.
        /// </summary>
        /// <returns>The value of CustomTextColourTwoColourMenu.</returns>
        public ContextMenuStrip GetCustomTextColourTwoColourMenu()
        {
            return CustomTextColourTwoMenu;
        }

        /// <summary>
        /// Sets the value of CustomTextColourThreeColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourThreeColourMenu.</param>
        public void SetCustomTextColourThreeColourMenu(ContextMenuStrip value)
        {
            CustomTextColourThreeMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourThreeColourMenu.
        /// </summary>
        /// <returns>The value of CustomTextColourThreeColourMenu.</returns>
        public ContextMenuStrip GetCustomTextColourThreeColourMenu()
        {
            return CustomTextColourThreeMenu;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFourColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourFourColourMenu.</param>
        public void SetCustomTextColourFourColourMenu(ContextMenuStrip value)
        {
            CustomTextColourFourMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourFourColourMenu.
        /// </summary>
        /// <returns>The value of CustomTextColourFourColourMenu.</returns>
        public ContextMenuStrip GetCustomTextColourFourColourMenu()
        {
            return CustomTextColourFourMenu;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFiveColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourFiveColourMenu.</param>
        public void SetCustomTextColourFiveColourMenu(ContextMenuStrip value)
        {
            CustomTextColourFiveMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourFiveColourMenu.
        /// </summary>
        /// <returns>The value of CustomTextColourFiveColourMenu.</returns>
        public ContextMenuStrip GetCustomTextColourFiveColourMenu()
        {
            return CustomTextColourFiveMenu;
        }

        /// <summary>
        /// Sets the value of CustomTextColourSixColourMenu to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourSixColourMenu.</param>
        public void SetCustomTextColourSixColourMenu(ContextMenuStrip value)
        {
            CustomTextColourSixMenu = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourSixColourMenu.
        /// </summary>
        /// <returns>The value of CustomTextColourSixColourMenu.</returns>
        public ContextMenuStrip GetCustomTextColourSixColourMenu()
        {
            return CustomTextColourSixMenu;
        }

        /// <summary>
        /// Sets the value of MenuTextColourMenu to value.
        /// </summary>
        /// <param name="value">The value of MenuTextColourMenu.</param>
        public void SetMenuTextColourMenu(ContextMenuStrip value)
        {
            MenuTextColourMenu = value;
        }

        /// <summary>
        /// Returns the value of MenuTextColourMenu.
        /// </summary>
        /// <returns>The value of MenuTextColourMenu.</returns>
        public ContextMenuStrip GetMenuTextColourMenu()
        {
            return MenuTextColourMenu;
        }

        /// <summary>
        /// Sets the value of StatusTextColourMenu to value.
        /// </summary>
        /// <param name="value">The value of StatusTextColourMenu.</param>
        public void SetStatusTextColourMenu(ContextMenuStrip value)
        {
            StatusTextColourMenu = value;
        }

        /// <summary>
        /// Returns the value of StatusTextColourMenu.
        /// </summary>
        /// <returns>The value of StatusTextColourMenu.</returns>
        public ContextMenuStrip GetStatusTextColourMenu()
        {
            return StatusTextColourMenu;
        }

        /// <summary>
        /// Sets the value of RibbonTabTextColourMenu to value.
        /// </summary>
        /// <param name="value">The value of RibbonTabTextColourMenu.</param>
        public void SetRibbonTabTextColourMenu(ContextMenuStrip value)
        {
            RibbonTabTextColourMenu = value;
        }

        /// <summary>
        /// Returns the value of RibbonTabTextColourMenu.
        /// </summary>
        /// <returns>The value of RibbonTabTextColourMenu.</returns>
        public ContextMenuStrip GetRibbonTabTextColourMenu()
        {
            return RibbonTabTextColourMenu;
        }
        #endregion

        #endregion

        #region Methods        
        /// <summary>
        /// Assigns the context menu to control.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="contextMenu">The context menu.</param>
        private void AssignContextMenuToControl(Control control, ContextMenuStrip contextMenu)
        {
            control.ContextMenuStrip = contextMenu;
        }

        public static void SetDefaultColour(Color defaultColour, CircularPictureBoxControl control)
        {
            control.GetBaseColourPreview().BackColor = defaultColour;

            control.GetDarkColourPreview().BackColor = defaultColour;

            control.GetMiddleColourMenu().BackColor = defaultColour;

            control.GetLightColourPreview().BackColor = defaultColour;

            control.GetLightestColourPreview().BackColor = defaultColour;

            control.GetBorderColourPreview().BackColor = defaultColour;

            control.GetAlternativeNormalTextColourPreview().BackColor = defaultColour;

            control.GetNormalTextColourPreview().BackColor = defaultColour;

            control.GetDisabledTextColourPreview().BackColor = defaultColour;

            control.GetFocusedTextColourPreview().BackColor = defaultColour;

            control.GetPressedTextColourPreview().BackColor = defaultColour;

            control.GetDisabledControlColourPreview().BackColor = defaultColour;

            control.GetLinkDisabedColourPreview().BackColor = defaultColour;

            control.GetLinkNormalColourPreview().BackColor = defaultColour;

            control.GetLinkFocusedColourPreview().BackColor = defaultColour;

            control.GetLinkHoverColourPreview().BackColor = defaultColour;

            control.GetLinkVisitedColourPreview().BackColor = defaultColour;

            control.GetCustomColourOneColourPreview().BackColor = defaultColour;

            control.GetCustomColourTwoColourPreview().BackColor = defaultColour;

            control.GetCustomColourThreeColourPreview().BackColor = defaultColour;

            control.GetCustomColourFourColourPreview().BackColor = defaultColour;

            control.GetCustomColourFiveColourPreview().BackColor = defaultColour;

            control.GetCustomColourSixColourPreview().BackColor = defaultColour;

            control.GetCustomTextColourOneColourPreview().BackColor = defaultColour;

            control.GetCustomTextColourTwoColourPreview().BackColor = defaultColour;

            control.GetCustomTextColourThreeColourPreview().BackColor = defaultColour;

            control.GetCustomTextColourFourColourPreview().BackColor = defaultColour;

            control.GetCustomTextColourFiveColourPreview().BackColor = defaultColour;

            control.GetCustomTextColourSixColourPreview().BackColor = defaultColour;

            control.GetMenuTextColourPreview().BackColor = defaultColour;

            control.GetStatusTextColourPreview().BackColor = defaultColour;

            control.GetRibbonTabTextColourPreview().BackColor = defaultColour;
        }

        public static void ResetColours(CircularPictureBoxControl control)
        {
            Color transparent = Color.Transparent;

            control.GetBaseColourPreview().BackColor = transparent;

            control.GetDarkColourPreview().BackColor = transparent;

            control.GetMiddleColourMenu().BackColor = transparent;

            control.GetLightColourPreview().BackColor = transparent;

            control.GetLightestColourPreview().BackColor = transparent;

            control.GetBorderColourPreview().BackColor = transparent;

            control.GetAlternativeNormalTextColourPreview().BackColor = transparent;

            control.GetNormalTextColourPreview().BackColor = transparent;

            control.GetDisabledTextColourPreview().BackColor = transparent;

            control.GetFocusedTextColourPreview().BackColor = transparent;

            control.GetPressedTextColourPreview().BackColor = transparent;

            control.GetDisabledControlColourPreview().BackColor = transparent;

            control.GetLinkDisabedColourPreview().BackColor = transparent;

            control.GetLinkNormalColourPreview().BackColor = transparent;

            control.GetLinkFocusedColourPreview().BackColor = transparent;

            control.GetLinkHoverColourPreview().BackColor = transparent;

            control.GetLinkVisitedColourPreview().BackColor = transparent;

            control.GetCustomColourOneColourPreview().BackColor = transparent;

            control.GetCustomColourTwoColourPreview().BackColor = transparent;

            control.GetCustomColourThreeColourPreview().BackColor = transparent;

            control.GetCustomColourFourColourPreview().BackColor = transparent;

            control.GetCustomColourFiveColourPreview().BackColor = transparent;

            control.GetCustomColourSixColourPreview().BackColor = transparent;

            control.GetCustomTextColourOneColourPreview().BackColor = transparent;

            control.GetCustomTextColourTwoColourPreview().BackColor = transparent;

            control.GetCustomTextColourThreeColourPreview().BackColor = transparent;

            control.GetCustomTextColourFourColourPreview().BackColor = transparent;

            control.GetCustomTextColourFiveColourPreview().BackColor = transparent;

            control.GetCustomTextColourSixColourPreview().BackColor = transparent;

            control.GetMenuTextColourPreview().BackColor = transparent;

            control.GetStatusTextColourPreview().BackColor = transparent;

            control.GetRibbonTabTextColourPreview().BackColor = transparent;
        }

        public static void ResetColours()
        {
            CircularPictureBoxControl control = new CircularPictureBoxControl();

            try
            {
                if (control._boxListCollection.Count > 0)
                {
                    foreach (CircularPictureBox box in control._boxListCollection)
                    {
                        box.BackColor = Color.Transparent;
                    }
                }
            }
            catch (Exception exc)
            {

                throw;
            }
        }

        public static void ResetColours(Color defaultColour)
        {
            CircularPictureBoxControl control = new CircularPictureBoxControl();

            try
            {
                foreach (CircularPictureBox box in control._boxListCollection)
                {
                    box.BackColor = defaultColour;
                }
            }
            catch (Exception exc)
            {

                throw;
            }
        }

        public void ResetPaletteColours()
        {
            try
            {
                if (_boxListCollection.Count > 0)
                {
                    foreach (CircularPictureBox box in _boxListCollection)
                    {
                        box.BackColor = Color.Transparent;
                    }
                }
            }
            catch (Exception exc)
            {

                throw;
            }
        }

        public void ResetPaletteColours(Color defaultColour)
        {
            try
            {
                foreach (CircularPictureBox box in _boxListCollection)
                {
                    box.BackColor = defaultColour;
                }
            }
            catch (Exception exc)
            {

                throw;
            }
        }

        /// <summary>
        /// Adds to box list collection.
        /// </summary>
        /// <param name="box">The box.</param>
        private void AddToBoxListCollection(CircularPictureBox box)
        {
            try
            {
                _boxListCollection.Add(box);
            }
            catch (Exception e)
            {
                ExceptionHandler.CaptureException(e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool AreAllColoursEmpty()
        {
            if (GetBaseColourPreview().BackColor == Color.Empty && GetDarkColourPreview().BackColor == Color.Empty && GetMiddleColourPreview().BackColor == Color.Empty && GetLightColourPreview().BackColor == Color.Empty && GetLightestColourPreview().BackColor == Color.Empty && GetBorderColourPreview().BackColor == Color.Empty && GetAlternativeNormalTextColourPreview().BackColor == Color.Empty && GetNormalTextColourPreview().BackColor == Color.Empty && GetDisabledTextColourPreview().BackColor == Color.Empty && GetFocusedTextColourPreview().BackColor == Color.Empty && GetPressedTextColourPreview().BackColor == Color.Empty && GetDisabledControlColourPreview().BackColor == Color.Empty && GetLinkDisabedColourPreview().BackColor == Color.Empty && GetLinkFocusedColourPreview().BackColor == Color.Empty && GetLinkHoverColourPreview().BackColor == Color.Empty && GetLinkNormalColourPreview().BackColor == Color.Empty && GetLinkVisitedColourPreview().BackColor == Color.Empty && GetCustomColourOneColourPreview().BackColor == Color.Empty && GetCustomColourTwoColourPreview().BackColor == Color.Empty && GetCustomColourThreeColourPreview().BackColor == Color.Empty && GetCustomColourFourColourPreview().BackColor == Color.Empty && GetCustomColourFiveColourPreview().BackColor == Color.Empty && GetCustomColourSixColourPreview().BackColor == Color.Empty && GetCustomTextColourOneColourPreview().BackColor == Color.Empty && GetCustomTextColourTwoColourPreview().BackColor == Color.Empty && GetCustomTextColourThreeColourPreview().BackColor == Color.Empty && GetCustomTextColourFourColourPreview().BackColor == Color.Empty && GetCustomTextColourFiveColourPreview().BackColor == Color.Empty && GetCustomTextColourSixColourPreview().BackColor == Color.Empty && GetMenuTextColourPreview().BackColor == Color.Empty && GetStatusTextColourPreview().BackColor == Color.Empty && GetRibbonTabTextColourPreview().BackColor == Color.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static new Color RandomiseColour()
        {
            Random rnd = new Random();

            return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        public void InspireMe(bool usePrompt = false)
        {
            if (usePrompt)
            {
                if (!AreAllColoursEmpty())
                {
                    DialogResult result = ExtendedKryptonMessageBox.Show("All colours are not empty, do you want to reset them now?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        ResetColours(Color.Empty);

                        GenerateAllColours();
                    }
                }
                else
                {
                    GenerateAllColours();
                }
            }
            else
            {
                GenerateAllColours();
            }
        }

        private void GenerateAllColours()
        {
            #region Basic Colours
            GetBaseColourPreview().BackColor = RandomisePaletteColours.ReturnBaseColour();

            GetDarkColourPreview().BackColor = RandomisePaletteColours.ReturnDarkColour();

            GetMiddleColourPreview().BackColor = RandomisePaletteColours.ReturnMiddleColour();

            GetLightColourPreview().BackColor = RandomisePaletteColours.ReturnLightColour();

            GetLightestColourPreview().BackColor = RandomisePaletteColours.ReturnLightestColour();
            #endregion
        }
        #endregion

        #region Refresh UI
        /// <summary>
        /// Refreshes all colours.
        /// </summary>
        public void RefreshColours()
        {
            #region Variables
            BasicColourSettingsManager basicColourSettingsManager = new BasicColourSettingsManager();

            CustomColourSettingsManager customColourSettingsManager = new CustomColourSettingsManager();

            CustomTextColourSettingsManager customTextColourSettingsManager = new CustomTextColourSettingsManager();

            LinkTextColourSettingsManager linkTextColourSettingsManager = new LinkTextColourSettingsManager();

            MiscellaneousColourSettingsManager miscellaneousColourSettingsManager = new MiscellaneousColourSettingsManager();

            StandardControlTextColourSettingsManager standardControlTextColourSettingsManager = new StandardControlTextColourSettingsManager();

            TextColourSettingsManager textColourSettingsManager = new TextColourSettingsManager();
            #endregion

            #region Basics
            GetBaseColourPreview().BackColor = basicColourSettingsManager.GetBaseColour();

            GetDarkColourPreview().BackColor = basicColourSettingsManager.GetDarkColour();

            GetMiddleColourPreview().BackColor = basicColourSettingsManager.GetMediumColour();

            GetLightColourPreview().BackColor = basicColourSettingsManager.GetLightColour();

            GetLightestColourPreview().BackColor = basicColourSettingsManager.GetLightestColour();
            #endregion

            #region Custom Colours
            GetCustomColourOneColourPreview().BackColor = customColourSettingsManager.GetCustomColourOne();

            GetCustomColourTwoColourPreview().BackColor = customColourSettingsManager.GetCustomColourTwo();

            GetCustomColourThreeColourPreview().BackColor = customColourSettingsManager.GetCustomColourThree();

            GetCustomColourFourColourPreview().BackColor = customColourSettingsManager.GetCustomColourFour();

            GetCustomColourFiveColourPreview().BackColor = customColourSettingsManager.GetCustomColourFive();

            GetCustomColourSixColourPreview().BackColor = customColourSettingsManager.GetCustomColourSix();
            #endregion

            #region Custom Text Colours
            GetCustomTextColourOneColourPreview().BackColor = customTextColourSettingsManager.GetCustomTextColourOne();

            GetCustomTextColourTwoColourPreview().BackColor = customTextColourSettingsManager.GetCustomTextColourTwo();

            GetCustomTextColourThreeColourPreview().BackColor = customTextColourSettingsManager.GetCustomTextColourThree();

            GetCustomTextColourFourColourPreview().BackColor = customTextColourSettingsManager.GetCustomTextColourFour();

            GetCustomTextColourFiveColourPreview().BackColor = customTextColourSettingsManager.GetCustomTextColourFive();

            GetCustomTextColourSixColourPreview().BackColor = customTextColourSettingsManager.GetCustomTextColourSix();
            #endregion

            #region Link Text Colours
            GetLinkDisabedColourPreview().BackColor = linkTextColourSettingsManager.GetLinkDisabledColour();

            GetLinkFocusedColourPreview().BackColor = linkTextColourSettingsManager.GetLinkFocusedColour();

            GetLinkHoverColourPreview().BackColor = linkTextColourSettingsManager.GetLinkHoverColour();

            GetLinkNormalColourPreview().BackColor = linkTextColourSettingsManager.GetLinkNormalColour();

            GetLinkVisitedColourMenu().BackColor = linkTextColourSettingsManager.GetLinkVisitedColour();
            #endregion

            #region Miscellaneous Colours
            GetBorderColourPreview().BackColor = miscellaneousColourSettingsManager.GetBorderColour();

            GetDisabledControlColourPreview().BackColor = miscellaneousColourSettingsManager.GetDisabledControlColour();
            #endregion

            #region Standard Control Text Colours
            GetMenuTextColourPreview().BackColor = standardControlTextColourSettingsManager.GetMenuTextColour();

            GetStatusTextColourPreview().BackColor = standardControlTextColourSettingsManager.GetStatusStripTextColour();

            GetRibbonTabTextColourPreview().BackColor = standardControlTextColourSettingsManager.GetRibbonTabTextColour();
            #endregion

            #region Text Colours
            GetAlternativeNormalTextColourPreview().BackColor = textColourSettingsManager.GetAlternativeNormalTextColour();

            GetDisabledTextColourPreview().BackColor = textColourSettingsManager.GetDisabledTextColour();

            GetFocusedTextColourPreview().BackColor = textColourSettingsManager.GetFocusedTextColour();

            GetNormalTextColourPreview().BackColor = textColourSettingsManager.GetNormalTextColour();

            GetPressedTextColourPreview().BackColor = textColourSettingsManager.GetPressedTextColour();
            #endregion
        }
        #endregion
    }
}