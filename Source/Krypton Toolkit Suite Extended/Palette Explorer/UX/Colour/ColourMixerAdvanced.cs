using ComponentFactory.Krypton.Toolkit;
using System;

namespace PaletteExplorer.UX.Colour
{
    public class ColourMixerAdvanced : KryptonForm
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ColourMixerAdvanced
            // 
            this.ClientSize = new System.Drawing.Size(1400, 849);
            this.Name = "ColourMixerAdvanced";
            this.Load += new System.EventHandler(this.ColourMixerAdvanced_Load);
            this.ResumeLayout(false);

        }


        #region Constructors
        public ColourMixerAdvanced()
        {

        }
        #endregion

        private void ColourMixerAdvanced_Load(object sender, EventArgs e)
        {

        }
    }
}