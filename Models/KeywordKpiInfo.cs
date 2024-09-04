namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordKpiInfo
    {
        /// <summary>
        /// represents the position of the relevant ad in SERP
        /// <br/>can take the following values:
        /// <br/>FirstPage1: The first ad to appear on the right side of the first search results page
        /// <br/>FirstPage2: The second ad to appear on the right side of the first search results page
        /// <br/>FirstPage3: The third ad to appear on the right side of the first search results page
        /// <br/>FirstPage4: The fourth ad to appear on the right side of the first search results page
        /// <br/>FirstPage5: The fifth ad to appear on the right side of the first search results page
        /// <br/>FirstPage6: The sixth ad to appear on the right side of the first search results page
        /// <br/>FirstPage7: The seventh ad to appear on the right side of the first search results page
        /// <br/>FirstPage8: The eighth ad to appear on the right side of the first search results page
        /// <br/>FirstPage9: The ninth ad to appear on the right side of the first search results page
        /// <br/>FirstPage10: The tenth ad to appear on the right side of the first search results page
        /// <br/>MainLine1: The first ad to appear at the top of the search results page
        /// <br/>MainLine2: The second ad to appear at the top of the search results page
        /// <br/>MainLine3: The third ad to appear at the top of the search results page
        /// <br/>MainLine4: The fourth ad to appear at the top of the search results page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdPosition { get; set; }

        /// <summary>
        /// ad clicks
        /// <br/>the number of clicks that the keyword and match type generated during the last month
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clicks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Clicks { get; set; }

        /// <summary>
        /// ad impressions
        /// <br/>the number of impressions that the keyword and match type generated during the last month
        /// </summary>
        [Newtonsoft.Json.JsonProperty("impressions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Impressions { get; set; }

        /// <summary>
        /// average cost per click, USD
        /// <br/>calculated by dividing the cost of all clicks by the number of clicks
        /// </summary>
        [Newtonsoft.Json.JsonProperty("average_cpc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AverageCpc { get; set; }

        /// <summary>
        /// click-through rate as a percentage
        /// <br/>calculated by dividing the number of clicks by the number of impressions and multiplying the result by 100
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ctr { get; set; }

        /// <summary>
        /// total cost of an ad, USD
        /// <br/>the cost of using the specified keyword and match type during the last month
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_cost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalCost { get; set; }

        /// <summary>
        /// average bid of the keyword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("average_bid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AverageBid { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}