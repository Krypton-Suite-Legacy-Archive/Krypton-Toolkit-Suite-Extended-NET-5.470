using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoHub.UX.Splash
{
    public class MainWindow : KryptonForm
    {
        #region Designer Code
        private System.Windows.Forms.StatusStrip statusStrip1;
        private KryptonPalette kryptonPalette1;
        private System.ComponentModel.IContainer components;
        private KryptonPanel kryptonPanelTop;
        private KryptonLabel labelKryptonExplorer;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private KryptonButton kbtnClose;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage3;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage4;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage5;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage6;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage7;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage8;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanelTop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.labelKryptonExplorer = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage3 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage4 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage5 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage6 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage7 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage8 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelTop)).BeginInit();
            this.kryptonPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage8)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnClose);
            this.kryptonPanel1.Controls.Add(this.statusStrip1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 492);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(717, 65);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnClose
            // 
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.Location = new System.Drawing.Point(615, 8);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(90, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 1;
            this.kbtnClose.Values.Text = "Clos&e";
            this.kbtnClose.Click += new System.EventHandler(this.kbtnClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Location = new System.Drawing.Point(0, 43);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(717, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.CustomisedKryptonPaletteFilePath = null;
            // 
            // kryptonPanelTop
            // 
            this.kryptonPanelTop.Controls.Add(this.labelKryptonExplorer);
            this.kryptonPanelTop.Controls.Add(this.pictureBoxRight);
            this.kryptonPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanelTop.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelTop.Name = "kryptonPanelTop";
            this.kryptonPanelTop.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonPanelTop.Size = new System.Drawing.Size(717, 90);
            this.kryptonPanelTop.TabIndex = 2;
            // 
            // labelKryptonExplorer
            // 
            this.labelKryptonExplorer.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.labelKryptonExplorer.Location = new System.Drawing.Point(17, 54);
            this.labelKryptonExplorer.Name = "labelKryptonExplorer";
            this.labelKryptonExplorer.Size = new System.Drawing.Size(470, 28);
            this.labelKryptonExplorer.StateCommon.ShortText.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKryptonExplorer.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.labelKryptonExplorer.TabIndex = 0;
            this.labelKryptonExplorer.Values.ExtraText = "Built for .Net 4.7";
            this.labelKryptonExplorer.Values.Text = "Krypton Extended Toolkit 5.470";
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxRight.Image = global::DemoHub.Properties.Resources.KR_64__x_64_Orange;
            this.pictureBoxRight.Location = new System.Drawing.Point(610, 0);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(107, 90);
            this.pictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxRight.TabIndex = 0;
            this.pictureBoxRight.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 3);
            this.panel1.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonNavigator1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 90);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(717, 399);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Bar.BarOrientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.kryptonNavigator1.Bar.CheckButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.kryptonNavigator1.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            this.kryptonNavigator1.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.OneNote;
            this.kryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarCheckButtonGroupOutside;
            this.kryptonNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2,
            this.kryptonPage3,
            this.kryptonPage4,
            this.kryptonPage5,
            this.kryptonPage6,
            this.kryptonPage7,
            this.kryptonPage8});
            this.kryptonNavigator1.SelectedIndex = 7;
            this.kryptonNavigator1.Size = new System.Drawing.Size(717, 399);
            this.kryptonNavigator1.StateCommon.Bar.BarPaddingOutside = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.kryptonNavigator1.StateCommon.Bar.CheckButtonGap = 5;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(588, 397);
            this.kryptonPage1.Text = "Core";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "b9322797412b486e88d7bf8056aa67da";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(588, 397);
            this.kryptonPage2.Text = "Dialogs";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "419c8ea99da44619b29354043d29a999";
            // 
            // kryptonPage3
            // 
            this.kryptonPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage3.Flags = 65534;
            this.kryptonPage3.LastVisibleSet = true;
            this.kryptonPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage3.Name = "kryptonPage3";
            this.kryptonPage3.Size = new System.Drawing.Size(588, 397);
            this.kryptonPage3.Text = "Outlook Grid";
            this.kryptonPage3.ToolTipTitle = "Page ToolTip";
            this.kryptonPage3.UniqueName = "29a07ed70c75409780c8cbb247c483d9";
            // 
            // kryptonPage4
            // 
            this.kryptonPage4.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage4.Flags = 65534;
            this.kryptonPage4.LastVisibleSet = true;
            this.kryptonPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage4.Name = "kryptonPage4";
            this.kryptonPage4.Size = new System.Drawing.Size(588, 397);
            this.kryptonPage4.Text = "Wizard";
            this.kryptonPage4.ToolTipTitle = "Page ToolTip";
            this.kryptonPage4.UniqueName = "21d61935efe54482972abc8ee8a3d62c";
            // 
            // kryptonPage5
            // 
            this.kryptonPage5.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage5.Flags = 65534;
            this.kryptonPage5.LastVisibleSet = true;
            this.kryptonPage5.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage5.Name = "kryptonPage5";
            this.kryptonPage5.Size = new System.Drawing.Size(588, 397);
            this.kryptonPage5.Text = "Toolbars";
            this.kryptonPage5.ToolTipTitle = "Page ToolTip";
            this.kryptonPage5.UniqueName = "665508ede045476292cb5b6d650b24f2";
            // 
            // kryptonPage6
            // 
            this.kryptonPage6.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage6.Flags = 65534;
            this.kryptonPage6.LastVisibleSet = true;
            this.kryptonPage6.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage6.Name = "kryptonPage6";
            this.kryptonPage6.Size = new System.Drawing.Size(574, 397);
            this.kryptonPage6.Text = "Colour Controls";
            this.kryptonPage6.ToolTipTitle = "Page ToolTip";
            this.kryptonPage6.UniqueName = "e53b1a35a58d49c0b013515a397f1d61";
            // 
            // kryptonPage7
            // 
            this.kryptonPage7.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage7.Flags = 65534;
            this.kryptonPage7.LastVisibleSet = true;
            this.kryptonPage7.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage7.Name = "kryptonPage7";
            this.kryptonPage7.Size = new System.Drawing.Size(574, 397);
            this.kryptonPage7.Text = "IO Components";
            this.kryptonPage7.ToolTipTitle = "Page ToolTip";
            this.kryptonPage7.UniqueName = "86ccf13d73434c508a943edabc5065ed";
            // 
            // kryptonPage8
            // 
            this.kryptonPage8.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage8.Flags = 65534;
            this.kryptonPage8.LastVisibleSet = true;
            this.kryptonPage8.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage8.Name = "kryptonPage8";
            this.kryptonPage8.Size = new System.Drawing.Size(574, 397);
            this.kryptonPage8.Text = "Toolkit Controls";
            this.kryptonPage8.ToolTipTitle = "Page ToolTip";
            this.kryptonPage8.UniqueName = "f02391499eb944a28eafec15d7a573bd";
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(717, 557);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanelTop);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton Extended Toolkit Demo Hub";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelTop)).EndInit();
            this.kryptonPanelTop.ResumeLayout(false);
            this.kryptonPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage8)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        private void kbtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}