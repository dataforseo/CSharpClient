using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ProductSeller 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// product title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// seller url
        /// <br/>url of the page where the product is sold
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// rating of the seller
        /// </summary>
        [JsonProperty("seller_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement SellerRating { get; set; }

        /// <summary>
        /// number of seller reviews
        /// <br/>number of reviews on the product seller’s account
        /// </summary>
        [JsonProperty("seller_review_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SellerReviewCount { get; set; }

        /// <summary>
        /// product price
        /// <br/>product price details on the seller’s website
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        /// <summary>
        /// delivery information
        /// <br/>product delivery information
        /// </summary>
        [JsonProperty("delivery_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// product availability information
        /// <br/>can take the following values: in_stock, limited_stock, out_of_stock, backordered, pre_order_available, on_display_to_order
        /// </summary>
        [JsonProperty("product_availability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductAvailability { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}