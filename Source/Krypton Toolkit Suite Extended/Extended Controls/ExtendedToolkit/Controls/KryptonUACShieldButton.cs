using ComponentFactory.Krypton.Toolkit;
using GlobalUtilities.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    /// <summary>
    /// A standard Krypton button control with UAC shield
    /// Modified from the AeroSuite project.
    /// </summary>
    /// <remarks>
    /// The shield is extracted from the system with LoadImage if possible. Otherwise the shield will be enabled by sending the BCM_SETSHIELD Message to the control.
    /// If the operating system is not Windows Vista or higher, no shield will be displayed as there's no such thing as UAC on the target system -> the shield is obsolete.
    /// </remarks>
    [DesignerCategory("Code")]
    [DisplayName("Krypton UAC Shield Button")]
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(KryptonButton))]
    public partial class KryptonUACShieldButton : KryptonButton
    {
        #region Variables
        private static bool? _isSystemAbleToLoadShield = null;

        private const int BCM_SETSHIELD = 0x160C;

        private GlobalMethods _globalMethods = new GlobalMethods();
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="KryptonUACShieldButton"/> class.
        /// </summary>
        public KryptonUACShieldButton() : base()
        {
            Size = new Size((int)(Width * 1.5), Height + 1);

            _globalMethods.CheckIfTargetPlatformIsSupported(true);

            if (_globalMethods.IsTargetPlatformSupported)
            {
                if (!_isSystemAbleToLoadShield.HasValue || _isSystemAbleToLoadShield.Value)
                {
                    try
                    {
                        var _icon = IconExtractor.LoadIcon(IconExtractor.IconType.SHIELD, SystemInformation.SmallIconSize);

                        if (_icon != null)
                        {
                            Values.Image = _icon.ToBitmap();

                            //this.TextImageRelation = TextImageRelation.ImageBeforeText;

                            //Values.Image.ImageAlign = ContentAlignment.MiddleCenter;

                            _isSystemAbleToLoadShield = true;

                            return;
                        }
                        else
                        {
                            _isSystemAbleToLoadShield = false;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Your platform is unsupported. Please contact the software vendor for details.", "Unsupported Software", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //FlatStyle = FlatStyle.System;

                NativeMethods.SendMessage(Handle, BCM_SETSHIELD, IntPtr.Zero, new IntPtr(1));
            }
        }
        #endregion
    }
}