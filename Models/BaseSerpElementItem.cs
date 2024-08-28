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
    [JsonInheritanceAttribute("maps_search", typeof(MapsSearchSerpElementItem))]
    [JsonInheritanceAttribute("maps_paid_item", typeof(MapsPaidItemSerpElementItem))]
    [JsonInheritanceAttribute("news_search", typeof(NewsSearchSerpElementItem))]
    [JsonInheritanceAttribute("event_item", typeof(EventItemSerpElementItem))]
    [JsonInheritanceAttribute("images_search", typeof(ImagesSearchSerpElementItem))]
    [JsonInheritanceAttribute("google_jobs_item", typeof(GoogleJobsItemSerpElementItem))]
    [JsonInheritanceAttribute("autocomplete", typeof(AutocompleteSerpElementItem))]
    [JsonInheritanceAttribute("dataset", typeof(DatasetSerpElementItem))]
    [JsonInheritanceAttribute("youtube_video_info", typeof(YoutubeVideoInfoSerpElementItem))]
    [JsonInheritanceAttribute("youtube_subtitles", typeof(YoutubeSubtitlesSerpElementItem))]
    [JsonInheritanceAttribute("youtube_comment", typeof(YoutubeCommentSerpElementItem))]
    [JsonInheritanceAttribute("dictionary", typeof(DictionarySerpElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseSerpElementItem
    {

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}