#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.ExtendedToolkit.FloatingFramework.UX;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.FloatingFramework.Controls
{
    [ToolboxBitmap(typeof(ToolStrip))]
    public partial class TearOffToolStrip : ToolStrip
    {
        #region Variables
        private DockingHostToolStripPanel topToolStripPanel, bottomToolStripPanel, leftToolStripPanel, rightToolStripPanel, lastDockedPanel;
        private bool disableMouseCapture, isFloating;
        #endregion

        #region Properties
        [Browsable(false)]
        public bool IsFloating
        {
            get
            {
                return this.isFloating;
            }
        }

        [Browsable(false)]
        public DockingHostToolStripPanel LastDockedPanel
        {
            get
            {
                return this.lastDockedPanel;
            }
        }

        [Browsable(true)]
        [Description("Determines whether the control is visible or hidden.")]
        public bool Visible
        {
            get
            {
                return base.Visible;
            }
            set
            {
                if (!this.isFloating)
                    base.Visible = value;
                else
                {
                    KryptonFloatingForm form = (KryptonFloatingForm)this.Parent;
                    if (form != null)
                    {
                        if (value == true) form.Show();
                        else if (value == false) form.Hide();
                    }
                }
            }
        }

        [Browsable(true)]
        [Description("Reference to the DockingHostToolStripPanel on left of the main form")]
        public DockingHostToolStripPanel TopToolStripPanel
        {
            get
            {
                return this.topToolStripPanel;
            }
            set
            {
                this.topToolStripPanel = value;
            }
        }

        [Browsable(true)]
        [Description("Reference to the DockingHostToolStripPanel on bottom of the main form")]
        public DockingHostToolStripPanel BottomToolStripPanel
        {
            get
            {
                return this.bottomToolStripPanel;
            }
            set
            {
                this.bottomToolStripPanel = value;
            }
        }

        [Browsable(true)]
        [Description("Reference to the DockingHostToolStripPanel on left of the main form")]
        public DockingHostToolStripPanel LeftToolStripPanel
        {
            get
            {
                return this.leftToolStripPanel;
            }
            set
            {
                this.leftToolStripPanel = value;
            }
        }

        [Browsable(true)]
        [Description("Reference to the DockingHostToolStripPanel on right of the main form")]
        public DockingHostToolStripPanel RightToolStripPanel
        {
            get
            {
                return this.rightToolStripPanel;
            }
            set
            {
                this.rightToolStripPanel = value;
            }
        }
        #endregion

        #region Constructors
        public TearOffToolStrip()
        {
            topToolStripPanel = null;

            bottomToolStripPanel = null;

            leftToolStripPanel = null;

            rightToolStripPanel = null;

            lastDockedPanel = null;

            isFloating = false;

            disableMouseCapture = false;

            InitializeComponent();
        }
        #endregion

        #region Overrides
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);

            if (!IsFloating)
            {
                MakeFloating();
            }
        }

        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);

            if (disableMouseCapture)
            {
                disableMouseCapture = false;

                return;
            }

            if (DesignMode)
            {
                return;
            }

            if (topToolStripPanel == null && bottomToolStripPanel == null && leftToolStripPanel == null && rightToolStripPanel == null)
            {
                return;
            }

            if (!topToolStripPanel.IsPointWithinMe(MousePosition) && !rightToolStripPanel.IsPointWithinMe(MousePosition) && !bottomToolStripPanel.IsPointWithinMe(MousePosition) && !leftToolStripPanel.IsPointWithinMe(MousePosition))
            {
                MakeFloating();
            }
            else if (topToolStripPanel.IsPointWithinMe(MousePosition) || bottomToolStripPanel.IsPointWithinMe(MousePosition) || leftToolStripPanel.IsPointWithinMe(MousePosition) || rightToolStripPanel.IsPointWithinMe(MousePosition))
            {
                if (topToolStripPanel.IsPointWithinMe(MousePosition))
                {
                    DockTo(topToolStripPanel);
                }
                else if (bottomToolStripPanel.IsPointWithinMe(MousePosition))
                {
                    DockTo(bottomToolStripPanel);
                }
                else if (leftToolStripPanel.IsPointWithinMe(MousePosition))
                {
                    DockTo(leftToolStripPanel);
                }
                else if (rightToolStripPanel.IsPointWithinMe(MousePosition))
                {
                    DockTo(rightToolStripPanel);
                }
            }
        }
        #endregion

        #region Methods
        public void MakeFloating()
        {
            DockingHostToolStripPanel parentPanel = new DockingHostToolStripPanel();

            if (parentPanel == null)
            {
                return;
            }

            disableMouseCapture = true;

            isFloating = true;

            Orientation orientation = Orientation;

            KryptonFloatingForm kryptonFloatingForm = new KryptonFloatingForm();

            kryptonFloatingForm.Text = Text;

            kryptonFloatingForm.Bounds = new Rectangle(MousePosition, Size);

            kryptonFloatingForm.Location = new Point(MousePosition.X + 25, MousePosition.Y + 25);

            lastDockedPanel = parentPanel;

            parentPanel.Controls.Remove(this);

            kryptonFloatingForm.Controls.Add(this);

            Stretch = true;

            Dock = DockStyle.Fill;

            GripStyle = ToolStripGripStyle.Hidden;

            kryptonFloatingForm.MouseCaptureChanged += new EventHandler(KryptonFloatingForm_MouseCaptureChanged);

            kryptonFloatingForm.DockingRequested += new EventHandler(KryptonFloatingForm_DockingRequested);

            kryptonFloatingForm.Show(parentPanel.Parent);
        }

        public void DockTo(DockingHostToolStripPanel panel)
        {
            if (!IsFloating)
            {
                return;
            }

            if ((panel == null) || (Parent is ToolStripPanel))
            {
                return;
            }

            isFloating = false;

            KryptonFloatingForm kryptonFloatingForm = (KryptonFloatingForm)Parent;

            kryptonFloatingForm.Hide();

            Stretch = false;

            GripStyle = ToolStripGripStyle.Hidden;

            kryptonFloatingForm.Controls.Remove(this);

            panel.Controls.Add(this);

            kryptonFloatingForm.Close();
        }
        #endregion

        #region Event Handlers
        private void KryptonFloatingForm_DockingRequested(object sender, EventArgs e)
        {
            if (lastDockedPanel == null)
            {
                lastDockedPanel = topToolStripPanel;
            }

            DockTo(lastDockedPanel);
        }

        private void KryptonFloatingForm_MouseCaptureChanged(object sender, EventArgs e)
        {
            OnMouseCaptureChanged(e);
        }

        private void TearOffToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            disableMouseCapture = true;
        }
        #endregion
    }
}