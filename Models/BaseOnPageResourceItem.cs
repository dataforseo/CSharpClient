using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritance("html", typeof(OnPageHtmlResourceItem))]
    [JsonInheritance("broken", typeof(OnPageBrokenResourceItem))]
    [JsonInheritance("redirect", typeof(OnPageRedirectResourceItem))]
    [JsonInheritance("script", typeof(OnPageScriptResourceItem))]
    [JsonInheritance("image", typeof(OnPageImageResourceItem))]
    [JsonInheritance("stylesheet", typeof(OnPageStylesheetResourceItem))]

    public class BaseOnPageResourceItem 
    {

        /// <summary>
        /// type of the returned resource = ‘html’
        /// </summary>
        [JsonProperty("resource_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// status code of the page
        /// </summary>
        [JsonProperty("status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// location header
        /// <br/>indicates the URL to redirect a page to
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// page URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// resource errors and warnings
        /// </summary>
        [JsonProperty("resource_errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public OnPageResourceIssueInfo ResourceErrors { get; set; }

        /// <summary>
        /// resource size
        /// <br/>indicates the size of a given page measured in bytes
        /// </summary>
        [JsonProperty("size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// page size after encoding
        /// <br/>indicates the size of the encoded page measured in bytes
        /// </summary>
        [JsonProperty("encoded_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EncodedSize { get; set; }

        /// <summary>
        /// compressed page size
        /// <br/>indicates the compressed size of a given page
        /// </summary>
        [JsonProperty("total_transfer_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalTransferSize { get; set; }

        /// <summary>
        /// date and time when a resource was fetched
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("fetch_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FetchTime { get; set; }

        /// <summary>
        /// instructions for caching
        /// </summary>
        [JsonProperty("cache_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CacheControl CacheControl { get; set; }

        /// <summary>
        /// website checks
        /// <br/>on-page check-ups related to the page
        /// </summary>
        [JsonProperty("checks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, bool?> Checks { get; set; }

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
        /// contains data on changes related to the resource
        /// <br/>if there is no data, the value will be null
        /// </summary>
        [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LastModified LastModified { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}