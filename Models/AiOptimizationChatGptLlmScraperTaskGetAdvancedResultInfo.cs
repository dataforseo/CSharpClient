using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationChatGptLlmScraperTaskGetAdvancedResultInfo 
    {

        /// <summary>
        /// keyword received in a POST array
        /// <br/>the keyword is returned with decoded %## (plus symbol ‘+’ will be decoded to a space character)
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

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
        /// indicates the model version
        /// </summary>
        [JsonProperty("model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// direct URL to search engine results
        /// <br/>you can use it to make sure that we provided exact results
        /// </summary>
        [JsonProperty("check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// date and time when the result was received
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Datetime { get; set; }

        /// <summary>
        /// content of the element in markdown format
        /// <br/>content of the result formatted in the markdown markup language
        /// </summary>
        [JsonProperty("markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Markdown { get; set; }

        /// <summary>
        /// array of search results
        /// <br/>all web search outputs the model retrieved when looking up information, including duplicates and unused entries
        /// </summary>
        [JsonProperty("search_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ChatgptSearchResult> SearchResults { get; set; }

        /// <summary>
        /// array of sources
        /// <br/>the sources the model actually cited or relied on in its final answer
        /// </summary>
        [JsonProperty("sources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ChatGptSource> Sources { get; set; }

        /// <summary>
        /// array of fan-out queries
        /// <br/>contains related search queries derived from the main query to provide a more comprehensive response
        /// </summary>
        [JsonProperty("fan_out_queries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> FanOutQueries { get; set; }

        /// <summary>
        /// total number of results
        /// </summary>
        [JsonProperty("se_results_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SeResultsCount { get; set; }

        /// <summary>
        /// types of search results
        /// <br/>contains types of search results (items) found.
        /// <br/>possible item types:
        /// <br/>chat_gpt_text, chat_gpt_table, chat_gpt_navigation_list, chat_gpt_images, chat_gpt_local_businesses, chat_gpt_products
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// the number of results returned in the items array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// items present in the element
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseChatGptLlmScraperElementItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}