namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppDataAppleAppListingsSearchLiveItem
    {
        /// <summary>
        /// ID of the returned app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// search engine domain in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// location code in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// direct URL to search engine results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// date and time when SERP data was last updated
        /// <br/>in the ISO 8601 format: “YYYY-MM-DDThh:mm:ss.sssssssZ”
        /// <br/>example:
        /// <br/>2023-05-23 10:16:19 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_update", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeUpdate { get; set; }

        /// <summary>
        /// detailed information about the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppDataAppStoreInfoOrganicSerpElementItem Item { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}