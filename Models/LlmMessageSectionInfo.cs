using Newtonsoft.Json;
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
        /// AI-generated text content
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// array of references used to generate the response
        /// <br/>equals null if the web_search parameter is not set to true
        /// <br/>Note: annotations may return empty even when web_search is true, as the AI will attempt to retrieve web information but may not find relevant results
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