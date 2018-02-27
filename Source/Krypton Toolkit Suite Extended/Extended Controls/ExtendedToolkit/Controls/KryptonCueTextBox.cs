using ComponentFactory.Krypton.Toolkit;
using GlobalUtilities.Classes;
using System;
using System.ComponentModel;
using System.Drawing;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    /// <summary>
    /// A KryptonTextBox with cue banner support.
    /// </summary>
    /// <remarks>
    /// A cue banner is the text that is shown when the KryptonTextBox is empty.
    /// </remarks>
    [DesignerCategory("Code")]
    [DisplayName("Cue KryptonTextBox")]
    [Description("A KryptonTextBox with cue banner support.")]
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(KryptonTextBox))]
    public partial class KryptonCueTextBox : KryptonTextBox
    {
        #region Variables
        private bool _retainCueText = false;

        private string _cueText = string.Empty;

        private GlobalMethods _globalMethods = new GlobalMethods();
        #endregion

        #region Constants
        private const int EM_SETCUEBANNER = 0x1501;
        #endregion

        #region Properties
        /// <summary>
        /// Determines if the cue banner is shown even when the textbox is focused.
        /// </summary>
        /// <value>
        /// The cue.
        /// </value>
        [DefaultValue(false)]
        [Category("Appearance")]
        [Description("Determines if the cue banner is shown even when the textbox is focused.")]
        [Localizable(true)]
        [Bindable(true)]
        public virtual bool RetainCueText
        {
            get
            {
                return _retainCueText;
            }

            set
            {
                _retainCueText = value;

                UpdateCueText();
            }
        }

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
        /// Initialises a new instance of the <see cref="KryptonCueTextBox"/> class.
        /// </summary>
        public KryptonCueTextBox() : base()
        {
            UpdateCueText();
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Raises the <see cref="E:HandleCreated" /> event.
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
                    NativeMethods.SendMessage(Handle, EM_SETCUEBANNER, (RetainCueText && _globalMethods.GetIsTargetPlatformSupported()) ? new IntPtr(1) : IntPtr.Zero, CueText);
                }
            }
        }
        #endregion
    }
}