namespace ExtendedControls.ExtendedToolkit.Messageboxes.Enumerations
{
    /// <summary>
    /// The krypton messagebox border style.
    /// </summary>
    public enum KryptonMessageBoxExtendedBorderType
    {
        /// <summary>
        /// No border (not recommended).
        /// </summary>
        NONE = 0,
        /// <summary>
        /// A fixed single border.
        /// </summary>
        FIXEDSINGLE = 1,
        /// <summary>
        /// A fixed 3D border.
        /// </summary>
        FIXED3D = 2,
        /// <summary>
        /// A fixed dialog border.
        /// </summary>
        FIXEDDIALOG = 3,
        /// <summary>
        /// A sizable border.
        /// </summary>
        SIZABLE = 4,
        /// <summary>
        /// A fixed tool window border.
        /// </summary>
        FIXEDTOOLWINDOW = 5,
        /// <summary>
        /// A sizable tool window border.
        /// </summary>
        SIZABLETOOLWINDOW = 6
    }

    /// <summary>
    /// Krypton messagebox extended palette theme.
    /// </summary>
    public enum KryptonMessageBoxExtendedThemeType
    {
        CUSTOM = 0,
        OFFICE2013 = 1,
        OFFICE2013WHITE = 2,
        OFFICE2010BLACK = 3,
        OFFICE2010BLUE = 4,
        OFFICE2010SILVER = 5,
        OFFICE2007BLACK = 6,
        OFFICE2007BLUE = 7,
        OFFICE2007SILVER = 8,
        PROFESSIONALOFFICE2003 = 9,
        PROFESSIONALSYSTEM = 10,
        SPARKLEBLUE = 11,
        SPARKLEORANGE = 12,
        SPARKLEPURPLE = 13
    }

    /// <summary>
    /// 
    /// </summary>
    public enum KryptonMessageBoxExtendedApplicationIconVisibility
    {
        /// <summary>
        /// Icon is visible
        /// </summary>
        VISIBLE = 0,
        /// <summary>
        /// Icon is hidden
        /// </summary>
        HIDDEN = 1
    }

    /// <summary>
    /// Messagebox icon
    /// </summary>
    public enum KryptonMessageBoxExtendedIcon
    {
        /// <summary>
        /// A hand icon.
        /// </summary>
        HAND = 0,
        /// <summary>
        /// A question icon.
        /// </summary>
        QUESTION = 1,
        /// <summary>
        /// A exclamation icon.
        /// </summary>
        EXCLAMATION = 2,
        /// <summary>
        /// A asterisk icon.
        /// </summary>
        ASTERISK = 3,
        /// <summary>
        /// A stop icon.
        /// </summary>
        STOP = 4,
        /// <summary>
        /// A error icon.
        /// </summary>
        ERROR = 5,
        /// <summary>
        /// A warning icon.
        /// </summary>
        //WARNING = 6,
        /// <summary>
        /// A information icon.
        /// </summary>
        INFORMATION = 6,
        /// <summary>
        /// A custom icon (must be 64 x 64).
        /// </summary>
        CUSTOM = 7,
        /// <summary>
        /// A critical icon.
        /// </summary>
        CRITICAL = 8,
        /// <summary>
        /// The ok icon.
        /// </summary>
        OK = 9,
        /// <summary>
        /// No icon set.
        /// </summary>
        NONE = 10
    }

    /// <summary>
    /// 
    /// </summary>
    public enum KryptonMessageBoxExtendedButtons
    {
        /// <summary>
        /// The ok button.
        /// </summary>
        OK = 0,
        /// <summary>
        /// The ok cancel buttons.
        /// </summary>
        OKCANCEL = 1,
        /// <summary>
        /// The yes no buttons.
        /// </summary>
        YESNO = 2,
        YESNOCANCEL = 3,
        RETRY = 4,
        ABORT = 5,
        RETRYABORT = 6,
        RETRYABORTCANCEL = 7,
        CUSTOM = 8
    }

    public enum KryptonMessageBoxExtendedResult
    {
        CANCEL = 0,
        NO = 1,
        NONE = 2,
        OK = 3,
        YES = 4,
        YESNO = 5,
        RETRY = 6,
        ABORT = 7,
        RETRYABORT = 8,
        RETRYABORTCANCEL = 9,
        CUSTOM = 10
    }

    public enum KryptonMessageBoxExtendedDefaultButton
    {
        BUTTON1 = 0,
        BUTTON2 = 256,
        BUTTON3 = 512
    }

    public enum KryptonMessageBoxExtendedBoxOptions
    {

    }

    public enum KryptonMessageBoxExtendedBoxButtonCount
    {
        ONE = 0,
        TWO = 1,
        THREE = 2
    }

    public enum CheckedState
    {
        CHECKED = 0,
        UNCHECKED = 1,
        INTERMEDIATE = 3
    }
}