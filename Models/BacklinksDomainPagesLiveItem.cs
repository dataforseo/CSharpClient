namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksDomainPagesLiveItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// main website domain
        /// <br/>main website domain does not include subdomains
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        /// <summary>
        /// domain
        /// <br/>domain where the page was found
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// top-level domain
        /// <br/>top-level domain in the DNS root zone
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tld", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tld { get; set; }

        /// <summary>
        /// page URL
        /// <br/>relevant page URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Page { get; set; }

        /// <summary>
        /// Internet Protocol address
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// date and time of the first page visit
        /// <br/>date and time when our crawler visited this page for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2017-01-24 13:20:59 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_visited", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstVisited { get; set; }

        /// <summary>
        /// previous to the most recent date when our crawler visited the page
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2017-01-24 13:20:59 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prev_visited", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrevVisited { get; set; }

        /// <summary>
        /// most recent date and time when our crawler visited the page
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2017-01-24 13:20:59 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FetchTime { get; set; }

        /// <summary>
        /// HTTP status code of the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// location header
        /// <br/>indicates the URL to redirect a page to if exists
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// indicates the page size, in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// page size after encoding
        /// <br/>indicates the size of the encoded page, in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encoded_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EncodedSize { get; set; }

        /// <summary>
        /// type of encoding
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_encoding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// types of media used to display a page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MediaType { get; set; }

        /// <summary>
        /// server version
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// page meta data
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BacklinksPageMeta Meta { get; set; }

        /// <summary>
        /// contains backlink data for this page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PageSummary PageSummary { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}