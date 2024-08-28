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
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseBusinessDataSerpElementItem
    {

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}