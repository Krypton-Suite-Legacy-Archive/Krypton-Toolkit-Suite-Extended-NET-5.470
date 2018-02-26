using GlobalUtilities.Classes;
using System.Drawing;
using System.ComponentModel;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    /// <summary>
    /// A KryptonCommandLink button.
    /// </summary>
    /// <remarks>
    /// If used on Windows Vista or higher, the button will be a CommandLink: Basically the same functionality as a Button but looks different.
    /// </remarks>
    [DesignerCategory("Code")]
    [DisplayName("Krypton Command Link")]
    [Description("A Krypton Command Link Button.")]
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(KryptonButton))]
    public partial class KryptonCommandLinkVersion1 : KryptonButton
    {
        #region Variables
        private string _note = string.Empty;

        private GlobalMethods _globalMethods = new GlobalMethods();
        #endregion

        #region Constants
        private const int BS_COMMANDLINK = 0xE, BCM_SETNOTE = 0x1609;
        #endregion

        #region Properties
        /// <summary>
        /// Returns the default size of <see cref="KryptonCommandLinkVersion1"/>.
        /// </summary>
        /// <value>The size of <see cref="KryptonCommandLinkVersion1"/>.</value>
        protected override Size DefaultSize
        {
            get
            {
                // This can be changed if required.
                return new Size(180, 45);
            }
        }

        /// <summary>
        /// The note text shown below the main text.
        /// </summary>
        /// <value>
        /// A user defined note.
        /// </value>
        [Category("Appearance")]
        [Description("The note text shown below the main text.")]
        [Localizable(true)]
        [Bindable(true)]
        public virtual string Note
        {
            get
            {
                return _note;
            }

            set
            {
                _note = value;

                UpdateNote();
            }
        }

        public override RightToLeft RightToLeft
        {
            get
            {
                return base.RightToLeft;
            }

            set
            {
                base.RightToLeft = value;

                UpdateNote();
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="KryptonCommandLinkVersion1"/> class.
        /// </summary>
        public KryptonCommandLinkVersion1() : base()
        {

        }
        #endregion

        #region Protected Methods
        protected void UpdateNote()
        {
            if (_globalMethods.CheckIfTargetPlatformIsSupported(true))
            {
                if (_globalMethods.GetIsTargetPlatformSupported())
                {
                    NativeMethods.SendMessage(Handle, BCM_SETNOTE, IntPtr.Zero, _note);
                }
            }
        }
        #endregion
    }
}