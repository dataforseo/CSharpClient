using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleShoppingCarouselElement 
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
        /// product title
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
        /// URL to the product page on Google Shopping
        /// </summary>
        [JsonProperty("shopping_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ShoppingUrl { get; set; }

        /// <summary>
        /// unique product identifier on Google Shopping
        /// <br/>note that there is no full list of possible values as the product_id is a dynamic value assigned by Google
        /// <br/>if there are no values, you will get null
        /// <br/>example:
        /// <br/>4485466949985702538
        /// <br/>learn more about the parameter in this help center guide
        /// </summary>
        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// unique identifier of the SERP data element
        /// <br/>note that there is no full list of possible values as the data_docid is a dynamic value assigned by Google
        /// <br/>example:
        /// <br/>17363035694596624076
        /// </summary>
        [JsonProperty("data_docid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DataDocid { get; set; }

        /// <summary>
        /// global product identifier on Google Shopping
        /// <br/>note that there is no full list of possible values as the gid is a dynamic value assigned by Google
        /// <br/>if there are no values, you will get null
        /// <br/>example:
        /// <br/>4702526954592161872
        /// <br/>learn more about gid parameter in this help center guide
        /// </summary>
        [JsonProperty("gid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Gid { get; set; }

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