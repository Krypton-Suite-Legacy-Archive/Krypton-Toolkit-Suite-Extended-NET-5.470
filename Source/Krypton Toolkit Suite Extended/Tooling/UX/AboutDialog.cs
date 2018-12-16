using ComponentFactory.Krypton.Toolkit;
using GlobalUtilities.Interfaces;
using System;

namespace Core.UX
{
    public partial class AboutDialog : KryptonForm
    {
        #region Variables
        private IAbout _about;
        #endregion

        public AboutDialog()
        {
            InitializeComponent();
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            ShowIcon = _about.UseIcon;

            if (_about.ApplicationIcon != null)
            {
                Icon = _about.ApplicationIcon;
            }

            kbtnSystemInformation.Visible = _about.ShowSystemInformationButton;

            Text = $"About { _about.ApplicationName }";

            pbxApplicationImage.Image = _about.ApplicationIconImage;
        }
    }
}