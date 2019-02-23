using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Models.Typeface;
using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.SystemDialogs.Typeface
{
    public class TypefaceSelector : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBold;
        private System.Windows.Forms.ToolStripButton tsbItalic;
        private System.Windows.Forms.ToolStripButton tsbUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox tscmbTextSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbStrikethrough;
        private KryptonPanel kryptonPanel3;
        private KryptonTextBox ktxtSampleText;
        private KryptonListBox klstTypefaces;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnAccept;
        private Controls.KryptonPromptTextBox kryptonPromptTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnAccept = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBold = new System.Windows.Forms.ToolStripButton();
            this.tsbItalic = new System.Windows.Forms.ToolStripButton();
            this.tsbUnderline = new System.Windows.Forms.ToolStripButton();
            this.tsbStrikethrough = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tscmbTextSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPromptTextBox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.ktxtSampleText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.klstTypefaces = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnAccept);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Controls.Add(this.statusStrip1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 742);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1115, 77);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnAccept
            // 
            this.kbtnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnAccept.Location = new System.Drawing.Point(863, 16);
            this.kbtnAccept.Name = "kbtnAccept";
            this.kbtnAccept.Size = new System.Drawing.Size(144, 26);
            this.kbtnAccept.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnAccept.TabIndex = 6;
            this.kbtnAccept.Values.Text = "&Use Typeface";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(1013, 16);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 26);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 5;
            this.kbtnCancel.Values.Text = "C&ancel";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 55);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1115, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(1069, 17);
            this.tslStatus.Spring = true;
            this.tslStatus.Text = "Ready";
            this.tslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.toolStrip1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1115, 25);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImport,
            this.tsbExport,
            this.toolStripSeparator1,
            this.tsbBold,
            this.tsbItalic,
            this.tsbUnderline,
            this.tsbStrikethrough,
            this.toolStripSeparator2,
            this.tscmbTextSize,
            this.toolStripSeparator3,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(234, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbImport
            // 
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImport.Image = global::ExtendedControls.Properties.Resources.Open_File_16_x_16;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(23, 22);
            this.tsbImport.Text = "toolStripButton1";
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Image = global::ExtendedControls.Properties.Resources.Export_To_Document;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(23, 22);
            this.tsbExport.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBold
            // 
            this.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBold.Image = global::ExtendedControls.Properties.Resources.text_bold;
            this.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBold.Name = "tsbBold";
            this.tsbBold.Size = new System.Drawing.Size(23, 22);
            this.tsbBold.Text = "toolStripButton3";
            // 
            // tsbItalic
            // 
            this.tsbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbItalic.Image = global::ExtendedControls.Properties.Resources.text_italic;
            this.tsbItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbItalic.Name = "tsbItalic";
            this.tsbItalic.Size = new System.Drawing.Size(23, 22);
            this.tsbItalic.Text = "toolStripButton4";
            // 
            // tsbUnderline
            // 
            this.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnderline.Image = global::ExtendedControls.Properties.Resources.text_underline;
            this.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnderline.Name = "tsbUnderline";
            this.tsbUnderline.Size = new System.Drawing.Size(23, 22);
            this.tsbUnderline.Text = "toolStripButton5";
            // 
            // tsbStrikethrough
            // 
            this.tsbStrikethrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStrikethrough.Image = global::ExtendedControls.Properties.Resources.text_strikethrough;
            this.tsbStrikethrough.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStrikethrough.Name = "tsbStrikethrough";
            this.tsbStrikethrough.Size = new System.Drawing.Size(23, 22);
            this.tsbStrikethrough.Text = "toolStripButton6";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tscmbTextSize
            // 
            this.tscmbTextSize.AutoSize = false;
            this.tscmbTextSize.Name = "tscmbTextSize";
            this.tscmbTextSize.Size = new System.Drawing.Size(50, 23);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::ExtendedControls.Properties.Resources.text_lowercase;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonPromptTextBox1);
            this.kryptonPanel3.Controls.Add(this.ktxtSampleText);
            this.kryptonPanel3.Controls.Add(this.klstTypefaces);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 25);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1115, 717);
            this.kryptonPanel3.TabIndex = 0;
            // 
            // kryptonPromptTextBox1
            // 
            this.kryptonPromptTextBox1.DrawPrompt = true;
            this.kryptonPromptTextBox1.FocusSelect = true;
            this.kryptonPromptTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPromptTextBox1.Location = new System.Drawing.Point(12, 6);
            this.kryptonPromptTextBox1.Name = "kryptonPromptTextBox1";
            this.kryptonPromptTextBox1.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kryptonPromptTextBox1.PromptText = "Filter typefaces";
            this.kryptonPromptTextBox1.PromptTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPromptTextBox1.Size = new System.Drawing.Size(333, 29);
            this.kryptonPromptTextBox1.TabIndex = 2;
            // 
            // ktxtSampleText
            // 
            this.ktxtSampleText.Location = new System.Drawing.Point(351, 6);
            this.ktxtSampleText.Multiline = true;
            this.ktxtSampleText.Name = "ktxtSampleText";
            this.ktxtSampleText.ReadOnly = true;
            this.ktxtSampleText.Size = new System.Drawing.Size(752, 702);
            this.ktxtSampleText.TabIndex = 1;
            this.ktxtSampleText.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ\r\nabcdefghijklmnopqrstuvwxyz\r\n1234567890\r\n\r\n/\\|!?%$&()[" +
    "]{}<>+-~=*@;:,._\r\n\r\nLorem ipsum dolor sit amet";
            // 
            // klstTypefaces
            // 
            this.klstTypefaces.Location = new System.Drawing.Point(12, 41);
            this.klstTypefaces.Name = "klstTypefaces";
            this.klstTypefaces.Size = new System.Drawing.Size(333, 667);
            this.klstTypefaces.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 739);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 3);
            this.panel1.TabIndex = 2;
            // 
            // TypefaceSelector
            // 
            this.AcceptButton = this.kbtnAccept;
            this.ClientSize = new System.Drawing.Size(1115, 819);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TypefaceSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Typeface";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private ArrayList _sizes;
        private Font _oldTypeface, _newTypeface;
        private TypefaceCollection _typefaces;
        private TypefaceLister _lister;
        private TypefaceProperties _properties;
        private SaveFileDialog _sfd;
        private string _currentTypefaceDirectory;
        #endregion

        #region Constructors
        public TypefaceSelector() //: this(null)
        {
            InitializeComponent();
        }

        public TypefaceSelector(Font currentTypeface)
        {
            InitializeComponent();

            _oldTypeface = currentTypeface;

            FillUIElements(currentTypeface);
        }

        public TypefaceSelector(string directory)
        {
            InitializeComponent();

            _typefaces = new TypefaceCollection();

            _sfd = new SaveFileDialog();

            _sfd.Title = "Save Image";

            _sfd.Filter = "Portable Network Graphics (*.png)|*.png";

            _sfd.FileName = "Typeface Preview.png";

            _sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (string.IsNullOrEmpty(directory) || !Directory.Exists(directory))
            {
                _currentTypefaceDirectory = Path.Combine(Environment.GetEnvironmentVariable("windir"), "Fonts");
            }
            else
            {
                _currentTypefaceDirectory = directory;
            }

            _lister = new TypefaceLister();

            _lister.LoadTypefacesFromDirectoryCompleted += new EventHandler<TypefaceListerEventArgs>(delegate (object sender, TypefaceListerEventArgs e)
            {
                Status = $"{ e.Collection.Count } typefaces loaded.";

                _typefaces = e.Collection;

                if (_typefaces != null && _typefaces.Count > 0)
                {
                    klstTypefaces.Enabled = true;

                    klstTypefaces.SelectedIndex = 0;

                    RefreshTypefaceList();

                    foreach (TypefaceModel item in klstTypefaces.Items)
                    {
                        if (item.TypefaceName == "Segoe UI")
                        {
                            klstTypefaces.SelectedItem = item;

                            break;
                        }
                    }
                }
                else
                {
                    klstTypefaces.DataSource = null;

                    klstTypefaces.Items.Clear();

                    klstTypefaces.Items.Add("No installed typefaces found in selected directory.");

                    klstTypefaces.SelectedItem = null;

                    klstTypefaces.Enabled = false;

                    Status = $"No installed typefaces found in selected directory: { _currentTypefaceDirectory }";
                }
            });

            _lister.LoadTypefaceFromDirectoryAsync(_currentTypefaceDirectory);

            //SetLoadingState();
        }
        #endregion

        #region Properties
        public string Status { get => tslStatus.Text; set => tslStatus.Text = value; }

        public TypefaceModel SelectedTypeface { get => klstTypefaces.SelectedItem as TypefaceModel; }

        public float TypefaceSize
        {
            get
            {
                float result = 24;

                string raw = tscmbTextSize.Text;

                if (string.IsNullOrEmpty(raw))
                {
                    tscmbTextSize.Text = "24pt";

                    result = 24;
                }
                else
                {
                    float tmp = 0;

                    Match match = Regex.Match(raw, @"([\d\.,]+)", RegexOptions.IgnoreCase);

                    if (match.Success && float.TryParse(match.Groups[1].Value, NumberStyles.Float, CultureInfo.InvariantCulture, out tmp))
                    {
                        result = tmp;
                    }
                }

                return result;
            }

            set
            {
                string size = value.ToString("N0"), unit = null;

                switch (TypefaceSizeUnits)
                {
                    case GraphicsUnit.Pixel:
                        unit = "px";
                        break;
                    case GraphicsUnit.Point:
                        unit = "pt";
                        break;
                    case GraphicsUnit.Inch:
                        unit = "in";
                        break;
                    case GraphicsUnit.Millimeter:
                        unit = "mm";
                        break;
                }

                tscmbTextSize.Text = size + (unit != null ? " " + unit : null);
            }
        }

        public GraphicsUnit TypefaceSizeUnits
        {
            get
            {
                string raw = tscmbTextSize.Text;

                if (string.IsNullOrEmpty(raw))
                {
                    tscmbTextSize.Text = "24pt";

                    return GraphicsUnit.Point;
                }
                else
                {
                    Match match = Regex.Match(raw, @"([\d\.,]+)\s*(pt|px|mm|in)", RegexOptions.IgnoreCase);

                    if (match.Success && match.Groups.Count == 3)
                    {
                        switch (match.Groups[2].Value.ToLower())
                        {
                            case "pt":
                                return GraphicsUnit.Point;

                            default:
                            case "px":
                                return GraphicsUnit.Pixel;

                            case "mm":
                                return GraphicsUnit.Millimeter;

                            case "in":
                                return GraphicsUnit.Inch;
                        }
                    }
                }

                return GraphicsUnit.Point;
            }
        }
        #endregion

        #region Methods
        private void FillUIElements(Font currentTypeface)
        {
            ktxtSampleText.Font = currentTypeface;

            klstTypefaces.GetItemText(currentTypeface.FontFamily.Name);
        }

        private void PropagateTypefaceSizes()
        {
            _sizes = new ArrayList(16);

            _sizes.Add("8");

            _sizes.Add("9");

            _sizes.Add("10");

            _sizes.Add("11");

            _sizes.Add("12");

            _sizes.Add("14");

            _sizes.Add("16");

            _sizes.Add("18");

            _sizes.Add("20");

            _sizes.Add("22");

            _sizes.Add("24");

            _sizes.Add("26");

            _sizes.Add("28");

            _sizes.Add("36");

            _sizes.Add("48");

            _sizes.Add("72");

            foreach (string size in _sizes)
            {
                tscmbTextSize.Items.Add(size);
            }
        }

        private void UpdateUI(Font typeface)
        {

        }

        protected void RefreshTypefaceList()
        {
            klstTypefaces.DataSource = null;

            klstTypefaces.DataSource = _typefaces;

            if (klstTypefaces.Items.Count > 0)
            {
                klstTypefaces.SelectedIndex = 0;
            }
        }

        protected void RefreshTypefacePreview()
        {
            Font typeface = GetTypeface();

            if (typeface != null)
            {
                ktxtSampleText.ForeColor = SystemColors.WindowText;

                ktxtSampleText.Font = typeface;

                Status = SelectedTypeface.TypefaceFilePath;
            }
            else
            {
                ktxtSampleText.ForeColor = Color.Red;

                ktxtSampleText.Font = new Font(new FontFamily("Arial"), TypefaceSize, TypefaceSizeUnits);

                Status = "This font style is not available.";
            }

            if (_properties != null)
            {
                //_properties.LoadTypeface(typeface, SelectedTypeface);
            }
        }

        protected Font GetTypeface()
        {
            TypefaceModel model = SelectedTypeface;

            FontStyle style = FontStyle.Regular;

            if (tsbBold.Checked) style |= FontStyle.Bold;

            if (tsbItalic.Checked) style |= FontStyle.Italic;

            if (tsbUnderline.Checked) style |= FontStyle.Underline;

            if (tsbStrikethrough.Checked) style |= FontStyle.Strikeout;

            try
            {
                Font typeface = new Font(model.Typeface, TypefaceSize, style, TypefaceSizeUnits);

                return typeface;
            }
            catch
            {
                try
                {
                    Font typeface = new Font(model.Typeface, TypefaceSize, TypefaceSizeUnits);

                    return typeface;
                }
                catch
                {
                    try
                    {
                        Font typeface = new Font(model.Typeface, 24, GraphicsUnit.Pixel);

                        return typeface;
                    }
                    catch
                    {
                    }
                }
            }

            return null;
        }
        #endregion
    }
}