using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ProductInformationRowProductInformationImageRowElementItem  : BaseMerchantAmazonProductInformationRowElementItem 
    {

        /// <summary>
        /// alternative text of the related product image
        /// </summary>
        [JsonProperty("alt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Alt { get; set; }

        /// <summary>
        /// URL of the image
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}