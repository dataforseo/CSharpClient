using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BusinessDataGoogleHotelInfoTaskPostRequestInfo 
    {

        /// <summary>
        /// unique hotel identifier
        /// <br/>required field if you don't specify <c>keyword</c>
        /// <br/>if you use this field, you don't need to specify <c>keyword</c>
        /// <br/>unique identifier of a hotel entity in Google search;
        /// <br/>you can obtain the value by making a request to Advanced <see href="/v3/serp/google/organic/overview/">Google SERP API</see> (enclosed in the <c>hotels_pack</c> element of the response), or the <see href="/v3/business_data/google/hotel_searches/task_post/">Hotel Searches endpoint</see> of Business Data API
        /// <br/>example:
        /// <br/><c>ChYIq6SB--i6p6cpGgovbS8wN2s5ODZfEAE</c>
        /// </summary>
        [JsonProperty("hotel_identifier", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string HotelIdentifier { get; set; }

        /// <summary>
        /// keyword
        /// <br/>required field if you don't specify <c>hotel_identifier</c>
        /// <br/>if you use this field, you don't need to specify <c>hotel_identifier</c>
        /// <br/>the keyword you specify should indicate the name of the hotel entity
        /// <br/>you can specify up to 700 characters in the <c>keyword</c> filed
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your <c>keyword</c>, please specify it as “%25”
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// task priority
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/>1 – normal execution priority (set by default)
        /// <br/>2 – high execution priorityYou will be additionally charged for the tasks with high execution priority.
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/business-data/google-hotels-api">Pricing</see> page.
        /// </summary>
        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations with <c>location_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/business_data/google/locations</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c>_or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations with <c>location_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/business_data/google/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>n
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don't specify <c>location_name</c>_or <c>location_code</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_code</c>
        /// <br/><c>location_coordinate</c> parameter should be specified in the 'latitude,longitude' format
        /// <br/>the maximum number of decimal digits for 'latitude' and 'longitude': 7
        /// <br/>Note: if the coordinates are used to set a location, the search will occur in the nearest settlement;
        /// <br/>example:
        /// <br/><c>53.476225,-2.243572</c>n
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages with <c>language_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/business_data/google/languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c>_by making a separate request to <c>https://api.dataforseo.com/v3/business_data/google/languages</c>
        /// <br/>example:
        /// <br/><c>en</c>n
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// check-in date
        /// <br/>optional field
        /// <br/>if you don't specify this field, tomorrow's date will be used by default;
        /// <br/>the value must not be earlier than today's date
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2019-01-15'</c>
        /// </summary>
        [JsonProperty("check_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckIn { get; set; }

        /// <summary>
        /// check-out date
        /// <br/>optional field
        /// <br/>if you don't specify this field, our system will apply the date of two days from now by default;
        /// <br/>Note: the value cannot be less than or equal to <c>check_in</c>;
        /// <br/>the range between <c>check_in</c> and <c>check_out</c> values cannot exceed 30 days
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2019-01-15'</c>
        /// </summary>
        [JsonProperty("check_out", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckOut { get; set; }

        /// <summary>
        /// currency
        /// <br/>optional field
        /// <br/>example:
        /// <br/><c>'USD'</c>
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// number of adults
        /// <br/>optional field
        /// <br/>if you don't specify this field, two adults will be used by default
        /// <br/>example:
        /// <br/><c>1</c>
        /// </summary>
        [JsonProperty("adults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adults { get; set; }

        /// <summary>
        /// number and age of children
        /// <br/>optional field
        /// <br/>if you don't specify this field, no children will be included in the search;
        /// <br/>set the following value if you want to include one 14-years-old child:
        /// <br/><c>[14]</c>
        /// <br/>set the following value if you want to include one 13-years-old child and one 8-years-old child:
        /// <br/><c>[13,8]</c>
        /// </summary>
        [JsonProperty("children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Children { get; set; }

        /// <summary>
        /// load hotel stay prices by dates
        /// <br/>optional field
        /// <br/>if you specify this parameter with <c>true</c>, the response will include the <c>prices_by_dates</c> array with hotel stay prices divided by dates
        /// <br/>if you use this parameter, you will be charged double the base price for a request
        /// </summary>
        [JsonProperty("load_prices_by_dates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoadPricesByDates { get; set; }

        /// <summary>
        /// start date to load prices by dates
        /// <br/>optional field
        /// <br/>to use this parameter, you must specify <c>load_prices_by_dates</c> with <c>true</c>
        /// <br/>if this parameter is not specified, the start date is set to <c>check_in</c> date
        /// <br/>date format: <c>yyyy-mm-dd</c>
        /// <br/>example:
        /// <br/><c>2025-05-20</c>
        /// </summary>
        [JsonProperty("prices_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PricesStartDate { get; set; }

        /// <summary>
        /// end date to load prices by dates
        /// <br/>optional field
        /// <br/>to use this parameter, you must specify <c>load_prices_by_dates</c> with <c>true</c>
        /// <br/>if this parameter is not specified, you will get prices by date for the month 
        /// <br/>date format: <c>yyyy-mm-dd</c>
        /// <br/>example:
        /// <br/><c>2025-05-21</c>
        /// </summary>
        [JsonProperty("prices_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PricesEndDate { get; set; }

        /// <summary>
        /// predefined period for retrieving daily price data
        /// <br/>optional field
        /// <br/>to use this parameter, you must specify <c>load_prices_by_dates</c> with <c>true</c>
        /// <br/>if the <c>prices_start_date</c>is not specified, the start date is set to <c>check_in</c> date
        /// <br/>possible values: <c>month</c>, <c>three_months</c>, <c>six_months</c>, <c>year</c>
        /// <br/>default value: <c>month</c>
        /// </summary>
        [JsonProperty("prices_date_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PricesDateRange { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255;
        /// <br/>you can use this parameter to identify the task and match it with the result;
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// URL for sending task results
        /// <br/>optional field
        /// <br/>once the task is completed, we will send a POST request with its results compressed in the <c>gzip</c> format to the <c>postback_url</c> you specified;
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request;
        /// <br/>example:
        /// <br/><c>http://your-server.com/postbackscript?id=$id</c>
        /// <br/><c>http://your-server.com/postbackscript?id=$id&amp;tag=$tag</c>
        /// <br/>Note: special characters in <c>postback_url</c> will be urlencoded; 
        /// <br/>i.a., the <c>#</c> character will be encoded into <c>%23</c>
        /// <br/>learn more on our <see href="https://dataforseo.com/help-center/pingbacks-postbacks-with-dataforseo-api">Help Center</see>
        /// </summary>
        [JsonProperty("postback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackUrl { get; set; }

        /// <summary>
        /// postback_url datatype
        /// <br/>required field if you specify <c>postback_url</c>
        /// <br/>corresponds to the datatype that will be sent to your server
        /// <br/>possible values:
        /// <br/><c>advanced</c>, <c>html</c>
        /// </summary>
        [JsonProperty("postback_data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackData { get; set; }

        /// <summary>
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified;
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable;
        /// <br/>we will set the necessary values before sending the request;
        /// <br/>example:
        /// <br/><c>http://your-server.com/pingscript?id=$id</c>
        /// <br/><c>http://your-server.com/pingscript?id=$id&amp;tag=$tag</c>
        /// <br/>Note: special characters in <c>pingback_url</c> will be urlencoded; 
        /// <br/>i.a., the <c>#</c> character will be encoded into <c>%23</c>
        /// <br/>learn more on our <see href="https://dataforseo.com/help-center/pingbacks-postbacks-with-dataforseo-api">Help Center</see>
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