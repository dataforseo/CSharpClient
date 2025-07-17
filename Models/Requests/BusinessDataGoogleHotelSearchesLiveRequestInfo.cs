using Newtonsoft.Json;
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
        /// <br/>if you don’t use this field, we will return the list of hotels found in a specified location;
        /// <br/>you can specify up to 700 characters in the keyword filed
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your keyword, please specify it as “%25”;
        /// <br/>Note: in order to obtain accurate search results, the location name is appended to the keyword automatically
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don’t specify location_code or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_code or location_coordinate
        /// <br/>you can receive the list of available locations with location_name by making a separate request to https://api.dataforseo.com/v3/business_data/google/locations
        /// <br/>example:
        /// <br/>London,England,United Kingdom
        /// <br/>Note: in order to obtain accurate search results, the location_name you specify will be automatically appended to the keyword
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
        /// <br/>Note: if the coordinates are used to set a location, the search will occur in the nearest settlement
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
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results in Google Hotels
        /// <br/>default value: 20 organic results
        /// <br/>max value: 140
        /// <br/>Note: your account will be billed per each 20 organic results regardless of paid listings in the response;
        /// <br/>thus, setting a depth above 20 may result in additional charges if Google Hotels return more than 20 results;
        /// <br/>if the specified depth is higher than the number of results in the response, the difference will be refunded automatically to your account balance
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// check-in date
        /// <br/>optional field
        /// <br/>if you don’t specify this field, tomorrow’s date will be used by default;
        /// <br/>date format: 'yyyy-mm-dd'
        /// <br/>example:
        /// <br/>'2019-01-15'
        /// <br/>Note: the value cannot precede the today’s date
        /// </summary>
        [JsonProperty("check_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckIn { get; set; }

        /// <summary>
        /// check-out date
        /// <br/>optional field
        /// <br/>if you don’t specify this field, our system will apply the date of two days from now by default;
        /// <br/>date format: 'yyyy-mm-dd'
        /// <br/>example:
        /// <br/>'2019-01-15'
        /// <br/>Note: the value cannot be less than or equal to check_in;
        /// <br/>the range between check_in and check_out values cannot exceed 30 days
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
        /// <br/>if you don’t specify this field, the default value of 2 will be applied;
        /// <br/>note that you can specify up to 6 persons including both adults and children
        /// <br/>example:
        /// <br/>1
        /// </summary>
        [JsonProperty("adults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adults { get; set; }

        /// <summary>
        /// number and age of children
        /// <br/>optional field
        /// <br/>if you don’t specify this field, no children will be included in the search;
        /// <br/>age of child can be from 0 to 17;
        /// <br/>note that you can specify up to 6 persons including both adults and children
        /// <br/>set the following value if you want to include one 14-year-old child:
        /// <br/>[14]
        /// <br/>set the following value if you want to include one 13-year-old child and one 8-year-old child:
        /// <br/>[13,8]
        /// </summary>
        [JsonProperty("children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Children { get; set; }

        /// <summary>
        /// hotel stars
        /// <br/>optional field
        /// <br/>set this field to [5] if you want to get the list of 5-star hotels only
        /// <br/>example:
        /// <br/>[3,4,5]
        /// </summary>
        [JsonProperty("stars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Stars { get; set; }

        /// <summary>
        /// minimum rating
        /// <br/>optional field
        /// <br/>you can use this field to specify guest rating higher than a certain value
        /// <br/>example:
        /// <br/>2.5
        /// </summary>
        [JsonProperty("min_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MinRating { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>you can use this field to sort the results
        /// <br/>possible types of sorting:
        /// <br/>relevance – sort by most relevant
        /// <br/>lowest_price – sort by the lowest price
        /// <br/>highest_rating – sort by highest rating
        /// <br/>most_reviewed – sort by most reviewed
        /// <br/>default value: relevance
        /// </summary>
        [JsonProperty("sort_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// minimum price per night
        /// <br/>optional field
        /// <br/>the currency of this value depends on the currency field
        /// <br/>example:
        /// <br/>100
        /// </summary>
        [JsonProperty("min_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MinPrice { get; set; }

        /// <summary>
        /// maximum price per night
        /// <br/>optional field
        /// <br/>the currency of this value depends on the currency field
        /// <br/>example:
        /// <br/>600
        /// </summary>
        [JsonProperty("max_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPrice { get; set; }

        /// <summary>
        /// hotels with a free cancellation
        /// <br/>optional field
        /// <br/>set this field to true if you want to get the list of hotels with free cancellation of reservations
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("free_cancellation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FreeCancellation { get; set; }

        /// <summary>
        /// search for vacation rentals
        /// <br/>optional field
        /// <br/>set this field to true if you want to get the list of vacation rentals instead of hotels
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("is_vacation_rentals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVacationRentals { get; set; }

        /// <summary>
        /// hotel amenities
        /// <br/>optional field
        /// <br/>you can use this field to specify different hotel amenities
        /// <br/>example:
        /// <br/>  [
        /// <br/>            'free_parking',
        /// <br/>            'pets_allowed'
        /// <br/>        ]
        /// <br/>
        /// <br/>possible values:
        /// <br/>'air_conditioning',
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
        /// <br/>'beach_access'
        /// </summary>
        [JsonProperty("amenities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Amenities { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
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