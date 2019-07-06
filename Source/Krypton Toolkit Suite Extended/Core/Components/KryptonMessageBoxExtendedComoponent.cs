using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore
{
    public class KryptonMessageBoxExtendedComoponent : Component
    {
        #region Variables
        private bool? _showCtrlCopy;

        private bool _showDoNotShowAgainOption, _useTimeOutOption;

        Font _messageboxTypeface;

        DialogResult _defaultTimeOutResponse;

        MessageBoxButtons _buttons;

        MessageBoxDefaultButton _defaultButton;

        MessageBoxIcon _icon;

        MessageBoxOptions _options;

        KryptonMessageBoxExtended.HelpInformation _helpInformation;

        IWin32Window _owner;
        #endregion

        #region Properties
        public bool? ShowControlCopy { get => _showCtrlCopy; set => _showCtrlCopy = value; }
        #endregion

        #region Event
        //public event ShowMessageBox;
        #endregion
    }
}