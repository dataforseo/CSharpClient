using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationChatGptLlmResponsesModelsResultInfo 
    {

        /// <summary>
        /// name of the AI model
        /// </summary>
        [JsonProperty("model_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

        /// <summary>
        /// web search support for the AI model
        /// <br/>if <c>true</c>, the <c>web_search</c> parameter can be set with the AI model
        /// </summary>
        [JsonProperty("web_search_supported", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WebSearchSupported { get; set; }

        /// <summary>
        /// indicates if Standard (POST-GET) data retrieval is supported
        /// <br/>if <c>true</c>, you can use the <see href="https://dataforseo.com/help-center/live-vs-standard-method">Standard (POST-GET)</see> data retrieval method with the AI model
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