using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsAvailableFiltersAmazonInfo 
    {
        [JsonProperty("keyword_data.keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeyword { get; set; }
        [JsonProperty("keyword_data.keyword_info.last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoLastUpdatedTime { get; set; }
        [JsonProperty("keyword_data.keyword_info.search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoSearchVolume { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("ranked_serp_element.serp_item.type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemType { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRankGroup { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRankAbsolute { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemXpath { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDomain { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemTitle { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemUrl { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.asin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemAsin { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemImageUrl { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.price_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemPriceFrom { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.price_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemPriceTo { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemCurrency { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.is_best_seller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemIsBestSeller { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.is_amazon_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemIsAmazonChoice { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rating.rating_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRatingRatingType { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rating.value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRatingValue { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rating.votes_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRatingVotesCount { get; set; }

        /// <summary>
        /// the maximum value for a rating_type
        /// </summary>
        [JsonProperty("ranked_serp_element.serp_item.rating.rating_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankedSerpElementSerpItemRatingRatingMax { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.delivery_info.delivery_date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDeliveryInfoDeliveryDateFrom { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.delivery_info.delivery_date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDeliveryInfoDeliveryDateTo { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.delivery_info.fastest_delivery_date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDeliveryInfoFastestDeliveryDateFrom { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.delivery_info.fastest_delivery_date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDeliveryInfoFastestDeliveryDateTo { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.delivery_info.delivery_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDeliveryInfoDeliveryMessage { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.delivery_info.delivery_price.current", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDeliveryInfoDeliveryPriceCurrent { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.delivery_info.delivery_price.regular", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDeliveryInfoDeliveryPriceRegular { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.delivery_info.delivery_price.max_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDeliveryInfoDeliveryPriceMaxValue { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.delivery_info.delivery_price.currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDeliveryInfoDeliveryPriceCurrency { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.delivery_info.delivery_price.is_price_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDeliveryInfoDeliveryPriceIsPriceRange { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.delivery_info.delivery_price.displayed_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDeliveryInfoDeliveryPriceDisplayedPrice { get; set; }
        [JsonProperty("ranked_serp_element.check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementCheckUrl { get; set; }
        [JsonProperty("ranked_serp_element.serp_item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemTypes { get; set; }
        [JsonProperty("ranked_serp_element.se_results_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSeResultsCount { get; set; }
        [JsonProperty("ranked_serp_element.last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementLastUpdatedTime { get; set; }
        [JsonProperty("ranked_serp_element.previous_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementPreviousUpdatedTime { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}