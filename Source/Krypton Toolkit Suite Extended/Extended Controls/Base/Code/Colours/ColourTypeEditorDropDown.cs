#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.ExtendedToolkit.Controls.Colours;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace ExtendedControls.Base.Code.Colours
{
    public class ColourTypeEditorDropDown : UITypeEditor
    {
        private ColourUI _colourUI;

        public override object EditValue(
            ITypeDescriptorContext context,
            IServiceProvider provider,
            object value)
        {
            if (provider != null)
            {
                var edSvc =
                    (IWindowsFormsEditorService)provider.GetService(
                    typeof(IWindowsFormsEditorService));

                if (edSvc == null)
                {
                    return value;
                }
                if (_colourUI == null)
                {
                    _colourUI = new ColourUI(this);
                }
                _colourUI.Start(edSvc, value);
                edSvc.DropDownControl(_colourUI);

                // --

                if ((_colourUI.Value != null) && (((Color)_colourUI.Value) != Color.Empty))
                {
                    value = _colourUI.Value;
                }

                _colourUI.End();
            }
            return value;
        }

        public override UITypeEditorEditStyle GetEditStyle(
            ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override bool GetPaintValueSupported(
            ITypeDescriptorContext context)
        {
            return true;
        }

        public override void PaintValue(
            PaintValueEventArgs e)
        {
            if (e.Value is Color)
            {
                var color = (Color)e.Value;
                var brush = new SolidBrush(color);
                e.Graphics.FillRectangle(brush, e.Bounds);
                brush.Dispose();
            }
        }
    }
}