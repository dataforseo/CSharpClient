namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ScriptResourceElementItem : BaseOnPageResourceItemInfo
    {
        /// <summary>
        /// resource properties
        /// <br/>the value depends on the resource_type
        /// <br/>note that if you do not indicate a url when setting a task, resource’s meta is returned based on the data from the page where our crawler first saw the resource;
        /// <br/>to obtain resource’s meta from a particular url, specify that URL when setting a task
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ResourceMetaInfo Meta { get; set; }

        /// <summary>
        /// status code of the page where a given resource is located
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
        /// resource URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// resource size
        /// <br/>indicates the size of a given resource measured in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// resource size after encoding
        /// <br/>indicates the size of the encoded resource measured in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encoded_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EncodedSize { get; set; }

        /// <summary>
        /// compressed resource size
        /// <br/>indicates the compressed size of a given resource in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_transfer_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalTransferSize { get; set; }

        /// <summary>
        /// date and time when a resource was fetched
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2021-02-17 13:54:15 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FetchTime { get; set; }

        /// <summary>
        /// resource fething time range
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_timing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FetchTiming FetchTiming { get; set; }

        /// <summary>
        /// instructions for caching
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cache_control", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CacheControl CacheControl { get; set; }

        /// <summary>
        /// resource check-ups
        /// <br/>contents of the array depend on the resource_type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, bool?> Checks { get; set; }

        /// <summary>
        /// resource errors and warnings
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OnPageResourceIssueInfo ResourceErrors { get; set; }

        /// <summary>
        /// type of encoding
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_encoding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// types of media used to display a resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MediaType { get; set; }

        /// <summary>
        /// indicates the expected type of resource
        /// <br/>for example, if "resource_type": "broken", accept_type will indicate the type of the broken resource
        /// <br/>possible values:
        /// <br/>any, none, image, sitemap, robots, script, stylesheet, redirect, html, text, other, font
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcceptType { get; set; }

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