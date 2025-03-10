namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SerpGoogleFinanceExploreAdvancedItem
    {
        /// <summary>
        /// array of items
        /// <br/>this array can take the following names: most_active, gainers, losers
        /// </summary>
        [Newtonsoft.Json.JsonProperty("most_active", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<GoogleFinanceMarketTrendsElement> MostActive { get; set; }

        [Newtonsoft.Json.JsonProperty("gainers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<GoogleFinanceMarketTrendsElement> Gainers { get; set; }

        [Newtonsoft.Json.JsonProperty("losers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<GoogleFinanceMarketTrendsElement> Losers { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}