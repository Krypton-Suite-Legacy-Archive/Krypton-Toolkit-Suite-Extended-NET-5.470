#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    [ToolboxItem(true)]
    public class KryptonHexadecimalColourTextBox : KryptonTextBox
    {
        #region Variables
        private ArrayList _hexadecimalColourList;
        private bool _uppercase = true;
        private string _hexadecimalColourDatabaseFilePath;
        #endregion

        #region Properties
        public bool Uppercase { get { return _uppercase; } set { _uppercase = value; } }

        /// <summary>
        /// Gets or sets the hexadecimal colour database file path.
        /// </summary>
        /// <value>
        /// The hexadecimal colour database file path.
        /// </value>
        [Category("Data")]
        [Description("Gets or sets the hexadecimal colour database file path.")]
        public string HexadecimalColourDatabaseFilePath { get { return _hexadecimalColourDatabaseFilePath; } set { _hexadecimalColourDatabaseFilePath = value; } }
        #endregion

        #region Constructors
        public KryptonHexadecimalColourTextBox()
        {
            TextAlign = HorizontalAlignment.Center;

            UpdateControl();
        }
        #endregion

        #region Methods
        public void UpdateControl()
        {
            _hexadecimalColourList = new ArrayList();

            if (HexadecimalColourDatabaseFilePath != string.Empty)
            {
                if (File.Exists(HexadecimalColourDatabaseFilePath))
                {
                    StreamReader reader = new StreamReader(HexadecimalColourDatabaseFilePath);

                    string contents = reader.ReadToEnd();


                }
            }
        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            //UpdateControl();

            base.OnPaint(e);

            //Invalidate();
        }
        #endregion
    }
}