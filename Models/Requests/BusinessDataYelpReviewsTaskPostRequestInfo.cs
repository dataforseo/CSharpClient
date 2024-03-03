using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessDataYelpReviewsTaskPostRequestInfo
    {
        /// <summary>
        /// unique business identifier
        /// <br/>required field if you don’t specify keyword
        /// <br/>if you use this field, you don’t need to specify keyword
        /// <br/>unique business identifier on Yelp;
        /// <br/>you can find this identifier in the URL of every business listed on Yelp
        /// <br/>example:
        /// <br/>vatos-urban-tacos-singapore
        /// <br/>https://www.yelp.com/biz/vatos-urban-tacos-singapore?rl=en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// keyword
        /// <br/>required field if you don’t specify alias
        /// <br/>if you use this field, you don’t need to specify alias
        /// <br/>you can specify up to 700 symbols in the keyword filed;
        /// <br/>all %## will be decoded (plus symbol ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” symbol for your keyword, please specify it as “%25”
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// task priority
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/>1 – normal execution priority (set by default)
        /// <br/>2 – high execution priority
        /// <br/>You will be additionally charged for the tasks with high execution priority.
        /// <br/>The cost can be calculated on the Pricing page.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don’t specify location_code or alias
        /// <br/>if you use this field, you don’t need to specify location_code
        /// <br/>you can receive the list of available locations of the search engine with their location_name by making a separate request to https://api.dataforseo.com/v3/business_data/yelp/locations
        /// <br/>example:
        /// <br/>West Los Angeles,California,United States
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don’t specify location_name or alias
        /// <br/>if you use this field, you don’t need to specify location_name
        /// <br/>you can receive the list of available locations of the search engines with their location_code by making a separate request to https://api.dataforseo.com/v3/business_data/yelp/locations
        /// <br/>example:
        /// <br/>9061121
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify language_code
        /// <br/>you can receive the list of available languages with language_name by making a separate request to https://api.dataforseo.com/v3/business_data/yelp/languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify language_name
        /// <br/>you can receive the list of available languages with their language_code by making a separate request to https://api.dataforseo.com/v3/business_data/yelp/languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of reviews in SERP
        /// <br/>we strongly recommend setting the parsing depth in the multiples of ten, because our systems processes ten reviews in a row
        /// <br/>default value: 10
        /// <br/>maximum value: 4490
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>you can use this field to sort the results
        /// <br/>possible types of sorting:
        /// <br/>newest – sort by newest first
        /// <br/>highest_rating – sort by highest rating
        /// <br/>lowest_rating – sort by lowest rating
        /// <br/>relevant – sort by relevance
        /// <br/>elites – sort by elite Yelp users first
        /// <br/>default value: relevant
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// return URL for sending task results
        /// <br/>optional field
        /// <br/>once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request.
        /// <br/>example:
        /// <br/>http://your-server.com/postbackscript?id=$id
        /// <br/>http://your-server.com/postbackscript?id=$id&amp;tag=$tag
        /// <br/>Note: special symbols in postback_url will be urlencoded;
        /// <br/>i.a., the # symbol will be encoded into %23
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postback_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostbackUrl { get; set; }

        /// <summary>
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request.
        /// <br/>example:
        /// <br/>http://your-server.com/pingscript?id=$id
        /// <br/>http://your-server.com/pingscript?id=$id&amp;tag=$tag
        /// <br/>Note: special symbols in pingback_url will be urlencoded;
        /// <br/>i.a., the # symbol will be encoded into %23
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pingback_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PingbackUrl { get; set; }

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