using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace ExtendedControls.Base.Code.Security
{
    #region Class: VirusTotalAPI
    public class VirusTotalAPI
    {
    }
    #endregion

    #region Class: UnixTimeConverter    
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Newtonsoft.Json.Converters.DateTimeConverterBase" />
    public class UnixTimeConverter : DateTimeConverterBase
    {
        #region Constants
        // UNIX start time (Thursday 1st January, 1970 at 00:00 AM)
        private static DateTime _epoc = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        #endregion

        #region Methods
        private static DateTime FromUNIX(long unixTime)
        {
            return _epoc.AddSeconds(unixTime).ToLocalTime();
        }
        #endregion

        #region Overrides
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string returnedValue = reader.Value.ToString();

            if (string.IsNullOrWhiteSpace(returnedValue)) return DateTime.MinValue;

            if (!ResourcesHelper.IsNumeric(returnedValue)) return DateTime.MinValue;

            return FromUNIX(long.Parse(returnedValue));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    #endregion

    #region Class: YearMonthDayConverter
    public class YearMonthDayConverter : DateTimeConverterBase
    {
        #region Variables
        private readonly CultureInfo _culture = new CultureInfo("en-US");
        #endregion

        #region Constants
        private const string _newDateTimeFormat = "yyyyMMdd", _oldDateTimeFormat = "yyyyMMddHHmmss";
        #endregion

        #region Overrides
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) return DateTime.MinValue;

            if (!(reader.Value is string stringVal)) throw new InvalidDateTimeException("Invalid date/time from VirusTotal. Tried to parse: " + reader.Value);

            if (!ResourcesHelper.IsNumeric(stringVal)) return DateTime.MinValue;

            //New format
            if (DateTime.TryParseExact(stringVal, _newDateTimeFormat, _culture, DateTimeStyles.AllowWhiteSpaces, out DateTime result)) return result;

            //Old format
            if (DateTime.TryParseExact(stringVal, _oldDateTimeFormat, _culture, DateTimeStyles.AllowWhiteSpaces, out result)) return result;

            throw new InvalidDateTimeException("Invalid date/time from VirusTotal. Tried to parse: " + stringVal);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.DateFormatString = _newDateTimeFormat;

            writer.WriteValue(value);
        }
        #endregion
    }
    #endregion

    #region Enumerations
    [Flags]
    public enum ResourceType : long
    {
        MD5 = 1 << 0,
        SHA1 = 1 << 1,
        SHA256 = 1 << 2,
        ScanId = 1 << 3,
        URL = 1 << 4,
        IP = 1 << 5,
        Domain = 1 << 6,
        AnyHash = MD5 | SHA1 | SHA256,
        AnyType = AnyHash | ScanId | URL | IP | Domain
    }
    #endregion

    #region Class: AccessDeniedException
    public class AccessDeniedException : Exception
    {
        public AccessDeniedException(string msg) : base(msg) { }
    }
    #endregion

    #region Class: InvalidDateTimeException
    public class InvalidDateTimeException : Exception
    {
        public InvalidDateTimeException(string msg) : base(msg) { }
    }
    #endregion

    #region Class: InvalidResourceException
    public class InvalidResourceException : Exception
    {
        public InvalidResourceException(string msg) : base(msg) { }
    }
    #endregion

    #region Class: RateLimitException
    public class RateLimitException : Exception
    {
        public RateLimitException(string msg) : base(msg) { }
    }
    #endregion

    #region Class: ResourceLimitException
    public class ResourceLimitException : Exception
    {
        public ResourceLimitException(string msg) : base(msg) { }
    }
    #endregion

    #region Class: SizeLimitException
    public class SizeLimitException : Exception
    {
        public SizeLimitException(long virusTotalBytesLimit, long actualBytes) : base($"The file size limit allowed to be uploaded to VirusTotal is: { virusTotalBytesLimit / 1024 } KB. Your file is: { actualBytes / 1024} KB.") { }

        public SizeLimitException(long virusTotalBytesLimit) : base($"The file size limit allowed to be uploaded to VirusTotal is: { virusTotalBytesLimit / 1024 } KB.") { }
    }
    #endregion

    #region Class: EnumerationHelper
    internal static class EnumerationHelper
    {
        public static IEnumerable<Enum> GetIndividualFlags(this Enum value)
        {
            return GetFlags(value, GetFlagValues(value.GetType()).ToArray());
        }

        private static IEnumerable<Enum> GetFlags(Enum value, Enum[] values)
        {
            ulong bits = Convert.ToUInt64(value);

            List<Enum> enums = new List<Enum>();

            for (int i = values.Length - 1; i >= 0; i--)
            {
                ulong mask = Convert.ToUInt64(values[i]);

                if (i == 0 && mask == 0L) break;

                if ((bits & mask) == mask)
                {
                    enums.Add(values[i]);

                    bits -= mask;
                }
            }

            if (bits != 0L) return Enumerable.Empty<Enum>();

            if (Convert.ToUInt64(value) != 0L) return enums.Reverse<Enum>();

            if (bits == Convert.ToUInt64(value) && values.Length > 0 && Convert.ToUInt64(values[0]) == 0L) return values.Take(1);

            return Enumerable.Empty<Enum>();
        }

        private static IEnumerable<Enum> GetFlagValues(Type enumType)
        {
            ulong flag = 0x1;

            foreach (Enum value in Enum.GetValues(enumType).Cast<Enum>())
            {
                ulong bits = Convert.ToUInt64(value);

                if (bits == 0L) continue;

                while (flag < bits)
                {
                    flag <<= 1;
                }

                if (flag == bits) yield return value;
            }
        }
    }
    #endregion

    #region Class: HashHelper
    public static class HashHelper
    {
        public static string GetSHA256(byte[] buffer)
        {
            using (MemoryStream ms = new MemoryStream(buffer))
                return GetSHA256(ms);
        }

        public static string GetSHA256(string content)
        {
            return GetSHA256(content, Encoding.UTF8);
        }

        public static string GetSHA256(string content, Encoding encoding)
        {
            using (MemoryStream ms = new MemoryStream(encoding.GetBytes(content)))
                return GetSHA256(ms);
        }

        public static string GetSHA256(FileInfo file)
        {
            if (!file.Exists)
                throw new FileNotFoundException("File not found.", file.FullName);

            using (FileStream stream = file.OpenRead())
                return GetSHA256(stream);
        }

        public static string GetSHA256(Stream stream)
        {
            if (stream == null || stream.Length == 0)
                throw new ArgumentException("You must provide a valid stream.", nameof(stream));

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(stream);
                return ByteArrayToHex(hashBytes);
            }
        }

        public static string GetSHA1(byte[] buffer)
        {
            using (MemoryStream ms = new MemoryStream(buffer))
                return GetSHA1(ms);
        }

        public static string GetSHA1(string content)
        {
            return GetSHA1(content, Encoding.UTF8);
        }

        public static string GetSHA1(string content, Encoding encoding)
        {
            using (MemoryStream ms = new MemoryStream(encoding.GetBytes(content)))
                return GetSHA1(ms);
        }

        public static string GetSHA1(FileInfo file)
        {
            if (!file.Exists)
                throw new FileNotFoundException("File not found.", file.FullName);

            using (FileStream stream = file.OpenRead())
                return GetSHA1(stream);
        }

        public static string GetSHA1(Stream stream)
        {
            if (stream == null || stream.Length == 0)
                throw new ArgumentException("You must provide a valid stream.", nameof(stream));

            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hashBytes = sha1.ComputeHash(stream);
                return ByteArrayToHex(hashBytes);
            }
        }

        public static string GetMD5(byte[] buffer)
        {
            using (MemoryStream ms = new MemoryStream(buffer))
                return GetMD5(ms);
        }

        public static string GetMD5(string content)
        {
            return GetMD5(content, Encoding.UTF8);
        }

        public static string GetMD5(string content, Encoding encoding)
        {
            using (MemoryStream ms = new MemoryStream(encoding.GetBytes(content)))
                return GetMD5(ms);
        }

        public static string GetMD5(FileInfo file)
        {
            if (!file.Exists)
                throw new FileNotFoundException("File not found.", file.FullName);

            using (FileStream stream = file.OpenRead())
                return GetMD5(stream);
        }

        public static string GetMD5(Stream stream)
        {
            if (stream == null || stream.Length == 0)
                throw new ArgumentException("You must provide a valid stream.", nameof(stream));

            using (MD5 md5 = MD5.Create())
            {
                byte[] md5Result = md5.ComputeHash(stream);
                return ByteArrayToHex(md5Result);
            }
        }

        public static string ByteArrayToHex(byte[] buffer)
        {
            StringBuilder hex = new StringBuilder(buffer.Length * 2);

            foreach (byte b in buffer)
            {
                hex.AppendFormat("{0:x2}", b);
            }

            return hex.ToString();
        }
    }
    #endregion

    #region Class: ResourcesHelper
    public static class ResourcesHelper
    {
        public static IEnumerable<string> GetResourceIdentifier(IEnumerable<FileInfo> files)
        {
            foreach (FileInfo fileInfo in files)
            {
                yield return GetResourceIdentifier(fileInfo);
            }
        }

        public static string GetResourceIdentifier(FileInfo file)
        {
            return HashHelper.GetSHA256(file);
        }

        public static IEnumerable<string> GetResourceIdentifier(IEnumerable<byte[]> files)
        {
            foreach (byte[] fileBytes in files)
            {
                yield return GetResourceIdentifier(fileBytes);
            }
        }

        public static string GetResourceIdentifier(byte[] file)
        {
            return HashHelper.GetSHA256(file);
        }

        public static IEnumerable<string> GetResourceIdentifier(IEnumerable<Stream> streams)
        {
            foreach (Stream stream in streams)
            {
                yield return GetResourceIdentifier(stream);
            }
        }

        public static string GetResourceIdentifier(Stream stream)
        {
            return HashHelper.GetSHA256(stream);
        }

        public static string GetResourceIdentifier(string url)
        {
            if (!IsValidURL(url, out url))
                throw new InvalidResourceException($"The url '{url}' is in the wrong format");

            return HashHelper.GetSHA256(url);
        }

        public static string GetResourceIdentifier(Uri url)
        {
            return GetResourceIdentifier(url.ToString());
        }

        public static IEnumerable<string> ValidateResourcea(IEnumerable<string> resources, ResourceType type)
        {
            if (resources == null)
                throw new InvalidResourceException("No resources given");

            IEnumerable<string> array = resources as string[] ?? resources.ToArray();

            if (!array.Any())
                throw new InvalidResourceException("No resources given");

            foreach (string resource in array)
            {
                yield return ValidateResourcea(resource, type);
            }
        }

        public static string ValidateResourcea(string resource, ResourceType type)
        {
            if (string.IsNullOrWhiteSpace(resource))
                throw new InvalidResourceException("Resource is invalid");

            string sanitized = resource;
            bool valid = false;

            if (type.HasFlag(ResourceType.MD5))
                valid |= IsValidMD5(resource);
            if (type.HasFlag(ResourceType.SHA1))
                valid |= IsValidSHA1(resource);
            if (type.HasFlag(ResourceType.SHA256))
                valid |= IsValidSHA256(resource);
            if (type.HasFlag(ResourceType.ScanId))
                valid |= IsValidScanId(resource);
            if (type.HasFlag(ResourceType.URL))
                valid |= IsValidURL(resource, out sanitized);
            if (type.HasFlag(ResourceType.IP))
                valid |= IsValidIP(resource, out sanitized);
            if (type.HasFlag(ResourceType.Domain))
                valid |= IsValidDomain(resource, out sanitized);

            if (!valid)
                throw new InvalidResourceException($"Resource '{resource}' has to be one of the following: {string.Join(", ", type.GetIndividualFlags())}");

            return sanitized;
        }

        public static bool IsValidScanId(string resource)
        {
            if (resource.Length != 75)
                return false;

            string[] parts = resource.Split('-');

            if (parts.Length != 2)
                return false;

            if (parts[0].Length != 64 || parts[1].Length != 10)
                return false;

            return IsAlphaNumeric(parts[0]) && IsNumeric(parts[1]);
        }

        public static bool IsValidURL(string resource, out string sanitized)
        {
            sanitized = resource;

            if (!resource.Contains('.'))
                return false;

            if (!Uri.TryCreate(NormalizeUrl(resource, false), UriKind.Absolute, out Uri uri))
                return false;

            sanitized = uri.ToString();
            return true;
        }

        public static bool IsValidIP(string resource, out string sanitized)
        {
            sanitized = resource;

            if (!IPAddress.TryParse(resource, out IPAddress ip))
                return false;

            if (ip.AddressFamily != AddressFamily.InterNetwork)
                return false;

            sanitized = ip.ToString();
            return true;
        }

        public static bool IsValidDomain(string resource, out string sanitized)
        {
            sanitized = resource;

            if (!resource.Contains('.'))
                return false;

            if (!Uri.TryCreate(NormalizeUrl(resource, false), UriKind.Absolute, out Uri uri))
                return false;

            sanitized = uri.Host;
            return true;
        }

        public static bool IsValidMD5(string resource)
        {
            return resource.Length == 32 && IsAlphaNumeric(resource);
        }

        public static bool IsValidSHA1(string resource)
        {
            return resource.Length == 40 && IsAlphaNumeric(resource);
        }

        public static bool IsValidSHA256(string resource)
        {
            return resource.Length == 64 && IsAlphaNumeric(resource);
        }

        public static bool IsAlphaNumeric(string input)
        {
            return input.All(char.IsLetterOrDigit);
        }

        public static bool IsNumeric(string input)
        {
            return input != string.Empty && input.All(x => x >= 48 && x <= 57);
        }

        public static string NormalizeUrl(string url, bool useTls)
        {
            string tempUri = url.Trim();

            if (tempUri.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || tempUri.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                return tempUri;

            if (useTls)
            {
                if (!tempUri.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                    tempUri = "https://" + tempUri;
            }
            else
            {
                if (!tempUri.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
                    tempUri = "http://" + tempUri;
            }

            return tempUri;
        }
    }
    #endregion

    #region Class: DetectedUrl
    public class DetectedUrl
    {
        public string Url { get; set; }

        public int Positives { get; set; }

        public int Total { get; set; }

        [JsonProperty("scan_date")]
        public DateTime ScanDate { get; set; }
    }
    #endregion

    #region Class: DomainResolution
    public class DomainResolution
    {
        [JsonProperty("last_resolved", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime LastResolved { get; set; }

        [JsonProperty("ip_address")]
        public string IPAddress { get; set; }
    }
    #endregion

    #region Class: IPResolution
    public class IPResolution
    {
        [JsonProperty("last_resolved", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime LastResolved { get; set; }

        public string Hostname { get; set; }
    }
    #endregion

    #region Class: Sample
    public class Sample
    {
        public int Positives { get; set; }

        public int Total { get; set; }

        public string SHA256 { get; set; }
    }
    #endregion

    #region Class: SampleWithDate
    public class SampleWithDate
    {
        public DateTime Date { get; set; }

        public int Positives { get; set; }

        public int Total { get; set; }

        public string SHA256 { get; set; }
    }
    #endregion

    #region Class: ScanEngine
    public class ScanEngine
    {
        /// <summary>
        /// True if the engine flagged the resource.
        /// </summary>
        public bool Detected { get; set; }

        /// <summary>
        /// Version of the engine.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Contains the name of the malware, if any.
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// The date of the latest signatures of the engine.
        /// </summary>
        [JsonConverter(typeof(YearMonthDayConverter))]
        public DateTime Update { get; set; }
    }
    #endregion
}