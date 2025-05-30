using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BuyOnGoogleMerchantSerpElementItem  : BaseMerchantSerpElementItem 
    {

        /// <summary>
        /// XPath of the element
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// domain in SERP
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// product title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Google Shopping URL forwarding to the product page
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// details and special offers
        /// <br/>if there are no details, the value will be null
        /// </summary>
        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        /// <summary>
        /// product price without tax and shipping
        /// </summary>
        [JsonProperty("base_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BasePrice { get; set; }

        /// <summary>
        /// the amount of tax
        /// <br/>tax is specified as the actual amount of money, not as the percentage
        /// </summary>
        [JsonProperty("tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax { get; set; }

        /// <summary>
        /// product shipping price
        /// </summary>
        [JsonProperty("shipping_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ShippingPrice { get; set; }

        /// <summary>
        /// product price including tax and shipping
        /// </summary>
        [JsonProperty("total_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalPrice { get; set; }

        /// <summary>
        /// currency in the ISO format
        /// <br/>example:
        /// <br/>USD
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// name of the seller
        /// <br/>the name of the company that placed a corresponding product on Google Shopping
        /// </summary>
        [JsonProperty("seller_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SellerName { get; set; }

        /// <summary>
        /// shop rating
        /// <br/>the shop popularity rate based on product reviews
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// unique ad click referral parameter
        /// <br/>using this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL
        /// <br/>in this case, the value equals null
        /// </summary>
        [JsonProperty("shop_ad_aclk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ShopAdAclk { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}