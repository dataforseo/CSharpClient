using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationClaudeLlmResponsesLiveResultInfo 
    {

        /// <summary>
        /// name of the AI model used
        /// </summary>
        [JsonProperty("model_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

        /// <summary>
        /// number of tokens in the inputtotal count of tokens processed
        /// </summary>
        [JsonProperty("input_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InputTokens { get; set; }

        /// <summary>
        /// number of tokens in the outputtotal count of tokens generated in the AI response
        /// </summary>
        [JsonProperty("output_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// number of reasoning tokenstotal count of tokens used to generate reasoning content
        /// </summary>
        [JsonProperty("reasoning_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// indicates if web search was used
        /// </summary>
        [JsonProperty("web_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WebSearch { get; set; }

        /// <summary>
        /// cost of AI tokens, USDthe price charged by the third-party AI model provider for according to its Pricing
        /// </summary>
        [JsonProperty("money_spent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MoneySpent { get; set; }

        /// <summary>
        /// date and time when the result was receivedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Datetime { get; set; }

        /// <summary>
        /// array of response itemscontains structured AI response data
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseAiOptimizationLlmResponseElementItem> Items { get; set; }

        /// <summary>
        /// array of fan-out queriescontains related search queries derived from the main query to provide a more comprehensive response
        /// </summary>
        [JsonProperty("fan_out_queries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> FanOutQueries { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}