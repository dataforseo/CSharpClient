using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo
    {
        /// <summary>
        /// domain or page
        /// <br/>required field
        /// <br/>the domain name of the target website or the url of the target page;
        /// <br/>note: to obtain keywords for the target website, use the target_type parameter
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// search keywords for site or url
        /// <br/>optional field
        /// <br/>possible values: site, page;
        /// <br/>default value: page
        /// <br/>if set to site, keywords will be provided for the entire site;
        /// <br/>if set to page, keywords will be provided for the specified webpage
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TargetType { get; set; }

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
        /// <br/>Note: the indicated date cannot be greater than yesterday’s date;
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
        /// <br/>if set to true, adult keywords will be included in the response
        /// <br/>default value: false
        /// <br/>note that the API may return no data for such keywords due to Google Ads restrictions
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_adult_keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeAdultKeywords { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>Use these parameters to sort the results by relevance, search_volume, competition_index, low_top_of_page_bid, or high_top_of_page_bid in descending order
        /// <br/>default value: relevance
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SortBy { get; set; }

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
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request
        /// <br/>example:
        /// <br/>http://your-server.com/pingscript?id=$id
        /// <br/>http://your-server.com/pingscript?id=$id&amp;tag=$tag
        /// <br/>Note: special symbols in pingback_url will be urlencoded;
        /// <br/>i.a., the # symbol will be encoded into %23
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