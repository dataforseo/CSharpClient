namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("paid", typeof(PaidSerpElementItem))]
    [JsonInheritanceAttribute("organic", typeof(OrganicSerpElementItem))]
    [JsonInheritanceAttribute("featured_snippet", typeof(FeaturedSnippetSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_carousel_item", typeof(KnowledgeGraphCarouselItemSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_description_item", typeof(KnowledgeGraphDescriptionItemSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_images_item", typeof(KnowledgeGraphImagesItemSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_list_item", typeof(KnowledgeGraphListItemSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_row_item", typeof(KnowledgeGraphRowItemSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_expanded_item", typeof(KnowledgeGraphExpandedItemSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_part_item", typeof(KnowledgeGraphPartItemSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_shopping_item", typeof(KnowledgeGraphShoppingItemSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_hotels_booking_item", typeof(KnowledgeGraphHotelsBookingItemSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_ai_overview_item", typeof(KnowledgeGraphAiOverviewItemSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph", typeof(KnowledgeGraphSerpElementItem))]
    [JsonInheritanceAttribute("top_stories", typeof(TopStoriesSerpElementItem))]
    [JsonInheritanceAttribute("people_also_ask", typeof(PeopleAlsoAskSerpElementItem))]
    [JsonInheritanceAttribute("people_also_search", typeof(PeopleAlsoSearchSerpElementItem))]
    [JsonInheritanceAttribute("images", typeof(ImagesSerpElementItem))]
    [JsonInheritanceAttribute("twitter", typeof(TwitterSerpElementItem))]
    [JsonInheritanceAttribute("google_reviews", typeof(GoogleReviewsSerpElementItem))]
    [JsonInheritanceAttribute("jobs", typeof(JobsSerpElementItem))]
    [JsonInheritanceAttribute("map", typeof(MapSerpElementItem))]
    [JsonInheritanceAttribute("app", typeof(AppSerpElementItem))]
    [JsonInheritanceAttribute("local_pack", typeof(LocalPackSerpElementItem))]
    [JsonInheritanceAttribute("carousel", typeof(CarouselSerpElementItem))]
    [JsonInheritanceAttribute("video", typeof(VideoSerpElementItem))]
    [JsonInheritanceAttribute("answer_box", typeof(AnswerBoxSerpElementItem))]
    [JsonInheritanceAttribute("shopping", typeof(ShoppingSerpElementItem))]
    [JsonInheritanceAttribute("google_flights", typeof(GoogleFlightsSerpElementItem))]
    [JsonInheritanceAttribute("mention_carousel", typeof(MentionCarouselSerpElementItem))]
    [JsonInheritanceAttribute("events", typeof(EventsSerpElementItem))]
    [JsonInheritanceAttribute("related_searches", typeof(RelatedSearchesSerpElementItem))]
    [JsonInheritanceAttribute("multi_carousel", typeof(MultiCarouselSerpElementItem))]
    [JsonInheritanceAttribute("recipes", typeof(RecipesSerpElementItem))]
    [JsonInheritanceAttribute("top_sights", typeof(TopSightsSerpElementItem))]
    [JsonInheritanceAttribute("scholarly_articles", typeof(ScholarlyArticlesSerpElementItem))]
    [JsonInheritanceAttribute("popular_products", typeof(PopularProductsSerpElementItem))]
    [JsonInheritanceAttribute("podcasts", typeof(PodcastsSerpElementItem))]
    [JsonInheritanceAttribute("stocks_box", typeof(StocksBoxSerpElementItem))]
    [JsonInheritanceAttribute("find_results_on", typeof(FindResultsOnSerpElementItem))]
    [JsonInheritanceAttribute("questions_and_answers", typeof(QuestionsAndAnswersSerpElementItem))]
    [JsonInheritanceAttribute("hotels_pack", typeof(HotelsPackSerpElementItem))]
    [JsonInheritanceAttribute("visual_stories", typeof(VisualStoriesSerpElementItem))]
    [JsonInheritanceAttribute("commercial_units", typeof(CommercialUnitsSerpElementItem))]
    [JsonInheritanceAttribute("local_services", typeof(LocalServicesSerpElementItem))]
    [JsonInheritanceAttribute("google_hotels", typeof(GoogleHotelsSerpElementItem))]
    [JsonInheritanceAttribute("math_solver", typeof(MathSolverSerpElementItem))]
    [JsonInheritanceAttribute("currency_box", typeof(CurrencyBoxSerpElementItem))]
    [JsonInheritanceAttribute("google_posts", typeof(GooglePostsSerpElementItem))]
    [JsonInheritanceAttribute("product_considerations", typeof(ProductConsiderationsSerpElementItem))]
    [JsonInheritanceAttribute("found_on_web", typeof(FoundOnWebSerpElementItem))]
    [JsonInheritanceAttribute("short_videos", typeof(ShortVideosSerpElementItem))]
    [JsonInheritanceAttribute("refine_products", typeof(RefineProductsSerpElementItem))]
    [JsonInheritanceAttribute("explore_brands", typeof(ExploreBrandsSerpElementItem))]
    [JsonInheritanceAttribute("perspectives", typeof(PerspectivesSerpElementItem))]
    [JsonInheritanceAttribute("discussions_and_forums", typeof(DiscussionsAndForumsSerpElementItem))]
    [JsonInheritanceAttribute("compare_sites", typeof(CompareSitesSerpElementItem))]
    [JsonInheritanceAttribute("courses", typeof(CoursesSerpElementItem))]
    [JsonInheritanceAttribute("ai_overview", typeof(AiOverviewSerpElementItem))]
    [JsonInheritanceAttribute("third_party_reviews", typeof(ThirdPartyReviewsSerpElementItem))]
    [JsonInheritanceAttribute("event_item", typeof(EventItemSerpElementItem))]
    [JsonInheritanceAttribute("dictionary", typeof(DictionarySerpElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseSerpElementItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

    }
}