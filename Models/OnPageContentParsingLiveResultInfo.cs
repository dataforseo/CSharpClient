using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageContentParsingLiveResultInfo 
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

        /// <summary>
        /// number of items in the results array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ContentParsingElement> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}