using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore.Components.Controls
{
    public class KryptonKnobControlEnhanced : UserControl
    {
        #region Designer Code
        private Container components = null;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // KryptonKnobControlEnhanced
            // 
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "KryptonKnobControlEnhanced";
            this.Resize += new System.EventHandler(this.KryptonKnobControlEnhanced_Resize);

        }

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
        #endregion

        #region Variables
        private bool _showSmallScale = false, _showLargeScale = true, _isFocused = false, _isKnobRotating = false;

        private Brush _bKnob, _bKnobPoint;

        private Rectangle _rKnob, _rScale;

        private int _minimum = 0, _maximum = 25, _largeChange = 5, _smallChange = 1, _value = 0;

        private Point _pKnob;

        private Pen _dottedPen;

        private Image _offScreenImage;

        private Graphics _gOffScreen;

        private IPalette _palette;
        #endregion

        #region Properties
        /// <summary>
        /// Shows Small Scale marking.
        /// </summary>
        public bool ShowSmallScale
        {
            get => _showSmallScale;

            set
            {
                _showSmallScale = value;
                // need to redraw 
                Refresh();
            }
        }

        /// <summary>
        /// Shows Large Scale marking
        /// </summary>
        public bool ShowLargeScale
        {
            get => _showLargeScale;

            set
            {
                _showLargeScale = value;
                // need to redraw
                Refresh();
            }
        }

        /// <summary>
        /// Minimum Value for knob Control
        /// </summary>
        public int Minimum
        {
            get => _minimum;
            set => _minimum = value;
        }
        /// <summary>
        /// Maximum value for knob control
        /// </summary>
        public int Maximum
        {
            get => _maximum;
            set => _maximum = value;
        }

        /// <summary>
        /// value set for large change
        /// </summary>
        public int LargeChange
        {
            get => _largeChange;

            set
            {
                _largeChange = value;
                Refresh();
            }
        }
        /// <summary>
        /// value set for small change.
        /// </summary>
        public int SmallChange
        {
            get => _smallChange;

            set
            {
                _smallChange = value;
                Refresh();
            }
        }

        /// <summary>
        /// Current Value of knob control
        /// </summary>
        public int Value
        {
            get => _value;

            set
            {

                _value = value;
                // need to redraw 
                Refresh();
                // call delegate  
                OnValueChanged(this);
            }
        }
        #endregion

        #region Delegates
        public delegate void ValueChangedEventHandler(object sender);
        #endregion

        #region Events
        public event ValueChangedEventHandler ValueChanged;
        #endregion

        #region Virtual
        protected virtual void OnValueChanged(object sender)
        {
            if (ValueChanged != null)
            {
                ValueChanged(sender);
            }
        }
        #endregion

        #region Constructor
        public KryptonKnobControlEnhanced()
        {
            //_dottedPen 
        }
        #endregion

        private void KryptonKnobControlEnhanced_Resize(object sender, EventArgs e)
        {

        }
    }
}