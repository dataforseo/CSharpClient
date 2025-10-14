using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("featured_snippet", typeof(DataLabsFeaturedSnippetSerpElementItem))]
    [JsonInheritance("paid", typeof(DataLabsPaidSerpElementItem))]
    [JsonInheritance("organic", typeof(DataLabsOrganicSerpElementItem))]
    [JsonInheritance("local_pack", typeof(DataLabsLocalPackSerpElementItem))]
    [JsonInheritance("answer_box", typeof(DataLabsAnswerBoxSerpElementItem))]
    [JsonInheritance("carousel", typeof(DataLabsCarouselSerpElementItem))]
    [JsonInheritance("multi_carousel", typeof(DataLabsMultiCarouselSerpElementItem))]
    [JsonInheritance("google_flights", typeof(DataLabsGoogleFlightsSerpElementItem))]
    [JsonInheritance("google_reviews", typeof(DataLabsGoogleReviewsSerpElementItem))]
    [JsonInheritance("google_posts", typeof(DataLabsGooglePostsSerpElementItem))]
    [JsonInheritance("images", typeof(DataLabsImagesSerpElementItem))]
    [JsonInheritance("jobs", typeof(DataLabsJobsSerpElementItem))]
    [JsonInheritance("knowledge_graph", typeof(DataLabsKnowledgeGraphSerpElementItem))]
    [JsonInheritance("hotels_pack", typeof(DataLabsHotelsPackSerpElementItem))]
    [JsonInheritance("map", typeof(DataLabsMapSerpElementItem))]
    [JsonInheritance("people_also_ask", typeof(DataLabsPeopleAlsoAskSerpElementItem))]
    [JsonInheritance("related_searches", typeof(DataLabsRelatedSearchesSerpElementItem))]
    [JsonInheritance("people_also_search", typeof(DataLabsPeopleAlsoSearchSerpElementItem))]
    [JsonInheritance("shopping", typeof(DataLabsShoppingSerpElementItem))]
    [JsonInheritance("top_stories", typeof(DataLabsTopStoriesSerpElementItem))]
    [JsonInheritance("twitter", typeof(DataLabsTwitterSerpElementItem))]
    [JsonInheritance("video", typeof(DataLabsVideoSerpElementItem))]
    [JsonInheritance("events", typeof(DataLabsEventsSerpElementItem))]
    [JsonInheritance("mention_carousel", typeof(DataLabsMentionCarouselSerpElementItem))]
    [JsonInheritance("recipes", typeof(DataLabsRecipesSerpElementItem))]
    [JsonInheritance("top_sights", typeof(DataLabsTopSightsSerpElementItem))]
    [JsonInheritance("scholarly_articles", typeof(DataLabsScholarlyArticlesSerpElementItem))]
    [JsonInheritance("popular_products", typeof(DataLabsPopularProductsSerpElementItem))]
    [JsonInheritance("podcasts", typeof(DataLabsPodcastsSerpElementItem))]
    [JsonInheritance("questions_and_answers", typeof(DataLabsQuestionsAndAnswersSerpElementItem))]
    [JsonInheritance("find_results_on", typeof(DataLabsFindResultsOnSerpElementItem))]
    [JsonInheritance("stocks_box", typeof(DataLabsStocksBoxSerpElementItem))]
    [JsonInheritance("commercial_units", typeof(DataLabsCommercialUnitsSerpElementItem))]
    [JsonInheritance("local_services", typeof(DataLabsLocalServicesSerpElementItem))]
    [JsonInheritance("google_hotels", typeof(DataLabsGoogleHotelsSerpElementItem))]
    [JsonInheritance("math_solver", typeof(DataLabsMathSolverSerpElementItem))]

    public class BaseDataforseoLabsApiElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the XPath of the element
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}