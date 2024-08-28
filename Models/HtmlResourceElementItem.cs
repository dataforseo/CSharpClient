namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HtmlResourceElementItem : BaseOnPageResourceItemInfo
    {
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
        /// page properties
        /// <br/>the value depends on the resource_type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PageMetaInfo Meta { get; set; }

        /// <summary>
        /// object of page load metrics
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_timing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PageTiming PageTiming { get; set; }

        /// <summary>
        /// shows how page is optimized on a 100-point scale
        /// <br/>this field shows how page is optimized considering critical on-page issues and warnings detected;
        /// <br/>100 is the highest possible score that means the page does not have any critical on-page issues and important warnings;
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("onpage_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? OnpageScore { get; set; }

        /// <summary>
        /// total DOM size of a page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_dom_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalDomSize { get; set; }

        /// <summary>
        /// the result of executing a specified JS script
        /// <br/>note that you should specify a custom_js field when setting a task to receive this data and the field type and its value will totally depend on the script you specified;you can also filter the results by this value specifying filters in the following way:
        /// <br/>["custom_js_response.url", "like", "pixel"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_js_response", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object CustomJsResponse { get; set; }

        /// <summary>
        /// resource errors and warnings
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OnPageResourceIssueInfo ResourceErrors { get; set; }

        /// <summary>
        /// indicates whether a page contains broken resources
        /// </summary>
        [Newtonsoft.Json.JsonProperty("broken_resources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? BrokenResources { get; set; }

        /// <summary>
        /// indicates whether a page contains broken links
        /// </summary>
        [Newtonsoft.Json.JsonProperty("broken_links", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? BrokenLinks { get; set; }

        /// <summary>
        /// indicates whether a page has duplicate title tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplicate_title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DuplicateTitle { get; set; }

        /// <summary>
        /// indicates whether a page has a duplicate description
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplicate_description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DuplicateDescription { get; set; }

        /// <summary>
        /// indicates whether a page has duplicate content
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplicate_content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DuplicateContent { get; set; }

        /// <summary>
        /// number of clicks it takes to get to the page
        /// <br/>indicates the number of clicks from the homepage needed before landing at the target page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("click_depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ClickDepth { get; set; }

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
        /// indicates whether a page is a single resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_resource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsResource { get; set; }

        /// <summary>
        /// page URL length in characters
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_length", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? UrlLength { get; set; }

        /// <summary>
        /// relative URL length in characters
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relative_url_length", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RelativeUrlLength { get; set; }

        /// <summary>
        /// contains data on changes related to the resource
        /// <br/>if there is no data, the value will be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_modified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LastModified LastModified { get; set; }

    }
}