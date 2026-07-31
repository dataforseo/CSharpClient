using Newtonsoft.Json;
using System;
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
        public int? CategoryCode { get; set; }

        /// <summary>
        /// full name of the category
        /// </summary>
        [JsonProperty("category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// the code of the superordinate category
        /// <br/>example:
        /// <br/><c>'category_code': 10178,'category_name': 'Apparel Accessories','category_code_parent': 10021</c> 
        /// <br/>where <c>category_code_parent</c> 
        /// <br/>corresponds to: 
        /// <br/><c>'category_code': 10178,'category_name': 'Apparel Accessories'</c>
        /// </summary>
        [JsonProperty("category_code_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryCodeParent { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}