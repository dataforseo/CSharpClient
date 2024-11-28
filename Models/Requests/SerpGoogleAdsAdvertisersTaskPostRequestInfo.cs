using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SerpGoogleAdsAdvertisersTaskPostRequestInfo
    {
        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 700 characters in the keyword field
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your keyword, please specify it as “%25”;
        /// <br/>if you need to use the “+” character for your keyword, please specify it as “%2B”
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don’t specify location_code or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_code or location_coordinate
        /// <br/>you can receive the list of available locations of the search engine with their location_name by making a separate request to the https://api.dataforseo.com/v3/serp/google/ads_advertisers/locations
        /// <br/>example:
        /// <br/>London,England,United Kingdom
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don’t specify location_name or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_name or location_coordinate
        /// <br/>you can receive the list of available locations of the search engines with their location_code by making a separate request to the https://api.dataforseo.com/v3/serp/google/ads_advertisers/locations
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don’t specify location_name or location_code
        /// <br/>if you use this field, you don’t need to specify location_name or location_code
        /// <br/>example:
        /// <br/>52.6178549,-155.352142
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_coordinate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

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
        /// <br/>Note: special characters in postback_url will be urlencoded;
        /// <br/>i.a., the # character will be encoded into %23
        /// <br/>learn more on our Help Center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postback_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostbackUrl { get; set; }

        /// <summary>
        /// postback_url datatype
        /// <br/>required field if you specify postback_url
        /// <br/>corresponds to the function you used for setting a task
        /// <br/>possible values:
        /// <br/>advanced
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postback_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostbackData { get; set; }

        /// <summary>
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request.
        /// <br/>example:
        /// <br/>http://your-server.com/pingscript?id=$id
        /// <br/>http://your-server.com/pingscript?id=$id&amp;tag=$tag
        /// <br/>Note: special characters in pingback_url will be urlencoded;
        /// <br/>i.a., the # character will be encoded into %23
        /// <br/>learn more on our Help Center
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