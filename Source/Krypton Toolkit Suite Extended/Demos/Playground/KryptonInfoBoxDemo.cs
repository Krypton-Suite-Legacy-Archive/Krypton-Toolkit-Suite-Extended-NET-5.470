#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using Core.Classes;
using Core.Classes.Other;
using ExtendedDialogs.Classes;
using ExtendedDialogs.Dialogs.IO;
using System;
using System.Drawing;

namespace Playground
{
    public class KryptonInfoBoxDemo : KryptonForm
    {
        #region Designer Code
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonLabel kryptonLabel8;
        private KryptonLabel kryptonLabel7;
        private KryptonLabel kryptonLabel2;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel5;
        private KryptonLabel kryptonLabel6;
        private KryptonLabel kryptonLabel1;
        private KryptonComboBox kcmbIcon;
        private KryptonTextBox ktxtCustomIcon;
        private KryptonLabel klblCustomIcon;
        private KryptonTextBox ktxtTitleText;
        private KryptonTextBox ktxtMessageText;
        private KryptonComboBox kcmbImageSize;
        private KryptonButton kbtnCancel;
        private KryptonComboBox kcmbType;
        private KryptonTextBox ktxtCancelText;
        private KryptonTextBox ktxtYesText;
        private KryptonTextBox ktxtNoText;
        private KryptonTextBox ktxtOkText;
        private KryptonTextBox ktxtHintText;
        private KryptonLabel kryptonLabel11;
        private KryptonTextBox ktxtAbortText;
        private KryptonLabel klblCustomButtonText;
        private KryptonComboBox kcmbButtons;
        private KryptonComboBox kcmbLanguage;
        private KryptonComboBox kcmbCustomItems;
        private KryptonLabel kryptonLabel14;
        private KryptonButton kbtnInsertCustomItems;
        private KryptonGroup kryptonGroup4;
        private KryptonGroup kryptonGroup5;
        private KryptonGroup kryptonGroup3;
        private KryptonGroup kryptonGroup2;
        private KryptonNumericUpDown knumHeight;
        private KryptonLabel kryptonLabel15;
        private KryptonLabel kryptonLabel16;
        private KryptonNumericUpDown knumWidth;
        private KryptonGroup kryptonGroup1;
        private KryptonButton kbtnBrowseCustomIcon;
        private KryptonButton kbtnTest;
        private KryptonLabel kryptonLabel13;
        private KryptonLabel kryptonLabel12;
        private KryptonLabel kryptonLabel10;
        private KryptonLabel kryptonLabel9;
        private KryptonComboBox kcmbMessaageTextAlignment;
        private KryptonComboBox kcmbUserSelectionAlignment;
        private KryptonComboBox kcmbUserInputTextAlignment;
        private KryptonComboBox kcmbStartPosition;
        private KryptonComboBox kcmbRightToLeft;
        private KryptonCheckBox kcbAlwaysOnTop;
        private KryptonComboBox kcmbShowInTaskbar;
        private KryptonLabel kryptonLabel17;
        private KryptonButton kbtnMessageTypeface;
        private KryptonLabel kryptonLabel19;
        private KryptonTextBox ktxtMessageTypeface;
        private KryptonButton kbtnCommonTypeface;
        private KryptonLabel kryptonLabel18;
        private KryptonTextBox ktxtCommonTypeface;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kcbAlwaysOnTop = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kbtnTest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnMessageTypeface = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel19 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktxtMessageTypeface = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnCommonTypeface = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel18 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktxtCommonTypeface = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kcmbShowInTaskbar = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel17 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcmbMessaageTextAlignment = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kcmbUserSelectionAlignment = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kcmbUserInputTextAlignment = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kcmbStartPosition = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kcmbRightToLeft = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroup4 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcmbCustomItems = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kbtnInsertCustomItems = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroup5 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.klblCustomButtonText = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktxtAbortText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtOkText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtNoText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtYesText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtCancelText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktxtHintText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.knumHeight = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumWidth = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kbtnBrowseCustomIcon = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblCustomIcon = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktxtCustomIcon = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kcmbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kcmbButtons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kcmbLanguage = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kcmbIcon = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.ktxtTitleText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtMessageText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kcmbImageSize = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbShowInTaskbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbMessaageTextAlignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbUserSelectionAlignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbUserInputTextAlignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbStartPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbRightToLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4.Panel)).BeginInit();
            this.kryptonGroup4.Panel.SuspendLayout();
            this.kryptonGroup4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbCustomItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5.Panel)).BeginInit();
            this.kryptonGroup5.Panel.SuspendLayout();
            this.kryptonGroup5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbImageSize)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kcbAlwaysOnTop);
            this.kryptonPanel1.Controls.Add(this.kbtnTest);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 734);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1142, 57);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kcbAlwaysOnTop
            // 
            this.kcbAlwaysOnTop.Location = new System.Drawing.Point(13, 19);
            this.kcbAlwaysOnTop.Name = "kcbAlwaysOnTop";
            this.kcbAlwaysOnTop.Size = new System.Drawing.Size(131, 26);
            this.kcbAlwaysOnTop.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbAlwaysOnTop.TabIndex = 50;
            this.kcbAlwaysOnTop.Values.Text = "&Always on Top";
            // 
            // kbtnTest
            // 
            this.kbtnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnTest.Location = new System.Drawing.Point(828, 6);
            this.kbtnTest.Name = "kbtnTest";
            this.kbtnTest.Size = new System.Drawing.Size(148, 39);
            this.kbtnTest.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTest.TabIndex = 1;
            this.kbtnTest.Values.Text = "Te&st";
            this.kbtnTest.Click += new System.EventHandler(this.kbtnTest_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.Location = new System.Drawing.Point(982, 6);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(148, 39);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 0;
            this.kbtnCancel.Values.Text = "Canc&el";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 731);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 3);
            this.panel1.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnMessageTypeface);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel19);
            this.kryptonPanel2.Controls.Add(this.ktxtMessageTypeface);
            this.kryptonPanel2.Controls.Add(this.kbtnCommonTypeface);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel18);
            this.kryptonPanel2.Controls.Add(this.ktxtCommonTypeface);
            this.kryptonPanel2.Controls.Add(this.kcmbShowInTaskbar);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel17);
            this.kryptonPanel2.Controls.Add(this.kcmbMessaageTextAlignment);
            this.kryptonPanel2.Controls.Add(this.kcmbUserSelectionAlignment);
            this.kryptonPanel2.Controls.Add(this.kcmbUserInputTextAlignment);
            this.kryptonPanel2.Controls.Add(this.kcmbStartPosition);
            this.kryptonPanel2.Controls.Add(this.kcmbRightToLeft);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel13);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel2.Controls.Add(this.kryptonGroup4);
            this.kryptonPanel2.Controls.Add(this.kryptonGroup5);
            this.kryptonPanel2.Controls.Add(this.kryptonGroup3);
            this.kryptonPanel2.Controls.Add(this.kryptonGroup2);
            this.kryptonPanel2.Controls.Add(this.kryptonGroup1);
            this.kryptonPanel2.Controls.Add(this.kcmbType);
            this.kryptonPanel2.Controls.Add(this.kcmbButtons);
            this.kryptonPanel2.Controls.Add(this.kcmbLanguage);
            this.kryptonPanel2.Controls.Add(this.kcmbIcon);
            this.kryptonPanel2.Controls.Add(this.ktxtTitleText);
            this.kryptonPanel2.Controls.Add(this.ktxtMessageText);
            this.kryptonPanel2.Controls.Add(this.kcmbImageSize);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1142, 731);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kbtnMessageTypeface
            // 
            this.kbtnMessageTypeface.AutoSize = true;
            this.kbtnMessageTypeface.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnMessageTypeface.Enabled = false;
            this.kbtnMessageTypeface.Location = new System.Drawing.Point(1107, 684);
            this.kbtnMessageTypeface.Name = "kbtnMessageTypeface";
            this.kbtnMessageTypeface.Size = new System.Drawing.Size(23, 30);
            this.kbtnMessageTypeface.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnMessageTypeface.TabIndex = 56;
            this.kbtnMessageTypeface.Values.Text = "...";
            // 
            // kryptonLabel19
            // 
            this.kryptonLabel19.Enabled = false;
            this.kryptonLabel19.Location = new System.Drawing.Point(547, 686);
            this.kryptonLabel19.Name = "kryptonLabel19";
            this.kryptonLabel19.Size = new System.Drawing.Size(170, 28);
            this.kryptonLabel19.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel19.TabIndex = 57;
            this.kryptonLabel19.Values.Text = "Message Typeface:";
            // 
            // ktxtMessageTypeface
            // 
            this.ktxtMessageTypeface.Enabled = false;
            this.ktxtMessageTypeface.Location = new System.Drawing.Point(723, 684);
            this.ktxtMessageTypeface.Name = "ktxtMessageTypeface";
            this.ktxtMessageTypeface.Size = new System.Drawing.Size(378, 29);
            this.ktxtMessageTypeface.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtMessageTypeface.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtMessageTypeface.TabIndex = 55;
            // 
            // kbtnCommonTypeface
            // 
            this.kbtnCommonTypeface.AutoSize = true;
            this.kbtnCommonTypeface.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnCommonTypeface.Enabled = false;
            this.kbtnCommonTypeface.Location = new System.Drawing.Point(1107, 588);
            this.kbtnCommonTypeface.Name = "kbtnCommonTypeface";
            this.kbtnCommonTypeface.Size = new System.Drawing.Size(23, 30);
            this.kbtnCommonTypeface.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCommonTypeface.TabIndex = 53;
            this.kbtnCommonTypeface.Values.Text = "...";
            // 
            // kryptonLabel18
            // 
            this.kryptonLabel18.Enabled = false;
            this.kryptonLabel18.Location = new System.Drawing.Point(527, 590);
            this.kryptonLabel18.Name = "kryptonLabel18";
            this.kryptonLabel18.Size = new System.Drawing.Size(190, 28);
            this.kryptonLabel18.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel18.TabIndex = 54;
            this.kryptonLabel18.Values.Text = "Commmon Typeface:";
            // 
            // ktxtCommonTypeface
            // 
            this.ktxtCommonTypeface.Enabled = false;
            this.ktxtCommonTypeface.Location = new System.Drawing.Point(723, 588);
            this.ktxtCommonTypeface.Name = "ktxtCommonTypeface";
            this.ktxtCommonTypeface.Size = new System.Drawing.Size(378, 29);
            this.ktxtCommonTypeface.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtCommonTypeface.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtCommonTypeface.TabIndex = 52;
            // 
            // kcmbShowInTaskbar
            // 
            this.kcmbShowInTaskbar.AutoCompleteCustomSource.AddRange(new string[] {
            "True",
            "False"});
            this.kcmbShowInTaskbar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbShowInTaskbar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbShowInTaskbar.DropDownWidth = 149;
            this.kcmbShowInTaskbar.IntegralHeight = false;
            this.kcmbShowInTaskbar.Items.AddRange(new object[] {
            "True",
            "False"});
            this.kcmbShowInTaskbar.Location = new System.Drawing.Point(981, 399);
            this.kcmbShowInTaskbar.Name = "kcmbShowInTaskbar";
            this.kcmbShowInTaskbar.Size = new System.Drawing.Size(149, 27);
            this.kcmbShowInTaskbar.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbShowInTaskbar.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbShowInTaskbar.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbShowInTaskbar.TabIndex = 51;
            // 
            // kryptonLabel17
            // 
            this.kryptonLabel17.Location = new System.Drawing.Point(678, 396);
            this.kryptonLabel17.Name = "kryptonLabel17";
            this.kryptonLabel17.Size = new System.Drawing.Size(169, 30);
            this.kryptonLabel17.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel17.TabIndex = 50;
            this.kryptonLabel17.Values.Text = "Show in Taskbar:";
            // 
            // kcmbMessaageTextAlignment
            // 
            this.kcmbMessaageTextAlignment.AutoCompleteCustomSource.AddRange(new string[] {
            "Left",
            "Centre",
            "Right"});
            this.kcmbMessaageTextAlignment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbMessaageTextAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbMessaageTextAlignment.DropDownWidth = 149;
            this.kcmbMessaageTextAlignment.IntegralHeight = false;
            this.kcmbMessaageTextAlignment.Items.AddRange(new object[] {
            "Left",
            "Centre",
            "Right"});
            this.kcmbMessaageTextAlignment.Location = new System.Drawing.Point(264, 684);
            this.kcmbMessaageTextAlignment.Name = "kcmbMessaageTextAlignment";
            this.kcmbMessaageTextAlignment.Size = new System.Drawing.Size(149, 27);
            this.kcmbMessaageTextAlignment.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbMessaageTextAlignment.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbMessaageTextAlignment.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbMessaageTextAlignment.TabIndex = 49;
            // 
            // kcmbUserSelectionAlignment
            // 
            this.kcmbUserSelectionAlignment.AutoCompleteCustomSource.AddRange(new string[] {
            "Left",
            "Centre",
            "Right"});
            this.kcmbUserSelectionAlignment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbUserSelectionAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbUserSelectionAlignment.DropDownWidth = 149;
            this.kcmbUserSelectionAlignment.IntegralHeight = false;
            this.kcmbUserSelectionAlignment.Items.AddRange(new object[] {
            "Left",
            "Centre",
            "Right"});
            this.kcmbUserSelectionAlignment.Location = new System.Drawing.Point(981, 108);
            this.kcmbUserSelectionAlignment.Name = "kcmbUserSelectionAlignment";
            this.kcmbUserSelectionAlignment.Size = new System.Drawing.Size(149, 27);
            this.kcmbUserSelectionAlignment.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbUserSelectionAlignment.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbUserSelectionAlignment.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbUserSelectionAlignment.TabIndex = 48;
            // 
            // kcmbUserInputTextAlignment
            // 
            this.kcmbUserInputTextAlignment.AutoCompleteCustomSource.AddRange(new string[] {
            "Left",
            "Centre",
            "Right"});
            this.kcmbUserInputTextAlignment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbUserInputTextAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbUserInputTextAlignment.DropDownWidth = 149;
            this.kcmbUserInputTextAlignment.IntegralHeight = false;
            this.kcmbUserInputTextAlignment.Items.AddRange(new object[] {
            "Left",
            "Centre",
            "Right"});
            this.kcmbUserInputTextAlignment.Location = new System.Drawing.Point(981, 12);
            this.kcmbUserInputTextAlignment.Name = "kcmbUserInputTextAlignment";
            this.kcmbUserInputTextAlignment.Size = new System.Drawing.Size(149, 27);
            this.kcmbUserInputTextAlignment.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbUserInputTextAlignment.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbUserInputTextAlignment.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbUserInputTextAlignment.TabIndex = 47;
            // 
            // kcmbStartPosition
            // 
            this.kcmbStartPosition.AutoCompleteCustomSource.AddRange(new string[] {
            "Manual",
            "CenterScreen",
            "WindowsDefaultLocation",
            "WindowsDefaultBounds",
            "CenterParent"});
            this.kcmbStartPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbStartPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbStartPosition.DropDownWidth = 149;
            this.kcmbStartPosition.IntegralHeight = false;
            this.kcmbStartPosition.Items.AddRange(new object[] {
            "Manual",
            "CenterScreen",
            "WindowsDefaultLocation",
            "WindowsDefaultBounds",
            "CenterParent"});
            this.kcmbStartPosition.Location = new System.Drawing.Point(981, 204);
            this.kcmbStartPosition.Name = "kcmbStartPosition";
            this.kcmbStartPosition.Size = new System.Drawing.Size(149, 27);
            this.kcmbStartPosition.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbStartPosition.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbStartPosition.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbStartPosition.TabIndex = 46;
            // 
            // kcmbRightToLeft
            // 
            this.kcmbRightToLeft.AutoCompleteCustomSource.AddRange(new string[] {
            "No",
            "Yes",
            "Inherit"});
            this.kcmbRightToLeft.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbRightToLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbRightToLeft.DropDownWidth = 149;
            this.kcmbRightToLeft.IntegralHeight = false;
            this.kcmbRightToLeft.Items.AddRange(new object[] {
            "No",
            "Yes",
            "Inherit"});
            this.kcmbRightToLeft.Location = new System.Drawing.Point(981, 300);
            this.kcmbRightToLeft.Name = "kcmbRightToLeft";
            this.kcmbRightToLeft.Size = new System.Drawing.Size(149, 27);
            this.kcmbRightToLeft.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbRightToLeft.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbRightToLeft.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbRightToLeft.TabIndex = 44;
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(678, 12);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(262, 30);
            this.kryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel13.TabIndex = 43;
            this.kryptonLabel13.Values.Text = "User Input Text Alignment:";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(678, 108);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(297, 30);
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.TabIndex = 42;
            this.kryptonLabel12.Values.Text = "User Selection Text Alignment:";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(678, 204);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(143, 30);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 41;
            this.kryptonLabel10.Values.Text = "Start Position:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(678, 297);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(134, 30);
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 40;
            this.kryptonLabel9.Values.Text = "Right to Left:";
            // 
            // kryptonGroup4
            // 
            this.kryptonGroup4.AutoSize = true;
            this.kryptonGroup4.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonGroup4.Location = new System.Drawing.Point(29, 624);
            this.kryptonGroup4.Name = "kryptonGroup4";
            // 
            // kryptonGroup4.Panel
            // 
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonLabel14);
            this.kryptonGroup4.Panel.Controls.Add(this.kcmbCustomItems);
            this.kryptonGroup4.Panel.Controls.Add(this.kbtnInsertCustomItems);
            this.kryptonGroup4.Size = new System.Drawing.Size(317, 46);
            this.kryptonGroup4.TabIndex = 38;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Enabled = false;
            this.kryptonLabel14.Location = new System.Drawing.Point(13, 11);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(115, 28);
            this.kryptonLabel14.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel14.TabIndex = 33;
            this.kryptonLabel14.Values.Text = "Custom List:";
            // 
            // kcmbCustomItems
            // 
            this.kcmbCustomItems.AutoCompleteCustomSource.AddRange(new string[] {
            "Custom",
            "32 x 32",
            "48 x 48",
            "64 x 64",
            "128 x 128"});
            this.kcmbCustomItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbCustomItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbCustomItems.DropDownWidth = 149;
            this.kcmbCustomItems.Enabled = false;
            this.kcmbCustomItems.IntegralHeight = false;
            this.kcmbCustomItems.Location = new System.Drawing.Point(134, 11);
            this.kcmbCustomItems.Name = "kcmbCustomItems";
            this.kcmbCustomItems.Size = new System.Drawing.Size(149, 27);
            this.kcmbCustomItems.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbCustomItems.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbCustomItems.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbCustomItems.TabIndex = 0;
            // 
            // kbtnInsertCustomItems
            // 
            this.kbtnInsertCustomItems.AutoSize = true;
            this.kbtnInsertCustomItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnInsertCustomItems.Enabled = false;
            this.kbtnInsertCustomItems.Location = new System.Drawing.Point(289, 11);
            this.kbtnInsertCustomItems.Name = "kbtnInsertCustomItems";
            this.kbtnInsertCustomItems.Size = new System.Drawing.Size(23, 30);
            this.kbtnInsertCustomItems.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInsertCustomItems.TabIndex = 1;
            this.kbtnInsertCustomItems.Values.Text = "...";
            this.kbtnInsertCustomItems.Click += new System.EventHandler(this.kbtnInsertCustomItems_Click);
            // 
            // kryptonGroup5
            // 
            this.kryptonGroup5.AutoSize = true;
            this.kryptonGroup5.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonGroup5.Location = new System.Drawing.Point(29, 528);
            this.kryptonGroup5.Name = "kryptonGroup5";
            // 
            // kryptonGroup5.Panel
            // 
            this.kryptonGroup5.Panel.Controls.Add(this.klblCustomButtonText);
            this.kryptonGroup5.Panel.Controls.Add(this.ktxtAbortText);
            this.kryptonGroup5.Panel.Controls.Add(this.ktxtOkText);
            this.kryptonGroup5.Panel.Controls.Add(this.ktxtNoText);
            this.kryptonGroup5.Panel.Controls.Add(this.ktxtYesText);
            this.kryptonGroup5.Panel.Controls.Add(this.ktxtCancelText);
            this.kryptonGroup5.Size = new System.Drawing.Size(807, 46);
            this.kryptonGroup5.TabIndex = 39;
            // 
            // klblCustomButtonText
            // 
            this.klblCustomButtonText.Enabled = false;
            this.klblCustomButtonText.Location = new System.Drawing.Point(15, 12);
            this.klblCustomButtonText.Name = "klblCustomButtonText";
            this.klblCustomButtonText.Size = new System.Drawing.Size(123, 28);
            this.klblCustomButtonText.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.klblCustomButtonText.TabIndex = 20;
            this.klblCustomButtonText.Values.Text = "Custom Text:";
            // 
            // ktxtAbortText
            // 
            this.ktxtAbortText.Enabled = false;
            this.ktxtAbortText.Hint = "Abort Text";
            this.ktxtAbortText.Location = new System.Drawing.Point(143, 12);
            this.ktxtAbortText.Name = "ktxtAbortText";
            this.ktxtAbortText.Size = new System.Drawing.Size(127, 29);
            this.ktxtAbortText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtAbortText.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtAbortText.TabIndex = 0;
            // 
            // ktxtOkText
            // 
            this.ktxtOkText.Enabled = false;
            this.ktxtOkText.Hint = "Ok Text";
            this.ktxtOkText.Location = new System.Drawing.Point(675, 12);
            this.ktxtOkText.Name = "ktxtOkText";
            this.ktxtOkText.Size = new System.Drawing.Size(127, 29);
            this.ktxtOkText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtOkText.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtOkText.TabIndex = 4;
            // 
            // ktxtNoText
            // 
            this.ktxtNoText.Enabled = false;
            this.ktxtNoText.Hint = "No Text";
            this.ktxtNoText.Location = new System.Drawing.Point(542, 12);
            this.ktxtNoText.Name = "ktxtNoText";
            this.ktxtNoText.Size = new System.Drawing.Size(127, 29);
            this.ktxtNoText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtNoText.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtNoText.TabIndex = 3;
            // 
            // ktxtYesText
            // 
            this.ktxtYesText.Enabled = false;
            this.ktxtYesText.Hint = "Yes Text";
            this.ktxtYesText.Location = new System.Drawing.Point(409, 12);
            this.ktxtYesText.Name = "ktxtYesText";
            this.ktxtYesText.Size = new System.Drawing.Size(127, 29);
            this.ktxtYesText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtYesText.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtYesText.TabIndex = 2;
            // 
            // ktxtCancelText
            // 
            this.ktxtCancelText.Enabled = false;
            this.ktxtCancelText.Hint = "Cancel Text";
            this.ktxtCancelText.Location = new System.Drawing.Point(276, 12);
            this.ktxtCancelText.Name = "ktxtCancelText";
            this.ktxtCancelText.Size = new System.Drawing.Size(127, 29);
            this.ktxtCancelText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtCancelText.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtCancelText.TabIndex = 1;
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.AutoSize = true;
            this.kryptonGroup3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonGroup3.Location = new System.Drawing.Point(29, 48);
            this.kryptonGroup3.Name = "kryptonGroup3";
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel11);
            this.kryptonGroup3.Panel.Controls.Add(this.ktxtHintText);
            this.kryptonGroup3.Size = new System.Drawing.Size(498, 43);
            this.kryptonGroup3.TabIndex = 38;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(9, 9);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(95, 28);
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel11.TabIndex = 22;
            this.kryptonLabel11.Values.Text = "Hint Text:";
            // 
            // ktxtHintText
            // 
            this.ktxtHintText.Location = new System.Drawing.Point(115, 9);
            this.ktxtHintText.Name = "ktxtHintText";
            this.ktxtHintText.Size = new System.Drawing.Size(378, 29);
            this.ktxtHintText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtHintText.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtHintText.TabIndex = 0;
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.AutoSize = true;
            this.kryptonGroup2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonGroup2.Location = new System.Drawing.Point(29, 240);
            this.kryptonGroup2.Name = "kryptonGroup2";
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.knumHeight);
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonLabel15);
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonLabel16);
            this.kryptonGroup2.Panel.Controls.Add(this.knumWidth);
            this.kryptonGroup2.Size = new System.Drawing.Size(401, 40);
            this.kryptonGroup2.TabIndex = 38;
            // 
            // knumHeight
            // 
            this.knumHeight.Location = new System.Drawing.Point(311, 7);
            this.knumHeight.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.knumHeight.Name = "knumHeight";
            this.knumHeight.Size = new System.Drawing.Size(85, 28);
            this.knumHeight.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumHeight.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumHeight.TabIndex = 2;
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(231, 7);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(74, 28);
            this.kryptonLabel15.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel15.TabIndex = 1;
            this.kryptonLabel15.Values.Text = "Height:";
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(12, 7);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(69, 28);
            this.kryptonLabel16.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel16.TabIndex = 30;
            this.kryptonLabel16.Values.Text = "Width:";
            // 
            // knumWidth
            // 
            this.knumWidth.Location = new System.Drawing.Point(118, 7);
            this.knumWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.knumWidth.Name = "knumWidth";
            this.knumWidth.Size = new System.Drawing.Size(85, 28);
            this.knumWidth.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumWidth.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumWidth.TabIndex = 0;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.AutoSize = true;
            this.kryptonGroup1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonGroup1.Location = new System.Drawing.Point(29, 336);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kbtnBrowseCustomIcon);
            this.kryptonGroup1.Panel.Controls.Add(this.klblCustomIcon);
            this.kryptonGroup1.Panel.Controls.Add(this.ktxtCustomIcon);
            this.kryptonGroup1.Size = new System.Drawing.Size(552, 47);
            this.kryptonGroup1.TabIndex = 37;
            // 
            // kbtnBrowseCustomIcon
            // 
            this.kbtnBrowseCustomIcon.AutoSize = true;
            this.kbtnBrowseCustomIcon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnBrowseCustomIcon.Enabled = false;
            this.kbtnBrowseCustomIcon.Location = new System.Drawing.Point(524, 12);
            this.kbtnBrowseCustomIcon.Name = "kbtnBrowseCustomIcon";
            this.kbtnBrowseCustomIcon.Size = new System.Drawing.Size(23, 30);
            this.kbtnBrowseCustomIcon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseCustomIcon.TabIndex = 1;
            this.kbtnBrowseCustomIcon.Values.Text = "...";
            this.kbtnBrowseCustomIcon.Click += new System.EventHandler(this.kbtnBrowseCustomIcon_Click);
            // 
            // klblCustomIcon
            // 
            this.klblCustomIcon.Enabled = false;
            this.klblCustomIcon.Location = new System.Drawing.Point(12, 12);
            this.klblCustomIcon.Name = "klblCustomIcon";
            this.klblCustomIcon.Size = new System.Drawing.Size(122, 28);
            this.klblCustomIcon.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.klblCustomIcon.TabIndex = 15;
            this.klblCustomIcon.Values.Text = "Custom Icon:";
            // 
            // ktxtCustomIcon
            // 
            this.ktxtCustomIcon.Enabled = false;
            this.ktxtCustomIcon.Location = new System.Drawing.Point(140, 12);
            this.ktxtCustomIcon.Name = "ktxtCustomIcon";
            this.ktxtCustomIcon.Size = new System.Drawing.Size(378, 29);
            this.ktxtCustomIcon.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtCustomIcon.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtCustomIcon.TabIndex = 0;
            // 
            // kcmbType
            // 
            this.kcmbType.AutoCompleteCustomSource.AddRange(new string[] {
            "Custom",
            "32 x 32",
            "48 x 48",
            "64 x 64",
            "128 x 128"});
            this.kcmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbType.DropDownWidth = 149;
            this.kcmbType.IntegralHeight = false;
            this.kcmbType.Items.AddRange(new object[] {
            "Custom",
            "32 x 32",
            "48 x 48",
            "64 x 64",
            "128 x 128"});
            this.kcmbType.Location = new System.Drawing.Point(135, 588);
            this.kcmbType.Name = "kcmbType";
            this.kcmbType.Size = new System.Drawing.Size(149, 27);
            this.kcmbType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbType.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbType.TabIndex = 6;
            this.kcmbType.TextChanged += new System.EventHandler(this.ktxtType_TextChanged);
            // 
            // kcmbButtons
            // 
            this.kcmbButtons.AutoCompleteCustomSource.AddRange(new string[] {
            "Custom",
            "32 x 32",
            "48 x 48",
            "64 x 64",
            "128 x 128"});
            this.kcmbButtons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbButtons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbButtons.DropDownWidth = 149;
            this.kcmbButtons.IntegralHeight = false;
            this.kcmbButtons.Items.AddRange(new object[] {
            "Ok",
            "Ok, Cancel",
            "Yes, No",
            "Yes, No, Cancel",
            "-----------------",
            "Custom"});
            this.kcmbButtons.Location = new System.Drawing.Point(135, 492);
            this.kcmbButtons.Name = "kcmbButtons";
            this.kcmbButtons.Size = new System.Drawing.Size(149, 27);
            this.kcmbButtons.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbButtons.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbButtons.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbButtons.TabIndex = 5;
            this.kcmbButtons.TextChanged += new System.EventHandler(this.kcmbButtons_TextChanged);
            // 
            // kcmbLanguage
            // 
            this.kcmbLanguage.AutoCompleteCustomSource.AddRange(new string[] {
            "Custom",
            "32 x 32",
            "48 x 48",
            "64 x 64",
            "128 x 128"});
            this.kcmbLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbLanguage.DropDownWidth = 149;
            this.kcmbLanguage.IntegralHeight = false;
            this.kcmbLanguage.Items.AddRange(new object[] {
            "Czech",
            "English",
            "Français",
            "Deutsch",
            "Slovakian",
            "Español",
            "-----------",
            "Custom"});
            this.kcmbLanguage.Location = new System.Drawing.Point(135, 396);
            this.kcmbLanguage.Name = "kcmbLanguage";
            this.kcmbLanguage.Size = new System.Drawing.Size(149, 27);
            this.kcmbLanguage.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbLanguage.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbLanguage.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbLanguage.TabIndex = 4;
            // 
            // kcmbIcon
            // 
            this.kcmbIcon.AutoCompleteCustomSource.AddRange(new string[] {
            "Custom",
            "Ok",
            "Error",
            "Exclamation",
            "Information",
            "Question",
            "None",
            "Stop",
            "Hand"});
            this.kcmbIcon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbIcon.DropDownWidth = 149;
            this.kcmbIcon.IntegralHeight = false;
            this.kcmbIcon.Items.AddRange(new object[] {
            "Custom",
            "Ok",
            "Error",
            "Exclamation",
            "Information",
            "Question",
            "None",
            "Stop",
            "Hand"});
            this.kcmbIcon.Location = new System.Drawing.Point(135, 300);
            this.kcmbIcon.Name = "kcmbIcon";
            this.kcmbIcon.Size = new System.Drawing.Size(149, 27);
            this.kcmbIcon.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbIcon.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbIcon.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbIcon.TabIndex = 3;
            this.kcmbIcon.TextChanged += new System.EventHandler(this.kcmbIcon_TextChanged);
            // 
            // ktxtTitleText
            // 
            this.ktxtTitleText.Location = new System.Drawing.Point(135, 108);
            this.ktxtTitleText.Name = "ktxtTitleText";
            this.ktxtTitleText.Size = new System.Drawing.Size(378, 29);
            this.ktxtTitleText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtTitleText.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtTitleText.TabIndex = 1;
            // 
            // ktxtMessageText
            // 
            this.ktxtMessageText.Location = new System.Drawing.Point(135, 12);
            this.ktxtMessageText.Name = "ktxtMessageText";
            this.ktxtMessageText.Size = new System.Drawing.Size(378, 29);
            this.ktxtMessageText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtMessageText.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtMessageText.TabIndex = 0;
            // 
            // kcmbImageSize
            // 
            this.kcmbImageSize.AutoCompleteCustomSource.AddRange(new string[] {
            "Custom",
            "ThirtyTwo",
            "FourtyEight",
            "SixtyFour",
            "OneHundredAndTwentyEight"});
            this.kcmbImageSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kcmbImageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbImageSize.DropDownWidth = 149;
            this.kcmbImageSize.IntegralHeight = false;
            this.kcmbImageSize.Items.AddRange(new object[] {
            "Custom",
            "ThirtyTwo",
            "FourtyEight",
            "SixtyFour",
            "OneHundredAndTwentyEight"});
            this.kcmbImageSize.Location = new System.Drawing.Point(135, 204);
            this.kcmbImageSize.Name = "kcmbImageSize";
            this.kcmbImageSize.Size = new System.Drawing.Size(149, 27);
            this.kcmbImageSize.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbImageSize.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbImageSize.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbImageSize.TabIndex = 2;
            this.kcmbImageSize.TextChanged += new System.EventHandler(this.kcmbImageSize_TextChanged);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(12, 492);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(90, 30);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 11;
            this.kryptonLabel8.Values.Text = "Buttons:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(13, 588);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(63, 30);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 10;
            this.kryptonLabel7.Values.Text = "Type:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 396);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(108, 30);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Language:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 300);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(58, 30);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Icon:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 204);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(117, 30);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 7;
            this.kryptonLabel4.Values.Text = "Image Size:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 684);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(246, 30);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 8;
            this.kryptonLabel5.Values.Text = "Message Text Alignment:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 108);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(59, 30);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 9;
            this.kryptonLabel6.Values.Text = "Title:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(98, 30);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Message:";
            // 
            // KryptonInfoBoxDemo
            // 
            this.ClientSize = new System.Drawing.Size(1142, 791);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonInfoBoxDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KryptonInfoBoxDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbShowInTaskbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbMessaageTextAlignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbUserSelectionAlignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbUserInputTextAlignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbStartPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbRightToLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4.Panel)).EndInit();
            this.kryptonGroup4.Panel.ResumeLayout(false);
            this.kryptonGroup4.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4)).EndInit();
            this.kryptonGroup4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbCustomItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5.Panel)).EndInit();
            this.kryptonGroup5.Panel.ResumeLayout(false);
            this.kryptonGroup5.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5)).EndInit();
            this.kryptonGroup5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            this.kryptonGroup3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            this.kryptonGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbImageSize)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructor
        public KryptonInfoBoxDemo()
        {
            InitializeComponent();
        }
        #endregion

        private void KryptonInfoBoxDemo_Load(object sender, EventArgs e)
        {

        }

        private void kcmbImageSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void kcmbIcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void kcmbButtons_TextChanged(object sender, EventArgs e)
        {

        }

        private void ktxtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void kbtnBrowseCustomIcon_Click(object sender, EventArgs e)
        {

        }

        private void kbtnInsertCustomItems_Click(object sender, EventArgs e)
        {

        }

        private void kbtnTest_Click(object sender, EventArgs e)
        {
            FontConverter fcCommon = new FontConverter(), fcMessage = new FontConverter();

            //KryptonInputBoxExtendedNew kryptonInputBox = new KryptonInputBoxExtendedNew(ktxtMessageText.Text, ktxtTitleText.Text, EnumerationTranslator.TranslateInputBoxIconImageSize(kcmbImageSize.Text), EnumerationTranslator.TranslateInputBoxIcon(kcmbIcon.Text), new Bitmap(ktxtCustomIcon.Text), EnumerationTranslator.TranslateInputLanguage(kcmbLanguage.Text), EnumerationTranslator.TranslateInputBoxButtons(kcmbButtons.Text), EnumerationTranslator.TranslateInputBoxType(kcmbType.Text), TranslationMethods.ObjectCollectionToArray(kcmbCustomItems.Items), ConversionMethods.ConvertStringToBoolean(kcmbShowInTaskbar.Text), null, null, ktxtOkText.Text, ktxtYesText.Text, ktxtNoText.Text, ktxtCancelText.Text, ktxtHintText.Text, EnumerationTranslator.TranslateInputBoxMessageTextAlignment(kcmbMessaageTextAlignment.Text), EnumerationTranslator.TranslateInputBoxUserInputTextAlignment(kcmbUserInputTextAlignment.Text), EnumerationTranslator.TranslateInputBoxUserSelectionTextAlignment(kcmbUserSelectionAlignment.Text));

            //kryptonInputBox.Show();
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}