using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataLabsLocalPackSerpElementItem  : BaseDataforseoLabsApiElementItem 
    {

        /// <summary>
        /// title of the result in SERP
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// description of the results element in SERP
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// domain in SERP
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// phone number
        /// </summary>
        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// sitelink URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// indicates whether the element is an ad
        /// </summary>
        [JsonProperty("is_paid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPaid { get; set; }

        /// <summary>
        /// the item’s rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

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
        /// <br/>estimated organic monthly traffic a featured URL delivers to the domain
        /// <br/>calculated as the product of CTR (click-through-rate) and search volume values of the returned keyword
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Etv { get; set; }

        /// <summary>
        /// estimated cost of converting organic search traffic into paid
        /// <br/>represents the estimated monthly cost of running ads for the returned keyword
        /// <br/>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("estimated_paid_traffic_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? EstimatedPaidTrafficCost { get; set; }
        [JsonProperty("clickstream_etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ClickstreamEtv { get; set; }

        /// <summary>
        /// changes in rankings
        /// <br/>ranking changes of the SERP element compared to the preceding month;
        /// <br/>Note: the changes are calculated even if the preceding month is not included in a POST request
        /// </summary>
        [JsonProperty("rank_changes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RankChanges RankChanges { get; set; }

        /// <summary>
        /// backlinks information for the ranked website
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