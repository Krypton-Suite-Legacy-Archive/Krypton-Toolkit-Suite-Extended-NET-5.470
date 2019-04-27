using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    public class KryptonFlashingLabel : ComponentFactory.Krypton.Toolkit.KryptonLabel
    {
        #region Variables
        bool _flashTimerEnabled;

        Color _backColourOne, _backColourTwo, _foreColourOne, _foreColourTwo;

        Timer _flashTimer;

        int _currentFlashCount, _maximumFlashCount, _flashTimerInterval;
        #endregion

        #region Properties
        public bool EnableFlashTimer { get => _flashTimerEnabled; set => _flashTimerEnabled = value; }

        public Color BackColourOne { get => _backColourOne; set => _backColourOne = value; }

        public Color BackColourTwo { get => _backColourTwo; set => _backColourTwo = value; }

        public Color ForeColourOne { get => _foreColourOne; set => _foreColourOne = value; }

        public Color ForeColourTwo { get => _foreColourTwo; set => _foreColourTwo = value; }

        private int CurrentFlashCount { get => _currentFlashCount; set => _currentFlashCount = value; }

        public int MaximumFlashCount { get => _maximumFlashCount; set => _maximumFlashCount = value; }

        public int FlashTimerInterval { get => _flashTimerInterval; set => _flashTimerInterval = value; }
        #endregion

        #region Constructor        
        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonFlashingLabel"/> class.
        /// </summary>
        public KryptonFlashingLabel()
        {
            _flashTimer = new Timer();

            _flashTimer.Enabled = EnableFlashTimer;

            _flashTimer.Interval = FlashTimerInterval;

            _flashTimer.Tick += FlashTimer_Tick;

            InitialiseColours();
        }
        #endregion

        #region Event Handlers        
        /// <summary>
        /// Handles the Tick event of the FlashTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FlashTimer_Tick(object sender, EventArgs e)
        {
            Flash(MaximumFlashCount, BackColourOne, BackColourTwo, ForeColourOne, ForeColourTwo);
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Flashes the specified maximum flash count.
        /// </summary>
        /// <param name="maxFlashCount">The maximum flash count.</param>
        /// <param name="backColourOne">The back colour one.</param>
        /// <param name="backColourTwo">The back colour two.</param>
        /// <param name="foreColourOne">The fore colour one.</param>
        /// <param name="foreColourTwo">The fore colour two.</param>
        public void Flash(int maxFlashCount, Color backColourOne, Color backColourTwo, Color foreColourOne, Color foreColourTwo)
        {
            // Reset the counter to 0
            CurrentFlashCount = 0;

            while (CurrentFlashCount < maxFlashCount)
            {


                CurrentFlashCount++;
            }

            _flashTimer.Stop();
        }

        /// <summary>
        /// Starts the timer.
        /// </summary>
        /// <param name="startTimer">if set to <c>true</c> [start timer].</param>
        public void StartTimer(bool startTimer)
        {
            if (startTimer)
            {
                _flashTimer.Start();
            }
        }

        private void InitialiseColours()
        {
            KryptonPalette palette = new KryptonPalette();

            BackColourOne = palette.GetBackColor1(PaletteBackStyle.ButtonCustom1, PaletteState.Normal);

            ForeColourOne = StateCommon.GetContentLongTextColor1(PaletteState.Normal);
        }
        #endregion
    }
}