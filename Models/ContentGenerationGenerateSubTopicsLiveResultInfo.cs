using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentGenerationGenerateSubTopicsLiveResultInfo 
    {

        /// <summary>
        /// number of input tokens
        /// </summary>
        [JsonProperty("input_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? InputTokens { get; set; }

        /// <summary>
        /// number of output tokens
        /// </summary>
        [JsonProperty("output_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OutputTokens { get; set; }

        /// <summary>
        /// number of new tokens
        /// </summary>
        [JsonProperty("new_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewTokens { get; set; }

        /// <summary>
        /// resulting subtopics
        /// </summary>
        [JsonProperty("sub_topics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> SubTopics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}