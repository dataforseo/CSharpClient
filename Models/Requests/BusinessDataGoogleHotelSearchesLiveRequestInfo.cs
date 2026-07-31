using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BusinessDataGoogleHotelSearchesLiveRequestInfo 
    {

        /// <summary>
        /// keyword
        /// <br/>optional field
        /// <br/>the keyword you specify is used to search for the list of hotels;
        /// <br/>if you don't use this field, we will return the list of hotels found in a specified location;
        /// <br/>you can specify up to 700 characters in the <c>keyword</c> filed
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your <c>keyword</c>, please specify it as “%25”; 
        /// <br/>Note: in order to obtain accurate search results, the location name is appended to the keyword automatically
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations with <c>location_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/business_data/google/locations</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// <br/>Note: in order to obtain accurate search results, the <c>location_name</c> you specify will be automatically appended to the keyword
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
        /// <br/>Note: if the coordinates are used to set a location, the search will occur in the nearest settlement
        /// <br/>example:
        /// <br/><c>53.476225,-2.243572</c>n
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// show hotels from the displayed area
        /// <br/>optional field
        /// <br/>can take the values: <c>true</c>, <c>false</c>
        /// <br/>default value: <c>true</c>
        /// <br/>if set to <c>false</c> the <c>search_this_area</c> mode will be turned off
        /// <br/>Note: if the <c>search_this_area</c> mode is turned off, the <c>location_name</c> won't be appended to the <c>keyword</c> during search
        /// <br/>learn more about this parameter <see href="https://dataforseo.com/help-center/how-to-use-search_this_area-parameter-in-google-hotel-searches">on our Help Center</see>
        /// </summary>
        [JsonProperty("search_this_area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SearchThisArea { get; set; }

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
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results in Google Hotels
        /// <br/>default value: <c>18</c> organic results
        /// <br/>max value: <c>140</c>
        /// <br/>Note: your account will be billed per each 18 organic results regardless of paid listings in the response;
        /// <br/>thus, setting a depth above <c>18</c> may result in additional charges if Google Hotels return more than 18 results;
        /// <br/>if the specified depth is higher than the number of results in the response, the difference will be refunded automatically to your account balance
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// check-in date
        /// <br/>optional field
        /// <br/>if you don't specify this field, tomorrow's date will be used by default;
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2019-01-15'</c>
        /// <br/>Note: the value cannot precede the today's date
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
        /// <br/>Note: the value cannot be less than or equal to <c>check_in</c>;
        /// <br/>the range between <c>check_in</c> and <c>check_out</c> values cannot exceed 30 days
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
        /// <br/>if you don't specify this field, the default value of <c>2</c> will be applied;
        /// <br/>note that you can specify up to 6 persons including both adults and children
        /// <br/>example:
        /// <br/><c>1</c>
        /// </summary>
        [JsonProperty("adults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adults { get; set; }

        /// <summary>
        /// number and age of children
        /// <br/>optional field
        /// <br/>if you don't specify this field, no children will be included in the search;
        /// <br/>age of child can be from <c>0</c> to <c>17</c>;
        /// <br/>note that you can specify up to 6 persons including both adults and children
        /// <br/>set the following value if you want to include one 14-year-old child:
        /// <br/><c>[14]</c>
        /// <br/>set the following value if you want to include one 13-year-old child and one 8-year-old child:
        /// <br/><c>[13,8]</c>
        /// </summary>
        [JsonProperty("children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Children { get; set; }

        /// <summary>
        /// hotel stars
        /// <br/>optional field
        /// <br/>set this field to <c>[5]</c> if you want to get the list of 5-star hotels only
        /// <br/>example:
        /// <br/><c>[3,4,5]</c>
        /// </summary>
        [JsonProperty("stars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Stars { get; set; }

        /// <summary>
        /// minimum rating
        /// <br/>optional field
        /// <br/>you can use this field to specify guest rating higher than a certain value
        /// <br/>example:
        /// <br/><c>2.5</c>
        /// </summary>
        [JsonProperty("min_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MinRating { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>you can use this field to sort the results
        /// <br/>possible types of sorting:
        /// <br/><c>relevance</c> – sort by most relevant
        /// <br/><c>lowest_price</c> – sort by the lowest price
        /// <br/><c>highest_rating</c> – sort by highest rating
        /// <br/><c>most_reviewed</c> – sort by most reviewed
        /// <br/>default value: <c>relevance</c>
        /// </summary>
        [JsonProperty("sort_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// minimum price per night
        /// <br/>optional field
        /// <br/>the currency of this value depends on the <c>currency</c> field
        /// <br/>example:
        /// <br/><c>100</c>
        /// </summary>
        [JsonProperty("min_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MinPrice { get; set; }

        /// <summary>
        /// maximum price per night
        /// <br/>optional field
        /// <br/>the currency of this value depends on the <c>currency</c> field
        /// <br/>example:
        /// <br/><c>600</c>
        /// </summary>
        [JsonProperty("max_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPrice { get; set; }

        /// <summary>
        /// hotels with a free cancellation
        /// <br/>optional field
        /// <br/>set this field to <c>true</c> if you want to get the list of hotels with free cancellation of reservations
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("free_cancellation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FreeCancellation { get; set; }

        /// <summary>
        /// search for vacation rentals
        /// <br/>optional field
        /// <br/>set this field to <c>true</c> if you want to get the list of vacation rentals instead of hotels
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("is_vacation_rentals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVacationRentals { get; set; }

        /// <summary>
        /// hotel amenities
        /// <br/>optional field
        /// <br/>you can use this field to specify different hotel amenities
        /// <br/>example:
        /// <br/><c>[            'free_parking',            'pets_allowed'        ]</c>
        /// <br/>possible values:
        /// <br/>`'air_conditioning',
        /// <br/>'all_inclusive_available',
        /// <br/>'bar',
        /// <br/>'free_breakfast',
        /// <br/>'fitness_center',
        /// <br/>'kid_friendly',
        /// <br/>'free_parking',
        /// <br/>'pets_allowed',
        /// <br/>'pool',
        /// <br/>'restaurant',
        /// <br/>'room_service',
        /// <br/>'spa',
        /// <br/>'free_wifi',
        /// <br/>'parking',
        /// <br/>'indoor_pool',
        /// <br/>'outdoor_pool',
        /// <br/>'wheelchair_accessible',
        /// <br/>'beach_access'`
        /// </summary>
        [JsonProperty("amenities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Amenities { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
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