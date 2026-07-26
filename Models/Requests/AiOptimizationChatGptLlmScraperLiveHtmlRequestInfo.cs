using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AiOptimizationChatGptLlmScraperLiveHtmlRequestInfo 
    {

        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 2000 characters in the <c>keyword</c> field
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your <c>keyword</c>, please specify it as “%25”;
        /// <br/>if you need to use the “+” character for your <c>keyword</c>, please specify it as “%2B”
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c>
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/{{low_se_name}}/locations</c>
        /// <br/>example:
        /// <br/><c>United States</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c>
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/{{low_se_name}}/{{low_se_type}}/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/{{low_se_name}}/{{low_se_type}}/languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c>_by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/{{low_se_name}}/{{low_se_type}}/languages</c>
        /// <br/>example:<c>en</c>n
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// force AI agent to use web search
        /// <br/>optional field
        /// <br/>when enabled, the AI model is forced to access and cite current web information;
        /// <br/>default value: <c>false</c>;
        /// <br/>Note: even if the parameter is set to <c>true</c>, there is no guarantee web sources will be cited in the response
        /// </summary>
        [JsonProperty("force_web_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceWebSearch { get; set; }

        /// <summary>
        /// return expanded citation bar in HTML results
        /// <br/>optional field
        /// <br/>to enable this parameter, <c>force_web_search</c> must also be enabled;
        /// <br/>when enabled, the endpoint will return HTML data from the expanded citation bar;
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("expand_citations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExpandCitations { get; set; }

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