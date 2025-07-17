using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class ContentGenerationGenerateLiveRequestInfo 
    {

        /// <summary>
        /// initial target text
        /// <br/>required field
        /// <br/>text input for content generation;
        /// <br/>can contain from 1 to 500 tokens
        /// <br/>learn more about tokens on our help center
        /// </summary>
        [JsonProperty("text", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// generation limit for new tokens
        /// <br/>required field if max_tokens is not specified
        /// <br/>the maximum number of new tokens for generated content;
        /// <br/>maximum value: 300;
        /// <br/>Note: the number does not include tokens specified in the text field;
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [JsonProperty("max_new_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxNewTokens { get; set; }

        /// <summary>
        /// generation limit for all tokens
        /// <br/>required field if max_new_tokens is not specified
        /// <br/>the maximum total number of tokens for generated content;
        /// <br/>maximum value: 1024;
        /// <br/>Note: the number includes tokens specified in the text field
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [JsonProperty("max_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("creativity_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CreativityIndex { get; set; }

        /// <summary>
        /// token repetition
        /// <br/>optional field
        /// <br/>limits the repetition of the same tokens in the generated content;
        /// <br/>can take values from 0.5 to 2;
        /// <br/>default value: 1
        /// </summary>
        [JsonProperty("token_repetition_penalty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TokenRepetitionPenalty { get; set; }

        /// <summary>
        /// the number of initial tokens in each iteration for choosing a subsequent word
        /// <br/>optional field
        /// <br/>if you use creativity_index, this field will be ignored
        /// <br/>the higher the number, the more high-probability tokens will be shortlisted for generation;
        /// <br/>can take values from 1 to 100;
        /// <br/>default value: 40
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [JsonProperty("top_k", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("top_p", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TopP { get; set; }

        /// <summary>
        /// controls the randomness in the output
        /// <br/>optional field
        /// <br/>if you use creativity_index, this field will be ignored
        /// <br/>the lower the temperature, the more likely the model will choose words with a higher probability of occurrence;
        /// <br/>can take values from 0 to 1;
        /// <br/>default value: 0.7
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [JsonProperty("temperature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Temperature { get; set; }

        /// <summary>
        /// words or phrases to avoid when generating a text
        /// <br/>optional field
        /// <br/>you can specify up to 50 terms;
        /// <br/>example:
        /// <br/>['term', 'optimization']
        /// </summary>
        [JsonProperty("avoid_words", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> AvoidWords { get; set; }

        /// <summary>
        /// words or phrases to avoid in the beginning of the generated text
        /// <br/>optional field
        /// <br/>you can specify up to 50 terms;
        /// <br/>example:
        /// <br/>['SEO', 'search engine optimization']
        /// </summary>
        [JsonProperty("avoid_starting_words", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> AvoidStartingWords { get; set; }

        /// <summary>
        /// words or phrases to end the text
        /// <br/>optional field
        /// <br/>you can specify up to 50 terms;
        /// <br/>example:
        /// <br/>['now','subscribe']
        /// </summary>
        [JsonProperty("stop_words", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> StopWords { get; set; }

        /// <summary>
        /// token for generating subsequent results
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>you can use this parameter to continue the generation of text from the initial response
        /// <br/>supplement_token values are unique for each subsequent task
        /// </summary>
        [JsonProperty("supplement_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SupplementToken { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}