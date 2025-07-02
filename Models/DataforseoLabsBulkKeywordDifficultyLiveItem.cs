using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsBulkKeywordDifficultyLiveItem 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// keyword in a POST array
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// difficulty of ranking in the first top-10 organic results for a keyword
        /// <br/>indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100;
        /// <br/>calculated by analysing, among other parameters, link profiles of the first 10 pages in SERP;
        /// <br/>learn more about the metric in this help center guide
        /// </summary>
        [JsonProperty("keyword_difficulty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KeywordDifficulty { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}