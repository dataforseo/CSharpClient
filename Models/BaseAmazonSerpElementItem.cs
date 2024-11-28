namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("amazon_serp", typeof(AmazonAmazonSerpSerpElementItem))]
    [JsonInheritanceAttribute("amazon_paid", typeof(AmazonAmazonPaidSerpElementItem))]
    [JsonInheritanceAttribute("editorial_recommendations", typeof(AmazonEditorialRecommendationsSerpElementItem))]
    [JsonInheritanceAttribute("related_searches", typeof(AmazonRelatedSearchesSerpElementItem))]
    [JsonInheritanceAttribute("top_rated_from_our_brands", typeof(AmazonTopRatedFromOurBrandsSerpElementItem))]
    [JsonInheritanceAttribute("amazon_product_info", typeof(AmazonAmazonProductInfoSerpElementItem))]
    [JsonInheritanceAttribute("amazon_review_item", typeof(AmazonAmazonReviewItemSerpElementItem))]
    [JsonInheritanceAttribute("amazon_seller_main_item", typeof(AmazonAmazonSellerMainItemSerpElementItem))]
    [JsonInheritanceAttribute("amazon_seller_item", typeof(AmazonAmazonSellerItemSerpElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseAmazonSerpElementItem
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
        /// absolute rank in Amazon SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the XPath of the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xpath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Xpath { get; set; }

    }
}