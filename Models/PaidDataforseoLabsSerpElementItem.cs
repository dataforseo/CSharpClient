using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PaidDataforseoLabsSerpElementItem  : BaseDataforseoLabsSerpElementItem 
    {

        /// <summary>
        /// title of the result in SERP
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// domain where a link points
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// description of the results element in SERP
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// breadcrumb of the Ad element in SERP
        /// </summary>
        [JsonProperty("breadcrumb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Breadcrumb { get; set; }

        /// <summary>
        /// relevant URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// words highlighted in bold within the results description
        /// </summary>
        [JsonProperty("highlighted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Highlighted { get; set; }

        /// <summary>
        /// additional information about the result
        /// </summary>
        [JsonProperty("extra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Extra { get; set; }

        /// <summary>
        /// extended description
        /// <br/>if there is none, equals null
        /// </summary>
        [JsonProperty("description_rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> DescriptionRows { get; set; }

        /// <summary>
        /// links featured in the math_solver element
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AdLinkElement> Links { get; set; }

        /// <summary>
        /// primary domain name in SERP
        /// </summary>
        [JsonProperty("main_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        /// <summary>
        /// URL in SERP that does not specify the HTTPs protocol and domain name
        /// </summary>
        [JsonProperty("relative_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RelativeUrl { get; set; }

        /// <summary>
        /// estimated traffic volume
        /// <br/>estimated organic monthly traffic to the domain
        /// <br/>calculated as the product of CTR (click-through-rate) and search volume values of the returned keyword
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Etv { get; set; }

        /// <summary>
        /// estimated traffic volume based on impressions
        /// <br/>estimated organic monthly traffic to the domain
        /// <br/>calculated as the product of CTR (click-through-rate) and impressions values of the returned keyword
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("impressions_etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ImpressionsEtv { get; set; }

        /// <summary>
        /// estimated cost of converting organic search traffic into paid
        /// <br/>represents the estimated monthly cost of running ads for the returned keyword
        /// <br/>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("estimated_paid_traffic_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? EstimatedPaidTrafficCost { get; set; }

        /// <summary>
        /// changes in rankings
        /// <br/>ranking changes of the SERP element compared to the preceding month;
        /// <br/>Note: the changes are calculated even if the preceding month is not included in a POST request
        /// </summary>
        [JsonProperty("rank_changes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RankChanges RankChanges { get; set; }

        /// <summary>
        /// estimated traffic volume based on clickstream data
        /// <br/>calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for
        /// <br/>to retrieve results for this field, the parameter include_clickstream_data must be set to true
        /// <br/>learn more about how the metric is calculated in this help center article https://dataforseo.com/help-center/whats-clickstream-estimated-traffic-volume-and-how-is-it-calculated
        /// </summary>
        [JsonProperty("clickstream_etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClickstreamEtv { get; set; }

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// backlinks information for the target website
        /// </summary>
        [JsonProperty("backlinks_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BacklinksInfo BacklinksInfo { get; set; }

        /// <summary>
        /// page and domain rank information
        /// </summary>
        [JsonProperty("rank_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RankInfo RankInfo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}