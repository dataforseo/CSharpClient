using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLlmMentionsTimeseriesNewLostLiveItem 
    {

        /// <summary>
        /// date timestamp
        /// <br/> date format: 'yyyy-mm-dd'
        /// </summary>
        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// new LLM mentions
        /// <br/>indicates the LLM responses that contain the target at the date_to timestamp, did not contain it at the date_from timestamp
        /// </summary>
        [JsonProperty("new_mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewMentions { get; set; }

        /// <summary>
        /// lost LLM mentions
        /// <br/>indicates the LLM responses that contained the specified target at the date_from timestamp, do not contain it at the date_to timestamp
        /// </summary>
        [JsonProperty("lost_mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LostMentions { get; set; }

        /// <summary>
        /// ai_search_volume increment
        /// <br/>indicates the increase of ai_search_volume values between the current timestamp and the previous one
        /// <br/>learn more about this metric here
        /// </summary>
        [JsonProperty("new_ai_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? NewAiSearchVolume { get; set; }

        /// <summary>
        /// ai_search_volume decrement
        /// <br/>indicates the decrease of ai_search_volume values between the current timestamp and the previous one
        /// <br/>learn more about this metric here
        /// </summary>
        [JsonProperty("lost_ai_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? LostAiSearchVolume { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}