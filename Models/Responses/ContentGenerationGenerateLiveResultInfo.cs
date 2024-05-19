using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentGenerationGenerateLiveResultInfo
    {
        /// <summary>
        /// number of input tokens
        /// </summary>
        [Newtonsoft.Json.JsonProperty("input_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? InputTokens { get; set; }

        /// <summary>
        /// number of output tokens
        /// </summary>
        [Newtonsoft.Json.JsonProperty("output_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// number of new tokens
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NewTokens { get; set; }

        /// <summary>
        /// resulting text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("generated_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratedText { get; set; }

        /// <summary>
        /// token for generating subsequent results
        /// <br/>you can use this parameter to continue the generation from the end of the current result;
        /// <br/>supplement_token values are unique for each subsequent task
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplement_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplementToken { get; set; }

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