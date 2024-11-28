namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppDataAppStoreSearchOrganicSerpElementItem : BaseAppDataSerpElementItem
    {
        /// <summary>
        /// id of the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// URL to the app page on App Store
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// URL to the app icon
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Icon { get; set; }

        /// <summary>
        /// the total number of reviews of the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reviews_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReviewsCount { get; set; }

        /// <summary>
        /// indicates whether the app is free
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_free", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsFree { get; set; }

        /// <summary>
        /// price of the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}