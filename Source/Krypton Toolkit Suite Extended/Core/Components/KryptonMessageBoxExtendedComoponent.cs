using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore
{
    public class KryptonMessageBoxExtendedComoponent : Component
    {
        #region Variables
        private bool? _showCtrlCopy;

        private bool _showDoNotShowAgainOption, _useTimeOutOption, _topMost;

        Font _messageboxTypeface;

        DialogResult _defaultTimeOutResponse;

        MessageBoxButtons _buttons;

        MessageBoxDefaultButton _defaultButton;

        MessageBoxIcon _icon;

        MessageBoxOptions _options;

        KryptonMessageBoxExtended.HelpInformation _helpInformation;

        IWin32Window _owner;

        string _messageBody, _title;
        #endregion

        #region Properties
        public bool? ShowControlCopy { get => _showCtrlCopy; set => _showCtrlCopy = value; }

        public Font MessageBoxTypeface { get => _messageboxTypeface; set => _messageboxTypeface = value; }

        public MessageBoxButtons MessageBoxButtons { get => _buttons; set => _buttons = value; }

        public MessageBoxDefaultButton MessageBoxDefaultButton { get => _defaultButton; set => _defaultButton = value; }

        public MessageBoxIcon MessageBoxIcon { get => _icon; set => _icon = value; }

        public MessageBoxOptions MessageBoxOptions { get => _options; set => _options = value; }

        public KryptonMessageBoxExtended.HelpInformation HelpInformation { get => _helpInformation; set => _helpInformation = value; }

        public IWin32Window Owner { get => _owner; set => _owner = value; }

        public string MessageBody { get => _messageBody; set => _messageBody = value; }

        public string Title { get => _title; set => _title = value; }
        #endregion

        #region Event
        public event EventHandler ShowMessageBox;
        #endregion

        #region Constructor
        public KryptonMessageBoxExtendedComoponent()
        {
            ShowControlCopy = false;

            MessageBoxTypeface = new Font("Segoe UI", 11f);

            MessageBoxButtons = MessageBoxButtons.OK;

            MessageBoxDefaultButton = MessageBoxDefaultButton.Button1;

            MessageBoxIcon = MessageBoxIcon.None;

            MessageBoxOptions = MessageBoxOptions.DefaultDesktopOnly;

            HelpInformation = null;

            Owner = null;

            MessageBody = "Dummy message text.";

            Title = "Dummy Title";
        }
        #endregion
    }
}