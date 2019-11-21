#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.Dialogues
{
    public partial class TypefaceSelectionDialogue : KryptonForm
    {
        #region Variables
        private bool _enabled;

        private int _interval, _minimumTypefaceSize, _maximumTypefaceSize;

        private Font _newTypeface;

        private Timer _tmrUpdateTypeface;

        private float _typefaceSize;

        private FontStyle _style;
        #endregion

        #region Properties
        public bool EnableTimer { get { return _enabled; } set { _enabled = value; } }

        public int TimerInterval { get { return _interval; } set { _interval = value; } }

        public int MinimumTypefaceSize { get { return _minimumTypefaceSize; } set { _minimumTypefaceSize = value; } }

        public int MaximumTypefaceSize { get { return _maximumTypefaceSize; } set { _maximumTypefaceSize = value; } }

        public Font NewTypeface { get { return _newTypeface; } set { _newTypeface = value; } }

        public float TypefaceSize { get { return _typefaceSize; } set { _typefaceSize = value; } }

        public FontStyle Style { get { return _style; } set { _style = value; } }
        #endregion

        #region Constructors
        public TypefaceSelectionDialogue()
        {
            InitializeComponent();

            EnableTimer = true;

            TimerInterval = 250;

            _tmrUpdateTypeface = new Timer();

            _tmrUpdateTypeface.Enabled = EnableTimer;

            _tmrUpdateTypeface.Interval = TimerInterval;

            _tmrUpdateTypeface.Tick += new EventHandler(UpdateTypeface_Tick);
        }

        public TypefaceSelectionDialogue(Font newTypeface)
        {
            InitializeComponent();

            EnableTimer = true;

            TimerInterval = 250;

            NewTypeface = newTypeface;

            _tmrUpdateTypeface = new Timer();

            _tmrUpdateTypeface.Enabled = EnableTimer;

            _tmrUpdateTypeface.Interval = TimerInterval;

            _tmrUpdateTypeface.Tick += new EventHandler(UpdateTypeface_Tick);
        }

        public TypefaceSelectionDialogue(Font newTypeface, bool enableTimer, int timerInterval)
        {
            InitializeComponent();

            EnableTimer = enableTimer;

            TimerInterval = timerInterval;

            NewTypeface = newTypeface;

            _tmrUpdateTypeface = new Timer();

            _tmrUpdateTypeface.Enabled = EnableTimer;

            _tmrUpdateTypeface.Interval = TimerInterval;

            _tmrUpdateTypeface.Tick += new EventHandler(UpdateTypeface_Tick);
        }
        #endregion

        private void TypefaceSelectionDialogue_Load(object sender, EventArgs e)
        {
            TypefaceHelper.InitialiseTypefaceFamilies(kcmbSelectedTypeface);

            TypefaceHelper.InitialiseTypefaceStyles(klbTypefaceStyles);
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UpdateTypeface_Tick(object sender, EventArgs e)
        {
            UpdateTypeface();
        }

        private void knumTypefaceSize_ValueChanged(object sender, EventArgs e)
        {
            int value = decimal.ToInt32(knumTypefaceSize.Value);

            SetTypefaceSize(ConvertIntegerToFloat(value));
        }

        #region Methods
        private void UpdateTypeface()
        {
            if (klbTypefaceStyles.GetItemText(klbTypefaceStyles.SelectedItem) == "Bold")
            {
                UpdateTypeface(kcmbSelectedTypeface.Text, GetTypefaceSize(), FontStyle.Bold); //, GraphicsUnit.Pixel);
            }

            klblTextPreview.StateCommon.ShortText.Font = GetNewTypeface();
        }

        private void UpdateTypeface(string familyName, float typefaceSize, FontStyle style)
        {
            Font newTypeface = new Font(familyName, typefaceSize, style);

            SetNewTypeface(newTypeface);
        }
        #endregion

        #region Setters & Getters
        public void SetEnableTimer(bool enableTimer)
        {
            EnableTimer = enableTimer;
        }

        public bool GetEnableTimer()
        {
            return EnableTimer;
        }

        public void SetTimerInterval(int timerInterval)
        {
            TimerInterval = timerInterval;
        }

        public int GetTimerInterval()
        {
            return TimerInterval;
        }

        public void SetMinimumTypefaceSize(int minimumTypefaceSize)
        {
            MinimumTypefaceSize = minimumTypefaceSize;
        }

        public int GetMinimumTypefaceSize()
        {
            return MinimumTypefaceSize;
        }

        public void SetMaximumTypefaceSize(int maximumTypefaceSize)
        {
            MaximumTypefaceSize = maximumTypefaceSize;
        }

        public int GetMaximumTypefaceSize()
        {
            return MaximumTypefaceSize;
        }

        public void SetNewTypeface(Font newTypeface)
        {
            NewTypeface = newTypeface;
        }

        public Font GetNewTypeface()
        {
            return NewTypeface;
        }

        public void SetTypefaceSize(float typefaceSize)
        {
            TypefaceSize = typefaceSize;
        }

        public float GetTypefaceSize()
        {
            return TypefaceSize;
        }

        public void SetTypefaceStyle(FontStyle style)
        {
            Style = style;
        }

        public FontStyle GetTypefaceStyle()
        {
            return Style;
        }
        #endregion

        #region Conversion Methods
        public float ConvertIntegerToFloat(int inputNumber)
        {
            float output = Convert.ToSingle(inputNumber);

            return output;
        }

        public int ConvertFloatToInteger(float inputFloat)
        {
            int outputNumber = (int)inputFloat;

            return outputNumber;
        }

        public string GetSelectedItemText(object item)
        {
            string itemText = klbTypefaceStyles.GetItemText(item);

            return itemText;
        }
        #endregion

        #region Methods
        public void UpdateTypefaceStyle()
        {
            if (klbTypefaceStyles.GetItemText(klbTypefaceStyles.SelectedItem) == "Bold")
            {
                SetTypefaceStyle(FontStyle.Bold);
            }
            else if (klbTypefaceStyles.GetItemText(klbTypefaceStyles.SelectedItem) == "Italic")
            {
                SetTypefaceStyle(FontStyle.Italic);
            }
            else if (klbTypefaceStyles.GetItemText(klbTypefaceStyles.SelectedItem) == "Regular")
            {
                SetTypefaceStyle(FontStyle.Regular);
            }
            else if (klbTypefaceStyles.GetItemText(klbTypefaceStyles.SelectedItem) == "Strikeout")
            {
                SetTypefaceStyle(FontStyle.Strikeout);
            }
            else if (klbTypefaceStyles.GetItemText(klbTypefaceStyles.SelectedItem) == "Underline")
            {
                SetTypefaceStyle(FontStyle.Underline);
            }
        }
        #endregion

        private void kcmbSelectedTypeface_TextChanged(object sender, EventArgs e)
        {
            UpdateTypeface(kcmbSelectedTypeface.Text, GetTypefaceSize(), GetTypefaceStyle());
        }
    }
}