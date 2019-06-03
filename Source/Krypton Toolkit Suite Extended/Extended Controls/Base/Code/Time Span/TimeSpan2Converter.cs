using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace System
{
    /// <summary>
    /// Type converter for <see cref="TimeSpan2"/> objects.
    /// </summary>
    public class TimeSpan2Converter : TypeConverter
    {
        /// <summary>
        /// Returns whether this converter can convert an object of the given type to the type of this converter, using the specified context.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
        /// <param name="sourceType">A <see cref="T:System.Type"/> that represents the type you want to convert from.</param>
        /// <returns>
        /// true if this converter can perform the conversion; otherwise, false.
        /// </returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) => sourceType == typeof(string) ||
                TypeDescriptor.GetConverter(sourceType).CanConvertTo(typeof(long)) ||
                base.CanConvertFrom(context, sourceType);

        /// <summary>
        /// Returns whether this converter can convert the object to the specified type, using the specified context.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
        /// <param name="destinationType">A <see cref="T:System.Type"/> that represents the type you want to convert to.</param>
        /// <returns>
        /// true if this converter can perform the conversion; otherwise, false.
        /// </returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) => destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);

        /// <summary>
        /// Converts the given object to the type of this converter, using the specified context and culture information.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
        /// <param name="culture">The <see cref="T:System.Globalization.CultureInfo"/> to use as the current culture.</param>
        /// <param name="value">The <see cref="T:System.Object"/> to convert.</param>
        /// <returns>
        /// An <see cref="T:System.Object"/> that represents the converted value.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException">
        /// The conversion cannot be performed.
        /// </exception>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var sval = value as string;
            if (sval != null)
            {
                if (string.IsNullOrEmpty(sval))
                    return TimeSpan2.Zero;

                var fi = new TimeSpan2FormatInfo(culture);
                TimeSpan ts;
                if (fi.TryParse(sval, null, out ts))
                    return (TimeSpan2)ts;
            }
            try { var l = Convert.ToInt64(value, CultureInfo.CurrentUICulture); return new TimeSpan2(l); }
            catch { }
            return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// Converts the given value object to the specified type, using the specified context and culture information.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
        /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo"/>. If null is passed, the current culture is assumed.</param>
        /// <param name="value">The <see cref="T:System.Object"/> to convert.</param>
        /// <param name="destinationType">The <see cref="T:System.Type"/> to convert the <paramref name="value"/> parameter to.</param>
        /// <returns>
        /// An <see cref="T:System.Object"/> that represents the converted value.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// The <paramref name="destinationType"/> parameter is null.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        /// The conversion cannot be performed.
        /// </exception>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is TimeSpan)
                value = new TimeSpan2((TimeSpan)value);
            if (value is TimeSpan2)
            {
                if (destinationType == typeof(InstanceDescriptor))
                {
                    var ts = (TimeSpan2)value;
                    /*if (ts.IsZero)
					{
						System.Reflection.FieldInfo field = outType.GetField("Zero");
						if (field != null)
							return new InstanceDescriptor(field, new object[0]);
					}
					else
					{*/
                    if (ts.Ticks % TimeSpan.TicksPerSecond == 0)
                    {
                        var constructor = typeof(TimeSpan2).GetConstructor(new[] { typeof(int), typeof(int), typeof(int), typeof(int) });
                        if (constructor != null)
                            return new InstanceDescriptor(constructor, new object[] { ts.Days, ts.Hours, ts.Minutes, ts.Seconds });
                    }
                    else
                    {
                        var constructor = typeof(TimeSpan2).GetConstructor(new[] { typeof(long) });
                        if (constructor != null)
                            return new InstanceDescriptor(constructor, new object[] { ts.Ticks });
                    }
                }

                try { return Convert.ChangeType(value, destinationType, CultureInfo.CurrentUICulture); }
                catch { }
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        /// <summary>
        /// Creates an instance of the type that this <see cref="T:System.ComponentModel.TypeConverter"/> is associated with, using the specified context, given a set of property values for the object.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
        /// <param name="propertyValues">An <see cref="T:System.Collections.IDictionary"/> of new property values.</param>
        /// <returns>
        /// An <see cref="T:System.Object"/> representing the given <see cref="T:System.Collections.IDictionary"/>, or null if the object cannot be created. This method always returns null.
        /// </returns>
        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            if (propertyValues == null)
                throw new ArgumentNullException(nameof(propertyValues));

            var obj = propertyValues["Ticks"];
            if (!(obj is long))
            {
                throw new ArgumentException("Invalid property entry.");
            }
            return new TimeSpan2((long)obj);
        }

        /// <summary>
        /// Returns whether changing a value on this object requires a call to <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)"/> to create a new value, using the specified context.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
        /// <returns>
        /// true if changing a property on this object requires a call to <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)"/> to create a new value; otherwise, false.
        /// </returns>
        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) => true;

        /// <summary>
        /// Returns a collection of properties for the type of array specified by the value parameter, using the specified context and attributes.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
        /// <param name="value">An <see cref="T:System.Object"/> that specifies the type of array for which to get properties.</param>
        /// <param name="attributes">An array of type <see cref="T:System.Attribute"/> that is used as a filter.</param>
        /// <returns>
        /// A <see cref="T:System.ComponentModel.PropertyDescriptorCollection"/> with the properties that are exposed for this data type, or null if there are no properties.
        /// </returns>
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (attributes == null)
                throw new ArgumentNullException(nameof(attributes));
            return TypeDescriptor.GetProperties(value.GetType(), attributes).Sort(new[] { "Ticks" });
        }

        /// <summary>
        /// Returns whether this object supports properties, using the specified context.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
        /// <returns>
        /// true if <see cref="M:System.ComponentModel.TypeConverter.GetProperties(System.Object)"/> should be called to find the properties of this object; otherwise, false.
        /// </returns>
        public override bool GetPropertiesSupported(ITypeDescriptorContext context) => true;
    }
}
