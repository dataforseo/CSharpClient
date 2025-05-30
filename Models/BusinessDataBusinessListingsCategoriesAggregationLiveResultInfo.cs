using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataBusinessListingsCategoriesAggregationLiveResultInfo 
    {

        /// <summary>
        /// total number of results in our database relevant to your request
        /// </summary>
        [JsonProperty("total_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalCount { get; set; }

        /// <summary>
        /// item types
        /// <br/>the number of items in the items array
        /// </summary>
        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Count { get; set; }

        /// <summary>
        /// offset in the results array of returned categories
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// token for subsequent requests
        /// <br/>by specifying the unique offset_token when setting a new task, you will get the subsequent results of the initial task;
        /// <br/>offset_token values are unique for each subsequent task
        /// </summary>
        [JsonProperty("offset_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OffsetToken { get; set; }

        /// <summary>
        /// encountered item types
        /// <br/>types of search engine results encountered in the items array;
        /// <br/>possible item types: business_category
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BusinessDataBusinessListingsCategoriesAggregationLiveItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}