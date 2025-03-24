namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FeaturedSnippetDataforseoLabsSerpElementItem : BaseDataforseoLabsSerpElementItem
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// subdomain in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// title of the result in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// the title of the featured snippets source page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("featured_title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FeaturedTitle { get; set; }

        /// <summary>
        /// description of the results element in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// relevant URL in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// results table
        /// <br/>if there are none, equals null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Table Table { get; set; }

        /// <summary>
        /// primary domain name in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        /// <summary>
        /// relative URL in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relative_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RelativeUrl { get; set; }

        /// <summary>
        /// estimated traffic volume
        /// <br/>estimated organic monthly traffic to the domain;
        /// <br/>calculated as the product of CTR (click-through-rate) and search volume values of the returned keyword
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("etv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Etv { get; set; }

        /// <summary>
        /// estimated cost of converting organic search traffic into paid
        /// <br/>represents the estimated monthly cost of running ads (USD) for the returned keyword;
        /// <br/>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Bing Search
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimated_paid_traffic_cost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? EstimatedPaidTrafficCost { get; set; }

        /// <summary>
        /// changes in rankings
        /// <br/>contains information about the ranking changes of the SERP element since the previous_updated_time
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_changes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RankChanges RankChanges { get; set; }

        [Newtonsoft.Json.JsonProperty("backlinks_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BacklinksInfo BacklinksInfo { get; set; }

        [Newtonsoft.Json.JsonProperty("rank_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RankInfo RankInfo { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}