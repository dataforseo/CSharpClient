using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataBingKeywordsForKeywordsTasksReadyResultInfo 
    {

        /// <summary>
        /// task identifier of the completed task
        /// <br/>unique task identifier in our system in the UUID format
        /// </summary>
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// search engine specified when setting the task
        /// </summary>
        [JsonProperty("se", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Se { get; set; }

        /// <summary>
        /// type of the task
        /// </summary>
        [JsonProperty("function", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Function { get; set; }

        /// <summary>
        /// date when the task was posted (in the UTC format)
        /// </summary>
        [JsonProperty("date_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatePosted { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// URL for collecting the results of the task
        /// </summary>
        [JsonProperty("endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}