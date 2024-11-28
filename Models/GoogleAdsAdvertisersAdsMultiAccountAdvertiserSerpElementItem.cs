namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GoogleAdsAdvertisersAdsMultiAccountAdvertiserSerpElementItem : BaseGoogleAdsAdvertisersSerpElementItem
    {
        /// <summary>
        /// title of the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// advertiser location
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// ads count
        /// <br/>the approximate number of ads that are run by the advertiser across all available Google Ads platforms
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approx_ads_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ApproxAdsCount { get; set; }

        /// <summary>
        /// associated advertiser accounts
        /// <br/>contains objects with data on associated advertiser accounts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertisers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Advertiser> Advertisers { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}