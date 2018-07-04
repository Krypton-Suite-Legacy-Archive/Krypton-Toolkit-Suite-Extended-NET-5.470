using System;

namespace Tooling.Classes.Other
{
    public class RandomNumberGenerator
    {
        #region Variables
        private int _alphaValue, _redValue, _greenValue, _blueValue;
        #endregion

        #region Properties
        public int AlphaValue { get { return _alphaValue; } set { _alphaValue = value; } }

        public int RedValue { get { return _redValue; } set { _redValue = value; } }

        public int GreenValue { get { return _greenValue; } set { _greenValue = value; } }

        public int BlueValue { get { return _blueValue; } set { _blueValue = value; } }
        #endregion

        #region Constructor
        public RandomNumberGenerator()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Randomly generate a number.
        /// </summary>
        /// <param name="startNumber">The start number.</param>
        /// <param name="endNumber">The end number.</param>
        /// <returns></returns>
        public int RandomlyGenerateARedNumberBetween(int startNumber, int endNumber)
        {
            int output1;

            Random random = new Random();

            output1 = random.Next(startNumber, endNumber + 1);

            SetRedValue(output1);

            if (output1 == GetGreenValue() && output1 == GetBlueValue())
            {
                RandomlyGenerateARedNumberBetween(startNumber, endNumber);
            }

            return output1;
        }

        public int RandomlyGenerateAGreenNumberBetween(int startNumber, int endNumber)
        {
            int output2;

            Random random = new Random();

            output2 = random.Next(startNumber, endNumber + 1);

            SetGreenValue(output2);

            if (output2 == GetBlueValue() && output2 == GetRedValue())
            {
                RandomlyGenerateAGreenNumberBetween(startNumber, endNumber);
            }

            return output2;
        }

        public int RandomlyGenerateABlueNumberBetween(int startNumber, int endNumber)
        {
            int output3;

            Random random = new Random();

            output3 = random.Next(startNumber, endNumber + 1);

            SetBlueValue(output3);

            if (output3 == GetGreenValue() && output3 == GetRedValue())
            {
                RandomlyGenerateABlueNumberBetween(startNumber, endNumber);
            }

            return output3;
        }
        #endregion

        #region Setters & Getters
        /// <summary>
        /// Sets the AlpheValue to value of value.
        /// </summary>
        /// <param name="value">The value of the AlpheValue.</param>
        public void SetAlphaValue(int value)
        {
            AlphaValue = value;
        }

        /// <summary>
        /// Gets the AlpheValue current value.
        /// </summary>
        /// <returns>The AlpheValue current value.</returns>
        public int GetAlphaValue()
        {
            return AlphaValue;
        }

        /// <summary>
        /// Sets the RedValue to value of value.
        /// </summary>
        /// <param name="value">The value of the RedValue.</param>
        public void SetRedValue(int value)
        {
            RedValue = value;
        }

        /// <summary>
        /// Gets the RedValue current value.
        /// </summary>
        /// <returns>The RedValue current value.</returns>
        public int GetRedValue()
        {
            return RedValue;
        }

        /// <summary>
        /// Sets the GreenValue to value of value.
        /// </summary>
        /// <param name="value">The value of the GreenValue.</param>
        public void SetGreenValue(int value)
        {
            GreenValue = value;
        }

        /// <summary>
        /// Gets the GreenValue current value.
        /// </summary>
        /// <returns>The GreenValue current value.</returns>
        public int GetGreenValue()
        {
            return GreenValue;
        }

        /// <summary>
        /// Sets the BlueValue to value of value.
        /// </summary>
        /// <param name="value">The value of the BlueValue.</param>
        public void SetBlueValue(int value)
        {
            BlueValue = value;
        }

        /// <summary>
        /// Gets the BlueValue current value.
        /// </summary>
        /// <returns>The BlueValue current value.</returns>
        public int GetBlueValue()
        {
            return BlueValue;
        }
        #endregion
    }
}