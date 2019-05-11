#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.IO;

namespace ExtendedControls.ExtendedToolkit.UI.GraphicsTools
{
    /// <summary>
    /// A tool for resizing images (https://www.youtube.com/watch?v=tvet0wU7whw)
    /// </summary>
    /// <seealso cref="ComponentFactory.Krypton.Toolkit.KryptonForm" />
    public class KryptonImageResizingToolWindow : KryptonForm
    {
        #region Designer Code
        private KryptonButton kbtnResizeImage;
        private KryptonButton kbtnSave;
        private KryptonButton kbtnCancel;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonComboBox kcmbFileType;
        private KryptonLabel kryptonLabel4;
        private KryptonNumericUpDown knudHeight;
        private KryptonLabel kryptonLabel3;
        private KryptonNumericUpDown knudWidth;
        private KryptonLabel kryptonLabel2;
        private KryptonButton kbtnBrowseNewImageLocation;
        private KryptonTextBox ktxtNewImageLocation;
        private KryptonLabel kryptonLabel1;
        private KryptonButton kbtnTargetBrowse;
        private KryptonTextBox ktxtTargetImageLocation;
        private KryptonLabel klblPaletteStyle;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues2 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues15 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues14 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues13 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues10 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues11 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues12 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues9 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues8 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues6 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues7 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues5 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues4 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnResizeImage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblPaletteStyle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktxtTargetImageLocation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnTargetBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnBrowseNewImageLocation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktxtNewImageLocation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knudWidth = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knudHeight = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcmbFileType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbFileType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnResizeImage);
            this.kryptonPanel1.Controls.Add(this.kbtnSave);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 158);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(830, 55);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(701, 14);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 14;
            popupPositionValues3.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kbtnCancel.ToolTipValues.ToolTipPosition = popupPositionValues3;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // kbtnSave
            // 
            this.kbtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnSave.Enabled = false;
            this.kbtnSave.Location = new System.Drawing.Point(578, 14);
            this.kbtnSave.Name = "kbtnSave";
            this.kbtnSave.Size = new System.Drawing.Size(117, 29);
            this.kbtnSave.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSave.TabIndex = 15;
            popupPositionValues2.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kbtnSave.ToolTipValues.ToolTipPosition = popupPositionValues2;
            this.kbtnSave.Values.Text = "&Save";
            this.kbtnSave.Click += new System.EventHandler(this.KbtnSave_Click);
            // 
            // kbtnResizeImage
            // 
            this.kbtnResizeImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnResizeImage.Location = new System.Drawing.Point(371, 14);
            this.kbtnResizeImage.Name = "kbtnResizeImage";
            this.kbtnResizeImage.Size = new System.Drawing.Size(201, 29);
            this.kbtnResizeImage.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnResizeImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnResizeImage.TabIndex = 16;
            popupPositionValues1.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kbtnResizeImage.ToolTipValues.ToolTipPosition = popupPositionValues1;
            this.kbtnResizeImage.Values.Text = "Resize &Image";
            this.kbtnResizeImage.Click += new System.EventHandler(this.KbtnResizeImage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 5);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kcmbFileType);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.knudHeight);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.knudWidth);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kbtnBrowseNewImageLocation);
            this.kryptonPanel2.Controls.Add(this.ktxtNewImageLocation);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.kbtnTargetBrowse);
            this.kryptonPanel2.Controls.Add(this.ktxtTargetImageLocation);
            this.kryptonPanel2.Controls.Add(this.klblPaletteStyle);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(830, 153);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // klblPaletteStyle
            // 
            this.klblPaletteStyle.Location = new System.Drawing.Point(12, 12);
            this.klblPaletteStyle.Name = "klblPaletteStyle";
            this.klblPaletteStyle.Size = new System.Drawing.Size(113, 24);
            this.klblPaletteStyle.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblPaletteStyle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblPaletteStyle.TabIndex = 6;
            popupPositionValues15.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.klblPaletteStyle.ToolTipValues.ToolTipPosition = popupPositionValues15;
            this.klblPaletteStyle.Values.Text = "Target Image:";
            // 
            // ktxtTargetImageLocation
            // 
            this.ktxtTargetImageLocation.Hint = "Taget image location...";
            this.ktxtTargetImageLocation.Location = new System.Drawing.Point(131, 10);
            this.ktxtTargetImageLocation.Name = "ktxtTargetImageLocation";
            this.ktxtTargetImageLocation.Size = new System.Drawing.Size(642, 29);
            this.ktxtTargetImageLocation.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtTargetImageLocation.TabIndex = 7;
            popupPositionValues14.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.ktxtTargetImageLocation.ToolTipValues.ToolTipPosition = popupPositionValues14;
            // 
            // kbtnTargetBrowse
            // 
            this.kbtnTargetBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnTargetBrowse.Location = new System.Drawing.Point(779, 12);
            this.kbtnTargetBrowse.Name = "kbtnTargetBrowse";
            this.kbtnTargetBrowse.Size = new System.Drawing.Size(39, 27);
            this.kbtnTargetBrowse.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTargetBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTargetBrowse.TabIndex = 17;
            popupPositionValues13.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kbtnTargetBrowse.ToolTipValues.ToolTipPosition = popupPositionValues13;
            this.kbtnTargetBrowse.Values.Text = "...";
            this.kbtnTargetBrowse.Click += new System.EventHandler(this.KbtnTargetBrowse_Click);
            // 
            // kbtnBrowseNewImageLocation
            // 
            this.kbtnBrowseNewImageLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnBrowseNewImageLocation.Location = new System.Drawing.Point(779, 56);
            this.kbtnBrowseNewImageLocation.Name = "kbtnBrowseNewImageLocation";
            this.kbtnBrowseNewImageLocation.Size = new System.Drawing.Size(39, 27);
            this.kbtnBrowseNewImageLocation.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseNewImageLocation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseNewImageLocation.TabIndex = 20;
            popupPositionValues10.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kbtnBrowseNewImageLocation.ToolTipValues.ToolTipPosition = popupPositionValues10;
            this.kbtnBrowseNewImageLocation.Values.Text = "...";
            this.kbtnBrowseNewImageLocation.Click += new System.EventHandler(this.KbtnBrowseNewImageLocation_Click);
            // 
            // ktxtNewImageLocation
            // 
            this.ktxtNewImageLocation.Hint = "New image location...";
            this.ktxtNewImageLocation.Location = new System.Drawing.Point(131, 54);
            this.ktxtNewImageLocation.Name = "ktxtNewImageLocation";
            this.ktxtNewImageLocation.Size = new System.Drawing.Size(642, 29);
            this.ktxtNewImageLocation.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtNewImageLocation.TabIndex = 19;
            popupPositionValues11.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.ktxtNewImageLocation.ToolTipValues.ToolTipPosition = popupPositionValues11;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 56);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(99, 24);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 18;
            popupPositionValues12.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kryptonLabel1.ToolTipValues.ToolTipPosition = popupPositionValues12;
            this.kryptonLabel1.Values.Text = "Save Image:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(106, 110);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(60, 24);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 21;
            popupPositionValues9.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kryptonLabel2.ToolTipValues.ToolTipPosition = popupPositionValues9;
            this.kryptonLabel2.Values.Text = "Width:";
            // 
            // knudWidth
            // 
            this.knudWidth.DecimalPlaces = 99;
            this.knudWidth.Location = new System.Drawing.Point(172, 108);
            this.knudWidth.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.knudWidth.Name = "knudWidth";
            this.knudWidth.Size = new System.Drawing.Size(120, 28);
            this.knudWidth.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knudWidth.TabIndex = 22;
            this.knudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            popupPositionValues8.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.knudWidth.ToolTipValues.ToolTipPosition = popupPositionValues8;
            // 
            // knudHeight
            // 
            this.knudHeight.DecimalPlaces = 99;
            this.knudHeight.Location = new System.Drawing.Point(393, 108);
            this.knudHeight.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.knudHeight.Name = "knudHeight";
            this.knudHeight.Size = new System.Drawing.Size(120, 28);
            this.knudHeight.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knudHeight.TabIndex = 24;
            this.knudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            popupPositionValues6.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.knudHeight.ToolTipValues.ToolTipPosition = popupPositionValues6;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(322, 110);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(65, 24);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 23;
            popupPositionValues7.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kryptonLabel3.ToolTipValues.ToolTipPosition = popupPositionValues7;
            this.kryptonLabel3.Values.Text = "Height:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(556, 110);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(51, 24);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 25;
            popupPositionValues5.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kryptonLabel4.ToolTipValues.ToolTipPosition = popupPositionValues5;
            this.kryptonLabel4.Values.Text = "Type:";
            // 
            // kcmbFileType
            // 
            this.kcmbFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbFileType.DropDownWidth = 121;
            this.kcmbFileType.Location = new System.Drawing.Point(613, 110);
            this.kcmbFileType.Name = "kcmbFileType";
            this.kcmbFileType.Size = new System.Drawing.Size(121, 27);
            this.kcmbFileType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbFileType.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbFileType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbFileType.TabIndex = 26;
            popupPositionValues4.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kcmbFileType.ToolTipValues.ToolTipPosition = popupPositionValues4;
            // 
            // KryptonImageResizingToolWindow
            // 
            this.ClientSize = new System.Drawing.Size(830, 213);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonImageResizingToolWindow";
            this.ShowInTaskbar = false;
            this.Text = "Krypton Image Resizer";
            this.Load += new System.EventHandler(this.KryptonImageResizingToolWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbFileType)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private Image _image;

        private string[] _extentsions = { ".PNG", ".JPEG", ".JPG", ".GIF" };
        #endregion

        #region Properties
        public Image Image { get => _image; set => _image = value; }

        public string[] Extentions { get => _extentsions; }
        #endregion

        #region Constructors
        public KryptonImageResizingToolWindow()
        {
            InitializeComponent();
        }
        #endregion

        private void KryptonImageResizingToolWindow_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Extentions.Length; i++)
            {
                kcmbFileType.Items.Add(Extentions[i]);
            }
        }

        private void KbtnTargetBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog ticofd = new CommonOpenFileDialog();

            ticofd.Title = "Open a image file:";

            ticofd.Filters.Add(new CommonFileDialogFilter("Portable Network Graphics (*.png)|JPEG Images (*.jpeg, *.jpg)|Graphics Interchange Format (*.gif)", ".png,.jpeg,.jpg,.gif"));

            if (ticofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktxtTargetImageLocation.Text = Path.GetFullPath(ticofd.FileName);

                Image = Image.FromFile(ticofd.FileName);
            }
        }

        private void KbtnBrowseNewImageLocation_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cfd = new CommonOpenFileDialog();

            cfd.IsFolderPicker = true;

            if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktxtNewImageLocation.Text = Path.GetFullPath(cfd.FileName);
            }
        }

        private void KbtnResizeImage_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(knudWidth.Value), height = Convert.ToInt32(knudHeight.Value);

            Image = ResizeImage(Image, width, height);

            ((KryptonButton)sender).Enabled = false;

            ExtendedKryptonMessageBox.Show($"The image: { Path.GetFileName(ktxtTargetImageLocation.Text) } has been resized to width: { knudWidth.Value.ToString() }, height: { knudHeight.Value.ToString() }.");

            kbtnSave.Enabled = true;
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);

            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap);

            graphics.DrawImage(image, 0, 0, width, height);

            graphics.Dispose();

            return bitmap;
        }

        private void KbtnSave_Click(object sender, EventArgs e)
        {
            int dot = 0, slash = 0;

            for (int j = ktxtTargetImageLocation.Text.Length - 1; j >= 0; j--)
            {
                if (ktxtTargetImageLocation.Text[j] == '.')
                {
                    dot = j;
                }
                else if (ktxtTargetImageLocation.Text[j] == '\\')
                {
                    slash = j;

                    break;
                }
            }

            Image.Save(ktxtNewImageLocation.Text + "\\" + ktxtTargetImageLocation.Text.Substring(slash + 1, dot - slash - 1) + Extentions[kcmbFileType.SelectedIndex]);

            ((KryptonButton)sender).Enabled = false;
        }
    }
}