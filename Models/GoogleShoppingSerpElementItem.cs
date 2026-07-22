using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleShoppingSerpElementItem  : BaseMerchantGoogleShoppingProductsElementItem 
    {

        /// <summary>
        /// domain of the URLdomain of the URL where a special offer is postedNote: this field is deprecated and will return null
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// title of the element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// description of the product in Google Shopping SERP
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// URL pointing at special offer pageURL where a special offer is postedNote: this field is deprecated and will return null
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// URL to the product page on Google Shopping
        /// </summary>
        [JsonProperty("shopping_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ShoppingUrl { get; set; }

        /// <summary>
        /// tags assigned to the product
        /// </summary>
        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// product priceexample:384.99
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// price multiplier for instalment planindicates the number of months covered by the monthly payment for the product
        /// </summary>
        [JsonProperty("price_multiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceMultiplier { get; set; }

        /// <summary>
        /// product old pricedisplayed if the product price has been changedexample:499
        /// </summary>
        [JsonProperty("old_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OldPrice { get; set; }

        /// <summary>
        /// currency in the ISO formatexample:USD
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// unique product identifier on Google Shoppingnote that there is no full list of possible values as the product_id is a dynamic value assigned by Googleif there are no values, you will get nullexample:4485466949985702538learn more about the parameter in this help center guide
        /// </summary>
        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// unique identifier of the SERP data elementnote that there is no full list of possible values as the data_docid is a dynamic value assigned by Googleexample:17363035694596624076
        /// </summary>
        [JsonProperty("data_docid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DataDocid { get; set; }

        /// <summary>
        /// name of the sellerthe name of the company that placed a corresponding product on Google Shopping
        /// </summary>
        [JsonProperty("seller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Seller { get; set; }

        /// <summary>
        /// object containing additional url parametersyou can get more details about the product by using this object in the POST request to the Google Shopping Product Specification and Google Shopping Sellers endpoint
        /// </summary>
        [JsonProperty("additional_specifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> AdditionalSpecifications { get; set; }

        /// <summary>
        /// number of product reviewsindicates the number of reviews left by users on Google Shoppingif there are no values, you will get null
        /// </summary>
        [JsonProperty("reviews_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReviewsCount { get; set; }

        /// <summary>
        /// 'best match' labelif the value is true, the product is marked with the 'best match' labelif there are no values, you will get null
        /// </summary>
        [JsonProperty("is_best_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBestMatch { get; set; }

        /// <summary>
        /// product ratingthe product popularity rate based on product reviews
        /// </summary>
        [JsonProperty("product_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement ProductRating { get; set; }

        /// <summary>
        /// shop ratingthe popularity rate of the seller based on user reviews
        /// </summary>
        [JsonProperty("shop_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement ShopRating { get; set; }

        /// <summary>
        /// URLs to the images of the productthe first URL in the array is the featured image of the product
        /// </summary>
        [JsonProperty("product_images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ProductImages { get; set; }

        /// <summary>
        /// unique ad click referral parameterusing this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL
        /// </summary>
        [JsonProperty("shop_ad_aclk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ShopAdAclk { get; set; }

        /// <summary>
        /// global product identifier on Google Shoppingnote that there is no full list of possible values as the gid is a dynamic value assigned by Googleif there are no values, you will get nullexample:4702526954592161872learn more about gid parameter in this help center guide
        /// </summary>
        [JsonProperty("gid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Gid { get; set; }

        /// <summary>
        /// delivery informationdelivery information including free and fast delivery date ranges
        /// </summary>
        [JsonProperty("delivery_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// stores count informationcontains information about the number of stores that offer the same product
        /// </summary>
        [JsonProperty("stores_count_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public StoresCountInfo StoresCountInfo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}