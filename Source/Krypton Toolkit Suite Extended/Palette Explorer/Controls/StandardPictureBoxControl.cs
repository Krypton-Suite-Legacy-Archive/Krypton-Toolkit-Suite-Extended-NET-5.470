using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletteExplorer.Controls
{
    public class StandardPictureBoxControl : UserControl
    {
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbPreviewPane;
        private PictureBox pbxLinkFocusedColourPreview;
        private PictureBox pictureBox5;
        private PictureBox pbxRibbonTabTextColourPreview;
        private PictureBox pbxStatusTextColourPreview;
        private PictureBox pbxMenuTextColourPreview;
        private PictureBox pbxCustomColourFourPreview;
        private PictureBox pbxCustomTextColourFivePreview;
        private PictureBox pbxCustomTextColourFourPreview;
        private PictureBox pbxCustomTextColourThreePreview;
        private PictureBox pbxCustomTextColourTwoPreview;
        private PictureBox pbxCustomTextColourOnePreview;
        private PictureBox pbxCustomColourFivePreview;
        private PictureBox pbxCustomColourThreePreview;
        private PictureBox pbxCustomColourTwoPreview;
        private PictureBox pbxCustomColourOnePreview;
        private PictureBox pbxLinkVisitedColourPreview;
        private PictureBox pbxLinkHoverColourPreview;
        private PictureBox pbxAlternativeNormalTextColour;
        private PictureBox pbxLinkNormalColourPreview;
        private PictureBox pbxDisabledColourPreview;
        private PictureBox pbxPressedTextColourPreview;
        private PictureBox pbxFocusedTextColourPreview;
        private PictureBox pbxDisabledTextColourPreview;
        private PictureBox pbxNormalTextColourPreview;
        private PictureBox pbxBorderColourPreview;
        private PictureBox pbxBaseColour;
        private PictureBox pbxLightestColour;
        private PictureBox pbxDarkColour;
        private PictureBox pbxLightColour;
        private ContextMenuStrip ctxRibbonTabTextColour;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem tsmiRibbonTabTextColour;
        private ContextMenuStrip ctxMenuTextColour;
        private ToolStripMenuItem tsmiMenuTextColour;
        private ContextMenuStrip ctxCustomTextColourSixColour;
        private ToolStripMenuItem tsmiCustomTextColourSixColour;
        private ContextMenuStrip ctxCustomTextColourFiveColour;
        private ToolStripMenuItem tsmiCustomTextColourFiveColour;
        private ContextMenuStrip ctxCustomTextColourFourColour;
        private ToolStripMenuItem tsmiCustomTextColourFourColour;
        private ContextMenuStrip ctxCustomTextColourThreeColour;
        private ToolStripMenuItem tsmiCustomTextColourThreeColour;
        private ContextMenuStrip ctxCustomTextColourTwoColour;
        private ToolStripMenuItem tsmiCustomTextColourTwoColour;
        private ContextMenuStrip ctxCustomTextColourOneColour;
        private ToolStripMenuItem tsmiCustomTextColourOneColour;
        private ContextMenuStrip ctxCustomColourSixColour;
        private ToolStripMenuItem tsmiCustomColourSixColour;
        private ContextMenuStrip ctxCustomColourOneColour;
        private ToolStripMenuItem tsmiCustomColourOneColour;
        private ContextMenuStrip ctxLinkVisitedTextColour;
        private ToolStripMenuItem tsmiLinkVisitedTextColour;
        private ContextMenuStrip ctxLinkHoverTextColour;
        private ToolStripMenuItem tsmiLinkHoverTextColour;
        private ContextMenuStrip ctxAlternativeNormalTextColour;
        private ToolStripMenuItem tsmiAlternativeNormalTextColour;
        private ContextMenuStrip ctxBorderColour;
        private ToolStripMenuItem tsmiBorderColour;
        private ContextMenuStrip ctxStatusStripTextColour;
        private ToolStripMenuItem tsmiStatusStripTextColour;
        private ContextMenuStrip ctxNormalTextColour;
        private ToolStripMenuItem tsmiNormalTextColour;
        private ContextMenuStrip ctxDisabledControlColour;
        private ToolStripMenuItem tsmiDisabledControlColour;
        private ContextMenuStrip ctxDisabedTextColour;
        private ToolStripMenuItem tsmiDisabledTextColour;
        private ContextMenuStrip ctxFocusedTextColour;
        private ToolStripMenuItem tsmiFocusedTextColour;
        private ContextMenuStrip ctxPressedTextColour;
        private ToolStripMenuItem tsmiPressedTextColour;
        private ContextMenuStrip ctxLinkFocusedTextColour;
        private ToolStripMenuItem tsmiLinkFocusedTextColour;
        private ContextMenuStrip ctxCustomColourFiveColour;
        private ToolStripMenuItem tsmlCustomColourFiveColour;
        private ContextMenuStrip ctxCustomColourFourColour;
        private ToolStripMenuItem tsmiCustomColourFourColour;
        private ContextMenuStrip ctxCustomColourThreeColour;
        private ToolStripMenuItem tsmiCustomColourThreeColour;
        private ContextMenuStrip ctxCustomColourTwoColour;
        private ToolStripMenuItem tsmiCustomColourTwoColour;
        private ContextMenuStrip ctxBaseColour;
        private ToolStripMenuItem useBaseColourAsBaseToolStripMenuItem;
        private ContextMenuStrip ctxDarkColour;
        private ToolStripMenuItem tsiDarkColour;
        private ContextMenuStrip ctxMediumColour;
        private ToolStripMenuItem tsmiMediumColour;
        private ContextMenuStrip ctxLightColour;
        private ToolStripMenuItem tsmiLightColour;
        private ContextMenuStrip ctxLinkNormalTextColour;
        private ToolStripMenuItem tsmiLinkNormalTextColour;
        private ContextMenuStrip ctxLightestColour;
        private ToolStripMenuItem tsmiLightestColour;
        private PictureBox pbxMiddleColour;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
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
            this.ctxRibbonTabTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRibbonTabTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMenuTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourSixColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourSixColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourFiveColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourFiveColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourFourColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourFourColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourThreeColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourThreeColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourTwoColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourTwoColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomTextColourOneColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomTextColourOneColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourSixColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomColourSixColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourOneColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomColourOneColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLinkVisitedTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLinkVisitedTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLinkHoverTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLinkHoverTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxAlternativeNormalTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAlternativeNormalTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBorderColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBorderColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxStatusStripTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiStatusStripTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxNormalTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNormalTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDisabledControlColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDisabledControlColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDisabedTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDisabledTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFocusedTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFocusedTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPressedTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPressedTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLinkFocusedTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLinkFocusedTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourFiveColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmlCustomColourFiveColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourFourColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomColourFourColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourThreeColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomColourThreeColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomColourTwoColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCustomColourTwoColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBaseColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.useBaseColourAsBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDarkColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiDarkColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMediumColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMediumColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLightColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLightColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLinkNormalTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLinkNormalTextColour = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLightestColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLightestColour = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ctxRibbonTabTextColour.SuspendLayout();
            this.ctxMenuTextColour.SuspendLayout();
            this.ctxCustomTextColourSixColour.SuspendLayout();
            this.ctxCustomTextColourFiveColour.SuspendLayout();
            this.ctxCustomTextColourFourColour.SuspendLayout();
            this.ctxCustomTextColourThreeColour.SuspendLayout();
            this.ctxCustomTextColourTwoColour.SuspendLayout();
            this.ctxCustomTextColourOneColour.SuspendLayout();
            this.ctxCustomColourSixColour.SuspendLayout();
            this.ctxCustomColourOneColour.SuspendLayout();
            this.ctxLinkVisitedTextColour.SuspendLayout();
            this.ctxLinkHoverTextColour.SuspendLayout();
            this.ctxAlternativeNormalTextColour.SuspendLayout();
            this.ctxBorderColour.SuspendLayout();
            this.ctxStatusStripTextColour.SuspendLayout();
            this.ctxNormalTextColour.SuspendLayout();
            this.ctxDisabledControlColour.SuspendLayout();
            this.ctxDisabedTextColour.SuspendLayout();
            this.ctxFocusedTextColour.SuspendLayout();
            this.ctxPressedTextColour.SuspendLayout();
            this.ctxLinkFocusedTextColour.SuspendLayout();
            this.ctxCustomColourFiveColour.SuspendLayout();
            this.ctxCustomColourFourColour.SuspendLayout();
            this.ctxCustomColourThreeColour.SuspendLayout();
            this.ctxCustomColourTwoColour.SuspendLayout();
            this.ctxBaseColour.SuspendLayout();
            this.ctxDarkColour.SuspendLayout();
            this.ctxMediumColour.SuspendLayout();
            this.ctxLightColour.SuspendLayout();
            this.ctxLinkNormalTextColour.SuspendLayout();
            this.ctxLightestColour.SuspendLayout();
            this.SuspendLayout();
            // 
            // kgbPreviewPane
            // 
            this.kgbPreviewPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kgbPreviewPane.Location = new System.Drawing.Point(0, 0);
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
            this.kgbPreviewPane.Size = new System.Drawing.Size(1625, 660);
            this.kgbPreviewPane.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbPreviewPane.TabIndex = 13;
            popupPositionValues1.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kgbPreviewPane.ToolTipValues.ToolTipPosition = popupPositionValues1;
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
            // ctxRibbonTabTextColour
            // 
            this.ctxRibbonTabTextColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxRibbonTabTextColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRibbonTabTextColour});
            this.ctxRibbonTabTextColour.Name = "ctxBaseColour";
            this.ctxRibbonTabTextColour.Size = new System.Drawing.Size(261, 26);
            // 
            // tsmiRibbonTabTextColour
            // 
            this.tsmiRibbonTabTextColour.Name = "tsmiRibbonTabTextColour";
            this.tsmiRibbonTabTextColour.Size = new System.Drawing.Size(260, 22);
            this.tsmiRibbonTabTextColour.Text = "Use &Ribbon Tab Text Colour as Base";
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
            // 
            // ctxCustomTextColourSixColour
            // 
            this.ctxCustomTextColourSixColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourSixColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomTextColourSixColour});
            this.ctxCustomTextColourSixColour.Name = "ctxBaseColour";
            this.ctxCustomTextColourSixColour.Size = new System.Drawing.Size(299, 26);
            // 
            // tsmiCustomTextColourSixColour
            // 
            this.tsmiCustomTextColourSixColour.Name = "tsmiCustomTextColourSixColour";
            this.tsmiCustomTextColourSixColour.Size = new System.Drawing.Size(298, 22);
            this.tsmiCustomTextColourSixColour.Text = "Use Custom Text Colour &Six Colour as Base";
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
            // 
            // ctxCustomTextColourThreeColour
            // 
            this.ctxCustomTextColourThreeColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourThreeColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomTextColourThreeColour});
            this.ctxCustomTextColourThreeColour.Name = "ctxBaseColour";
            this.ctxCustomTextColourThreeColour.Size = new System.Drawing.Size(315, 26);
            // 
            // tsmiCustomTextColourThreeColour
            // 
            this.tsmiCustomTextColourThreeColour.Name = "tsmiCustomTextColourThreeColour";
            this.tsmiCustomTextColourThreeColour.Size = new System.Drawing.Size(314, 22);
            this.tsmiCustomTextColourThreeColour.Text = "Use Custom Text Colour &Three Colour as Base";
            // 
            // ctxCustomTextColourTwoColour
            // 
            this.ctxCustomTextColourTwoColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomTextColourTwoColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomTextColourTwoColour});
            this.ctxCustomTextColourTwoColour.Name = "ctxBaseColour";
            this.ctxCustomTextColourTwoColour.Size = new System.Drawing.Size(307, 26);
            // 
            // tsmiCustomTextColourTwoColour
            // 
            this.tsmiCustomTextColourTwoColour.Name = "tsmiCustomTextColourTwoColour";
            this.tsmiCustomTextColourTwoColour.Size = new System.Drawing.Size(306, 22);
            this.tsmiCustomTextColourTwoColour.Text = "Use Custom Text Colour &Two Colour as Base";
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
            // 
            // ctxCustomColourSixColour
            // 
            this.ctxCustomColourSixColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourSixColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomColourSixColour});
            this.ctxCustomColourSixColour.Name = "ctxBaseColour";
            this.ctxCustomColourSixColour.Size = new System.Drawing.Size(275, 26);
            // 
            // tsmiCustomColourSixColour
            // 
            this.tsmiCustomColourSixColour.Name = "tsmiCustomColourSixColour";
            this.tsmiCustomColourSixColour.Size = new System.Drawing.Size(274, 22);
            this.tsmiCustomColourSixColour.Text = "Use Custom Colour &Six Colour as Base";
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
            // 
            // ctxCustomColourThreeColour
            // 
            this.ctxCustomColourThreeColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourThreeColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomColourThreeColour});
            this.ctxCustomColourThreeColour.Name = "ctxBaseColour";
            this.ctxCustomColourThreeColour.Size = new System.Drawing.Size(291, 26);
            // 
            // tsmiCustomColourThreeColour
            // 
            this.tsmiCustomColourThreeColour.Name = "tsmiCustomColourThreeColour";
            this.tsmiCustomColourThreeColour.Size = new System.Drawing.Size(290, 22);
            this.tsmiCustomColourThreeColour.Text = "Use Custom Colour &Three Colour as Base";
            // 
            // ctxCustomColourTwoColour
            // 
            this.ctxCustomColourTwoColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCustomColourTwoColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomColourTwoColour});
            this.ctxCustomColourTwoColour.Name = "ctxBaseColour";
            this.ctxCustomColourTwoColour.Size = new System.Drawing.Size(283, 26);
            // 
            // tsmiCustomColourTwoColour
            // 
            this.tsmiCustomColourTwoColour.Name = "tsmiCustomColourTwoColour";
            this.tsmiCustomColourTwoColour.Size = new System.Drawing.Size(282, 22);
            this.tsmiCustomColourTwoColour.Text = "Use Custom Colour &Two Colour as Base";
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
            // 
            // ctxLightestColour
            // 
            this.ctxLightestColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxLightestColour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLightestColour});
            this.ctxLightestColour.Name = "ctxBaseColour";
            this.ctxLightestColour.Size = new System.Drawing.Size(219, 48);
            // 
            // tsmiLightestColour
            // 
            this.tsmiLightestColour.Name = "tsmiLightestColour";
            this.tsmiLightestColour.Size = new System.Drawing.Size(218, 22);
            this.tsmiLightestColour.Text = "Use &Lightest Colour as Base";
            // 
            // StandardPictureBoxControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kgbPreviewPane);
            this.Name = "StandardPictureBoxControl";
            this.Size = new System.Drawing.Size(1625, 660);
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
            this.ctxRibbonTabTextColour.ResumeLayout(false);
            this.ctxMenuTextColour.ResumeLayout(false);
            this.ctxCustomTextColourSixColour.ResumeLayout(false);
            this.ctxCustomTextColourFiveColour.ResumeLayout(false);
            this.ctxCustomTextColourFourColour.ResumeLayout(false);
            this.ctxCustomTextColourThreeColour.ResumeLayout(false);
            this.ctxCustomTextColourTwoColour.ResumeLayout(false);
            this.ctxCustomTextColourOneColour.ResumeLayout(false);
            this.ctxCustomColourSixColour.ResumeLayout(false);
            this.ctxCustomColourOneColour.ResumeLayout(false);
            this.ctxLinkVisitedTextColour.ResumeLayout(false);
            this.ctxLinkHoverTextColour.ResumeLayout(false);
            this.ctxAlternativeNormalTextColour.ResumeLayout(false);
            this.ctxBorderColour.ResumeLayout(false);
            this.ctxStatusStripTextColour.ResumeLayout(false);
            this.ctxNormalTextColour.ResumeLayout(false);
            this.ctxDisabledControlColour.ResumeLayout(false);
            this.ctxDisabedTextColour.ResumeLayout(false);
            this.ctxFocusedTextColour.ResumeLayout(false);
            this.ctxPressedTextColour.ResumeLayout(false);
            this.ctxLinkFocusedTextColour.ResumeLayout(false);
            this.ctxCustomColourFiveColour.ResumeLayout(false);
            this.ctxCustomColourFourColour.ResumeLayout(false);
            this.ctxCustomColourThreeColour.ResumeLayout(false);
            this.ctxCustomColourTwoColour.ResumeLayout(false);
            this.ctxBaseColour.ResumeLayout(false);
            this.ctxDarkColour.ResumeLayout(false);
            this.ctxMediumColour.ResumeLayout(false);
            this.ctxLightColour.ResumeLayout(false);
            this.ctxLinkNormalTextColour.ResumeLayout(false);
            this.ctxLightestColour.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}