using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace KryptonBackupUtility.UX
{
    public partial class MainWindow : KryptonForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void kbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
