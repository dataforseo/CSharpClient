using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BusinessDataGoogleHotelInfoLiveHtmlRequestInfo 
    {

        /// <summary>
        /// unique hotel identifier
        /// <br/>required field
        /// <br/>unique identifier of a hotel entity in Google search;
        /// <br/>you can obtain the value by making a request to Advanced <see href="/v3/serp/google/organic/overview/">Google SERP API</see> (enclosed in the <c>hotels</c> element of the response), or the <see href="/v3/business_data/google/hotel_searches/task_post/">Hotel Searches endpoint</see> of Business Data API
        /// <br/>example:
        /// <br/><c>ChYIq6SB--i6p6cpGgovbS8wN2s5ODZfEAE</c>
        /// </summary>
        [JsonProperty("hotel_identifier", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string HotelIdentifier { get; set; }

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
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> array of the response
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