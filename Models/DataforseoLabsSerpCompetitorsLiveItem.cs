namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsSerpCompetitorsLiveItem
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// domain name of the detected SERP competitor
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// the average position of the domain for the specified keywords
        /// <br/>the arithmetic mean of values in the keywords_positions array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avg_position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? AvgPosition { get; set; }

        /// <summary>
        /// the median position of the domain for the specified keywords
        /// <br/>the median of the values in the keywords_positions array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("median_position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MedianPosition { get; set; }

        /// <summary>
        /// the margin between the greatest possible and actual keyword positions
        /// <br/>represents the relative visibility rate of the domain in SERP for the specified keywords
        /// <br/>calculated as sum(100-keywords_positions)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rating { get; set; }

        /// <summary>
        /// estimated traffic volume
        /// <br/>represents the estimated monthly traffic that specified keywords are driving to the website
        /// <br/>calculated as the sum of the products of the specified keywords’ search volume values and CTR (click-through-rate) rates at certain positions in SERP
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("etv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Etv { get; set; }

        /// <summary>
        /// the number of specified keywords the domain has positions for in SERPs
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keywords_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? KeywordsCount { get; set; }

        /// <summary>
        /// SERP visibility rate
        /// <br/>represents the website visibility rate based on the SERP positions of the specified keywords
        /// <br/>Keywords with positions in the range from 1 to 10 are assigned the visibility index from 1 to 0.1, respectively
        /// <br/>Keywords with positions in the range from 11 to 20 have the fixed visibility index of 0.05
        /// <br/>keywords with positions from 20 to 100 have the visibility index equal to 0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visibility", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Visibility { get; set; }

        /// <summary>
        /// the number of SERP elements relevant to the domain
        /// <br/>represents the number of search results in SERP relevant to the domain for the specified keywords
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relevant_serp_items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RelevantSerpItems { get; set; }

        /// <summary>
        /// keyword positions
        /// <br/>SERP positions the related domain holds in SERP for the specified keywords
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keywords_positions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.ICollection<int?>> KeywordsPositions { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}