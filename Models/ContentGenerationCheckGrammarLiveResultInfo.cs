using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentGenerationCheckGrammarLiveResultInfo 
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
        /// initial text in the POST request
        /// </summary>
        [JsonProperty("initial_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string InitialText { get; set; }

        /// <summary>
        /// language code in the POST request
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// the number of results returned in the items array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// contains grammar or spelling errors and related data
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ContentGenerationCheckGrammarLiveItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}