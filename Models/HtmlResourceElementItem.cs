namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HtmlResourceElementItem : BaseOnPageResourceItemInfo
    {
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
        /// error when executing a custom js
        /// <br/>if the error occurred when executing the script you specified in the custom_js field, the error message would be displayed here
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_js_client_exception", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomJsClientException { get; set; }

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

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}