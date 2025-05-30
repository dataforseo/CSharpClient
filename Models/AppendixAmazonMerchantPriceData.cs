using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixAmazonMerchantPriceData 
    {
        [JsonProperty("asin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixProductGoogleMerchantPriceDataInfo Asin { get; set; }
        [JsonProperty("products", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixProductGoogleMerchantPriceDataInfo Products { get; set; }
        [JsonProperty("sellers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixProductGoogleMerchantPriceDataInfo Sellers { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}