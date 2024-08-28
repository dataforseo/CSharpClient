using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessDataBusinessListingsCategoriesResultInfo
    {
        /// <summary>
        /// full name of the category
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// number of businesses in the category
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? BusinessCount { get; set; }

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