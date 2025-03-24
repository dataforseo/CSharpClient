namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("google_finance_asset_pair", typeof(GoogleFinanceAssetPairSerpElementItem))]
    [JsonInheritanceAttribute("google_finance_market_instrument", typeof(GoogleFinanceMarketInstrumentSerpElementItem))]
    [JsonInheritanceAttribute("google_finance_market_index", typeof(GoogleFinanceMarketIndexSerpElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseGoogleFinanceTickerSearchSerpElementItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

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

    }
}