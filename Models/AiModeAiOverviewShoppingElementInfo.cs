using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiModeAiOverviewShoppingElementInfo 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// unique product identifier on Google Shopping
        /// <br/>learn more about the parameter in <see href="https://dataforseo.com/help-center/product-id-google-shopping">this help center guide</see>
        /// </summary>
        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// unique identifier of the SERP data element
        /// </summary>
        [JsonProperty("data_docid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DataDocid { get; set; }

        /// <summary>
        /// global product identifier on Google Shopping
        /// <br/>learn more about the parameter in <see href="https://dataforseo.com/help-center/whats-a-gid-in-google-shopping-api">this help center guide</see>
        /// </summary>
        [JsonProperty("gid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Gid { get; set; }

        /// <summary>
        /// reference page title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL in link
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// domain in link
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// product rating 
        /// <br/>the popularity rate based on reviews
        /// <br/> if there is none, the value will be <c>null</c>
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// product price
        /// <br/>product price details on the seller's website;
        /// <br/> if there is none, the value will be <c>null</c>
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AiModePriceInfo Price { get; set; }

        /// <summary>
        /// product seller
        /// <br/>name of the product's seller as displayed in search results
        /// </summary>
        [JsonProperty("seller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Seller { get; set; }

        /// <summary>
        /// additional information about the result
        /// </summary>
        [JsonProperty("snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Snippet { get; set; }

        /// <summary>
        /// merchant account provider
        /// <br/>e-commerce site that hosts products or websites of individual sellers under the same merchant account
        /// <br/>example:
        /// <br/><c>by Google</c>
        /// </summary>
        [JsonProperty("marketplace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Marketplace { get; set; }

        /// <summary>
        /// URL to the merchant account provider
        /// <br/>e-commerce site that hosts products or websites of individual sellers under the same merchant account
        /// </summary>
        [JsonProperty("marketplace_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MarketplaceUrl { get; set; }

        /// <summary>
        /// URL of the image
        /// <br/>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available)
        /// </summary>
        [JsonProperty("image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}