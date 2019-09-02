#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using Persistence.Classes.Other;
using System;
using System.IO;
using System.Windows.Forms;

namespace Persistence.UX
{
    public partial class PaletteFileEditor : KryptonForm
    {
        #region Variables
        private FileCreator _fileCreator = new FileCreator();
        #endregion

        public PaletteFileEditor()
        {
            InitializeComponent();
        }

        public PaletteFileEditor(string paletteFilePath)
        {
            InitializeComponent();

            try
            {
                StreamReader reader = new StreamReader(paletteFilePath);

                string fileContents = reader.ReadToEnd();

                filePane.Text = fileContents;
            }
            catch (Exception error)
            {
                KryptonMessageBox.Show($"An error has occurred: { error.Message }", "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kbtnGenerateNewFile_Click(object sender, EventArgs e)
        {
            _fileCreator.GenerateNewFile(filePane);
        }

        private void PaletteFileEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
