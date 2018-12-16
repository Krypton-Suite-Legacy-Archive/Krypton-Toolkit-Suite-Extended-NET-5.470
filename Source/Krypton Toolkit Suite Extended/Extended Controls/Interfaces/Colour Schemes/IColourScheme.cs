using System.Drawing;

namespace ExtendedControls.Interfaces.ColourSchemes
{
    public interface IColourScheme
    {
        /// <summary>
        /// Gets the colours.
        /// </summary>
        /// <value>
        /// The colours.
        /// </value>
        Color[] Colours { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; }
    }
}