using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AmazonAmazonSerpSerpElementItem  : BaseAmazonSerpElementItem 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// Amazon domain
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// product title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL of the product page
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// ASIN of the product
        /// <br/>learn more about ASIN in this help center guide
        /// </summary>
        [JsonProperty("asin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Asin { get; set; }

        /// <summary>
        /// URL of the product image featured in the results
        /// </summary>
        [JsonProperty("image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// the regular price of a product
        /// <br/>example:
        /// <br/>49.98
        /// </summary>
        [JsonProperty("price_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? PriceFrom { get; set; }

        /// <summary>
        /// the upper limit of the product price range
        /// <br/>example:
        /// <br/>384.99
        /// </summary>
        [JsonProperty("price_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? PriceTo { get; set; }

        /// <summary>
        /// currency in the ISO format
        /// <br/>example:
        /// <br/>USD
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// special offer details
        /// <br/>contains special offer details, including coupon and Subscribe &amp; Save discounts
        /// </summary>
        [JsonProperty("special_offers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> SpecialOffers { get; set; }

        /// <summary>
        /// “Best Seller” label
        /// <br/>if the value is true, the product is marked with the “Best Seller” label
        /// </summary>
        [JsonProperty("is_best_seller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBestSeller { get; set; }

        /// <summary>
        /// “Amazon’s choice” label
        /// <br/>if the value is true, the product is marked with the “Amazon’s choice” label
        /// </summary>
        [JsonProperty("is_amazon_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAmazonChoice { get; set; }

        /// <summary>
        /// the item’s rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// delivery information
        /// <br/>delivery information including free and fast delivery date ranges
        /// </summary>
        [JsonProperty("delivery_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AmazonDeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// number of product purchases in the past month
        /// </summary>
        [JsonProperty("bought_past_month", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BoughtPastMonth { get; set; }

        /// <summary>
        /// description of the product
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// unique product identifier on Amazon
        /// <br/>note that there is no full list of possible values as the data_asin is a dynamic value assigned by Amazon
        /// <br/>example:
        /// <br/>B07G82D89J
        /// </summary>
        [JsonProperty("data_asin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DataAsin { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}