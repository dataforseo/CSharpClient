using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class CrawlStatusInfo 
    {

        /// <summary>
        /// maximum number of pages to crawl
        /// <br/> indicates the max_crawl_pages limit you specified when setting a task
        /// </summary>
        [JsonProperty("max_crawl_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxCrawlPages { get; set; }

        /// <summary>
        /// number of pages that are currently in the crawling queue
        /// </summary>
        [JsonProperty("pages_in_queue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PagesInQueue { get; set; }

        /// <summary>
        /// number of crawled pages
        /// </summary>
        [JsonProperty("pages_crawled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PagesCrawled { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}