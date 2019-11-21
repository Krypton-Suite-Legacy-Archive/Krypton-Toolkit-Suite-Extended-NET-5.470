#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Exceptions;
using ExtendedControls.Base.Code.Models.Typeface;
using System;
using System.Drawing;
using System.IO;

namespace ExtendedControls.ExtendedToolkit.SystemDialogs.Typeface
{
    public class TypefaceProperties : KryptonForm
    {
        #region Designer Code
        private Controls.KryptonControls.KryptonPropertyGrid kpgTypefaceProperties;

        private void InitializeComponent()
        {
            this.kpgTypefaceProperties = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid();
            this.SuspendLayout();
            // 
            // kpgTypefaceProperties
            // 
            this.kpgTypefaceProperties.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgTypefaceProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpgTypefaceProperties.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kpgTypefaceProperties.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kpgTypefaceProperties.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgTypefaceProperties.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpgTypefaceProperties.Location = new System.Drawing.Point(0, 0);
            this.kpgTypefaceProperties.Name = "kpgTypefaceProperties";
            this.kpgTypefaceProperties.Size = new System.Drawing.Size(385, 529);
            this.kpgTypefaceProperties.TabIndex = 0;
            // 
            // TypefaceProperties
            // 
            this.ClientSize = new System.Drawing.Size(385, 529);
            this.Controls.Add(this.kpgTypefaceProperties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TypefaceProperties";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Typeface Properties";
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables

        #endregion

        #region Constructors
        public TypefaceProperties()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        public void LoadTypeface(Font typeface, TypefaceModel model)
        {
            PropertiesModel propertiesModel = new PropertiesModel();

            if (model != null)
            {
                propertiesModel.Name = model.TypefaceName;

                propertiesModel.Path = model.TypefaceFilePath;

                propertiesModel.TypefaceType = GetTypefaceType(model.TypefaceFilePath);
            }

            if (typeface != null)
            {
                try
                {
                    string unit = GetUnitName(typeface.Unit);

                    if (unit != null) unit = " " + unit;

                    propertiesModel.Name = typeface.Name;

                    propertiesModel.Bold = typeface.Bold;

                    propertiesModel.Italic = typeface.Italic;

                    propertiesModel.Underline = typeface.Underline;

                    propertiesModel.Strikethrough = typeface.Strikeout;

                    propertiesModel.Size = typeface.Size + unit;

                    propertiesModel.LineHeight = typeface.Height + " px";

                    propertiesModel.Ascent = typeface.FontFamily.GetCellAscent(typeface.Style).ToString();

                    propertiesModel.Descent = typeface.FontFamily.GetCellDescent(typeface.Style).ToString();

                    propertiesModel.LineSpacing = typeface.FontFamily.GetLineSpacing(typeface.Style).ToString();

                    propertiesModel.EmHeight = typeface.FontFamily.GetEmHeight(typeface.Style).ToString();
                }
                catch (Exception exc)
                {
                    ExceptionHandler.CaptureException(exc);
                }
            }

            kpgTypefaceProperties.SelectedObject = propertiesModel;
        }

        private string GetUnitName(GraphicsUnit unit)
        {
            switch (unit)
            {
                case GraphicsUnit.Pixel:
                    return "px";

                case GraphicsUnit.Point:
                    return "pt";

                case GraphicsUnit.Millimeter:
                    return "mm";

                case GraphicsUnit.Inch:
                    return "in";

                default:
                    return null;
            }
        }

        private string GetTypefaceType(string path)
        {
            if (string.IsNullOrEmpty(path)) return null;

            string ext = Path.GetExtension(path).ToLower();

            switch (ext)
            {
                case ".ttf":
                    return "TrueType (*.ttf)";

                case ".otf":
                    return "OpenType (*.otf)";

                default:
                    return ext;
            }
        }
        #endregion
    }
}