using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLlmMentionsSearchLiveItem 
    {

        /// <summary>
        /// platform received in a POST array
        /// </summary>
        [JsonProperty("platform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// location code in a POST array
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// relevant question
        /// </summary>
        [JsonProperty("question", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Question { get; set; }

        /// <summary>
        /// relevant answer in markdown format
        /// <br/>content of the result formatted in the markdown markup language
        /// </summary>
        [JsonProperty("answer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Answer { get; set; }

        /// <summary>
        /// array of sources
        /// <br/>the sources the model cited or relied on in its final answer
        /// </summary>
        [JsonProperty("sources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Sources> Sources { get; set; }

        /// <summary>
        /// array of search results
        /// <br/>all web search outputs the model retrieved when looking up information, including duplicates and unused entries
        /// </summary>
        [JsonProperty("search_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SearchResults> SearchResults { get; set; }

        /// <summary>
        /// current AI search volume rate of a keyword
        /// <br/>learn more about this metric here
        /// </summary>
        [JsonProperty("ai_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? AiSearchVolume { get; set; }
        [JsonProperty("monthly_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<MonthlySearchesInfo> MonthlySearches { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}