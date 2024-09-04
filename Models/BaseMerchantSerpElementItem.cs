namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("google_shopping_serp", typeof(GoogleShoppingSerpMerchantSerpElementItem))]
    [JsonInheritanceAttribute("google_shopping_paid", typeof(GoogleShoppingPaidMerchantSerpElementItem))]
    [JsonInheritanceAttribute("google_shopping_sponsored_carousel", typeof(GoogleShoppingSponsoredCarouselMerchantSerpElementItem))]
    [JsonInheritanceAttribute("related_searches", typeof(RelatedSearchesMerchantSerpElementItem))]
    [JsonInheritanceAttribute("shops_list", typeof(ShopsListMerchantSerpElementItem))]
    [JsonInheritanceAttribute("buy_on_google", typeof(BuyOnGoogleMerchantSerpElementItem))]
    [JsonInheritanceAttribute("shopping_specification", typeof(ShoppingSpecificationMerchantSerpElementItem))]
    [JsonInheritanceAttribute("product_info_element", typeof(ProductInfoElementMerchantSerpElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseMerchantSerpElementItem
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
        /// <br/>absolute position among all the elements found in Google Shopping SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

    }
}