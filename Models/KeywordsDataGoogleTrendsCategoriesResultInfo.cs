using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataGoogleTrendsCategoriesResultInfo 
    {

        /// <summary>
        /// unique google trends category identifier
        /// </summary>
        [JsonProperty("category_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryCode { get; set; }

        /// <summary>
        /// name of the google trends category
        /// </summary>
        [JsonProperty("category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// the code of the superordinate category
        /// <br/>example:
        /// <br/>'category_code': 1100,
        /// <br/>'category_name': 'Superhero Films',
        /// <br/>'category_code_parent': 1097
        /// <br/>where category_code_parent corresponds to:
        /// <br/>'category_code': 1097,
        /// <br/>'category_name': 'Action &amp; Adventure Films'
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