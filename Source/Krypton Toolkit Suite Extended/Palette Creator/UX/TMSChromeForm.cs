using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletteCreator.UX
{
    public partial class TMSChromeForm : Form
    {

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="TMSChromeForm"/> class.
        /// </summary>
        public TMSChromeForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Sets the override tool strip renderer.
        /// </summary>
        /// <value>
        /// The override tool strip renderer.
        /// </value>
        public ToolStripRenderer OverrideToolStripRenderer
        {
            set
            {
                tmsMenuStrip.Renderer = value;

                tmsStatusStrip.Renderer = value;

                tmsToolStrip.Renderer = value;

                tmsToolStripContainer.TopToolStripPanel.Renderer = value;

                tmsToolStripContainer.BottomToolStripPanel.Renderer = value;

                tmsToolStripContainer.LeftToolStripPanel.Renderer = value;

                tmsToolStripContainer.RightToolStripPanel.Renderer = value;

                tmsToolStripContainer.ContentPanel.Renderer = value;
            }
        }
        #endregion
    }
}
