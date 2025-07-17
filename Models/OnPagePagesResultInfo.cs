using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPagePagesResultInfo 
    {

        /// <summary>
        /// status of the crawling session
        /// <br/>possible values: in_progress, finished
        /// </summary>
        [JsonProperty("crawl_progress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlProgress { get; set; }

        /// <summary>
        /// details of the crawling session
        /// </summary>
        [JsonProperty("crawl_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CrawlStatusInfo CrawlStatus { get; set; }
        [JsonProperty("search_after_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchAfterToken { get; set; }
        [JsonProperty("current_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentOffset { get; set; }

        /// <summary>
        /// total number of relevant items in the database
        /// </summary>
        [JsonProperty("total_items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalItemsCount { get; set; }

        /// <summary>
        /// number of items in the results array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseOnPageResourceItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}