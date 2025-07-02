using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("organic", typeof(OrganicDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph_description_item", typeof(KnowledgeGraphDescriptionItemDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph_carousel_item", typeof(KnowledgeGraphCarouselItemDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph_row_item", typeof(KnowledgeGraphRowItemDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph", typeof(KnowledgeGraphDataforseoLabsSerpElementItem))]
    [JsonInheritance("people_also_ask", typeof(PeopleAlsoAskDataforseoLabsSerpElementItem))]
    [JsonInheritance("video", typeof(VideoDataforseoLabsSerpElementItem))]
    [JsonInheritance("related_searches", typeof(RelatedSearchesDataforseoLabsSerpElementItem))]
    [JsonInheritance("images", typeof(ImagesDataforseoLabsSerpElementItem))]
    [JsonInheritance("people_also_search", typeof(PeopleAlsoSearchDataforseoLabsSerpElementItem))]
    [JsonInheritance("carousel", typeof(CarouselDataforseoLabsSerpElementItem))]
    [JsonInheritance("multi_carousel", typeof(MultiCarouselDataforseoLabsSerpElementItem))]
    [JsonInheritance("top_stories", typeof(TopStoriesDataforseoLabsSerpElementItem))]
    [JsonInheritance("answer_box", typeof(AnswerBoxDataforseoLabsSerpElementItem))]
    [JsonInheritance("math_solver", typeof(MathSolverDataforseoLabsSerpElementItem))]
    [JsonInheritance("map", typeof(MapDataforseoLabsSerpElementItem))]
    [JsonInheritance("featured_snippet", typeof(FeaturedSnippetDataforseoLabsSerpElementItem))]
    [JsonInheritance("local_pack", typeof(LocalPackDataforseoLabsSerpElementItem))]
    [JsonInheritance("hotels_pack", typeof(HotelsPackDataforseoLabsSerpElementItem))]
    [JsonInheritance("twitter", typeof(TwitterDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph_images_item", typeof(KnowledgeGraphImagesItemDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph_list_item", typeof(KnowledgeGraphListItemDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph_part_item", typeof(KnowledgeGraphPartItemDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph_expanded_item", typeof(KnowledgeGraphExpandedItemDataforseoLabsSerpElementItem))]
    [JsonInheritance("knowledge_graph_shopping_item", typeof(KnowledgeGraphShoppingItemDataforseoLabsSerpElementItem))]
    [JsonInheritance("paid", typeof(PaidDataforseoLabsSerpElementItem))]
    [JsonInheritance("google_reviews", typeof(GoogleReviewsDataforseoLabsSerpElementItem))]
    [JsonInheritance("google_posts", typeof(GooglePostsDataforseoLabsSerpElementItem))]
    [JsonInheritance("google_flights", typeof(GoogleFlightsDataforseoLabsSerpElementItem))]
    [JsonInheritance("shopping", typeof(ShoppingDataforseoLabsSerpElementItem))]
    [JsonInheritance("jobs", typeof(JobsDataforseoLabsSerpElementItem))]
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
    [JsonInheritance("visual_stories", typeof(VisualStoriesDataforseoLabsSerpElementItem))]
    [JsonInheritance("commercial_units", typeof(CommercialUnitsDataforseoLabsSerpElementItem))]
    [JsonInheritance("local_services", typeof(LocalServicesDataforseoLabsSerpElementItem))]
    [JsonInheritance("google_hotels", typeof(GoogleHotelsDataforseoLabsSerpElementItem))]

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