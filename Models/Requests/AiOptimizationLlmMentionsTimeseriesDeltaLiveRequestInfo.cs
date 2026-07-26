using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AiOptimizationLlmMentionsTimeseriesDeltaLiveRequestInfo 
    {

        /// <summary>
        /// array of objects containing target entities
        /// <br/>required field
        /// <br/>you can specify up to 10 entities (objects) in the target field
        /// <br/>one target entity can contain either one domain or one keyword and related parameters
        /// <br/>examples:
        /// <br/>target array with a domain entity
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseAiOptimizationLLmMentionsTargetElement> Target { get; set; }

        /// <summary>
        /// start date of the time range
        /// <br/>required field
        /// <br/>minimal value: <c>2025-08-01</c>
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// </summary>
        [JsonProperty("date_from", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// end date of the time range
        /// <br/>required field
        /// <br/>Note:the value specified in <c>date_from</c> cannot exceed the value in <c>date_to</c>
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// </summary>
        [JsonProperty("date_to", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// timeseries delta range
        /// <br/>required field
        /// <br/>possible values:
        /// <br/><c>day</c>, <c>week</c>, <c>month</c>, <c>year</c>
        /// </summary>
        [JsonProperty("group_range", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string GroupRange { get; set; }

        /// <summary>
        /// full name of search location
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>location_code</c>
        /// <br/>if you don't specify this field, the <c>location_code</c> with <c>2840</c> value will be used by default;
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languages</c>
        /// <br/>Note: <c>chat_gpt</c> data is available for <c>United States</c> only
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search location code
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>location_name</c>
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languages</c>
        /// <br/>default value: <c>2840</c>
        /// <br/>Note: <c>chat_gpt</c> data is available for <c>2840</c> only
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of search language
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>;
        /// <br/>if you don't specify this field, the <c>language_code</c> with <c>en</c> value will be used by default;
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languages</c>
        /// <br/>Note: <c>chat_gpt</c> data is available for <c>English</c> only
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search language code
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>;
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languages</c>
        /// <br/>default value: <c>en</c>
        /// <br/>Note: <c>chat_gpt</c> data is available for <c>en</c> only
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// target platform
        /// <br/>optional field
        /// <br/>possible values:
        /// <br/><c>chat_gpt</c>, <c>google</c>
        /// <br/>default value: <c>google</c>
        /// <br/>Note: if the <c>platform</c> is not specified, the data is returned for both platforms
        /// <br/>Note #2:<c>chat_gpt</c> data is available for the <c>United States</c> and <c>English</c> only
        /// </summary>
        [JsonProperty("platform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
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