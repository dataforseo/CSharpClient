using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageDuplicateTagsResultInfo 
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
        public CrawlStatus CrawlStatus { get; set; }

        /// <summary>
        /// total number of pages with duplicate tags
        /// <br/>displays the total number of pages with duplicate tags of the target website
        /// </summary>
        [JsonProperty("total_pages_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalPagesCount { get; set; }

        /// <summary>
        /// number of pages with duplicate tags in the response
        /// <br/>displays the number of pages with duplicate tags returned in the response
        /// </summary>
        [JsonProperty("pages_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PagesCount { get; set; }

        /// <summary>
        /// number of items in the results array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ItemsCount { get; set; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<OnPageDuplicateTagsItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}