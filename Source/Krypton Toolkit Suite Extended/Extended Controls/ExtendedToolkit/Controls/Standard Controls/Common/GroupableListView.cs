using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common
{
    [ToolboxBitmap(typeof(System.Windows.Forms.ListView)), ToolboxItem(false)]
    public class GroupableListView : System.Windows.Forms.ListView
    {
        #region Fields
        private ToolStrip tsGroups;
        private Image m_ToolStripImage = null;
        private ArrayList HeaderGroup = new ArrayList();
        private bool m_ShowGroupLabel = false;
        private string m_GroupLabelText = "Group by :";
        private bool m_GroupsGUIs = false;

        #endregion

        #region Properties
        [Category("Groups")]
        [Description("Show or not the ToolStrip to allow group items.")]
        public bool GroupsGUIs
        {
            get { return m_GroupsGUIs; }
            set { m_GroupsGUIs = value; Bind(); }
        }

        [Category("Groups")]
        [Description("The image to show on ToolStripButtons of the groups")]
        public Image ToolStripImage
        {
            get { return m_ToolStripImage; }
            set { m_ToolStripImage = value; CreateButtons(); }
        }

        [Category("Groups")]
        [Description("Show or hide the 'ShowGroup' label.")]
        public bool ShowGroupLabel
        {
            get { return m_ShowGroupLabel; }
            set { m_ShowGroupLabel = value; CreateButtons(); }
        }

        [Category("Groups")]
        [Description("The 'ShowGroup' label. (DEFAULT : 'Group by:'")]
        public string GroupLabelText
        {
            get { return m_GroupLabelText; }
            set { m_GroupLabelText = value; }
        }
        #endregion

        #region Constructors
        public GroupableListView()
        {
            InitializeComponent();
            Bind();
        }

        #endregion

        #region Overrides
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Bind();
            CreateButtons();
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            Bind();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Bind();

        }

        protected override void Dispose(bool disposing)
        {
            this.tsGroups.Dispose();
            base.Dispose(disposing);
        }

        public override DockStyle Dock
        {
            get { return base.Dock; }
            set
            {
                base.Dock = value;
                if (value == DockStyle.Fill || value == DockStyle.Top)
                {
                    tsGroups.Dock = DockStyle.Top;
                }
                else
                {
                    tsGroups.Dock = DockStyle.None;
                }
            }
        }

        #endregion

        #region Binding
        protected virtual void Bind()
        {
            if (m_GroupsGUIs)
            {
                if (this.tsGroups.Visible == false)
                    this.tsGroups.Visible = true;
                this.tsGroups.Parent = this.Parent;
                this.tsGroups.Location = new Point(this.Location.X, this.Location.Y - 25);
                if (tsGroups.Width != this.Width)
                    this.tsGroups.Width = this.Width;
            }
            else
            {
                if (this.tsGroups.Visible)
                    this.tsGroups.Visible = false;
            }
        }
        #endregion

        #region Group Methods

        #region Thread-Safe GroupBy Method
        private delegate void dGroupBy(ColumnHeader[] Headers);
        public void GroupBy(ColumnHeader[] Headers)
        {
            if (this.InvokeRequired)
            {
                dGroupBy d = new dGroupBy(GroupBy);
                this.Invoke(d, new object[] { Headers });
            }
            else
            {
                //code
                foreach (ListViewItem lvi in this.Items)
                {
                    string header = "";

                    foreach (ColumnHeader ch in Headers)
                    {
                        header += " " + lvi.SubItems[ch.Index].Text;
                    }

                    ListViewGroup group = new ListViewGroup(header);
                    ListViewGroup found = null;
                    foreach (ListViewGroup g in Groups)
                    {
                        if (g.Header == group.Header)
                        { found = g; break; }
                    }
                    if (found == null)
                    {
                        this.Groups.Add(group);
                        group.Items.Add(lvi);
                    }
                    else
                    {
                        found.Items.Add(lvi);
                    }


                }
            }
        }
        #endregion

        public virtual void GroupBy()
        {
            GroupBy((ColumnHeader[])HeaderGroup.ToArray(typeof(ColumnHeader)));
        }


        /// <summary>
        /// Method for generation ToolStrip Buttons on GroupBy ToolStrip
        /// </summary>
        private void CreateButtons()
        {

            this.tsGroups.Items.Clear();
            if (m_ShowGroupLabel)
            {
                ToolStripLabel tsl = new ToolStripLabel(m_GroupLabelText);
                tsGroups.Items.Add(tsl);
            }

            foreach (ColumnHeader C in this.Columns)
            {
                ToolStripButton tsb = new ToolStripButton(C.Text, m_ToolStripImage);
                tsb.Click += new EventHandler(tsb_Click);
                tsb.Tag = C;
                tsGroups.Items.Add(tsb);
            }
        }

        private void tsb_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = ((ToolStripButton)sender);

            tsb.Checked = !tsb.Checked;
            if (tsb.Checked)
            {
                HeaderGroup.Add((ColumnHeader)tsb.Tag);
            }
            else
            {
                HeaderGroup.Remove((ColumnHeader)tsb.Tag);
            }

            Thread th = new Thread(new ThreadStart(GroupBy));
            th.IsBackground = true;
            th.Start();
        }

        #endregion

        #region GeneratedCode
        private void InitializeComponent()
        {
            this.tsGroups = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // tsGroups
            // 
            this.tsGroups.AutoSize = false;
            this.tsGroups.Dock = System.Windows.Forms.DockStyle.None;
            this.tsGroups.Location = new System.Drawing.Point(0, 0);
            this.tsGroups.Name = "tsGroups";
            this.tsGroups.Size = new System.Drawing.Size(100, 25);
            this.tsGroups.TabIndex = 0;
            this.tsGroups.Text = "toolStrip1";
            this.ResumeLayout(false);

        }
        #endregion

    }
}