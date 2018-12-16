using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.FileDownloader
{
    public partial class FileDownloaderBasic : KryptonForm
    {
        #region Variables
        private string _downloadURL;

        private PaletteMode _paletteMode;

        private KryptonPalette _palette = new KryptonPalette();

        private WebClient _webClient;

        private Stopwatch _stopwatch = new Stopwatch();

        private Font _globalTypeface;
        #endregion

        #region Properties
        public string DownloadURL { get { return _downloadURL; } set { _downloadURL = value; } }

        public PaletteMode PaletteMode { get { return _paletteMode; } set { _paletteMode = value; } }

        public Font GlobalTypeface { get { return _globalTypeface; } set { _globalTypeface = value; } }
        #endregion

        #region Constructors
        public FileDownloaderBasic()
        {
            InitializeComponent();

            DownloadURL = null;

            PaletteMode = PaletteMode.Office2010Blue;
        }

        public FileDownloaderBasic(string downloadURL)
        {

        }

        public FileDownloaderBasic(PaletteMode mode)
        {

        }

        public FileDownloaderBasic(Font globalTypeface)
        {

        }

        public FileDownloaderBasic(string downloadURL, PaletteMode mode)
        {

        }

        public FileDownloaderBasic(string downloadURL, Font globalTypeface, PaletteMode mode)
        {

        }
        #endregion

        #region Methods
        public void DownloadFile(string urlAddress, string location)
        {
            using (_webClient = new WebClient())
            {
                _webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);

                _webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                Uri url = urlAddress.StartsWith("https://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);

                _stopwatch.Start();

                try
                {
                    _webClient.DownloadFileAsync(url, location);
                }
                catch (Exception exc)
                {
                    KryptonMessageBox.Show($"An unexpected error has occurred: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadTheme(string themeFile = "")
        {

        }

        public void SwitchTheme(PaletteMode mode)
        {
            switch (mode)
            {
                case PaletteMode.Global:
                    kMan.GlobalPaletteMode = PaletteModeManager.Custom;
                    break;
                case PaletteMode.ProfessionalSystem:
                    kMan.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                    break;
                case PaletteMode.ProfessionalOffice2003:
                    kMan.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
                    break;
                case PaletteMode.Office2007Blue:
                    kMan.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                    break;
                case PaletteMode.Office2007Silver:
                    kMan.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
                    break;
                case PaletteMode.Office2007Black:
                    kMan.GlobalPaletteMode = PaletteModeManager.Office2007Black;
                    break;
                case PaletteMode.Office2010Blue:
                    kMan.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
                case PaletteMode.Office2010Silver:
                    kMan.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
                    break;
                case PaletteMode.Office2010Black:
                    kMan.GlobalPaletteMode = PaletteModeManager.Office2010Black;
                    break;
                case PaletteMode.Office2013:
                    kMan.GlobalPaletteMode = PaletteModeManager.Office2013;
                    break;
                case PaletteMode.Office2013White:
                    kMan.GlobalPaletteMode = PaletteModeManager.Office2013White;
                    break;
                case PaletteMode.SparkleBlue:
                    kMan.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                    break;
                case PaletteMode.SparkleOrange:
                    kMan.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
                    break;
                case PaletteMode.SparklePurple:
                    kMan.GlobalPaletteMode = PaletteModeManager.SparklePurple;
                    break;
                case PaletteMode.Custom:
                    kMan.GlobalPaletteMode = PaletteModeManager.Custom;
                    break;
                default:
                    kMan.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
            }
        }
        #endregion

        #region Event Handlers
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            klblCurrentDownloadSpeed.Text = $"{ (e.BytesReceived / 1024d / _stopwatch.Elapsed.TotalSeconds).ToString("0.00") } KB/s";

            pbDownload.Value = e.ProgressPercentage;

            klblDownloadPercentage.Text = $"{ e.ProgressPercentage.ToString() }%";

            klblDownloaded.Text = $"{ (e.BytesReceived / 1024d / 1024d).ToString("0.00") } MB's / { (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00") } MB's";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            _stopwatch.Stop();

            if (e.Cancelled == true)
            {
                KryptonMessageBox.Show("Download has been canceled.");
            }
            else
            {
                KryptonMessageBox.Show("Download completed!");
            }
        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            SwitchTheme(PaletteMode);

            base.OnPaint(e);
        }
        #endregion
    }
}