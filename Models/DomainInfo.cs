using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DomainInfo 
    {

        /// <summary>
        /// domain name
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// content management system
        /// <br/>content management system identified on a website
        /// <br/>the content of the generator meta tag
        /// <br/>the data is taken from the first random page that returns the 200 response code
        /// <br/>if our crawler was unable to identify the cms, the value would be null
        /// </summary>
        [JsonProperty("cms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Cms { get; set; }

        /// <summary>
        /// domain ip address
        /// </summary>
        [JsonProperty("ip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// website server
        /// <br/>the version of the server detected on a website
        /// <br/>the content of the server header
        /// <br/>the information is taken from the first page which response code is 200
        /// </summary>
        [JsonProperty("server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// time when the crawling start
        /// <br/>date and time when the website was sent for crawling
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("crawl_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlStart { get; set; }

        /// <summary>
        /// time when the crawling ended
        /// <br/>date and time when the crawling was finished
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// <br/>Note: informative only if 'crawl_progress' is 'finished'
        /// <br/>if 'crawl_progress' is in_progress, the value will be null
        /// </summary>
        [JsonProperty("crawl_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlEnd { get; set; }

        /// <summary>
        /// crawl status and errors
        /// <br/>indicates the reason why a website was not crawled;
        /// <br/>can take the following values:
        /// <br/>no_errors – no crawling errors were detected;
        /// <br/>site_unreachable – our crawler could not reach a website and thus was not able to obtain a status code;
        /// <br/>invalid_page_status_code – status code of the first crawled page &gt;= 400;
        /// <br/>forbidden_meta_tag – the first crawled page contains the &lt;meta robots=”noindex”&gt; tag;
        /// <br/>forbidden_robots – robots.txt forbids crawling the page;
        /// <br/>forbidden_http_header – HTTP header of the page contains “X-Robots-Tag: noindex” ;
        /// <br/>too_many_redirects – the first crawled page has more than 10 redirects;
        /// <br/>unknown – the reason is unknown
        /// </summary>
        [JsonProperty("extended_crawl_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendedCrawlStatus { get; set; }

        /// <summary>
        /// ssl certificate info
        /// <br/>information about the Secure Sockets Layer protocol detected on a website
        /// </summary>
        [JsonProperty("ssl_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SslInfo SslInfo { get; set; }

        /// <summary>
        /// website checks
        /// <br/>other on-page check-ups related to the website
        /// </summary>
        [JsonProperty("checks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, bool?> Checks { get; set; }

        /// <summary>
        /// total crawled pages
        /// <br/>the total number of crawled pages
        /// </summary>
        [JsonProperty("total_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalPages { get; set; }

        /// <summary>
        /// status code returned by a non-existent page
        /// <br/>in most cases, it is recommended a server returns a 404 response code
        /// </summary>
        [JsonProperty("page_not_found_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PageNotFoundStatusCode { get; set; }

        /// <summary>
        /// status code returned by a canonicalized page
        /// <br/>the checkup of the server behavior when our crawler tries to access the website via IP;
        /// <br/>in most cases, it is recommended that canonicalized pages respond with a 301 or 302 status code
        /// </summary>
        [JsonProperty("canonicalization_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CanonicalizationStatusCode { get; set; }

        /// <summary>
        /// status code returned by a directory
        /// <br/>the status code returned by a directory page on a target website
        /// <br/>in most cases, it is recommended that directories respond with a 403 or 401 status code
        /// </summary>
        [JsonProperty("directory_browsing_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DirectoryBrowsingStatusCode { get; set; }

        /// <summary>
        /// redirect status code
        /// <br/>the status code of the www to non-www redirect
        /// <br/>in most cases, it is recommended that redirect returns a 301 status code
        /// </summary>
        [JsonProperty("www_redirect_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WwwRedirectStatusCode { get; set; }

        /// <summary>
        /// root domain name
        /// </summary>
        [JsonProperty("main_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}