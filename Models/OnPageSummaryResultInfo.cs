using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageSummaryResultInfo 
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
        /// crawler ip address
        /// <br/>displays the IP address used by the crawler to initiate the current crawling session
        /// <br/>you can find the full list of IPs used by our crawler in the Overview section
        /// </summary>
        [JsonProperty("crawl_gateway_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlGatewayAddress { get; set; }

        /// <summary>
        /// reason why the crawling stopped
        /// <br/>information about the reason why the crawling process stopped;
        /// <br/>possible values:
        /// <br/>limit_exceeded – the limit set in the max_crawl_pages was exceeded;
        /// <br/>empty_queue – all URLs in the queue were crawled;
        /// <br/>force_stopped – the crawling process was halted using the On Page API Force Stop function;
        /// <br/>unexpected_exception – an internal error was encountered while crawling the target, contact support for more info
        /// </summary>
        [JsonProperty("crawl_stop_reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlStopReason { get; set; }

        /// <summary>
        /// domain-wide info
        /// <br/>on-page information about the target domain and crawling process
        /// </summary>
        [JsonProperty("domain_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DomainInfo DomainInfo { get; set; }

        /// <summary>
        /// page-specific info
        /// <br/>metrics information on the target website pages
        /// </summary>
        [JsonProperty("page_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PageMetrics PageMetrics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}