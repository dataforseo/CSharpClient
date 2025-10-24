using Newtonsoft.Json;
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
        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// title of the element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// reference page URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// domain in link
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// the item’s rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// pricing details
        /// <br/>contains the pricing details of the product or service featured in the result
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        /// <summary>
        /// seller of the product
        /// </summary>
        [JsonProperty("seller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Seller { get; set; }

        /// <summary>
        /// text alongside the link title
        /// </summary>
        [JsonProperty("snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Snippet { get; set; }

        /// <summary>
        /// merchant account provider
        /// <br/>commerce site that hosts products or websites of individual sellers under the same merchant account
        /// <br/>example:
        /// <br/>by Google
        /// </summary>
        [JsonProperty("marketplace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Marketplace { get; set; }

        /// <summary>
        /// relevant marketplace URL
        /// <br/>URL of the page on the marketplace website where the product is hosted
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