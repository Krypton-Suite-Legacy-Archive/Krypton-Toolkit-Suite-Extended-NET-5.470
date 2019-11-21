#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedControls.Base.Code.Security
{
    #region Class: VirusTotalAPI
    public class VirusTotalAPI
    {
        private readonly HttpClient _client;
        private bool _useTls;
        private readonly HttpClientHandler _httpClientHandler;
        private readonly Dictionary<string, string> _defaultValues;
        private readonly JsonSerializer _serializer;

        /// <param name="apiKey">The API key you got from Virus Total</param>
        public VirusTotalAPI(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentException("You have to set an API key.", nameof(apiKey));

            if (apiKey.Length < 64)
                throw new ArgumentException("API key is too short.", nameof(apiKey));

            _defaultValues = new Dictionary<string, string>(1);
            _defaultValues.Add("apikey", apiKey);

            _httpClientHandler = new HttpClientHandler();
            _httpClientHandler.AllowAutoRedirect = false;

            _serializer = JsonSerializer.Create();
            _serializer.NullValueHandling = NullValueHandling.Ignore;

            _client = new HttpClient(_httpClientHandler);

            ApiUrl = "www.virustotal.com/vtapi/v2/";

            RestrictSizeLimits = true;
            RestrictNumberOfResources = true;
        }

        internal VirusTotalAPI(string apiKey, JsonSerializerSettings settings) : this(apiKey)
        {
            _serializer = JsonSerializer.Create(settings);
        }

        /// <summary>
        /// Occurs when the raw JSON response is received from VirusTotal.
        /// </summary>
        public event Action<byte[]> OnRawResponseReceived;

        /// <summary>
        /// Occurs just before we send a request to VirusTotal.
        /// </summary>
        public event Action<HttpRequestMessage> OnHTTPRequestSending;

        /// <summary>
        /// Occurs right after a response has been received from VirusTotal.
        /// </summary>
        public event Action<HttpResponseMessage> OnHTTPResponseReceived;

        /// <summary>
        /// When true, we check the file size before uploading it to Virus Total. The file size restrictions are based on the Virus Total public API 2.0 documentation.
        /// </summary>
        public bool RestrictSizeLimits { get; set; }

        /// <summary>
        /// When true, we check the number of resources that are submitted to Virus Total. The limits are according to Virus Total public API 2.0 documentation.
        /// </summary>
        public bool RestrictNumberOfResources { get; set; }

        /// <summary>
        /// The maximum size (in bytes) that the Virus Total public API 2.0 supports for file uploads.
        /// </summary>
        public long FileSizeLimit { get; set; } = 33553369; //32 MB - 1063 = 33553369 it is the effective limit by virus total as it measures file size limit on the TOTAL request size, and not just the file content.

        /// <summary>
        /// The maximum size (in bytes) of comments.
        /// </summary>
        public int CommentSizeRestriction { get; set; } = 4096;

        /// <summary>
        /// The maximum number of resources you can rescan in one request.
        /// </summary>
        public int RescanBatchSizeLimit { get; set; } = 25;

        /// <summary>
        /// The maximum number of resources you can get file reports for in one request.
        /// </summary>
        public int FileReportBatchSizeLimit { get; set; } = 4;

        /// <summary>
        /// The maximum number of URLs you can get reports for in one request.
        /// </summary>
        public int UrlReportBatchSizeLimit { get; set; } = 4;

        /// <summary>
        /// The maximum number of URLs you can scan in one request.
        /// </summary>
        public int UrlScanBatchSizeLimit { get; set; } = 25;

        /// <summary>
        /// Set to false to use HTTP instead of HTTPS. HTTPS is used by default.
        /// </summary>
        public bool UseTLS
        {
            get => _useTls;
            set
            {
                _useTls = value;

                string oldUrl = ApiUrl;

                if (string.IsNullOrWhiteSpace(oldUrl))
                    return;

                if (oldUrl.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                    oldUrl = oldUrl.Substring(8);
                else if (oldUrl.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
                    oldUrl = oldUrl.Substring(7);

                _client.BaseAddress = _useTls ? new Uri("https://" + oldUrl) : new Uri("http://" + oldUrl);
            }
        }

        /// <summary>
        /// The user-agent to use when doing queries
        /// </summary>
        public string UserAgent
        {
            get => _client.DefaultRequestHeaders.UserAgent.ToString();
            set => _client.DefaultRequestHeaders.Add("User-Agent", value);
        }

        /// <summary>
        /// Get or set the proxy.
        /// </summary>
        public IWebProxy Proxy
        {
            get => _httpClientHandler.Proxy;
            set => _httpClientHandler.Proxy = value;
        }

        /// <summary>
        /// Get or set the timeout.
        /// </summary>
        public TimeSpan Timeout
        {
            get => _client.Timeout;
            set => _client.Timeout = value;
        }

        /// <summary>
        /// The URL which the Virus Total service listens on. If you don't set the scheme to http:// or https:// it will default to https://
        /// </summary>
        public string ApiUrl
        {
            get => _client.BaseAddress.ToString();
            set
            {
                string newUrl = value.Trim();

                if (string.IsNullOrWhiteSpace(newUrl))
                    return;

                if (newUrl.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                {
                    _useTls = true;
                    newUrl = newUrl.Substring(8);
                }
                else if (newUrl.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
                {
                    _useTls = false;
                    newUrl = newUrl.Substring(7);
                }
                else
                    _useTls = true;

                _client.BaseAddress = _useTls ? new Uri("https://" + newUrl) : new Uri("http://" + newUrl);
            }
        }

        /// <summary>
        /// Scan a file.
        /// Note: It is highly encouraged to get the report of the file before scanning, in case it has already been scanned before.
        /// </summary>
        /// <param name="file">The file to scan</param>
        public Task<ScanResult> ScanFileAsync(FileInfo file)
        {
            if (!file.Exists)
                throw new FileNotFoundException("The file was not found.", file.Name);

            return ScanFileAsync(file.OpenRead(), file.Name);
        }

        /// <summary>
        /// Scan a file.
        /// Note: It is highly encouraged to get the report of the file before scanning, in case it has already been scanned before.
        /// Note: You are also strongly encouraged to provide the filename as it is rich metadata for the Virus Total database.
        /// </summary>
        /// <param name="file">The file to scan</param>
        /// <param name="filename">The filename of the file</param>
        public Task<ScanResult> ScanFileAsync(byte[] file, string filename)
        {
            return ScanFileAsync(new MemoryStream(file), filename);
        }

        /// <summary>
        /// Scan a file.
        /// Note: It is highly encouraged to get the report of the file before scanning, in case it has already been scanned before.
        /// Note: You are also strongly encouraged to provide the filename as it is rich metadata for the Virus Total database.
        /// </summary>
        /// <param name="stream">The file to scan</param>
        /// <param name="filename">The filename of the file</param>
        public Task<ScanResult> ScanFileAsync(Stream stream, string filename)
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream), "You must provide a stream that is not null");

            if (stream.Length <= 0)
                throw new ArgumentException("You must provide a stream with content", nameof(stream));

            if (RestrictSizeLimits && stream.Length > FileSizeLimit)
                throw new SizeLimitException(FileSizeLimit, stream.Length);

            if (string.IsNullOrWhiteSpace(filename))
                throw new ArgumentException("You must provide a filename. Preferably the original filename.");

            MultipartFormDataContent multi = new MultipartFormDataContent();
            multi.Add(CreateApiPart());
            multi.Add(CreateFileContent(stream, filename));

            //https://www.virustotal.com/vtapi/v2/file/scan
            return GetResult<ScanResult>("file/scan", HttpMethod.Post, multi);
        }

        /// <summary>
        /// Tell VirusTotal to rescan a file.
        /// Note: This does not send the files to VirusTotal. It hashes the file and sends that instead.
        /// Note: Before requesting a rescan you should retrieve the latest report on the file.
        /// </summary>
        public Task<RescanResult> RescanFileAsync(FileInfo file)
        {
            return RescanFileAsync(ResourcesHelper.GetResourceIdentifier(file));
        }

        /// <summary>
        /// Tell VirusTotal to rescan a file.
        /// Note: This does not send the files to VirusTotal. It hashes the file and sends that instead.
        /// Note: Before requesting a rescan you should retrieve the latest report on the file.
        /// </summary>
        public Task<RescanResult> RescanFileAsync(byte[] file)
        {
            return RescanFileAsync(ResourcesHelper.GetResourceIdentifier(file));
        }

        /// <summary>
        /// Tell VirusTotal to rescan a file.
        /// Note: This does not send the files to VirusTotal. It hashes the file and sends that instead.
        /// Note: Before requesting a rescan you should retrieve the latest report on the file.
        /// </summary>
        public Task<RescanResult> RescanFileAsync(Stream stream)
        {
            return RescanFileAsync(ResourcesHelper.GetResourceIdentifier(stream));
        }

        /// <summary>
        /// Tell VirusTotal to rescan a file without sending the actual file to VirusTotal.
        /// Note: Before requesting a rescan you should retrieve the latest report on the file.
        /// </summary>
        /// <param name="resource">A hash of the file. It can be an MD5, SHA1 or SHA256</param>
        public Task<RescanResult> RescanFileAsync(string resource)
        {
            resource = ResourcesHelper.ValidateResourcea(resource, ResourceType.AnyHash);

            //Required
            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("resource", resource);

            //https://www.virustotal.com/vtapi/v2/file/rescan
            return GetResult<RescanResult>("file/rescan", HttpMethod.Post, CreateURLEncodedContent(values));
        }

        /// <summary>
        /// Tell VirusTotal to rescan a file.
        /// Note: This does not send the files to VirusTotal. It hashes the file and sends that instead.
        /// Note: Before requesting a rescan you should retrieve the latest report on the files.
        /// </summary>
        public Task<IEnumerable<RescanResult>> RescanFilesAsync(IEnumerable<FileInfo> files)
        {
            return RescanFilesAsync(ResourcesHelper.GetResourceIdentifier(files));
        }

        /// <summary>
        /// Tell VirusTotal to rescan a file.
        /// Note: This does not send the files to VirusTotal. It hashes the file and sends that instead.
        /// Note: Before requesting a rescan you should retrieve the latest report on the files.
        /// </summary>
        public Task<IEnumerable<RescanResult>> RescanFilesAsync(IEnumerable<byte[]> files)
        {
            return RescanFilesAsync(ResourcesHelper.GetResourceIdentifier(files));
        }

        /// <summary>
        /// Tell VirusTotal to rescan a file.
        /// Note: This does not send the content of the streams to VirusTotal. It hashes the content and sends that instead.
        /// Note: Before requesting a rescan you should retrieve the latest report on the files.
        /// </summary>
        public Task<IEnumerable<RescanResult>> RescanFilesAsync(IEnumerable<Stream> streams)
        {
            return RescanFilesAsync(ResourcesHelper.GetResourceIdentifier(streams));
        }

        /// <summary>
        /// Tell VirusTotal to rescan a file.
        /// Note: This does not send the files to VirusTotal. It hashes the file and sends that instead.
        /// Note: Before requesting a rescan you should retrieve the latest report on the files.
        /// Note: You can use MD5, SHA1 or SHA256 and even mix them.
        /// Note: You can only request a maximum of 25 rescans at the time.
        /// </summary>
        /// <param name="resourceList">a MD5, SHA1 or SHA256 of the files. You can also specify list made up of a combination of any of the three allowed hashes (up to 25 items), this allows you to perform a batch request with one single call.</param>
        public Task<IEnumerable<RescanResult>> RescanFilesAsync(IEnumerable<string> resourceList)
        {
            resourceList = ResourcesHelper.ValidateResourcea(resourceList, ResourceType.AnyHash);

            string[] resources = resourceList as string[] ?? resourceList.ToArray();

            if (RestrictNumberOfResources && resources.Length > RescanBatchSizeLimit)
                throw new ResourceLimitException($"Too many resources. There is a maximum of {RescanBatchSizeLimit} resources at the time.");

            //Required
            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("resource", string.Join(",", resources));

            //https://www.virustotal.com/vtapi/v2/file/rescan
            return GetResults<RescanResult>("file/rescan", HttpMethod.Post, CreateURLEncodedContent(values));
        }

        /// <summary>
        /// Gets the report of the file.
        /// Note: This does not send the files to VirusTotal. It hashes the file and sends that instead.
        /// </summary>
        /// <param name="file">The file you want to get a report on.</param>
        public Task<FileReport> GetFileReportAsync(byte[] file)
        {
            return GetFileReportAsync(ResourcesHelper.GetResourceIdentifier(file));
        }

        /// <summary>
        /// Gets the report of the file.
        /// Note: This does not send the files to VirusTotal. It hashes the file and sends that instead.
        /// </summary>
        /// <param name="file">The file you want to get a report on.</param>
        public Task<FileReport> GetFileReportAsync(FileInfo file)
        {
            return GetFileReportAsync(ResourcesHelper.GetResourceIdentifier(file));
        }

        /// <summary>
        /// Gets the report of the file.
        /// Note: This does not send the files to VirusTotal. It hashes the file and sends that instead.
        /// </summary>
        /// <param name="stream">The stream you want to get a report on.</param>
        public Task<FileReport> GetFileReportAsync(Stream stream)
        {
            return GetFileReportAsync(ResourcesHelper.GetResourceIdentifier(stream));
        }

        /// <summary>
        /// Gets the report of the file.
        /// Note: This does not send the files to VirusTotal. It hashes the file and sends that instead.
        /// </summary>
        /// <param name="resource">The resource (MD5, SHA1 or SHA256) you wish to get a report on.</param>
        public Task<FileReport> GetFileReportAsync(string resource)
        {
            resource = ResourcesHelper.ValidateResourcea(resource, ResourceType.AnyHash | ResourceType.ScanId);

            //Required
            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("resource", resource);

            //https://www.virustotal.com/vtapi/v2/file/report
            return GetResult<FileReport>("file/report", HttpMethod.Post, CreateURLEncodedContent(values));
        }

        /// <summary>
        /// Gets a list of reports of the files.
        /// Note: This does not send the files to VirusTotal. It hashes the files and sends them instead.
        /// </summary>
        /// <param name="files">The files you want to get reports on.</param>
        public Task<IEnumerable<FileReport>> GetFileReportsAsync(IEnumerable<byte[]> files)
        {
            return GetFileReportsAsync(ResourcesHelper.GetResourceIdentifier(files));
        }

        /// <summary>
        /// Gets a list of reports of the files.
        /// Note: This does not send the files to VirusTotal. It hashes the files and sends them instead.
        /// </summary>
        /// <param name="files">The files you want to get reports on.</param>
        public Task<IEnumerable<FileReport>> GetFileReportsAsync(IEnumerable<FileInfo> files)
        {
            return GetFileReportsAsync(ResourcesHelper.GetResourceIdentifier(files));
        }

        /// <summary>
        /// Gets a list of reports of the files.
        /// Note: This does not send the content of the streams to VirusTotal. It hashes the content of the stream and sends that instead.
        /// </summary>
        /// <param name="streams">The streams you want to get reports on.</param>
        public Task<IEnumerable<FileReport>> GetFileReportsAsync(IEnumerable<Stream> streams)
        {
            return GetFileReportsAsync(ResourcesHelper.GetResourceIdentifier(streams));
        }

        /// <summary>
        /// Gets the report of the file represented by its hash or scan ID.
        /// Keep in mind that URLs sent using the API have the lowest scanning priority, depending on VirusTotal's load, it may take several hours before the file is scanned,
        /// so query the report at regular intervals until the result shows up and do not keep submitting the file over and over again.
        /// </summary>
        /// <param name="resourceList">SHA1, MD5 or SHA256 of the file. It can also be a scan ID of a previous scan.</param>
        public Task<IEnumerable<FileReport>> GetFileReportsAsync(IEnumerable<string> resourceList)
        {
            resourceList = ResourcesHelper.ValidateResourcea(resourceList, ResourceType.AnyHash | ResourceType.ScanId);

            string[] resources = resourceList as string[] ?? resourceList.ToArray();

            if (RestrictNumberOfResources && resources.Length > FileReportBatchSizeLimit)
                throw new ResourceLimitException($"Too many hashes. There is a maximum of {FileReportBatchSizeLimit} resources at the same time.");

            //Required
            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("resource", string.Join(",", resources));

            //https://www.virustotal.com/vtapi/v2/file/report
            return GetResults<FileReport>("file/report", HttpMethod.Post, CreateURLEncodedContent(values));
        }

        /// <summary>
        /// Scan the given URL. The URL will be downloaded by VirusTotal and processed.
        /// Note: Before performing your submission, you should retrieve the latest report on the URL.
        /// </summary>
        /// <param name="url">The URL to process.</param>
        public Task<URLScanResult> ScanUrlAsync(string url)
        {
            url = ResourcesHelper.ValidateResourcea(url, ResourceType.URL);

            //Required
            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("url", url);

            //https://www.virustotal.com/vtapi/v2/url/scan
            return GetResult<URLScanResult>("url/scan", HttpMethod.Post, CreateURLEncodedContent(values));
        }

        /// <summary>
        /// Scan the given URL. The URL will be downloaded by VirusTotal and processed.
        /// Note: Before performing your submission, you should retrieve the latest report on the URL.
        /// </summary>
        /// <param name="url">The URL to process.</param>
        public Task<URLScanResult> ScanUrlAsync(Uri url)
        {
            return ScanUrlAsync(url.ToString());
        }

        /// <summary>
        /// Scan the given URLs. The URLs will be downloaded by VirusTotal and processed.
        /// Note: Before performing your submission, you should retrieve the latest reports on the URLs.
        /// </summary>
        /// <param name="urls">The URLs to process.</param>
        public Task<IEnumerable<URLScanResult>> ScanUrlsAsync(IEnumerable<string> urls)
        {
            urls = ResourcesHelper.ValidateResourcea(urls, ResourceType.URL);

            string[] urlCast = urls as string[] ?? urls.ToArray();

            if (RestrictNumberOfResources && urlCast.Length > UrlScanBatchSizeLimit)
                throw new ResourceLimitException($"Too many URLs. There is a maximum of {UrlScanBatchSizeLimit} URLs at the same time.");

            //Required
            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("url", string.Join(Environment.NewLine, urlCast));

            //https://www.virustotal.com/vtapi/v2/url/scan
            return GetResults<URLScanResult>("url/scan", HttpMethod.Post, CreateURLEncodedContent(values));
        }

        /// <summary>
        /// Scan the given URLs. The URLs will be downloaded by VirusTotal and processed.
        /// Note: Before performing your submission, you should retrieve the latest reports on the URLs.
        /// </summary>
        /// <param name="urlList">The URLs to process.</param>
        public Task<IEnumerable<URLScanResult>> ScanUrlsAsync(IEnumerable<Uri> urlList)
        {
            return ScanUrlsAsync(urlList.Select(x => x.ToString()));
        }

        /// <summary>
        /// Gets a scan report from an URL
        /// </summary>
        /// <param name="url">The URL you wish to get the report on.</param>
        /// <param name="scanIfNoReport">Set to true if you wish VirusTotal to scan the URL if it is not present in the database.</param>
        public Task<URLReport> GetUrlReportAsync(string url, bool scanIfNoReport = false)
        {
            url = ResourcesHelper.ValidateResourcea(url, ResourceType.URL | ResourceType.ScanId);

            //Required
            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("resource", url);

            //Optional
            if (scanIfNoReport)
                values.Add("scan", "1");

            //Output
            return GetResult<URLReport>("url/report", HttpMethod.Post, CreateURLEncodedContent(values));
        }

        /// <summary>
        /// Gets a scan report from an URL
        /// </summary>
        /// <param name="url">The URL you wish to get the report on.</param>
        /// <param name="scanIfNoReport">Set to true if you wish VirusTotal to scan the URL if it is not present in the database.</param>
        public Task<URLReport> GetUrlReportAsync(Uri url, bool scanIfNoReport = false)
        {
            return GetUrlReportAsync(url.ToString(), scanIfNoReport);
        }

        /// <summary>
        /// Gets a scan report from a list of URLs
        /// </summary>
        /// <param name="urls">The URLs you wish to get the reports on.</param>
        /// <param name="scanIfNoReport">Set to true if you wish VirusTotal to scan the URLs if it is not present in the database.</param>
        public Task<IEnumerable<URLReport>> GetUrlReportsAsync(IEnumerable<string> urls, bool scanIfNoReport = false)
        {
            urls = ResourcesHelper.ValidateResourcea(urls, ResourceType.URL);

            string[] urlCast = urls as string[] ?? urls.ToArray();

            if (RestrictNumberOfResources && urlCast.Length > UrlReportBatchSizeLimit)
                throw new ResourceLimitException($"Too many URLs. There is a maximum of {UrlReportBatchSizeLimit} urls at the time.");

            //Required
            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("resource", string.Join(Environment.NewLine, urlCast));

            //Optional
            if (scanIfNoReport)
                values.Add("scan", "1");

            //Output
            return GetResults<URLReport>("url/report", HttpMethod.Post, CreateURLEncodedContent(values));
        }

        /// <summary>
        /// Gets a scan report from a list of URLs
        /// </summary>
        /// <param name="urlList">The URLs you wish to get the reports on.</param>
        /// <param name="scanIfNoReport">Set to true if you wish VirusTotal to scan the URLs if it is not present in the database.</param>
        public Task<IEnumerable<URLReport>> GetUrlReportsAsync(IEnumerable<Uri> urlList, bool scanIfNoReport = false)
        {
            return GetUrlReportsAsync(urlList.Select(x => x.ToString()), scanIfNoReport);
        }

        /// <summary>
        /// Gets a scan report from an IP
        /// </summary>
        /// <param name="ip">The IP you wish to get the report on.</param>
        public Task<IPReport> GetIPReportAsync(string ip)
        {
            ip = ResourcesHelper.ValidateResourcea(ip, ResourceType.IP);

            return GetResult<IPReport>("ip-address/report?apikey=" + _defaultValues["apikey"] + "&ip=" + ip, HttpMethod.Get, null);
        }

        /// <summary>
        /// Gets a scan report from an IP
        /// </summary>
        /// <param name="ip">The IP you wish to get the report on.</param>
        public Task<IPReport> GetIPReportAsync(IPAddress ip)
        {
            return GetIPReportAsync(ip.ToString());
        }

        /// <summary>
        /// Gets a scan report from a domain
        /// </summary>
        /// <param name="domain">The domain you wish to get the report on.</param>
        public Task<DomainReport> GetDomainReportAsync(string domain)
        {
            domain = ResourcesHelper.ValidateResourcea(domain, ResourceType.Domain);

            //Hack because VT thought it was a good idea to have this API call as GET
            return GetResult<DomainReport>("domain/report?apikey=" + _defaultValues["apikey"] + "&domain=" + domain, HttpMethod.Get, null);
        }

        /// <summary>
        /// Gets a scan report from a domain
        /// </summary>
        /// <param name="domain">The domain you wish to get the report on.</param>
        public Task<DomainReport> GetDomainReportAsync(Uri domain)
        {
            return GetDomainReportAsync(domain.Host);
        }

        /// <summary>
        /// Retrieves a comment on a file.
        /// </summary>
        /// <param name="file">The file you wish to retrieve a comment from</param>
        /// <param name="before">TODO</param>
        public Task<CommentResult> GetCommentAsync(byte[] file, DateTime? before = null)
        {
            return GetCommentAsync(ResourcesHelper.GetResourceIdentifier(file), before);
        }

        /// <summary>
        /// Retrieves a comment on a file.
        /// </summary>
        /// <param name="file">The file you wish to retrieve a comment from</param>
        /// <param name="before">TODO</param>
        public Task<CommentResult> GetCommentAsync(FileInfo file, DateTime? before = null)
        {
            return GetCommentAsync(ResourcesHelper.GetResourceIdentifier(file), before);
        }

        /// <summary>
        /// Retrieves a comment from an URL.
        /// </summary>
        /// <param name="uri">The URL you wish to retrieve a comment from</param>
        /// <param name="before">TODO</param>
        public Task<CommentResult> GetCommentAsync(Uri uri, DateTime? before = null)
        {
            return GetCommentAsync(uri.ToString(), before);
        }

        /// <summary>
        /// Retrieves a comment on a resource.
        /// </summary>
        /// <param name="resource">The MD5/SHA1/SHA256 hash or URL.</param>
        /// <param name="before">TODO</param>
        public Task<CommentResult> GetCommentAsync(string resource, DateTime? before = null)
        {
            resource = ResourcesHelper.ValidateResourcea(resource, ResourceType.AnyHash | ResourceType.URL);

            //TODO: before

            //https://www.virustotal.com/vtapi/v2/comments/get
            return GetResult<CommentResult>("comments/get?apikey=" + _defaultValues["apikey"] + "&resource=" + resource, HttpMethod.Get, null);
        }

        /// <summary>
        /// Creates a comment on a file
        /// </summary>
        /// <param name="file">The file you wish to create a comment on</param>
        /// <param name="comment">The comment you wish to add.</param>
        public Task<CreateCommentResult> CreateCommentAsync(byte[] file, string comment)
        {
            return CreateCommentAsync(ResourcesHelper.GetResourceIdentifier(file), comment);
        }

        /// <summary>
        /// Creates a comment on a file
        /// </summary>
        /// <param name="file">The file you wish to create a comment on</param>
        /// <param name="comment">The comment you wish to add.</param>
        public Task<CreateCommentResult> CreateCommentAsync(FileInfo file, string comment)
        {
            return CreateCommentAsync(ResourcesHelper.GetResourceIdentifier(file), comment);
        }

        /// <summary>
        /// Creates a comment on an URL
        /// </summary>
        /// <param name="url">The URL you wish to create a comment on</param>
        /// <param name="comment">The comment you wish to add.</param>
        public Task<CreateCommentResult> CreateCommentAsync(Uri url, string comment)
        {
            return CreateCommentAsync(url.ToString(), comment);
        }

        /// <summary>
        /// Creates a comment on a resource
        /// </summary>
        /// <param name="resource">The MD5/SHA1/SHA256 hash or URL.</param>
        /// <param name="comment">The comment you wish to add.</param>
        public Task<CreateCommentResult> CreateCommentAsync(string resource, string comment)
        {
            resource = ResourcesHelper.ValidateResourcea(resource, ResourceType.AnyHash | ResourceType.URL);

            if (string.IsNullOrWhiteSpace(comment))
                throw new ArgumentException("Comment must not be null or whitespace", nameof(comment));

            if (RestrictSizeLimits && comment.Length > CommentSizeRestriction)
                throw new ArgumentOutOfRangeException(nameof(comment), $"Your comment is larger than the maximum size of {CommentSizeRestriction / 1024} KB");

            //Required
            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("resource", resource);
            values.Add("comment", comment);

            //https://www.virustotal.com/vtapi/v2/comments/put
            return GetResult<CreateCommentResult>("comments/put", HttpMethod.Post, CreateURLEncodedContent(values));
        }

        /// <summary>
        /// Gives you a link to a file analysis based on its hash.
        /// </summary>
        public string GetPublicFileScanLink(string resource)
        {
            resource = ResourcesHelper.ValidateResourcea(resource, ResourceType.AnyHash);

            return ResourcesHelper.NormalizeUrl($"www.virustotal.com/#/file/{resource}/detection", UseTLS);
        }

        /// <summary>
        /// Gives you a link to a file analysis based on its hash.
        /// Note: This actually hashes the file - if you have the hash already, use the overload that takes in a string.
        /// </summary>
        public string GetPublicFileScanLink(FileInfo file)
        {
            if (file == null)
                throw new ArgumentNullException(nameof(file));

            if (!file.Exists)
                throw new FileNotFoundException("The file you provided does not exist.", file.FullName);

            return GetPublicFileScanLink(ResourcesHelper.GetResourceIdentifier(file));
        }

        /// <summary>
        /// Gives you a link to a URL analysis.
        /// </summary>
        /// <returns>A link to VirusTotal that contains the report</returns>
        public string GetPublicUrlScanLink(string url)
        {
            url = ResourcesHelper.ValidateResourcea(url, ResourceType.URL);

            return ResourcesHelper.NormalizeUrl($"www.virustotal.com/#/url/{ResourcesHelper.GetResourceIdentifier(url)}/detection", UseTLS);
        }

        /// <summary>
        /// Gives you a link to a URL analysis.
        /// </summary>
        /// <returns>A link to VirusTotal that contains the report</returns>
        public string GetPublicUrlScanLink(Uri url)
        {
            return GetPublicUrlScanLink(url.ToString());
        }

        private async Task<IEnumerable<T>> GetResults<T>(string url, HttpMethod method, HttpContent content)
        {
            HttpResponseMessage response = await SendRequest(url, method, content).ConfigureAwait(false);

            using (Stream responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
            using (StreamReader sr = new StreamReader(responseStream, Encoding.UTF8))
            using (JsonTextReader jsonTextReader = new JsonTextReader(sr))
            {
                jsonTextReader.CloseInput = false;

                SaveResponse(responseStream);

                JToken token = JToken.Load(jsonTextReader);

                if (token.Type == JTokenType.Array)
                    return token.ToObject<List<T>>(_serializer);

                return new List<T> { token.ToObject<T>(_serializer) };
            }
        }

        private async Task<T> GetResult<T>(string url, HttpMethod method, HttpContent content)
        {
            HttpResponseMessage response = await SendRequest(url, method, content).ConfigureAwait(false);

            using (Stream responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
            using (StreamReader sr = new StreamReader(responseStream, Encoding.UTF8))
            using (JsonTextReader jsonTextReader = new JsonTextReader(sr))
            {
                jsonTextReader.CloseInput = false;

                SaveResponse(responseStream);

                return _serializer.Deserialize<T>(jsonTextReader);
            }
        }

        private async Task<HttpResponseMessage> SendRequest(string url, HttpMethod method, HttpContent content)
        {
            HttpRequestMessage request = new HttpRequestMessage(method, url);
            request.Content = content;

            OnHTTPRequestSending?.Invoke(request);

            HttpResponseMessage response = await _client.SendAsync(request).ConfigureAwait(false);

            OnHTTPResponseReceived?.Invoke(response);

            if (response.StatusCode == HttpStatusCode.NoContent)
                throw new RateLimitException("You have reached the 4 requests pr. min. limit of VirusTotal");

            if (response.StatusCode == HttpStatusCode.Forbidden)
                throw new AccessDeniedException("You don't have access to the service. Make sure your API key is working correctly.");

            if (response.StatusCode == HttpStatusCode.RequestEntityTooLarge)
                throw new SizeLimitException(FileSizeLimit);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception("API gave error code " + response.StatusCode);

            if (string.IsNullOrWhiteSpace(response.Content.ToString()))
                throw new Exception("There were no content in the response.");

            return response;
        }

        private void SaveResponse(Stream stream)
        {
            if (OnRawResponseReceived == null)
                return;

            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                OnRawResponseReceived(ms.ToArray());
            }

            stream.Position = 0;
        }

        private HttpContent CreateApiPart()
        {
            HttpContent content = new StringContent(_defaultValues["apikey"]);
            content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"apikey\""
            };

            return content;
        }

        private HttpContent CreateFileContent(Stream stream, string fileName)
        {
            StreamContent fileContent = new StreamContent(stream);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"file\"",
                FileName = "\"" + fileName + "\"",
                Size = stream.Length
            };
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            return fileContent;
        }

        private HttpContent CreateURLEncodedContent(IDictionary<string, string> values)
        {
            return new CustomURLEncodedContent(_defaultValues.Concat(values));
        }
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

    public enum CommentResponseCode
    {
        Error = 0,
        Success = 1
    }

    public enum DomainResponseCode
    {
        /// <summary>
        /// The item you searched for was not present in VirusTotal's dataset.
        /// </summary>
        NotPresent = 0,

        /// <summary>
        /// The item was present and it could be retrieved.
        /// </summary>
        Present = 1
    }

    public enum FileReportResponseCode
    {
        /// <summary>
        /// The resource is still being scanned
        /// </summary>
        Queued = -2,

        /// <summary>
        /// The item you searched for was not present in VirusTotal's dataset.
        /// </summary>
        NotPresent = 0,

        /// <summary>
        /// The item was present and it could be retrieved.
        /// </summary>
        Present = 1
    }

    public enum IPReportResponseCode
    {
        /// <summary>
        /// The item you searched for was not present in VirusTotal's dataset.
        /// </summary>
        NotPresent = 0,

        /// <summary>
        /// The item was present and it could be retrieved.
        /// </summary>
        Present = 1
    }

    public enum RescanResponseCode
    {
        /// <summary>
        /// There was an error in the request
        /// </summary>
        ResourceNotFound = 0,

        /// <summary>
        /// The requested item is still queued for analysis.
        /// </summary>
        Queued = 1
    }

    public enum ScanFileResponseCode
    {
        //Note: I don't think Error can happen.

        /// <summary>
        /// An error happened in the request.
        /// </summary>
        Error = 0,

        /// <summary>
        /// The requested item is still queued for analysis.
        /// </summary>
        Queued = 1
    }

    public enum UrlReportResponseCode
    {
        /// <summary>
        /// The item you searched for was not present in VirusTotal's dataset.
        /// </summary>
        NotPresent = 0,

        /// <summary>
        /// The item was indeed present and it could be retrieved.
        /// </summary>
        Present = 1
    }

    public enum UrlScanResponseCode
    {
        /// <summary>
        /// The requested item is queued for analysis.
        /// </summary>
        Queued = 1
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

    #region Class: URLScanEngine
    public class URLScanEngine
    {
        /// <summary>
        /// True if the engine flagged the resource.
        /// </summary>
        public bool Detected { get; set; }

        /// <summary>
        /// Details about the detection
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Contains the name of the malware, if any.
        /// </summary>
        public string Result { get; set; }
    }
    #endregion

    #region Class: UserComment
    public class UserComment
    {
        public string Comment { get; set; }

        public DateTime Date { get; set; }
    }
    #endregion

    #region Class: WebutationInfo
    public class WebutationInfo
    {
        [JsonProperty("Adult content")]
        public string AdultContent { get; set; }

        [JsonProperty("Safety score")]
        public int SafetyScore { get; set; }

        public string Verdict { get; set; }
    }
    #endregion

    #region Class: WOTInfo
    public class WOTInfo
    {
        [JsonProperty("Child safety")]
        public string ChildSafety { get; set; }

        public string Privacy { get; set; }

        public string Trustworthiness { get; set; }

        [JsonProperty("Vendor reliability")]
        public string VendorReliability { get; set; }
    }
    #endregion

    #region Class: CommentResult
    public class CommentResult
    {
        /// <summary>
        /// A list of comments on the resource
        /// </summary>
        public List<UserComment> Comments { get; set; }

        /// <summary>
        /// Contains the message that corresponds to the response code.
        /// </summary>
        [JsonProperty("verbose_msg")]
        public string VerboseMsg { get; set; }
    }
    #endregion

    #region Class: CreateCommentResult
    public class CreateCommentResult
    {
        [JsonProperty("response_code")]
        public CommentResponseCode ResponseCode { get; set; }

        /// <summary>
        /// Contains the message that corresponds to the response code.
        /// </summary>
        [JsonProperty("verbose_msg")]
        public string VerboseMsg { get; set; }
    }
    #endregion

    #region Class: DomainReport
    public class DomainReport
    {
        [JsonProperty("Alexa category")]
        public string AlexaCategory { get; set; }

        [JsonProperty("Alexa domain info")]
        public string AlexaDomainInfo { get; set; }

        [JsonProperty("Alexa rank")]
        public int AlexaRank { get; set; }

        [JsonProperty("BitDefender category")]
        public string BitDefenderCategory { get; set; }

        [JsonProperty("BitDefender domain info")]
        public string BitDefenderDomainInfo { get; set; }

        public List<string> Categories { get; set; }

        [JsonProperty("detected_communicating_samples")]
        public List<SampleWithDate> DetectedCommunicatingSamples { get; set; }

        [JsonProperty("detected_downloaded_samples")]
        public List<SampleWithDate> DetectedDownloadedSamples { get; set; }

        [JsonProperty("detected_referrer_samples")]
        public List<SampleWithDate> DetectedReferrerSamples { get; set; }

        [JsonProperty("detected_urls")]
        public List<DetectedUrl> DetectedUrls { get; set; }

        [JsonProperty("Dr.Web category")]
        public string DrWebCategory { get; set; }

        [JsonProperty("Forcepoint ThreatSeeker category")]
        public string ForcePointThreatSeekerCategory { get; set; }

        [JsonProperty("Opera domain info")]
        public string OperaDomainInfo { get; set; }

        public List<string> Pcaps { get; set; }

        public List<DomainResolution> Resolutions { get; set; }

        [JsonProperty("domain_siblings")]
        public List<string> DomainSiblings { get; set; }

        [JsonProperty("subdomains")]
        public List<string> SubDomains { get; set; }

        [JsonProperty("TrendMicro category")]
        public string TrendMicroCategory { get; set; }

        [JsonProperty("undetected_communicating_samples")]
        public List<SampleWithDate> UndetectedCommunicatingSamples { get; set; }

        [JsonProperty("undetected_downloaded_samples")]
        public List<SampleWithDate> UndetectedDownloadedSamples { get; set; }

        [JsonProperty("undetected_referrer_samples")]
        public List<SampleWithDate> UndetectedReferrerSamples { get; set; }

        [JsonProperty("undetected_urls")]
        public List<List<string>> UndetectedUrls { get; set; }

        [JsonProperty("Websense ThreatSeeker category")]
        public string WebsenseThreatSeekerCategory { get; set; }

        [JsonProperty("Webutation domain info")]
        public WebutationInfo WebutationDomainInfo { get; set; }

        [JsonProperty("whois")]
        public string WhoIs { get; set; }

        [JsonProperty("whois_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixTimeConverter))]
        public DateTime WhoIsTimestamp { get; set; }

        [JsonProperty("WOT domain info")]
        public WOTInfo WOTDomainInfo { get; set; }

        [JsonProperty("response_code")]
        public DomainResponseCode ResponseCode { get; set; }

        /// <summary>
        /// Contains the message that corresponds to the response code.
        /// </summary>
        [JsonProperty("verbose_msg")]
        public string VerboseMsg { get; set; }
    }
    #endregion

    #region Class: FileReport
    public class FileReport
    {
        /// <summary>
        /// MD5 hash of the resource.
        /// </summary>
        public string MD5 { get; set; }

        /// <summary>
        /// A permanent link that points to this specific scan.
        /// </summary>
        public string Permalink { get; set; }

        /// <summary>
        /// How many engines flagged this resource.
        /// </summary>
        public int Positives { get; set; }

        /// <summary>
        /// Contains the id of the resource. Can be a SHA256, MD5 or other hash type.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// The date the resource was last scanned.
        /// </summary>
        [JsonProperty("scan_date")]
        public DateTime ScanDate { get; set; }

        /// <summary>
        /// Contains the scan id for this result.
        /// </summary>
        [JsonProperty("scan_id")]
        public string ScanId { get; set; }

        /// <summary>
        /// The scan results from each engine.
        /// </summary>
        public Dictionary<string, ScanEngine> Scans { get; set; }

        /// <summary>
        /// SHA1 hash of the resource.
        /// </summary>
        public string SHA1 { get; set; }

        /// <summary>
        /// SHA256 hash of the resource.
        /// </summary>
        public string SHA256 { get; set; }

        /// <summary>
        /// How many engines scanned this resource.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// The response code. Use this to determine the status of the report.
        /// </summary>
        [JsonProperty("response_code")]
        public FileReportResponseCode ResponseCode { get; set; }

        /// <summary>
        /// Contains the message that corresponds to the response code.
        /// </summary>
        [JsonProperty("verbose_msg")]
        public string VerboseMsg { get; set; }
    }
    #endregion

    #region Class: IPReport
    public class IPReport
    {
        [JsonProperty("as_owner")]
        public string AsOwner { get; set; }

        public int ASN { get; set; }

        public string Country { get; set; }

        [JsonProperty("detected_communicating_samples")]
        public List<SampleWithDate> DetectedCommunicatingSamples { get; set; }

        [JsonProperty("detected_downloaded_samples")]
        public List<SampleWithDate> DetectedDownloadedSamples { get; set; }

        [JsonProperty("detected_referrer_samples")]
        public List<SampleWithDate> DetectedReferrerSamples { get; set; }

        [JsonProperty("detected_urls")]
        public List<DetectedUrl> DetectedUrls { get; set; }

        public List<IPResolution> Resolutions { get; set; }

        [JsonProperty("undetected_communicating_samples")]
        public List<SampleWithDate> UndetectedCommunicatingSamples { get; set; }

        [JsonProperty("undetected_downloaded_samples")]
        public List<SampleWithDate> UndetectedDownloadedSamples { get; set; }

        [JsonProperty("undetected_referrer_samples")]
        public List<Sample> UndetectedReferrerSamples { get; set; }

        [JsonProperty("undetected_urls")]
        public List<List<string>> UndetectedUrls { get; set; }

        /// <summary>
        /// The response code. Use this to determine the status of the report.
        /// </summary>
        [JsonProperty("response_code")]
        public IPReportResponseCode ResponseCode { get; set; }

        /// <summary>
        /// Contains the message that corresponds to the response code.
        /// </summary>
        [JsonProperty("verbose_msg")]
        public string VerboseMsg { get; set; }
    }
    #endregion

    #region Class: RescanResult
    public class RescanResult
    {
        /// <summary>
        /// A unique link to this particular scan result.
        /// </summary>
        public string Permalink { get; set; }

        /// <summary>
        /// Id of the resource.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// The unique scan id of the resource.
        /// </summary>
        [JsonProperty("scan_id")]
        public string ScanId { get; set; }

        /// <summary>
        /// SHA256 hash of the resource.
        /// </summary>
        public string SHA256 { get; set; }

        [JsonProperty("response_code")]
        public RescanResponseCode ResponseCode { get; set; }
    }
    #endregion

    #region Class: ScanResult
    public class ScanResult
    {
        /// <summary>
        /// MD5 hash of the resource.
        /// </summary>
        public string MD5 { get; set; }

        /// <summary>
        /// A unique link to this particular scan result.
        /// </summary>
        public string Permalink { get; set; }

        /// <summary>
        /// Id of the resource.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// The unique scan id of the resource.
        /// </summary>
        [JsonProperty("scan_id")]
        public string ScanId { get; set; }

        /// <summary>
        /// SHA256 hash of the resource.
        /// </summary>
        public string SHA1 { get; set; }

        /// <summary>
        /// SHA256 hash of the resource.
        /// </summary>
        public string SHA256 { get; set; }

        [JsonProperty("response_code")]
        public ScanFileResponseCode ResponseCode { get; set; }

        /// <summary>
        /// Contains the message that corresponds to the response code.
        /// </summary>
        [JsonProperty("verbose_msg")]
        public string VerboseMsg { get; set; }
    }
    #endregion

    #region Class: URLReport
    public class URLReport
    {
        /// <summary>
        /// File scan id of the resource.
        /// </summary>
        [JsonProperty("filescan_id")]
        public string FileScanId { get; set; }

        /// <summary>
        /// A permanent link that points to this specific scan.
        /// </summary>
        public string Permalink { get; set; }

        /// <summary>
        /// How many engines flagged this resource.
        /// </summary>
        public int Positives { get; set; }

        /// <summary>
        /// Contains the id of the resource. Can be a SHA256, MD5 or other hash type.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// The date the resource was last scanned.
        /// </summary>
        [JsonProperty("scan_date")]
        public DateTime ScanDate { get; set; }

        /// <summary>
        /// Contains the scan id for this result.
        /// </summary>
        [JsonProperty("scan_id")]
        public string ScanId { get; set; }

        /// <summary>
        /// The scan results from each engine.
        /// </summary>
        public Dictionary<string, URLScanEngine> Scans { get; set; }

        /// <summary>
        /// How many engines scanned this resource.
        /// </summary>
        public int Total { get; set; }

        public string URL { get; set; }

        /// <summary>
        /// The response code. Use this to determine the status of the report.
        /// </summary>
        [JsonProperty("response_code")]
        public UrlReportResponseCode ResponseCode { get; set; }

        /// <summary>
        /// Contains the message that corresponds to the response code.
        /// </summary>
        [JsonProperty("verbose_msg")]
        public string VerboseMsg { get; set; }
    }
    #endregion

    #region Class: URLScanResult
    public class URLScanResult
    {
        public string Url { get; set; }

        [JsonProperty("scan_date")]
        public DateTime ScanDate { get; set; }

        /// <summary>
        /// A unique link to this particular scan result.
        /// </summary>
        public string Permalink { get; set; }

        /// <summary>
        /// The resource.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// The unique scan id of the resource.
        /// </summary>
        [JsonProperty("scan_id")]
        public string ScanId { get; set; }

        [JsonProperty("response_code")]
        public UrlScanResponseCode ResponseCode { get; set; }

        /// <summary>
        /// Contains the message that corresponds to the response code.
        /// </summary>
        [JsonProperty("verbose_msg")]
        public string VerboseMsg { get; set; }
    }
    #endregion

    #region Class: CustomURLEncodedContent
    /// <summary>
    /// I use this class instead of FormUrlEncodedContent due to a bug in .NET core regarding the length of values
    /// </summary>
    public class CustomURLEncodedContent : ByteArrayContent
    {
        public CustomURLEncodedContent(IEnumerable<KeyValuePair<string, string>> nameValueCollection)
            : base(GetContentByteArray(nameValueCollection))
        {
            Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
        }

        private static byte[] GetContentByteArray(IEnumerable<KeyValuePair<string, string>> nameValueCollection)
        {
            // Encode and concatenate data
            StringBuilder builder = new StringBuilder();
            foreach (KeyValuePair<string, string> pair in nameValueCollection)
            {
                if (builder.Length > 0)
                    builder.Append('&');

                builder.Append(Encode(pair.Key));
                builder.Append('=');
                builder.Append(Encode(pair.Value));
            }
            return Encoding.UTF8.GetBytes(builder.ToString());
        }

        private static string Encode(string data)
        {
            if (string.IsNullOrEmpty(data))
                return string.Empty;

            return WebUtility.UrlEncode(data);
        }
    }
    #endregion
}