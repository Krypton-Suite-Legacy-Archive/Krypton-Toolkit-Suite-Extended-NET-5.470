#region License and Copyright
/*
 
Copyright (c) Guifreaks - Jacob Mesu
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the Guifreaks nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

*/
#endregion


using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.NaviSuite.Common.Classes
{
    public class SmallImageIndexConverter : ImageIndexConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                int result = -1;
                string text = value.ToString();
                if (!text.Equals("(none)") && !(string.IsNullOrEmpty(text)))
                {
                    int.TryParse(text, out result);
                }
                return result;
            }
            else
                return null;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is Int32)
            {
                int number = (int)value;
                if (number >= 0)
                    return number.ToString();
                else
                    return "(none)";
            }
            else
                return null;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            ImageList imageList = null;

            PropertyDescriptorCollection PropertyCollection
                              = TypeDescriptor.GetProperties(context.Instance);

            PropertyDescriptor property;
            if ((property = PropertyCollection.Find("SmallImages", false)) != null)
                imageList = (ImageList)property.GetValue(context.Instance);

            if (imageList != null)
            {
                ArrayList imgIdx = new ArrayList();
                imgIdx.Add(-1);
                for (int i = 0; i < imageList.Images.Count; i++)
                {
                    imgIdx.Add(i);
                }

                return new StandardValuesCollection(imgIdx);
            }

            return new StandardValuesCollection(new int[1] { -1 });
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            if (context.Instance != null)
                return true;
            else
                return false;
        }

    }

}