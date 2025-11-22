using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLlmMentionsSearchLiveResultInfo 
    {

        /// <summary>
        /// total amount of results relevant the request
        /// </summary>
        [JsonProperty("total_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// the number of mentions objects that are omitted in the items array
        /// </summary>
        [JsonProperty("current_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentOffset { get; set; }

        /// <summary>
        /// token for subsequent requests
        /// <br/>by specifying the unique search_after_token when setting a new task, you will get the subsequent results of the initial task;
        /// <br/>search_after_token values are unique for each subsequent task
        /// </summary>
        [JsonProperty("search_after_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchAfterToken { get; set; }

        /// <summary>
        /// the number of results returned in the items array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// contains relevant mentions data
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiOptimizationLlmMentionsSearchLiveItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}