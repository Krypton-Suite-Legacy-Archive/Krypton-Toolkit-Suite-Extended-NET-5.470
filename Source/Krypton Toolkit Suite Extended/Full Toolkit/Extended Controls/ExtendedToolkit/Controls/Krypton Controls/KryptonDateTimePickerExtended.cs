#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonExtendedToolkit.ExtendedToolkit.Controls
{
    /// <summary>
    /// An enhanced version of <see cref="KryptonDateTimePicker"/>.
    /// </summary>
    /// <seealso cref="KryptonDateTimePicker" />
    [Description("An enhanced version of the Krypton Date/Time picker.")]
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(KryptonDateTimePicker))]
    public partial class KryptonDateTimePickerExtended : KryptonDateTimePicker
    {
        #region Variables
        private KryptonTextBox ktxtDateTime;

        private IContainer components;

        private bool _setDate, _bDroppedDown, _showButtons = true;

        private ErrorProvider errorMessage;

        private ToolTip toolTip;

        private string _linkedTo, _customFormatMessage;

        private int _buttonWidth = BUTTON_WIDTH, _checkWith = 0;

        private DateTimePickerCustomExtensions _customExtensions;

        private KryptonDateTimePickerExtended _linkTo;

        private ArrayList _linkToArray = new ArrayList(), _linkedArray = new ArrayList();
        #endregion

        #region Constants
        private const int BUTTON_WIDTH = 16;
        #endregion

        #region Enumerations        
        /// <summary>
        /// 
        /// </summary>
        public enum DateTimePickerCustomExtensions
        {
            DTPLONG = 0,
            DTPSHORT = 1,
            DTPTIME = 2,
            DTPSHORTDATESHORTTIMEAMPM = 3,
            DTPSHORTDATELONGTIMEAMPM = 4,
            DTPSHORTDATESHORTTIME24HOUR = 5,
            DTPSHORTDATELONGTIME24HOUR = 6,
            DTPLONGDATESHORTTIMEAMPM = 7,
            DTPLONGDATELONGTIMEAMPM = 8,
            DTPLONGDATESHORTTIME24HOUR = 9,
            DTPLONGDATELONGTIME24HOUR = 10,
            DTPSORTABLEDATEANDTIMELOCALTIME = 11,
            DTPUTFLOCALDATEANDSHORTTIMEAMPM = 12,
            DTPUTFLOCALDATEANDLONGTIMEAMPM = 13,
            DTPUTFLOCALDATEANDSHORTTIME24HOUR = 14,
            DTPUTFLOCALDATEANDLONGTIME24HOUR = 15,
            DTPSHORTTIMEAMPM = 16,
            DTPSHORTTIME24HOUR = 17,
            DTPLONGTIME24HOUR = 18,
            DTPYEARANDMONTHNAME = 19,
            DTPMONTHNAMEANDDAY = 20,
            DTPYEAR4DIGIT = 21,
            DTPMONTHFULLNAME = 22,
            DTPMONTHSHORTNAME = 23,
            DTPDAYFULLNAME = 24,
            DTPDAYSHORTNAME = 25,
            DTPSHORTDATEAMPM = 26,
            DTPSHORTDATEMORNINGAFTERNOON = 27,
            DTPCUSTOM = 28
        }
        #endregion

        #region Constructor        
        /// <summary>
        /// Initialises a new instance of the <see cref="KryptonDateTimePickerExtended"/> class.
        /// </summary>
        public KryptonDateTimePickerExtended()
        {
            InitialiseComponent();

            base.Format = DateTimePickerFormat.Custom;

            KryptonDateTimePickerExtended_Resize(this, null);
        }
        #endregion

        #region Setup        
        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        private void InitialiseComponent()
        {
            components = new Container();

            ktxtDateTime = new KryptonTextBox();

            errorMessage = new ErrorProvider();

            toolTip = new ToolTip(components);

            SuspendLayout();
            //
            // ktxtDateTime
            //
            ktxtDateTime.Location = new Point(20, 40);

            ktxtDateTime.MaxLength = 50;

            ktxtDateTime.Name = "ktxtDateTime";

            ktxtDateTime.TabIndex = 0;

            ktxtDateTime.Leave += new EventHandler(ktxtDateTime_Leave);

            ktxtDateTime.Enter += new EventHandler(ktxtDateTime_Enter);

            MaxDate = new DateTime(9999, 12, 31, 23, 59, 59, 59);

            //
            // errorMessage
            //
            errorMessage.DataMember = null;

            //
            // KryptonDateTimePickerExtended
            //
            Controls.AddRange(new Control[] { ktxtDateTime });

            Value = new DateTime(1753, 1, 1, 15, 8, 40, 119);

            DropDown += new EventHandler<DateTimePickerDropArgs>(KryptonDateTimePickerExtended_DropDown);

            FontChanged += new EventHandler(KryptonDateTimePickerExtended_FontChanged);

            Resize += new EventHandler(KryptonDateTimePickerExtended_Resize);

            Enter += new EventHandler(KryptonDateTimePickerExtended_Enter);

            CloseUp += new EventHandler<DateTimePickerCloseArgs>(KryptonDateTimePickerExtended_CloseUp);

            ForeColorChanged += new EventHandler(KryptonDateTimePickerExtended_ForeColorChanged);

            BackColorChanged += new EventHandler(KryptonDateTimePickerExtended_BackColorChanged);

            ValueChanged += new EventHandler(FormatOrValue_Changed);

            FormatChanged += new EventHandler(FormatOrValue_Changed);

            ResumeLayout(false);
        }
        #endregion

        #region Event Handlers
        private void ktxtDateTime_Leave(object sender, EventArgs e)
        {
            if (!SetDate)
            {
                SetDate = true;

                errorMessage.SetError(this, "");

                if (Text != "")
                {
                    try
                    {
                        FormatKryptonTextBox();

                        _linkToArray.Clear();

                        if (_linkedTo != "" && _linkedTo != null)
                        {
                            for (int j = 0; j < _linkedArray.Count; j++)
                            {
                                for (int i = 0; i < Parent.Controls.Count; i++)
                                {
                                    if (Parent.Controls[i].Name == _linkedArray[j].ToString() && Parent.Controls[i] is KryptonDateTimePickerExtended)
                                    {
                                        _linkTo = (KryptonDateTimePickerExtended)Parent.Controls[i];

                                        _linkToArray.Add(_linkTo);

                                        break;
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        errorMessage.SetError(this, $"Invalid date - { ktxtDateTime.Text }, valid format is { _customFormatMessage }");
                    }
                }

                for (int i = 0; i < _linkToArray.Count; i++)
                {
                    if (_linkToArray[i] != null)
                    {
                        _linkTo = (KryptonDateTimePickerExtended)_linkToArray[i];

                        _linkTo.Text = Text;
                    }
                }

                SetDate = false;
            }
        }

        private void ktxtDateTime_Enter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(ktxtDateTime, _customFormatMessage);

            if (ktxtDateTime.Text.Length > 0)
            {
                ktxtDateTime.SelectionStart = 0;

                ktxtDateTime.SelectionLength = ktxtDateTime.Text.Length;
            }

            SetDate = true;

            Value = DateTime.Now;

            SetDate = false;
        }

        private void FormatOrValue_Changed(object sender, EventArgs e)
        {
            errorMessage.SetError(this, "");

            if (Text != "")
            {
                try
                {
                    FormatKryptonTextBox();
                }
                catch
                {
                    errorMessage.SetError(this, $"Invalid Date - { ktxtDateTime.Text }, valid format is { _customFormatMessage }");
                }
            }
        }

        private void KryptonDateTimePickerExtended_BackColorChanged(object sender, EventArgs e)
        {
            ktxtDateTime.BackColor = BackColor;

            if (ktxtDateTime.BackColor != BackColor)
            {
                BackColor = ktxtDateTime.BackColor;
            }
        }

        private void KryptonDateTimePickerExtended_ForeColorChanged(object sender, EventArgs e)
        {
            ktxtDateTime.ForeColor = BackColor;
        }

        private void KryptonDateTimePickerExtended_CloseUp(object sender, DateTimePickerCloseArgs e)
        {
            if (_bDroppedDown || ShowUpDown)
            {
                if (!SetDate)
                {
                    ktxtDateTime.Text = Value.ToString();

                    FormatKryptonTextBox();
                }
            }
        }

        private void KryptonDateTimePickerExtended_Enter(object sender, EventArgs e)
        {
            ktxtDateTime.Focus();
        }

        private void KryptonDateTimePickerExtended_Resize(object sender, EventArgs e)
        {
            ktxtDateTime.Location = new Point(-2 + _checkWith, -2);

            ktxtDateTime.Size = new Size(Width - _buttonWidth - _checkWith, Height);
        }

        private void KryptonDateTimePickerExtended_FontChanged(object sender, EventArgs e)
        {
            ktxtDateTime.Font = Font;
        }

        private void KryptonDateTimePickerExtended_DropDown(object sender, DateTimePickerDropArgs e)
        {
            _bDroppedDown = true;
        }
        #endregion

        #region Overrides and Additional Properties        
        /// <summary>
        /// Gets the format.
        /// </summary>
        /// <value>
        /// The format.
        /// </value>
        [Browsable(false)]
        public new DateTimePickerFormat Format
        {
            get
            {
                return base.Format;
            }
        }

        /// <summary>
        /// Gets or sets the extended format.
        /// </summary>
        /// <value>
        /// The extended format.
        /// </value>
        [Browsable(true), Category("Appearance"), Description("Format Extensions replaces Format gets sets display Formats")]
        public DateTimePickerCustomExtensions ExtendedFormat
        {
            get
            {
                return _customExtensions;
            }

            set
            {
                _customExtensions = value;

                InitialiseCustomMessage();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show buttons].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show buttons]; otherwise, <c>false</c>.
        /// </value>
        [Browsable(true), Category("Appearance"), Description("Hides DropDown and Spin Buttons, Allows keyed entry only.")]
        public bool ShowButtons
        {
            get
            {
                return _showButtons;
            }

            set
            {
                if (!ReadOnly)
                {
                    _showButtons = value;

                    if (_showButtons)
                    {
                        _buttonWidth = BUTTON_WIDTH;
                    }
                    else
                    {
                        _buttonWidth = 0;
                    }

                    KryptonDateTimePickerExtended_Resize(this, null);
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show CheckBox].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show CheckBox]; otherwise, <c>false</c>.
        /// </value>
        [Browsable(true), Category("Appearance"), Description("Hides DropDown and Spin Buttons, Allows keyed entry only.")]
        public new bool ShowCheckBox
        {
            get
            {
                return base.ShowCheckBox;
            }

            set
            {
                if (!ReadOnly)
                {
                    base.ShowCheckBox = value;

                    if (base.ShowCheckBox)
                    {
                        _checkWith = BUTTON_WIDTH;
                    }
                    else
                    {
                        _checkWith = 0;
                    }

                    KryptonDateTimePickerExtended_Resize(this, null);
                }
            }
        }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [Browsable(true), Category("Behavior"), Description("Date and Time displayed")]
        public new string Text
        {
            get
            {
                return ktxtDateTime.Text;
            }

            set
            {
                ktxtDateTime.Text = value;

                if (value != "")
                {
                    FormatKryptonTextBox();
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show up down].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show up down]; otherwise, <c>false</c>.
        /// </value>
        [Browsable(true), Category("Appearance"), Description("Uses Updown control to select dates instead of Dropdown control")]
        public new bool ShowUpDown
        {
            get
            {
                return base.ShowUpDown;
            }

            set
            {
                if (!ReadOnly)
                {
                    base.ShowUpDown = value;

                    ktxtDateTime.Text = "";
                }
            }
        }

        /// <summary>
        /// Gets or sets the colour of the back.
        /// </summary>
        /// <value>
        /// The colour of the back.
        /// </value>
        [Browsable(true), Category("Appearance"), Description("The Backround Colour user to display Text and Graphics in this Control")]
        public new Color BackColor
        {
            get
            {
                return base.BackColor;
            }

            set
            {
                base.BackColor = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [read only].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [read only]; otherwise, <c>false</c>.
        /// </value>
        [Browsable(true), Category("Behavior"), Description("Used to set whether the control can be edited")]
        public bool ReadOnly
        {
            get
            {
                return ktxtDateTime.ReadOnly;
            }

            set
            {
                if (value)
                {
                    ShowCheckBox = false;

                    ShowUpDown = false;

                    ShowButtons = false;

                    ktxtDateTime.ReadOnly = value;
                }
                else
                {
                    ktxtDateTime.ReadOnly = value;

                    ShowButtons = true;
                }
            }
        }

        /// <summary>
        /// Gets or sets the linked to.
        /// </summary>
        /// <value>
        /// The linked to.
        /// </value>
        [Browsable(true), Category("Behavior"), Description("Set Get another Date Picker Control that this control receives data from.")]
        public string LinkedTo
        {
            get
            {
                return _linkedTo;
            }

            set
            {
                _linkedTo = value;

                _linkedArray.Clear();

                if (_linkedTo != "" && _linkedTo != null)
                {
                    string[] splitLinkedTo = _linkedTo.Split(",".ToCharArray());

                    for (int i = 0; i < splitLinkedTo.Length; i++)
                    {
                        _linkedArray.Add(splitLinkedTo[i].Trim());
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [set date].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [set date]; otherwise, <c>false</c>.
        /// </value>
        public bool SetDate
        {
            get
            {
                return _setDate;
            }

            set
            {
                _setDate = value;
            }
        }
        #endregion

        #region Methods
        private void InitialiseCustomMessage()
        {
            switch (_customExtensions)
            {
                case DateTimePickerCustomExtensions.DTPLONG:
                    _customFormatMessage = "Long Date (" + DateTime.Now.ToLongDateString() + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPSHORT:
                    _customFormatMessage = "Short Date (" + DateTime.Now.ToShortDateString() + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPTIME:
                    _customFormatMessage = "Long Time AM/PM (" + DateTime.Now.ToLongTimeString() + ")";

                    CustomFormat = "HH:mm:ss yyyy-MM-dd ";
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATESHORTTIMEAMPM:
                    _customFormatMessage = " Short Date Short Time AM/PM (" + DateTime.Now.ToString("d", Application.CurrentCulture) + " " + DateTime.Now.ToString("hh:mmss tt", Application.CurrentCulture) + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATELONGTIMEAMPM:
                    _customFormatMessage = "Short Date Long Time AM/PM (" + DateTime.Now.ToString("G", Application.CurrentCulture) + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATESHORTTIME24HOUR:
                    _customFormatMessage = " Short Date Short Time 24 Hour (" + DateTime.Now.ToString("d", Application.CurrentCulture) + " " + DateTime.Now.ToString("HH:mm", Application.CurrentCulture) + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATELONGTIME24HOUR:
                    _customFormatMessage = "Short Date Long Time AM/PM (" + DateTime.Now.ToString("G", Application.CurrentCulture) + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPLONGDATESHORTTIMEAMPM:
                    _customFormatMessage = "Long Date Short Time AM/PM (" + DateTime.Now.ToString("D", Application.CurrentCulture) + " " + DateTime.Now.ToString("hh:mm tt", Application.CurrentCulture) + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPLONGDATELONGTIMEAMPM:
                    _customFormatMessage = "Long Date Long Time AM/PM (" + DateTime.Now.ToString("D", Application.CurrentCulture) + " " + DateTime.Now.ToString("hh:mm:ss tt", Application.CurrentCulture) + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPLONGDATESHORTTIME24HOUR:
                    _customFormatMessage = "Long Date Short Time 24 Hour (" + DateTime.Now.ToString("D", Application.CurrentCulture) + " " + DateTime.Now.ToString("HH:mm", Application.CurrentCulture) + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPLONGDATELONGTIME24HOUR:
                    _customFormatMessage = "Long Date Long Time 24 Hour (" + DateTime.Now.ToString("D", Application.CurrentCulture) + " " + DateTime.Now.ToString("HH:mm:ss", Application.CurrentCulture) + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPSORTABLEDATEANDTIMELOCALTIME:
                    _customFormatMessage = "Sortable Date and Local Time (" + DateTime.Now.ToString("s", Application.CurrentCulture) + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPUTFLOCALDATEANDSHORTTIMEAMPM:
                    _customFormatMessage = "UTF Local Date and Short Time AM/PM (" + DateTime.Now.ToString("yyyy-MM-dd HH:mm tt", Application.CurrentCulture) + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPUTFLOCALDATEANDLONGTIMEAMPM:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("yyyy-MM-dd", Application.CurrentCulture) + " " + Value.ToString("hh:mm:ss tt", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPUTFLOCALDATEANDSHORTTIME24HOUR:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("yyyy-MM-dd", Application.CurrentCulture) + " " + Value.ToString("HH:mm", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPUTFLOCALDATEANDLONGTIME24HOUR:
                    _customFormatMessage = "UTF Local Date and Long Time 24 Hour (" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", Application.CurrentCulture) + ")";

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTTIMEAMPM:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("hh:mm tt", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTTIME24HOUR:
                    _customFormatMessage = "Short Time 24 Hour (" + DateTime.Now.ToString("HH:mm", Application.CurrentCulture) + ")";

                    CustomFormat = "HH:mm:ss yyyy-MM-dd ";
                    break;
                case DateTimePickerCustomExtensions.DTPLONGTIME24HOUR:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("HH:mm:ss", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPYEARANDMONTHNAME:
                    try
                    {
                        Value = DateTime.Parse(ktxtDateTime.Text);
                    }
                    catch
                    {
                        try
                        {
                            ktxtDateTime.Text = DateTime.Now.Year.ToString() + " " + int.Parse(ktxtDateTime.Text, Application.CurrentCulture).ToString();
                        }
                        catch
                        {
                            Value = DateTime.Parse(ktxtDateTime.Text + " 01");
                        }
                    }

                    ktxtDateTime.Text = Value.ToString("Y", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPMONTHNAMEANDDAY:
                    _customFormatMessage = "Month Name and Day (" + DateTime.Now.ToString("M", Application.CurrentCulture) + ")";

                    CustomFormat = "dd-MM-yyyy HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPYEAR4DIGIT:
                    _customFormatMessage = "4 Digit Year (" + DateTime.Now.ToString("yyyy", Application.CurrentCulture);

                    CustomFormat = "yyyy-MM-dd HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPMONTHFULLNAME:
                    try
                    {
                        Value = DateTime.Parse(ktxtDateTime.Text);
                    }
                    catch
                    {
                        int aMonth;

                        DateTime aDate;

                        string[] sMonth = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

                        for (aMonth = 0; aMonth < 12; aMonth++)
                        {
                            aDate = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (aMonth + 1) + "-" + "01");

                            if (sMonth[aMonth].ToLower() == ktxtDateTime.Text.ToLower() || sMonth[aMonth].ToLower() == ktxtDateTime.Text.Substring(0, 3).ToLower())
                            {
                                Value = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (aMonth + 1) + "-" + "01");

                                break;
                            }
                        }
                    }

                    ktxtDateTime.Text = Value.ToString("MMMM", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPMONTHSHORTNAME:
                    try
                    {
                        Value = DateTime.Parse(ktxtDateTime.Text);
                    }
                    catch
                    {
                        int aMonth;

                        DateTime aDate;

                        string[] sMonth = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

                        for (aMonth = 0; aMonth < 12; aMonth++)
                        {
                            aDate = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (aMonth + 1) + "-" + "01");

                            if (sMonth[aMonth].ToLower() == ktxtDateTime.Text.ToLower() || sMonth[aMonth].ToLower() == ktxtDateTime.Text.Substring(0, 3).ToLower())
                            {
                                Value = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (aMonth + 1) + "-" + "01");

                                break;
                            }
                        }
                    }

                    ktxtDateTime.Text = Value.ToString("MMM", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPDAYFULLNAME:
                    _customFormatMessage = "Day of the Week Full Name (" + DateTime.Now.ToString("dddd", Application.CurrentCulture) + ")";

                    CustomFormat = "dd-MM-yyyy HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPDAYSHORTNAME:
                    _customFormatMessage = "Day of the Week Short Name (" + DateTime.Now.ToString("ddd", Application.CurrentCulture) + ")";

                    CustomFormat = "dd-MM-yyyy HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATEAMPM:
                    _customFormatMessage = "Short Date AM/PM (" + DateTime.Now.ToString("d", Application.CurrentCulture) + " " + DateTime.Now.ToString("tt", Application.CurrentCulture) + ")";

                    CustomFormat = "MM-dd-yyyy HH:mm:ss";
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATEMORNINGAFTERNOON:
                    string AMPM = "AM";

                    if (DateTime.Now.Hour >= 12)
                    {
                        AMPM = "Afternoon";
                    }

                    _customFormatMessage = "Short Date Morning/Afternoon (" + DateTime.Now.ToString("d", Application.CurrentCulture) + " " + AMPM + ")";

                    CustomFormat = "MM-dd-yyyy HH:mm:ss";

                    break;
                case DateTimePickerCustomExtensions.DTPCUSTOM:
                    _customFormatMessage = CustomFormat;
                    break;
            }

            toolTip.SetToolTip(ktxtDateTime, _customFormatMessage);
        }

        private void FormatKryptonTextBox()
        {
            switch (_customExtensions)
            {
                case DateTimePickerCustomExtensions.DTPLONG:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToLongDateString();
                    break;
                case DateTimePickerCustomExtensions.DTPSHORT:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToShortDateString();
                    break;
                case DateTimePickerCustomExtensions.DTPTIME:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToLongTimeString();
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATESHORTTIMEAMPM:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("d", Application.CurrentCulture) + " " + Value.ToString("hh:mms tt", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATELONGTIMEAMPM:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("d", Application.CurrentCulture) + " " + Value.ToString("hh:mms:ss tt", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATESHORTTIME24HOUR:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("d", Application.CurrentCulture) + " " + Value.ToString("HH:mm", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATELONGTIME24HOUR:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("d", Application.CurrentCulture) + " " + Value.ToString("HH:mms:ss", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPLONGDATESHORTTIMEAMPM:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("D", Application.CurrentCulture) + " " + Value.ToString("hh:mm tt", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPLONGDATELONGTIMEAMPM:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("D", Application.CurrentCulture) + " " + Value.ToString("hh:mm:ss tt", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPLONGDATESHORTTIME24HOUR:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("D", Application.CurrentCulture) + " " + Value.ToString("HH:mm", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPLONGDATELONGTIME24HOUR:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("D", Application.CurrentCulture) + " " + Value.ToString("HH:mm:ss", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPSORTABLEDATEANDTIMELOCALTIME:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("s", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPUTFLOCALDATEANDSHORTTIMEAMPM:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("yyyy-MM-dd", Application.CurrentCulture) + " " + Value.ToString("hh:mm tt", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPUTFLOCALDATEANDLONGTIMEAMPM:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("yyyy-MM-dd", Application.CurrentCulture) + " " + Value.ToString("hh:mm:ss tt", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPUTFLOCALDATEANDSHORTTIME24HOUR:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("yyyy-MM-dd", Application.CurrentCulture) + " " + Value.ToString("HH:mm", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPUTFLOCALDATEANDLONGTIME24HOUR:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("yyyy-MM-dd", Application.CurrentCulture) + " " + Value.ToString("HH:mm:ss", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTTIMEAMPM:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("hh:mm tt", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTTIME24HOUR:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("HH:mm", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPLONGTIME24HOUR:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("HH:mm:ss", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPYEARANDMONTHNAME:
                    try
                    {
                        Value = DateTime.Parse(ktxtDateTime.Text);
                    }
                    catch
                    {
                        try
                        {
                            ktxtDateTime.Text = DateTime.Now.Year.ToString() + " " + int.Parse(ktxtDateTime.Text, Application.CurrentCulture).ToString();
                        }
                        catch
                        {
                            Value = DateTime.Parse(ktxtDateTime.Text + " 01");
                        }
                    }

                    ktxtDateTime.Text = Value.ToString("Y", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPMONTHNAMEANDDAY:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("M", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPYEAR4DIGIT:
                    try
                    {
                        Value = DateTime.Parse(ktxtDateTime.Text);
                    }
                    catch
                    {
                        Value = DateTime.Parse("01 01 " + ktxtDateTime.Text);
                    }

                    ktxtDateTime.Text = Value.ToString("yyyy", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPMONTHFULLNAME:
                    try
                    {
                        Value = DateTime.Parse(ktxtDateTime.Text);
                    }
                    catch
                    {
                        int aMonth;

                        DateTime aDate;

                        string[] sMonth = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

                        for (aMonth = 0; aMonth < 12; aMonth++)
                        {
                            aDate = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (aMonth + 1) + "-" + "01");

                            if (sMonth[aMonth].ToLower() == ktxtDateTime.Text.ToLower() || sMonth[aMonth].ToLower() == ktxtDateTime.Text.Substring(0, 3).ToLower())
                            {
                                Value = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (aMonth + 1) + "-" + "01");

                                break;
                            }
                        }
                    }

                    ktxtDateTime.Text = Value.ToString("MMMM", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPMONTHSHORTNAME:
                    try
                    {
                        Value = DateTime.Parse(ktxtDateTime.Text);
                    }
                    catch
                    {
                        int aMonth;

                        DateTime aDate;

                        string[] sMonth = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

                        for (aMonth = 0; aMonth < 12; aMonth++)
                        {
                            aDate = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (aMonth + 1) + "-" + "01");

                            if (sMonth[aMonth].ToLower() == ktxtDateTime.Text.ToLower() || sMonth[aMonth].ToLower() == ktxtDateTime.Text.Substring(0, 3).ToLower())
                            {
                                Value = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + (aMonth + 1) + "-" + "01");

                                break;
                            }
                        }
                    }

                    ktxtDateTime.Text = Value.ToString("MMM", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPDAYFULLNAME:
                    try
                    {
                        Value = DateTime.Parse(ktxtDateTime.Text);
                    }
                    catch
                    {
                        int aDay;

                        DateTime aDate;

                        for (aDay = 1; aDay < 8; aDay++)
                        {
                            aDate = DateTime.Parse(DateTime.Now.Year.ToString() + "-01-" + aDay.ToString());

                            if (aDate.DayOfWeek.ToString().ToLower() == ktxtDateTime.Text.ToLower() || aDate.DayOfWeek.ToString().Substring(0, 3).ToLower() == ktxtDateTime.Text.ToLower())
                            {
                                Value = DateTime.Parse(DateTime.Now.Year.ToString() + "-01-" + aDay.ToString());

                                break;
                            }
                        }
                    }

                    ktxtDateTime.Text = Value.ToString("dddd", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPDAYSHORTNAME:
                    try
                    {
                        Value = DateTime.Parse(ktxtDateTime.Text);
                    }
                    catch
                    {
                        int aDay;

                        DateTime aDate;

                        for (aDay = 1; aDay < 8; aDay++)
                        {
                            aDate = DateTime.Parse(DateTime.Now.Year.ToString() + "-01-" + aDay.ToString());

                            if (aDate.DayOfWeek.ToString().ToLower() == ktxtDateTime.Text.ToLower() || aDate.DayOfWeek.ToString().Substring(0, 3).ToLower() == ktxtDateTime.Text.ToLower())
                            {
                                Value = DateTime.Parse(DateTime.Now.Year.ToString() + "-01-" + aDay.ToString());

                                break;
                            }
                        }
                    }

                    ktxtDateTime.Text = Value.ToString("ddd", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATEAMPM:
                    if (ktxtDateTime.Text.Substring(ktxtDateTime.Text.Length - 2, 2).ToLower() == "pm")
                    {
                        ktxtDateTime.Text = ktxtDateTime.Text.Substring(0, ktxtDateTime.Text.Length - 2);

                        ktxtDateTime.Text = ktxtDateTime.Text + " 13:00";
                    }
                    else
                    {
                        if (ktxtDateTime.Text.Substring(ktxtDateTime.Text.Length - 2, 2).ToLower() == "am")
                        {
                            ktxtDateTime.Text = ktxtDateTime.Text.Substring(0, ktxtDateTime.Text.Length - 2);
                        }

                        ktxtDateTime.Text = ktxtDateTime.Text + " 01:00";
                    }

                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString("d", Application.CurrentCulture) + " " + Value.ToString("tt", Application.CurrentCulture);
                    break;
                case DateTimePickerCustomExtensions.DTPSHORTDATEMORNINGAFTERNOON:
                    string AMPM = "Morning";

                    if (ktxtDateTime.Text.Substring(ktxtDateTime.Text.Length - 2, 2).ToLower() == "pm")
                    {
                        ktxtDateTime.Text = ktxtDateTime.Text.Substring(0, ktxtDateTime.Text.Length - 2);

                        ktxtDateTime.Text = ktxtDateTime.Text + " 13:00";
                    }
                    else
                    {
                        if (ktxtDateTime.Text.Substring(ktxtDateTime.Text.Length - 2, 2).ToLower() == "am")
                        {
                            ktxtDateTime.Text = ktxtDateTime.Text.Substring(0, ktxtDateTime.Text.Length - 2);
                        }

                        ktxtDateTime.Text = ktxtDateTime.Text + " 01:00";
                    }

                    Value = DateTime.Parse(ktxtDateTime.Text);

                    if (Value.Hour >= 12)
                    {
                        AMPM = "Afternoon";
                    }

                    ktxtDateTime.Text = Value.ToString("d", Application.CurrentCulture) + " " + AMPM;
                    break;
                case DateTimePickerCustomExtensions.DTPCUSTOM:
                    Value = DateTime.Parse(ktxtDateTime.Text);

                    ktxtDateTime.Text = Value.ToString(CustomFormat, Application.CurrentCulture);
                    break;
            }
        }
        #endregion
    }
}