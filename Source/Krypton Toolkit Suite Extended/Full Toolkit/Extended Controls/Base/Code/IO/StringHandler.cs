using ComponentFactory.Krypton.Toolkit;
using System.Collections.Generic;
using System.Collections.Specialized;
using ToolkitSettings.Classes.PaletteExplorer;

namespace ExtendedControls.Base.Code.IO
{
    public class StringHandler
    {
        #region Constructor
        public StringHandler()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Sorts the string collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <returns></returns>
        public static StringCollection SortStringCollection(StringCollection collection)
        {
            List<string> sortedList = new List<string>();

            StringCollection result = new StringCollection();

            foreach (string item in collection)
            {
                sortedList.Add(item);
            }

            sortedList.Sort();

            foreach (string item in sortedList)
            {
                result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// Reverses the string collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <returns></returns>
        public static StringCollection ReverseStringCollection(StringCollection collection)
        {
            List<string> reversedList = new List<string>();

            StringCollection result = new StringCollection();

            foreach (string item in collection)
            {
                reversedList.Add(item);
            }

            reversedList.Reverse();

            foreach (string item in reversedList)
            {
                result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// Propagates the colour selector.
        /// </summary>
        /// <param name="selector">The selector.</param>
        /// <param name="sorted">if set to <c>true</c> [sorted].</param>
        public static void PropagateColourSelector(KryptonComboBox selector, bool sorted = true)
        {
            ColourCollectionStringSettingsManager manager = new ColourCollectionStringSettingsManager();

            if (sorted)
            {
                foreach (string item in SortStringCollection(manager.GetColourStringCollectionValues()))
                {
                    selector.AutoCompleteCustomSource.Add(item);

                    selector.Items.Add(item);
                }
            }
            else
            {
                foreach (string item in ReverseStringCollection(manager.GetColourStringCollectionValues()))
                {
                    selector.AutoCompleteCustomSource.Add(item);

                    selector.Items.Add(item);
                }
            }
        }
        #endregion
    }
}