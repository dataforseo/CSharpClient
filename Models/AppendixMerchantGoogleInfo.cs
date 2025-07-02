using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixMerchantGoogleInfo 
    {
        [JsonProperty("products", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpsRatesDataInfo Products { get; set; }
        [JsonProperty("sellers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSellersGoogleMerchantLimitsRatesDataInfo Sellers { get; set; }
        [JsonProperty("product_spec", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpsRatesDataInfo ProductSpec { get; set; }
        [JsonProperty("product_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpsRatesDataInfo ProductInfo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}