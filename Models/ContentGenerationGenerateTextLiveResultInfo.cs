using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentGenerationGenerateTextLiveResultInfo 
    {

        /// <summary>
        /// number of input tokens
        /// </summary>
        [JsonProperty("input_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InputTokens { get; set; }

        /// <summary>
        /// number of output tokens
        /// </summary>
        [JsonProperty("output_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// number of new tokens
        /// </summary>
        [JsonProperty("new_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewTokens { get; set; }

        /// <summary>
        /// resulting text
        /// </summary>
        [JsonProperty("generated_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GeneratedText { get; set; }

        /// <summary>
        /// token for generating subsequent results
        /// <br/>you can use this parameter to continue the generation from the end of the current result;
        /// <br/>supplement_token values are unique for each subsequent task
        /// </summary>
        [JsonProperty("supplement_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SupplementToken { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}