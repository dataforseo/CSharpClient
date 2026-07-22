using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLlmMentionsTimeseriesDeltaLiveItem 
    {

        /// <summary>
        /// date timestamp
        /// <br/> date format: 'yyyy-mm-dd'
        /// </summary>
        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// LLM mentions count delta
        /// <br/>the difference in mentions between the current timestamp and the previous one
        /// </summary>
        [JsonProperty("delta_mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DeltaMentions { get; set; }

        /// <summary>
        /// LLM mentions count delta
        /// <br/>the difference in ai_search_volume values between the current timestamp and the previous one
        /// <br/>learn more about this metric here
        /// </summary>
        [JsonProperty("delta_ai_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? DeltaAiSearchVolume { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}