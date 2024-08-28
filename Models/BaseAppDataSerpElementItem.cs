namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("google_play_search_organic", typeof(AppDataGooglePlaySearchOrganicSerpElementItem))]
    [JsonInheritanceAttribute("app_store_search_organic", typeof(AppDataAppStoreSearchOrganicSerpElementItem))]
    [JsonInheritanceAttribute("google_play_info_organic", typeof(AppDataGooglePlayInfoOrganicSerpElementItem))]
    [JsonInheritanceAttribute("google_play_reviews_search", typeof(AppDataGooglePlayReviewsSearchSerpElementItem))]
    [JsonInheritanceAttribute("app_store_info_organic", typeof(AppDataAppStoreInfoOrganicSerpElementItem))]
    [JsonInheritanceAttribute("app_store_reviews_search", typeof(AppDataAppStoreReviewsSearchSerpElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseAppDataSerpElementItem
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