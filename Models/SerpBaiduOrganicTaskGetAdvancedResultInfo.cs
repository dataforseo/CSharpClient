using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpBaiduOrganicTaskGetAdvancedResultInfo 
    {

        /// <summary>
        /// keyword received in a POST array
        /// <br/>the keyword is returned with decoded %## (plus symbol ‘+’ will be decoded to a space character)
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
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Datetime { get; set; }

        /// <summary>
        /// autocorrection of the search engine
        /// <br/>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection
        /// </summary>
        [JsonProperty("spell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SpellInfo Spell { get; set; }

        /// <summary>
        /// search refinement chips
        /// <br/>equals null
        /// </summary>
        [JsonProperty("refinement_chips", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RefinementChipsInfo RefinementChips { get; set; }

        /// <summary>
        /// types of search results in SERP
        /// <br/>contains types of search results (items) found in SERP.
        /// <br/>possible item types:
        /// <br/>images, local_pack, map, organic, paid, related_searches, video, stocks_box, dictionary, shopping
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// total number of results in SERP
        /// </summary>
        [JsonProperty("se_results_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SeResultsCount { get; set; }

        /// <summary>
        /// total pages retrieved
        /// <br/>total number of retrieved SERPs in the result
        /// </summary>
        [JsonProperty("pages_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PagesCount { get; set; }

        /// <summary>
        /// the number of results returned in the items array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// additional items present in the element
        /// <br/>if there are none, equals null
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