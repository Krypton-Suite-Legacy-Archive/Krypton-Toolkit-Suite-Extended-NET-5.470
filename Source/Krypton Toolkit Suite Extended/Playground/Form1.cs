using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Enumerations;
using KryptonApplicationUpdater.Classes.SettingsManager;
using KryptonApplicationUpdater.Interfaces;
using KryptonExtendedToolkit.Base.Code;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Tooling.Classes.Other;
using Tooling.UX;

namespace Playground
{
    public partial class Form1 : KryptonForm, IUpdatable
    {
        private UtilityMethods utilityMethods = new UtilityMethods();
        private InternalApplicationUpdaterSettingsManager internalApplicationUpdaterSettingsManager = new InternalApplicationUpdaterSettingsManager();
        private MostRecentlyUsedFileManager mostRecentlyUsedFileManager;
        private Version currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
        private ToolStripNonClientRenderer toolStripNonClientRenderer;

        public Form1()
        {
            InitializeComponent();

            tsTest.Renderer = new ToolStripNonClientRenderer();
        }

        #region IUpdatable Implementation
        public Icon ApplicationIcon { get { return Icon; } set { } }
        public string ServerXMLFileURL { get { return "https://www.dropbox.com/s/mwyexz1baqt0y4b/Update.xml?dl=0"; } set { } }
        public string ApplicationName { get { return "Playground"; } set { } }
        public string CurrentApplicationVersion { get { return currentVersion.ToString(); } set { } }
        public string ApplicationIdentification { get { return "Playground"; } set { } }
        Form IUpdatable.ParentForm { get { return this; } set { } }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            mostRecentlyUsedFileManager = new MostRecentlyUsedFileManager(recentDocumentsToolStripMenuItem, "Playground", MyOwnRecentFileGotClicked_Handler, MyOwnRecentFilesGotCleared_Handler);

            kuacsbElevate.ProcessName = Process.GetCurrentProcess().ProcessName;

            if (ServerXMLFileURL != null)
            {
                internalApplicationUpdaterSettingsManager.SetXMLFileURL(ServerXMLFileURL);
            }

            if (utilityMethods.GetHasElevateProcessWithAdministrativeRights())
            {
                Text = Text + " (Administrator)";
            }

            klblAdminMode.Text = $"Is running in Administrator mode: { utilityMethods.GetHasElevateProcessWithAdministrativeRights().ToString() }";

            //kctb1.CueText = "Hello";

            //kryptonCommandLinkVersion11.Note = "Hello";

            lblVersion.Text = $"Version: { currentVersion.ToString() }";

            etslBlinkTest.SoftBlink(etslBlinkTest.AlertColourOne, etslBlinkTest.AlertColourTwo, etslBlinkTest.AlertTextColour, 2000, false, 5);

            foreach (LinearGradientMode lgm in Enum.GetValues(typeof(LinearGradientMode)))
            {
                kcmbGradientDirection.Items.Add(lgm.ToString().ToUpper());
            }

            //kcmbGradientDirection.d
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

        private void SaveFile(string filePath, bool saveAs = false)
        {
            if (saveAs)
            {

            }
            else
            {

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

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Save file as:";

            saveFileDialog.Filter = "Normal Text Files (*.txt)|*.txt";

            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);

                writer.Write(krtbEditor.Text);

                mostRecentlyUsedFileManager.AddRecentFile(Path.GetFullPath(saveFileDialog.FileName));
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ColourRGBToHexadecimalConverter colourRGBToHexadecimalConverter = new ColourRGBToHexadecimalConverter();

            colourRGBToHexadecimalConverter.Show();
        }

        private void tsAlignLeft_Click(object sender, EventArgs e)
        {
            rxrbTextPad.SelectionAlignment = TextAlignment.LEFT;
        }

        private void tsAlignCentre_Click(object sender, EventArgs e)
        {
            rxrbTextPad.SelectionAlignment = TextAlignment.CENTRE;
        }

        private void tsAlignRight_Click(object sender, EventArgs e)
        {
            rxrbTextPad.SelectionAlignment = TextAlignment.RIGHT;
        }

        private void tsJustify_Click(object sender, EventArgs e)
        {
            rxrbTextPad.SelectionAlignment = TextAlignment.JUSTIFY;
        }

        private void kbtnHexToRGB_Click(object sender, EventArgs e)
        {
            ColourHexadecimalToRGBConverter colourHexadecimalToRGBConverter = new ColourHexadecimalToRGBConverter();

            colourHexadecimalToRGBConverter.Show();
        }

        private void kbtnColourMixer_Click(object sender, EventArgs e)
        {
            ColourMixer colourMixer = new ColourMixer(255, 255, 255, 255);

            colourMixer.Show();
        }

        private void kbtnColourCreator_Click(object sender, EventArgs e)
        {
            PaletteColourCreator paletteColourCreator = new PaletteColourCreator();

            paletteColourCreator.Show();
        }

        private void kcbtnGradientColour1_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            etslBlinkTest.GradientColourOne = kcbtnGradientColour1.SelectedColor;
        }

        private void kcbtnGradientColour2_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            etslBlinkTest.GradientColourTwo = kcbtnGradientColour2.SelectedColor;
        }

        private void kcbtnTextColour_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            etslBlinkTest.ForeColor = kcbtnTextColour.SelectedColor;
        }

        private void kcmbGradientDirection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kcmbGradientDirection_TextChanged(object sender, EventArgs e)
        {
            // etslBlinkTest.GradientMode = Enum.Parse(typeof(LinearGradientMode), (LinearGradientMode)kcmbGradientDirection.Text);
        }

        private void kcbtnHorizontal_Click(object sender, EventArgs e)
        {
            etslBlinkTest.GradientMode = LinearGradientMode.Horizontal;

            kcbtnHorizontal.Checked = true;

            kcbtnVertical.Checked = false;

            kcbtnForwardDiagonal.Checked = false;

            kcbtnBackwardDiagonal.Checked = false;
        }

        private void kcbtnVertical_Click(object sender, EventArgs e)
        {
            etslBlinkTest.GradientMode = LinearGradientMode.Vertical;

            kcbtnHorizontal.Checked = false;

            kcbtnVertical.Checked = true;

            kcbtnForwardDiagonal.Checked = false;

            kcbtnBackwardDiagonal.Checked = false;
        }

        private void kcbtnForwardDiagonal_Click(object sender, EventArgs e)
        {
            etslBlinkTest.GradientMode = LinearGradientMode.ForwardDiagonal;

            kcbtnHorizontal.Checked = false;

            kcbtnVertical.Checked = false;

            kcbtnForwardDiagonal.Checked = true;

            kcbtnBackwardDiagonal.Checked = false;
        }

        private void kcbtnBackwardDiagonal_Click(object sender, EventArgs e)
        {
            etslBlinkTest.GradientMode = LinearGradientMode.BackwardDiagonal;

            kcbtnHorizontal.Checked = false;

            kcbtnVertical.Checked = false;

            kcbtnForwardDiagonal.Checked = false;

            kcbtnBackwardDiagonal.Checked = true;
        }
    }
}