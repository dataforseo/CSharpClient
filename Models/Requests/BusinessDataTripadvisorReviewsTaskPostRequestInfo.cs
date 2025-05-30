using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BusinessDataTripadvisorReviewsTaskPostRequestInfo 
    {

        /// <summary>
        /// URL path of the business entity
        /// <br/>required field if you do not specify keyword
        /// <br/>URL path to the Tripadvisor page of the business entity;
        /// <br/>examples:
        /// <br/>Hotel_Review-g60763-d23462501-Reviews-Margaritaville_Times_Square-New_York_City_New_York.html
        /// <br/>https://www.tripadvisor.com/Hotel_Review-g60763-d23462501-Reviews-Margaritaville_Times_Square-New_York_City_New_York.html
        /// </summary>
        [JsonProperty("url_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UrlPath { get; set; }

        /// <summary>
        /// keyword
        /// <br/>required field if you do not specify url_path
        /// <br/>the keyword you specify should indicate a name of an existing business or prominent place on Tripadvisor;
        /// <br/>you can specify up to 700 characters in the keyword filed;
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character);
        /// <br/>if you need to use the “%” character for your keyword, please specify it as “%25”
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don’t specify location_code or url_path
        /// <br/>you can receive the list of available locations with location_name by making a separate request to the https://api.dataforseo.com/v3/business_data/tripadvisor/locations
        /// <br/>example:
        /// <br/>London,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don’t specify location_name or url_path
        /// <br/>you can receive the list of available locations with location_code by making a separate request to the https://api.dataforseo.com/v3/business_data/tripadvisor/locations
        /// <br/>example:
        /// <br/>1003854
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

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
        /// full name of search engine language
        /// <br/>optional field
        /// <br/>if you use this field, your account will be charged for one extra request
        /// <br/>you can receive the list of available languages with language_name by making a separate request to the https://api.dataforseo.com/v3/business_data/tripadvisor/languages
        /// <br/>example:
        /// <br/>English
        /// <br/>You will be additionally charged for setting a language parameter in this endpoint.
        /// <br/>The cost can be calculated on the Pricing page.
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field
        /// <br/>if you use this field, your account will be charged for one extra request
        /// <br/>you can receive the list of available languages with language_code by making a separate request to the https://api.dataforseo.com/v3/business_data/tripadvisor/languages
        /// <br/>example:
        /// <br/>en
        /// <br/>You will be additionally charged for setting a language parameter in this endpoint.
        /// <br/>The cost can be calculated on the Pricing page.
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of reviews in SERP;
        /// <br/>we strongly recommend setting the parsing depth in the multiples of ten, because our systems processes ten reviews in a row;
        /// <br/>default value: 10;
        /// <br/>max value: 4490
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// Tripadvisor traveler rating for a place of interest
        /// <br/>optional field
        /// <br/>rating based on the written reviews by a traveler after they visited a place.
        /// <br/>possible values: excellent, very_good, average, poor, terrible
        /// <br/>you can specify several values at once
        /// </summary>
        [JsonProperty("ratings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Ratings { get; set; }

        /// <summary>
        /// filter by type of travelers who left a review
        /// <br/>optional field
        /// <br/>possible values: families, couples, solo, business, friends
        /// <br/>you can specify several values at once
        /// </summary>
        [JsonProperty("visit_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> VisitType { get; set; }

        /// <summary>
        /// filter by months when a traveler made a visit
        /// <br/>optional field
        /// <br/>possible values: january, february, march, april, may, april, june, july, august, september, october, november, december
        /// <br/>you can specify several values at once
        /// </summary>
        [JsonProperty("months", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Months { get; set; }

        /// <summary>
        /// search reviews containing a specified keyword
        /// <br/>example:
        /// <br/>dessert
        /// </summary>
        [JsonProperty("search_reviews_keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchReviewsKeyword { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>you can use this field to sort the results;
        /// <br/>possible types of sorting:
        /// <br/>most_recent
        /// <br/>detailed_reviews
        /// </summary>
        [JsonProperty("sort_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// translate reviews according to the URL path
        /// <br/>optional field
        /// <br/>if set to true, returned reviews will be translated to the language matching the specified url_path;
        /// <br/>for example, if url_path contains tripadvisor.it and translate_reviews is true, reviews will be translated to the Italian language;
        /// <br/>default value: true
        /// <br/>you can learn more about how reviews are translated in this Help Center article
        /// </summary>
        [JsonProperty("translate_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TranslateReviews { get; set; }

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