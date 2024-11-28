using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataBingKeywordPerformanceLiveRequestInfo
    {
        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>The maximum number of keywords you can specify: 1000
        /// <br/>The maximum number of characters for each keyword: 80
        /// <br/>The maximum number of words for each keyword phrase: 10
        /// <br/>the specified keywords will be converted to lowercase, data will be provided in a separate array
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Keywords { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>specify this field if you want to get the data for a particular device typepossible values: desktop, mobile, tablet, all
        /// <br/>default value: all
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// keywords match type
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/>aggregate returns data across all match types;
        /// <br/>broad returns data for all user queries containing the specified keyword with varying word order;
        /// <br/>phrase returns data for all user queries containing the specified keyword with identical word order;
        /// <br/>exact returns data for user query that matches the specified keyword;Note: the aggregate match type is applied by default
        /// </summary>
        [Newtonsoft.Json.JsonProperty("match", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Match { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don’t specify location_code or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_code or location_coordinate
        /// <br/>you can receive the list of available locations and languages by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages
        /// <br/>example:
        /// <br/>"United States"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don’t specify location_name or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_name or location_coordinate
        /// <br/>you can receive the list of available locations and languages by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don’t specify location_name or location_code
        /// <br/>if you use this field, you don’t need to specify location_name or location_code
        /// <br/>location_coordinate parameter should be specified in the “latitude,longitude” format
        /// <br/>the data will be provided for the country the specified coordinates belong to
        /// <br/>example:
        /// <br/>52.6178549,-155.352142
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_coordinate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don’t specify language_code
        /// <br/>if you use this field, you don’t need to specify language_code
        /// <br/>you can receive the list of available locations and languages by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don’t specify language_name
        /// <br/>you can receive the list of available locations and languages by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages
        /// <br/>example:
        /// <br/>"en"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

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