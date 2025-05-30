using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BusinessDataGoogleHotelInfoTaskPostRequestInfo 
    {

        /// <summary>
        /// unique hotel identifier
        /// <br/>required field if you don’t specify keyword
        /// <br/>if you use this field, you don’t need to specify keyword
        /// <br/>unique identifier of a hotel entity in Google search;
        /// <br/>you can obtain the value by making a request to Advanced Google SERP API (enclosed in the hotels_pack element of the response), or the Hotel Searches endpoint of Business Data API
        /// <br/>example:
        /// <br/>ChYIq6SB--i6p6cpGgovbS8wN2s5ODZfEAE
        /// </summary>
        [JsonProperty("hotel_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HotelIdentifier { get; set; }

        /// <summary>
        /// keyword
        /// <br/>required field if you don’t specify hotel_identifier
        /// <br/>if you use this field, you don’t need to specify hotel_identifier
        /// <br/>the keyword you specify should indicate the name of the hotel entity
        /// <br/>you can specify up to 700 characters in the keyword filed
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your keyword, please specify it as “%25”
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
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
        /// <br/>you can receive the list of available locations with location_name by making a separate request to https://api.dataforseo.com/v3/business_data/google/locations
        /// <br/>example:
        /// <br/>London,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don’t specify location_name or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_name or location_coordinate
        /// <br/>you can receive the list of available locations with location_code by making a separate request to the https://api.dataforseo.com/v3/business_data/google/locations
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don’t specify location_name or location_code
        /// <br/>if you use this field, you don’t need to specify location_name or location_code
        /// <br/>location_coordinate parameter should be specified in the “latitude,longitude” format
        /// <br/>the maximum number of decimal digits for “latitude” and “longitude”: 7
        /// <br/>Note: if the coordinates are used to set a location, the search will occur in the nearest settlement;
        /// <br/>example:
        /// <br/>53.476225,-2.243572
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don’t specify language_code
        /// <br/>if you use this field, you don’t need to specify language_code
        /// <br/>you can receive the list of available languages with language_name by making a separate request to https://api.dataforseo.com/v3/business_data/google/languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don’t specify language_name
        /// <br/>if you use this field, you don’t need to specify language_name
        /// <br/>you can receive the list of available languages with their language_code by making a separate request to https://api.dataforseo.com/v3/business_data/google/languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// check-in date
        /// <br/>optional field
        /// <br/>if you don’t specify this field, tomorrow’s date will be used by default;
        /// <br/>the value must not be earlier than today’s date
        /// <br/>date format: 'yyyy-mm-dd'
        /// <br/>example:
        /// <br/>'2019-01-15'
        /// </summary>
        [JsonProperty("check_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckIn { get; set; }

        /// <summary>
        /// check-out date
        /// <br/>optional field
        /// <br/>if you don’t specify this field, our system will apply the date of two days from now by default;
        /// <br/>Note: the value cannot be less than or equal to check_in;
        /// <br/>the range between check_in and check_out values cannot exceed 30 days
        /// <br/>date format: 'yyyy-mm-dd'
        /// <br/>example:
        /// <br/>'2019-01-15'
        /// </summary>
        [JsonProperty("check_out", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckOut { get; set; }

        /// <summary>
        /// currency
        /// <br/>optional field
        /// <br/>example:
        /// <br/>'USD'
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// number of adults
        /// <br/>optional field
        /// <br/>if you don’t specify this field, two adults will be used by default
        /// <br/>example:
        /// <br/>1
        /// </summary>
        [JsonProperty("adults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adults { get; set; }

        /// <summary>
        /// number and age of children
        /// <br/>optional field
        /// <br/>if you don’t specify this field, no children will be included in the search;
        /// <br/>set the following value if you want to include one 14-years-old child:
        /// <br/>[14]
        /// <br/>set the following value if you want to include one 13-years-old child and one 8-years-old child:
        /// <br/>[13,8]
        /// </summary>
        [JsonProperty("children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Children { get; set; }

        /// <summary>
        /// load hotel stay prices by dates
        /// <br/>optional field
        /// <br/>if you specify this parameter with true, the response will include the prices_by_dates array with hotel stay prices divided by dates
        /// <br/>if you use this parameter, you will be charged double the base price for a request
        /// </summary>
        [JsonProperty("load_prices_by_dates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoadPricesByDates { get; set; }

        /// <summary>
        /// start date to load prices by dates
        /// <br/>optional field
        /// <br/>to use this parameter, you must specify load_prices_by_dates with true
        /// <br/>if this parameter is not specified, the start date is set to check_in date
        /// <br/>date format: yyyy-mm-dd
        /// <br/>example:
        /// <br/>2025-05-20
        /// </summary>
        [JsonProperty("prices_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PricesStartDate { get; set; }

        /// <summary>
        /// end date to load prices by dates
        /// <br/>optional field
        /// <br/>to use this parameter, you must specify load_prices_by_dates with true
        /// <br/>if this parameter is not specified, you will get prices by date for the month
        /// <br/>date format: yyyy-mm-dd
        /// <br/>example:
        /// <br/>2025-05-21
        /// </summary>
        [JsonProperty("prices_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PricesEndDate { get; set; }

        /// <summary>
        /// predefined period for retrieving daily price data
        /// <br/>optional field
        /// <br/>to use this parameter, you must specify load_prices_by_dates with true
        /// <br/>if the prices_start_date is not specified, the start date is set to check_in date
        /// <br/>possible values: month, three_months, six_months, year
        /// <br/>default value: month
        /// </summary>
        [JsonProperty("prices_date_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PricesDateRange { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255;
        /// <br/>you can use this parameter to identify the task and match it with the result;
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// return URL for sending task results
        /// <br/>optional field
        /// <br/>once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified;
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request;
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
        /// <br/>corresponds to the datatype that will be sent to your server
        /// <br/>possible values:
        /// <br/>advanced, html
        /// </summary>
        [JsonProperty("postback_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackData { get; set; }

        /// <summary>
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified;
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable;
        /// <br/>we will set the necessary values before sending the request;
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