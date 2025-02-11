using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataGoogleTrendsExploreTaskPostRequestInfo
    {
        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>The maximum number of keywords you can specify: 5
        /// <br/>comma characters (,) in the specified keywords will be unset and ignored
        /// <br/>Note: to obtain google_trends_topics_list and google_trends_queries_list items, specify no more than 1 keyword
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Keywords { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>optional field
        /// <br/>if you don’t use this field, you will recieve global results
        /// <br/>if you use this field, you don’t need to specify location_code
        /// <br/>you can use this field as an array to set several locations, each corresponding to a specific keyword – learn more;
        /// <br/>you can receive the list of available locations of the search engine with their location_name by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_trends/locations
        /// <br/>example:
        /// <br/>United Kingdom
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>optional field
        /// <br/>if you don’t use this field, you will recieve global results
        /// <br/>if you use this field, you don’t need to specify location_name
        /// <br/>you can use this field as an array to set several locations, each corresponding to a specific keyword – learn more;
        /// <br/>you can receive the list of available locations of the search engines with their location_code by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_trends/locations
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int?> LocationCode { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>optional field
        /// <br/>default value: English
        /// <br/>if you use this field, you don’t need to specify language_code
        /// <br/>you can receive the list of available languages of the search engine with their language_name by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_trends/languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field
        /// <br/>default value: en
        /// <br/>if you use this field, you don’t need to specify language_name
        /// <br/>you can receive the list of available languages of the search engine with their language_code by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_trends/languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// google trends search category
        /// <br/>optional field
        /// <br/>if you don’t specify this field, the 0 value will be applied by default and the search will be carried out across all available categories
        /// <br/>you can receive the list of available categories with their category_code by making a separate request to the https://api.dataforseo.com/v3/keywords_data/google_trends/categories
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CategoryCode { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>if you don’t specify this field, the current day and month of the preceding year will be used by default
        /// <br/>minimal value for the web type: 2004-01-01
        /// <br/>minimal value for other types: 2008-01-01
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2019-01-15"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>if you don’t specify this field, the today’s date will be used by default
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2019-01-15"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// preset time ranges
        /// <br/>optional field
        /// <br/>if you specify date_from or date_to parameters, this field will be ignored when setting a task
        /// <br/>possible values for all type parameters:
        /// <br/>past_hour, past_4_hours, past_day, past_7_days, past_30_days, past_90_days, past_12_months, past_5_years
        /// <br/>possible values for web only:
        /// <br/>2004_present
        /// <br/>possible values for news, youtube, images, froogle:
        /// <br/>2008_present
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_range", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeRange { get; set; }

        /// <summary>
        /// types of items returned
        /// <br/>optional field
        /// <br/>to speed up the execution of the request, specify one item at a time;
        /// <br/>possible values:
        /// <br/>"google_trends_graph", "google_trends_map", "google_trends_topics_list","google_trends_queries_list"
        /// <br/>default value:
        /// <br/>"google_trends_graph"
        /// <br/>Note: to obtain google_trends_topics_list and google_trends_queries_list items, specify no more than 1 keyword in the keywords field
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ItemTypes { get; set; }

        /// <summary>
        /// return URL for sending task results
        /// <br/>optional field
        /// <br/>once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request.
        /// <br/>example:
        /// <br/>http://your-server.com/postbackscript?id=$id
        /// <br/>http://your-server.com/postbackscript?id=$id&amp;tag=$tag
        /// <br/>Note: special characters in postback_url will be urlencoded;
        /// <br/>i.a., the # character will be encoded into %23
        /// <br/>learn more on our Help Center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postback_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostbackUrl { get; set; }

        /// <summary>
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request
        /// <br/>example:
        /// <br/>http://your-server.com/pingscript?id=$id
        /// <br/>http://your-server.com/pingscript?id=$id&amp;tag=$tag
        /// <br/>Note: special characters in pingback_url will be urlencoded;
        /// <br/>i.a., the # character will be encoded into %23
        /// <br/>learn more on our Help Center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pingback_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PingbackUrl { get; set; }

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