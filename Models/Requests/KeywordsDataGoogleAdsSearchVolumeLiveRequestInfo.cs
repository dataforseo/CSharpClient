using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataGoogleAdsSearchVolumeLiveRequestInfo
    {
        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>The maximum number of keywords you can specify: 1000
        /// <br/>The maximum number of characters for each keyword: 80
        /// <br/>The maximum number of words for each keyword phrase: 10
        /// <br/>the keywords you specify will be converted to a lowercase format
        /// <br/>Note #1: Google Ads may return no data for certain groups of keywords;
        /// <br/>Note #2: Google Ads provides combined search volume values for groups of similar keywords
        /// <br/>to obtain search volume for similar keywords, we recommend submitting such keywords in separate requests;
        /// <br/>Note #3: Google Ads doesn’t allow using certain symbols and characters (e.g., UTF symbols, emojis), so you can’t use them when setting a task;
        /// <br/>to learn more about which symbols and characters can be used, please refer to this article
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Keywords { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>optional field
        /// <br/>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
        /// <br/>if you use this field, you don’t need to specify location_code or location_coordinate
        /// <br/>you can receive the list of available locations of the search engine with their location_name by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/locations
        /// <br/>example:
        /// <br/>London,England,United Kingdom
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>optional field
        /// <br/>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
        /// <br/>if you use this field, you don’t need to specify location_name or location_coordinate;
        /// <br/>you can receive the list of available locations of the search engines with their location_code by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/locations
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>optional field
        /// <br/>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
        /// <br/>if you use this field, you don’t need to specify location_name or location_code;
        /// <br/>location_coordinate parameter should be specified in the “latitude,longitude” format;
        /// <br/>the data will be provided for the country the specified coordinates belong to;
        /// <br/>example:
        /// <br/>52.6178549,-155.352142
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_coordinate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their language_name by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their language_code by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// include Google search partners
        /// <br/>optional field
        /// <br/>if you specify true, the results will be delivered for owned, operated, and syndicated networks across Google and partner sites that host Google search;
        /// <br/>default value: false – results are returned for Google search sites
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_partners", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SearchPartners { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>minimal value: 4 years from the current date
        /// <br/>by default, data is returned for the past 12 months;
        /// <br/>Note: the indicated date cannot be greater than that specified in date_to and/or yesterday’s date;if Status endpoint returns false in the actual_data field, date_from can be set to the month before last and prior;
        /// <br/>if Status endpoint returns true in the actual_data field, date_from can be set to the last month and prior
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>Note: the indicated date cannot be greater than the past month, Google Ads does not return data on the current month;
        /// <br/>if you don’t specify this field, yesterday’s date will be used by default
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2022-11-30"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// include keywords associated with adult content
        /// <br/>optional field
        /// <br/>if set to true, adult keywords will be included in the response
        /// <br/>default value: false
        /// <br/>note that the API may return no data for such keywords due to Google Ads restrictions
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_adult_keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeAdultKeywords { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>use these parameters to sort the results by relevance, search_volume, competition_index, low_top_of_page_bid, or high_top_of_page_bid in the descending order
        /// <br/>default value: relevance
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data array of the response
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