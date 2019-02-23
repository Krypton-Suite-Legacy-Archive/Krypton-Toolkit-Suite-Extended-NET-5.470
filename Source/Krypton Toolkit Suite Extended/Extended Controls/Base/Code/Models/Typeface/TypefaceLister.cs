using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace ExtendedControls.Base.Code.Models.Typeface
{
    public class TypefaceLister
    {
        #region Methods        
        /// <summary>
        /// Creates the typeface list.
        /// </summary>
        /// <param name="typefaces">The typefaces.</param>
        /// <param name="bold">if set to <c>true</c> [bold].</param>
        /// <param name="italic">if set to <c>true</c> [italic].</param>
        /// <param name="underline">if set to <c>true</c> [underline].</param>
        /// <param name="strikeout">if set to <c>true</c> [strikeout].</param>
        /// <param name="typefaceSize">Size of the typeface.</param>
        /// <param name="graphicsUnit">The graphics unit.</param>
        /// <param name="sampleText">The sample text.</param>
        /// <returns></returns>
        public Bitmap CreateTypefaceList(PrivateFontCollection typefaces, bool bold = false, bool italic = false, bool underline = false, bool strikeout = false, float typefaceSize = 8.25f, GraphicsUnit graphicsUnit = GraphicsUnit.Point, string sampleText = "Lorem Ipsum")
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            float x = 0, y = 0;

            FontStyle style = FontStyle.Regular;

            if (bold) style |= FontStyle.Bold;

            if (italic) style |= FontStyle.Italic;

            if (underline) style |= FontStyle.Underline;

            if (strikeout) style |= FontStyle.Strikeout;

            Font normal = new Font("Segoe UI", 12);

            Brush left = new SolidBrush(Color.Brown);

            int width = 0, height = 0, spacing = (int)(1.1 * typefaceSize);

            foreach (var typeface in typefaces.Families)
            {
                try
                {
                    Font newTypeface = new Font(typeface, typefaceSize, style, graphicsUnit);

                    Size size = TextRenderer.MeasureText(sampleText, newTypeface);

                    width = Math.Max(width, size.Width);

                    height += (size.Height > 12 ? size.Height : 12) + spacing;

                    size = TextRenderer.MeasureText(newTypeface.Name, normal);

                    x = Math.Max(x, size.Width + spacing);
                }
                catch (Exception)
                {

                }
            }

            width = (int)(1.2 * width);

            Bitmap bitmap = new Bitmap(width, height);

            using (Graphics gfx = Graphics.FromImage(bitmap))
            {
                gfx.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, width, height));

                foreach (var typeface in typefaces.Families)
                {
                    try
                    {
                        Font newTypeface = new Font(typeface, typefaceSize, style, graphicsUnit);

                        Size size = TextRenderer.MeasureText(sampleText, newTypeface);

                        gfx.DrawString(typeface.Name, normal, left, 0, y);

                        gfx.DrawString(sampleText, newTypeface, brush, x, y);

                        y += size.Height + spacing;
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            return bitmap;
        }

        /// <summary>
        /// Loads the typeface from directory.
        /// </summary>
        /// <param name="typefaceDirectory">The typeface directory.</param>
        /// <param name="includeSubDirectories">if set to <c>true</c> [include sub directories].</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">fontDirectory must be specified!</exception>
        /// <exception cref="DirectoryNotFoundException">Directory does not exist! " + typefaceDirectory</exception>
        public TypefaceCollection LoadTypefaceFromDirectory(string typefaceDirectory, bool includeSubDirectories = true)
        {
            if (string.IsNullOrEmpty(typefaceDirectory))
            {
                throw new ArgumentException("fontDirectory must be specified!");
            }

            if (!Directory.Exists(typefaceDirectory))
            {
                throw new DirectoryNotFoundException("Directory does not exist! " + typefaceDirectory);
            }

            TypefaceCollection endResult = new TypefaceCollection();

            SearchOption options = (includeSubDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

            string[] typefaceFiles = Directory.GetFiles(typefaceDirectory, "*.ttf", options);

            foreach (var typefaceFile in typefaceFiles)
            {
                try
                {
                    endResult.AddTypefaceToFile(typefaceFile);
                }
                catch (Exception)
                {
                }
            }

            typefaceFiles = Directory.GetFiles(typefaceDirectory, "*.otf", options);

            foreach (var typefaceFile in typefaceFiles)
            {
                try
                {
                    endResult.AddTypefaceToFile(typefaceFile);
                }
                catch (Exception)
                {

                }
            }

            return endResult;
        }

        public void LoadTypefaceFromDirectoryAsync(string typefaceDirectory, bool includeSubDirectories = true)
        {
            TypefaceCollection collection = null;

            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += new DoWorkEventHandler(delegate (object sender, DoWorkEventArgs e)
            {
                collection = LoadTypefaceFromDirectory(typefaceDirectory, includeSubDirectories);
            });

            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate (object sender, RunWorkerCompletedEventArgs e)
            {
                OnLoadTypefacesFromDirectoryCompleted(collection);
            });

            worker.RunWorkerAsync();
        }

        public event EventHandler<TypefaceListerEventArgs> LoadTypefacesFromDirectoryCompleted;

        protected virtual void OnLoadTypefacesFromDirectoryCompleted(TypefaceCollection collection)
        {
            if (LoadTypefacesFromDirectoryCompleted != null)
            {
                LoadTypefacesFromDirectoryCompleted(this, new TypefaceListerEventArgs() { Collection = collection });
            }
        }
        #endregion
    }

    public class TypefaceListerEventArgs : EventArgs
    {
        public TypefaceCollection Collection { get; set; }
    }
}