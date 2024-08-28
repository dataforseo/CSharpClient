using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataGoogleTrendsCategoriesResultInfo
    {
        /// <summary>
        /// unique google trends category identifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CategoryCode { get; set; }

        /// <summary>
        /// name of the google trends category
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// the code of the superordinate category
        /// <br/>example:
        /// <br/>"category_code": 1100,
        /// <br/>"category_name": "Superhero Films",
        /// <br/>"category_code_parent": 1097
        /// <br/>where category_code_parent corresponds to:
        /// <br/>"category_code": 1097,
        /// <br/>"category_name": "Action &amp; Adventure Films"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code_parent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CategoryCodeParent { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}