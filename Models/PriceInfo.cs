using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PriceInfo 
    {

        /// <summary>
        /// current price
        /// <br/>indicates the current price of the product or service featured in the result
        /// </summary>
        [JsonProperty("current", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Current { get; set; }

        /// <summary>
        /// regular price
        /// <br/>indicates the regular price of the product or service with no discounts applied
        /// </summary>
        [JsonProperty("regular", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Regular { get; set; }

        /// <summary>
        /// the maximum price
        /// <br/>the maximum price of the product or service as indicated in the result
        /// </summary>
        [JsonProperty("max_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxValue { get; set; }

        /// <summary>
        /// currency of the listed price
        /// <br/>ISO code of the currency applied to the price
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// price is provided as a range
        /// <br/>indicates whether a price is provided in a range
        /// </summary>
        [JsonProperty("is_price_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPriceRange { get; set; }

        /// <summary>
        /// price string in the result
        /// <br/>raw price string as provided in the result
        /// </summary>
        [JsonProperty("displayed_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayedPrice { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}