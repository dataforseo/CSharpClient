using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo
    {
        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>UTF-8 encoding
        /// <br/>the keywords should be specified in the lowercase format
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don’t specify location_code
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_name by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>Note: this endpoint currently supports the US, Egypt, Saudi Arabia, and the United Arab Emirates locations only;
        /// <br/>example:
        /// <br/>United States
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if you don’t specify location_name
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_code by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>Note: this endpoint currently supports the US, Egypt, Saudi Arabia, and the United Arab Emirates locations only;
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don’t specify language_code
        /// <br/>Note: it is required to specify either language_name or language_code
        /// <br/>you can receive the list of available locations with their language_name by making a separate request to https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if you don’t specify language_name
        /// <br/>Note: it is required to specify either language_name or language_code
        /// <br/>you can receive the list of available locations with their language_code by making a separate request to https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// keyword search depth
        /// <br/>optional field
        /// <br/>default value: 1;
        /// <br/>number of the returned results depends on the value you set in this field;
        /// <br/>you can specify a level from 0 to 4;
        /// <br/>estimated number of keywords for each level (maximum):
        /// <br/>0 – the keyword set in the keyword field
        /// <br/>1 – 6 keywords
        /// <br/>2 – 42 keywords
        /// <br/>3 – 258 keywords
        /// <br/>4 – 1554 keywords
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// include data for the seed keyword
        /// <br/>optional field
        /// <br/>if set to true, data for the seed keyword specified in the keyword field will be provided in the seed_keyword_data array of the response
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_seed_keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeSeedKeyword { get; set; }

        /// <summary>
        /// ignore highly similar keywords
        /// <br/>optional field
        /// <br/>if set to true only core keywords will be returned, all highly similar keywords will be excluded;
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ignore_synonyms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

        /// <summary>
        /// the maximum number of returned keywords
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>maximum value: 1000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned keywords
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify the 10 value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Offset { get; set; }

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