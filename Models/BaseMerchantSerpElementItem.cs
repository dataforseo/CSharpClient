using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("google_shopping_serp", typeof(GoogleShoppingSerpMerchantSerpElementItem))]
    [JsonInheritance("google_shopping_paid", typeof(GoogleShoppingPaidMerchantSerpElementItem))]
    [JsonInheritance("google_shopping_sponsored_carousel", typeof(GoogleShoppingSponsoredCarouselMerchantSerpElementItem))]
    [JsonInheritance("related_searches", typeof(RelatedSearchesMerchantSerpElementItem))]
    [JsonInheritance("shops_list", typeof(ShopsListMerchantSerpElementItem))]
    [JsonInheritance("buy_on_google", typeof(BuyOnGoogleMerchantSerpElementItem))]
    [JsonInheritance("shopping_specification", typeof(ShoppingSpecificationMerchantSerpElementItem))]
    [JsonInheritance("product_info_element", typeof(ProductInfoElementMerchantSerpElementItem))]

    public class BaseMerchantSerpElementItem 
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
        public double? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements found in Google Shopping SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankAbsolute { get; set; }

        /// <summary>
        /// alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}