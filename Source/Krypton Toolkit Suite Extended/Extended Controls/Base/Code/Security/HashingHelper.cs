#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Exceptions;
using System;
using System.Drawing;

namespace ExtendedControls.Base.Code.Security
{
    public class HashingHelper
    {
        #region Variables
        private static string[] _hashTypeArray = { "MD5", "SHA-1", "SHA-256", "SHA-384", "SHA-512", "RIPEMD-160" };
        #endregion

        #region Properties        
        /// <summary>
        /// Gets the hash type array.
        /// </summary>
        /// <value>
        /// The hash type array.
        /// </value>
        public static string[] HashTypeArray { get => _hashTypeArray; }
        #endregion

        #region Constructors        
        /// <summary>
        /// Initializes a new instance of the <see cref="HashingHelper"/> class.
        /// </summary>
        public HashingHelper()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Propagates the hash input.
        /// </summary>
        /// <param name="box">The box.</param>
        public static void PropagateHashInput(KryptonComboBox box)
        {
            try
            {
                foreach (string value in HashTypeArray)
                {
                    box.Items.Add(value);
                }
            }
            catch (Exception e)
            {
                ExceptionHandler.CaptureException(e);
            }
        }

        /// <summary>
        /// Determines whether [is hash valid] [the specified file hash].
        /// </summary>
        /// <param name="fileHash">The file hash.</param>
        /// <param name="hash">The hash.</param>
        /// <returns>
        ///   <c>true</c> if [is hash valid] [the specified file hash]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsHashValid(KryptonLabel fileHash, KryptonTextBox hash)
        {
            return fileHash.Text.Contains(hash.Text);
        }

        /// <summary>
        /// Validates the file hash.
        /// </summary>
        /// <param name="fileHash">The file hash.</param>
        /// <param name="hash">The hash.</param>
        public static void ValidateFileHash(KryptonLabel fileHash, KryptonTextBox hash)
        {
            if (IsHashValid(fileHash, hash))
            {
                hash.StateCommon.Back.Color1 = Color.Green;

                hash.StateCommon.Content.Color1 = Color.Black;
            }
            else
            {
                hash.StateCommon.Back.Color1 = Color.Red;

                hash.StateCommon.Content.Color1 = Color.White;
            }
        }

        /// <summary>
        /// Validates the file hash.
        /// </summary>
        /// <param name="showConfirmation">if set to <c>true</c> [show confirmation].</param>
        /// <param name="fileHash">The file hash.</param>
        /// <param name="hash">The hash.</param>
        public static void ValidateFileHash(bool showConfirmation, KryptonLabel fileHash, KryptonTextBox hash)
        {
            if (showConfirmation)
            {
                if (IsHashValid(fileHash, hash))
                {
                    hash.StateCommon.Back.Color1 = Color.Green;

                    hash.StateCommon.Content.Color1 = Color.Black;
                }
                else
                {
                    hash.StateCommon.Back.Color1 = Color.Red;

                    hash.StateCommon.Content.Color1 = Color.White;
                }
            }
            else
            {
                ValidateFileHash(fileHash, hash);
            }
        }
        #endregion
    }
}