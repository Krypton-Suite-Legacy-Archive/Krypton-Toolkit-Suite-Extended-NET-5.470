using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOComponents.User_Controls.Dev
{
    public class KryptonFileSystemUserControlDev : UserControl
    {
        private Panel pnlTop;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtPath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnBack;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnHome;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnNext;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView ktvFileSystem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnUp;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonFileSystemUserControlDev));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.kbtnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktxtPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnGo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnInfo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnHome = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnUp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktvFileSystem = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.kbtnAdd);
            this.pnlTop.Controls.Add(this.ktxtPath);
            this.pnlTop.Controls.Add(this.kbtnGo);
            this.pnlTop.Controls.Add(this.kbtnInfo);
            this.pnlTop.Controls.Add(this.kbtnRefresh);
            this.pnlTop.Controls.Add(this.kbtnBack);
            this.pnlTop.Controls.Add(this.kbtnHome);
            this.pnlTop.Controls.Add(this.kbtnNext);
            this.pnlTop.Controls.Add(this.kbtnUp);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(519, 43);
            this.pnlTop.TabIndex = 92;
            // 
            // kbtnAdd
            // 
            this.kbtnAdd.Location = new System.Drawing.Point(12, 12);
            this.kbtnAdd.Name = "kbtnAdd";
            this.kbtnAdd.Size = new System.Drawing.Size(33, 26);
            this.kbtnAdd.TabIndex = 85;
            this.kbtnAdd.ToolTipValues.Description = "Add shortcut to frequently used folders";
            this.kbtnAdd.ToolTipValues.Heading = "Add Shortcut";
            this.kbtnAdd.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnAdd.Values.Image")));
            this.kbtnAdd.Values.Text = "";
            // 
            // ktxtPath
            // 
            this.ktxtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ktxtPath.Hint = "Type a path here... (e.g. C:\\Windows)";
            this.ktxtPath.Location = new System.Drawing.Point(12, 44);
            this.ktxtPath.Name = "ktxtPath";
            this.ktxtPath.Size = new System.Drawing.Size(465, 29);
            this.ktxtPath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtPath.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtPath.TabIndex = 1;
            // 
            // kbtnGo
            // 
            this.kbtnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnGo.Location = new System.Drawing.Point(483, 44);
            this.kbtnGo.Name = "kbtnGo";
            this.kbtnGo.Size = new System.Drawing.Size(33, 29);
            this.kbtnGo.TabIndex = 84;
            this.kbtnGo.ToolTipValues.Description = "Go to the directory";
            this.kbtnGo.ToolTipValues.Heading = "Go";
            this.kbtnGo.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnGo.Values.Image")));
            this.kbtnGo.Values.Text = "";
            // 
            // kbtnInfo
            // 
            this.kbtnInfo.Location = new System.Drawing.Point(246, 12);
            this.kbtnInfo.Name = "kbtnInfo";
            this.kbtnInfo.Size = new System.Drawing.Size(33, 26);
            this.kbtnInfo.TabIndex = 79;
            this.kbtnInfo.ToolTipValues.Description = "Information";
            this.kbtnInfo.ToolTipValues.Heading = "Information";
            this.kbtnInfo.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnInfo.Values.Image")));
            this.kbtnInfo.Values.Text = "";
            // 
            // kbtnRefresh
            // 
            this.kbtnRefresh.Location = new System.Drawing.Point(168, 12);
            this.kbtnRefresh.Name = "kbtnRefresh";
            this.kbtnRefresh.Size = new System.Drawing.Size(33, 26);
            this.kbtnRefresh.TabIndex = 82;
            this.kbtnRefresh.ToolTipValues.Description = "Refresh explorer tree";
            this.kbtnRefresh.ToolTipValues.Heading = "Refresh";
            this.kbtnRefresh.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnRefresh.Values.Image")));
            this.kbtnRefresh.Values.Text = "";
            // 
            // kbtnBack
            // 
            this.kbtnBack.Location = new System.Drawing.Point(51, 12);
            this.kbtnBack.Name = "kbtnBack";
            this.kbtnBack.Size = new System.Drawing.Size(33, 26);
            this.kbtnBack.TabIndex = 86;
            this.kbtnBack.ToolTipValues.Description = "Go backwards";
            this.kbtnBack.ToolTipValues.Heading = "Backward";
            this.kbtnBack.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnBack.Values.Image")));
            this.kbtnBack.Values.Text = "";
            // 
            // kbtnHome
            // 
            this.kbtnHome.Location = new System.Drawing.Point(207, 12);
            this.kbtnHome.Name = "kbtnHome";
            this.kbtnHome.Size = new System.Drawing.Size(33, 26);
            this.kbtnHome.TabIndex = 83;
            this.kbtnHome.ToolTipValues.Description = "Home directory";
            this.kbtnHome.ToolTipValues.Heading = "Home";
            this.kbtnHome.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnHome.Values.Image")));
            this.kbtnHome.Values.Text = "";
            // 
            // kbtnNext
            // 
            this.kbtnNext.Location = new System.Drawing.Point(90, 12);
            this.kbtnNext.Name = "kbtnNext";
            this.kbtnNext.Size = new System.Drawing.Size(33, 26);
            this.kbtnNext.TabIndex = 80;
            this.kbtnNext.ToolTipValues.Description = "Go forward";
            this.kbtnNext.ToolTipValues.Heading = "Forward";
            this.kbtnNext.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnNext.Values.Image")));
            this.kbtnNext.Values.Text = "";
            // 
            // kbtnUp
            // 
            this.kbtnUp.Location = new System.Drawing.Point(129, 12);
            this.kbtnUp.Name = "kbtnUp";
            this.kbtnUp.Size = new System.Drawing.Size(33, 26);
            this.kbtnUp.TabIndex = 81;
            this.kbtnUp.ToolTipValues.Description = "Go up";
            this.kbtnUp.ToolTipValues.Heading = "Parent Directory";
            this.kbtnUp.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnUp.Values.Image")));
            this.kbtnUp.Values.Text = "";
            // 
            // ktvFileSystem
            // 
            this.ktvFileSystem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ktvFileSystem.Location = new System.Drawing.Point(0, 49);
            this.ktvFileSystem.Name = "ktvFileSystem";
            this.ktvFileSystem.Size = new System.Drawing.Size(519, 499);
            this.ktvFileSystem.TabIndex = 93;
            // 
            // KryptonFileSystemUserControlDev
            // 
            this.Controls.Add(this.ktvFileSystem);
            this.Controls.Add(this.pnlTop);
            this.Name = "KryptonFileSystemUserControlDev";
            this.Size = new System.Drawing.Size(519, 548);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}