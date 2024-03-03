namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AmazonRankedSerpElement
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// contains data on the SERP element
        /// <br/>the list of supported SERP elements can be found below
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serp_item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BaseAmazonSerpElementItem SerpItem { get; set; }

        /// <summary>
        /// direct URL to Amazon results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// direct URL to Amazon results
        /// <br/>contains types of all search results (items) found in the returned SERP;
        /// <br/>possible item types:
        /// <br/>amazon_serp, amazon_paid, editorial_recommendations, top_rated_from_our_brands, related_searches
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serp_item_types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> SerpItemTypes { get; set; }

        /// <summary>
        /// total number of results in Amazon SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_results_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SeResultsCount { get; set; }

        /// <summary>
        /// date and time when SERP data was last updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_updated_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// previous to the most recent update of SERP data
        /// <br/>in the ISO 8601 format: “YYYY-MM-DDThh:mm:ss.sssssssZ”
        /// <br/>example:
        /// <br/>2020-09-12T00:07:43.0733218Z
        /// </summary>
        [Newtonsoft.Json.JsonProperty("previous_updated_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PreviousUpdatedTime { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}