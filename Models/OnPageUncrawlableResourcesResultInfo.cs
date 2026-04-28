using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageUncrawlableResourcesResultInfo 
    {

        /// <summary>
        /// status of the crawling sessionpossible values: in_progress, finished
        /// </summary>
        [JsonProperty("crawl_progress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlProgress { get; set; }

        /// <summary>
        /// details of the crawling session
        /// </summary>
        [JsonProperty("crawl_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CrawlStatusInfo CrawlStatus { get; set; }
        [JsonProperty("current_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentOffset { get; set; }

        /// <summary>
        /// total number of uncrawlable resources found total number of uncrawlable resources found during the crawl of the target domain
        /// </summary>
        [JsonProperty("total_items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalItemsCount { get; set; }

        /// <summary>
        /// number of uncrawlable resources in the items array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// array of uncrawlable resources
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<OnPageUncrawlableResourcesItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}