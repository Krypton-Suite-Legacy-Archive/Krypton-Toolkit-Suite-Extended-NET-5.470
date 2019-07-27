using System;

namespace ExtendedControls.Base.Code.Colours
{
    public class HexadecimalHelper
    {
        public HexadecimalHelper()
        {

        }

        public static bool IsNumber(string value)
        {
            if (value.Length == 0) return false;

            for (int i = 0; i < value.Length; i++)
            {
                if (!(Char.IsDigit(value[i]))) return false;
            }

            return true;
        }

        public static bool IsHexadecimal(string hexadecimalValue)
        {
            if (hexadecimalValue.Length == 0) return false;

            for (int i = 0; i < hexadecimalValue.Length; i++)
            {
                if (!((Char.IsDigit(hexadecimalValue[i])) || (hexadecimalValue[i] == 'A') || (hexadecimalValue[i] == 'B') || (hexadecimalValue[i] == 'C') || (hexadecimalValue[i] == 'D') || (hexadecimalValue[i] == 'E') || (hexadecimalValue[i] == 'F'))) return false;
            }

            return true;
        }

        public static int GetNumberFromNotation(char character)
        {
            if (character == 'A')
            {
                return 10;
            }
            else if (character == 'B')
            {
                return 11;
            }
            else if (character == 'C')
            {
                return 12;
            }
            else if (character == 'D')
            {
                return 13;
            }
            else if (character == 'E')
            {
                return 14;
            }
            else if (character == 'F')
            {
                return 15;
            }

            return Convert.ToInt32(character.ToString());
        }
    }
}