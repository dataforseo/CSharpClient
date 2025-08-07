using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationClaudeLlmResponsesModelsResultInfo 
    {

        /// <summary>
        /// name of the AI model
        /// </summary>
        [JsonProperty("model_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

        /// <summary>
        /// web search support for the AI model
        /// <br/>if true, the web_search parameter can be set with the AI model
        /// </summary>
        [JsonProperty("web_search_supported", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WebSearchSupported { get; set; }

        /// <summary>
        /// indicates if Standard (POST-GET) data retrieval is supported
        /// <br/>if true, you can use the Standard (POST-GET) data retrieval method with the AI model
        /// </summary>
        [JsonProperty("task_post_supported", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaskPostSupported { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}