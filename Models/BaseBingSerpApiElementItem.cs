using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("organic", typeof(BingOrganicSerpElementItem))]
    [JsonInheritance("paid", typeof(BingPaidSerpElementItem))]
    [JsonInheritance("featured_snippet", typeof(BingFeaturedSnippetSerpElementItem))]
    [JsonInheritance("related_searches", typeof(BingRelatedSearchesSerpElementItem))]
    [JsonInheritance("ai_overview", typeof(BingAiOverviewSerpElementItem))]
    [JsonInheritance("images", typeof(BingImagesSerpElementItem))]
    [JsonInheritance("video", typeof(BingVideoSerpElementItem))]
    [JsonInheritance("shopping", typeof(BingShoppingSerpElementItem))]
    [JsonInheritance("answer_box", typeof(BingAnswerBoxSerpElementItem))]
    [JsonInheritance("local_pack", typeof(BingLocalPackSerpElementItem))]
    [JsonInheritance("questions_and_answers", typeof(BingQuestionsAndAnswersSerpElementItem))]
    [JsonInheritance("hotels_pack", typeof(BingHotelsPackSerpElementItem))]
    [JsonInheritance("jobs", typeof(BingJobsSerpElementItem))]
    [JsonInheritance("top_stories", typeof(BingTopStoriesSerpElementItem))]
    [JsonInheritance("carousel", typeof(BingCarouselSerpElementItem))]
    [JsonInheritance("map", typeof(BingMapSerpElementItem))]
    [JsonInheritance("events", typeof(BingEventsSerpElementItem))]
    [JsonInheritance("recipes", typeof(BingRecipesSerpElementItem))]
    [JsonInheritance("people_also_ask", typeof(BingPeopleAlsoAskSerpElementItem))]
    [JsonInheritance("people_also_search", typeof(BingPeopleAlsoSearchSerpElementItem))]

    public class BaseBingSerpApiElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
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
        /// search results page number
        /// <br/>indicates the number of the SERP page on which the element is located
        /// </summary>
        [JsonProperty("page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

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

        /// <summary>
        /// rectangle parameters
        /// <br/>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP
        /// <br/>equals null if calculate_rectangles in the POST request is not set to true
        /// </summary>
        [JsonProperty("rectangle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AiModeRectangleInfo Rectangle { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}