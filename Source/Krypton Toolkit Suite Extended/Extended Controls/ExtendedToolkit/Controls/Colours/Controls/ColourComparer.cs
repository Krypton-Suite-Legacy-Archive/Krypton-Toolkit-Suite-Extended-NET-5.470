using ExtendedControls.Base.Code.Colours;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Colours.Controls
{
    public class ColourComparer : UserControl
    {
        #region Designer Code
        private Panel pnlPrimaryColour;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblPrimaryColourHexValue;
        private Panel pnlSecondaryColour;
        private TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSecondaryColourHexValue;

        private void InitializeComponent()
        {
            this.pnlPrimaryColour = new System.Windows.Forms.Panel();
            this.klblPrimaryColourHexValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlSecondaryColour = new System.Windows.Forms.Panel();
            this.klblSecondaryColourHexValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPrimaryColour.SuspendLayout();
            this.pnlSecondaryColour.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrimaryColour
            // 
            this.pnlPrimaryColour.BackColor = System.Drawing.Color.White;
            this.pnlPrimaryColour.Controls.Add(this.klblPrimaryColourHexValue);
            this.pnlPrimaryColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrimaryColour.Location = new System.Drawing.Point(3, 3);
            this.pnlPrimaryColour.Name = "pnlPrimaryColour";
            this.pnlPrimaryColour.Size = new System.Drawing.Size(140, 67);
            this.pnlPrimaryColour.TabIndex = 0;
            this.pnlPrimaryColour.BackColorChanged += new System.EventHandler(this.pnlPrimaryColour_BackColorChanged);
            // 
            // klblPrimaryColourHexValue
            // 
            this.klblPrimaryColourHexValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.klblPrimaryColourHexValue.Location = new System.Drawing.Point(3, 44);
            this.klblPrimaryColourHexValue.Name = "klblPrimaryColourHexValue";
            this.klblPrimaryColourHexValue.Size = new System.Drawing.Size(32, 20);
            this.klblPrimaryColourHexValue.TabIndex = 0;
            this.klblPrimaryColourHexValue.Values.Text = "#{0}";
            // 
            // pnlSecondaryColour
            // 
            this.pnlSecondaryColour.BackColor = System.Drawing.Color.Silver;
            this.pnlSecondaryColour.Controls.Add(this.klblSecondaryColourHexValue);
            this.pnlSecondaryColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSecondaryColour.Location = new System.Drawing.Point(3, 76);
            this.pnlSecondaryColour.Name = "pnlSecondaryColour";
            this.pnlSecondaryColour.Size = new System.Drawing.Size(140, 67);
            this.pnlSecondaryColour.TabIndex = 1;
            this.pnlSecondaryColour.BackColorChanged += new System.EventHandler(this.pnlSecondaryColour_BackColorChanged);
            // 
            // klblSecondaryColourHexValue
            // 
            this.klblSecondaryColourHexValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.klblSecondaryColourHexValue.Location = new System.Drawing.Point(3, 44);
            this.klblSecondaryColourHexValue.Name = "klblSecondaryColourHexValue";
            this.klblSecondaryColourHexValue.Size = new System.Drawing.Size(32, 20);
            this.klblSecondaryColourHexValue.TabIndex = 1;
            this.klblSecondaryColourHexValue.Values.Text = "#{0}";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlSecondaryColour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPrimaryColour, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(146, 146);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ColourComparer
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ColourComparer";
            this.Size = new System.Drawing.Size(146, 146);
            this.Resize += new System.EventHandler(this.ColourComparer_Resize);
            this.pnlPrimaryColour.ResumeLayout(false);
            this.pnlPrimaryColour.PerformLayout();
            this.pnlSecondaryColour.ResumeLayout(false);
            this.pnlSecondaryColour.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool _showHexadecimalValues;
        private Color _primaryColourValue, _secondaryColourValue;
        private Timer _updateValues = new Timer();
        #endregion

        #region Properties
        public bool ShowHexadecimalValues { get => _showHexadecimalValues; set { _showHexadecimalValues = value; Invalidate(); } }

        public Color PrimaryColour { get => _primaryColourValue; set { _primaryColourValue = value; Invalidate(); } }

        public Color SecondaryColour { get => _secondaryColourValue; set { _secondaryColourValue = value; Invalidate(); } }
        #endregion

        #region Constructor
        public ColourComparer()
        {
            InitializeComponent();

            ShowHexadecimalValues = false;

            PrimaryColour = Color.White;

            SecondaryColour = Color.Silver;

            pnlPrimaryColour.Size = new Size(Width, Height / 2);

            pnlSecondaryColour.Size = new Size(Height, Width / 2);

            _updateValues.Interval = 250;

            _updateValues.Enabled = true;

            _updateValues.Tick += UpdateValues_Tick;
        }
        #endregion

        private void UpdateValues_Tick(object sender, EventArgs e)
        {
            pnlPrimaryColour.BackColor = PrimaryColour;

            pnlSecondaryColour.BackColor = SecondaryColour;

            klblPrimaryColourHexValue.Visible = ShowHexadecimalValues;

            klblSecondaryColourHexValue.Visible = ShowHexadecimalValues;

            if (ShowHexadecimalValues)
            {
                klblPrimaryColourHexValue.Text = ColorTranslator.ToHtml(pnlPrimaryColour.BackColor);

                klblSecondaryColourHexValue.Text = ColorTranslator.ToHtml(pnlSecondaryColour.BackColor);
            }
            else
            {
                klblPrimaryColourHexValue.Text = "";

                klblSecondaryColourHexValue.Text = "";
            }
        }

        private void ColourComparer_Resize(object sender, EventArgs e)
        {
            pnlPrimaryColour.Size = new Size(Width, Height / 2);

            pnlSecondaryColour.Size = new Size(Height, Width / 2);
        }

        private void pnlPrimaryColour_BackColorChanged(object sender, EventArgs e)
        {
            klblPrimaryColourHexValue.StateCommon.ShortText.Color1 = ColourExtensions.GetContrast(pnlPrimaryColour.BackColor);

            klblPrimaryColourHexValue.StateCommon.LongText.Color1 = ColourExtensions.GetContrast(pnlPrimaryColour.BackColor);
        }

        private void pnlSecondaryColour_BackColorChanged(object sender, EventArgs e)
        {
            klblSecondaryColourHexValue.StateCommon.ShortText.Color1 = ColourExtensions.GetContrast(pnlSecondaryColour.BackColor);
        }
    }
}