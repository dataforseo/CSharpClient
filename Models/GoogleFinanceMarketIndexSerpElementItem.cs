namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GoogleFinanceMarketIndexSerpElementItem : BaseGoogleFinanceTickerSearchSerpElementItem
    {
        /// <summary>
        /// ticker of the market index
        /// <br/>example: DAX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticker", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ticker { get; set; }

        /// <summary>
        /// market identifier
        /// <br/>example: INDEXDB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("market_identifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MarketIdentifier { get; set; }

        /// <summary>
        /// value of the market index
        /// <br/>numerical value of the index at a given timestamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("index_value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? IndexValue { get; set; }

        /// <summary>
        /// change in value of the market index
        /// <br/>change in the index_value at a given timestamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("index_value_delta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? IndexValueDelta { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}