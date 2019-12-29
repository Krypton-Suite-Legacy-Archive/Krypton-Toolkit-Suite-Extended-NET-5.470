namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    partial class KryptonTreeViewExtended
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (_mementoContent != null)
        //        {
        //            _mementoContent.Dispose();
        //            _mementoContent = null;
        //        }

        //        if (_mementoBack1 != null)
        //        {
        //            _mementoBack1.Dispose();
        //            _mementoBack1 = null;
        //        }

        //        if (_mementoBack2 != null)
        //        {
        //            _mementoBack2.Dispose();
        //            _mementoBack2 = null;
        //        }

        //        // Unhook from the palette events
        //        if (_palette != null)
        //        {
        //            _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
        //            _palette = null;
        //        }

        //        // Unhook from the static events, otherwise we cannot be garbage collected
        //        KryptonManager.GlobalPaletteChanged -= new EventHandler(OnGlobalPaletteChanged);
        //    }
        //    base.Dispose(disposing);
        //}

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonTreeViewExtended));
            this.ilSigns = new System.Windows.Forms.ImageList(this.components);
            this.ilCheckBoxes = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ilSigns
            // 
            this.ilSigns.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSigns.ImageStream")));
            this.ilSigns.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSigns.Images.SetKeyName(0, "XPPlus.png");
            this.ilSigns.Images.SetKeyName(1, "XPMinus.png");
            this.ilSigns.Images.SetKeyName(2, "VistaPlus.png");
            this.ilSigns.Images.SetKeyName(3, "VistaMinus.png");
            // 
            // ilCheckBoxes
            // 
            this.ilCheckBoxes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilCheckBoxes.ImageStream")));
            this.ilCheckBoxes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilCheckBoxes.Images.SetKeyName(0, "XpNotChecked.gif");
            this.ilCheckBoxes.Images.SetKeyName(1, "XpChecked.gif");
            this.ilCheckBoxes.Images.SetKeyName(2, "VistaNotChecked.png");
            this.ilCheckBoxes.Images.SetKeyName(3, "VistaChecked.png");
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilSigns;
        private System.Windows.Forms.ImageList ilCheckBoxes;
    }
}
