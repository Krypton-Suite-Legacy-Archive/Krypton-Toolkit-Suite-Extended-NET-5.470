using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.Design;
using GlobalUtilities.Classes;

namespace ExtendedControls.ExtendedToolkit.ToolstripControls
{
    /// <summary>
    /// A standard tool strip menu item control with UAC shield.
    /// Modified from the AeroSuite project.
    /// </summary>
    /// <remarks>
    /// The shield is extracted from the system with LoadImage if possible. Otherwise the shield will be enabled by sending the BCM_SETSHIELD Message to the control.
    /// If the operating system is not Windows Vista or higher, no shield will be displayed as there's no such thing as UAC on the target system -> the shield is obsolete.
    /// </remarks>
    [DisplayName("ToolStrip UAC Shield Menu Item")]
    [ToolboxBitmap(typeof(ToolStripMenuItem)), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public partial class ToolStripMenuItemUACSheld : ToolStripMenuItem
    {
        #region Variables
        private static bool? _isSystemAbleToLoadShield = null;

        private const int BCM_SETSHIELD = 0x160C;

        private GlobalMethods _globalMethods = new GlobalMethods();
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="ToolStripMenuItemUACSheld"/> class.
        /// </summary>
        public ToolStripMenuItemUACSheld() : base()
        {
            _globalMethods.CheckIfTargetPlatformIsSupported(true);

            if (_globalMethods.GetIsTargetPlatformSupported())
            {
                if (!_isSystemAbleToLoadShield.HasValue || _isSystemAbleToLoadShield.Value)
                {
                    try
                    {
                        var _icon = IconExtractor.LoadIcon(IconExtractor.IconType.SHIELD, SystemInformation.SmallIconSize);

                        if (_icon != null)
                        {
                            Image = _icon.ToBitmap();

                            TextImageRelation = TextImageRelation.ImageBeforeText;

                            ImageAlign = ContentAlignment.MiddleCenter;

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
                        MessageBox.Show($"Your platform is unsupported. Please contact the software vendor for details.\nFor reference, your system is running: { _globalMethods.GetOSFriendlyName() }.\nException message: { exc.Message }.", "Unsupported Software", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        _isSystemAbleToLoadShield = false;
                    }
                }

                //NativeMethods.SendMessage(Handle, BCM_SETSHIELD, IntPtr.Zero, new IntPtr(1));
            }
        }
        #endregion
    }
}