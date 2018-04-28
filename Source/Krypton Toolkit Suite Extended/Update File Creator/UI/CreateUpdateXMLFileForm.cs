using ComponentFactory.Krypton.Toolkit;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Windows.Forms;

namespace UpdateFileCreator.UI
{
    public partial class CreateUpdateXMLFileForm : KryptonForm
    {
        #region Variables
        bool _dataModified = false;

        Timer _wordCount;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets DataModified.
        /// </summary>
        /// <value>
        /// _dataModified.
        /// </value>
        public bool DataModified
        {
            get
            {
                return _dataModified;
            }


            set
            {
                _dataModified = value;
            }
        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the DataModified to the value of value.
        /// </summary>
        /// <param name="value">The desired value of DataModified.</param>
        private void SetDataModified(bool value)
        {
            DataModified = value;
        }

        /// <summary>
        /// Returns the value of the DataModified.
        /// </summary>
        /// <returns>The value of the DataModified.</returns>
        private bool GetDataModified()
        {
            return DataModified;
        }
        #endregion

        /// <summary>
        /// Initialises a new instance of the <see cref="CreateUpdateXMLFileForm"/> class.
        /// </summary>
        public CreateUpdateXMLFileForm()
        {
            InitializeComponent();

            // Sets up the word count timer
            _wordCount = new Timer();

            _wordCount.Interval = 250;

            _wordCount.Enabled = false; // Don't need it straight away

            _wordCount.Tick += new EventHandler(WordCount_Tick);
        }

        /// <summary>
        /// Handles the Tick event of the WordCount control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void WordCount_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Handles the Click event of the kbtnBrowseForUpdateXMLFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnBrowseForUpdateXMLFile_Click(object sender, EventArgs e)
        {
            CommonFileDialog commonFileDialog = new CommonOpenFileDialog();

            commonFileDialog.Title = "Update XML File Location:";

            commonFileDialog.Filters.Add(new CommonFileDialogFilter("Update XML Files (*.xml)", "*.xml"));

            commonFileDialog.DefaultFileName = "Update.xml";

            commonFileDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();

            if (commonFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktxtUpdateXMLFilePath.Text = Path.GetFullPath(commonFileDialog.FileName);
            }
        }

        /// <summary>
        /// Handles the Click event of the kbtnBrowseForUpdatePackageFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnBrowseForUpdatePackageFile_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the kbtnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            QuitApplication();
        }

        /// <summary>
        /// Quits the application.
        /// </summary>
        private void QuitApplication()
        {
            if (GetDataModified())
            {
                if (KryptonMessageBox.Show("Data fields have been changed. Export now?", "Unsaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void CreateUpdateXMLFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            QuitApplication();
        }
    }
}