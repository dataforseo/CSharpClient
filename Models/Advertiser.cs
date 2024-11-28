namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Advertiser
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// unique identifier of the advertiser account
        /// <br/>can be used to obtain data on advertising campaigns from the Google Ads Search endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdvertiserId { get; set; }

        /// <summary>
        /// location of the advertiser account
        /// <br/>country code associated with the advertiser account
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// verified advertiser account
        /// <br/>equals true if advertiser account is verified by Google Ads
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        /// <summary>
        /// ads count
        /// <br/>the approximate number of ads that are run by the advertiser account across all available Google Ads platforms
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approx_ads_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ApproxAdsCount { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}