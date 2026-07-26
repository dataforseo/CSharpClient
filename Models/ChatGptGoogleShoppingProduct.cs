using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ChatGptGoogleShoppingProduct 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// event identifier
        /// <br/>internal event identifier used by Google
        /// </summary>
        [JsonProperty("ei", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ei { get; set; }

        /// <summary>
        /// product identifier
        /// <br/>can be used as a <c>data_docid</c> in Google Shopping API endpoints
        /// </summary>
        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// Google Shopping catalog identifier of the product
        /// <br/>can be used as a <c>product_id</c> in <see href="https://docs.dataforseo.com/v3/merchant/google/overview/">Google Shopping API endpoints</see>
        /// </summary>
        [JsonProperty("catalog_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Google product cluster identifier
        /// <br/>can be used as a <c>gid</c> in <see href="https://docs.dataforseo.com/v3/merchant/google/overview/">Google Shopping API endpoints</see>
        /// </summary>
        [JsonProperty("gpcid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Gpcid { get; set; }

        /// <summary>
        /// document identifier of the main offer in the headline
        /// <br/>can be used as a <c>data_docid</c> in <see href="https://docs.dataforseo.com/v3/merchant/google/overview/">Google Shopping API endpoints</see>
        /// </summary>
        [JsonProperty("headline_offer_docid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HeadlineOfferDocid { get; set; }

        /// <summary>
        /// identifier for the displayed product’s image
        /// </summary>
        [JsonProperty("image_docid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageDocid { get; set; }

        /// <summary>
        /// resource descriptor string 
        /// <br/>internal Google resource descriptor string that identifies the product within Google's Shopping index
        /// </summary>
        [JsonProperty("rds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Rds { get; set; }

        /// <summary>
        /// search query
        /// <br/>search query used by ChatGPT to retrieve the product from Google Shopping
        /// </summary>
        [JsonProperty("query", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// merchant identifier
        /// <br/>identifier of the seller or merchant account in Google Shopping
        /// </summary>
        [JsonProperty("mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mid { get; set; }

        /// <summary>
        /// product view type
        /// <br/>internal Google parameter that specifies the product view type used when rendering the product item
        /// </summary>
        [JsonProperty("pvt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Pvt { get; set; }

        /// <summary>
        /// encoded location parameter
        /// <br/>indicates the location for a search
        /// </summary>
        [JsonProperty("uule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Uule { get; set; }

        /// <summary>
        /// country code
        /// <br/>indicates the location for which search results are displayed
        /// </summary>
        [JsonProperty("gl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Gl { get; set; }

        /// <summary>
        /// host language code
        /// <br/>indicates the language in which search results are displayed
        /// </summary>
        [JsonProperty("hl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Hl { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}