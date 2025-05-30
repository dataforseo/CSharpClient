using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentAnalysisCategoriesResultInfo 
    {

        /// <summary>
        /// category code
        /// </summary>
        [JsonProperty("category_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CategoryCode { get; set; }

        /// <summary>
        /// full name of the category
        /// </summary>
        [JsonProperty("category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// the code of the superordinate category
        /// <br/>example:
        /// <br/>'category_code': 10178,
        /// <br/>'category_name': 'Apparel Accessories',
        /// <br/>'category_code_parent': 10021
        /// <br/>where category_code_parent
        /// <br/>corresponds to:
        /// <br/>'category_code': 10178,
        /// <br/>'category_name': 'Apparel Accessories'
        /// </summary>
        [JsonProperty("category_code_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CategoryCodeParent { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}