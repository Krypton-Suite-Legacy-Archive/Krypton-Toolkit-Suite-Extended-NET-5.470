using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using ToolkitResources.Strings;

namespace System.Globalization
{
    /// <summary>
    /// Type of pattern to extract.
    /// </summary>
    public enum TimeSpanPatternType
    {
        /// <summary>Pattern used for formatting output.</summary>
        Formatting,
        /// <summary>Pattern used for parsing input string.</summary>
        Parsing
    }

    /// <summary>
    /// Defines how <see cref="TimeSpan"/> values are formatted and displayed, depending on the culture.
    /// </summary>
    public sealed class TimeSpan2FormatInfo : IFormatProvider, ICustomFormatter
    {
        private const string defaultPattern = "-[d'.']hh':'mm':'ss['.'fffffff]";
        private const string generalLongPattern = "-d.hh:mm:ss.fffffff";
        private const string generalShortPattern = "-[d.]h:mm:ss[.FFFFFFF]";
        private const string ISO8601Pattern = @"'P'[d'D']['T'[h'H'][m'M'][p3'S']];PT0S";
        private const RegexOptions opts = RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace; // | RegexOptions.IgnoreCase;
        private const string pattern = @"(?:(?>(?<LEVEL>)\[|\](?<OPT-LEVEL>)|(?! \[ | \] )'(?<q>[^']*)'|\\(?<e>.)|(?<w>%w|w+)|(?<r>%r|r+)|(?<d>%d|d+)|(?<h>%h|h+)|(?<m>%m|m+)|(?<s>%s|s+)|(?<k>%k|k+)|(?<t>%t|t+)|(?<D>%D|D\d*)|(?<H>%H|H\d*)|(?<M>%M|M\d*)|(?<S>%S|S\d*)|(?<K>%K|K\d*)|(?<p>p\d*)|(?<vd>@[dD])|(?<vh>@[hH])|(?<vm>@[mM])|(?<vs>@[sS])|(?<vk>@[kK])|(?<vt>@[tT])|(?<f>%f|f{2,7})|(?<F>%F|F{2,7})|(?<fs>,)|(?<ws>_)|(?<ts>:)|(?<ds>\.))+(?(LEVEL)(?!)))*";
        private const string post = @"(?:;(?<z>[ A-Za-z0-9,:\(\)]+))?\s*$";
        private const string pre = @"^\s*(?<n>-)?";
        private const string standardPatternsArray = "cgGfxj";

        private static readonly string fullPattern = string.Concat(pre, pattern, post);
        private static readonly Dictionary<int, TimeSpan2FormatInfo> cache = new Dictionary<int, TimeSpan2FormatInfo>();
        private static readonly Dictionary<string, Match> fullPatternCache = new Dictionary<string, Match>();
        private static readonly string validFormats = "cgGfjx";

        private Regex regex = new Regex(fullPattern, opts);

        /// <summary>
        /// Initializes a new writable instance of the <see cref="TimeSpan2FormatInfo"/> class that is culture-independent (invariant).
        /// </summary>
        public TimeSpan2FormatInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSpan2FormatInfo"/> class that is associated with the supplied culture.
        /// </summary>
        /// <param name="culture">The culture.</param>
        internal TimeSpan2FormatInfo(CultureInfo culture)
        {
            TimeSpanResources.Culture = culture;
        }

        /// <summary>
        /// Gets a read-only <see cref="TimeSpan2FormatInfo"/> object that formats values based on the current culture.
        /// </summary>
        /// <value>A read-only <see cref="TimeSpan2FormatInfo"/> object based on the <see cref="CultureInfo"/> object for the current thread.</value>
        public static TimeSpan2FormatInfo CurrentInfo
        {
            get
            {
                var currentCulture = Thread.CurrentThread.CurrentUICulture;
                return GetInstance(currentCulture);
            }
        }

        /// <summary>
        /// Gets the default pattern.
        /// </summary>
        /// <value>The default pattern.</value>
        public string DefaultPattern => defaultPattern;

        /// <summary>
        /// Gets or sets the long pattern.
        /// </summary>
        /// <value>The long pattern.</value>
        public string LongPattern { get; set; } = generalLongPattern;

        /// <summary>
        /// Gets or sets the short pattern.
        /// </summary>
        /// <value>The short pattern.</value>
        public string ShortPattern { get; set; } = generalShortPattern;

        /// <summary>
        /// Gets or sets the string to display the representing <c>TimeSpan.Zero</c>.
        /// </summary>
        public string TimeSpanZeroDisplay { get; set; }

        private Regex MyRegex => regex ?? (regex = new Regex(fullPattern, opts));

        /// <summary>
        /// Gets a value indicating whether to ignore case when parsing word formatted time spans. Pulls value, if available, from localized resources.
        /// </summary>
        private bool WordPatternIgnoreCase
        {
            get
            {
                try { return bool.Parse(TimeSpanResources.TimeSpanWordPatternIgnoreCase); }
                catch { return true; }
            }
        }

        /// <summary>
        /// Returns the <see cref="TimeSpan2FormatInfo"/> associated with the specified <see cref="IFormatProvider"/>.
        /// </summary>
        /// <param name="provider">The <see cref="IFormatProvider"/> that gets the <see cref="TimeSpan2FormatInfo"/>. -or- <c>null</c> reference (Nothing in Visual Basic) to get <see cref="CurrentInfo"/>.</param>
        /// <returns>A <see cref="TimeSpan2FormatInfo"/> associated with the specified <see cref="IFormatProvider"/>.</returns>
        public static TimeSpan2FormatInfo GetInstance(IFormatProvider provider)
        {
            var info2 = provider as CultureInfo;
            if (info2 != null)
            {
                TimeSpan2FormatInfo tsInfo;
                lock (cache)
                {
                    if (cache.TryGetValue(info2.LCID, out tsInfo))
                        return tsInfo;
                    tsInfo = new TimeSpan2FormatInfo(CultureInfo.CurrentUICulture);
                    cache.Add(info2.LCID, tsInfo);
                }
                return tsInfo;
            }

            var timeSpanInfo = provider as TimeSpan2FormatInfo;
            if (timeSpanInfo != null)
                return timeSpanInfo;

            if (provider != null)
            {
                timeSpanInfo = provider.GetFormat(typeof(TimeSpan2FormatInfo)) as TimeSpan2FormatInfo;
                if (timeSpanInfo != null)
                    return timeSpanInfo;
            }
            return CurrentInfo;
        }

        /// <summary>
        /// Converts the value of the <see cref="TimeSpan"/> object to its equivalent string representation using the specified format.
        /// </summary>
        /// <param name="format">A TimeSpan format string.</param>
        /// <param name="arg">An object to format.</param>
        /// <param name="formatProvider">An <see cref="T:System.IFormatProvider"/> object that supplies format information about the current instance.</param>
        /// <returns>A string representation of value of the current <see cref="TimeSpan"/> object as specified by format.</returns>
        /// <remarks>The following table lists the standard TimeSpan format patterns associated with TimeSpan2FormatInfo properties.
        /// <list type="table">
        /// <listheader><term>Format pattern</term><description>Associated Property/Description</description></listheader>
        /// <item><term>d</term><description>Localized string for TotalDays</description></item>
        /// <item><term>f</term><description>Full localized string displaying each time element with separator between</description></item>
        /// <item><term>h</term><description>Localized string for TotalHours</description></item>
        /// <item><term>j</term><description>JIRA style output</description></item>
        /// <item><term>m</term><description>Localized string for TotalMinutes</description></item>
        /// <item><term>n</term><description>Standard TimeSpan format (00:00:00:00)</description></item>
        /// <item><term>s</term><description>Localized string for TotalSeconds</description></item>
        /// <item><term>t</term><description>Localized string for TotalMilliseconds</description></item>
        /// <item><term>x</term><description>ISO 8601 XML standard for durations</description></item>
        /// </list>
        /// </remarks>
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg == null) throw new ArgumentNullException(nameof(arg));

            if (format != null)
            {
                if (arg is TimeSpan)
                    return FormatTimeSpan((TimeSpan)arg, format);
                if (arg is TimeSpan2)
                {
                    var changeType = Convert.ChangeType(arg, typeof(TimeSpan), formatProvider);
                    if (changeType != null)
                        return FormatTimeSpan((TimeSpan)changeType, format);
                }
            }

            var formattable = arg as IFormattable;
            return formattable != null && !(arg is TimeSpan2) ? formattable.ToString(format, formatProvider) : arg.ToString();
        }

        /// <summary>
        /// Returns all the standard patterns in which <see cref="TimeSpan"/> values can be formatted.
        /// </summary>
        /// <param name="patternType">Type of the pattern.</param>
        /// <returns>
        /// An array containing the standard patterns in which <see cref="TimeSpan"/> values can be formatted.
        /// </returns>
        public string[] GetAllTimeSpanPatterns(TimeSpanPatternType patternType)
        {
            var output = new List<string>();
            foreach (var f in standardPatternsArray.ToCharArray())
                output.AddRange(GetAllTimeSpanPatterns(patternType, f));
            return output.ToArray();
        }

        /// <summary>
        /// Returns all the standard patterns in which <see cref="TimeSpan"/> values can be formatted using the specified format pattern.
        /// </summary>
        /// <param name="patternType">Type of the pattern.</param>
        /// <param name="format">A standard format pattern.</param>
        /// <returns>
        /// An array containing the standard patterns in which <see cref="TimeSpan"/> values can be formatted using the specified format pattern.
        /// </returns>
        public string[] GetAllTimeSpanPatterns(TimeSpanPatternType patternType, char format) => new[] { GetTimeSpanPattern(patternType, format) };

        /// <summary>
        /// Returns an object of the specified type that provides a <see cref="TimeSpan"/> formatting service.
        /// </summary>
        /// <param name="formatType">The <see cref="Type"/> of the required formatting service.</param>
        /// <returns>
        /// The current <see cref="TimeSpan2FormatInfo"/>, if <paramref name="formatType"/> is the same as the type of the current <see cref="TimeSpan2FormatInfo"/>; otherwise, <c>null</c>.
        /// </returns>
        public object GetFormat(Type formatType) => formatType != typeof(ICustomFormatter) ? null : this;

        /// <summary>
        /// Converts the specified string representation of a time span to its <see cref="TimeSpan"/> equivalent.
        /// </summary>
        /// <param name="s">A string containing a time span to parse.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s"/>.</param>
        /// <returns>A <see cref="TimeSpan"/> equivalent to the time span contained in <paramref name="s"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="s"/> is <c>null</c>.</exception>
        /// <exception cref="FormatException"><paramref name="s"/> does not contain a valid string representation of a time span.</exception>
        internal TimeSpan Parse(string s, IFormatProvider provider)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentNullException(nameof(s));
            TimeSpan ts;
            if (TryParse(s, provider, out ts))
                return ts;
            throw new FormatException();
        }

        /// <summary>
        /// Converts the specified string representation of a time span to its <see cref="TimeSpan"/> equivalent using the specified format and culture-specific format information. The format of the string representation must match the specified format exactly.
        /// </summary>
        /// <param name="s">A string containing a time span to parse.</param>
        /// <param name="formats">An array of standard or custom format strings that define the required format of <paramref name="s"/>.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s"/>.</param>
        /// <returns>A <see cref="TimeSpan"/> equivalent to the time span contained in <paramref name="s"/> as specified by <paramref name="formats"/> and <paramref name="provider"/>.</returns>
        internal TimeSpan ParseExact(string s, string[] formats, IFormatProvider provider)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));

            TimeSpan ts;
            if (!TryParseExact(s, formats, provider, out ts))
                throw new FormatException();

            return ts;
        }

        /// <summary>
        /// Converts the specified string representation of a date and time to its <see cref="TimeSpan"/> equivalent and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a time span to convert.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s"/>.</param>
        /// <param name="result">When this method returns, contains the <see cref="TimeSpan"/> value equivalent to the time span contained in <paramref name="s"/>, if the conversion succeeded, or <c>TimeSpan.Zero</c> if the conversion failed. The conversion fails if the <paramref name="s"/> parameter is <c>null</c>, is an empty string (""), or does not contain a valid string representation of a time span. This parameter is passed uninitialized.</param>
        /// <returns>
        /// 	<c>true</c> if the <paramref name="s"/> parameter was converted successfully; otherwise, <c>false</c>.
        /// </returns>
        internal bool TryParse(string s, IFormatProvider provider, out TimeSpan result)
        {
            s = s.Trim();
            result = TimeSpan.Zero;
            if (string.IsNullOrEmpty(s))
                return false;

            if (TryParseExact(s, GetAllTimeSpanPatterns(TimeSpanPatternType.Parsing), provider, out result))
                return true;

            // Setup
            if (!string.IsNullOrEmpty(TimeSpanZeroDisplay) && string.Compare(s, TimeSpanZeroDisplay, StringComparison.CurrentCultureIgnoreCase) == 0)
                return true;

            return false;
        }

        /// <summary>
        /// Converts the specified string representation of a date and time to its <see cref="TimeSpan"/> equivalent and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a time span to convert.</param>
        /// <param name="formats">An array of allowable formats of <paramref name="s"/>.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s"/>.</param>
        /// <param name="result">When this method returns, contains the <see cref="TimeSpan"/> value equivalent to the time span contained in <paramref name="s"/>, if the conversion succeeded, or <c>TimeSpan.Zero</c> if the conversion failed. The conversion fails if <paramref name="s"/> or <paramref name="formats"/> is <c>null</c>, <paramref name="s"/> or an element of <paramref name="formats"/> is an empty string, or the format of <paramref name="s"/> is not exactly as specified by at least one of the format patterns in <paramref name="formats"/>. This parameter is passed uninitialized.</param>
        /// <returns>
        /// 	<c>true</c> if the <paramref name="s"/> parameter was converted successfully; otherwise, <c>false</c>.
        /// </returns>
        internal bool TryParseExact(string s, string[] formats, IFormatProvider provider, out TimeSpan result)
        {
            foreach (var f in formats)
            {
                string zeroFormat;
                var cFormat = GetCustomFormatString(TimeSpanPatternType.Parsing, f, out zeroFormat);
                if (cFormat.Length == 0)
                    return TimeSpan.TryParse(s, out result);

                var m = ValidateCustomPattern(cFormat);

                var pExp = BuildParsingExpression(m);
                Debug.WriteLine(pExp);
                var p = Regex.Match(s, pExp, opts);
                if (!p.Success)
                    continue;

                try
                {
                    result = TimeSpanFromParseMatch(p);
                    return true;
                }
                catch { }
            }

            result = TimeSpan.Zero;
            return false;
        }

        private string BuildParsingExpression(Match m)
        {
            var head = GetParsedTokens(m);
            if (head.children == null)
                throw new FormatException();
            ProcessParseEntity(head);
            return head.ToString();
        }

        private string CustomFormat(TimeSpan core, string format, string zeroFormat)
        {
            // Try for easy Zero value
            if (core == TimeSpan.Zero)
            {
                var zMatch = Regex.Match(format, post);
                var foundZ = zMatch.Success && zMatch.Groups["z"].Success;
                if (zeroFormat != null || foundZ)
                    return foundZ ? zMatch.Groups["z"].Value : zeroFormat;
            }

            // Validate whole string
            var match = ValidateCustomPattern(format);

            var head = GetParsedTokens(match);
            if (head.children == null)
                throw new FormatException();
            var z = head.children.Find(p => p.name == "z");
            if (z != null && core == TimeSpan.Zero)
                return z.value;
            head.children.Remove(z);
            ProcessFormatEntity(head, core);
            return head.ToString();
        }

        private string FormatTimeSpan(TimeSpan core, string format)
        {
            string zeroFormat;
            var cFormat = GetCustomFormatString(TimeSpanPatternType.Formatting, format, out zeroFormat);
            if (cFormat.Length == 0)
                return core == TimeSpan.Zero && zeroFormat != null ? zeroFormat : core.ToString();
            return CustomFormat(core, cFormat, zeroFormat);
        }

        private string GetCultureString(long value, string matchValue)
        {
            var ret = string.Empty;
            switch (char.ToLower(matchValue[1]))
            {
                case 'd':
                    ret = value == 1 ? TimeSpanResources.TimeSpanOneDayFormat : TimeSpanResources.TimeSpanManyDayFormat;
                    break;

                case 'h':
                    ret = value == 1 ? TimeSpanResources.TimeSpanOneHourFormat : TimeSpanResources.TimeSpanManyHourFormat;
                    break;

                case 'm':
                    ret = value == 1 ? TimeSpanResources.TimeSpanOneMinuteFormat : TimeSpanResources.TimeSpanManyMinuteFormat;
                    break;

                case 's':
                    ret = value == 1 ? TimeSpanResources.TimeSpanOneSecondFormat : TimeSpanResources.TimeSpanManySecondFormat;
                    break;

                case 'k':
                    ret = value == 1 ? TimeSpanResources.TimeSpanOneMillisecondFormat : TimeSpanResources.TimeSpanManyMillisecondFormat;
                    break;

                case 't':
                    ret = value == 1 ? TimeSpanResources.TimeSpanOneTickFormat : TimeSpanResources.TimeSpanManyTickFormat;
                    break;
            }
            if (ret.Length > 0 && char.IsUpper(matchValue[1]))
                return char.ToUpper(ret[0]) + (ret.Length > 1 ? ret.Substring(1) : string.Empty);
            return ret;
        }

        private string GetCustomFormatString(TimeSpanPatternType patternType, string format, out string zeroFormat)
        {
            var fmt = string.IsNullOrEmpty(format) ? 'c' : format[0];
            zeroFormat = string.IsNullOrEmpty(TimeSpanZeroDisplay) ? string.Empty : TimeSpanZeroDisplay;
            if (format != null && format.Length > 1)
            {
                if (format[0] == ';')
                {
                    fmt = 'c';
                    zeroFormat = format.Substring(1);
                }
                else if (format[0] != '\\' && format[1] == ';')
                    zeroFormat = format.Substring(2);
                else
                    return format;
            }
            return validFormats.IndexOf(fmt) >= 0 ? GetTimeSpanPattern(patternType, fmt) : format;
        }

        private ParseEntity GetParsedTokens(Match m)
        {
            // Handle each match group
            var head = new ParseEntity(".", m, null);
            var list = head.children = new List<ParseEntity>();
            foreach (var gn in MyRegex.GetGroupNames())
            {
                if (gn != "OPT" && gn != "0")
                {
                    var g = m.Groups[gn];
                    if (g.Success)
                        foreach (Capture c in g.Captures)
                            list.Add(new ParseEntity(gn, c, head));
                }
            }
            list.Sort((p1, p2) => p1.start - p2.start);

            // Put in groupings
            foreach (Capture c in m.Groups["OPT"].Captures)
            {
                var f = list.FindIndex(p1 => p1.start > c.Index);
                var l = list.FindLastIndex(p1 => p1.start + p1.length < c.Index + c.Length);
                var p = new ParseEntity(null, c, head) { children = list.GetRange(f, l - f + 1) };
                list.RemoveRange(f, l - f + 1);
                p.children.ForEach(delegate (ParseEntity pe) { pe.parent = p; });
                list.Insert(f, p);
            }
#if DEBUG
            for (var i = 0; i < list.Count; i++)
            {
                Debug.WriteLine(string.Format("Match {3} = \"{1}\" ({0}:{2})", list[i].start, list[i].value, list[i].length, list[i].name));
            }
#endif
            return head;
        }

        private string GetStringValue(double value, ParseEntity e)
        {
            if (e.name == "F" || e.name == "f")
            {
                var fcnt = e.value.Length;
                if (e.value[0] == '%')
                    fcnt--;
                var ret = value.ToString("f7").Substring(2, fcnt);
                if (e.name == "F")
                    ret = ret.TrimEnd('0');
                return ret;
            }
            if (e.value.StartsWith("%") || e.value.Length == 1)
                return value.ToString(CultureInfo.CurrentCulture);
            if (!char.IsDigit(e.value, 1)) return value.ToString(e.value.Replace(e.value[0], '0'));
            var precision = int.Parse(e.value.Substring(1));
            var newVal = Math.Round(value, precision, MidpointRounding.AwayFromZero);
            return newVal.ToString(CultureInfo.CurrentCulture);
        }

        private string GetTimeSpanPattern(TimeSpanPatternType patternType, char format)
        {
            switch (format)
            {
                case 'c':
                    return DefaultPattern;
                case 'g':
                    return ShortPattern;
                case 'G':
                    return LongPattern;
                case 'f':
                    return patternType == TimeSpanPatternType.Formatting ? TimeSpanResources.TimeSpanWordFormat : TimeSpanResources.TimeSpanWordPattern;
                case 'j':
                    return patternType == TimeSpanPatternType.Formatting ? TimeSpanResources.TimeSpanJiraFormat : TimeSpanResources.TimeSpanJiraPattern;
                case 'x':
                    return ISO8601Pattern;
                default:
                    throw new ArgumentException("Invalid format specified.", nameof(format));
            }
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        private double GetValueForGroup(TimeSpan core, string matchGroup)
        {
            switch (matchGroup)
            {
                case "d":
                    return core.Days;
                case "D":
                    return core.TotalDays;
                case "h":
                    return core.Hours;
                case "H":
                    return core.TotalHours;
                case "m":
                    return core.Minutes;
                case "M":
                    return core.TotalMinutes;
                case "s":
                    return core.Seconds;
                case "S":
                    return core.TotalSeconds;
                case "t":
                    return core.Ticks;
                case "k":
                    return core.Milliseconds;
                case "K":
                    return core.TotalMilliseconds;
                case "f":
                case "F":
                    return (double)core.Ticks % TimeSpan.TicksPerSecond / 10000000;
                case "p":
                    return core.TotalSeconds % 60;
                case "w":
                    return core.Days / 7d;
                case "r":
                    return core.Days % 7;
            }
            throw new FormatException();
        }

        private string GetVerboseParseString(string entityName)
        {
            string parseWords;
            switch (entityName)
            {
                case "vd":
                    parseWords = TimeSpanResources.TimeSpanDayStrings;
                    break;
                case "vh":
                    parseWords = TimeSpanResources.TimeSpanHourStrings;
                    break;
                case "vm":
                    parseWords = TimeSpanResources.TimeSpanMinuteStrings;
                    break;
                case "vs":
                    parseWords = TimeSpanResources.TimeSpanSecondStrings;
                    break;
                case "vk":
                    parseWords = TimeSpanResources.TimeSpanMillisecondStrings;
                    break;
                case "vt":
                    parseWords = TimeSpanResources.TimeSpanTickStrings;
                    break;
                default:
                    return string.Empty;
            }
            return string.Format(@"\b(?{1}:{0})\b", string.Join("|", parseWords.Split(',')), WordPatternIgnoreCase ? "i" : string.Empty);
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        private bool ProcessFormatEntity(ParseEntity e, TimeSpan core)
        {
            if (e.name == null && e.children == null)
            {
                e.output = string.Empty;
                return false;
            }
            bool foundValue = false, foundSep = false, foundSpace = false;
            if (e.children != null)
            {
                var sb = new StringBuilder();
                for (var i = 0; i < e.children.Count; i++)
                {
                    if (ProcessFormatEntity(e.children[i], core) && !foundValue)
                        foundValue = true;
                    if (e.children[i].name == "fs")
                    {
                        if (sb.Length > 0)
                            foundSep = true;
                    }
                    else if (e.children[i].name == "ws")
                    {
                        if (sb.Length > 0)
                            foundSpace = true;
                    }
                    else
                    {
                        if (foundSep && !string.IsNullOrEmpty(e.children[i].output))
                        {
                            sb.Append(TimeSpanResources.TimeSpanSeparator);
                            foundSep = false;
                        }
                        if (foundSpace && !string.IsNullOrEmpty(e.children[i].output))
                        {
                            sb.Append(' ');
                            foundSpace = false;
                        }
                        sb.Append(e.children[i].output);
                    }
                }
                e.output = foundValue ? sb.ToString() : string.Empty;
                return foundValue;
            }
            switch (e.name)
            {
                case "n":
                    if (core.Ticks < 0)
                        e.output = CultureInfo.CurrentUICulture.NumberFormat.NegativeSign;
                    break;
                case "d":
                case "D":
                case "h":
                case "H":
                case "m":
                case "M":
                case "s":
                case "S":
                case "t":
                case "k":
                case "K":
                case "p":
                case "f":
                case "F":
                case "w":
                case "r":
                    var val = GetValueForGroup(core, e.name);
                    e.output = GetStringValue(val, e);
                    foundValue = val != 0;
                    break;
                case "ts":
                    e.output = CultureInfo.CurrentUICulture.DateTimeFormat.TimeSeparator;
                    break;
                case "ds":
                    e.output = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
                    break;
                case "ws":
                    e.output = " ";
                    break;
                case "fs":
                    e.output = string.Empty;
                    break;
                case "vd":
                case "vh":
                case "vm":
                case "vs":
                case "vk":
                case "vt":
                    e.output = GetCultureString((long)GetValueForGroup(core, e.name.Substring(1)), e.value);
                    break;
                case "q":
                case "e":
                default:
                    e.output = e.value;
                    break;
            }
            return foundValue;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        private void ProcessParseEntity(ParseEntity e)
        {
            if (e.name == null && e.children == null)
            {
                e.output = string.Empty;
                return;
            }
            if (e.children != null)
            {
                var sb = new StringBuilder();
                sb.Append(e.name != "." ? @"(?:" : @"^\s*");
                for (var i = 0; i < e.children.Count; i++)
                {
                    ProcessParseEntity(e.children[i]);
                    sb.Append(e.children[i].output);
                }
                sb.Append(e.name != "." ? @")?" : @"\s*$");
                e.output = sb.ToString();
                return;
            }
            switch (e.name)
            {
                case "z":
                    break;
                case "n":
                    e.output = $@"(?<n>{Regex.Escape(CultureInfo.CurrentUICulture.NumberFormat.NegativeSign)})?";
                    break;
                case "d":
                case "D":
                case "h":
                case "H":
                case "m":
                case "M":
                case "s":
                case "S":
                case "t":
                case "k":
                case "K":
                case "f":
                case "F":
                case "w":
                case "r":
                    e.output = $@"(?<{e.name}>\d+)";
                    break;
                case "p":
                    e.output = $@"(?<p>\d+(?:{Regex.Escape(CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator)}\d{{0,{e.value.Substring(1)}}})?)";
                    break;
                case "vd":
                case "vh":
                case "vm":
                case "vs":
                case "vk":
                case "vt":
                    e.output = GetVerboseParseString(e.name);
                    break;
                case "ts":
                    e.output = Regex.Escape(CultureInfo.CurrentUICulture.DateTimeFormat.TimeSeparator);
                    break;
                case "ds":
                    e.output = Regex.Escape(CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator);
                    break;
                case "ws":
                    e.output = @"\s+";
                    break;
                case "fs":
                    e.output = @"\s*" + Regex.Escape(TimeSpanResources.TimeSpanSeparator.Trim()) + @"\s*";
                    break;
                case "q":
                case "e":
                default:
                    e.output = Regex.Escape(e.value);
                    break;
            }
        }

        private TimeSpan TimeSpanFromParseMatch(Match p)
        {
            int d = 0, h = 0, m = 0, s = 0;
            double dk = 0;
            try
            {
                if (p.Groups["d"].Success)
                    d = int.Parse(p.Groups["d"].Value);
                if (p.Groups["w"].Success)
                    d += int.Parse(p.Groups["w"].Value) * 7;
                if (p.Groups["h"].Success)
                    h = int.Parse(p.Groups["h"].Value);
                if (p.Groups["m"].Success)
                    m = int.Parse(p.Groups["m"].Value);
                if (p.Groups["s"].Success)
                    s = int.Parse(p.Groups["s"].Value);
                if (p.Groups["p"].Success)
                {
                    var ps = double.Parse(p.Groups["p"].Value);
                    s = (int)Math.Truncate(ps);
                    dk = ps - s;
                }
                else if (p.Groups["s"].Success)
                    s = int.Parse(p.Groups["s"].Value);
            }
            catch
            {
                throw new OverflowException();
            }

            var ret = new TimeSpan(d, h, m, s);

            var fVal = string.Empty;
            if (p.Groups["f"].Success)
                fVal = p.Groups["f"].Value;
            else if (p.Groups["F"].Success)
                fVal = p.Groups["F"].Value;

            if (fVal.Length > 0)
                dk = double.Parse("0" + CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator + fVal);

            if (p.Groups["k"].Success)
                dk = int.Parse(p.Groups["k"].Value) / 1000.0;

            if (dk != 0)
                ret += TimeSpan.FromTicks((long)Math.Round(dk * 10000000));

            if (p.Groups["t"].Success)
                ret += TimeSpan.FromTicks(int.Parse(p.Groups["t"].Value));

            return ret;
        }

        private Match ValidateCustomPattern(string custPattern)
        {
            try
            {
                Match m = null;
                lock (fullPatternCache)
                {
                    if (fullPatternCache.TryGetValue(custPattern, out m))
                        return m;

                    m = MyRegex.Match(custPattern);
                    if (!m.Success)
                        throw new FormatException();
                    fullPatternCache.Add(custPattern, m);
                }
                return m;
            }
            catch
            {
                throw new FormatException();
            }
        }

        private class ParseEntity
        {
            public List<ParseEntity> children;
            public readonly string name;
            public readonly string value;
            public string output;
            public ParseEntity parent;
            public readonly int start;
            public readonly int length;

            public ParseEntity(string n, Capture c, ParseEntity p)
            {
                name = n; value = c.Value; start = c.Index; length = c.Length; parent = p;
            }

            public ParseEntity SiblingAfter
            {
                get
                {
                    var idx = parent.children.IndexOf(this);
                    return idx < parent.children.Count - 1 ? parent.children[idx + 1] : null;
                }
            }

            public ParseEntity SiblingPrior
            {
                get
                {
                    var idx = parent.children.IndexOf(this);
                    return idx > 0 ? parent.children[idx - 1] : null;
                }
            }

            public override string ToString() => output ?? string.Empty;
        }
    }
}