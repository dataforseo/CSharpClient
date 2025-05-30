using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PricesByDates 
    {

        /// <summary>
        /// price per night
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// price currency
        /// <br/>USD is applied by default, unless specified in the POST array
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }
        [JsonProperty("check_in_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckInDate { get; set; }
        [JsonProperty("check_out_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckOutDate { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}