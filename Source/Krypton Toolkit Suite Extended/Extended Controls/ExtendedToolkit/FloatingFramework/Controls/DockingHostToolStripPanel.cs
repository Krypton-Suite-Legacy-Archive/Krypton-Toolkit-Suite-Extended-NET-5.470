using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.FloatingFramework.Controls
{
    [ToolboxBitmap(typeof(ToolStripPanel))]
    public partial class DockingHostToolStripPanel : ToolStripPanel
    {
        #region Variables
        // Internal member variables
        private Rectangle dockingRectangle;     // the default rectangle for receiving a floating ToolStrip
        private int defaultToolStripInferiorDimension; // the default value for the smaller of a ToolStrip's height or width
        private List<ToolStrip> dockedToolStrips;   // lists the toolstrips docked in this panel
        private Form mainForm;          // the main window of the application
        private KryptonForm _kryptonMainForm;
        #endregion

        #region Properties
        /// <summary>
        /// Gets a reference to the effective rectangular area taken by this panel.
        /// </summary>
        /// <remarks>
        /// When a DockingHostToolStripPanel contains no docked ToolStrips, its height/width is zero, depending on
        /// the panel's orientation.  We maintain this property to provide the 'effective' rectangle of a panel,
        /// which is identical to the ClientRectangle property, except if a panel contains no toolbars, the dimension
        /// which would normally be zero in ClientRectangle is in fact set to be identical to the value of the
        /// DefaultToolStripInferiorDimension property.  In order for a floating FloatingDockingToolStrip to snap 
        /// to a DockingHostToolStripPanel, the user must drag the toolbar such that the mouse cursor is within the 
        /// DockingRectangle
        /// </remarks>
        [Browsable(false)]
        public Rectangle DockingRectangle
        {
            get
            {
                return dockingRectangle;
            }
        }

        /// <summary>
        /// Gets a reference to the list of docked ToolStrips maintained by this panel dynamically.
        /// </summary>
        [Browsable(false)]
        public List<ToolStrip> DockedToolStrips
        {
            get
            {
                return dockedToolStrips;
            }
        }

        /// <summary>
        /// Gets or sets a reference to the default smaller dimension for ToolStrips hosted by this panel.
        /// </summary>
        /// <remarks>
        /// This dimension is the height of a horizontally-oriented ToolStrip or the
        /// width of a vertically-oriented ToolStrip.
        /// </remarks>
        [Browsable(true)]
        [Description("Specifies the default smaller dimension for ToolStrips hosted by this panel")]
        [DefaultValue(25)]
        public int DefaultToolStripInferiorDimension
        {
            get
            {
                return defaultToolStripInferiorDimension;
            }
            set
            {
                defaultToolStripInferiorDimension = value;
            }
        }
        #endregion

        #region Constructors
        public DockingHostToolStripPanel() : base()
        {
            defaultToolStripInferiorDimension = 25;

            dockedToolStrips = new List<ToolStrip>();

            mainForm = null;

            _kryptonMainForm = null;

            InitializeComponent();

            ContextMenuStrip = new ContextMenuStrip();

            ContextMenuStrip.Opening += new CancelEventHandler(ContextMenuStrip_Opening);
        }
        #endregion

        #region Event Handlers
        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            InitialiseToolStripContextMenu();
        }

        private void ToolStrip_Toggle(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            ToolStrip toolStrip = (ToolStrip)menuItem.Tag;

            toolStrip.Visible = !toolStrip.Visible;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Refreshes the DockingRectangle property to contain the outline of the area 
        /// available to floating ToolStrips.
        /// </summary>
        /// <remarks>
        /// The docking rectangle is based off of the parameters that ClientRectangle has
        /// when one ToolStrip is docked.
        /// </remarks>
        public void InitialiseDockingReceptionRectangle()
        {
            dockingRectangle = ClientRectangle;

            if (Orientation == Orientation.Horizontal && Height == 0)
            {
                dockingRectangle.Height = DefaultToolStripInferiorDimension;
            }
            else if (Orientation == Orientation.Vertical && dockingRectangle.Width == 0)
            {
                dockingRectangle.Width = DefaultToolStripInferiorDimension;
            }
        }

        /// <summary>
        /// Returns a value that indicates whether the specified point is located within the dockable area 
        /// of this panel.
        /// </summary>
        /// <param name="point">Point to test, in screen coordinates.</param>
        /// <returns></returns>
        public bool IsPointWithinMe(Point point)
        {
            // Convert the DockingRectangle into screen coordinates
            Rectangle rectangle = RectangleToScreen(DockingRectangle);

            // Assuming point is in screen coordinates, such as mouse position
            // Say whether our DockingRectangle contains the point
            return rectangle.Contains(point);
        }

        /// <summary>
        /// Returns a value specifying whether the indicated ToolStrip is docked in this panel.
        /// </summary>
        /// <param name="toolStrip">ToolStrip about which you want to inquire</param>
        /// <returns></returns>
        public bool IsToolStripDocked(ToolStrip toolStrip)
        {
            if (toolStrip == null)
            {
                throw new ArgumentException("ToolStrip provided to IsToolStripDocked was null.");
            }

            return dockedToolStrips.Contains(toolStrip);
        }

        public void AcceptDroppedFloatingToolStrip(ToolStrip toolStrip)
        {
            // TODO: Add implementation code here
        }

        public void InitialiseToolStripContextMenu()
        {
            ContextMenuStrip.Items.Clear();

            foreach (ToolStrip strip in dockedToolStrips)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(strip.Text, null, new EventHandler(ToolStrip_Toggle));

                menuItem.Tag = strip;

                menuItem.Checked = strip.Visible;

                ContextMenuStrip.Items.Add(menuItem);
            }
        }
        #endregion

        #region Overrides
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            if (e.Control is ToolStrip)
            {
                ToolStrip toolStrip = (ToolStrip)e.Control;

                toolStrip.GripStyle = ToolStripGripStyle.Visible;

                dockedToolStrips.Add(e.Control as ToolStrip);

                InitialiseToolStripContextMenu();
            }
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);

            if (e.Control is ToolStrip)
            {
                ToolStrip toolStrip = (ToolStrip)e.Control;

                toolStrip.GripStyle = ToolStripGripStyle.Hidden;    // only show grip in a docked ToolStrip

                dockedToolStrips.Remove(e.Control as ToolStrip);

                InitialiseToolStripContextMenu();
            }
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);

            InitialiseDockingReceptionRectangle();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            InitialiseDockingReceptionRectangle();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            InitialiseDockingReceptionRectangle();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);

            InitialiseDockingReceptionRectangle();
        }
        #endregion
    }
}