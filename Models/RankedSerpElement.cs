using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class RankedSerpElement 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// contains data on the SERP element
        /// <br/>the list of supported SERP elements can be found below
        /// </summary>
        [JsonProperty("serp_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BaseDataforseoLabsSerpElementItem SerpItem { get; set; }

        /// <summary>
        /// direct URL to search engine results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [JsonProperty("check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// types of search results in SERP
        /// <br/>contains types of search results (items) found in SERP
        /// <br/>possible item types:
        /// <br/>answer_box, app, carousel, multi_carousel, featured_snippet, google_flights, google_reviews, images, jobs, knowledge_graph, local_pack, map, organic, paid, people_also_ask, related_searches, people_also_search, shopping, top_stories, twitter, video, events, mention_carousel, recipes, top_sights, scholarly_articles, popular_products, podcasts, questions_and_answers, find_results_on, stocks_box;
        /// <br/>note that the actual results will be returned only for organic, paid, featured_snippet, and local_pack elements
        /// </summary>
        [JsonProperty("serp_item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> SerpItemTypes { get; set; }

        /// <summary>
        /// number of search results for the returned keyword
        /// </summary>
        [JsonProperty("se_results_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SeResultsCount { get; set; }

        /// <summary>
        /// difficulty of ranking in the first top-10 organic results for a keyword
        /// <br/>indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100;
        /// <br/>calculated by analysing, among other parameters, link profiles of the first 10 pages in SERP;
        /// <br/>learn more about the metric in this help center guide
        /// </summary>
        [JsonProperty("keyword_difficulty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? KeywordDifficulty { get; set; }

        /// <summary>
        /// lost ranked elements
        /// <br/>indicates how many ranked elements of this domain were previously presented in SERPs, but weren’t found during the last check
        /// </summary>
        [JsonProperty("is_lost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLost { get; set; }

        /// <summary>
        /// date and time when keyword data was updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// previous to the most recent date and time when SERP data was updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-10-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("previous_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousUpdatedTime { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}