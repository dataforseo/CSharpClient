using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{

    public class AiOptimizationChatGptLlmScraperLiveHtmlResponseInfo  : BaseResponseInfo 
    {

        /// <summary>
        /// array of tasks
        /// </summary>
        [JsonProperty("tasks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiOptimizationChatGptLlmScraperLiveHtmlTaskInfo> Tasks { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}