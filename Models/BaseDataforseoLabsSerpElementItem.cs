namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("organic", typeof(OrganicDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("people_also_ask", typeof(PeopleAlsoAskDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("twitter", typeof(TwitterDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("people_also_search", typeof(PeopleAlsoSearchDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("related_searches", typeof(RelatedSearchesDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_description_item", typeof(KnowledgeGraphDescriptionItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_images_item", typeof(KnowledgeGraphImagesItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_row_item", typeof(KnowledgeGraphRowItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph", typeof(KnowledgeGraphDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("knowledge_graph_carousel_item", typeof(KnowledgeGraphCarouselItemDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("carousel", typeof(CarouselDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("multi_carousel", typeof(MultiCarouselDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("top_stories", typeof(TopStoriesDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("answer_box", typeof(AnswerBoxDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("math_solver", typeof(MathSolverDataforseoLabsSerpElementItem))]
    [JsonInheritanceAttribute("video", typeof(VideoDataforseoLabsSerpElementItem))]
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
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseDataforseoLabsSerpElementItem
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