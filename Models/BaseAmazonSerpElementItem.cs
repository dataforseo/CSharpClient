namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("amazon_serp", typeof(AmazonAmazonSerpSerpElementItem))]
    [JsonInheritanceAttribute("amazon_paid", typeof(AmazonAmazonPaidSerpElementItem))]
    [JsonInheritanceAttribute("editorial_recommendations", typeof(AmazonEditorialRecommendationsSerpElementItem))]
    [JsonInheritanceAttribute("related_searches", typeof(AmazonRelatedSearchesSerpElementItem))]
    [JsonInheritanceAttribute("top_rated_from_our_brands", typeof(AmazonTopRatedFromOurBrandsSerpElementItem))]
    [JsonInheritanceAttribute("amazon_product_info", typeof(AmazonAmazonProductInfoSerpElementItem))]
    [JsonInheritanceAttribute("amazon_seller_main_item", typeof(AmazonAmazonSellerMainItemSerpElementItem))]
    [JsonInheritanceAttribute("amazon_seller_item", typeof(AmazonAmazonSellerItemSerpElementItem))]
    [JsonInheritanceAttribute("amazon_review_item", typeof(AmazonAmazonReviewItemSerpElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseAmazonSerpElementItem
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