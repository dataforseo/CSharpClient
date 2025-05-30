using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("local_pack", typeof(LocalPackDataforseoLabsSerpElementItem))]
    [JsonInheritance("featured_snippet", typeof(FeaturedSnippetDataforseoLabsSerpElementItem))]
    [JsonInheritance("organic", typeof(OrganicDataforseoLabsSerpElementItem))]
    [JsonInheritance("answer_box", typeof(AnswerBoxDataforseoLabsSerpElementItem))]
    [JsonInheritance("carousel", typeof(CarouselDataforseoLabsSerpElementItem))]
    [JsonInheritance("multi_carousel", typeof(MultiCarouselDataforseoLabsSerpElementItem))]
    [JsonInheritance("google_flights", typeof(GoogleFlightsDataforseoLabsSerpElementItem))]
    [JsonInheritance("google_reviews", typeof(GoogleReviewsDataforseoLabsSerpElementItem))]
    [JsonInheritance("google_posts", typeof(GooglePostsDataforseoLabsSerpElementItem))]
    [JsonInheritance("images", typeof(ImagesDataforseoLabsSerpElementItem))]
    [JsonInheritance("jobs", typeof(JobsDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph_description_item", typeof(KnowledgeGraphDescriptionItemDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph_row_item", typeof(KnowledgeGraphRowItemDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph_images_item", typeof(KnowledgeGraphImagesItemDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph", typeof(KnowledgeGraphDataforseoLabsSerpElementItem))]
    [JsonInheritance("hotels_pack", typeof(HotelsPackDataforseoLabsSerpElementItem))]
    [JsonInheritance("map", typeof(MapDataforseoLabsSerpElementItem))]
    [JsonInheritance("paid", typeof(PaidDataforseoLabsSerpElementItem))]
    [JsonInheritance("people_also_ask", typeof(PeopleAlsoAskDataforseoLabsSerpElementItem))]
    [JsonInheritance("related_searches", typeof(RelatedSearchesDataforseoLabsSerpElementItem))]
    [JsonInheritance("people_also_search", typeof(PeopleAlsoSearchDataforseoLabsSerpElementItem))]
    [JsonInheritance("shopping", typeof(ShoppingDataforseoLabsSerpElementItem))]
    [JsonInheritance("top_stories", typeof(TopStoriesDataforseoLabsSerpElementItem))]
    [JsonInheritance("twitter", typeof(TwitterDataforseoLabsSerpElementItem))]
    [JsonInheritance("video", typeof(VideoDataforseoLabsSerpElementItem))]
    [JsonInheritance("events", typeof(EventsDataforseoLabsSerpElementItem))]
    [JsonInheritance("mention_carousel", typeof(MentionCarouselDataforseoLabsSerpElementItem))]
    [JsonInheritance("recipes", typeof(RecipesDataforseoLabsSerpElementItem))]
    [JsonInheritance("top_sights", typeof(TopSightsDataforseoLabsSerpElementItem))]
    [JsonInheritance("scholarly_articles", typeof(ScholarlyArticlesDataforseoLabsSerpElementItem))]
    [JsonInheritance("popular_products", typeof(PopularProductsDataforseoLabsSerpElementItem))]
    [JsonInheritance("podcasts", typeof(PodcastsDataforseoLabsSerpElementItem))]
    [JsonInheritance("questions_and_answers", typeof(QuestionsAndAnswersDataforseoLabsSerpElementItem))]
    [JsonInheritance("find_results_on", typeof(FindResultsOnDataforseoLabsSerpElementItem))]
    [JsonInheritance("stocks_box", typeof(StocksBoxDataforseoLabsSerpElementItem))]
    [JsonInheritance("commercial_units", typeof(CommercialUnitsDataforseoLabsSerpElementItem))]
    [JsonInheritance("local_services", typeof(LocalServicesDataforseoLabsSerpElementItem))]
    [JsonInheritance("google_hotels", typeof(GoogleHotelsDataforseoLabsSerpElementItem))]
    [JsonInheritance("math_solver", typeof(MathSolverDataforseoLabsSerpElementItem))]

    public class BaseDataforseoLabsSerpElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankAbsolute { get; set; }

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