#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using Core.Interfaces;
using System;
using System.Drawing;

namespace Core.UI.Elements
{
    /// <summary>
    /// Displays the application information.
    /// </summary>
    /// <seealso cref="ComponentFactory.Krypton.Toolkit.KryptonForm" />
    /// <seealso cref="Core.Interfaces.IAbout" />
    public partial class AboutBox : KryptonForm, IAbout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutBox"/> class.
        /// </summary>
        public AboutBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets a value indicating whether [use icon].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use icon]; otherwise, <c>false</c>.
        /// </value>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool UseIcon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ShowSystemInformationButton { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreationDateTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Version ApplicationVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Version FrameworkVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Icon ApplicationIcon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Bitmap ApplicationIconImage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AuthourName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InstallLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}