using ExtendedControls.ExtendedToolkit.Utilities.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [ToolboxBitmap(typeof(ComboBox)), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class KryptonComboBoxToolStripMenuItem : ToolStripControlHostFixed
    {
        // Constants =========================================================

        // Attributes ========================================================

        // Properties ========================================================
        /// <summary>
        /// Gets the KryptonComboBox control.
        /// </summary>
        /// <value>The KryptonComboBox control.</value>
        [RefreshProperties(RefreshProperties.All),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox KryptonComboBoxControl
        {
            get { return Control as ComponentFactory.Krypton.Toolkit.KryptonComboBox; }
        }

        // Constructor ========================================================
        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonComboBoxToolStripMenuItem"/> class.
        /// </summary>
        public KryptonComboBoxToolStripMenuItem()
            : base(new ComponentFactory.Krypton.Toolkit.KryptonComboBox())
        {
            this.AutoSize = false;
        }

        /// <summary>
        /// Retrieves the size of a rectangular area into which a control can be fitted.
        /// </summary>
        /// <param name="constrainingSize">The custom-sized area for a control.</param>
        /// <returns>
        /// An ordered pair of type <see cref="T:System.Drawing.Size"></see> representing the width and height of a rectangle.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/><IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        public override Size GetPreferredSize(Size constrainingSize)
        {
            //return base.GetPreferredSize(constrainingSize);
            return this.KryptonComboBoxControl.GetPreferredSize(constrainingSize);
        }

        /// <summary>
        /// Subscribes events from the hosted control.
        /// </summary>
        /// <param name="control">The control from which to subscribe events.</param>
        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);

            //Add your code here to subsribe to Control Events
            ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)control).SelectedIndexChanged += new EventHandler(OnSelectedIndexChanged);
        }

        /// <summary>
        /// Unsubscribes events from the hosted control.
        /// </summary>
        /// <param name="control">The control from which to unsubscribe events.</param>
        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);

            //Add your code here to unsubscribe from control events.
            ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)control).SelectedIndexChanged -= new EventHandler(OnSelectedIndexChanged);
        }

        #region ... exposed properties ...
        public int SelectedIndex
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedIndex; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedIndex = value; }
        }

        public string SelectedText
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedText; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedText = value; }
        }

        public object SelectedValue
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedValue; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedValue = value; }
        }
        #endregion

        #region ... exposed events ...
        public event EventHandler SelectedIndexChanged;
        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexChanged != null)
                SelectedIndexChanged(this, e);
        }
        #endregion
    }
}