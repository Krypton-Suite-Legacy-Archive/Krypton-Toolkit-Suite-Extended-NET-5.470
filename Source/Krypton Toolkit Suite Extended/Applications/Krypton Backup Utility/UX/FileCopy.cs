using ComponentFactory.Krypton.Toolkit;
using KryptonBackupUtility.Classes;
using System;
using System.Runtime.CompilerServices;

namespace KryptonBackupUtility.UX
{
    public class FileCopy : KryptonForm
    {
        #region Designer Code
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel tslStatusLeft;
        private KryptonPanel kryptonPanel2;
        private ExtendedStandardControls.KryptonLabelExtended klblSourceDirectory;
        private ExtendedStandardControls.KryptonButtonExtended kbtnBrowseToTargetDirectory;
        private ExtendedStandardControls.KryptonButtonExtended kbtnBrowseToSourceDirectory;
        private ExtendedStandardControls.KryptonLabelExtended klblTargetDirectory;
        private KryptonGroupBox kryptonGroupBox1;
        private KryptonRadioButton krbRootAndSubdirectories;
        private KryptonRadioButton krbRootOnly;
        private KryptonGroupBox kryptonGroupBox2;
        private System.Windows.Forms.ProgressBar pbProgress;
        private ExtendedStandardControls.KryptonLabelExtended klblCurrentStatus;
        private ExtendedStandardControls.KryptonLabelExtended klblTotalDirectoryCount;
        private ExtendedStandardControls.KryptonLabelExtended klblTotalFileCount;
        private ExtendedStandardControls.KryptonLabelExtended klblOperation;
        private ExtendedStandardControls.KryptonButtonExtended kbtneCancelCopy;
        private ExtendedStandardControls.KryptonButtonExtended kbtneStartCopy;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tslStatusLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.klblCurrentStatus = new ExtendedStandardControls.KryptonLabelExtended();
            this.klblTotalDirectoryCount = new ExtendedStandardControls.KryptonLabelExtended();
            this.klblTotalFileCount = new ExtendedStandardControls.KryptonLabelExtended();
            this.klblOperation = new ExtendedStandardControls.KryptonLabelExtended();
            this.kbtneCancelCopy = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtneStartCopy = new ExtendedStandardControls.KryptonButtonExtended();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.krbRootAndSubdirectories = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbRootOnly = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.klblTargetDirectory = new ExtendedStandardControls.KryptonLabelExtended();
            this.klblSourceDirectory = new ExtendedStandardControls.KryptonLabelExtended();
            this.kbtnBrowseToTargetDirectory = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnBrowseToSourceDirectory = new ExtendedStandardControls.KryptonButtonExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.ss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.ss);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 688);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1012, 22);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatusLeft});
            this.ss.Location = new System.Drawing.Point(0, 0);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(1012, 22);
            this.ss.TabIndex = 0;
            this.ss.Text = "statusStrip1";
            // 
            // tslStatusLeft
            // 
            this.tslStatusLeft.Name = "tslStatusLeft";
            this.tslStatusLeft.Size = new System.Drawing.Size(0, 17);
            this.tslStatusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel2.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel2.Controls.Add(this.klblTargetDirectory);
            this.kryptonPanel2.Controls.Add(this.klblSourceDirectory);
            this.kryptonPanel2.Controls.Add(this.kbtnBrowseToTargetDirectory);
            this.kryptonPanel2.Controls.Add(this.kbtnBrowseToSourceDirectory);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1012, 688);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(12, 339);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.pbProgress);
            this.kryptonGroupBox2.Panel.Controls.Add(this.klblCurrentStatus);
            this.kryptonGroupBox2.Panel.Controls.Add(this.klblTotalDirectoryCount);
            this.kryptonGroupBox2.Panel.Controls.Add(this.klblTotalFileCount);
            this.kryptonGroupBox2.Panel.Controls.Add(this.klblOperation);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kbtneCancelCopy);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kbtneStartCopy);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(988, 337);
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 4;
            this.kryptonGroupBox2.Values.Heading = "Copy Directories and Files";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(12, 272);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(956, 23);
            this.pbProgress.TabIndex = 8;
            this.pbProgress.MouseEnter += new System.EventHandler(this.pbProgress_MouseEnter);
            // 
            // klblCurrentStatus
            // 
            this.klblCurrentStatus.Image = null;
            this.klblCurrentStatus.Location = new System.Drawing.Point(107, 217);
            this.klblCurrentStatus.LongTextTypeface = null;
            this.klblCurrentStatus.Name = "klblCurrentStatus";
            this.klblCurrentStatus.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentStatus.Size = new System.Drawing.Size(154, 26);
            this.klblCurrentStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentStatus.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblCurrentStatus.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblCurrentStatus.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentStatus.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klblCurrentStatus.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klblCurrentStatus.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentStatus.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klblCurrentStatus.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klblCurrentStatus.TabIndex = 7;
            this.klblCurrentStatus.Values.Text = "Current Status: {0}";
            this.klblCurrentStatus.MouseEnter += new System.EventHandler(this.klblCurrentStatus_MouseEnter);
            // 
            // klblTotalDirectoryCount
            // 
            this.klblTotalDirectoryCount.Image = null;
            this.klblTotalDirectoryCount.Location = new System.Drawing.Point(51, 166);
            this.klblTotalDirectoryCount.LongTextTypeface = null;
            this.klblTotalDirectoryCount.Name = "klblTotalDirectoryCount";
            this.klblTotalDirectoryCount.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalDirectoryCount.Size = new System.Drawing.Size(210, 26);
            this.klblTotalDirectoryCount.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalDirectoryCount.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblTotalDirectoryCount.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblTotalDirectoryCount.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalDirectoryCount.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klblTotalDirectoryCount.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klblTotalDirectoryCount.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalDirectoryCount.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klblTotalDirectoryCount.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klblTotalDirectoryCount.TabIndex = 6;
            this.klblTotalDirectoryCount.Values.Text = "Total Directory Count: {0}";
            this.klblTotalDirectoryCount.MouseEnter += new System.EventHandler(this.klblTotalDirectoryCount_MouseEnter);
            // 
            // klblTotalFileCount
            // 
            this.klblTotalFileCount.Image = null;
            this.klblTotalFileCount.Location = new System.Drawing.Point(96, 118);
            this.klblTotalFileCount.LongTextTypeface = null;
            this.klblTotalFileCount.Name = "klblTotalFileCount";
            this.klblTotalFileCount.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFileCount.Size = new System.Drawing.Size(165, 26);
            this.klblTotalFileCount.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFileCount.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblTotalFileCount.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblTotalFileCount.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFileCount.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klblTotalFileCount.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klblTotalFileCount.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFileCount.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klblTotalFileCount.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klblTotalFileCount.TabIndex = 5;
            this.klblTotalFileCount.Values.Text = "Total File Count: {0}";
            this.klblTotalFileCount.MouseEnter += new System.EventHandler(this.klblTotalFileCount_MouseEnter);
            // 
            // klblOperation
            // 
            this.klblOperation.Image = null;
            this.klblOperation.Location = new System.Drawing.Point(140, 67);
            this.klblOperation.LongTextTypeface = null;
            this.klblOperation.Name = "klblOperation";
            this.klblOperation.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblOperation.Size = new System.Drawing.Size(121, 26);
            this.klblOperation.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblOperation.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblOperation.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblOperation.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblOperation.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klblOperation.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klblOperation.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblOperation.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klblOperation.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klblOperation.TabIndex = 4;
            this.klblOperation.Values.Text = "Operation: {0}";
            this.klblOperation.MouseEnter += new System.EventHandler(this.klblOperation_MouseEnter);
            // 
            // kbtneCancelCopy
            // 
            this.kbtneCancelCopy.AutoSize = true;
            this.kbtneCancelCopy.Image = null;
            this.kbtneCancelCopy.Location = new System.Drawing.Point(739, 21);
            this.kbtneCancelCopy.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancelCopy.Name = "kbtneCancelCopy";
            this.kbtneCancelCopy.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancelCopy.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancelCopy.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancelCopy.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancelCopy.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancelCopy.Size = new System.Drawing.Size(125, 30);
            this.kbtneCancelCopy.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancelCopy.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancelCopy.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancelCopy.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancelCopy.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancelCopy.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancelCopy.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancelCopy.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancelCopy.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancelCopy.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancelCopy.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancelCopy.TabIndex = 2;
            this.kbtneCancelCopy.Values.Text = "&Cancel Copying";
            this.kbtneCancelCopy.Click += new System.EventHandler(this.kbtneCancelCopy_Click);
            this.kbtneCancelCopy.MouseEnter += new System.EventHandler(this.kbtneCancelCopy_MouseEnter);
            // 
            // kbtneStartCopy
            // 
            this.kbtneStartCopy.AutoSize = true;
            this.kbtneStartCopy.Image = null;
            this.kbtneStartCopy.Location = new System.Drawing.Point(96, 21);
            this.kbtneStartCopy.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneStartCopy.Name = "kbtneStartCopy";
            this.kbtneStartCopy.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneStartCopy.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneStartCopy.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneStartCopy.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneStartCopy.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneStartCopy.Size = new System.Drawing.Size(125, 30);
            this.kbtneStartCopy.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneStartCopy.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneStartCopy.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneStartCopy.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneStartCopy.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneStartCopy.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneStartCopy.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneStartCopy.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneStartCopy.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneStartCopy.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneStartCopy.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneStartCopy.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneStartCopy.TabIndex = 1;
            this.kbtneStartCopy.Values.Text = "&Start Copying";
            this.kbtneStartCopy.Click += new System.EventHandler(this.kbtneStartCopy_Click);
            this.kbtneStartCopy.MouseEnter += new System.EventHandler(this.kbtneStartCopy_MouseEnter);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(65, 172);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.krbRootAndSubdirectories);
            this.kryptonGroupBox1.Panel.Controls.Add(this.krbRootOnly);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(866, 135);
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 2;
            this.kryptonGroupBox1.Values.Heading = "Select What to Copy";
            // 
            // krbRootAndSubdirectories
            // 
            this.krbRootAndSubdirectories.Location = new System.Drawing.Point(12, 59);
            this.krbRootAndSubdirectories.Name = "krbRootAndSubdirectories";
            this.krbRootAndSubdirectories.Size = new System.Drawing.Size(431, 26);
            this.krbRootAndSubdirectories.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbRootAndSubdirectories.TabIndex = 3;
            this.krbRootAndSubdirectories.Values.Text = "Only Copy files from Root Directory && All &Subdirectories";
            this.krbRootAndSubdirectories.MouseEnter += new System.EventHandler(this.krbRootAndSubdirectories_MouseEnter);
            // 
            // krbRootOnly
            // 
            this.krbRootOnly.Location = new System.Drawing.Point(12, 13);
            this.krbRootOnly.Name = "krbRootOnly";
            this.krbRootOnly.Size = new System.Drawing.Size(282, 26);
            this.krbRootOnly.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbRootOnly.TabIndex = 2;
            this.krbRootOnly.Values.Text = "Only Copy files from &Root Directory";
            this.krbRootOnly.MouseEnter += new System.EventHandler(this.krbRootOnly_MouseEnter);
            // 
            // klblTargetDirectory
            // 
            this.klblTargetDirectory.Image = null;
            this.klblTargetDirectory.Location = new System.Drawing.Point(65, 122);
            this.klblTargetDirectory.LongTextTypeface = null;
            this.klblTargetDirectory.Name = "klblTargetDirectory";
            this.klblTargetDirectory.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTargetDirectory.Size = new System.Drawing.Size(170, 26);
            this.klblTargetDirectory.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTargetDirectory.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblTargetDirectory.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblTargetDirectory.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTargetDirectory.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klblTargetDirectory.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klblTargetDirectory.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTargetDirectory.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klblTargetDirectory.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klblTargetDirectory.TabIndex = 3;
            this.klblTargetDirectory.Values.Text = "Target Directory: {0}";
            this.klblTargetDirectory.MouseEnter += new System.EventHandler(this.klblTargetDirectory_MouseEnter);
            // 
            // klblSourceDirectory
            // 
            this.klblSourceDirectory.Image = null;
            this.klblSourceDirectory.Location = new System.Drawing.Point(65, 71);
            this.klblSourceDirectory.LongTextTypeface = null;
            this.klblSourceDirectory.Name = "klblSourceDirectory";
            this.klblSourceDirectory.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSourceDirectory.Size = new System.Drawing.Size(172, 26);
            this.klblSourceDirectory.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSourceDirectory.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblSourceDirectory.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblSourceDirectory.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSourceDirectory.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klblSourceDirectory.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klblSourceDirectory.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSourceDirectory.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klblSourceDirectory.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klblSourceDirectory.TabIndex = 2;
            this.klblSourceDirectory.Values.Text = "Source Directory: {0}";
            this.klblSourceDirectory.MouseEnter += new System.EventHandler(this.klblSourceDirectory_MouseEnter);
            // 
            // kbtnBrowseToTargetDirectory
            // 
            this.kbtnBrowseToTargetDirectory.AutoSize = true;
            this.kbtnBrowseToTargetDirectory.Image = null;
            this.kbtnBrowseToTargetDirectory.Location = new System.Drawing.Point(712, 12);
            this.kbtnBrowseToTargetDirectory.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToTargetDirectory.Name = "kbtnBrowseToTargetDirectory";
            this.kbtnBrowseToTargetDirectory.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToTargetDirectory.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToTargetDirectory.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToTargetDirectory.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToTargetDirectory.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToTargetDirectory.Size = new System.Drawing.Size(219, 30);
            this.kbtnBrowseToTargetDirectory.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToTargetDirectory.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToTargetDirectory.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToTargetDirectory.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToTargetDirectory.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToTargetDirectory.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToTargetDirectory.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToTargetDirectory.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToTargetDirectory.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToTargetDirectory.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToTargetDirectory.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToTargetDirectory.TabIndex = 1;
            this.kbtnBrowseToTargetDirectory.Values.Text = "Browse to &Target Directory";
            this.kbtnBrowseToTargetDirectory.Click += new System.EventHandler(this.kbtnBrowseToTargetDirectory_Click);
            this.kbtnBrowseToTargetDirectory.MouseEnter += new System.EventHandler(this.kbtnBrowseToTargetDirectory_MouseEnter);
            // 
            // kbtnBrowseToSourceDirectory
            // 
            this.kbtnBrowseToSourceDirectory.AutoSize = true;
            this.kbtnBrowseToSourceDirectory.Image = null;
            this.kbtnBrowseToSourceDirectory.Location = new System.Drawing.Point(65, 12);
            this.kbtnBrowseToSourceDirectory.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToSourceDirectory.Name = "kbtnBrowseToSourceDirectory";
            this.kbtnBrowseToSourceDirectory.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToSourceDirectory.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToSourceDirectory.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToSourceDirectory.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToSourceDirectory.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToSourceDirectory.Size = new System.Drawing.Size(219, 30);
            this.kbtnBrowseToSourceDirectory.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToSourceDirectory.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToSourceDirectory.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToSourceDirectory.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToSourceDirectory.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToSourceDirectory.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToSourceDirectory.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToSourceDirectory.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToSourceDirectory.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseToSourceDirectory.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseToSourceDirectory.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseToSourceDirectory.TabIndex = 0;
            this.kbtnBrowseToSourceDirectory.Values.Text = "&Browse to Source Directory";
            this.kbtnBrowseToSourceDirectory.Click += new System.EventHandler(this.kbtnBrowseToSourceDirectory_Click);
            this.kbtnBrowseToSourceDirectory.MouseEnter += new System.EventHandler(this.kbtnBrowseToSourceDirectory_MouseEnter);
            // 
            // FileCopy
            // 
            this.ClientSize = new System.Drawing.Size(1012, 710);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FileCopy";
            this.Load += new System.EventHandler(this.FileCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private Copy _copier;

        private string _sourceDirectory, _targetDirectory;
        #endregion

        #region Properties
        public Copy Copier
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get => _copier;


            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {

            }
        }
        #endregion

        public FileCopy()
        {
            InitializeComponent();
        }

        private void FileCopy_Load(object sender, EventArgs e)
        {

        }

        private void kbtnBrowseToSourceDirectory_Click(object sender, EventArgs e)
        {

        }

        private void kbtnBrowseToTargetDirectory_Click(object sender, EventArgs e)
        {

        }

        private void kbtnBrowseToSourceDirectory_MouseEnter(object sender, EventArgs e)
        {

        }

        private void kbtnBrowseToTargetDirectory_MouseEnter(object sender, EventArgs e)
        {

        }

        private void klblSourceDirectory_MouseEnter(object sender, EventArgs e)
        {

        }

        private void klblTargetDirectory_MouseEnter(object sender, EventArgs e)
        {

        }

        private void krbRootOnly_MouseEnter(object sender, EventArgs e)
        {

        }

        private void krbRootAndSubdirectories_MouseEnter(object sender, EventArgs e)
        {

        }

        private void kbtneStartCopy_Click(object sender, EventArgs e)
        {

        }

        private void kbtneStartCopy_MouseEnter(object sender, EventArgs e)
        {

        }

        private void kbtneCancelCopy_Click(object sender, EventArgs e)
        {

        }

        private void kbtneCancelCopy_MouseEnter(object sender, EventArgs e)
        {

        }

        private void klblOperation_MouseEnter(object sender, EventArgs e)
        {

        }

        private void klblTotalFileCount_MouseEnter(object sender, EventArgs e)
        {

        }

        private void klblTotalDirectoryCount_MouseEnter(object sender, EventArgs e)
        {

        }

        private void klblCurrentStatus_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbProgress_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}