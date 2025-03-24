namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GoogleFinanceMarketInstrumentSerpElementItem : BaseGoogleFinanceTickerSearchSerpElementItem
    {
        /// <summary>
        /// ticker of the market index
        /// <br/>example: DAX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticker", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ticker { get; set; }

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

        /// <summary>
        /// price currency
        /// <br/>example: USD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price_currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PriceCurrency { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}