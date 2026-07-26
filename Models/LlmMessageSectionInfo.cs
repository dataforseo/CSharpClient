using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class LlmMessageSectionInfo 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// text of the reasoning chain section
        /// <br/>text of the reasoning chain  section summarizing the model's thought process
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// array of references used to generate the response
        /// <br/>equals <c>null</c> if the <c>web_search</c> parameter is not set to <c>true</c>
        /// <br/>Note: <c>annotations</c> may return empty even when <c>web_search</c> is <c>true</c>, as the AI will attempt to retrieve web information but may not find relevant results
        /// </summary>
        [JsonProperty("annotations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AnnotationInfo> Annotations { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}