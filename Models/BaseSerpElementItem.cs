using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("paid", typeof(PaidSerpElementItem))]
    [JsonInheritance("organic", typeof(OrganicSerpElementItem))]
    [JsonInheritance("featured_snippet", typeof(FeaturedSnippetSerpElementItem))]
    [JsonInheritance("knowledge_graph_carousel_item", typeof(KnowledgeGraphCarouselItemSerpElementItem))]
    [JsonInheritance("knowledge_graph_description_item", typeof(KnowledgeGraphDescriptionItemSerpElementItem))]
    [JsonInheritance("knowledge_graph_images_item", typeof(KnowledgeGraphImagesItemSerpElementItem))]
    [JsonInheritance("knowledge_graph_list_item", typeof(KnowledgeGraphListItemSerpElementItem))]
    [JsonInheritance("knowledge_graph_row_item", typeof(KnowledgeGraphRowItemSerpElementItem))]
    [JsonInheritance("knowledge_graph_expanded_item", typeof(KnowledgeGraphExpandedItemSerpElementItem))]
    [JsonInheritance("knowledge_graph_part_item", typeof(KnowledgeGraphPartItemSerpElementItem))]
    [JsonInheritance("knowledge_graph_shopping_item", typeof(KnowledgeGraphShoppingItemSerpElementItem))]
    [JsonInheritance("knowledge_graph_hotels_booking_item", typeof(KnowledgeGraphHotelsBookingItemSerpElementItem))]
    [JsonInheritance("knowledge_graph_ai_overview_item", typeof(KnowledgeGraphAiOverviewItemSerpElementItem))]
    [JsonInheritance("knowledge_graph", typeof(KnowledgeGraphSerpElementItem))]
    [JsonInheritance("top_stories", typeof(TopStoriesSerpElementItem))]
    [JsonInheritance("people_also_ask", typeof(PeopleAlsoAskSerpElementItem))]
    [JsonInheritance("people_also_search", typeof(PeopleAlsoSearchSerpElementItem))]
    [JsonInheritance("images", typeof(ImagesSerpElementItem))]
    [JsonInheritance("twitter", typeof(TwitterSerpElementItem))]
    [JsonInheritance("google_reviews", typeof(GoogleReviewsSerpElementItem))]
    [JsonInheritance("jobs", typeof(JobsSerpElementItem))]
    [JsonInheritance("map", typeof(MapSerpElementItem))]
    [JsonInheritance("app", typeof(AppSerpElementItem))]
    [JsonInheritance("local_pack", typeof(LocalPackSerpElementItem))]
    [JsonInheritance("carousel", typeof(CarouselSerpElementItem))]
    [JsonInheritance("video", typeof(VideoSerpElementItem))]
    [JsonInheritance("answer_box", typeof(AnswerBoxSerpElementItem))]
    [JsonInheritance("shopping", typeof(ShoppingSerpElementItem))]
    [JsonInheritance("google_flights", typeof(GoogleFlightsSerpElementItem))]
    [JsonInheritance("mention_carousel", typeof(MentionCarouselSerpElementItem))]
    [JsonInheritance("events", typeof(EventsSerpElementItem))]
    [JsonInheritance("related_searches", typeof(RelatedSearchesSerpElementItem))]
    [JsonInheritance("multi_carousel", typeof(MultiCarouselSerpElementItem))]
    [JsonInheritance("recipes", typeof(RecipesSerpElementItem))]
    [JsonInheritance("top_sights", typeof(TopSightsSerpElementItem))]
    [JsonInheritance("scholarly_articles", typeof(ScholarlyArticlesSerpElementItem))]
    [JsonInheritance("popular_products", typeof(PopularProductsSerpElementItem))]
    [JsonInheritance("podcasts", typeof(PodcastsSerpElementItem))]
    [JsonInheritance("stocks_box", typeof(StocksBoxSerpElementItem))]
    [JsonInheritance("find_results_on", typeof(FindResultsOnSerpElementItem))]
    [JsonInheritance("questions_and_answers", typeof(QuestionsAndAnswersSerpElementItem))]
    [JsonInheritance("hotels_pack", typeof(HotelsPackSerpElementItem))]
    [JsonInheritance("visual_stories", typeof(VisualStoriesSerpElementItem))]
    [JsonInheritance("commercial_units", typeof(CommercialUnitsSerpElementItem))]
    [JsonInheritance("local_services", typeof(LocalServicesSerpElementItem))]
    [JsonInheritance("google_hotels", typeof(GoogleHotelsSerpElementItem))]
    [JsonInheritance("math_solver", typeof(MathSolverSerpElementItem))]
    [JsonInheritance("currency_box", typeof(CurrencyBoxSerpElementItem))]
    [JsonInheritance("google_posts", typeof(GooglePostsSerpElementItem))]
    [JsonInheritance("product_considerations", typeof(ProductConsiderationsSerpElementItem))]
    [JsonInheritance("found_on_web", typeof(FoundOnWebSerpElementItem))]
    [JsonInheritance("short_videos", typeof(ShortVideosSerpElementItem))]
    [JsonInheritance("refine_products", typeof(RefineProductsSerpElementItem))]
    [JsonInheritance("explore_brands", typeof(ExploreBrandsSerpElementItem))]
    [JsonInheritance("perspectives", typeof(PerspectivesSerpElementItem))]
    [JsonInheritance("discussions_and_forums", typeof(DiscussionsAndForumsSerpElementItem))]
    [JsonInheritance("compare_sites", typeof(CompareSitesSerpElementItem))]
    [JsonInheritance("courses", typeof(CoursesSerpElementItem))]
    [JsonInheritance("ai_overview", typeof(AiOverviewSerpElementItem))]
    [JsonInheritance("third_party_reviews", typeof(ThirdPartyReviewsSerpElementItem))]
    [JsonInheritance("event_item", typeof(EventItemSerpElementItem))]
    [JsonInheritance("dictionary", typeof(DictionarySerpElementItem))]

    public class BaseSerpElementItem 
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