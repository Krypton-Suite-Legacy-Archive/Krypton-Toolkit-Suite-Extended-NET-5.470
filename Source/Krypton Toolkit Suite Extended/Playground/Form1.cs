using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Playground
{
    public partial class Form1 : Form
    {
        UtilityMethods utilityMethods = new UtilityMethods();

        MostRecentlyUsedFileManager mostRecentlyUsedFileManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostRecentlyUsedFileManager = new MostRecentlyUsedFileManager(recentFilesToolStripMenuItem, "Playground", MyOwnRecentFileGotClicked_Handler, MyOwnRecentFilesGotCleared_Handler);

            kbtnUACTest.ProcessName = Process.GetCurrentProcess().ProcessName;

            tsmiUACTest.ProcessName = Process.GetCurrentProcess().ProcessName;

            if (utilityMethods.GetHasElevateProcessWithAdministrativeRights())
            {
                Text = Text + " (Administrator)";
            }

            lblIsAdminMode.Text = $"Is running in Administrator mode: { utilityMethods.GetHasElevateProcessWithAdministrativeRights().ToString() }";

            kctb1.CueText = "Hello";

            kryptonCommandLinkVersion11.Note = "Hello";
        }

        private void MyOwnRecentFileGotClicked_Handler(object sender, EventArgs e)
        {
            string fileName = (sender as ToolStripItem).Text;

            if (!File.Exists(fileName))
            {
                if (KryptonMessageBox.Show($"{ fileName } doesn't exist. Remove from recent workspaces?", "File not found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mostRecentlyUsedFileManager.RemoveRecentFile(fileName);
                }
                else
                {
                    return;
                }
            }

            OpenFile(fileName);
        }

        private void MyOwnRecentFilesGotCleared_Handler(object sender, EventArgs e)
        {

        }

        private void OpenFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                //rtbTextPad.LoadFile(filePath);

                StreamReader reader = new StreamReader(filePath);

                rtbTextPad.Text = reader.ReadToEnd();

                mostRecentlyUsedFileManager.AddRecentFile(filePath);
            }
            else
            {
                KryptonMessageBox.Show($"Error: file '{ filePath }' could not be found!");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog openFileDlg = new OpenFileDialog();

            openFileDlg.InitialDirectory = Environment.CurrentDirectory;


            if (openFileDlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string openedFile = openFileDlg.FileName;

            OpenFile(openedFile);
        }
    }
}
