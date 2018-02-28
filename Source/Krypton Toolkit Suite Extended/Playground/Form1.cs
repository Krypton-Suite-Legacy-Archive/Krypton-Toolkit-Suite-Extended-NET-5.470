using ExtendedControls.Base.Code;
using System.Diagnostics;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground
{
    public partial class Form1 : Form
    {
        UtilityMethods utilityMethods = new UtilityMethods();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kbtnUACTest.ProcessName = Process.GetCurrentProcess().ProcessName;

            tsmiUACTest.ProcessName= Process.GetCurrentProcess().ProcessName;

            if (utilityMethods.GetHasElevateProcessWithAdministrativeRights())
            {
                Text = Text + " (Administrator)";
            }

            kctb1.CueText = "Hello";

            kryptonCommandLinkVersion11.Note = "Hello";
        }
    }
}
