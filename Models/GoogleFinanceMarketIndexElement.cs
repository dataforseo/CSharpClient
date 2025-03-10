namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GoogleFinanceMarketIndexElement
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

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

        /// <summary>
        /// identifier of the element
        /// <br/>full identifier of the element that consists from ticker and market_identifier
        /// <br/>example: PX1:INDEXDB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// name of the market index as displayed on Google Finance
        /// <br/>example: CAC 40
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayed_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DisplayedName { get; set; }

        /// <summary>
        /// URL to the page of the market index on Google Finance
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// location of the market index
        /// <br/>example: Europe/Paris
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// growth trend of the market index
        /// <br/>possible values: up, down, stable
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trend", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Trend { get; set; }

        /// <summary>
        /// date and time of the value readout
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2025-02-10 09:40:00 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// percentage of change in value of the market index
        /// </summary>
        [Newtonsoft.Json.JsonProperty("percentage_delta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? PercentageDelta { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}