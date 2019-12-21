#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedDialogs.Dialogs.About.Custom;
using System.Drawing;

namespace ExtendedDialogs.Dialogs.About
{
    public interface IAbout
    {
        /// <summary>Gets or sets the assembly title.</summary>
        /// <value>The assembly title.</value>
        string AssemblyTitle { get; set; }

        /// <summary>Gets or sets the assembly version.</summary>
        /// <value>The assembly version.</value>
        string AssemblyVersion { get; set; }

        /// <summary>Gets or sets the assembly description.</summary>
        /// <value>The assembly description.</value>
        string AssemblyDescription { get; set; }

        /// <summary>Gets or sets the assembly product.</summary>
        /// <value>The assembly product.</value>
        string AssemblyProduct { get; set; }

        /// <summary>Gets or sets the assembly copyright.</summary>
        /// <value>The assembly copyright.</value>
        string AssemblyCopyright { get; set; }

        /// <summary>Gets or sets the assembly company.</summary>
        /// <value>The assembly company.</value>
        string AssemblyCompany { get; set; }

        /// <summary>Gets or sets the name of the product.</summary>
        /// <value>The name of the product.</value>
        string ProductName { get; set; }

        /// <summary>Gets or sets the name of the copyright holders.</summary>
        /// <value>The name of the copyright holders.</value>
        string CopyrightHoldersName { get; set; }

        /// <summary>Gets or sets the start year.</summary>
        /// <value>The start year.</value>
        string StartYear { get; set; }

        /// <summary>Gets or sets the current copyright year.</summary>
        /// <value>The current copyright year.</value>
        string CurrentCopyrightYear { get; set; }

        /// <summary>Gets or sets the license file path.</summary>
        /// <value>The license file path.</value>
        string LicenseFilePath { get; set; }

        /// <summary>Gets or sets the product icon.</summary>
        /// <value>The product icon.</value>
        Icon ProductIcon { get; set; }

        /// <summary>Gets or sets the product image 16 x 16.</summary>
        /// <value>The product image 16 x 16.</value>
        Image ProductImage16x16 { get; set; }

        /// <summary>Gets or sets the product image 32 x 32.</summary>
        /// <value>The product image 32 x 32.</value>
        Image ProductImage32x32 { get; set; }

        /// <summary>Gets or sets the product image 48 x 48.</summary>
        /// <value>The product image 48 x 48.</value>
        Image ProductImage48x48 { get; set; }

        /// <summary>Gets or sets the product image 64 x 64.</summary>
        /// <value>The product image 64 x 64.</value>
        Image ProductImage64x64 { get; set; }

        /// <summary>Gets or sets the product image128 x 128.</summary>
        /// <value>The product image 128 x 128. </value>
        Image ProductImage128x128 { get; set; }

        /// <summary>Gets or sets the product image 256 x 256.</summary>
        /// <value>The product image 256 x 256.</value>
        Image ProductImage256x256 { get; set; }

        /// <summary>Gets or sets the product image 512 x 512.</summary>
        /// <value>The product image 512 x 512.</value>
        Image ProductImage512x512 { get; set; }

        /// <summary>Gets or sets the type of the krypton about box layout button.</summary>
        /// <value>The type of the krypton about box layout button.</value>
        KryptonAboutBoxLayoutButtonType KryptonAboutBoxLayoutButtonType { get; set; }
    }
}