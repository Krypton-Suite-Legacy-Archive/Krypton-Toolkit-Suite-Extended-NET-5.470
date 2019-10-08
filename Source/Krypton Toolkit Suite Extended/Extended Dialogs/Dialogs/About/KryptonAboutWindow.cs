#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion


using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Reflection;

namespace ExtendedDialogs.Dialogs.About
{
    public class KryptonAboutWindow : KryptonForm
    {
        #region Designer Code
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private KryptonLabel klblProductName;
        private KryptonLabel klblVersion;
        private KryptonLabel klblCopyright;
        private KryptonLabel klblCompanyName;
        private KryptonRichTextBox krtbDescription;
        private KryptonButton kbtnOk;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonAboutWindow));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.klblProductName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblCopyright = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.krtbDescription = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(587, 416);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel1.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.klblProductName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.klblVersion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.klblCopyright, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.klblCompanyName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.krtbDescription, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.kbtnOk, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 392);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(179, 386);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 13;
            this.logoPictureBox.TabStop = false;
            // 
            // klblProductName
            // 
            this.klblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblProductName.Location = new System.Drawing.Point(188, 3);
            this.klblProductName.Name = "klblProductName";
            this.klblProductName.Size = new System.Drawing.Size(372, 43);
            this.klblProductName.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblProductName.TabIndex = 14;
            this.klblProductName.Values.Text = "{PRODUCT-NAME}";
            // 
            // klblVersion
            // 
            this.klblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblVersion.Location = new System.Drawing.Point(188, 52);
            this.klblVersion.Name = "klblVersion";
            this.klblVersion.Size = new System.Drawing.Size(372, 43);
            this.klblVersion.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblVersion.TabIndex = 15;
            this.klblVersion.Values.Text = "{VERSION}";
            // 
            // klblCopyright
            // 
            this.klblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblCopyright.Location = new System.Drawing.Point(188, 101);
            this.klblCopyright.Name = "klblCopyright";
            this.klblCopyright.Size = new System.Drawing.Size(372, 43);
            this.klblCopyright.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCopyright.TabIndex = 16;
            this.klblCopyright.Values.Text = "{COPYRIGHT}";
            // 
            // klblCompanyName
            // 
            this.klblCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblCompanyName.Location = new System.Drawing.Point(188, 150);
            this.klblCompanyName.Name = "klblCompanyName";
            this.klblCompanyName.Size = new System.Drawing.Size(372, 43);
            this.klblCompanyName.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCompanyName.TabIndex = 17;
            this.klblCompanyName.Values.Text = "{COMPANY-NAME}";
            // 
            // krtbDescription
            // 
            this.krtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.krtbDescription.Location = new System.Drawing.Point(188, 199);
            this.krtbDescription.Name = "krtbDescription";
            this.krtbDescription.ReadOnly = true;
            this.krtbDescription.Size = new System.Drawing.Size(372, 141);
            this.krtbDescription.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krtbDescription.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.krtbDescription.TabIndex = 18;
            this.krtbDescription.Text = "{DESCRIPTION}";
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.Location = new System.Drawing.Point(470, 364);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(90, 25);
            this.kbtnOk.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 21;
            this.kbtnOk.Values.Text = "&Ok";
            // 
            // KryptonAboutWindow
            // 
            this.ClientSize = new System.Drawing.Size(587, 416);
            this.Controls.Add(this.kryptonPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonAboutWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About {0}";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        #region Variables
        private Image _applicationLogo;
        #endregion

        #region Properties
        public Image ApplicationLogo { get => _applicationLogo; set => _applicationLogo = value; }
        #endregion

        #region Constructors
        public KryptonAboutWindow()
        {
            InitializeComponent();

            Text = $"About { AssemblyTitle }";

            klblProductName.Text = ProductName;

            klblVersion.Text = $"Version: { AssemblyVersion }";

            klblCopyright.Text = AssemblyCopyright;

            klblCompanyName.Text = AssemblyCompany;

            krtbDescription.Text = AssemblyDescription;

            if (ApplicationLogo != null)
            {
                logoPictureBox.Image = ApplicationLogo;
            }
        }
        #endregion
    }
}