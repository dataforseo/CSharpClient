using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleShoppingSponsoredCarouselElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// XPath of the element
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// title of the element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// tags assigned to the product
        /// </summary>
        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// name of the seller
        /// <br/>the name of the company that placed a corresponding product on Google Shopping
        /// </summary>
        [JsonProperty("seller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Seller { get; set; }

        /// <summary>
        /// product price
        /// <br/>example:
        /// <br/>384.99
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// currency in the ISO format
        /// <br/>example:
        /// <br/>USD
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// product rating
        /// <br/>the product popularity rate based on product reviews
        /// </summary>
        [JsonProperty("product_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement ProductRating { get; set; }

        /// <summary>
        /// URLs to the images of the product
        /// <br/>the first URL in the array is the featured image of the product
        /// </summary>
        [JsonProperty("product_images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ProductImages { get; set; }

        /// <summary>
        /// unique ad click referral parameter
        /// <br/>using this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL
        /// </summary>
        [JsonProperty("shop_ad_aclk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ShopAdAclk { get; set; }

        /// <summary>
        /// delivery information
        /// <br/>delivery information including free and fast delivery date ranges
        /// </summary>
        [JsonProperty("delivery_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// special offer from the seller
        /// <br/>information on the special offer from the seller, including discount and coupon info
        /// </summary>
        [JsonProperty("special_offer_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SpecialOfferInfo SpecialOfferInfo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}