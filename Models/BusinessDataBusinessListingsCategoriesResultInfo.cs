using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataBusinessListingsCategoriesResultInfo 
    {

        /// <summary>
        /// full name of the category
        /// </summary>
        [JsonProperty("category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// number of businesses in the category
        /// </summary>
        [JsonProperty("business_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessCount { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}