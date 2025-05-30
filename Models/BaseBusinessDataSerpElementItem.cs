using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("maps_search", typeof(MapsSearchBusinessDataSerpElementItem))]
    [JsonInheritance("google_business_info", typeof(GoogleBusinessInfoBusinessDataSerpElementItem))]
    [JsonInheritance("google_business_post", typeof(GoogleBusinessPostBusinessDataSerpElementItem))]
    [JsonInheritance("google_reviews_search", typeof(GoogleReviewsSearchBusinessDataSerpElementItem))]
    [JsonInheritance("trustpilot_search_organic", typeof(TrustpilotSearchOrganicBusinessDataSerpElementItem))]
    [JsonInheritance("trustpilot_review_search", typeof(TrustpilotReviewSearchBusinessDataSerpElementItem))]
    [JsonInheritance("tripadvisor_search_organic", typeof(TripadvisorSearchOrganicBusinessDataSerpElementItem))]
    [JsonInheritance("tripadvisor_review_search", typeof(TripadvisorReviewSearchBusinessDataSerpElementItem))]

    public class BaseBusinessDataSerpElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from the rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankGroup { get; set; }

        /// <summary>
        /// absolute rank among all the elements
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankAbsolute { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}