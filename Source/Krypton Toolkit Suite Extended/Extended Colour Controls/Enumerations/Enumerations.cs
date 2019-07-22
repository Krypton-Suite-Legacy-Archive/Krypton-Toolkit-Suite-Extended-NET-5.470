namespace ExtendedColourControls
{
    /// <summary>
    /// Specifies the style of a color cell border.
    /// </summary>
    public enum ColourCellBorderStyle
    {
        /// <summary>
        /// No border.
        /// </summary>
        None,

        /// <summary>
        /// A single line border.
        /// </summary>
        FixedSingle,

        /// <summary>
        /// A contrasting double border with a soft inner outline using the color of the cell.
        /// </summary>
        DoubleSoft
    }

    /// <summary>
    /// Specifies the sort order of colors
    /// </summary>
    public enum ColourCollectionSortOrder
    {
        /// <summary>
        /// Ordered by hue.
        /// </summary>
        Hue,

        /// <summary>
        /// Ordered by brightness.
        /// </summary>
        Brightness,

        /// <summary>
        /// Ordered by value
        /// </summary>
        Value
    }

    /// <summary>
    /// Specifies the style of a color bar
    /// </summary>
    public enum ColourBarStyle
    {
        /// <summary>
        /// A gradient from one color to another.
        /// </summary>
        TwoColour,

        /// <summary>
        /// A gradient between three colors.
        /// </summary>
        ThreeColour,

        /// <summary>
        /// A gadient between a user defined number of colors.
        /// </summary>
        Custom
    }

    /// <summary>
    /// Specifies the edit mode of a <see cref="ColourGrid" />.
    /// </summary>
    public enum ColourEditingMode
    {
        /// <summary>
        /// None. No editing is allowed.
        /// </summary>
        None,

        /// <summary>
        /// Only custom colors can be edited.
        /// </summary>
        CustomOnly,

        /// <summary>
        /// Custom or standard colors can be edited.
        /// </summary>
        Both
    }

    public enum ColourPalette
    {
        None,

        Named,

        Office2010,

        Paint,

        Standard,

        WebSafe,

        Standard256
    }

    /// <summary>
    /// Determines how the selected cell in a <see cref="KryptonColourGrid" /> control is rendered.
    /// </summary>
    public enum ColourGridSelectedCellStyle
    {
        /// <summary>
        /// The selected cell is drawn no differently to any other cell.
        /// </summary>
        None,

        /// <summary>
        /// The selected cell displays a basic outline and focus rectangle.
        /// </summary>
        Standard,

        /// <summary>
        /// The selected cell is displayed larger than other cells
        /// </summary>
        Zoomed
    }

    public enum ColourSource
    {
        None,

        Standard,

        Custom
    }

    /// <summary>
    /// Specifies the origin of a navigation operation
    /// </summary>
    public enum NavigationOrigin
    {
        /// <summary>
        /// Specifies the beginning
        /// </summary>
        Begin,

        /// <summary>
        /// Specifies the current position
        /// </summary>
        Current,

        /// <summary>
        /// Specifies the end
        /// </summary>
        End
    }

    public enum ColourSliderNubStyle
    {
        None,

        TopLeft,

        BottomRight
    }

    public enum RGBAChannel
    {
        Red,

        Green,

        Blue,

        Alpha
    }
}