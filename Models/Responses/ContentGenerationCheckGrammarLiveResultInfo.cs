using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentGenerationCheckGrammarLiveResultInfo
    {
        /// <summary>
        /// number of input tokens in the POST request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("input_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? InputTokens { get; set; }

        /// <summary>
        /// number of output tokens in the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("output_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// number of new tokens in the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NewTokens { get; set; }

        /// <summary>
        /// initial text in the POST request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("initial_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InitialText { get; set; }

        /// <summary>
        /// language code in the POST request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// the number of results returned in the items array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// contains grammar or spelling errors and related data
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContentGenerationCheckGrammarLiveItem> Items { get; set; }

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