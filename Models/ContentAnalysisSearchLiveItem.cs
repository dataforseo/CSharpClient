namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentAnalysisSearchLiveItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// URL where the citation was found
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// domain name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// main domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        /// <summary>
        /// rank of the url
        /// <br/>this value is based on backlink data for the given URL from DataForSEO Backlink Index;
        /// <br/>url_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? UrlRank { get; set; }

        /// <summary>
        /// backlink spam score of the url
        /// <br/>this value is based on backlink data for the given URL from DataForSEO Backlink Index;
        /// <br/>learn more about how the metric is calculated on this help center page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spam_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SpamScore { get; set; }

        /// <summary>
        /// rank of the domain
        /// <br/>this value is based on backlink data for the given domain from DataForSEO Backlink Index;
        /// <br/>domain_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DomainRank { get; set; }

        /// <summary>
        /// date and time when our crawler visited the page
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2017-01-24 13:20:59 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FetchTime { get; set; }

        /// <summary>
        /// country code of the domain registration
        /// <br/>to obtain a full list of available countries, refer to the Locations endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// main language of the domain
        /// <br/>to obtain a full list of available languages, refer to the Languages endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// citation prominence score
        /// <br/>this value is based on url_rank, domain_rank, keyword presence in title, main_title, url, snippet
        /// <br/>the higher the score, the more value the related citation has
        /// </summary>
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Score { get; set; }

        /// <summary>
        /// contains all relevant page categories
        /// <br/>product and service categories relevant for the page
        /// <br/>to obtain a full list of available categories, refer to the Categories endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> PageCategory { get; set; }

        /// <summary>
        /// page types
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> PageTypes { get; set; }

        /// <summary>
        /// ratings found on the page
        /// <br/>all ratings found on the page based on microdata
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ratings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RatingInfo> Ratings { get; set; }

        /// <summary>
        /// social media engagement metrics
        /// <br/>data on social media interactions associated with the content based on website embeds developed and supported by social media platforms
        /// </summary>
        [Newtonsoft.Json.JsonProperty("social_metrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SocialMetricsInfo> SocialMetrics { get; set; }

        /// <summary>
        /// contains data on citations from the given url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AnalysisContentInfo ContentInfo { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}