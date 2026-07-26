using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpGoogleOrganicTaskGetRegularResultInfo 
    {

        /// <summary>
        /// keyword received in a POST array
        /// <br/>keyword is returned with decoded %## (plus symbol '+' will be decoded to a space character)
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// search engine domain in a POST array
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

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
        /// direct URL to search engine results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [JsonProperty("check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// date and time when the result was received
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2019-11-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Datetime { get; set; }

        /// <summary>
        /// autocorrection of the search engine
        /// <br/>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection;
        /// <br/>if there is none, the value is <c>null</c>
        /// </summary>
        [JsonProperty("spell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SpellInfo Spell { get; set; }

        /// <summary>
        /// search refinement chips
        /// <br/>if there are none, the value is <c>null</c>
        /// </summary>
        [JsonProperty("refinement_chips", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RefinementChipsInfo RefinementChips { get; set; }

        /// <summary>
        /// types of search results found in SERP
        /// <br/>contains types of all search results (<c>items</c>) found in the returned SERP
        /// <br/>possible item types:
        /// <br/><c>answer_box</c>, <c>app</c>, <c>carousel</c>, <c>multi_carousel</c>, <c>featured_snippet</c>, <c>google_flights</c>, <c>google_reviews</c>, <c>third_party_reviews</c>,  <c>images</c>, <c>jobs</c>, <c>knowledge_graph</c>, <c>local_pack</c>, <c>hotels_pack</c>, <c>map</c>, <c>organic</c>, <c>paid</c>, <c>people_also_ask</c>, <c>related_searches</c>, <c>people_also_search</c>, <c>shopping</c>, <c>top_stories</c>, <c>twitter</c>, <c>video</c>, <c>events</c>, <c>recipes</c>, <c>top_sights</c>, <c>scholarly_articles</c>, <c>popular_products</c>, <c>questions_and_answers</c>, <c>find_results_on</c>, <c>stocks_box</c>, <c>commercial_units</c>, <c>local_services</c>, <c>google_hotels</c>, <c>math_solver</c>, <c>currency_box</c>, <c>product_considerations</c>, <c>short_videos</c>, <c>refine_products</c>, <c>perspectives</c>, <c>discussions_and_forums</c>, <c>compare_sites</c>, <c>ai_overview</c>
        /// <br/>note that this array contains all types of search results found in the returned SERP;
        /// <br/>however, this endpoint provides data for <c>featured_snippet</c>, <c>organic</c> and <c>paid</c> types only;
        /// <br/>to get all items (including SERP features and rich snippets) found in the returned SERP, please refer to the <see href="https://docs.dataforseo.com/v3/serp/google/organic/live/advanced/?php">Google Organiс Advanced SERP</see> endpoint
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// total number of results in SERP
        /// </summary>
        [JsonProperty("se_results_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SeResultsCount { get; set; }

        /// <summary>
        /// total search results pages retrieved
        /// <br/>total number of retrieved SERPs in the result
        /// </summary>
        [JsonProperty("pages_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PagesCount { get; set; }

        /// <summary>
        /// the number of results returned in the <c>items</c> array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// items in SERP
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseSerpApiElementItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}