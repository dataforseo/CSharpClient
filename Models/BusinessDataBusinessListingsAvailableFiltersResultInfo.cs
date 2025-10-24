using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataBusinessListingsAvailableFiltersResultInfo 
    {
        [JsonProperty("search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Info Search { get; set; }
        [JsonProperty("categories_aggregation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Info CategoriesAggregation { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}