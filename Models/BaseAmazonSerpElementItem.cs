using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("amazon_serp", typeof(AmazonAmazonSerpSerpElementItem))]
    [JsonInheritance("amazon_paid", typeof(AmazonAmazonPaidSerpElementItem))]
    [JsonInheritance("editorial_recommendations", typeof(AmazonEditorialRecommendationsSerpElementItem))]
    [JsonInheritance("related_searches", typeof(AmazonRelatedSearchesSerpElementItem))]
    [JsonInheritance("top_rated_from_our_brands", typeof(AmazonTopRatedFromOurBrandsSerpElementItem))]
    [JsonInheritance("amazon_review_item", typeof(AmazonAmazonReviewItemSerpElementItem))]
    [JsonInheritance("amazon_product_info", typeof(AmazonAmazonProductInfoSerpElementItem))]
    [JsonInheritance("amazon_seller_main_item", typeof(AmazonAmazonSellerMainItemSerpElementItem))]
    [JsonInheritance("amazon_seller_item", typeof(AmazonAmazonSellerItemSerpElementItem))]

    public class BaseAmazonSerpElementItem 
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
        /// absolute rank in Amazon SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankAbsolute { get; set; }

        /// <summary>
        /// the alignment of the element in Amazon SERP
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