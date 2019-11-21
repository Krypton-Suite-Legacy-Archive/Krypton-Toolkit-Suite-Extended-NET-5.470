#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Collections;
using System.Data;

namespace ExtendedControls.Base.Code.Security
{
    public class PasswordStrength
    {
        #region Variables
        private DataTable _dtDetails;
        private string _previousPassword = string.Empty;
        #endregion

        #region Properties
        public DataTable Details { get => _dtDetails; set => _dtDetails = value; }

        public string PreviousPassword { get => _previousPassword; set => _previousPassword = value; }
        #endregion

        #region Methods
        public static void SetPassword(string password)
        {
            PasswordStrength passwordStrength = new PasswordStrength();

            if (passwordStrength.PreviousPassword != password)
            {
                passwordStrength.PreviousPassword = password;

                CheckPasswordWithDetails(passwordStrength.PreviousPassword);
            }
        }

        public static int GetPasswordScore()
        {
            PasswordStrength passwordStrength = new PasswordStrength();

            if (passwordStrength.Details != null)
            {
                return (int)passwordStrength.Details.Rows[0][5];
            }
            else
            {
                return 0;
            }
        }

        public static string GetPasswordStrength()
        {
            PasswordStrength passwordStrength = new PasswordStrength();

            if (passwordStrength.Details != null)
            {
                return (string)passwordStrength.Details.Rows[0][3];
            }
            else
            {
                return "Unknown";
            }
        }

        public static DataTable GetStrengthDetails()
        {
            PasswordStrength passwordStrength = new PasswordStrength();

            return passwordStrength.Details;
        }

        private static void CheckPasswordWithDetails(string password)
        {
            #region Variables
            int nScore = 0;
            string sComplexity = "";
            int iUpperCase = 0;
            int iLowerCase = 0;
            int iDigit = 0;
            int iSymbol = 0;
            int iRepeated = 1;
            Hashtable htRepeated = new Hashtable();
            int iMiddle = 0;
            int iMiddleEx = 1;
            int ConsecutiveMode = 0;
            int iConsecutiveUpper = 0;
            int iConsecutiveLower = 0;
            int iConsecutiveDigit = 0;
            int iLevel = 0;
            string sAlphas = "abcdefghijklmnopqrstuvwxyz";
            string sNumerics = "01234567890";
            int nSeqAlpha = 0;
            int nSeqChar = 0;
            int nSeqNumber = 0;
            #endregion

            CreateDetailsTable();

            DataRow score = AddDetailsRow(iLevel++, "Score", "", "", 0, 0);

            foreach (char ch in password.ToCharArray())
            {
                if (Char.IsDigit(ch))
                {
                    iDigit++;

                    if (ConsecutiveMode == 3)
                    {
                        iConsecutiveDigit++;
                    }

                    ConsecutiveMode = 3;
                }

                if (Char.IsUpper(ch))
                {
                    iUpperCase++;

                    if (ConsecutiveMode == 1)
                    {
                        iConsecutiveUpper++;
                    }

                    ConsecutiveMode = 1;
                }

                if (Char.IsLower(ch))
                {
                    iLowerCase++;

                    if (ConsecutiveMode == 2)
                    {
                        iConsecutiveLower++;
                    }

                    ConsecutiveMode = 2;
                }

                if (Char.IsSymbol(ch) || Char.IsPunctuation(ch))
                {
                    iSymbol++;

                    ConsecutiveMode = 2;
                }

                if (Char.IsLetter(ch))
                {
                    if (htRepeated.Contains(Char.ToLower(ch)))
                    {
                        iRepeated++;
                    }
                    else
                    {
                        htRepeated.Add(Char.ToLower(ch), 0);
                    }

                    if (iMiddleEx > 1)
                    {
                        iMiddle = iMiddleEx - 1;
                    }
                }

                if (iUpperCase > 0 || iLowerCase > 0)
                {
                    if (Char.IsDigit(ch) || Char.IsSymbol(ch))
                    {
                        iMiddleEx++;
                    }
                }
            }

            // Check for sequential alpha string patterns (forward and reverse) 
            for (int s = 0; s < 23; s++)
            {
                string sFwd = sAlphas.Substring(s, 3);
                string sRev = strReverse(sFwd);
                if (password.ToLower().IndexOf(sFwd) != -1 || password.ToLower().IndexOf(sRev) != -1)
                {
                    nSeqAlpha++;
                    nSeqChar++;
                }
            }

            // Check for sequential numeric string patterns (forward and reverse)
            for (int s = 0; s < 8; s++)
            {
                string sFwd = sNumerics.Substring(s, 3);
                string sRev = strReverse(sFwd);
                if (password.ToLower().IndexOf(sFwd) != -1 || password.ToLower().IndexOf(sRev) != -1)
                {
                    nSeqNumber++;
                    nSeqChar++;
                }
            }

            // Calcuate score
            AddDetailsRow(iLevel++, "Additions", "", "", 0, 0);

            // Score += 4 * Password Length
            nScore = 4 * password.Length;
            AddDetailsRow(iLevel++, "Password Length", "Flat", "(n*4)", password.Length, password.Length * 4);

            // if we have uppercase letetrs Score +=(number of uppercase letters *2)
            if (iUpperCase > 0)
            {
                nScore += ((password.Length - iUpperCase) * 2);
                AddDetailsRow(iLevel++, "Uppercase Letters", "Cond/Incr", "+((len-n)*2)", iUpperCase, ((password.Length - iUpperCase) * 2));
            }
            else
                AddDetailsRow(iLevel++, "Uppercase Letters", "Cond/Incr", "+((len-n)*2)", iUpperCase, 0);

            // if we have lowercase letetrs Score +=(number of lowercase letters *2)
            if (iLowerCase > 0)
            {
                nScore += ((password.Length - iLowerCase) * 2);
                AddDetailsRow(iLevel++, "Lowercase Letters", "Cond/Incr", "+((len-n)*2)", iLowerCase, ((password.Length - iLowerCase) * 2));
            }
            else
                AddDetailsRow(iLevel++, "Lowercase Letters", "Cond/Incr", "+((len-n)*2)", iLowerCase, 0);


            // Score += (Number of digits *4)
            nScore += (iDigit * 4);
            AddDetailsRow(iLevel++, "Numbers", "Cond", "+(n*4)", iDigit, (iDigit * 4));

            // Score += (Number of Symbols * 6)
            nScore += (iSymbol * 6);
            AddDetailsRow(iLevel++, "Symbols", "Flat", "+(n*6)", iSymbol, (iSymbol * 6));

            // Score += (Number of digits or symbols in middle of password *2)
            nScore += (iMiddle * 2);
            AddDetailsRow(iLevel++, "Middle Numbers or Symbols", "Flat", "+(n*2)", iMiddle, (iMiddle * 2));

            //requirments
            int requirments = 0;
            if (password.Length >= 8) requirments++;     // Min password length
            if (iUpperCase > 0) requirments++;      // Uppercase letters
            if (iLowerCase > 0) requirments++;      // Lowercase letters
            if (iDigit > 0) requirments++;          // Digits
            if (iSymbol > 0) requirments++;         // Symbols

            // If we have more than 3 requirments then
            if (requirments > 3)
            {
                // Score += (requirments *2) 
                nScore += (requirments * 2);
                AddDetailsRow(iLevel++, "Requirments", "Flat", "+(n*2)", requirments, (requirments * 2));
            }
            else
                AddDetailsRow(iLevel++, "Requirments", "Flat", "+(n*2)", requirments, 0);

            //
            // Deductions
            //
            AddDetailsRow(iLevel++, "Deductions", "", "", 0, 0);

            // If only letters then score -=  password length
            if (iDigit == 0 && iSymbol == 0)
            {
                nScore -= password.Length;
                AddDetailsRow(iLevel++, "Letters only", "Flat", "-n", password.Length, -password.Length);
            }
            else
                AddDetailsRow(iLevel++, "Letters only", "Flat", "-n", 0, 0);

            // If only digits then score -=  password length
            if (iDigit == password.Length)
            {
                nScore -= password.Length;
                AddDetailsRow(iLevel++, "Numbers only", "Flat", "-n", password.Length, -password.Length);
            }
            else
                AddDetailsRow(iLevel++, "Numbers only", "Flat", "-n", 0, 0);

            // If repeated letters used then score -= (iRepeated * (iRepeated - 1));
            if (iRepeated > 1)
            {
                nScore -= (iRepeated * (iRepeated - 1));
                AddDetailsRow(iLevel++, "Repeat Characters (Case Insensitive)", "Incr", "-(n(n-1))", iRepeated, -(iRepeated * (iRepeated - 1)));
            }

            // If Consecutive uppercase letters then score -= (iConsecutiveUpper * 2);
            nScore -= (iConsecutiveUpper * 2);
            AddDetailsRow(iLevel++, "Consecutive Uppercase Letters", "Flat", "-(n*2)", iConsecutiveUpper, -(iConsecutiveUpper * 2));

            // If Consecutive lowercase letters then score -= (iConsecutiveUpper * 2);
            nScore -= (iConsecutiveLower * 2);
            AddDetailsRow(iLevel++, "Consecutive Lowercase Letters", "Flat", "-(n*2)", iConsecutiveLower, -(iConsecutiveLower * 2));

            // If Consecutive digits used then score -= (iConsecutiveDigits* 2);
            nScore -= (iConsecutiveDigit * 2);
            AddDetailsRow(iLevel++, "Consecutive Numbers", "Flat", "-(n*2)", iConsecutiveDigit, -(iConsecutiveDigit * 2));

            // If password contains sequence of letters then score -= (nSeqAlpha * 3)
            nScore -= (nSeqAlpha * 3);
            AddDetailsRow(iLevel++, "Sequential Letters (3+)", "Flat", "-(n*3)", nSeqAlpha, -(nSeqAlpha * 3));

            // If password contains sequence of digits then score -= (nSeqNumber * 3)
            nScore -= (nSeqNumber * 3);
            AddDetailsRow(iLevel++, "Sequential Numbers (3+)", "Flat", "-(n*3)", nSeqNumber, -(nSeqNumber * 3));

            /* Determine complexity based on overall score */
            if (nScore > 100) { nScore = 100; } else if (nScore < 0) { nScore = 0; }
            if (nScore >= 0 && nScore < 20) { sComplexity = "Very Weak"; }
            else if (nScore >= 20 && nScore < 40) { sComplexity = "Weak"; }
            else if (nScore >= 40 && nScore < 60) { sComplexity = "Good"; }
            else if (nScore >= 60 && nScore < 80) { sComplexity = "Strong"; }
            else if (nScore >= 80 && nScore <= 100) { sComplexity = "Very Strong"; }

            // Store score and complexity in dataset
            score[5] = nScore;

            score[3] = sComplexity;

            PasswordStrength passwordStrength = new PasswordStrength();

            passwordStrength.Details.AcceptChanges();
        }

        private static string strReverse(string str)
        {
            string newString = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                newString = str[i] + newString;
            }

            return newString;
        }

        private static DataRow AddDetailsRow(int identity, string description, string type, string rate, int count, int bonus)
        {
            PasswordStrength passwordStrength = new PasswordStrength();

            DataRow row = passwordStrength.Details.NewRow();

            row[0] = identity;

            row[1] = description;

            row[2] = type;

            row[3] = rate;

            row[4] = count;

            row[5] = bonus;

            passwordStrength.Details.Rows.Add(row);

            passwordStrength.Details.AcceptChanges();

            return row;
        }

        private static void CreateDetailsTable()
        {
            PasswordStrength passwordStrength = new PasswordStrength();

            passwordStrength.Details = new DataTable("PasswordDetails");

            passwordStrength.Details.Columns.Add(new DataColumn("Level", typeof(Int32)));

            passwordStrength.Details.Columns.Add(new DataColumn("Description", typeof(String)));

            passwordStrength.Details.Columns.Add(new DataColumn("Type", typeof(String)));

            passwordStrength.Details.Columns.Add(new DataColumn("Rate", typeof(String)));

            passwordStrength.Details.Columns.Add(new DataColumn("Count", typeof(Int32)));

            passwordStrength.Details.Columns.Add(new DataColumn("Bonus", typeof(Int32)));
        }
        #endregion
    }
}