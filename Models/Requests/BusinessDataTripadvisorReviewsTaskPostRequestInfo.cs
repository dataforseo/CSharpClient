using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BusinessDataTripadvisorReviewsTaskPostRequestInfo 
    {

        /// <summary>
        /// URL path of the business entity
        /// <br/>required field if you do not specify <c>keyword</c>
        /// <br/>URL path to the Tripadvisor page of the business entity;
        /// <br/>examples:
        /// <br/><c>Hotel_Review-g60763-d23462501-Reviews-Margaritaville_Times_Square-New_York_City_New_York.html</c>
        /// <br/><c>https://www.tripadvisor.com/Hotel_Review-g60763-d23462501-Reviews-Margaritaville_Times_Square-New_York_City_New_York.html</c>
        /// </summary>
        [JsonProperty("url_path", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string UrlPath { get; set; }

        /// <summary>
        /// keyword
        /// <br/>required field if you do not specify <c>url_path</c>
        /// <br/>the keyword you specify should indicate a name of an existing business or prominent place on Tripadvisor;
        /// <br/>you can specify up to 700 characters in the <c>keyword</c> filed;
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character);
        /// <br/>if you need to use the “%” character for your <c>keyword</c>, please specify it as “%25”
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c> or <c>url_path</c>
        /// <br/>you can receive the list of available locations with <c>location_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/business_data/tripadvisor/locations</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c> or <c>url_path</c>
        /// <br/>you can receive the list of available locations with <c>location_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/business_data/tripadvisor/locations</c>
        /// <br/>example:
        /// <br/><c>1003854</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// task priority
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/>1 – normal execution priority (set by default)
        /// <br/>2 – high execution priorityYou will be additionally charged for the tasks with high execution priority.
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/business-data/business-data-api-tripadvisor-pricing">Pricing</see> page.
        /// </summary>
        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>optional field
        /// <br/>if you use this field, your account will be charged for one extra request
        /// <br/>you can receive the list of available languages with <c>language_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/business_data/tripadvisor/languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// <br/>You will be additionally charged for setting a language parameter in this endpoint.
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/business-data/business-data-api-tripadvisor-pricing">Pricing</see> page.
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field
        /// <br/>if you use this field, your account will be charged for one extra request
        /// <br/>you can receive the list of available languages with <c>language_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/business_data/tripadvisor/languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// <br/>You will be additionally charged for setting a language parameter in this endpoint.
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/business-data/business-data-api-tripadvisor-pricing">Pricing</see> page.
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of reviews in SERP;
        /// <br/>we strongly recommend setting the parsing depth in the multiples of ten, because our systems processes ten reviews in a row;
        /// <br/>default value: <c>10</c>;
        /// <br/>max value: <c>4490</c>
        /// <br/>Your account will be billed per each SERP containing up to 10 results; 
        /// <br/>Setting depth above 10 may result in additional charges if the search engine returns more than 10 results;
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/business-data/business-data-api-tripadvisor-pricing">Pricing</see> page.
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// Tripadvisor traveler rating for a place of interest
        /// <br/>optional field
        /// <br/>rating based on the written reviews by a traveler after they visited a place.
        /// <br/>possible values: <c>excellent</c>, <c>very_good</c>, <c>average</c>, <c>poor</c>, <c>terrible</c>
        /// <br/>you can specify several values at once
        /// </summary>
        [JsonProperty("ratings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Ratings { get; set; }

        /// <summary>
        /// filter by type of travelers who left a review
        /// <br/>optional field
        /// <br/>possible values: <c>families</c>, <c>couples</c>, <c>solo</c>, <c>business</c>, <c>friends</c>
        /// <br/>you can specify several values at once
        /// </summary>
        [JsonProperty("visit_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> VisitType { get; set; }

        /// <summary>
        /// filter by months when a traveler made a visit
        /// <br/>optional field
        /// <br/>possible values: <c>january</c>, <c>february</c>, <c>march</c>, <c>april</c>, <c>may</c>, <c>april</c>, <c>june</c>, <c>july</c>, <c>august</c>, <c>september</c>, <c>october</c>, <c>november</c>, <c>december</c>
        /// <br/>you can specify several values at once
        /// </summary>
        [JsonProperty("months", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Months { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>you can use this field to sort the results;
        /// <br/>possible types of sorting:
        /// <br/><c>most_recent</c>
        /// <br/><c>detailed_reviews</c>
        /// </summary>
        [JsonProperty("sort_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// translate reviews according to the URL path
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, returned reviews will be translated to the language matching the specified <c>url_path</c>;
        /// <br/>for example, if <c>url_path</c> contains <c>tripadvisor.it</c> and <c>translate_reviews</c> is <c>true</c>, reviews will be translated to the Italian language;
        /// <br/>default value: <c>true</c>
        /// <br/>you can learn more about how reviews are translated in <see href="https://dataforseo.com/help-center/how-to-translate-reviews-in-tripadvisor-business-data-api">this Help Center article</see>
        /// </summary>
        [JsonProperty("translate_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TranslateReviews { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// URL for sending task results
        /// <br/>optional field
        /// <br/>once the task is completed, we will send a POST request with its results compressed in the <c>gzip</c> format to the <c>postback_url</c> you specified
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request.
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
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request.
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