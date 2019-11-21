#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;

namespace Persistence.UX
{
    public partial class AboutDialog : KryptonForm
    {
        #region Variables
        private Persistence.Interfaces.IAboutStripped _about;
        #endregion

        public AboutDialog()
        {
            InitializeComponent();
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            //ShowIcon = _about.UseIcon;

            if (_about.ApplicationIcon != null)
            {
                Icon = _about.ApplicationIcon;
            }

            //kbtnSystemInformation.Visible = _about.ShowSystemInformationButton;

            Text = $"About { _about.ApplicationName }";

            pbxApplicationImage.Image = _about.ApplicationIconImage;
        }
    }
}