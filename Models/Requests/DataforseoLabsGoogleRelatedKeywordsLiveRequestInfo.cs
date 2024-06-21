using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo
    {
        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>UTF-8 encoding
        /// <br/>a keyword should be at least 3 characters long;
        /// <br/>the keywords will be converted to lowercase format
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don’t specify location_code
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_name by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>United Kingdom
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if you don’t specify location_name
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_code by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don’t specify language_code
        /// <br/>Note: it is required to specify either language_name or language_code
        /// <br/>you can receive the list of available locations with their language_name by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if you don’t specify language_name
        /// <br/>Note: it is required to specify either language_name or language_code
        /// <br/>you can receive the list of available locations with their language_code by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// keyword search depth
        /// <br/>optional field
        /// <br/>default value: 1
        /// <br/>number of the returned results depends on the value you set in this field
        /// <br/>you can specify a level from 0 to 4
        /// <br/>estimated number of keywords for each level (maximum):
        /// <br/>0 – the keyword set in the keyword field
        /// <br/>1 – 8 keywords
        /// <br/>2 – 72 keywords
        /// <br/>3 – 584 keywords
        /// <br/>4 – 4680 keywords
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
        /// include data from SERP for each keyword
        /// <br/>optional field
        /// <br/>if set to true, we will return a serp_info array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the response
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_serp_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeSerpInfo { get; set; }

        /// <summary>
        /// include or exclude data from clickstream-based metrics in the result
        /// <br/>optional field
        /// <br/>if the parameter is set to true, you will receive clickstream_keyword_info object with clickstream data in the response
        /// <br/>default value: false
        /// <br/>with this parameter enabled, you will be charged double the price for the request
        /// <br/>Note: clickstream data is available for roughly 15% of keywords in the response
        /// <br/>learn more about how clickstream-based metrics are calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_clickstream_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

        /// <summary>
        /// ignore highly similar keywords
        /// <br/>optional field
        /// <br/>if set to true only core keywords will be returned, all highly similar keywords will be excluded;
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ignore_synonyms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

        /// <summary>
        /// return data for core keyword
        /// <br/>optional field
        /// <br/>if true, serp_info and related_keywords will be returned for the main keyword in the group that the specified keyword belongs to;
        /// <br/>if false, serp_info and related_keywords will be returned for the specified keyword (if available);
        /// <br/>refer to this help center article for more details;
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("replace_with_core_keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ReplaceWithCoreKeyword { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like,not_like
        /// <br/>you can use the % operator with like and not_like to match any string of zero or more characters
        /// <br/>example:
        /// <br/>["keyword_data.keyword_info.search_volume","&gt;",0]
        /// <br/>[["keyword_info.search_volume","in",[0,1000]],
        /// <br/>"and",
        /// <br/>["keyword_data.keyword_info.competition_level","=","LOW"]]
        /// <br/>[["keyword_data.keyword_info.search_volume","&gt;",100],
        /// <br/>"and",
        /// <br/>[["keyword_data.keyword_info.cpc","&lt;",0.5],
        /// <br/>"or",
        /// <br/>["keyword_info.high_top_of_page_bid","&lt;=",0.5]]]
        /// <br/>for more information about filters, please refer to Dataforseo Labs – Filters or this help center guide
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the filters array to sort the results
        /// <br/>possible sorting types:
        /// <br/>asc – results will be sorted in the ascending order
        /// <br/>desc – results will be sorted in the descending order
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/>["keyword_data.keyword_info.competition,desc"]
        /// <br/>default rule:
        /// <br/>["keyword_data.keyword_info.search_volume,desc"]
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>["keyword_data.keyword_info.search_volume,desc","keyword_data.keyword_info.cpc,desc"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> OrderBy { get; set; }

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