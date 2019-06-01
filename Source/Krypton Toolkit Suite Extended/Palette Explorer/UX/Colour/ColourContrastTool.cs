using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PaletteExplorer.UX.Colour
{
    #region Enums
    public enum ContrastType
    {
        CUSTOMCOLOURS = 1,
        CUSTOMTEXTCOLOURS = 2
    }
    #endregion

    public class ColourContrastTool : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel2;
        private ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheelExtended cwChosenColour;
        private System.Windows.Forms.Panel panel1;
        private KryptonNumericUpDown knudBlueChannelValue;
        private KryptonNumericUpDown knudGreenChannelValue;
        private KryptonLabel kryptonLabel1;
        private KryptonNumericUpDown knudRedChannelValue;
        private KryptonNumericUpDown knumAlpaValue;
        private KryptonLabel kryptonLabel10;
        private KryptonLabel kryptonLabel8;
        private KryptonLabel kryptonLabel9;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxContrastColourTwoPreview;
        private KryptonLabel kryptonLabel3;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxContrastColourOnePreview;
        private KryptonLabel kryptonLabel2;
        private KryptonLabel kryptonLabel6;
        private KryptonTextBox ktxtHexValue;
        private KryptonLabel klblHexValue;
        private KryptonComboBox kcbCustomColourTwoSelector;
        private KryptonComboBox kcbCustomColourOneSelector;
        private KryptonCheckBox kchkUpdateValues;
        private KryptonButton kbtnOk;
        private KryptonButton kbtnExport;
        private KryptonButton kbtnImportValues;
        private KryptonButton kbtnSaveValues;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourContrastTool));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kchkUpdateValues = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kcbCustomColourTwoSelector = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kcbCustomColourOneSelector = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbxContrastColourTwoPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbxContrastColourOnePreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knudBlueChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.ktxtHexValue = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cwChosenColour = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheelExtended();
            this.klblHexValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knudGreenChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knudRedChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumAlpaValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSaveValues = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnImportValues = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbCustomColourTwoSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcbCustomColourOneSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxContrastColourTwoPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxContrastColourOnePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnExport);
            this.kryptonPanel1.Controls.Add(this.kbtnImportValues);
            this.kryptonPanel1.Controls.Add(this.kbtnSaveValues);
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.kchkUpdateValues);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 755);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(988, 55);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kchkUpdateValues
            // 
            this.kchkUpdateValues.Location = new System.Drawing.Point(12, 17);
            this.kchkUpdateValues.Name = "kchkUpdateValues";
            this.kchkUpdateValues.Size = new System.Drawing.Size(185, 26);
            this.kchkUpdateValues.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkUpdateValues.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkUpdateValues.TabIndex = 0;
            this.kchkUpdateValues.Values.Text = "Always &Update Values";
            this.kchkUpdateValues.CheckedChanged += new System.EventHandler(this.KchkUpdateValues_CheckedChanged);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kcbCustomColourTwoSelector);
            this.kryptonPanel2.Controls.Add(this.kcbCustomColourOneSelector);
            this.kryptonPanel2.Controls.Add(this.cbxContrastColourTwoPreview);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.cbxContrastColourOnePreview);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel2.Controls.Add(this.knudBlueChannelValue);
            this.kryptonPanel2.Controls.Add(this.ktxtHexValue);
            this.kryptonPanel2.Controls.Add(this.cwChosenColour);
            this.kryptonPanel2.Controls.Add(this.klblHexValue);
            this.kryptonPanel2.Controls.Add(this.knudGreenChannelValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.knudRedChannelValue);
            this.kryptonPanel2.Controls.Add(this.knumAlpaValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(988, 755);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kcbCustomColourTwoSelector
            // 
            this.kcbCustomColourTwoSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kcbCustomColourTwoSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbCustomColourTwoSelector.DropDownWidth = 435;
            this.kcbCustomColourTwoSelector.Location = new System.Drawing.Point(638, 711);
            this.kcbCustomColourTwoSelector.Name = "kcbCustomColourTwoSelector";
            this.kcbCustomColourTwoSelector.Size = new System.Drawing.Size(338, 27);
            this.kcbCustomColourTwoSelector.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbCustomColourTwoSelector.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcbCustomColourTwoSelector.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbCustomColourTwoSelector.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbCustomColourTwoSelector.TabIndex = 58;
            this.kcbCustomColourTwoSelector.SelectedIndexChanged += new System.EventHandler(this.KcbCustomColourTwoSelector_SelectedIndexChanged);
            // 
            // kcbCustomColourOneSelector
            // 
            this.kcbCustomColourOneSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kcbCustomColourOneSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbCustomColourOneSelector.DropDownWidth = 435;
            this.kcbCustomColourOneSelector.Location = new System.Drawing.Point(638, 333);
            this.kcbCustomColourOneSelector.Name = "kcbCustomColourOneSelector";
            this.kcbCustomColourOneSelector.Size = new System.Drawing.Size(338, 27);
            this.kcbCustomColourOneSelector.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbCustomColourOneSelector.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcbCustomColourOneSelector.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbCustomColourOneSelector.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbCustomColourOneSelector.TabIndex = 57;
            this.kcbCustomColourOneSelector.SelectedIndexChanged += new System.EventHandler(this.KcbCustomColourOneSelector_SelectedIndexChanged);
            // 
            // cbxContrastColourTwoPreview
            // 
            this.cbxContrastColourTwoPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxContrastColourTwoPreview.BackColor = System.Drawing.Color.Black;
            this.cbxContrastColourTwoPreview.Location = new System.Drawing.Point(673, 391);
            this.cbxContrastColourTwoPreview.Name = "cbxContrastColourTwoPreview";
            this.cbxContrastColourTwoPreview.Size = new System.Drawing.Size(303, 291);
            this.cbxContrastColourTwoPreview.TabIndex = 56;
            this.cbxContrastColourTwoPreview.TabStop = false;
            this.cbxContrastColourTwoPreview.MouseEnter += new System.EventHandler(this.CbxContrastColourTwoPreview_MouseEnter);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel3.Location = new System.Drawing.Point(424, 522);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(211, 33);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 55;
            this.kryptonLabel3.Values.Text = "Contrast Colour #2:";
            // 
            // cbxContrastColourOnePreview
            // 
            this.cbxContrastColourOnePreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxContrastColourOnePreview.BackColor = System.Drawing.Color.Black;
            this.cbxContrastColourOnePreview.Location = new System.Drawing.Point(673, 12);
            this.cbxContrastColourOnePreview.Name = "cbxContrastColourOnePreview";
            this.cbxContrastColourOnePreview.Size = new System.Drawing.Size(303, 291);
            this.cbxContrastColourOnePreview.TabIndex = 54;
            this.cbxContrastColourOnePreview.TabStop = false;
            this.cbxContrastColourOnePreview.MouseEnter += new System.EventHandler(this.CbxContrastColourOnePreview_MouseEnter);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel2.Location = new System.Drawing.Point(424, 143);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(211, 33);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 53;
            this.kryptonLabel2.Values.Text = "Contrast Colour #1:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel6.Location = new System.Drawing.Point(78, 713);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(26, 33);
            this.kryptonLabel6.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 52;
            this.kryptonLabel6.Values.Text = "#";
            // 
            // knudBlueChannelValue
            // 
            this.knudBlueChannelValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.knudBlueChannelValue.DecimalPlaces = 99;
            this.knudBlueChannelValue.Location = new System.Drawing.Point(98, 631);
            this.knudBlueChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knudBlueChannelValue.Name = "knudBlueChannelValue";
            this.knudBlueChannelValue.Size = new System.Drawing.Size(120, 32);
            this.knudBlueChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.knudBlueChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knudBlueChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knudBlueChannelValue.TabIndex = 34;
            this.knudBlueChannelValue.ValueChanged += new System.EventHandler(this.KnudBlueChannelValue_ValueChanged);
            // 
            // ktxtHexValue
            // 
            this.ktxtHexValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ktxtHexValue.Hint = "FFFFFF";
            this.ktxtHexValue.Location = new System.Drawing.Point(110, 717);
            this.ktxtHexValue.MaxLength = 6;
            this.ktxtHexValue.Name = "ktxtHexValue";
            this.ktxtHexValue.Size = new System.Drawing.Size(158, 29);
            this.ktxtHexValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtHexValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtHexValue.TabIndex = 51;
            this.ktxtHexValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktxtHexValue.TextChanged += new System.EventHandler(this.KtxtHexValue_TextChanged);
            // 
            // cwChosenColour
            // 
            this.cwChosenColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cwChosenColour.BackColor = System.Drawing.Color.Transparent;
            this.cwChosenColour.Location = new System.Drawing.Point(12, 12);
            this.cwChosenColour.Name = "cwChosenColour";
            this.cwChosenColour.Size = new System.Drawing.Size(368, 373);
            this.cwChosenColour.TabIndex = 3;
            this.cwChosenColour.ColourChanged += new System.EventHandler(this.CwChosenColour_ColourChanged);
            // 
            // klblHexValue
            // 
            this.klblHexValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.klblHexValue.Location = new System.Drawing.Point(12, 711);
            this.klblHexValue.Name = "klblHexValue";
            this.klblHexValue.Size = new System.Drawing.Size(60, 33);
            this.klblHexValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHexValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHexValue.TabIndex = 50;
            this.klblHexValue.Values.Text = "Hex:";
            // 
            // knudGreenChannelValue
            // 
            this.knudGreenChannelValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.knudGreenChannelValue.DecimalPlaces = 99;
            this.knudGreenChannelValue.Location = new System.Drawing.Point(98, 551);
            this.knudGreenChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knudGreenChannelValue.Name = "knudGreenChannelValue";
            this.knudGreenChannelValue.Size = new System.Drawing.Size(120, 32);
            this.knudGreenChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.knudGreenChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knudGreenChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knudGreenChannelValue.TabIndex = 33;
            this.knudGreenChannelValue.ValueChanged += new System.EventHandler(this.KnudGreenChannelValue_ValueChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 391);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(79, 33);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 27;
            this.kryptonLabel1.Values.Text = "Alpha:";
            // 
            // knudRedChannelValue
            // 
            this.knudRedChannelValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.knudRedChannelValue.DecimalPlaces = 99;
            this.knudRedChannelValue.Location = new System.Drawing.Point(98, 471);
            this.knudRedChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knudRedChannelValue.Name = "knudRedChannelValue";
            this.knudRedChannelValue.Size = new System.Drawing.Size(120, 32);
            this.knudRedChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.knudRedChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knudRedChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knudRedChannelValue.TabIndex = 32;
            this.knudRedChannelValue.ValueChanged += new System.EventHandler(this.KnudRedChannelValue_ValueChanged);
            // 
            // knumAlpaValue
            // 
            this.knumAlpaValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.knumAlpaValue.DecimalPlaces = 99;
            this.knumAlpaValue.Location = new System.Drawing.Point(97, 391);
            this.knumAlpaValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumAlpaValue.Name = "knumAlpaValue";
            this.knumAlpaValue.Size = new System.Drawing.Size(120, 32);
            this.knumAlpaValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumAlpaValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knumAlpaValue.TabIndex = 28;
            this.knumAlpaValue.ValueChanged += new System.EventHandler(this.KnumAlpaValue_ValueChanged);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel10.Location = new System.Drawing.Point(12, 471);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(59, 33);
            this.kryptonLabel10.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 31;
            this.kryptonLabel10.Values.Text = "Red:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel8.Location = new System.Drawing.Point(12, 631);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(64, 33);
            this.kryptonLabel8.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 29;
            this.kryptonLabel8.Values.Text = "Blue:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel9.Location = new System.Drawing.Point(12, 551);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(80, 33);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 30;
            this.kryptonLabel9.Values.Text = "Green:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 752);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 3);
            this.panel1.TabIndex = 2;
            // 
            // kbtnOk
            // 
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(944, 13);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 61;
            this.kbtnOk.Values.Text = "O&k";
            this.kbtnOk.Click += new System.EventHandler(this.KbtnOk_Click);
            // 
            // kbtnSaveValues
            // 
            this.kbtnSaveValues.AutoSize = true;
            this.kbtnSaveValues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnSaveValues.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnSaveValues.Location = new System.Drawing.Point(840, 13);
            this.kbtnSaveValues.Name = "kbtnSaveValues";
            this.kbtnSaveValues.Size = new System.Drawing.Size(98, 30);
            this.kbtnSaveValues.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSaveValues.TabIndex = 62;
            this.kbtnSaveValues.Values.Text = "&Save Values";
            // 
            // kbtnImportValues
            // 
            this.kbtnImportValues.AutoSize = true;
            this.kbtnImportValues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnImportValues.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnImportValues.Location = new System.Drawing.Point(721, 13);
            this.kbtnImportValues.Name = "kbtnImportValues";
            this.kbtnImportValues.Size = new System.Drawing.Size(113, 30);
            this.kbtnImportValues.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnImportValues.TabIndex = 63;
            this.kbtnImportValues.Values.Text = "&Import Values";
            // 
            // kbtnExport
            // 
            this.kbtnExport.AutoSize = true;
            this.kbtnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnExport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnExport.Enabled = false;
            this.kbtnExport.Location = new System.Drawing.Point(605, 13);
            this.kbtnExport.Name = "kbtnExport";
            this.kbtnExport.Size = new System.Drawing.Size(110, 30);
            this.kbtnExport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnExport.TabIndex = 64;
            this.kbtnExport.Values.Text = "E&xport Values";
            // 
            // ColourContrastTool
            // 
            this.ClientSize = new System.Drawing.Size(988, 810);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ColourContrastTool";
            this.Text = "Krypton Colour Contrast Tool";
            this.Load += new System.EventHandler(this.ColourContrastTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbCustomColourTwoSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcbCustomColourOneSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxContrastColourTwoPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxContrastColourOnePreview)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private ContrastType _contrastType;

        private Timer _updateUITimer = new Timer();

        private List<string> _contrastItemsListOne = new List<string>(), _contrastItemsListTwo = new List<string>();
        #endregion

        #region Properties
        public ContrastType ContrastType { get => _contrastType; set => _contrastType = value; }

        public List<string> ContrastItemsListOne { get => _contrastItemsListOne; set => _contrastItemsListOne = value; }

        public List<string> ContrastItemsListTwo { get => _contrastItemsListTwo; set => _contrastItemsListTwo = value; }
        #endregion

        #region Constructors
        public ColourContrastTool()
        {
            InitializeComponent();

            InitialiseUpdateUITimer();
        }

        public ColourContrastTool(ContrastType contrastType)
        {
            InitializeComponent();

            SetContrastType(contrastType);

            InitialiseUpdateUITimer();
        }
        #endregion

        #region Propagation        
        /// <summary>
        /// Propagates the contrast items list one.
        /// </summary>
        /// <param name="values">The values.</param>
        public void PropagateContrastItemsListOne(string[] values)
        {
            foreach (string item in values)
            {
                ContrastItemsListOne.Add(item);
            }
        }

        /// <summary>
        /// Propagates the contrast items list two.
        /// </summary>
        /// <param name="values">The values.</param>
        public void PropagateContrastItemsListTwo(string[] values)
        {
            foreach (string item in values)
            {
                ContrastItemsListTwo.Add(item);
            }
        }

        /// <summary>
        /// Sorts the list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="accending">if set to <c>true</c> [accending].</param>
        /// <returns></returns>
        public List<string> SortList(List<string> list, bool accending = true)
        {
            List<string> tempList = list;

            if (accending)
            {
                tempList.Sort();
            }
            else
            {
                tempList.Reverse();
            }

            return tempList;
        }
        #endregion

        #region Setters/Getters
        /// <summary>
        /// Sets the value of ContrastType to type.
        /// </summary>
        /// <param name="type">The value of ContrastType.</param>
        public void SetContrastType(ContrastType type)
        {
            ContrastType = type;
        }

        /// <summary>
        /// Returns the value of ContrastType.
        /// </summary>
        /// <returns>The value of ContrastType.</returns>
        public ContrastType GetContrastType()
        {
            return ContrastType;
        }
        #endregion

        #region Initialisation Methods
        private void InitialiseUpdateUITimer(int interval = 250)
        {
            _updateUITimer.Enabled = true;

            _updateUITimer.Interval = interval;

            _updateUITimer.Tick += UpdateUITimer_Tick;
        }

        private void InitialiseWindow(ContrastType contrastType)
        {
            if (contrastType == ContrastType.CUSTOMCOLOURS)
            {

            }
            else if (contrastType == ContrastType.CUSTOMTEXTCOLOURS)
            {

            }
        }
        #endregion

        private void ColourContrastTool_Load(object sender, EventArgs e)
        {
            InitialiseWindow(GetContrastType());
        }

        private void KchkUpdateValues_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KbtnOk_Click(object sender, EventArgs e)
        {

        }

        private void KnumAlpaValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KnudRedChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KnudGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KnudBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KtxtHexValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CwChosenColour_ColourChanged(object sender, EventArgs e)
        {

        }

        private void CbxContrastColourOnePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void KcbCustomColourOneSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxContrastColourTwoPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void KcbCustomColourTwoSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateUITimer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}