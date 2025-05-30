using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentOfferInfo 
    {

        /// <summary>
        /// name of the product
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// price of the product
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// price currency
        /// </summary>
        [JsonProperty("price_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PriceCurrency { get; set; }

        /// <summary>
        /// displays the date and time until which the price is valid
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example: '2022-11-01 10:02:52 +00:00'
        /// </summary>
        [JsonProperty("price_valid_until", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PriceValidUntil { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}