using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ProductVariation 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// product ID in a POST array
        /// <br/>learn more about the parameter in <see href="https://dataforseo.com/help-center/product-id-google-shopping">this help center guide</see>
        /// </summary>
        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// GID ID in a POST array
        /// <br/>learn more about the parameter in <see href="https://dataforseo.com/help-center/whats-a-gid-in-google-shopping-api">this help center guide</see>
        /// </summary>
        [JsonProperty("gid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Gid { get; set; }

        /// <summary>
        /// unique identifier of the SERP data element in the POST array
        /// </summary>
        [JsonProperty("data_docid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DataDocid { get; set; }

        /// <summary>
        /// product variation filter
        /// <br/>used in the product variation URL as the identifier of the specific product variation
        /// </summary>
        [JsonProperty("pvf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Pvf { get; set; }

        /// <summary>
        /// name of the product seller
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// product variation URL on Google Shopping
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// category of the product variation
        /// <br/>example: <c>'Storage Capacity'</c>
        /// </summary>
        [JsonProperty("variation_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string VariationCategory { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}