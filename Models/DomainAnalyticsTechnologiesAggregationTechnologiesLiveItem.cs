using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DomainAnalyticsTechnologiesAggregationTechnologiesLiveItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// technology group id
        /// </summary>
        [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// technology category id
        /// </summary>
        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// technology name
        /// </summary>
        [JsonProperty("technology", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Technology { get; set; }

        /// <summary>
        /// technology groups count
        /// <br/>number of domains that match the parameters you specified and are using technologies from the indicated group
        /// </summary>
        [JsonProperty("groups_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? GroupsCount { get; set; }

        /// <summary>
        /// technology categories count
        /// <br/>number of domains that match the parameters you specified and are using technologies from the indicated category
        /// </summary>
        [JsonProperty("categories_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CategoriesCount { get; set; }

        /// <summary>
        /// technologies count
        /// <br/>number of domains that match the parameters you specified and are using the indicated technology
        /// </summary>
        [JsonProperty("technologies_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TechnologiesCount { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}