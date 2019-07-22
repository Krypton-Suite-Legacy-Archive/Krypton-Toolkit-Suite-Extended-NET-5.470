using System;
using System.ComponentModel;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;

namespace ExtendedColourControls
{
    [DefaultEvent("PreviewColorChanged"), DefaultProperty("Color")]
    public class ColourPickerDialog : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kpnlMain;
        private Cyotek.Windows.Forms.ColorGrid cgColourPalette;
        private ColourEditorManager cem;
        private KryptonButton kbtnOk;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cbColourPreview;
        private KryptonButton kbtnCancel;
        private Cyotek.Windows.Forms.ColorEditor ceEditor;
        private ColourEditor ceColour;
        private ColourWheel cwColourPicker;

        private void InitializeComponent()
        {
            this.kpnlMain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ceEditor = new Cyotek.Windows.Forms.ColorEditor();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbColourPreview = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.cgColourPalette = new Cyotek.Windows.Forms.ColorGrid();
            this.cwColourPicker = new ExtendedColourControls.ColourWheel();
            this.cem = new ExtendedColourControls.ColourEditorManager();
            this.ceColour = new ExtendedColourControls.ColourEditor();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlMain)).BeginInit();
            this.kpnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbColourPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlMain
            // 
            this.kpnlMain.Controls.Add(this.ceColour);
            this.kpnlMain.Controls.Add(this.ceEditor);
            this.kpnlMain.Controls.Add(this.kbtnCancel);
            this.kpnlMain.Controls.Add(this.kbtnOk);
            this.kpnlMain.Controls.Add(this.cbColourPreview);
            this.kpnlMain.Controls.Add(this.cwColourPicker);
            this.kpnlMain.Controls.Add(this.cgColourPalette);
            this.kpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlMain.Location = new System.Drawing.Point(0, 0);
            this.kpnlMain.Name = "kpnlMain";
            this.kpnlMain.Size = new System.Drawing.Size(643, 483);
            this.kpnlMain.TabIndex = 0;
            // 
            // ceEditor
            // 
            this.ceEditor.BackColor = System.Drawing.Color.Transparent;
            this.ceEditor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceEditor.Location = new System.Drawing.Point(249, 20);
            this.ceEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ceEditor.Name = "ceEditor";
            this.ceEditor.Size = new System.Drawing.Size(246, 371);
            this.ceEditor.TabIndex = 1;
            this.ceEditor.Visible = false;
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(501, 64);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(130, 38);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 4;
            this.kbtnCancel.Values.Text = "C&ancel";
            // 
            // kbtnOk
            // 
            this.kbtnOk.Location = new System.Drawing.Point(501, 20);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(130, 38);
            this.kbtnOk.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 3;
            this.kbtnOk.Values.Text = "&Ok";
            // 
            // cbColourPreview
            // 
            this.cbColourPreview.BackColor = System.Drawing.SystemColors.Control;
            this.cbColourPreview.Location = new System.Drawing.Point(501, 341);
            this.cbColourPreview.Name = "cbColourPreview";
            this.cbColourPreview.Size = new System.Drawing.Size(130, 130);
            this.cbColourPreview.TabIndex = 2;
            this.cbColourPreview.TabStop = false;
            // 
            // cgColourPalette
            // 
            this.cgColourPalette.AutoAddColors = false;
            this.cgColourPalette.BackColor = System.Drawing.Color.Transparent;
            this.cgColourPalette.CellSize = new System.Drawing.Size(11, 12);
            this.cgColourPalette.EditMode = Cyotek.Windows.Forms.ColorEditingMode.Both;
            this.cgColourPalette.Location = new System.Drawing.Point(12, 329);
            this.cgColourPalette.Name = "cgColourPalette";
            this.cgColourPalette.SelectedCellStyle = Cyotek.Windows.Forms.ColorGridSelectedCellStyle.Standard;
            this.cgColourPalette.ShowCustomColors = false;
            this.cgColourPalette.Size = new System.Drawing.Size(231, 142);
            this.cgColourPalette.TabIndex = 1;
            // 
            // cwColourPicker
            // 
            this.cwColourPicker.BackColor = System.Drawing.Color.Transparent;
            this.cwColourPicker.Location = new System.Drawing.Point(12, 20);
            this.cwColourPicker.Name = "cwColourPicker";
            this.cwColourPicker.Size = new System.Drawing.Size(231, 212);
            this.cwColourPicker.TabIndex = 1;
            // 
            // cem
            // 
            this.cem.Color = System.Drawing.Color.Empty;
            // 
            // ceColour
            // 
            this.ceColour.BackColor = System.Drawing.Color.Transparent;
            this.ceColour.Location = new System.Drawing.Point(249, 20);
            this.ceColour.Name = "ceColour";
            this.ceColour.Size = new System.Drawing.Size(246, 371);
            this.ceColour.TabIndex = 1;
            // 
            // ColourPickerDialog
            // 
            this.AcceptButton = this.kbtnOk;
            this.CancelButton = this.kbtnCancel;
            this.ClientSize = new System.Drawing.Size(643, 483);
            this.Controls.Add(this.kpnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColourPickerDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Colour Picker";
            this.Load += new System.EventHandler(this.ColourPickerDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlMain)).EndInit();
            this.kpnlMain.ResumeLayout(false);
            this.kpnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbColourPreview)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Constants

        private static readonly object _eventPreviewColourChanged = new object();

        #endregion

        #region Fields

        private Brush _textureBrush;

        #endregion

        #region Events

        //[Category("Property Changed")]
        //public event EventHandler PreviewColourChanged
        //{
        //    //add { this.Events.AddHandler(_eventPreviewColorChanged, value); }
        //    //remove { this.Events.RemoveHandler(_eventPreviewColorChanged, value); }
        //}

        #endregion

        #region Properties

        public Color Colour
        {
            get { return cem.Colour; }
            set { cem.Colour = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowAlphaChannel { get; set; }

        #endregion

        #region Constructors
        public ColourPickerDialog()
        {
            InitializeComponent();

            ShowAlphaChannel = true;

            Font = SystemFonts.DialogFont;
        }
        #endregion

        private void ColourPickerDialog_Load(object sender, EventArgs e)
        {

        }
    }
}