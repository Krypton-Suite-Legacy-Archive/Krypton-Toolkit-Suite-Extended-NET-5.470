using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace ExtendedControls.ExtendedToolkit.Controls.TreeGridView
{
    /// <summary>
    /// Summary description for util.
    /// </summary>
    public class util
    {
        public util()
        {
        }

        //=================================
        // ARRAY
        //=================================
        //Gets a list of the items in an array missing from a second array.
        //This is useful when it is necessary to compare two arrays and to know what items are not included in one of the arrays.
        //This method uses
        //System.Collections
        //
        public ArrayList GetMissingItems(string[] allItems, ArrayList someItems)
        {
            ArrayList missingItems = new ArrayList();
            for (int i = 0; i < allItems.Length; i++)
            {
                if (allItems[i].Trim().Length > 0) //filter out empty strings
                {
                    if (!someItems.Contains(allItems[i].Trim()))
                    {
                        missingItems.Add(allItems[i]);
                    }
                }
            }
            return missingItems;
        }

        public string[] GetMissingItems(string[] allItems, string[] someItems)
        {
            ArrayList missingItems = new ArrayList();
            for (int i = 0; i < allItems.Length; i++)
            {
                bool match = false;
                if (allItems[i].Trim().Length > 0) //filter out empty strings
                {
                    for (int j = 0; j < someItems.Length; j++)
                    {
                        if (someItems[j].Trim().Equals(allItems[i].Trim()))
                        {
                            match = true;
                        }
                    }
                    if (!match)
                    {
                        missingItems.Add(allItems[i]);
                    }
                }
            }
            string[] aMissingItems = new string[missingItems.Count];
            missingItems.CopyTo(aMissingItems);

            return aMissingItems;
        }

        //Removes any duplicate items for a list of items.
        //This method takes an array of strings and returns a array of strings where each item is unique.  It also has the option to sort the list.
        //This method uses
        //System.Collections
        //
        public string[] RemoveDups(string[] items, bool sort)
        {
            ArrayList noDups = new ArrayList();
            for (int i = 0; i < items.Length; i++)
            {
                if (!noDups.Contains(items[i].Trim()))
                {
                    noDups.Add(items[i].Trim());
                }
            }
            if (sort) noDups.Sort();  //sorts list alphabetically
            string[] uniqueItems = new String[noDups.Count];
            noDups.CopyTo(uniqueItems);
            return uniqueItems;
        }

        //Converts an array of strings into a string. 
        //This method is useful for converting form data to string for database. If quotes are not necessary, it is easier to use the built-in join method.
        //string jstr = String.Join(",", astr);
        public string StringArrayToString(string[] astr, bool quotes)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < astr.Length; i++)
            {
                if (astr[i].Trim().Length > 0)
                {
                    string delim = i > 0 ? "," : string.Empty;
                    if (quotes)
                    {
                        sb.Append(delim + "'" + astr[i].Trim() + "'");
                    }
                    else
                    {
                        sb.Append(delim + astr[i].Trim());
                    }
                }
            }
            return sb.ToString();
        }

        //=================================
        // COLOR
        //=================================
        //Converts a color into an html hexadecimal string.
        //The first version of this uses the ColorTranslator Class.  If the ColorTranslator.ToHtml method is passed a color directly, such as ColorTranslator.ToHtml(Color.BlanchedAlmond), it will return the color name, in this case BlanchedAlmond.  To avoid this and to get a hexadecimal string, in this case #FFEBCD, the color is first converted to a 32-bit ARGB value, then that value is converted back to a color.  Since the color came from a number, the ColorTranslator.ToHtml method converts it to a hexadecimal string instead of a color name string.
        //The second and third version, sent in by <b>Phong Tran</b>, are more elegant ways to get a hexadecimal string from a Color object.
        //This method uses System.Drawing namespace.
        //
        public string ColorToHtml1(Color color)
        {
            return ColorTranslator.ToHtml(Color.FromArgb(color.ToArgb()));
        }

        public string ColorToHtml2(Color color)
        {
            return string.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);
        }

        public string ColorToHtml3(Color color)
        {
            return string.Format("#{0:X6}", color.ToArgb() & 0x00ffffff);
        }

        //Get an html table listing color, html hexadecimal, and color name.
        //This method uses the <a href="detail.aspx?id=26">ColorToHtml</a> method to get the html hexadecimal value.
        //This method uses System.Drawing namespace.
        public string GetColorTable()
        {
            Array colors = Enum.GetValues(typeof(KnownColor));
            StringBuilder sb = new StringBuilder();
            sb.Append("<table border=\"1\">");
            sb.Append("<tr><td>Color</td>");
            sb.Append("<td>HTML</td>");
            sb.Append("<td>Color Name</td>");
            sb.Append("</tr>");
            foreach (KnownColor kc in colors)
            {
                Color color = Color.FromKnownColor(kc);
                string html = ColorToHtml1(color);
                sb.Append("<tr><td bgcolor=" + html + ">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>");
                sb.Append("<td>" + html + "</td>");
                sb.Append("<td>" + color.Name + "</td>");
                sb.Append("</tr>");
            }
            sb.Append("</table>");

            return sb.ToString();
        }

        //Gets a random color.
        //This method uses System.Drawing namespace.
        public Color GetRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        //=================================
        // DATASET
        //=================================
        //Converts an array of strings to a DataTable.
        //Each string in the array becomes a row in the DataTable.  If the first string in the array has header information set headers to true and the columns of the DataTable will be named using the first string of the array.  This method is useful for reading a delimited file and converting it to a DataTable.
        //This method can be used with the <a href="detail.aspx?id=33">FileToArray</a> method to convert a delimited text file into a DataTable.
        //For example:<br>
        //<table><tr><td bgcolor="#efefef"><pre>  DataTable dt = ArrayToDataTable(FileToArray(@"C:\misc\xyz.txt"), new char[1]{','}, true);</pre></td><tr></table>
        //This method can also be used with the following methods:<br>
        //<a href="detail.aspx?id=35">GetFileInfo</a>, <a href="detail.aspx?id=36">GetDirectoryInfo</a>, <a href="detail.aspx?id=37">GetDirectoryFileInfo</a>, <a href="detail.aspx?id=38">GetHttpHeaders</a>, <a href="detail.aspx?id=39">DNSLookup</a>
        //The first method can be used with any type of single character delimiter and multiple single character delimiters, but does not ignore delimiters if they are inside quotation marks.
        //The second method is for using with strings in standard csv format.  If the commas are inside quotation marks, they are ignored.  Double quotation marks are considered as single quotation marks.
        //The first method uses 
        //System.Data namespace
        //The second method uses
        //System.Data namespace
        //System.Text.RegularExpressions
        //
        public DataTable ArrayToDataTable(string[] arr, char[] delimiter, bool headers)
        {
            DataTable dt = new DataTable();
            string[] header = arr[0].Split(delimiter);
            foreach (string head in header)
            {
                if (headers)
                {
                    dt.Columns.Add(head);
                }
                else
                {
                    dt.Columns.Add();
                }
            }

            for (int irow = 0; irow < arr.Length; irow++)
            {
                if (!((headers) && (irow == 0)))
                {
                    string str = arr[irow];
                    string[] item = str.Split(delimiter);
                    DataRow dr = dt.NewRow();
                    for (int icol = 0; icol < item.Length; icol++)
                    {
                        dr[icol] = item[icol];
                    }
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

        public DataTable ArrayToDataTable(string[] arr, bool headers)
        {
            DataTable dt = new DataTable();
            //pattern for matching csv format
            string pattern = "(?:^|,)(?:\"((?>[^\"]+|\"\")*)\"|([^\",]*))";
            Regex regex = new Regex(pattern);

            for (int irow = 0; irow < arr.Length; irow++)
            {
                Match match = regex.Match(arr[irow]);
                DataRow dr = dt.NewRow();
                int icol = 0;
                while (match.Success)
                {
                    string item = string.Empty;
                    if (match.Groups[1].Success)
                    {
                        item = match.Groups[1].Value.Replace("\"\"", "\"");
                    }
                    else
                    {
                        item = match.Groups[2].Value;
                    }
                    if (irow == 0)
                    {
                        if (headers)
                        {
                            dt.Columns.Add(item);
                        }
                        else
                        {
                            dt.Columns.Add();
                            dr[icol] = item;
                        }
                    }
                    else
                    {
                        dr[icol] = item;
                    }
                    icol++;
                    match = match.NextMatch();
                }
                if (!((irow == 0) && (headers)))
                {
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

        //Coverts a DataTable into an Excel string.
        //Use this method with the <a href="detail.aspx?id=13">WriteToFile method</a> to save a datatable as an Excel file.  Here is an example:
        //WriteToFile(DataTable2ExcelString(dt), @"C:\ExcelFiles\" + dt.TableName + ".xls");
        //DataSet2ExcelString converts a DataSet to an Excel string.  It loops through each of the DataTables in the DataSet.  There is also an option of whether to print the table headers (column names).
        //This method uses System.Data namespace
        public string DataTable2ExcelString(DataTable dt)
        {
            StringBuilder sbTop = new StringBuilder();
            sbTop.Append("<html xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:x=\"urn:schemas-microsoft-com:office:excel\" ");
            sbTop.Append("xmlns=\"http://www.w3.org/TR/REC-html40\"><head><meta http-equiv=Content-Type content=\"text/html; charset=windows-1252\">");
            sbTop.Append("<meta name=ProgId content=Excel.Sheet><meta name=Generator content=\"Microsoft Excel 9\"><!--[if gte mso 9]>");
            sbTop.Append("<xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>" + dt.TableName + "</x:Name><x:WorksheetOptions>");
            sbTop.Append("<x:Selected/><x:ProtectContents>False</x:ProtectContents><x:ProtectObjects>False</x:ProtectObjects>");
            sbTop.Append("<x:ProtectScenarios>False</x:ProtectScenarios></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets>");
            sbTop.Append("<x:ProtectStructure>False</x:ProtectStructure><x:ProtectWindows>False</x:ProtectWindows></x:ExcelWorkbook></xml>");
            sbTop.Append("<![endif]--></head><body><table>");
            string bottom = "</table></body></html>";
            StringBuilder sb = new StringBuilder();
            //Header
            sb.Append("<tr>");
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sb.Append("<td>" + dt.Columns[i].ColumnName + "</td>");
            }
            sb.Append("</tr>");

            //Items
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                sb.Append("<tr>");
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sb.Append("<td>" + dt.Rows[x][i] + "</td>");
                }
                sb.Append("</tr>");
            }

            string SSxml = sbTop.ToString() + sb.ToString() + bottom;

            return SSxml;
        }

        public string DataSet2ExcelString(DataSet ds, string title, bool printHeaders)
        {
            StringBuilder sbTop = new StringBuilder();
            sbTop.Append("<html xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:x=\"urn:schemas-microsoft-com:office:excel\" ");
            sbTop.Append("xmlns=\"http://www.w3.org/TR/REC-html40\"><head><meta http-equiv=Content-Type content=\"text/html; charset=windows-1252\">");
            sbTop.Append("<meta name=ProgId content=Excel.Sheet><meta name=Generator content=\"Microsoft Excel 9\"><!--[if gte mso 9]>");
            sbTop.Append("<xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>" + title + "</x:Name><x:WorksheetOptions>");
            sbTop.Append("<x:Selected/><x:ProtectContents>False</x:ProtectContents><x:ProtectObjects>False</x:ProtectObjects>");
            sbTop.Append("<x:ProtectScenarios>False</x:ProtectScenarios></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets>");
            sbTop.Append("<x:ProtectStructure>False</x:ProtectStructure><x:ProtectWindows>False</x:ProtectWindows></x:ExcelWorkbook></xml>");
            sbTop.Append("<![endif]--></head><body><table>");
            string bottom = "</body></html>";
            StringBuilder sb = new StringBuilder();

            sb.Append("</table><table><tr><td colspan=\"4\"><h3><b>" + title + "</b></h3></td></tr></table>");
            sb.Append("</table><table><tr><td></td></tr></table>");
            for (int t = 0; t < ds.Tables.Count; t++)
            {
                sb.Append("<table>");
                if (printHeaders)
                {
                    sb.Append("<tr><td colspan=\"" + ds.Tables[t].Columns.Count + "\"><b>" + ds.Tables[t].TableName.ToUpper() + "</b></td></tr>");
                    sb.Append("<tr bgcolor=\"#cccccc\">");
                    for (int i = 0; i < ds.Tables[t].Columns.Count; i++)
                    {
                        sb.Append("<td><b>" + ds.Tables[t].Columns[i].ColumnName + "</b></td>");
                    }
                    sb.Append("</tr>");
                }

                for (int x = 0; x < ds.Tables[t].Rows.Count; x++)
                {
                    sb.Append("<tr>");
                    for (int i = 0; i < ds.Tables[t].Columns.Count; i++)
                    {
                        sb.Append("<td>" + ds.Tables[t].Rows[x][i] + "</td>");
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table><table><tr><td></td></tr></table>");
            }

            string SSxml = sbTop.ToString() + sb.ToString() + bottom;

            return SSxml;
        }

        //Creates a string array from a DataTable.
        //This method converts a DataTable into an array of strings where each row of the table becomes a string in the array.  This is useful for converting a DataTable to a comma separated file.
        //This method can be used with the <a href="detail.aspx?id=34">ArrayToFile</a> method to save a DataTable as a delimited text file.
        //For example:<br>
        //<table><tr><td bgcolor="#efefef"><pre>  ArrayToFile( DataTableToArray(datatable, ",", false), @"C:\misc\xyz.txt" );</pre></td><tr></table>
        //This method uses System.Data namespace
        public static string[] DataTableToArray(DataTable dt, string delimiter, bool headers)
        {
            int rowCnt = (headers) ? (dt.Rows.Count + 1) : dt.Rows.Count;
            string[] arr = new string[rowCnt];

            if (headers)
            {
                //write column headings
                string colstr = string.Empty;
                for (int icol = 0; icol < dt.Columns.Count; icol++)
                {
                    DataColumn dc = dt.Columns[icol];
                    if (icol == 0)
                    {
                        colstr = dc.ColumnName;
                    }
                    else
                    {
                        colstr += delimiter + dc.ColumnName;
                    }
                }
                arr[0] = colstr;
            }

            //write table data
            for (int irow = 0; irow < dt.Rows.Count; irow++)
            {
                DataRow dr = dt.Rows[irow];
                string str = string.Empty;
                for (int icol = 0; icol < dt.Columns.Count; icol++)
                {
                    //if item contains delimiter, put quotes around item
                    string item = (dr[icol].ToString().IndexOf(delimiter) > -1)
                      ? "\"" + dr[icol].ToString() + "\"" : dr[icol].ToString();
                    if (icol == 0)
                    {
                        str = item;
                    }
                    else
                    {
                        str += delimiter + item;
                    }
                }
                int add = (headers) ? 1 : 0; //add row if headers is true
                arr[irow + add] = str;
            }

            return arr;
        }

        //Converts a DataTable to a string with an html table.
        //This method uses System.Data namespace
        public string DataTableToString(DataTable dt, bool headers)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table border=\"1\">");
            if (headers)
            {
                //write column headings
                sb.Append("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    sb.Append("<td>" + dc.ColumnName + "</td>");
                }
                sb.Append("</tr>");
            }

            //write table data
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    sb.Append("<td>" + dr[dc].ToString() + "</td>");
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");

            return sb.ToString();
        }

        //Filter and sort a dataset.
        //There are three versions of this overloaded method.
        //Version 1: Pass in a DataSet, Number of Table, FilterString, SortString
        //Version 2: Pass in a DataSet, FilterString, SortString (only works on the first table of a DataSet)
        //Version 3: Pass in a DataTable, FilterString, SortString
        //This method uses System.Data namespace.
        public DataSet FilterSortData(DataSet dsStart, int iTbl, string filter, string sort)
        {
            DataTable dt = dsStart.Tables[iTbl].Clone();
            DataRow[] drs = dsStart.Tables[iTbl].Select(filter, sort);
            foreach (DataRow dr in drs)
            {
                dt.ImportRow(dr);
            }

            DataSet ds = new DataSet();
            for (int i = 0; i < dsStart.Tables.Count; i++)
            {
                if (i == iTbl)
                {
                    ds.Tables.Add(dt);
                }
                else
                {
                    ds.Tables.Add(dsStart.Tables[i].Copy());
                }
            }

            return ds;
        }

        public DataSet FilterSortData(DataSet dsStart, string filter, string sort)
        {
            DataSet ds = dsStart.Clone();
            DataRow[] drs = dsStart.Tables[0].Select(filter, sort);
            foreach (DataRow dr in drs)
            {
                ds.Tables[0].ImportRow(dr);
            }

            return ds;
        }

        public DataTable FilterSortData(DataTable dtStart, string filter, string sort)
        {
            DataTable dt = dtStart.Clone();
            DataRow[] drs = dtStart.Select(filter, sort);
            foreach (DataRow dr in drs)
            {
                dt.ImportRow(dr);
            }

            return dt;
        }


        //=================================
        // DATETIME
        //=================================
        //Counts the number of weekdays between two dates.
        //This method uses the <a href="detail.aspx?id=40">IsWeekDay</a> method to determine if a given day is a weekday.
        public int CountWeekdays(DateTime startTime, DateTime endTime)
        {
            TimeSpan ts = endTime - startTime;
            Console.WriteLine(ts.Days);
            int cnt = 0;
            for (int i = 0; i < ts.Days; i++)
            {
                DateTime dt = startTime.AddDays(i);
                if (IsWeekDay(dt))
                {
                    cnt++;
                }
            }

            return cnt;
        }

        //Counts the number of weekends between two dates.
        //This method uses the <a href="detail.aspx?id=41">IsWeekEnd</a> method to determine if a given day is a weekend.
        public int CountWeekends(DateTime startTime, DateTime endTime)
        {
            TimeSpan ts = endTime - startTime;
            Console.WriteLine(ts.Days);
            int cnt = 0;
            for (int i = 0; i < ts.Days; i++)
            {
                DateTime dt = startTime.AddDays(i);
                if (IsWeekEnd(dt))
                {
                    cnt++;
                }
            }

            return cnt;
        }

        //Checks whether an object is a date.
        public static bool IsDate(object dt)
        {
            try
            {
                System.DateTime.Parse(dt.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Returns true of day is weekday, otherwise false.
        public bool IsWeekDay(DateTime dt)
        {
            if ((dt.DayOfWeek == DayOfWeek.Saturday) || (dt.DayOfWeek == DayOfWeek.Sunday))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Returns true of day is weekend, otherwise false.
        public bool IsWeekEnd(DateTime dt)
        {
            if ((dt.DayOfWeek == DayOfWeek.Saturday) || (dt.DayOfWeek == DayOfWeek.Sunday))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Returns a string that enumerates years, months, days, etc.
        //This method lists the time in words between a start time and an end time.  For example, if right now I put in a start date of May 28, 1987 2:30:15 PM (my oldest son's birthday) and an end date of DateTime.Now, this method would return the following string: 15 years 4 months 6 days 18 hours 10 minutes 56 seconds.
        public string TimeBreakdown(DateTime startTime, DateTime endTime)
        {
            int seconds = endTime.Second - startTime.Second;
            int minutes = endTime.Minute - startTime.Minute;
            int hours = endTime.Hour - startTime.Hour;
            int days = endTime.Day - startTime.Day;
            int months = endTime.Month - startTime.Month;
            int years = endTime.Year - startTime.Year;
            if (seconds < 0)
            {
                minutes--;
                seconds += 60;
            }
            if (minutes < 0)
            {
                hours--;
                minutes += 60;
            }
            if (hours < 0)
            {
                days--;
                hours += 24;
            }
            if (days < 0)
            {
                months--;
                int previousMonth = (endTime.Month == 1) ? 12 : endTime.Month - 1;
                int year = (previousMonth == 12) ? endTime.Year - 1 : endTime.Year;
                days += DateTime.DaysInMonth(year, previousMonth);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }

            string sYears = FormatString("year", string.Empty, years);
            string sMonths = FormatString("month", sYears, months);
            string sDays = FormatString("day", sMonths, days);
            string sHours = FormatString("hour", sDays, hours);
            string sMinutes = FormatString("minute", sHours, minutes);
            string sSeconds = FormatString("second", sMinutes, seconds);

            return sYears + sMonths + sDays + sHours + sMinutes + sSeconds;
        }

        //remove leading strings with zeros and adjust for singular/plural
        private string FormatString(string str, string previousStr, int t)
        {
            if ((t == 0) && (previousStr.Length == 0)) return string.Empty;
            if (t == 1)
            {
                str = t.ToString() + " " + str;
            }
            else
            {
                str = t.ToString() + " " + str + "s";
            }
            return str + " ";
        }

        //=================================
        // FILE
        //=================================
        //Saves a string array as a text file.
        //This method loops through the array and writes each string in the array as a line in the text file.
        //The method can be used with the <a href="detail.aspx?id=31">DataTableToArray</a> method to save a DataTable as a delimited text file.
        //For example:<br>
        //<table><tr><td bgcolor="#efefef"><pre>  ArrayToFile( DataTableToArray(datatable, ",", false), @"C:\misc\xyz.txt" );</pre></td><tr></table>
        //Namespaces used:
        //System.IO
        //
        public void ArrayToFile(string[] content, string path_Filename)
        {
            StreamWriter sw = File.CreateText(path_Filename);
            foreach (string str in content)
            {
                sw.WriteLine(str);
            }
            sw.Close();
        }

        //Converts the contents of a file to a string array.
        //As each line of the text file is read, it is added to the string array.
        //This method can be used with the <a href="detail.aspx?id=32">ArrayToDataTable</a> method to convert a delimited text file into a DataTable.
        //For example:<br>
        //<table><tr><td bgcolor="#efefef"><pre>  DataTable dt = ArrayToDataTable(FileToArray(@"C:\misc\xyz.txt"), new char[1]{','}, true);</pre></td><tr></table>
        //Namespaces used:
        //System.IO
        //
        public string[] FileToArray(string filename)
        {
            ArrayList al = new ArrayList();
            StreamReader sr = File.OpenText(filename);
            string str = sr.ReadLine();
            while (str != null)
            {
                al.Add(str);
                str = sr.ReadLine();
            }
            sr.Close();
            string[] astr = new string[al.Count];
            al.CopyTo(astr);

            return astr;
        }

        //Gets information about the files in a directory and puts it in an array of strings.
        //The properties of each file is a separate string in the array.  This method is useful when used with the <a href="detail.aspx?id=32">ArrayToDataTable</a> method.  
        //For example::<br>
        //<table><tr><td bgcolor="#efefef"><pre>  DataTable dt = ArrayToDataTable(GetDirectoryFileInfo(@"C:\misc"), new char[1]{','}, true);</pre></td><tr></table>
        //Namespaces used:
        //System.Collections
        //System.IO
        public string[] GetDirectoryFileInfo(string directory)
        {
            ArrayList al = new ArrayList();
            DirectoryInfo info = new DirectoryInfo(directory);

            al.Add("Name,Size,CreationTime,LastAccessTime,LastWriteTime,Attributes");

            FileInfo[] files = info.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                al.Add(files[i].Name + "," +
                  files[i].Length + "," +
                  files[i].CreationTime + "," +
                  files[i].LastAccessTime + "," +
                  files[i].LastWriteTime + "," +
                  files[i].Attributes);
            }

            string[] dInfo = new string[al.Count];
            al.CopyTo(dInfo);

            return dInfo;
        }

        //Gets information about a directory and puts it in an array of strings.
        //Each property of the directory is a separate string in the array.  This method is useful when used with the <a href="detail.aspx?id=32">ArrayToDataTable</a> method.  
        //For example::<br>
        //<table><tr><td bgcolor="#efefef"><pre>  DataTable dt = ArrayToDataTable(GetDirectoryInfo(@"C:\misc"), new char[1]{','}, true);</pre></td><tr></table>
        //Namespaces used:
        //System.Collections
        //System.IO
        public string[] GetDirectoryInfo(string directory)
        {
            ArrayList al = new ArrayList();
            DirectoryInfo info = new DirectoryInfo(directory);

            al.Add("Property,Value");
            al.Add("Name," + info.Name);
            al.Add("FullName," + info.FullName);
            al.Add("Parent," + info.Parent);
            al.Add("Root," + info.Root);
            al.Add("CreationTime," + info.CreationTime.ToString());
            al.Add("LastAccessTime," + info.LastAccessTime.ToString());
            al.Add("LastWriteTime," + info.LastWriteTime.ToString());
            al.Add("Exists," + info.Exists.ToString());

            DirectoryInfo[] directories = info.GetDirectories();
            for (int i = 0; i < directories.Length; i++)
            {
                al.Add("Directory " + i.ToString() + "," + directories[i].Name);
            }

            FileInfo[] files = info.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                al.Add("File " + i.ToString() + "," + files[i].Name);
            }

            string[] dInfo = new string[al.Count];
            al.CopyTo(dInfo);

            return dInfo;
        }

        //Gets information about a file and puts it in an array of strings.
        //Each property of the file is a separate string in the array.  This method is useful when used with the <a href="detail.aspx?id=32">ArrayToDataTable</a> method.  
        //For example::<br>
        //<table><tr><td bgcolor="#efefef"><pre>  DataTable dt = ArrayToDataTable(GetFileInfo(@"C:\misc\xyz.txt"), new char[1]{','}, true);</pre></td><tr></table>
        //This method uses 
        //System.Collections
        //System.IO 
        //
        public string[] GetFileInfo(string filename)
        {
            ArrayList al = new ArrayList();
            FileInfo info = new FileInfo(filename);

            al.Add("Property,Value");
            al.Add("Name," + info.Name);
            al.Add("FullName," + info.FullName);
            al.Add("DirectoryName," + info.DirectoryName);
            al.Add("Extension," + info.Extension);
            al.Add("CreationTime," + info.CreationTime.ToString());
            al.Add("LastAccessTime," + info.LastAccessTime.ToString());
            al.Add("LastWriteTime," + info.LastWriteTime.ToString());
            al.Add("Exists," + info.Exists.ToString());
            al.Add("Length," + info.Length.ToString());
            al.Add("Attributes," + info.Attributes.ToString());

            string[] fInfo = new string[al.Count];
            al.CopyTo(fInfo);

            return fInfo;
        }

        //Reads from a text file, puts the contents of the file in a string, and returns the string.
        //This method uses 
        //System.IO
        //System.Text
        //
        public string ReadFromFile(string filename)
        {
            StreamReader sr = File.OpenText(filename);

            StringBuilder sb = new StringBuilder();
            string str = sr.ReadLine();
            while (str != null)
            {
                sb.Append(str + "\n");
                str = sr.ReadLine();
            }

            sr.Close();
            return sb.ToString();
        }

        //Writes the passed in string to a file.  If the path_Filename is just a file name, for example (textfile.txt), it will be save to the directory what the application is running.
        //Namespaces used:
        //System.IO
        public void WriteToFile(string content, string path_Filename)
        {
            StreamWriter sw = File.CreateText(path_Filename);
            sw.WriteLine(content);
            sw.Close();
        }

        //=================================
        // FORMS
        //=================================
        //Adds a check to the checkboxes whose values are passed in.
        //<b>Contributed by John Hodgson</b>
        //If cblItems is a CheckBoxList object, here is an example call to the SetCheckboxesSelect method:
        //  cblItems.Items.Add("one");
        //  cblItems.Items.Add("two");
        //  cblItems.Items.Add("three");
        //  cblItems.Items.Add("four");
        //  SetCheckboxesSelect(cblItems, "two,four");
        //Namespaces used:
        //System.Web.UI.WebControls
        //
        //Accepts CheckBoxList and a list of values that need to be checked
        public static void SetCheckboxesSelect(CheckBoxList pChkList, string pValues)
        {
            string[] arValues = pValues.Split(char.Parse(","));

            for (int i = 0; i <= pChkList.Items.Count - 1; i++)
            {
                for (int j = 0; j <= arValues.Length - 1; j++)
                {
                    if (arValues[j] == pChkList.Items[i].Value)
                    {
                        pChkList.Items[i].Selected = true;
                        break;
                    }
                }
            }
        }


        //Sets which item is selected in a DropDownList.
        //The item selected in a DropDownList control can be set by finding the DropDownList item and setting the Selected property to true.  If "ddlItems" is an instance of the DropDownList control, here is an example of how to set the selected item:
        //<table><tr><td bgcolor="#efefef"><pre>  ddlItems.Items.FindByText("three").Selected = true;</pre></td><tr></table>
        //Sometimes you may need to find the item by the item's value instead of by its text.  Here is an example of how to set the selected item by finding its value:
        //<table><tr><td bgcolor="#efefef"><pre>  ddlItems.Items.FindByValue("3").Selected = true;</pre></td><tr></table>
        //If this syntax is difficult to remember, you can put it in a method or use one of the methods below.
        //<b>Contributed by John Hodgson.</b>
        //This overloaded method has two versions.
        //The first version is used if the DropDownList values are ints, for example (ddlItems is a DropDownList object):
        //<table><tr><td bgcolor="#efefef"><pre>  ddlItems.Items.Add("1");
        //  ddlItems.Items.Add("2");
        //  ddlItems.Items.Add("3");
        //  ddlItems.Items.Add("4");
        //  SetComboSelectedIndex(ddlItems, 4);</pre></td><tr></table>
        //The second version is used if the DropDownList values are strings, for example (ddlItems is a DropDownList object):
        //<table><tr><td bgcolor="#efefef"><pre>  ddlItems.Items.Add("one");
        //  ddlItems.Items.Add("two");
        //  ddlItems.Items.Add("three");
        //  ddlItems.Items.Add("four");
        //  SetComboSelectedIndex(ddlItems, "two");</pre></td><tr></table>
        //Namespaces used:
        //System.Web.UI.WebControls
        //
        //Accepts a DropDownList and an int value to be SELECTED 
        public static void SetComboSelectedIndex(DropDownList pCbo, int pValue)
        {
            for (int i = 0; i <= pCbo.Items.Count - 1; i++)
            {
                if (int.Parse(pCbo.Items[i].Value) == pValue)
                {
                    pCbo.SelectedIndex = i;
                    break;
                }
            }
        }

        //Accepts a DropDownList and a string value to be SELECTED 
        public static void SetComboSelectedIndex(DropDownList pCbo, string pValue)
        {
            for (int i = 0; i <= pCbo.Items.Count - 1; i++)
            {
                if (pCbo.Items[i].Value == pValue)
                {
                    pCbo.SelectedIndex = i;
                    break;
                }
            }
        }


        //=================================
        // MATH
        //=================================
        //Sums the numbers from 1 to n.
        //Useful when needing to pair each item in a group with each of the other items.
        //The first version has less overhead since it uses a formula and does not require recursion.
        //Get the sum of 1 to i.
        public int Triangulate(int i)
        {
            return ((i * i + i) / 2);
        }

        public int Triangulate2(int i)
        {
            return ((i <= 1) ? 1 : (i + Triangulate2(i - 1)));
        }

        //Undoes the Triangulate method.
        //Useful with pairs.
        //The first version is more efficient since it does not have to be processed through a loop.
        public int UnTriangulate(int n)
        {
            return Convert.ToInt32((Math.Sqrt(8 * n + 1) - 1) / 2);
        }

        public int UnTriangulate2(int n)
        {
            int i = 1;
            int x = 0;
            do
            {
                x += i;
                i++;
            } while (x < n);
            return i - 1;
        }

        //=================================
        // NETWORK
        //=================================
        //Gets DNS information about a url and puts it in an array of strings.
        //This methods takes either an ip address or a host name and returns a list with the host name, all the aliases, and all the addresses.
        //This method is useful when used with the <a href="detail.aspx?id=32">ArrayToDataTable</a> method.  
        //For example::<br>
        //<table><tr><td bgcolor="#efefef"><pre>  DataTable dt = ArrayToDataTable(DNSLookup("www.microsoft.com"), new char[1]{','}, true);</pre></td><tr></table>
        //This method uses 
        //System.Collections 
        //System.Net 
        //
        public string[] DNSLookup(string url)
        {
            ArrayList al = new ArrayList();

            //check whether url is ipaddress or hostname
            Regex regex = new Regex(@"\d{1,3}(\.\d{1,3}){3}");
            IPHostEntry ipEntry = (regex.IsMatch(url))
              ? Dns.GetHostByAddress(url) : Dns.GetHostByName(url);

            al.Add("HostName," + ipEntry.HostName);

            foreach (string name in ipEntry.Aliases)
            {
                al.Add("Aliases," + name);
            }

            foreach (IPAddress ip in ipEntry.AddressList)
            {
                al.Add("Address," + ip);
            }

            string[] ipInfo = new string[al.Count];
            al.CopyTo(ipInfo);

            return ipInfo;
        }

        //Gets Http Headers and puts them in an array of strings.
        //Each of the headers is put in a separate string in the array.  This method is useful when used with the <a href="detail.aspx?id=32">ArrayToDataTable</a> method.  
        //For example::<br>
        //<table><tr><td bgcolor="#efefef"><pre>  DataTable dt = ArrayToDataTable(GetHttpHeaders("http://www.aspalliance.com/olson/"), new char[1]{'|'}, true);</pre></td><tr></table>
        //This method uses 
        //System.Collections 
        //System.Web;
        //
        public string[] GetHttpHeaders(string url)
        {
            ArrayList al = new ArrayList();
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response = request.GetResponse();

            al.Add("Name|Value");
            foreach (string key in response.Headers)
            {
                al.Add(key + "|" + response.Headers[key]);
            }

            response.Close();
            string[] hInfo = new string[al.Count];
            al.CopyTo(hInfo);

            return hInfo;
        }

        //Gets the images from a webpage.
        //This method uses the <a href="detail.aspx?id=23">ReadWebPage</a> method to get the contents of the url.  The method uses a regular expression to search through the content of the web page.  Everytime an image is found it is added to the list of images.
        //Namespaces used:
        //System.Collections
        //System.Text.RegularExpressions
        public string[] GetImages(string url)
        {
            //get the content of the url
            //ReadWebPage is another method in this useful methods collection
            string htmlPage = ReadWebPage(url);

            //set up the regex for finding images
            StringBuilder imgPattern = new StringBuilder();
            imgPattern.Append("<img[^>]+"); //start 'img' tag
            imgPattern.Append("src\\s*=\\s*"); //start src property
            //three possibilities  for what src property --
            //(1) enclosed in double quotes
            //(2) enclosed in single quotes
            //(3) enclosed in spaces
            imgPattern.Append("(?:\"(?<src>[^\"]*)\"|'(?<src>[^']*)'|(?<src>[^\"'>\\s]+))");
            imgPattern.Append("[^>]*>"); //end of tag
            Regex imgRegex = new Regex(imgPattern.ToString(), RegexOptions.IgnoreCase);

            //look for matches 
            Match imgcheck = imgRegex.Match(htmlPage);
            ArrayList imagelist = new ArrayList();
            //add base href for relative urls
            imagelist.Add("<BASE href=\"" + url + "\">" + url);
            while (imgcheck.Success)
            {
                string src = imgcheck.Groups["src"].Value;
                string image = "<img src=\"" + src + "\">";
                imagelist.Add(image);
                imgcheck = imgcheck.NextMatch();
            }
            string[] images = new string[imagelist.Count];
            imagelist.CopyTo(images);

            return images;
        }

        //Gets the links from a webpage.
        //This method uses the <a href="detail.aspx?id=23">ReadWebPage</a> method to get the contents of the url.  The method uses a regular expression to search through the content of the web page.  Everytime a link is found it is added to the list of links.  If the makeLinkable option is set to true, the url of the link is added to the list with the html tags that make it a link otherwise just the url of the link is added to the list.
        //Namespaces used:
        //System.Collections
        //System.Text.RegularExpressions
        public string[] GetLinks(string url, bool makeLinkable)
        {
            //get the content of the url
            //ReadWebPage is another method in this useful methods collection
            string htmlPage = ReadWebPage(url);

            //set up the regex for finding the link urls
            StringBuilder hrefPattern = new StringBuilder();
            hrefPattern.Append("<a[^>]+"); //start 'a' tag and anything that comes before 'href' tag
            hrefPattern.Append("href\\s*=\\s*"); //start href property
            //three possibilities  for what href property --
            //(1) enclosed in double quotes
            //(2) enclosed in single quotes
            //(3) enclosed in spaces
            hrefPattern.Append("(?:\"(?<href>[^\"]*)\"|'(?<href>[^']*)'|(?<href>[^\"'>\\s]+))");
            hrefPattern.Append("[^>]*>.*?</a>"); //end of 'a' tag
            Regex hrefRegex = new Regex(hrefPattern.ToString(), RegexOptions.IgnoreCase);

            //look for matches 
            Match hrefcheck = hrefRegex.Match(htmlPage);
            ArrayList linklist = new ArrayList();
            //add base href for relative links
            linklist.Add("<BASE href=\"" + url + "\">" + url);
            while (hrefcheck.Success)
            {
                string href = hrefcheck.Groups["href"].Value; //link url
                string link = (makeLinkable)
                  ? "<a href=\"" + href + "\" target=\"_blank\">" + href + "</a>" : href;
                linklist.Add(link);
                hrefcheck = hrefcheck.NextMatch();
            }
            string[] links = new string[linklist.Count];
            linklist.CopyTo(links);

            return links;
        }

        //Gets the ServerVariables and puts them in a string.
        //This method needs to be in code that is processed by a web server.
        //This method uses
        //System.Collections.Specialized
        //System.Text
        public string GetServerVariables(HttpRequest request)
        {
            StringBuilder sb = new StringBuilder();
            NameValueCollection NVCSrvElements = request.ServerVariables;
            sb.Append("<table border=\"1\">");
            for (int i = 0; i < NVCSrvElements.Count; i++)
            {
                sb.Append("<tr><td>" + NVCSrvElements.GetKey(i) + "</td><td>");
                sb.Append(NVCSrvElements[i] + "</td></tr>");
            }
            sb.Append("</table>");

            return sb.ToString();
        }

        //Reads a web page and returns a string with the contents.
        //This method uses
        //System.IO
        //System.Net
        public string ReadWebPage(string url)
        {
            WebRequest request = HttpWebRequest.Create(url);
            Stream stream = request.GetResponse().GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string webPage = sr.ReadToEnd();
            sr.Close();

            return webPage;
        }

        //Sends an e-mail message.
        //This overloaded method has seven versions.  Each successive version allows you to pass in more parameters.  The last version allows attachments.  The attachments have to be a fully qualified path on the machine that is running the code.  <font color="#cc0000">If the deleteAttachments parameter is set to true, this code will delete the files specified in the attachments parameter.</font>  The purpose of the deleteAttachments parameter is to delete temporary files, such as when you have code that generates a file so that it can be attached to an e-mail.
        //This method uses
        //System.Web.Mail
        public string SendMail(string to)
        {
            MailMessage message = new MailMessage();
            message.From = "MailService@thisdomain.com";
            message.To = to;
            message.Subject = "Message to " + to;
            message.Body = "Hello!";
            SmtpMail.Send(message);
            return "Mail Sent";
        }

        public string SendMail(string to, string body)
        {
            MailMessage message = new MailMessage();
            message.From = "MailService@thisdomain.com";
            message.To = to;
            int len = (body.Length < 15) ? body.Length : 15;
            message.Subject = body.Substring(0, len);
            message.Body = body;
            SmtpMail.Send(message);
            return "Mail Sent";
        }

        public string SendMail(string to, string subject, string body)
        {
            MailMessage message = new MailMessage();
            message.From = "MailService@thisdomain.com";
            message.To = to;
            message.Subject = subject;
            message.Body = body;
            SmtpMail.Send(message);
            return "Mail Sent";
        }

        public string SendMail(string from, string to, string subject, string body)
        {
            MailMessage message = new MailMessage();
            message.From = from;
            message.To = to;
            message.Subject = subject;
            message.Body = body;
            SmtpMail.Send(message);
            return "Mail Sent";
        }

        public string SendMail(string from, string to, string cc, string subject,
          string body)
        {
            MailMessage message = new MailMessage();
            message.From = from;
            message.To = to;
            message.Cc = cc;
            message.Subject = subject;
            message.Body = body;
            SmtpMail.Send(message);
            return "Mail Sent";
        }

        public string SendMail(string from, string to, string cc, string bcc, string subject,
          string body)
        {
            MailMessage message = new MailMessage();
            message.From = from;
            message.To = to;
            message.Cc = cc;
            message.Bcc = bcc;
            message.Subject = subject;
            message.Body = body;
            SmtpMail.Send(message);
            return "Mail Sent";
        }

        public string SendMail(string from, string to, string cc, string bcc, string subject,
          string body, string[] attachments, bool deleteAttachments)
        {
            string returnMessage = "";

            MailMessage message = new MailMessage();
            message.From = from;
            message.To = to;
            message.Cc = cc;
            message.Bcc = bcc;
            message.Subject = subject;
            for (int i = 0; i < attachments.Length; i++)
            {
                try
                {
                    if (File.Exists(attachments[i]))
                    {
                        message.Attachments.Add(new MailAttachment(attachments[i]));
                    }
                    else
                    {
                        returnMessage += "ERROR: The file " + attachments[i] + " does not exist! ";
                    }
                }
                catch (Exception e)
                {
                    returnMessage += "ERROR: " + e.Message + " ";
                }
            }

            //If there is an error in attaching, let the recipient know also.
            message.Body = returnMessage + body;

            try
            {
                SmtpMail.Send(message);
                returnMessage += " Mail Sent ";
            }
            catch (Exception e)
            {
                returnMessage += "ERROR: " + e.Message;
            }

            if (deleteAttachments)
            {
                for (int i = 0; i < attachments.Length; i++)
                {
                    try
                    {
                        if (File.Exists(attachments[i]))
                        {
                            File.Delete(attachments[i]);
                            returnMessage += " Attachments Deleted ";
                        }
                        else
                        {
                            returnMessage += "ERROR: The file " + attachments[i] + " does not exist, so it cannot be deleted. ";
                        }
                    }
                    catch (Exception e)
                    {
                        returnMessage += "ERROR: " + e.Message;
                    }
                }
            }

            return returnMessage;
        }


        //=================================
        // NUMBERS
        //=================================
        //Gets an array of double values from the start value to the end value.
        //The list of numbers can be incremented by any amount (like step).
        public double[] GetDoubles(double start, double end, double increment)
        {
            double dlength = ((end - start) / increment) + 1;
            int ilength = System.Convert.ToInt32(dlength);
            double[] x = new double[ilength];
            for (int i = 0; i < ilength; i++)
            {
                x[i] = start + (i * increment);
            }
            return x;
        }

        //Gets an array of int values from the start value to the end value.
        //The list of numbers can be incremented by any amount (like step).
        public int[] GetInts(int start, int end, int increment)
        {
            int ilength = ((end - start) / increment) + 1;
            int[] x = new int[ilength];
            for (int i = 0; i < ilength; i++)
            {
                x[i] = start + (i * increment);
            }
            return x;
        }

        //Gets a random number.
        //The first method uses the RNGCryptoServiceProvider class.  If "true" is passed to this method it will return a non-zero random number otherwise the number may be zero.
        //The second method uses the Random class.  It returns a random number between the two numbers passed in.
        //The third method uses the Random class.  It returns a double between 0.0 and 1.0.
        //The first method uses
        //System.Security.Cryptography
        //
        public int GetRandomNumber(bool noZeros)
        {
            byte[] random = new Byte[1];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            if (noZeros)
            {
                rng.GetNonZeroBytes(random);
            }
            else
            {
                rng.GetBytes(random);
            }
            return (int)random[0];
        }

        public int GetRandomNumber(int low, int high)
        {
            return new Random().Next(low, high);
        }

        public double GetRandomNumber()
        {
            return new Random().NextDouble();
        }

        //Check whether an object is numeric.
        //The first version uses a regular expression pattern to determine if the string is numeric.  A better regular expression could probably be written for this.  This pattern worked for everything I tried to pass to this method.  It does not, however, take into consideration different cultures.
        //The second version is the simplest way I have seen to check whether an object is numeric.
        //I used to use the first method, being a purist in the sense that exceptions should not be used for normal program flow or for anything that you expect to happen.  Now I usually use the second method because when I am checking whether an object is numeric, I expect it to be numeric.  For me, it is exceptional if the object turns out not to be numeric.  If I had an application where I had a list of objects that could be numeric or non-numeric (where I did not expect everything in the list to be a number), I would probably use the first method.
        //The first method uses
        //System.Text.RegularExpressions
        public bool IsNumeric2(object num)
        {
            //[Ee] allow for exponents
            // (\d+ \d*) (\d? \d+) allow for decimal value without number before decimal point
            Regex r = new Regex(@"(^[-+]?\d+(,?\d*)*\.?\d*([Ee][-+]\d*)?$)|(^[-+]?\d?(,?\d*)*\.\d+([Ee][-+]\d*)?$)");
            return r.Match(num.ToString()).Success;
        }

        public bool IsNumeric(object num)
        {
            try
            {
                Convert.ToDouble(num);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //=================================
        // STATS
        //=================================
        //Gets the average of an array of doubles or an array of ints.
        public double GetAvg(double[] num)
        {
            double sum = 0.0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            double avg = sum / System.Convert.ToDouble(num.Length);

            return avg;
        }

        public double GetAvg(int[] num)
        {
            double sum = 0.0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            double avg = sum / System.Convert.ToDouble(num.Length);

            return avg;
        }

        public double GetAvg(ArrayList num)
        {
            double sum = 0.0;
            for (int i = 0; i < num.Count; i++)
            {
                sum += (double)num[i];
            }
            double avg = sum / System.Convert.ToDouble(num.Count);

            return avg;
        }


        //Gets the Correlation between two arrays of numbers.
        //This method uses the <a href="Detail.aspx?id=8">GetStandardDeviation</a> method and the <a href="Detail.aspx?id=7">GetAvg</a> method to get the correlation.
        public double GetCorrelation(double[] num1, double[] num2)
        {
            double denominator = (num1.Length - 1) * GetStandardDeviation(num1) * GetStandardDeviation(num2);
            double sumxy = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                sumxy += num1[i] * num2[i];
            }
            double numerator = sumxy - num1.Length * GetAvg(num1) * GetAvg(num2);
            return numerator / denominator;
        }

        //Gets the standard deviation of a list of numbers.
        //This overloaded method has three version:
        //Version 1: Takes an ArrayList of doubles
        //Version 2: Takes array of doubles
        //Version 3: Takes a two-dimensional array of doubles and the index of the column where the standard deviation is to be applied
        //The math is a little different between the first and the second method, but the answer, of course, is the same.  
        //The math in version 2 is modified a little so that it can be used in my MovingWindow class.  (More on that in a later article.)
        private double GetStandardDeviation(ArrayList num)
        {
            double SumOfSqrs = 0;
            double avg = GetAvg(num);
            for (int i = 0; i < num.Count; i++)
            {
                SumOfSqrs += Math.Pow(((double)num[i] - avg), 2);
            }
            double n = (double)num.Count;
            return Math.Sqrt(SumOfSqrs / (n - 1));
        }

        public static double GetStandardDeviation(double[] num)
        {
            double Sum = 0.0, SumOfSqrs = 0.0;
            for (int i = 0; i < num.Length; i++)
            {
                Sum += num[i];
                SumOfSqrs += Math.Pow(num[i], 2);
            }
            double topSum = (num.Length * SumOfSqrs) - (Math.Pow(Sum, 2));
            double n = (double)num.Length;
            return Math.Sqrt(topSum / (n * (n - 1)));
        }

        public static double GetStandardDeviation(double[,] num, int col)
        {
            double Sum = 0.0, SumOfSqrs = 0.0;
            int len = num.GetLength(0);
            for (int i = 0; i < len; i++)
            {
                Sum += num[i, col];
                SumOfSqrs += Math.Pow(num[i, col], 2);
            }
            double topSum = (len * SumOfSqrs) - (Math.Pow(Sum, 2));
            double n = System.Convert.ToDouble(len);
            return Math.Sqrt(topSum / (n * (n - 1)));
        }

        //=================================
        // STRINGS
        //=================================
        //Count how many times a string appears.
        //The first method counts the number of times a string appears in an array of strings.
        //The second method counts the number of times a string appears in string.  Actually it counts the number of times a regular expression pattern occurs in a string.  The caller example shows how to count the number of links in a web page.
        private int CountStrings(string[] astr, string str)
        {
            int x = 0;
            for (int i = 0; i < astr.Length; i++)
            {
                if (astr[i].IndexOf(str) > -1)
                {
                    x++;
                }
            }
            return x;
        }

        private int CountStrings(string str, string regexStr)
        {
            Regex regex = new Regex(regexStr);
            return regex.Matches(str).Count;
        }

        //Gets a string with ASCII characters.
        public string GetASCII()
        {
            char low = (char)33;
            char high = (char)255;
            StringBuilder sb = new StringBuilder();
            for (char ch = low; ch <= high; ch++)
            {
                sb.Append(ch.ToString() + " ");
            }
            return sb.ToString();
        }

        //Remove extra white space in a string.
        //Removes all white space except a single space.
        public string RemoveWhiteSpace(string str)
        {
            if (str.Length > 0)
            {
                while (str.IndexOf("  ") > 0)
                {
                    str = str.Replace("  ", " ");
                }
            }
            return str;
        }

        public string ProperCase(string stringInput)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = stringInput.Split(' ');
            foreach (string word in words)
            {
                sb.Append(Char.ToUpper(word[0])); //first letter
                sb.Append(word.Substring(1).ToLower()); //the rest of the word
                sb.Append(" ");
            }

            return sb.ToString();
        }

        public static string SendNetSend(string cuid, string message)
        {
            string output = "";

            Process newProcess = new Process();
            newProcess.StartInfo.RedirectStandardInput = true;
            newProcess.StartInfo.RedirectStandardOutput = true;
            newProcess.StartInfo.UseShellExecute = false;
            newProcess.StartInfo.FileName = "cmd.exe";
            newProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            newProcess.Start();

            StreamReader sOut = newProcess.StandardOutput;
            StreamWriter sIn = newProcess.StandardInput;

            sIn.Write("net send " + cuid + " " + message + System.Environment.NewLine);
            sIn.Flush();
            sIn.Close();

            newProcess.Close();

            string stuff = "";
            while ((stuff = sOut.ReadLine()) != null)
            {
                if (stuff.IndexOf("message") > 0)
                {
                    output = stuff;
                }
            }

            sOut.Close();

            return output;
        }

    }
}