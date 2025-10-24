using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ProductKeywordIntersectionsAmazonDataforseoLabsAvailableFiltersAmazonInfo 
    {
        [JsonProperty("keyword_data.keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeyword { get; set; }
        [JsonProperty("keyword_data.location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataLocationCode { get; set; }
        [JsonProperty("keyword_data.language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataLanguageCode { get; set; }
        [JsonProperty("keyword_data.keyword_info.last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoLastUpdatedTime { get; set; }
        [JsonProperty("keyword_data.keyword_info.search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoSearchVolume { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("intersection_result.$key.type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyType { get; set; }
        [JsonProperty("intersection_result.$key.rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyRankGroup { get; set; }
        [JsonProperty("intersection_result.$key.rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyRankAbsolute { get; set; }
        [JsonProperty("intersection_result.$key.xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyXpath { get; set; }
        [JsonProperty("intersection_result.$key.domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyDomain { get; set; }
        [JsonProperty("intersection_result.$key.title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyTitle { get; set; }
        [JsonProperty("intersection_result.$key.url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyUrl { get; set; }
        [JsonProperty("intersection_result.$key.asin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyAsin { get; set; }
        [JsonProperty("intersection_result.$key.image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyImageUrl { get; set; }
        [JsonProperty("intersection_result.$key.price_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyPriceFrom { get; set; }
        [JsonProperty("intersection_result.$key.price_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyPriceTo { get; set; }
        [JsonProperty("intersection_result.$key.currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyCurrency { get; set; }
        [JsonProperty("intersection_result.$key.is_best_seller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyIsBestSeller { get; set; }
        [JsonProperty("intersection_result.$key.is_amazon_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyIsAmazonChoice { get; set; }
        [JsonProperty("intersection_result.$key.rating.rating_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyRatingRatingType { get; set; }
        [JsonProperty("intersection_result.$key.rating.value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyRatingValue { get; set; }
        [JsonProperty("intersection_result.$key.rating.votes_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyRatingVotesCount { get; set; }

        /// <summary>
        /// the maximum value for a rating_type
        /// </summary>
        [JsonProperty("intersection_result.$key.rating.rating_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IntersectionResultKeyRatingRatingMax { get; set; }
        [JsonProperty("intersection_result.$key.delivery_info.delivery_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyDeliveryInfoDeliveryMessage { get; set; }
        [JsonProperty("intersection_result.$key.delivery_info.delivery_price.current", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyDeliveryInfoDeliveryPriceCurrent { get; set; }
        [JsonProperty("intersection_result.$key.delivery_info.delivery_price.regular", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyDeliveryInfoDeliveryPriceRegular { get; set; }
        [JsonProperty("intersection_result.$key.delivery_info.delivery_price.max_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyDeliveryInfoDeliveryPriceMaxValue { get; set; }
        [JsonProperty("intersection_result.$key.delivery_info.delivery_price.currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyDeliveryInfoDeliveryPriceCurrency { get; set; }
        [JsonProperty("intersection_result.$key.delivery_info.delivery_price.is_price_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyDeliveryInfoDeliveryPriceIsPriceRange { get; set; }
        [JsonProperty("intersection_result.$key.delivery_info.delivery_price.displayed_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionResultKeyDeliveryInfoDeliveryPriceDisplayedPrice { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}