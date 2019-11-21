using ExtendedControls.Base.Code.TimeSpanExtended;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace ExtendedControls.ExtendedToolkit.Controls.TimeSpanExtended
{
    [DefaultEvent("ValueChanged"), DefaultProperty("Value")]
    public class KryptonTimeSpanPicker : ComponentFactory.Krypton.Toolkit.KryptonComboBox
    {
        #region Variables
        private bool _isValid = true;

        private System.TimeSpan _tsValue;

        private readonly TimeSpanCollection _list;

        private string _zero;
        #endregion

        #region Properties
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new TimeSpan2FormatInfo FormatInfo
        {
            get => (TimeSpan2FormatInfo)base.FormatInfo;

            set
            {
                if (!string.IsNullOrEmpty(FormattedZero) && value != null)
                {
                    value.TimeSpanZeroDisplay = FormattedZero;
                }

                base.FormatInfo = value;
            }
        }

        [DefaultValue("f"), Category("Appearance"), Localizable(true)]
        public new string FormatString { get => base.FormatString; set => base.FormatString = value; }

        [DefaultValue(null), Category("Apperance"), Localizable(true)]
        public string FormattedZero { get => _zero; set { _zero = value; FormatInfo.TimeSpanZeroDisplay = value; } }

        [DefaultValue(true), Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool FormattingEnabled { get => base.FormattingEnabled; set => base.FormattingEnabled = value; }

        [DefaultValue(true), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTextValid => _isValid;

        [Category("Data"), Localizable(false), Editor(typeof(TimeSpanCollectionEditor), typeof(UITypeEditor)), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), RefreshProperties(RefreshProperties.All)]
        public new TimeSpanCollection Items => _list;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text { get => base.Text; set => base.Text = value; }

        [Category("Data")]
        public TimeSpan2 Value { get => _tsValue; set { _tsValue = value; base.Text = System.TimeSpan.Zero.Equals(value) ? FormatInfo.TimeSpanZeroDisplay : value.ToString(base.FormatString, FormatInfo); } }
        #endregion

        #region Events
        [Category("Property Changed")]
        public event EventHandler ValueChanged;
        #endregion

        #region Constructor
        public KryptonTimeSpanPicker()
        {
            FormatString = "f";

            FormattingEnabled = true;

            FormatInfo = TimeSpan2FormatInfo.CurrentInfo;

            _list = new TimeSpanCollection(base.Items);

            ResetValue();

            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
        }
        #endregion

        #region Event Handlers
        private void UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            switch (e.Category)
            {
                case UserPreferenceCategory.Locale:
                    ResetLocale();
                    break;
            }
        }
        #endregion

        #region Methods
        internal void ResetValue() => Value = TimeSpan2.Zero;

        internal bool ShouldSerializeValue() => Value != TimeSpan2.Zero;

        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }

        protected void ResetLocale()
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();

            FormatInfo = TimeSpan2FormatInfo.CurrentInfo;
        }
        #endregion

        #region Overrides
        protected override void Dispose(bool disposing)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;

            base.Dispose(disposing);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            System.TimeSpan timeSpan;

            _isValid = FormatInfo.TryParse(base.Text, null, out timeSpan);

            if (_isValid && timeSpan != _tsValue)
            {
                _tsValue = timeSpan;

                OnValueChanged(e);
            }

            base.OnTextChanged(e);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x001A:
                    ResetLocale();
                    break;
            }

            base.WndProc(ref m);
        }
        #endregion

        #region Classes
        public class TimeSpanCollection : StrongListWrapper<TimeSpan2>
        {
            internal TimeSpanCollection(ObjectCollection collection) : base(collection) { }
        }

        public class TimeSpanCollectionEditor : ExposedStringCollectionEditor
        {
            #region Variables
            private string _format = "f";
            #endregion

            #region Constructor
            public TimeSpanCollectionEditor(Type type) : base(type) { }
            #endregion

            #region Overrides
            protected override string FormTitle => "TimeSpan Collection Editor";

            protected override string InstructionText => "Enter string representations of TimeSpan objects (one per line):";

            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {
                if (context == null)
                {
                    throw new ArgumentNullException(nameof(context));
                }

                var p = context.Instance as KryptonTimeSpanPicker;

                if (p != null)
                {
                    _format = p.FormatString;
                }

                return base.EditValue(context, provider, value);
            }

            protected override object[] GetItems(object editValue)
            {
                var value = editValue as TimeSpanCollection;

                if (value != null)
                {
                    var c = value;

                    var output = new List<string>(c.Count);

                    foreach (var t in c)
                    {
                        var s = t.ToString(_format);

                        output.Add(string.IsNullOrEmpty(s) ? "0:0:0" : s);
                    }

                    return output.ToArray();
                }
                return new object[0];
            }

            protected override object SetItems(object editValue, object[] value)
            {
                if (!(editValue is TimeSpanCollection))
                {
                    return editValue;
                }

                var c = (TimeSpanCollection)editValue;

                c.Clear();

                var fi = TimeSpan2FormatInfo.CurrentInfo;

                foreach (var v in value)
                {
                    System.TimeSpan ts;

                    if (fi.TryParse(v.ToString(), null, out ts))
                    {
                        c.Add(ts);
                    }
                }

                return c;
            }
            #endregion
        }
        #endregion
    }
}