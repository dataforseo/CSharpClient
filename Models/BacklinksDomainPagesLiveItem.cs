using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksDomainPagesLiveItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// main website domain
        /// <br/>main website domain does not include subdomains
        /// </summary>
        [JsonProperty("main_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        /// <summary>
        /// domain
        /// <br/>domain where the page was found
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// top-level domain
        /// <br/>top-level domain in the DNS root zone
        /// </summary>
        [JsonProperty("tld", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tld { get; set; }

        /// <summary>
        /// page URL
        /// <br/>relevant page URL
        /// </summary>
        [JsonProperty("page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Page { get; set; }

        /// <summary>
        /// Internet Protocol address
        /// </summary>
        [JsonProperty("ip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// date and time of the first page visit
        /// <br/>date and time when our crawler visited this page for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2017-01-24 13:20:59 +00:00
        /// </summary>
        [JsonProperty("first_visited", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstVisited { get; set; }

        /// <summary>
        /// previous to the most recent date when our crawler visited the page
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2017-01-24 13:20:59 +00:00
        /// </summary>
        [JsonProperty("prev_visited", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PrevVisited { get; set; }

        /// <summary>
        /// most recent date and time when our crawler visited the page
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2017-01-24 13:20:59 +00:00
        /// </summary>
        [JsonProperty("fetch_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FetchTime { get; set; }

        /// <summary>
        /// HTTP status code of the page
        /// </summary>
        [JsonProperty("status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// location header
        /// <br/>indicates the URL to redirect a page to if exists
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// indicates the page size, in bytes
        /// </summary>
        [JsonProperty("size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// page size after encoding
        /// <br/>indicates the size of the encoded page, in bytes
        /// </summary>
        [JsonProperty("encoded_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EncodedSize { get; set; }

        /// <summary>
        /// type of encoding
        /// </summary>
        [JsonProperty("content_encoding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// types of media used to display a page
        /// </summary>
        [JsonProperty("media_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MediaType { get; set; }

        /// <summary>
        /// server version
        /// </summary>
        [JsonProperty("server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// page meta data
        /// </summary>
        [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BacklinksPageMeta Meta { get; set; }

        /// <summary>
        /// contains backlink data for this page
        /// </summary>
        [JsonProperty("page_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PageSummary PageSummary { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}