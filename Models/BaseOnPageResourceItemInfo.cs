namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("html", typeof(HtmlResourceElementItem))]
    [JsonInheritanceAttribute("stylesheet", typeof(StylesheetResourceElementItem))]
    [JsonInheritanceAttribute("script", typeof(ScriptResourceElementItem))]
    [JsonInheritanceAttribute("image", typeof(ImageResourceElementItem))]
    [JsonInheritanceAttribute("broken", typeof(BrokenResourceElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseOnPageResourceItemInfo
    {
        /// <summary>
        /// type of the returned resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// status code of the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// location header
        /// <br/>indicates the URL to redirect a page to
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// page URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// resource errors and warnings
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OnPageResourceIssueInfo ResourceErrors { get; set; }

        /// <summary>
        /// resource size
        /// <br/>indicates the size of a given page measured in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// page size after encoding
        /// <br/>indicates the size of the encoded page measured in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encoded_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EncodedSize { get; set; }

        /// <summary>
        /// compressed page size
        /// <br/>indicates the compressed size of a given page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_transfer_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalTransferSize { get; set; }

        /// <summary>
        /// date and time when a resource was fetched
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FetchTime { get; set; }

        /// <summary>
        /// instructions for caching
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cache_control", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CacheControl CacheControl { get; set; }

        /// <summary>
        /// website checks
        /// <br/>on-page check-ups related to the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, bool?> Checks { get; set; }

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
        /// contains data on changes related to the resource
        /// <br/>if there is no data, the value will be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_modified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LastModified LastModified { get; set; }

    }
}