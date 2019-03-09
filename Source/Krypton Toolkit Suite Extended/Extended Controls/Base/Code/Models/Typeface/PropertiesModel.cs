using System.ComponentModel;

namespace ExtendedControls.Base.Code.Models.Typeface
{
    [DefaultPropertyAttribute("Name")]
    public class PropertiesModel
    {
        #region Properties
        [ReadOnly(true)]
        [CategoryAttribute("Properties")]
        //[DescriptionAttribute("Name")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        private string name;

        [ReadOnly(true)]
        [CategoryAttribute("Properties")]
        [DescriptionAttribute("Path to the typeface file.")]
        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }
        private string path;

        [ReadOnly(true)]
        [CategoryAttribute("Properties")]
        [DescriptionAttribute("Typeface type: TrueType, OpenType, ClearType, etc.")]
        public string TypefaceType
        {
            get { return this.fontType; }
            set { this.fontType = value; }
        }
        private string fontType;
        #endregion

        #region Style
        [ReadOnly(true)]
        [CategoryAttribute("Style")]
        //[DescriptionAttribute("Bold")]
        public bool Bold
        {
            get { return this.bold; }
            set { this.bold = value; }
        }
        private bool bold;

        [ReadOnly(true)]
        [CategoryAttribute("Style")]
        //[DescriptionAttribute("Italic")]
        public bool Italic
        {
            get { return this.italic; }
            set { this.italic = value; }
        }
        private bool italic;

        [ReadOnly(true)]
        [CategoryAttribute("Style")]
        //[DescriptionAttribute("Underline")]
        public bool Underline
        {
            get { return this.underline; }
            set { this.underline = value; }
        }
        private bool underline;

        [ReadOnly(true)]
        [CategoryAttribute("Style")]
        //[DescriptionAttribute("Strikethrough")]
        public bool Strikethrough
        {
            get { return this.strikethrough; }
            set { this.strikethrough = value; }
        }
        private bool strikethrough;

        [ReadOnly(true)]
        [CategoryAttribute("Style")]
        //[DescriptionAttribute("Size")]
        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        private string size;

        [ReadOnly(true)]
        [CategoryAttribute("Style")]
        //[DescriptionAttribute("Height")]
        public string LineHeight
        {
            get { return this.height; }
            set { this.height = value; }
        }
        private string height;
        #endregion

        #region Metrics
        [ReadOnly(true)]
        [CategoryAttribute("Metrics")]
        [DescriptionAttribute("Cell ascent in design units of the current font and style.")]
        public string Ascent
        {
            get { return this.ascent; }
            set { this.ascent = value; }
        }
        private string ascent;

        [ReadOnly(true)]
        [CategoryAttribute("Metrics")]
        [DescriptionAttribute("Cell descent in design units of the current font and style.")]
        public string Descent
        {
            get { return this.descent; }
            set { this.descent = value; }
        }
        private string descent;

        [ReadOnly(true)]
        [CategoryAttribute("Metrics")]
        [DescriptionAttribute("Height of the em square in font design units.")]
        public string EmHeight
        {
            get { return this.emHeight; }
            set { this.emHeight = value; }
        }
        private string emHeight;

        [ReadOnly(true)]
        [CategoryAttribute("Metrics")]
        [DescriptionAttribute("Line spacing in design units. Value represents the vertical distance between the base lines of two consecutive lines of text.")]
        public string LineSpacing
        {
            get { return this.lineSpacing; }
            set { this.lineSpacing = value; }
        }
        private string lineSpacing;
        #endregion
    }
}