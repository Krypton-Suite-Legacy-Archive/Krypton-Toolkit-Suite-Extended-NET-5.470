using System;
using System.ComponentModel;
using System.Drawing;

using ComponentFactory.Krypton.Toolkit;

using Core.Classes;
using GlobalUtilities.Classes;

namespace KryptonExtendedToolkit.ExtendedToolkit.Controls
{
    /// <summary>
    /// A KryptonComboBox with cue banner support.
    /// </summary>
    /// <remarks>
    /// A cue banner is the text that is shown when the KryptonComboBox does not have a selected item.
    /// </remarks>
    [DesignerCategory("Code")]
    [DisplayName("Cue KryptonComboBox")]
    [Description("A KryptonComboBox with cue banner support.")]
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(KryptonComboBox))]
    public partial class KryptonCueComboBox : KryptonComboBox
    {
        #region Variables
        private string _cueText = string.Empty;

        private GlobalMethods _globalMethods = new GlobalMethods();
        #endregion

        #region Constants
        private const int CB_SETCUEBANNER = 0x1703;
        #endregion

        #region Properties
        /// <summary>
        /// The text shown on the Cue Banner.
        /// </summary>
        /// <value>
        /// The cue.
        /// </value>
        [Category("Appearance")]
        [Description("The text shown on the Cue Banner.")]
        [Localizable(true)]
        [Bindable(true)]
        public virtual string CueText
        {
            get
            {
                return _cueText;
            }

            set
            {
                _cueText = value;

                UpdateCueText();
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="KryptonCueComboBox"/> class.
        /// </summary>
        public KryptonCueComboBox() : base()
        {
            UpdateCueText();
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Raises the <see cref="OnHandleCreated(EventArgs)"/> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            UpdateCueText();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates the cue text.
        /// </summary>
        private void UpdateCueText()
        {
            if (IsHandleCreated && _globalMethods.CheckIfTargetPlatformIsSupported(true))
            {
                if (_globalMethods.GetIsTargetPlatformSupported())
                {
                    GlobalNativeMethods.SendMessage(Handle, CB_SETCUEBANNER, IntPtr.Zero, _cueText);
                }
            }
        }
        #endregion
    }
}