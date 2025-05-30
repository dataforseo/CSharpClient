using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentAnalysisCategoryTrendsLiveResultInfo
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// date for which the data is provided
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// total number of results in our database relevant to your request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalCount { get; set; }

        /// <summary>
        /// rank of all URLs citing the keyword
        /// <br/>normalized sum of ranks of all URLs citing the target keyword for the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Rank { get; set; }

        /// <summary>
        /// top domains citing the target keyword
        /// <br/>contains objects with top domains citing the target category and citation count per each domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TopDomainCountInfo> TopDomains { get; set; }

        /// <summary>
        /// sentiment connotations
        /// <br/>contains sentiments (emotional reactions) related to the target category citation and the number of citations per each sentiment
        /// <br/>possible connotations: "anger", "fear", "happiness", "love", "sadness", "share", "neutral", "fun"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sentiment_connotations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> SentimentConnotations { get; set; }

        /// <summary>
        /// connotation types
        /// <br/>contains types of sentiments (sentiment polarity) related to the category citation and citation count per each sentiment type
        /// <br/>possible connotation types: "positive", "negative", "neutral"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connotation_types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ConnotationTypes { get; set; }

        /// <summary>
        /// text categories
        /// <br/>contains objects with text categories and citation count in each text category
        /// <br/>to obtain a full list of available categories, refer to the Categories endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text_categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContentAnalysisCategoriesInfo> TextCategories { get; set; }

        /// <summary>
        /// page categories
        /// <br/>contains objects with page categories and citation count in each page category
        /// <br/>to obtain a full list of available categories, refer to the Categories endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContentAnalysisCategoriesInfo> PageCategories { get; set; }

        /// <summary>
        /// page types
        /// <br/>contains page types and citation count per each page type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> PageTypes { get; set; }

        /// <summary>
        /// countries
        /// <br/>contains countries and citation count in each country
        /// <br/>to obtain a full list of available countries, refer to the Locations endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("countries", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> Countries { get; set; }

        /// <summary>
        /// languages
        /// <br/>contains languages and citation count in each language
        /// <br/>to obtain a full list of available languages, refer to the Languages endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("languages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> Languages { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}