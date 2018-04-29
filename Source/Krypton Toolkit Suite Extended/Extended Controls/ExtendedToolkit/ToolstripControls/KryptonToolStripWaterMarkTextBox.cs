using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

using ComponentFactory.Krypton.Toolkit;

namespace KryptonExtendedToolkit.ExtendedToolkit.ToolstripControls
{
    [ToolboxBitmap(typeof(KryptonTextBox)), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public partial class KryptonToolStripWaterMarkTextBox : KryptonToolStripTextBox
    {
        #region Fields
        private bool _waterMarkTextEnabled = false, _toLower = false, _toUpper = false;

        private Color _waterMarkColour = Color.Gray;

        private Font _oldTypeface = null, _waterMarkTypeface = null;

        private string _waterMarkText = "Water Mark";

        private HorizontalAlignment _watermarkTextAlignment;
        #endregion

        #region Properties
        /// <summary>
        /// Enables or disables the watermark.
        /// </summary>
        public bool WaterMarkTextEnabled
        {
            get
            {
                return _waterMarkTextEnabled;
            }

            set
            {
                _waterMarkTextEnabled = value;
            }
        }

        /// <summary>
        /// Alters the watermark colour to one of your choosing.
        /// </summary>
        //[DefaultValue(typeof(new Color(_waterMarkColour))]
        public Color WaterMarkColour
        {
            get
            {
                return _waterMarkColour;
            }

            set
            {
                _waterMarkColour = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Sets the typeface of the watermark text.
        /// </summary>
        public Font WaterMarkTypeface
        {
            get
            {
                return _waterMarkTypeface;
            }

            set
            {
                _waterMarkTypeface = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Alters the alignment of the watermark text
        /// </summary>
        [DefaultValue(HorizontalAlignment.Left)]
        public HorizontalAlignment WatermarkTextAlignment
        {
            get
            {
                return _watermarkTextAlignment;
            }

            set
            {
                _watermarkTextAlignment = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Forces the text to always be in lower case (abc).
        /// </summary>
        public bool ToLower
        {
            get
            {
                return _toLower;
            }

            set
            {
                _toLower = value;
            }
        }

        /// <summary>
        /// Forces the text to always be in upper case (ABC).
        /// </summary>
        public bool ToUpper
        {
            get
            {
                return _toUpper;
            }

            set
            {
                _toUpper = value;
            }
        }

        /// <summary>
        /// The watermark mask.
        /// </summary>
        public string WaterMarkText
        {
            get
            {
                return _waterMarkText;
            }

            set
            {
                _waterMarkText = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// The default constructor.
        /// </summary>
        public KryptonToolStripWaterMarkTextBox()
        {
            JoinEvents(true);
        }
        #endregion

        #region Overrides

        #endregion

        #region Methods
        /// <summary>
        /// Concatenates built-in events to corresponding event handlers.
        /// </summary>
        /// <param name="join">Go ahead and setup the event handlers.</param>
        public void JoinEvents(bool join)
        {
            if (join)
            {
                TextChanged += new EventHandler(WaterMarkToggle);

                LostFocus += new EventHandler(WaterMarkToggle);

                //FontChanged += new EventHandler(WaterMarkFontChanged);
            }
        }

        /// <summary>
        /// Toggles watermark on and off.
        /// </summary>
        private void WaterMarkToggle(object sender, EventArgs e)
        {
            if (Text.Length <= 0)
            {
                EnableWaterMark();
            }
            else
            {
                DisableWaterMark();
            }
        }

        /// <summary>
        /// Enables the watermark.
        /// </summary>
        private void EnableWaterMark()
        {
            //Save current font until returning the UserPaint style to false (NOTE: It is a try and error advice)
            _oldTypeface = new Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit);

            //Enable OnPaint event handler
            //SetStyle(ControlStyles.UserPaint, true);

            WaterMarkTextEnabled = true;

            //Trigger OnPaint immediately
            //Refresh();
        }

        /// <summary>
        /// Disables the watermark.
        /// </summary>
        private void DisableWaterMark()
        {
            //Disable OnPaint event handler
            WaterMarkTextEnabled = false;

            //SetStyle(ControlStyles.UserPaint, false);

            //Return back oldFont if existed
            if (_oldTypeface != null)
            {
                Font = new Font(_oldTypeface.FontFamily, _oldTypeface.Size, _oldTypeface.Style, _oldTypeface.Unit);
            }
        }

        /// <summary>
        /// Fires only when the text has changed.
        /// </summary>
        private void WaterMarkFontChanged(object sender, EventArgs e)
        {
            if (WaterMarkTextEnabled)
            {
                _oldTypeface = new Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit);

                //Refresh();
            }
        }
        #endregion
    }
}