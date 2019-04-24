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
        private PictureBox pbxMiddleColour;

        private void InitializeComponent()
        {
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
            this.ResumeLayout(false);

        }
    }
}