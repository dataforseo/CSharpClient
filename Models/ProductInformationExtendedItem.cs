using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ProductInformationExtendedItem  : BaseProductInformationItem 
    {

        /// <summary>
        /// contains information specified about the product within the section_name
        /// </summary>
        [JsonProperty("contents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ProductInformationRows> Contents { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}