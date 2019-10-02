namespace InformationBox.Enumerations
{
    /// <summary>
    /// Defines constant representing the parameters specified for the auto-close feature.
    /// </summary>
    public enum AutoCloseDefinedParameters
    {
        /// <summary>
        /// The button to use is defined.
        /// </summary>
        Button,

        /// <summary>
        /// Only the time to wait is defined.
        /// </summary>
        TimeOnly,

        /// <summary>
        /// The InformationBoxResult is defined.
        /// </summary>
        Result,
    }

    /// <summary>
    /// Specifies constants defining which source to use for the icon.
    /// </summary>
    internal enum IconType
    {
        /// <summary>
        /// Uses internal icons
        /// </summary>
        Internal,

        /// <summary>
        /// Uses an icon specified by the client.
        /// </summary>
        UserDefined,
    }
}