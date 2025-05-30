using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentGenerationParaphraseLiveResultInfo
    {
        /// <summary>
        /// number of input tokens in the POST request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("input_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InputTokens { get; set; }

        /// <summary>
        /// number of output tokens in the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("output_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OutputTokens { get; set; }

        /// <summary>
        /// number of new tokens in the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NewTokens { get; set; }

        /// <summary>
        /// paraphrased version of the given text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("generated_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratedText { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}