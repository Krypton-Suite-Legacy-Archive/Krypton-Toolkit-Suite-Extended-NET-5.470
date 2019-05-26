#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

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
        #region Designer Code
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbPreviewPane;
        private PictureBox pbxLinkFocusedColourPreview;
        private PictureBox pbxCustomColourSixPreview;
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
        private PictureBox pbxAlternativeNormalTextColourPreview;
        private PictureBox pbxLinkNormalColourPreview;
        private PictureBox pbxDisabledControlColourPreview;
        private PictureBox pbxPressedTextColourPreview;
        private PictureBox pbxFocusedTextColourPreview;
        private PictureBox pbxDisabledTextColourPreview;
        private PictureBox pbxNormalTextColourPreview;
        private PictureBox pbxBorderColourPreview;
        private PictureBox pbxBaseColourPreview;
        private PictureBox pbxLightestColourPreview;
        private PictureBox pbxDarkColourPreview;
        private PictureBox pbxLightColourPreview;
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
        private PictureBox pbxCustomTextColourSixPreview;
        private PictureBox pbxLinkDisabledColourPreview;
        private ContextMenuStrip ctxLinkDisabledTextColour;
        private ToolStripMenuItem useLinkDisabledTextColourAsBaseToolStripMenuItem;
        private PictureBox pbxMediumColourPreview;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kgbPreviewPane = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pbxCustomTextColourSixPreview = new System.Windows.Forms.PictureBox();
            this.pbxLinkFocusedColourPreview = new System.Windows.Forms.PictureBox();
            this.pbxCustomColourSixPreview = new System.Windows.Forms.PictureBox();
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
            this.pbxMediumColourPreview = new System.Windows.Forms.PictureBox();
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
            this.pbxLinkDisabledColourPreview = new System.Windows.Forms.PictureBox();
            this.ctxLinkDisabledTextColour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.useLinkDisabledTextColourAsBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPreviewPane.Panel)).BeginInit();
            this.kgbPreviewPane.Panel.SuspendLayout();
            this.kgbPreviewPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourSixPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkFocusedColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourSixPreview)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxMediumColourPreview)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkDisabledColourPreview)).BeginInit();
            this.ctxLinkDisabledTextColour.SuspendLayout();
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
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLinkDisabledColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomTextColourSixPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLinkFocusedColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxCustomColourSixPreview);
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
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxAlternativeNormalTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLinkNormalColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxDisabledControlColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxPressedTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxFocusedTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxDisabledTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxNormalTextColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxBorderColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxBaseColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLightestColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxDarkColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxLightColourPreview);
            this.kgbPreviewPane.Panel.Controls.Add(this.pbxMediumColourPreview);
            this.kgbPreviewPane.Size = new System.Drawing.Size(1625, 660);
            this.kgbPreviewPane.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbPreviewPane.TabIndex = 13;
            this.kgbPreviewPane.Values.Heading = "Colour Preview";
            // 
            // pbxCustomTextColourSixPreview
            // 
            this.pbxCustomTextColourSixPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomTextColourSixPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomTextColourSixPreview.Location = new System.Drawing.Point(887, 549);
            this.pbxCustomTextColourSixPreview.Name = "pbxCustomTextColourSixPreview";
            this.pbxCustomTextColourSixPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomTextColourSixPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomTextColourSixPreview.TabIndex = 88;
            this.pbxCustomTextColourSixPreview.TabStop = false;
            // 
            // pbxLinkFocusedColourPreview
            // 
            this.pbxLinkFocusedColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkFocusedColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkFocusedColourPreview.Location = new System.Drawing.Point(1321, 193);
            this.pbxLinkFocusedColourPreview.Name = "pbxLinkFocusedColourPreview";
            this.pbxLinkFocusedColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLinkFocusedColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkFocusedColourPreview.TabIndex = 87;
            this.pbxLinkFocusedColourPreview.TabStop = false;
            // 
            // pbxCustomColourSixPreview
            // 
            this.pbxCustomColourSixPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxCustomColourSixPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCustomColourSixPreview.Location = new System.Drawing.Point(1321, 371);
            this.pbxCustomColourSixPreview.Name = "pbxCustomColourSixPreview";
            this.pbxCustomColourSixPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxCustomColourSixPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCustomColourSixPreview.TabIndex = 86;
            this.pbxCustomColourSixPreview.TabStop = false;
            // 
            // pbxRibbonTabTextColourPreview
            // 
            this.pbxRibbonTabTextColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxRibbonTabTextColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxRibbonTabTextColourPreview.Location = new System.Drawing.Point(1538, 549);
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
            this.pbxStatusTextColourPreview.Location = new System.Drawing.Point(1321, 549);
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
            this.pbxMenuTextColourPreview.Location = new System.Drawing.Point(1104, 549);
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
            this.pbxCustomColourFourPreview.Location = new System.Drawing.Point(887, 371);
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
            this.pbxCustomTextColourFivePreview.Location = new System.Drawing.Point(670, 549);
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
            this.pbxCustomTextColourFourPreview.Location = new System.Drawing.Point(453, 549);
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
            this.pbxCustomTextColourThreePreview.Location = new System.Drawing.Point(236, 549);
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
            this.pbxCustomTextColourTwoPreview.Location = new System.Drawing.Point(19, 549);
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
            this.pbxCustomTextColourOnePreview.Location = new System.Drawing.Point(1538, 371);
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
            this.pbxCustomColourFivePreview.Location = new System.Drawing.Point(1104, 371);
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
            this.pbxCustomColourThreePreview.Location = new System.Drawing.Point(670, 371);
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
            this.pbxCustomColourTwoPreview.Location = new System.Drawing.Point(453, 371);
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
            this.pbxCustomColourOnePreview.Location = new System.Drawing.Point(236, 371);
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
            this.pbxLinkVisitedColourPreview.Location = new System.Drawing.Point(19, 371);
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
            this.pbxLinkHoverColourPreview.Location = new System.Drawing.Point(1538, 193);
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
            this.pbxAlternativeNormalTextColourPreview.Location = new System.Drawing.Point(1321, 16);
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
            this.pbxLinkNormalColourPreview.Location = new System.Drawing.Point(1104, 193);
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
            this.pbxDisabledControlColourPreview.Location = new System.Drawing.Point(670, 193);
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
            // pbxBaseColourPreview
            // 
            this.pbxBaseColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxBaseColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.pbxLightestColourPreview.Location = new System.Drawing.Point(887, 16);
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
            this.pbxDarkColourPreview.Location = new System.Drawing.Point(236, 16);
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
            this.pbxLightColourPreview.Location = new System.Drawing.Point(670, 16);
            this.pbxLightColourPreview.Name = "pbxLightColourPreview";
            this.pbxLightColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLightColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLightColourPreview.TabIndex = 7;
            this.pbxLightColourPreview.TabStop = false;
            // 
            // pbxMediumColourPreview
            // 
            this.pbxMediumColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxMediumColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMediumColourPreview.Location = new System.Drawing.Point(453, 16);
            this.pbxMediumColourPreview.Name = "pbxMediumColourPreview";
            this.pbxMediumColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxMediumColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxMediumColourPreview.TabIndex = 6;
            this.pbxMediumColourPreview.TabStop = false;
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
            this.ctxCustomTextColourSixColour.Size = new System.Drawing.Size(300, 26);
            // 
            // tsmiCustomTextColourSixColour
            // 
            this.tsmiCustomTextColourSixColour.Name = "tsmiCustomTextColourSixColour";
            this.tsmiCustomTextColourSixColour.Size = new System.Drawing.Size(299, 22);
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
            this.ctxCustomTextColourThreeColour.Size = new System.Drawing.Size(314, 26);
            // 
            // tsmiCustomTextColourThreeColour
            // 
            this.tsmiCustomTextColourThreeColour.Name = "tsmiCustomTextColourThreeColour";
            this.tsmiCustomTextColourThreeColour.Size = new System.Drawing.Size(313, 22);
            this.tsmiCustomTextColourThreeColour.Text = "Use Custom Text Colour &Three Colour as Base";
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
            this.ctxCustomColourSixColour.Size = new System.Drawing.Size(276, 26);
            // 
            // tsmiCustomColourSixColour
            // 
            this.tsmiCustomColourSixColour.Name = "tsmiCustomColourSixColour";
            this.tsmiCustomColourSixColour.Size = new System.Drawing.Size(275, 22);
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
            this.ctxCustomColourThreeColour.Size = new System.Drawing.Size(290, 26);
            // 
            // tsmiCustomColourThreeColour
            // 
            this.tsmiCustomColourThreeColour.Name = "tsmiCustomColourThreeColour";
            this.tsmiCustomColourThreeColour.Size = new System.Drawing.Size(289, 22);
            this.tsmiCustomColourThreeColour.Text = "Use Custom Colour &Three Colour as Base";
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
            this.ctxLightestColour.Size = new System.Drawing.Size(219, 26);
            // 
            // tsmiLightestColour
            // 
            this.tsmiLightestColour.Name = "tsmiLightestColour";
            this.tsmiLightestColour.Size = new System.Drawing.Size(218, 22);
            this.tsmiLightestColour.Text = "Use &Lightest Colour as Base";
            // 
            // pbxLinkDisabledColourPreview
            // 
            this.pbxLinkDisabledColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxLinkDisabledColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLinkDisabledColourPreview.ContextMenuStrip = this.ctxLinkDisabledTextColour;
            this.pbxLinkDisabledColourPreview.Location = new System.Drawing.Point(887, 193);
            this.pbxLinkDisabledColourPreview.Name = "pbxLinkDisabledColourPreview";
            this.pbxLinkDisabledColourPreview.Size = new System.Drawing.Size(64, 64);
            this.pbxLinkDisabledColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLinkDisabledColourPreview.TabIndex = 89;
            this.pbxLinkDisabledColourPreview.TabStop = false;
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
            this.useLinkDisabledTextColourAsBaseToolStripMenuItem.Text = "Use Link Disabl&ed Text Colour as Base";
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomTextColourSixPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkFocusedColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustomColourSixPreview)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxMediumColourPreview)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinkDisabledColourPreview)).EndInit();
            this.ctxLinkDisabledTextColour.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private PictureBox baseColourPreview, darkColourPreview, middleColourPreview, lightColourPreview, lightestColourPreview, borderColourPreview, alternativeNormalTextColourPreview, normalTextColourPreview, disabledTextColourPreview, focusedTextColourPreview, pressedTextColourPreview, disabledControlColourPreview, linkNormalColourPreview, linkFocusedColourPreview, linkHoverColourPreview, linkVisitedColourPreview, customColourOnePreview, customColourTwoPreview, customColourThreePreview, customColourFourPreview, customColourFivePreview, customColourSixPreview, customTextColourOnePreview, customTextColourTwoPreview, customTextColourThreePreview, customTextColourFourPreview, customTextColourFivePreview, customTextColourSixPreview, menuTextColourPreview, statusTextColourPreview, ribbonTabTextColourPreview;

        private ContextMenuStrip baseColourMenu, darkColourMenu, middleColourMenu, lightColourMenu, lightestColourMenu, borderColourMenu, alternativeNormalTextColourMenu, normalTextColourMenu, disabledTextColourMenu, focusedTextColourMenu, pressedTextColourMenu, disabledControlColourMenu, linkNormalColourMenu, linkFocusedColourMenu, linkHoverColourMenu, linkVisitedColourMenu, customColourOneMenu, customColourTwoMenu, customColourThreeMenu, customColourFourMenu, customColourFiveMenu, customColourSixMenu, customTextColourOneMenu, customTextColourTwoMenu, customTextColourThreeMenu, customTextColourFourMenu, customTextColourFiveMenu, customTextColourSixMenu, menuTextColourMenu, statusTextColourMenu, ribbonTabTextColourMenu;
        #endregion

        #region Properties

        #region Picture Box
        /// <summary>
        /// Gets or sets the base colour preview.
        /// </summary>
        /// <value>
        /// The base colour preview.
        /// </value>
        public PictureBox BaseColourPreview { get => baseColourPreview; set => baseColourPreview = value; }

        /// <summary>
        /// Gets or sets the dark colour preview.
        /// </summary>
        /// <value>
        /// The dark colour preview.
        /// </value>
        public PictureBox DarkColourPreview { get => darkColourPreview; set => darkColourPreview = value; }

        /// <summary>
        /// Gets or sets the middle colour preview.
        /// </summary>
        /// <value>
        /// The middle colour preview.
        /// </value>
        public PictureBox MiddleColourPreview { get => middleColourPreview; set => middleColourPreview = value; }

        /// <summary>
        /// Gets or sets the light colour preview.
        /// </summary>
        /// <value>
        /// The light colour preview.
        /// </value>
        public PictureBox LightColourPreview { get => lightColourPreview; set => lightColourPreview = value; }

        /// <summary>
        /// Gets or sets the lightest colour preview.
        /// </summary>
        /// <value>
        /// The lightest colour preview.
        /// </value>
        public PictureBox LightestColourPreview { get => lightestColourPreview; set => lightestColourPreview = value; }

        /// <summary>
        /// Gets or sets the border colour preview.
        /// </summary>
        /// <value>
        /// The border colour preview.
        /// </value>
        public PictureBox BorderColourPreview { get => borderColourPreview; set => borderColourPreview = value; }

        /// <summary>
        /// Gets or sets the alternative normal text colour preview.
        /// </summary>
        /// <value>
        /// The alternative normal text colour preview.
        /// </value>
        public PictureBox AlternativeNormalTextColourPreview { get => alternativeNormalTextColourPreview; set => alternativeNormalTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the normal text colour preview.
        /// </summary>
        /// <value>
        /// The normal text colour preview.
        /// </value>
        public PictureBox NormalTextColourPreview { get => normalTextColourPreview; set => normalTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the disabled text colour preview.
        /// </summary>
        /// <value>
        /// The disabled text colour preview.
        /// </value>
        public PictureBox DisabledTextColourPreview { get => disabledTextColourPreview; set => disabledTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the focused text colour preview.
        /// </summary>
        /// <value>
        /// The focused text colour preview.
        /// </value>
        public PictureBox FocusedTextColourPreview { get => focusedTextColourPreview; set => focusedTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the pressed text colour preview.
        /// </summary>
        /// <value>
        /// The pressed text colour preview.
        /// </value>
        public PictureBox PressedTextColourPreview { get => pressedTextColourPreview; set => pressedTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the disabled control colour preview.
        /// </summary>
        /// <value>
        /// The disabled colour control preview.
        /// </value>
        public PictureBox DisabledControlColourPreview { get => disabledControlColourPreview; set => disabledControlColourPreview = value; }

        /// <summary>
        /// Gets or sets the link normal colour preview.
        /// </summary>
        /// <value>
        /// The link normal colour preview.
        /// </value>
        public PictureBox LinkNormalColourPreview { get => linkNormalColourPreview; set => linkNormalColourPreview = value; }

        /// <summary>
        /// Gets or sets the link focused colour preview.
        /// </summary>
        /// <value>
        /// The link focused colour preview.
        /// </value>
        public PictureBox LinkFocusedColourPreview { get => linkFocusedColourPreview; set => linkFocusedColourPreview = value; }

        /// <summary>
        /// Gets or sets the link hover colour preview.
        /// </summary>
        /// <value>
        /// The link hover colour preview.
        /// </value>
        public PictureBox LinkHoverColourPreview { get => linkHoverColourPreview; set => linkHoverColourPreview = value; }

        /// <summary>
        /// Gets or sets the link visited colour preview.
        /// </summary>
        /// <value>
        /// The link visited colour preview.
        /// </value>
        public PictureBox LinkVisitedColourPreview { get => linkVisitedColourPreview; set => linkVisitedColourPreview = value; }

        /// <summary>
        /// Gets or sets the custom colour one preview.
        /// </summary>
        /// <value>
        /// The custom colour one preview.
        /// </value>
        public PictureBox CustomColourOnePreview { get => customColourOnePreview; set => customColourOnePreview = value; }

        /// <summary>
        /// Gets or sets the custom colour two preview.
        /// </summary>
        /// <value>
        /// The custom colour two preview.
        /// </value>
        public PictureBox CustomColourTwoPreview { get => customColourTwoPreview; set => customColourTwoPreview = value; }

        /// <summary>
        /// Gets or sets the custom colour three preview.
        /// </summary>
        /// <value>
        /// The custom colour three preview.
        /// </value>
        public PictureBox CustomColourThreePreview { get => customColourThreePreview; set => customColourThreePreview = value; }

        /// <summary>
        /// Gets or sets the custom colour four preview.
        /// </summary>
        /// <value>
        /// The custom colour four preview.
        /// </value>
        public PictureBox CustomColourFourPreview { get => customColourFourPreview; set => customColourFourPreview = value; }

        /// <summary>
        /// Gets or sets the custom colour five preview.
        /// </summary>
        /// <value>
        /// The custom colour five preview.
        /// </value>
        public PictureBox CustomColourFivePreview { get => customColourFivePreview; set => customColourFivePreview = value; }

        /// <summary>
        /// Gets or sets the custom colour six preview.
        /// </summary>
        /// <value>
        /// The custom colour six preview.
        /// </value>
        public PictureBox CustomColourSixPreview { get => customColourSixPreview; set => customColourSixPreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour one preview.
        /// </summary>
        /// <value>
        /// The custom text colour one preview.
        /// </value>
        public PictureBox CustomTextColourOnePreview { get => customTextColourOnePreview; set => customTextColourOnePreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour two preview.
        /// </summary>
        /// <value>
        /// The custom text colour two preview.
        /// </value>
        public PictureBox CustomTextColourTwoPreview { get => customTextColourTwoPreview; set => customTextColourTwoPreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour three preview.
        /// </summary>
        /// <value>
        /// The custom text colour three preview.
        /// </value>
        public PictureBox CustomTextColourThreePreview { get => customTextColourThreePreview; set => customTextColourThreePreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour four preview.
        /// </summary>
        /// <value>
        /// The custom text colour four preview.
        /// </value>
        public PictureBox CustomTextColourFourPreview { get => customTextColourFourPreview; set => customTextColourFourPreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour five preview.
        /// </summary>
        /// <value>
        /// The custom text colour five preview.
        /// </value>
        public PictureBox CustomTextColourFivePreview { get => customTextColourFivePreview; set => customTextColourFivePreview = value; }

        /// <summary>
        /// Gets or sets the custom text colour six preview.
        /// </summary>
        /// <value>
        /// The custom text colour six preview.
        /// </value>
        public PictureBox CustomTextColourSixPreview { get => customTextColourSixPreview; set => customTextColourSixPreview = value; }

        /// <summary>
        /// Gets or sets the menu text colour preview.
        /// </summary>
        /// <value>
        /// The menu text colour preview.
        /// </value>
        public PictureBox MenuTextColourPreview { get => menuTextColourPreview; set => menuTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the status text colour preview.
        /// </summary>
        /// <value>
        /// The status text colour preview.
        /// </value>
        public PictureBox StatusTextColourPreview { get => statusTextColourPreview; set => statusTextColourPreview = value; }

        /// <summary>
        /// Gets or sets the ribbon tab text colour.
        /// </summary>
        /// <value>
        /// The ribbon tab text colour.
        /// </value>
        public PictureBox RibbonTabTextColourPreview { get => ribbonTabTextColourPreview; set => ribbonTabTextColourPreview = value; }
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
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardPictureBoxControl"/> class.
        /// </summary>
        public StandardPictureBoxControl()
        {
            InitializeComponent();

            #region Picture Boxes
            SetBaseColourPreview(pbxBaseColourPreview);

            SetDarkColourPreview(pbxDarkColourPreview);

            SetMiddleColourPreview(pbxMediumColourPreview);

            SetLightColourPreview(pbxLightColourPreview);

            SetLightestColourPreview(pbxLightestColourPreview);

            SetBorderColourPreview(pbxBorderColourPreview);

            SetAlternativeNormalTextColourPreview(pbxAlternativeNormalTextColourPreview);

            SetNormalColourPreview(pbxNormalTextColourPreview);

            SetDisabledTextColourPreview(pbxDisabledTextColourPreview);

            SetFocusedTextColourPreview(pbxFocusedTextColourPreview);

            SetPressedTextColourPreview(pbxPressedTextColourPreview);

            SetDisabledControlColourPreview(pbxDisabledControlColourPreview);

            SetLinkNormalColourPreview(pbxLinkNormalColourPreview);

            SetLinkFocusedColourPreview(pbxLinkFocusedColourPreview);

            SetLinkHoverColourPreview(pbxLinkHoverColourPreview);

            SetLinkVisitedColourPreview(pbxLinkVisitedColourPreview);

            SetCustomColourOneColourPreview(pbxCustomColourOnePreview);

            SetCustomColourTwoColourPreview(pbxCustomColourTwoPreview);

            SetCustomColourThreeColourPreview(pbxCustomColourThreePreview);

            SetCustomColourFourColourPreview(pbxCustomColourFourPreview);

            SetCustomColourFiveColourPreview(pbxCustomColourFivePreview);

            SetCustomColourSixColourPreview(pbxCustomColourSixPreview);

            SetCustomTextColourOneColourPreview(pbxCustomTextColourOnePreview);

            SetCustomTextColourTwoColourPreview(pbxCustomTextColourTwoPreview);

            SetCustomTextColourThreeColourPreview(pbxCustomTextColourThreePreview);

            SetCustomTextColourFourColourPreview(pbxCustomTextColourFourPreview);

            SetCustomTextColourFiveColourPreview(pbxCustomTextColourFivePreview);

            SetCustomTextColourSixColourPreview(pbxCustomTextColourSixPreview);

            SetMenuTextColourPreview(pbxMenuTextColourPreview);

            SetStatusTextColourPreview(pbxStatusTextColourPreview);

            SetRibbonTabTextColourPreview(pbxRibbonTabTextColourPreview);
            #endregion

            #region Context Menu Strips
            SetBaseColourMenu(ctxBaseColour);

            SetDarkColourMenu(ctxDarkColour);

            SetMiddleColourMenu(ctxMediumColour);

            SetLightColourMenu(ctxLightColour);

            SetLightestColourMenu(ctxLightestColour);

            SetBorderColourMenu(ctxBorderColour);

            SetAlternativeNormalTextColourMenu(ctxAlternativeNormalTextColour);

            SetNormalColourMenu(ctxNormalTextColour);

            SetDisabledTextColourMenu(ctxDisabedTextColour);

            SetFocusedTextColourMenu(ctxFocusedTextColour);

            SetPressedTextColourMenu(ctxPressedTextColour);

            SetDisabledControlColourMenu(ctxDisabledControlColour);

            SetLinkNormalColourMenu(ctxLinkNormalTextColour);

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

            AssignContextMenuToControl(GetNormalColourPreview(), GetNormalColourMenu());

            AssignContextMenuToControl(GetDisabledTextColourPreview(), GetDisabledTextColourMenu());

            AssignContextMenuToControl(GetFocusedTextColourPreview(), GetFocusedTextColourMenu());

            AssignContextMenuToControl(GetPressedTextColourPreview(), GetPressedTextColourMenu());

            AssignContextMenuToControl(GetDisabledControlColourPreview(), GetDisabledControlColourMenu());

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
        }
        #endregion

        #region Setters and Getters

        #region Picture Box
        /// <summary>
        /// Sets the value of BaseColourPreview to value.
        /// </summary>
        /// <param name="value">The value of BaseColourPreview.</param>
        public void SetBaseColourPreview(PictureBox value)
        {
            BaseColourPreview = value;
        }

        /// <summary>
        /// Returns the value of BaseColourPreview.
        /// </summary>
        /// <returns>The value of BaseColourPreview.</returns>
        public PictureBox GetBaseColourPreview()
        {
            return BaseColourPreview;
        }

        /// <summary>
        /// Sets the value of DarkColourPreview to value.
        /// </summary>
        /// <param name="value">The value of DarkColourPreview.</param>
        public void SetDarkColourPreview(PictureBox value)
        {
            DarkColourPreview = value;
        }

        /// <summary>
        /// Returns the value of DarkColourPreview.
        /// </summary>
        /// <returns>The value of DarkColourPreview.</returns>
        public PictureBox GetDarkColourPreview()
        {
            return DarkColourPreview;
        }

        /// <summary>
        /// Sets the value of MiddleColourPreview to value.
        /// </summary>
        /// <param name="value">The value of MiddleColourPreview.</param>
        public void SetMiddleColourPreview(PictureBox value)
        {
            MiddleColourPreview = value;
        }

        /// <summary>
        /// Returns the value of MiddleColourPreview.
        /// </summary>
        /// <returns>The value of MiddleColourPreview.</returns>
        public PictureBox GetMiddleColourPreview()
        {
            return MiddleColourPreview;
        }

        /// <summary>
        /// Sets the value of LightColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LightColourPreview.</param>
        public void SetLightColourPreview(PictureBox value)
        {
            LightColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LightColourPreview.
        /// </summary>
        /// <returns>The value of LightColourPreview.</returns>
        public PictureBox GetLightColourPreview()
        {
            return LightColourPreview;
        }

        /// <summary>
        /// Sets the value of LightestColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LightestColourPreview.</param>
        public void SetLightestColourPreview(PictureBox value)
        {
            LightestColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LightestColourPreview.
        /// </summary>
        /// <returns>The value of LightestColourPreview.</returns>
        public PictureBox GetLightestColourPreview()
        {
            return LightestColourPreview;
        }

        /// <summary>
        /// Sets the value of BorderColourPreview to value.
        /// </summary>
        /// <param name="value">The value of BorderColourPreview.</param>
        public void SetBorderColourPreview(PictureBox value)
        {
            BorderColourPreview = value;
        }

        /// <summary>
        /// Returns the value of BorderColourPreview.
        /// </summary>
        /// <returns>The value of BorderColourPreview.</returns>
        public PictureBox GetBorderColourPreview()
        {
            return BorderColourPreview;
        }

        /// <summary>
        /// Sets the value of AlternativeNormalTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of AlternativeNormalTextColourPreview.</param>
        public void SetAlternativeNormalTextColourPreview(PictureBox value)
        {
            AlternativeNormalTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of AlternativeNormalTextColourPreview.
        /// </summary>
        /// <returns>The value of AlternativeNormalTextColourPreview.</returns>
        public PictureBox GetAlternativeNormalTextColourPreview()
        {
            return AlternativeNormalTextColourPreview;
        }

        /// <summary>
        /// Sets the value of NormalColourPreview to value.
        /// </summary>
        /// <param name="value">The value of NormalColourPreview.</param>
        public void SetNormalColourPreview(PictureBox value)
        {
            NormalTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of NormalColourPreview.
        /// </summary>
        /// <returns>The value of NormalColourPreview.</returns>
        public PictureBox GetNormalColourPreview()
        {
            return NormalTextColourPreview;
        }

        /// <summary>
        /// Sets the value of DisabledTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of DisabledTextColourPreview.</param>
        public void SetDisabledTextColourPreview(PictureBox value)
        {
            DisabledTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of DisabledTextColourPreview.
        /// </summary>
        /// <returns>The value of DisabledTextColourPreview.</returns>
        public PictureBox GetDisabledTextColourPreview()
        {
            return DisabledTextColourPreview;
        }

        /// <summary>
        /// Sets the value of FocusedTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of FocusedTextColourPreview.</param>
        public void SetFocusedTextColourPreview(PictureBox value)
        {
            FocusedTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of FocusedTextColourPreview.
        /// </summary>
        /// <returns>The value of FocusedTextColourPreview.</returns>
        public PictureBox GetFocusedTextColourPreview()
        {
            return FocusedTextColourPreview;
        }

        /// <summary>
        /// Sets the value of PressedTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of PressedTextColourPreview.</param>
        public void SetPressedTextColourPreview(PictureBox value)
        {
            PressedTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of PressedTextColourPreview.
        /// </summary>
        /// <returns>The value of PressedTextColourPreview.</returns>
        public PictureBox GetPressedTextColourPreview()
        {
            return PressedTextColourPreview;
        }

        /// <summary>
        /// Sets the value of DisabledControlColourPreview to value.
        /// </summary>
        /// <param name="value">The value of DisabledControlColourPreview.</param>
        public void SetDisabledControlColourPreview(PictureBox value)
        {
            DisabledControlColourPreview = value;
        }

        /// <summary>
        /// Returns the value of DisabledControlColourPreview.
        /// </summary>
        /// <returns>The value of DisabledControlColourPreview.</returns>
        public PictureBox GetDisabledControlColourPreview()
        {
            return DisabledControlColourPreview;
        }

        /// <summary>
        /// Sets the value of LinkNormalColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LinkNormalColourPreview.</param>
        public void SetLinkNormalColourPreview(PictureBox value)
        {
            LinkNormalColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LinkNormalColourPreview.
        /// </summary>
        /// <returns>The value of LinkNormalColourPreview.</returns>
        public PictureBox GetLinkNormalColourPreview()
        {
            return LinkNormalColourPreview;
        }

        /// <summary>
        /// Sets the value of LinkFocusedColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LinkFocusedColourPreview.</param>
        public void SetLinkFocusedColourPreview(PictureBox value)
        {
            LinkFocusedColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LinkFocusedColourPreview.
        /// </summary>
        /// <returns>The value of LinkFocusedColourPreview.</returns>
        public PictureBox GetLinkFocusedColourPreview()
        {
            return LinkFocusedColourPreview;
        }

        /// <summary>
        /// Sets the value of LinkHoverColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LinkHoverColourPreview.</param>
        public void SetLinkHoverColourPreview(PictureBox value)
        {
            LinkHoverColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LinkHoverColourPreview.
        /// </summary>
        /// <returns>The value of LinkHoverColourPreview.</returns>
        public PictureBox GetLinkHoverColourPreview()
        {
            return LinkHoverColourPreview;
        }

        /// <summary>
        /// Sets the value of LinkVisitedColourPreview to value.
        /// </summary>
        /// <param name="value">The value of LinkVisitedColourPreview.</param>
        public void SetLinkVisitedColourPreview(PictureBox value)
        {
            LinkVisitedColourPreview = value;
        }

        /// <summary>
        /// Returns the value of LinkVisitedColourPreview.
        /// </summary>
        /// <returns>The value of LinkVisitedColourPreview.</returns>
        public PictureBox GetLinkVisitedColourPreview()
        {
            return LinkVisitedColourPreview;
        }

        /// <summary>
        /// Sets the value of CustomColourOneColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourOneColourPreview.</param>
        public void SetCustomColourOneColourPreview(PictureBox value)
        {
            CustomColourOnePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourOneColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourOneColourPreview.</returns>
        public PictureBox GetCustomColourOneColourPreview()
        {
            return CustomColourOnePreview;
        }

        /// <summary>
        /// Sets the value of CustomColourTwoColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourTwoColourPreview.</param>
        public void SetCustomColourTwoColourPreview(PictureBox value)
        {
            CustomColourTwoPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourTwoColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourTwoColourPreview.</returns>
        public PictureBox GetCustomColourTwoColourPreview()
        {
            return CustomColourTwoPreview;
        }

        /// <summary>
        /// Sets the value of CustomColourThreeColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourThreeColourPreview.</param>
        public void SetCustomColourThreeColourPreview(PictureBox value)
        {
            CustomColourThreePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourThreeColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourThreeColourPreview.</returns>
        public PictureBox GetCustomColourThreeColourPreview()
        {
            return CustomColourThreePreview;
        }

        /// <summary>
        /// Sets the value of CustomColourFourColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourFourColourPreview.</param>
        public void SetCustomColourFourColourPreview(PictureBox value)
        {
            CustomColourFourPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourFourColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourFourColourPreview.</returns>
        public PictureBox GetCustomColourFourColourPreview()
        {
            return CustomColourFourPreview;
        }

        /// <summary>
        /// Sets the value of CustomColourFiveColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourFiveColourPreview.</param>
        public void SetCustomColourFiveColourPreview(PictureBox value)
        {
            CustomColourFivePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourFiveColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourFiveColourPreview.</returns>
        public PictureBox GetCustomColourFiveColourPreview()
        {
            return CustomColourFivePreview;
        }

        /// <summary>
        /// Sets the value of CustomColourSixColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomColourSixColourPreview.</param>
        public void SetCustomColourSixColourPreview(PictureBox value)
        {
            CustomColourSixPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomColourSixColourPreview.
        /// </summary>
        /// <returns>The value of CustomColourSixColourPreview.</returns>
        public PictureBox GetCustomColourSixColourPreview()
        {
            return CustomColourSixPreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourOneColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourOneColourPreview.</param>
        public void SetCustomTextColourOneColourPreview(PictureBox value)
        {
            CustomTextColourOnePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourOneColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourOneColourPreview.</returns>
        public PictureBox GetCustomTextColourOneColourPreview()
        {
            return CustomTextColourOnePreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourTwoColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourTwoColourPreview.</param>
        public void SetCustomTextColourTwoColourPreview(PictureBox value)
        {
            CustomTextColourTwoPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourTwoColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourTwoColourPreview.</returns>
        public PictureBox GetCustomTextColourTwoColourPreview()
        {
            return CustomTextColourTwoPreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourThreeColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourThreeColourPreview.</param>
        public void SetCustomTextColourThreeColourPreview(PictureBox value)
        {
            CustomTextColourThreePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourThreeColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourThreeColourPreview.</returns>
        public PictureBox GetCustomTextColourThreeColourPreview()
        {
            return CustomTextColourThreePreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFourColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourFourColourPreview.</param>
        public void SetCustomTextColourFourColourPreview(PictureBox value)
        {
            CustomTextColourFourPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourFourColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourFourColourPreview.</returns>
        public PictureBox GetCustomTextColourFourColourPreview()
        {
            return CustomTextColourFourPreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFiveColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourFiveColourPreview.</param>
        public void SetCustomTextColourFiveColourPreview(PictureBox value)
        {
            CustomTextColourFivePreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourFiveColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourFiveColourPreview.</returns>
        public PictureBox GetCustomTextColourFiveColourPreview()
        {
            return CustomTextColourFivePreview;
        }

        /// <summary>
        /// Sets the value of CustomTextColourSixColourPreview to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourSixColourPreview.</param>
        public void SetCustomTextColourSixColourPreview(PictureBox value)
        {
            CustomTextColourSixPreview = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourSixColourPreview.
        /// </summary>
        /// <returns>The value of CustomTextColourSixColourPreview.</returns>
        public PictureBox GetCustomTextColourSixColourPreview()
        {
            return CustomTextColourSixPreview;
        }

        /// <summary>
        /// Sets the value of MenuTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of MenuTextColourPreview.</param>
        public void SetMenuTextColourPreview(PictureBox value)
        {
            MenuTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of MenuTextColourPreview.
        /// </summary>
        /// <returns>The value of MenuTextColourPreview.</returns>
        public PictureBox GetMenuTextColourPreview()
        {
            return MenuTextColourPreview;
        }

        /// <summary>
        /// Sets the value of StatusTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of StatusTextColourPreview.</param>
        public void SetStatusTextColourPreview(PictureBox value)
        {
            StatusTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of StatusTextColourPreview.
        /// </summary>
        /// <returns>The value of StatusTextColourPreview.</returns>
        public PictureBox GetStatusTextColourPreview()
        {
            return StatusTextColourPreview;
        }

        /// <summary>
        /// Sets the value of RibbonTabTextColourPreview to value.
        /// </summary>
        /// <param name="value">The value of RibbonTabTextColourPreview.</param>
        public void SetRibbonTabTextColourPreview(PictureBox value)
        {
            RibbonTabTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of RibbonTabTextColourPreview.
        /// </summary>
        /// <returns>The value of RibbonTabTextColourPreview.</returns>
        public PictureBox GetRibbonTabTextColourPreview()
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
        /// Sets the value of NormalColourMenu to value.
        /// </summary>
        /// <param name="value">The value of NormalColourMenu.</param>
        public void SetNormalColourMenu(ContextMenuStrip value)
        {
            NormalTextColourMenu = value;
        }

        /// <summary>
        /// Returns the value of NormalColourMenu.
        /// </summary>
        /// <returns>The value of NormalColourMenu.</returns>
        public ContextMenuStrip GetNormalColourMenu()
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
        #endregion
    }
}