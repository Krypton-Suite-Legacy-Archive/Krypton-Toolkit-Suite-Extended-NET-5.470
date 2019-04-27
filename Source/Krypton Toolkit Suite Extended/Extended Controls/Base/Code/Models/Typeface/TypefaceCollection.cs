using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;

namespace ExtendedControls.Base.Code.Models.Typeface
{
    public class TypefaceCollection : List<TypefaceModel>
    {
        #region Variables
        private FontFamily[] _families = new FontFamily[0];
        private PrivateFontCollection _privateFontCollection = new PrivateFontCollection();
        #endregion

        #region Properties        
        /// <summary>
        /// Gets the collection.
        /// </summary>
        /// <value>
        /// The collection.
        /// </value>
        public PrivateFontCollection Collection { get => _privateFontCollection; }

        /// <summary>
        /// Gets the families.
        /// </summary>
        /// <value>
        /// The families.
        /// </value>
        public FontFamily[] Families { get => _families; }
        #endregion

        #region Methods        
        /// <summary>
        /// Adds the typeface to file.
        /// </summary>
        /// <param name="typefaceFile">The typeface file.</param>
        public void AddTypefaceToFile(string typefaceFile)
        {
            _privateFontCollection.AddFontFile(typefaceFile);

            foreach (var family in _privateFontCollection.Families)
            {
                if (!ContainsTypefaceFamily(family))
                {
                    TypefaceModel model = new TypefaceModel();

                    model.Typeface = family;

                    model.TypefaceName = family.Name;

                    model.TypefaceFilePath = typefaceFile;

                    Add(model);
                }
            }

            _families = _privateFontCollection.Families;
        }

        /// <summary>
        /// Clears the typeface files.
        /// </summary>
        public void ClearTypefaceFiles()
        {
            _privateFontCollection.Dispose();

            _privateFontCollection = null;

            _privateFontCollection = new PrivateFontCollection();

            _families = new FontFamily[0];

            Clear();
        }

        /// <summary>
        /// Determines whether [contains typeface family] [the specified family].
        /// </summary>
        /// <param name="family">The family.</param>
        /// <returns>
        ///   <c>true</c> if [contains typeface family] [the specified family]; otherwise, <c>false</c>.
        /// </returns>
        public bool ContainsTypefaceFamily(FontFamily family)
        {
            foreach (var item in _families)
            {
                if (item.GetHashCode() == family.GetHashCode())
                {
                    return true;
                }
            }

            return false;
        }
        #endregion
    }
}