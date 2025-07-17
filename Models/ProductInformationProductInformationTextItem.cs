using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ProductInformationProductInformationTextItem  : BaseMerchantAmazonProductInformationElementItem 
    {

        /// <summary>
        /// text specified under the given title within the section_name
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}