using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleLocalFinderTaskPostRequestInfo 
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
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don’t specify location_code or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_code or location_coordinate
        /// <br/>you can receive the list of available locations of the search engine with their location_name by making a separate request to the https://api.dataforseo.com/v3/serp/google/locations
        /// <br/>example:
        /// <br/>London,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don’t specify location_name or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_name or location_coordinate
        /// <br/>you can receive the list of available locations of the search engines with their location_code by making a separate request to the https://api.dataforseo.com/v3/serp/google/locations
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don’t specify location_name or location_code
        /// <br/>if you use this field, you don’t need to specify location_name or location_code
        /// <br/>location_coordinate parameter should be specified in the “latitude,longitude,zoom” format
        /// <br/>if “zoom” is not specified, 9z will be applied as a default value
        /// <br/>the maximum number of decimal digits for “latitude” and “longitude”: 7
        /// <br/>the minimum value for “zoom”: 4z
        /// <br/>the maximum value for “zoom”: 18z
        /// <br/>example:
        /// <br/>52.6178549,-155.352142,18z
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don’t specify language_code
        /// <br/>if you use this field, you don’t need to specify language_code
        /// <br/>you can receive the list of available languages of the search engine with their language_name by making a separate request to the https://api.dataforseo.com/v3/serp/google/languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don’t specify language_name
        /// <br/>if you use this field, you don’t need to specify language_name
        /// <br/>you can receive the list of available languages of the search engine with their language_code by making a separate request to the https://api.dataforseo.com/v3/serp/google/languages
        /// <br/>example:en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>can take the values:desktop, mobile
        /// <br/>default value: desktop
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// device operating system
        /// <br/>optional field
        /// <br/>if you specify desktop in the device field, choose from the following values: windows, macos
        /// <br/>default value: windows
        /// <br/>if you specify mobile in the device field, choose from the following values: android, ios
        /// <br/>default value: android
        /// </summary>
        [JsonProperty("os", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results in SERP
        /// <br/>default value for desktop: 20
        /// <br/>max value for desktop: 500default value for mobile: 10
        /// <br/>max value for mobile: 350
        /// <br/>Note: your account will be billed per each SERP containing up to 20 results for desktop or up to 10 results for a mobile device;
        /// <br/>thus, setting a depth above 20 for desktop or above 10 for mobile may result in additional charges if the search engine returns more than 20 or 10 results respectively;
        /// <br/>if the specified depth is higher than the number of results in the response, the difference will be refunded to your account balance automatically
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// filter results by minimum rating
        /// <br/>optional field
        /// <br/>possible values for desktop: 3.5, 4, 4.5;
        /// <br/>possible values for mobile: 2, 2.5, 3, 3.5, 4, 4.5
        /// </summary>
        [JsonProperty("min_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MinRating { get; set; }

        /// <summary>
        /// filter results by open hours
        /// <br/>optional field
        /// <br/>using this field, you can filter places in the results by the time a place is open for visitors
        /// <br/>note that Google may also provide results that do not match this filter
        /// <br/>possible values: 'open_now', '24_hours', '$day_value', '$day_value;$time_value';
        /// <br/>instead of $day_value use one of these values: 'monday', 'tuesday', 'wednesday', 'thursday', 'friday', 'saturday', 'sunday';
        /// <br/>instead of $time_value use one of these values: '00', '01', '02', '03', '04', '05', '06', '07', '08', '09', '10', '11', '12', '13', '14', '15', '16', '17', '18', '19', '20', '21', '22', '23'
        /// <br/>example: 'tuesday;18'
        /// </summary>
        [JsonProperty("time_filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TimeFilter { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("postback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackUrl { get; set; }

        /// <summary>
        /// postback_url datatype
        /// <br/>required field if you specify postback_url
        /// <br/>corresponds to the function you used for setting a task
        /// <br/>possible values:
        /// <br/>advanced, html
        /// </summary>
        [JsonProperty("postback_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("pingback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PingbackUrl { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}