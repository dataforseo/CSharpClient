using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageHtmlResourceItem  : BaseOnPageResourceItem 
    {

        /// <summary>
        /// page properties
        /// <br/>the value depends on the resource_type
        /// </summary>
        [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PageMetaInfo Meta { get; set; }

        /// <summary>
        /// object of page load metrics
        /// </summary>
        [JsonProperty("page_timing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PageTiming PageTiming { get; set; }

        /// <summary>
        /// shows how page is optimized on a 100-point scale
        /// <br/>this field shows how page is optimized considering critical on-page issues and warnings detected;
        /// <br/>100 is the highest possible score that means the page does not have any critical on-page issues and important warnings;
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("onpage_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OnpageScore { get; set; }

        /// <summary>
        /// total DOM size of a page
        /// </summary>
        [JsonProperty("total_dom_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDomSize { get; set; }

        /// <summary>
        /// the result of executing a specified JS script
        /// <br/>note that you should specify a custom_js field when setting a task to receive this data and the field type and its value will totally depend on the script you specified;
        /// <br/>you can also filter the results by this value specifying filters in the following way:
        /// <br/>['custom_js_response.url', 'like', 'pixel']
        /// </summary>
        [JsonProperty("custom_js_response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object CustomJsResponse { get; set; }

        /// <summary>
        /// error when executing a custom js
        /// <br/>if the error occurred when executing the script you specified in the custom_js field, the error message would be displayed here
        /// </summary>
        [JsonProperty("custom_js_client_exception", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomJsClientException { get; set; }

        /// <summary>
        /// indicates whether a page contains broken resources
        /// </summary>
        [JsonProperty("broken_resources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? BrokenResources { get; set; }

        /// <summary>
        /// indicates whether a page contains broken links
        /// </summary>
        [JsonProperty("broken_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? BrokenLinks { get; set; }

        /// <summary>
        /// indicates whether a page has duplicate title tags
        /// </summary>
        [JsonProperty("duplicate_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DuplicateTitle { get; set; }

        /// <summary>
        /// indicates whether a page has a duplicate description
        /// </summary>
        [JsonProperty("duplicate_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DuplicateDescription { get; set; }

        /// <summary>
        /// indicates whether a page has duplicate content
        /// </summary>
        [JsonProperty("duplicate_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DuplicateContent { get; set; }

        /// <summary>
        /// number of clicks it takes to get to the page
        /// <br/>indicates the number of clicks from the homepage needed before landing at the target page
        /// </summary>
        [JsonProperty("click_depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClickDepth { get; set; }

        /// <summary>
        /// indicates whether a page is a single resource
        /// </summary>
        [JsonProperty("is_resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsResource { get; set; }

        /// <summary>
        /// page URL length in characters
        /// </summary>
        [JsonProperty("url_length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UrlLength { get; set; }

        /// <summary>
        /// relative URL length in characters
        /// </summary>
        [JsonProperty("relative_url_length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RelativeUrlLength { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}