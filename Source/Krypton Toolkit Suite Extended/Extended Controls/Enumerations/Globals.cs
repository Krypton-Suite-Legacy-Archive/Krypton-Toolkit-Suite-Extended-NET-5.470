namespace ExtendedControls.Enumerations
{
    /// <summary>
    /// Messagebox icon
    /// </summary>
    public enum KryptonMessageBoxIcon
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
        WARNING = 6,
        /// <summary>
        /// A information icon.
        /// </summary>
        INFORMATION = 7,
        /// <summary>
        /// A custom icon (must be X x X).
        /// </summary>
        CUSTOM = 8,
        /// <summary>
        /// No icon set.
        /// </summary>
        NONE = 9
    }
	
	public enum KryptonMessageBoxButton
	{
		OK = 0,
		OKCANCEL = 1,
		YESNO = 2
		YESNOCANCEL = 3,
		RETRY = 4,
		ABORT = 5,
		RETRYABORT = 6,
		RETRYABORTCANCEL = 7
	}
	
	public enum KryptonMessageBoxMessageBoxResult
	{
		CANCEL = 0,
		NO = 1,
		NONE = 2,
		OK = 3,
		YES = 4
	}
}
