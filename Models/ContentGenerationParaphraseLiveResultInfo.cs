using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentGenerationParaphraseLiveResultInfo 
    {

        /// <summary>
        /// number of input tokens in the POST request
        /// </summary>
        [JsonProperty("input_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InputTokens { get; set; }

        /// <summary>
        /// number of output tokens in the response
        /// </summary>
        [JsonProperty("output_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// number of new tokens in the response
        /// </summary>
        [JsonProperty("new_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewTokens { get; set; }

        /// <summary>
        /// paraphrased version of the given text
        /// </summary>
        [JsonProperty("generated_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GeneratedText { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}