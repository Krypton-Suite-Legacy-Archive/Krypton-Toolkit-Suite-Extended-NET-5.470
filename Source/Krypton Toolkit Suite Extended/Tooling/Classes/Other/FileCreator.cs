using EasyScintilla;
using System;
using System.IO;
using Tooling.Properties;

namespace Tooling.Classes.Other
{
    public class FileCreator
    {
        #region Variables

        #endregion

        #region Constructors
        public FileCreator()
        {

        }
        #endregion

        #region Methods
        public void GenerateNewFile(SimpleEditor editor)
        {
            editor.Text = string.Format(Resources.FreshFile, DateTime.Now.ToString());
        }

        /// <summary>
        /// Writes the colour file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="darkestColour">The darkest colour.</param>
        /// <param name="mediumColour">The medium colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        public void WriteColourFile(string filePath, string darkestColour, string mediumColour, string lightColour, string lightestColour)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            StreamWriter writer = new StreamWriter(filePath);

            writer.WriteLine($"Darkest Colour: ({ darkestColour })");

            writer.WriteLine($"Medium Colour: ({ mediumColour })");

            writer.WriteLine($"Light Colour: ({ lightColour })");

            writer.WriteLine($"Lightest Colour: ({ lightestColour })");

            writer.Flush();

            writer.Dispose();
        }
        #endregion
    }
}