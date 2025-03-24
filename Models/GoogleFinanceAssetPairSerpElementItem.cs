namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GoogleFinanceAssetPairSerpElementItem : BaseGoogleFinanceTickerSearchSerpElementItem
    {
        /// <summary>
        /// identifier of the base asset in a pair
        /// <br/>example: EUR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_symbol", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BaseSymbol { get; set; }

        /// <summary>
        /// identifier of the quote asset in a pair
        /// <br/>example: USD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quote_symbol", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QuoteSymbol { get; set; }

        /// <summary>
        /// full name of the base asset in a pair
        /// <br/>example: Euro
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_display_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BaseDisplayName { get; set; }

        /// <summary>
        /// full name of the base asset in a pair
        /// <br/>example: Euro
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quote_display_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QuoteDisplayName { get; set; }

        /// <summary>
        /// value of the base asset compared to the quote asset
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Price { get; set; }

        /// <summary>
        /// change in price
        /// <br/>change in price at a given timestamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price_delta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? PriceDelta { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}