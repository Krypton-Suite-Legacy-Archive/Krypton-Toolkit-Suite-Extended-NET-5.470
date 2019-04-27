using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class KryptonCommandLinks : KryptonForm
    {
        private ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkButton kryptonCommandLinkButton2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkVersion2 kryptonCommandLinkVersion21;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonCommandLinks));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonCommandLinkButton2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkButton();
            this.kryptonCommandLinkVersion21 = new ExtendedControls.ExtendedToolkit.Controls.KryptonCommandLinkVersion2();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonCommandLinkButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonCommandLinkVersion21);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(374, 153);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonCommandLinkButton2
            // 
            this.kryptonCommandLinkButton2.CommandLinkImageValue.Image = null;
            this.kryptonCommandLinkButton2.Location = new System.Drawing.Point(12, 12);
            this.kryptonCommandLinkButton2.Name = "kryptonCommandLinkButton2";
            this.kryptonCommandLinkButton2.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton2.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton2.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton2.Size = new System.Drawing.Size(352, 55);
            this.kryptonCommandLinkButton2.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton2.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCommandLinkButton2.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton2.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton2.TabIndex = 36;
            this.kryptonCommandLinkButton2.Click += new System.EventHandler(this.KryptonCommandLinkButton2_Click);
            // 
            // kryptonCommandLinkVersion21
            // 
            this.kryptonCommandLinkVersion21.Location = new System.Drawing.Point(12, 82);
            this.kryptonCommandLinkVersion21.Name = "kryptonCommandLinkVersion21";
            this.kryptonCommandLinkVersion21.ShowUACShield = true;
            this.kryptonCommandLinkVersion21.Size = new System.Drawing.Size(354, 55);
            this.kryptonCommandLinkVersion21.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCommandLinkVersion21.TabIndex = 35;
            this.kryptonCommandLinkVersion21.Values.ExtraText = "Here be the extra Text";
            this.kryptonCommandLinkVersion21.Values.Image = global::Playground.Properties.Resources.KR_32_x_32_Orange;
            this.kryptonCommandLinkVersion21.Values.Text = "Command Link V2";
            // 
            // KryptonCommandLinks
            // 
            this.ClientSize = new System.Drawing.Size(374, 153);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonCommandLinks";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command Links";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public KryptonCommandLinks()
        {
            InitializeComponent();
        }

        private void KryptonCommandLinkButton2_Click(object sender, EventArgs e)
        {
            using (CommandLinkStyles cls = new CommandLinkStyles())
            {
                cls.ShowDialog(this);
            }
        }
    }
}