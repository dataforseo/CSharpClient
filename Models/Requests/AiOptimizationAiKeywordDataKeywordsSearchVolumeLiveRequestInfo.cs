using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveRequestInfo 
    {

        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>UTF-8 encoding
        /// <br/>The maximum number of keywords you can specify: 1000;
        /// <br/>The maximum number of characters in a single keyword: 250;
        /// <br/>The keywords will be converted to lowercase format;
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keywords", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don't specify <c>location_code</c>
        /// <br/>Note: it is required to specify either <c>location_name</c> or <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_name</c> by making a separate request to the
        /// <br/><c>https://api.dataforseo.com/v3/ai_optimization/ai_keyword_data/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// unique location identifier
        /// <br/>required field if you don't specify <c>location_name</c>
        /// <br/>Note: it is required to specify either <c>location_name</c> or <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_code</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/ai_optimization/ai_keyword_data/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_name</c> by making a separate request to the
        /// <br/><c>https://api.dataforseo.com/v3/ai_optimization/ai_keyword_data/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c> by making a separate request to the
        /// <br/><c>https://api.dataforseo.com/v3/ai_optimization/ai_keyword_data/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

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