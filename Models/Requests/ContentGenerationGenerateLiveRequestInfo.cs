using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentGenerationGenerateLiveRequestInfo
    {
        /// <summary>
        /// initial target text
        /// <br/>required field
        /// <br/>text input for content generation;
        /// <br/>can contain from 1 to 500 tokens
        /// <br/>learn more about tokens on our help center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// generation limit for new tokens
        /// <br/>required field if max_tokens is not specified
        /// <br/>the maximum number of new tokens for generated content;
        /// <br/>maximum value: 300;
        /// <br/>Note: the number does not include tokens specified in the text field;
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_new_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxNewTokens { get; set; }

        /// <summary>
        /// generation limit for all tokens
        /// <br/>required field if max_new_tokens is not specified
        /// <br/>the maximum total number of tokens for generated content;
        /// <br/>maximum value: 1024;
        /// <br/>Note: the number includes tokens specified in the text field
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_tokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// creativity of content generation
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to use top_k / top_p / temperature
        /// <br/>the randomness of the selection of equally probable subsequent tokens;
        /// <br/>can take values from 0 to 1
        /// <br/>default value: 0.8
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creativity_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? CreativityIndex { get; set; }

        /// <summary>
        /// token repetition
        /// <br/>optional field
        /// <br/>limits the repetition of the same tokens in the generated content;
        /// <br/>can take values from 0.5 to 2;
        /// <br/>default value: 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token_repetition_penalty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? TokenRepetitionPenalty { get; set; }

        /// <summary>
        /// the number of initial tokens in each iteration for choosing a subsequent word
        /// <br/>optional field
        /// <br/>if you use creativity_index, this field will be ignored
        /// <br/>the higher the number, the more high-probability tokens will be shortlisted for generation;
        /// <br/>can take values from 1 to 100;
        /// <br/>default value: 40
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top_k", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TopK { get; set; }

        /// <summary>
        /// excludes initial tokens with probability lower than one
        /// <br/>optional field
        /// <br/>if you use creativity_index, this field will be ignored
        /// <br/>the higher the value, the less low-probability tokens may be shortlisted for generation;
        /// <br/>can take values from 0 to 1
        /// <br/>default value: 0.9
        /// <br/>Note:if both top_k and top_p are used, top_k acts first;
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top_p", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? TopP { get; set; }

        /// <summary>
        /// controls the randomness in the output
        /// <br/>optional field
        /// <br/>if you use creativity_index, this field will be ignored
        /// <br/>the lower the temperature, the more likely the model will choose words with a higher probability of occurrence;
        /// <br/>can take values from 0 to 1;
        /// <br/>default value: 0.7
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("temperature", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Temperature { get; set; }

        /// <summary>
        /// words or phrases to avoid when generating a text
        /// <br/>optional field
        /// <br/>you can specify up to 50 terms;
        /// <br/>example:
        /// <br/>["term", "optimization"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avoid_words", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> AvoidWords { get; set; }

        /// <summary>
        /// words or phrases to avoid in the beginning of the generated text
        /// <br/>optional field
        /// <br/>you can specify up to 50 terms;
        /// <br/>example:
        /// <br/>["SEO", "search engine optimization"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avoid_starting_words", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> AvoidStartingWords { get; set; }

        /// <summary>
        /// words or phrases to end the text
        /// <br/>optional field
        /// <br/>you can specify up to 50 terms;
        /// <br/>example:
        /// <br/>["now","subscribe"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stop_words", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> StopWords { get; set; }

        /// <summary>
        /// token for generating subsequent results
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>you can use this parameter to continue the generation of text from the initial response
        /// <br/>supplement_token values are unique for each subsequent task
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplement_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplementToken { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tag { get; set; }

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