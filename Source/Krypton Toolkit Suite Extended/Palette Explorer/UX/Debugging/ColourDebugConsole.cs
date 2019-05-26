using ComponentFactory.Krypton.Toolkit;
using System;

namespace PaletteExplorer.UX.Debugging
{
    public class ColourDebugConsole : KryptonForm
    {
        private System.Windows.Forms.Panel pnlSplitter;
        private KryptonPanel kpnlContent;
        private KryptonListBox klstPaletteColours;
        private KryptonLabel klblAlphaValue;
        private KryptonLabel klblRedValue;
        private KryptonLabel klblGreenValue;
        private KryptonLabel klblBlueValue;
        private KryptonLabel kryptonLabel10;
        private KryptonLabel kryptonLabel9;
        private KryptonLabel kryptonLabel8;
        private KryptonLabel kryptonLabel1;
        private ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel cwSelectedColour;
        private KryptonLabel kryptonLabel2;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxColourPreview;
        private KryptonPanel kpnlControls;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourDebugConsole));
            this.kpnlControls = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.kpnlContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klstPaletteColours = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.klblRedValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblGreenValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblBlueValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblAlphaValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cwSelectedColour = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel();
            this.cbxColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).BeginInit();
            this.kpnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxColourPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlControls
            // 
            this.kpnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlControls.Location = new System.Drawing.Point(0, 827);
            this.kpnlControls.Name = "kpnlControls";
            this.kpnlControls.Size = new System.Drawing.Size(1115, 66);
            this.kpnlControls.TabIndex = 0;
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 824);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(1115, 3);
            this.pnlSplitter.TabIndex = 1;
            // 
            // kpnlContent
            // 
            this.kpnlContent.Controls.Add(this.kryptonLabel2);
            this.kpnlContent.Controls.Add(this.cbxColourPreview);
            this.kpnlContent.Controls.Add(this.cwSelectedColour);
            this.kpnlContent.Controls.Add(this.klblAlphaValue);
            this.kpnlContent.Controls.Add(this.klblRedValue);
            this.kpnlContent.Controls.Add(this.klblGreenValue);
            this.kpnlContent.Controls.Add(this.klblBlueValue);
            this.kpnlContent.Controls.Add(this.kryptonLabel10);
            this.kpnlContent.Controls.Add(this.kryptonLabel9);
            this.kpnlContent.Controls.Add(this.kryptonLabel8);
            this.kpnlContent.Controls.Add(this.kryptonLabel1);
            this.kpnlContent.Controls.Add(this.klstPaletteColours);
            this.kpnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlContent.Location = new System.Drawing.Point(0, 0);
            this.kpnlContent.Name = "kpnlContent";
            this.kpnlContent.Size = new System.Drawing.Size(1115, 824);
            this.kpnlContent.TabIndex = 2;
            // 
            // klstPaletteColours
            // 
            this.klstPaletteColours.Location = new System.Drawing.Point(12, 12);
            this.klstPaletteColours.Name = "klstPaletteColours";
            this.klstPaletteColours.Size = new System.Drawing.Size(483, 688);
            this.klstPaletteColours.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstPaletteColours.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstPaletteColours.TabIndex = 3;
            this.klstPaletteColours.SelectedIndexChanged += new System.EventHandler(this.KlstPaletteColours_SelectedIndexChanged);
            // 
            // klblRedValue
            // 
            this.klblRedValue.Location = new System.Drawing.Point(607, 740);
            this.klblRedValue.Name = "klblRedValue";
            this.klblRedValue.Size = new System.Drawing.Size(6, 2);
            this.klblRedValue.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.LongText.Color2 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRedValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRedValue.TabIndex = 40;
            this.klblRedValue.Values.Text = "";
            // 
            // klblGreenValue
            // 
            this.klblGreenValue.Location = new System.Drawing.Point(795, 740);
            this.klblGreenValue.Name = "klblGreenValue";
            this.klblGreenValue.Size = new System.Drawing.Size(6, 2);
            this.klblGreenValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblGreenValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Green;
            this.klblGreenValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Green;
            this.klblGreenValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblGreenValue.TabIndex = 39;
            this.klblGreenValue.Values.Text = "";
            // 
            // klblBlueValue
            // 
            this.klblBlueValue.Location = new System.Drawing.Point(985, 740);
            this.klblBlueValue.Name = "klblBlueValue";
            this.klblBlueValue.Size = new System.Drawing.Size(6, 2);
            this.klblBlueValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBlueValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.klblBlueValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Blue;
            this.klblBlueValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBlueValue.TabIndex = 38;
            this.klblBlueValue.Values.Text = "";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(542, 740);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(59, 33);
            this.kryptonLabel10.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 37;
            this.kryptonLabel10.Values.Text = "Red:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(709, 740);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(80, 33);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 36;
            this.kryptonLabel9.Values.Text = "Green:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(915, 737);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(64, 33);
            this.kryptonLabel8.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 35;
            this.kryptonLabel8.Values.Text = "Blue:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(331, 737);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(79, 33);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 33;
            this.kryptonLabel1.Values.Text = "Alpha:";
            // 
            // klblAlphaValue
            // 
            this.klblAlphaValue.Location = new System.Drawing.Point(416, 740);
            this.klblAlphaValue.Name = "klblAlphaValue";
            this.klblAlphaValue.Size = new System.Drawing.Size(6, 2);
            this.klblAlphaValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblAlphaValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblAlphaValue.TabIndex = 41;
            this.klblAlphaValue.Values.Text = "";
            // 
            // cwSelectedColour
            // 
            this.cwSelectedColour.BackColor = System.Drawing.Color.Transparent;
            this.cwSelectedColour.Location = new System.Drawing.Point(670, 12);
            this.cwSelectedColour.Name = "cwSelectedColour";
            this.cwSelectedColour.Size = new System.Drawing.Size(352, 362);
            this.cwSelectedColour.TabIndex = 42;
            // 
            // cbxColourPreview
            // 
            this.cbxColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxColourPreview.Location = new System.Drawing.Point(726, 399);
            this.cbxColourPreview.Name = "cbxColourPreview";
            this.cbxColourPreview.Size = new System.Drawing.Size(232, 230);
            this.cbxColourPreview.TabIndex = 43;
            this.cbxColourPreview.TabStop = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 737);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(79, 33);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 44;
            this.kryptonLabel2.Values.Text = "Alpha:";
            // 
            // ColourDebugConsole
            // 
            this.ClientSize = new System.Drawing.Size(1115, 893);
            this.Controls.Add(this.kpnlContent);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kpnlControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColourDebugConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palette Debug Console - [{0}]";
            ((System.ComponentModel.ISupportInitialize)(this.kpnlControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).EndInit();
            this.kpnlContent.ResumeLayout(false);
            this.kpnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxColourPreview)).EndInit();
            this.ResumeLayout(false);

        }

        public ColourDebugConsole()
        {
            InitializeComponent();
        }

        private void KlstPaletteColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI(klstPaletteColours.SelectedItem.ToString());
        }

        private void UpdateUI(string v)
        {

        }
    }
}