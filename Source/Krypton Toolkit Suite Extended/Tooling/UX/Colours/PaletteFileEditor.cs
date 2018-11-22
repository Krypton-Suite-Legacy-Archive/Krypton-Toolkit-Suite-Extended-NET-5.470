using ComponentFactory.Krypton.Toolkit;
using System;
using System.IO;
using System.Windows.Forms;
using Tooling.Classes.Other;

namespace Tooling.UX
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
