namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("maps_search", typeof(MapsSearchBusinessDataSerpElementItem))]
    [JsonInheritanceAttribute("google_business_info", typeof(GoogleBusinessInfoBusinessDataSerpElementItem))]
    [JsonInheritanceAttribute("google_business_post", typeof(GoogleBusinessPostBusinessDataSerpElementItem))]
    [JsonInheritanceAttribute("google_reviews_search", typeof(GoogleReviewsSearchBusinessDataSerpElementItem))]
    [JsonInheritanceAttribute("trustpilot_search_organic", typeof(TrustpilotSearchOrganicBusinessDataSerpElementItem))]
    [JsonInheritanceAttribute("trustpilot_review_search", typeof(TrustpilotReviewSearchBusinessDataSerpElementItem))]
    [JsonInheritanceAttribute("tripadvisor_search_organic", typeof(TripadvisorSearchOrganicBusinessDataSerpElementItem))]
    [JsonInheritanceAttribute("tripadvisor_review_search", typeof(TripadvisorReviewSearchBusinessDataSerpElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseBusinessDataSerpElementItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from the rank_group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank among all the elements
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

    }
}