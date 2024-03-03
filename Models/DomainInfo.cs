namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DomainInfo
    {
        /// <summary>
        /// domain name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// content management system
        /// <br/>content management system identified on a website
        /// <br/>the content of the generator meta tag
        /// <br/>the data is taken from the first random page that returns the 200 response code
        /// <br/>if our crawler was unable to identify the cms, the value would be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cms { get; set; }

        /// <summary>
        /// domain ip address
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// website server
        /// <br/>the version of the server detected on a website
        /// <br/>the content of the server header
        /// <br/>the information is taken from the first page which response code is 200
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// time when the crawling start
        /// <br/>date and time when the website was sent for crawling
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crawl_start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CrawlStart { get; set; }

        /// <summary>
        /// time when the crawling ended
        /// <br/>date and time when the crawling was finished
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00note: informative only if "crawl_progress" is "finished"
        /// <br/>if "crawl_progress" is in_progress, the value will be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crawl_end", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CrawlEnd { get; set; }

        /// <summary>
        /// crawl status and errors
        /// <br/>indicates the reason why a website was not crawledcan take the following values:
        /// <br/>no_errors – no crawling errors were detected;
        /// <br/>site_unreachable – our crawler could not reach a website and thus was not able to obtain a status code;
        /// <br/>invalid_page_status_code – status code of the first crawled page &gt;= 400;
        /// <br/>forbidden_meta_tag – the first crawled page contains the &lt;meta robots=”noindex”&gt; tag;
        /// <br/>forbidden_robots – robots.txt forbids crawling the page;
        /// <br/>forbidden_http_header – HTTP header of the page contains “X-Robots-Tag: noindex” ;
        /// <br/>too_many_redirects – the first crawled page has more than 10 redirects;
        /// <br/>unknown – the reason is unknown
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extended_crawl_status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExtendedCrawlStatus { get; set; }

        /// <summary>
        /// ssl certificate info
        /// <br/>information about the Secure Sockets Layer protocol detected on a website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssl_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SslInfo SslInfo { get; set; }

        /// <summary>
        /// website checks
        /// <br/>other on-page check-ups related to the website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, bool?> Checks { get; set; }

        /// <summary>
        /// total crawled pages
        /// <br/>the total number of crawled pages
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalPages { get; set; }

        /// <summary>
        /// status code returned by a non-existent page
        /// <br/>in most cases, it is recommended a server returns a 404 response code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_not_found_status_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageNotFoundStatusCode { get; set; }

        /// <summary>
        /// status code returned by a canonicalized page
        /// <br/>the checkup of the server behavior when our crawler tries to access the website via IP;
        /// <br/>in most cases, it is recommended that canonicalized pages respond with a 301 or 302 status code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("canonicalization_status_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CanonicalizationStatusCode { get; set; }

        /// <summary>
        /// status code returned by a directory
        /// <br/>the status code returned by a directory page on a target website
        /// <br/>in most cases, it is recommended that directories respond with a 403 or 401 status code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("directory_browsing_status_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DirectoryBrowsingStatusCode { get; set; }

        /// <summary>
        /// redirect status code
        /// <br/>the status code of the www to non-www redirect
        /// <br/>in most cases, it is recommended that redirect returns a 301 status code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("www_redirect_status_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? WwwRedirectStatusCode { get; set; }

        /// <summary>
        /// root domain name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}