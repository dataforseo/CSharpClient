namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CrawlStatusInfo
    {
        /// <summary>
        /// maximum number of pages to crawl
        /// <br/> indicates the max_crawl_pages limit you specified when setting a task
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_crawl_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? MaxCrawlPages { get; set; }

        /// <summary>
        /// number of pages that are currently in the crawling queue
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pages_in_queue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? PagesInQueue { get; set; }

        /// <summary>
        /// number of crawled pages
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pages_crawled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? PagesCrawled { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}