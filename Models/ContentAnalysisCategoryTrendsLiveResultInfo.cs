using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentAnalysisCategoryTrendsLiveResultInfo 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// date for which the data is provided
        /// </summary>
        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// total number of results in our database relevant to your request
        /// </summary>
        [JsonProperty("total_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// rank of all URLs citing the keyword
        /// <br/>normalized sum of ranks of all URLs citing the target keyword for the given date
        /// </summary>
        [JsonProperty("rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// top domains citing the target keyword
        /// <br/>contains objects with top domains citing the target category and citation count per each domain
        /// </summary>
        [JsonProperty("top_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TopDomainInfo> TopDomains { get; set; }

        /// <summary>
        /// sentiment connotations
        /// <br/>contains sentiments (emotional reactions) related to the target category citation and the number of citations per each sentiment
        /// <br/>possible connotations: 'anger', 'fear', 'happiness', 'love', 'sadness', 'share', 'neutral', 'fun'
        /// </summary>
        [JsonProperty("sentiment_connotations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> SentimentConnotations { get; set; }

        /// <summary>
        /// connotation types
        /// <br/>contains types of sentiments (sentiment polarity) related to the category citation and citation count per each sentiment type
        /// <br/>possible connotation types: 'positive', 'negative', 'neutral'
        /// </summary>
        [JsonProperty("connotation_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ConnotationTypes { get; set; }

        /// <summary>
        /// text categories
        /// <br/>contains objects with text categories and citation count in each text category
        /// <br/>to obtain a full list of available categories, refer to the Categories endpoint
        /// </summary>
        [JsonProperty("text_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ContentAnalysisCategoriesInfo> TextCategories { get; set; }

        /// <summary>
        /// page categories
        /// <br/>contains objects with page categories and citation count in each page category
        /// <br/>to obtain a full list of available categories, refer to the Categories endpoint
        /// </summary>
        [JsonProperty("page_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ContentAnalysisCategoriesInfo> PageCategories { get; set; }

        /// <summary>
        /// page types
        /// <br/>contains page types and citation count per each page type
        /// </summary>
        [JsonProperty("page_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> PageTypes { get; set; }

        /// <summary>
        /// countries
        /// <br/>contains countries and citation count in each country
        /// <br/>to obtain a full list of available countries, refer to the Locations endpoint
        /// </summary>
        [JsonProperty("countries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> Countries { get; set; }

        /// <summary>
        /// languages
        /// <br/>contains languages and citation count in each language
        /// <br/>to obtain a full list of available languages, refer to the Languages endpoint
        /// </summary>
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> Languages { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}