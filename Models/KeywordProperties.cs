using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordProperties 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// main keyword in a group
        /// <br/>contains the main keyword in a group determined by the synonym clustering algorithm
        /// <br/>if the value is null, our database does not contain any keywords the corresponding algorithm could identify as synonymous with keyword
        /// </summary>
        [JsonProperty("core_keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CoreKeyword { get; set; }

        /// <summary>
        /// the algorithm used to identify synonyms
        /// <br/>possible values:
        /// <br/>keyword_metrics – indicates the algorithm based on keyword_info parameters
        /// <br/>text_processing – indicates the text-based algorithm
        /// <br/>if the value is null, our database does not contain any keywords the corresponding algorithm could identify as synonymous with keyword
        /// </summary>
        [JsonProperty("synonym_clustering_algorithm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SynonymClusteringAlgorithm { get; set; }

        /// <summary>
        /// difficulty of ranking in the first top-10 organic results for a keyword
        /// <br/>indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100;
        /// <br/>calculated by analysing, among other parameters, link profiles of the first 10 pages in SERP;
        /// <br/>learn more about the metric in this help center guide
        /// </summary>
        [JsonProperty("keyword_difficulty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KeywordDifficulty { get; set; }

        /// <summary>
        /// detected language of the keyword
        /// <br/>indicates the language of the keyword as identified by our system
        /// </summary>
        [JsonProperty("detected_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DetectedLanguage { get; set; }

        /// <summary>
        /// detected language of the keyword is different from the set language
        /// <br/>if true, the language set in the request does not match the language determined by our system for a given keyword
        /// </summary>
        [JsonProperty("is_another_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAnotherLanguage { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}