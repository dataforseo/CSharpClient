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
        /// name of the AI model from which the data was retrievedNote: for the google platform type, the value is always google_ai_overview
        /// </summary>
        [JsonProperty("model_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

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
        /// relevant answer in markdown formatcontent of the result formatted in the markdown markup language
        /// </summary>
        [JsonProperty("answer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Answer { get; set; }

        /// <summary>
        /// array of sourcesthe sources the model cited or relied on in its final answer
        /// </summary>
        [JsonProperty("sources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Sources> Sources { get; set; }

        /// <summary>
        /// array of search resultsall web search outputs the model retrieved when looking up information, including duplicates and unused entries
        /// </summary>
        [JsonProperty("search_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SearchResults> SearchResults { get; set; }

        /// <summary>
        /// current AI search volume rate of a keywordlearn more about this metric here
        /// </summary>
        [JsonProperty("ai_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? AiSearchVolume { get; set; }

        /// <summary>
        /// monthly AI search volume ratesarray of objects with AI search volume rates in a certain month of a year
        /// </summary>
        [JsonProperty("monthly_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<MonthlySearchesInfo> MonthlySearches { get; set; }

        /// <summary>
        /// date and time when the response data was first recordedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2025-10-21 06:25:30 +00:00
        /// </summary>
        [JsonProperty("first_response_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstResponseAt { get; set; }

        /// <summary>
        /// date and time when the response data was last updatedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2025-10-21 06:25:30 +00:00
        /// </summary>
        [JsonProperty("last_response_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastResponseAt { get; set; }

        /// <summary>
        /// array of brand entitiescontains information on brands mentioned in the response
        /// </summary>
        [JsonProperty("brand_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BrandEntities> BrandEntities { get; set; }

        /// <summary>
        /// array of fan-out queriescontains related search queries derived from the main query to provide a more comprehensive response
        /// </summary>
        [JsonProperty("fan_out_queries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> FanOutQueries { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}