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
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseMerchantSerpElementItem
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