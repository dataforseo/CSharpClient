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
        /// event identifierinternal event identifier used by Google
        /// </summary>
        [JsonProperty("ei", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ei { get; set; }

        /// <summary>
        /// product identifiercan be used as a data_docid in Google Shopping API endpoints
        /// </summary>
        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// Google Shopping catalog identifier of the productcan be used as a product_id in Google Shopping API endpoints
        /// </summary>
        [JsonProperty("catalog_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Google product cluster identifiercan be used as a gid in Google Shopping API endpoints
        /// </summary>
        [JsonProperty("gpcid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Gpcid { get; set; }

        /// <summary>
        /// document identifier of the main offer in the headlinecan be used as a data_docid in Google Shopping API endpoints
        /// </summary>
        [JsonProperty("headline_offer_docid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HeadlineOfferDocid { get; set; }

        /// <summary>
        /// identifier for the displayed product’s image
        /// </summary>
        [JsonProperty("image_docid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageDocid { get; set; }

        /// <summary>
        /// resource descriptor string internal Google resource descriptor string that identifies the product within Google's Shopping index
        /// </summary>
        [JsonProperty("rds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Rds { get; set; }

        /// <summary>
        /// search querysearch query used by ChatGPT to retrieve the product from Google Shopping
        /// </summary>
        [JsonProperty("query", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// merchant identifieridentifier of the seller or merchant account in Google Shopping
        /// </summary>
        [JsonProperty("mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mid { get; set; }

        /// <summary>
        /// product view typeinternal Google parameter that specifies the product view type used when rendering the product item
        /// </summary>
        [JsonProperty("pvt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Pvt { get; set; }

        /// <summary>
        /// encoded location parameterindicates the location for a search
        /// </summary>
        [JsonProperty("uule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Uule { get; set; }

        /// <summary>
        /// country codeindicates the location for which search results are displayed
        /// </summary>
        [JsonProperty("gl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Gl { get; set; }

        /// <summary>
        /// host language codeindicates the language in which search results are displayed
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