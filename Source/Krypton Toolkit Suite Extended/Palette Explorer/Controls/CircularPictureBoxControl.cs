﻿using ExtendedControls.ExtendedToolkit.Controls;
using System.Windows.Forms;

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
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxMiddleColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxDarkColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxBaseColourPreview;

        private void InitializeComponent()
        {
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            this.kgbCircularColourPreviewPane = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
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
            this.cbxMiddleColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxDarkColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxBaseColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbCircularColourPreviewPane.Panel)).BeginInit();
            this.kgbCircularColourPreviewPane.Panel.SuspendLayout();
            this.kgbCircularColourPreviewPane.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbxMiddleColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBaseColourPreview)).BeginInit();
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
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxMiddleColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxDarkColourPreview);
            this.kgbCircularColourPreviewPane.Panel.Controls.Add(this.cbxBaseColourPreview);
            this.kgbCircularColourPreviewPane.Size = new System.Drawing.Size(1625, 660);
            this.kgbCircularColourPreviewPane.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbCircularColourPreviewPane.TabIndex = 39;
            popupPositionValues1.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kgbCircularColourPreviewPane.ToolTipValues.ToolTipPosition = popupPositionValues1;
            this.kgbCircularColourPreviewPane.Values.Heading = "Colour Preview";
            // 
            // cbxCustomTextColourSixPreview
            // 
            this.cbxCustomTextColourSixPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourSixPreview.Location = new System.Drawing.Point(1537, 413);
            this.cbxCustomTextColourSixPreview.Name = "cbxCustomTextColourSixPreview";
            this.cbxCustomTextColourSixPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourSixPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourSixPreview.TabIndex = 56;
            this.cbxCustomTextColourSixPreview.TabStop = false;
            // 
            // cbxCustomColourSixPreview
            // 
            this.cbxCustomColourSixPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomColourSixPreview.Location = new System.Drawing.Point(19, 413);
            this.cbxCustomColourSixPreview.Name = "cbxCustomColourSixPreview";
            this.cbxCustomColourSixPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomColourSixPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomColourSixPreview.TabIndex = 55;
            this.cbxCustomColourSixPreview.TabStop = false;
            // 
            // cbxRibbonTabTextColourPreview
            // 
            this.cbxRibbonTabTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxRibbonTabTextColourPreview.Location = new System.Drawing.Point(525, 549);
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
            this.cbxStatusTextColourPreview.Location = new System.Drawing.Point(272, 549);
            this.cbxStatusTextColourPreview.Name = "cbxStatusTextColourPreview";
            this.cbxStatusTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxStatusTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxStatusTextColourPreview.TabIndex = 52;
            this.cbxStatusTextColourPreview.TabStop = false;
            // 
            // cbxCustomTextColourThreePreview
            // 
            this.cbxCustomTextColourThreePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourThreePreview.Location = new System.Drawing.Point(778, 413);
            this.cbxCustomTextColourThreePreview.Name = "cbxCustomTextColourThreePreview";
            this.cbxCustomTextColourThreePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourThreePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourThreePreview.TabIndex = 51;
            this.cbxCustomTextColourThreePreview.TabStop = false;
            // 
            // cbxCustomTextColourTwoPreview
            // 
            this.cbxCustomTextColourTwoPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourTwoPreview.Location = new System.Drawing.Point(525, 413);
            this.cbxCustomTextColourTwoPreview.Name = "cbxCustomTextColourTwoPreview";
            this.cbxCustomTextColourTwoPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourTwoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourTwoPreview.TabIndex = 50;
            this.cbxCustomTextColourTwoPreview.TabStop = false;
            // 
            // cbxMenuTextColourPreview
            // 
            this.cbxMenuTextColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxMenuTextColourPreview.Location = new System.Drawing.Point(19, 549);
            this.cbxMenuTextColourPreview.Name = "cbxMenuTextColourPreview";
            this.cbxMenuTextColourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxMenuTextColourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxMenuTextColourPreview.TabIndex = 49;
            this.cbxMenuTextColourPreview.TabStop = false;
            // 
            // cbxCustomTextColourFourPreview
            // 
            this.cbxCustomTextColourFourPreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourFourPreview.Location = new System.Drawing.Point(1031, 413);
            this.cbxCustomTextColourFourPreview.Name = "cbxCustomTextColourFourPreview";
            this.cbxCustomTextColourFourPreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourFourPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourFourPreview.TabIndex = 48;
            this.cbxCustomTextColourFourPreview.TabStop = false;
            // 
            // cbxCustomTextColourFivePreview
            // 
            this.cbxCustomTextColourFivePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourFivePreview.Location = new System.Drawing.Point(1284, 413);
            this.cbxCustomTextColourFivePreview.Name = "cbxCustomTextColourFivePreview";
            this.cbxCustomTextColourFivePreview.Size = new System.Drawing.Size(64, 64);
            this.cbxCustomTextColourFivePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cbxCustomTextColourFivePreview.TabIndex = 47;
            this.cbxCustomTextColourFivePreview.TabStop = false;
            // 
            // cbxCustomTextColourOnePreview
            // 
            this.cbxCustomTextColourOnePreview.BackColor = System.Drawing.Color.White;
            this.cbxCustomTextColourOnePreview.Location = new System.Drawing.Point(272, 413);
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
            ((System.ComponentModel.ISupportInitialize)(this.cbxMiddleColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBaseColourPreview)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private CircularPictureBox baseColourPreview, darkColourPreview, middleColourPreview, lightColourPreview, lightestColourPreview, borderColourPreview, alternativeNormalTextColourPreview, normalTextColourPreview, disabledTextColourPreview, focusedTextColourPreview, pressedTextColourPreview, disabledColourPreview, linkNormalColourPreview, linkFocusedColourPreview, linkHoverColourPreview, linkVisitedColourPreview, customColourOnePreview, customColourTwoPreview, customColourThreePreview, customColourFourPreview, customColourFivePreview, customColourSixPreview, customTextColourOnePreview, customTextColourTwoPreview, customTextColourThreePreview, customTextColourFourPreview, customTextColourFivePreview, customTextColourSixPreview, menuTextColourPreview, statusTextColourPreview, ribbonTabTextColourPreview;

        private ContextMenuStrip baseColourMenu, darkColourMenu, middleColourMenu, lightColourMenu, lightestColourMenu, borderColourMenu, alternativeNormalTextColourMenu, normalTextColourMenu, disabledTextColourMenu, focusedTextColourMenu, pressedTextColourMenu, disabledColourMenu, linkNormalColourMenu, linkFocusedColourMenu, linkHoverColourMenu, linkVisitedColourMenu, customColourOneMenu, customColourTwoMenu, customColourThreeMenu, customColourFourMenu, customColourFiveMenu, customColourSixMenu, customTextColourOneMenu, customTextColourTwoMenu, customTextColourThreeMenu, customTextColourFourMenu, customTextColourFiveMenu, customTextColourSixMenu, menuTextColourMenu, statusTextColourMenu, ribbonTabTextColourMenu;
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
        /// Gets or sets the disabled colour preview.
        /// </summary>
        /// <value>
        /// The disabled colour preview.
        /// </value>
        public CircularPictureBox DisabledColourPreview { get => disabledColourPreview; set => disabledColourPreview = value; }

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

        public ContextMenuStrip BaseColourMenu { get; set; }
        public ContextMenuStrip DarkColourMenu { get; set; }
        public ContextMenuStrip MiddleColourMenu { get; set; }
        public ContextMenuStrip LightColourMenu { get; set; }
        public ContextMenuStrip LightestColourMenu { get; set; }
        public ContextMenuStrip BorderColourMenu { get; set; }
        public ContextMenuStrip AlternativeNormalTextColourMenu { get; set; }
        public ContextMenuStrip NormalTextColourMenu { get; set; }
        public ContextMenuStrip DisabledTextColourMenu { get; set; }
        public ContextMenuStrip FocusedTextColourMenu { get; set; }
        public ContextMenuStrip PressedTextColourMenu { get; set; }
        public ContextMenuStrip DisabledColourMenu { get; set; }
        public ContextMenuStrip LinkNormalColourMenu { get; set; }
        public ContextMenuStrip LinkFocusedColourMenu { get; set; }
        public ContextMenuStrip LinkHoverColourMenu { get; set; }
        public ContextMenuStrip LinkVisitedColourMenu { get; set; }
        public ContextMenuStrip CustomColourOneMenu { get; set; }
        public ContextMenuStrip CustomColourTwoMenu { get; set; }
        public ContextMenuStrip CustomColourThreeMenu { get; set; }
        public ContextMenuStrip CustomColourFourMenu { get; set; }
        public ContextMenuStrip CustomColourFiveMenu { get; set; }
        public ContextMenuStrip CustomColourSixMenu { get; set; }
        public ContextMenuStrip CustomTextColourOneMenu { get; set; }
        public ContextMenuStrip CustomTextColourTwoMenu { get; set; }
        public ContextMenuStrip CustomTextColourThreeMenu { get; set; }
        public ContextMenuStrip CustomTextColourFourMenu { get; set; }
        public ContextMenuStrip CustomTextColourFiveMenu { get; set; }
        public ContextMenuStrip CustomTextColourSixMenu { get; set; }
        public ContextMenuStrip MenuTextColourMenu { get; set; }
        public ContextMenuStrip StatusTextColourMenu { get; set; }
        public ContextMenuStrip RibbonTabTextColourMenu { get; set; }
        #endregion

        #region Constructor
        public CircularPictureBoxControl()
        {
            InitializeComponent();
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
        /// Sets the value of NormalColourPreview to value.
        /// </summary>
        /// <param name="value">The value of NormalColourPreview.</param>
        public void SetNormalColourPreview(CircularPictureBox value)
        {
            NormalTextColourPreview = value;
        }

        /// <summary>
        /// Returns the value of NormalColourPreview.
        /// </summary>
        /// <returns>The value of NormalColourPreview.</returns>
        public CircularPictureBox GetNormalColourPreview()
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
        /// Sets the value of DisabledColourPreview to value.
        /// </summary>
        /// <param name="value">The value of DisabledColourPreview.</param>
        public void SetDisabledColourPreview(CircularPictureBox value)
        {
            DisabledColourPreview = value;
        }

        /// <summary>
        /// Returns the value of DisabledColourPreview.
        /// </summary>
        /// <returns>The value of DisabledColourPreview.</returns>
        public CircularPictureBox GetDisabledColourPreview()
        {
            return DisabledColourPreview;
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
        /// Sets the value of DisabledColourMenu to value.
        /// </summary>
        /// <param name="value">The value of DisabledColourMenu.</param>
        public void SetDisabledColourMenu(ContextMenuStrip value)
        {
            DisabledColourMenu = value;
        }

        /// <summary>
        /// Returns the value of DisabledColourMenu.
        /// </summary>
        /// <returns>The value of DisabledColourMenu.</returns>
        public ContextMenuStrip GetDisabledColourMenu()
        {
            return DisabledColourMenu;
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
    }
}