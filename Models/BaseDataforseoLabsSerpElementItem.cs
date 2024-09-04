namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("organic", typeof(OrganicDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("people_also_ask", typeof(PeopleAlsoAskDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("twitter", typeof(TwitterDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("related_searches", typeof(RelatedSearchesDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_description_item", typeof(KnowledgeGraphDescriptionItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_images_item", typeof(KnowledgeGraphImagesItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_row_item", typeof(KnowledgeGraphRowItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_carousel_item", typeof(KnowledgeGraphCarouselItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph", typeof(KnowledgeGraphDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("carousel", typeof(CarouselDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("multi_carousel", typeof(MultiCarouselDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("top_stories", typeof(TopStoriesDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("answer_box", typeof(AnswerBoxDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("math_solver", typeof(MathSolverDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("video", typeof(VideoDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("people_also_search", typeof(PeopleAlsoSearchDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("map", typeof(MapDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("featured_snippet", typeof(FeaturedSnippetDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("local_pack", typeof(LocalPackDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("hotels_pack", typeof(HotelsPackDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_list_item", typeof(KnowledgeGraphListItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_part_item", typeof(KnowledgeGraphPartItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_expanded_item", typeof(KnowledgeGraphExpandedItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_shopping_item", typeof(KnowledgeGraphShoppingItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("paid", typeof(PaidDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("google_reviews", typeof(GoogleReviewsDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("google_posts", typeof(GooglePostsDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("google_flights", typeof(GoogleFlightsDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("images", typeof(ImagesDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("shopping", typeof(ShoppingDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("jobs", typeof(JobsDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("events", typeof(EventsDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("mention_carousel", typeof(MentionCarouselDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("recipes", typeof(RecipesDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("top_sights", typeof(TopSightsDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("scholarly_articles", typeof(ScholarlyArticlesDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("popular_products", typeof(PopularProductsDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("podcasts", typeof(PodcastsDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("questions_and_answers", typeof(QuestionsAndAnswersDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("find_results_on", typeof(FindResultsOnDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("stocks_box", typeof(StocksBoxDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("visual_stories", typeof(VisualStoriesDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("commercial_units", typeof(CommercialUnitsDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("local_services", typeof(LocalServicesDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("google_hotels", typeof(GoogleHotelsDataforseoLabsSerpElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseDataforseoLabsSerpElementItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// position within a group of elements with identical type values
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

        /// <summary>
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the XPath of the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xpath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Xpath { get; set; }

    }
}