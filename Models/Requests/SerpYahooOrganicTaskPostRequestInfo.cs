using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpYahooOrganicTaskPostRequestInfo 
    {

        /// <summary>
        /// direct URL of the search query
        /// <br/>optional field
        /// <br/>you can specify a direct URL and we will sort it out to the necessary fields. Note that this method is the most difficult for our API to process and also requires you to specify the exact language and location in the URL. In most cases, we wouldn’t recommend using this method.
        /// <br/>example:
        /// <br/><c>https://search.yahoo.com/search?p=rank+checker&amp;n=100&amp;vl=lang_en&amp;vc=us&amp;ei=UTF-8</c>
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 700 characters in the <c>keyword</c> field
        /// <br/>all %## will be decoded (plus character '+' will be decoded to a space character)
        /// <br/>if you need to use the '%' character for your <c>keyword</c>, please specify it as '%25';
        /// <br/>if you need to use the “+” character for your <c>keyword</c>, please specify it as “%2B”
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// task priority
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/>1 – normal execution priority (set by default)
        /// <br/>2 – high execution priorityYou will be additionally charged for the tasks with high execution priority.
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/serp/yahoo-serp-api">Pricing</see> page.
        /// </summary>
        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/{{low_se_name}}/locations</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c>_or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/{{low_se_name}}/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>n
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don't specify <c>location_name</c>_or <c>location_code</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_code</c>
        /// <br/><c>location_coordinate</c> parameter should be specified in the 'latitude,longitude,radius' format
        /// <br/>the maximum number of decimal digits for 'latitude' and 'longitude': 7
        /// <br/>the minimum value for 'radius': 199.9 (mm)
        /// <br/>the maximum value for 'radius': 199999 (mm)
        /// <br/>example:
        /// <br/><c>53.476225,-2.243572,200</c>n
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/{{low_se_name}}/languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c>_by making a separate request to the <c>https://api.dataforseo.com/v3/serp/{{low_se_name}}/languages</c>
        /// <br/>example:
        /// <br/><c>en</c>n
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>return results for a specific device type
        /// <br/>can take the values:<c>desktop</c>, <c>mobile</c>
        /// <br/>default value: <c>desktop</c>
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// device operating system
        /// <br/>optional field
        /// <br/>if you specify <c>desktop</c> in the <c>device</c> field, choose from the following values: <c>windows</c>, <c>macos</c>
        /// <br/>default value: <c>windows</c>
        /// <br/>if you specify <c>mobile</c> in the <c>device</c> field, choose from the following values: <c>android</c>, <c>ios</c>
        /// <br/>default value: <c>android</c>
        /// </summary>
        [JsonProperty("os", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// search engine domain
        /// <br/>optional field
        /// <br/>we choose the relevant search engine domain automatically according to the location and language you specify
        /// <br/>however, you can set a custom search engine domain in this field
        /// <br/>example:
        /// <br/><c>au.search.yahoo.com</c>, <c>uk.search.yahoo.com</c>, <c>ca.search.yahoo.com</c>, etc.
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results in SERP
        /// <br/>default value: <c>6</c>
        /// <br/>max value: <c>700</c>
        /// <br/>Your account will be billed per each SERP; 
        /// <br/>Each Yahoo SERP can contain fewer than 10 results, so setting depth above the default value may result in additional charges <see href="https://dataforseo.com/help-center/how-many-results-scraped"></see>;
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/serp/yahoo-serp-api">Pricing</see> page.
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// page crawl limit
        /// <br/>optional field
        /// <br/>number of search results pages to crawl
        /// <br/>default value: <c>1</c>
        /// <br/>max value: <c>100</c>
        /// <br/>Note: the <c>max_crawl_pages</c> and <c>depth</c> parameters complement each other;
        /// <br/>learn more at <see href="https://dataforseo.com/help-center/what-is-max-crawl-pages-and-how-does-it-work">our help center</see>
        /// </summary>
        [JsonProperty("max_crawl_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCrawlPages { get; set; }

        /// <summary>
        /// additional parameters of the search query
        /// <br/>optional field
        /// <br/><see href="https://dataforseo.com/help-center/yahoo-search-engine-parameters-and-how-to-use-them">get the list of available parameters and additional details here</see>
        /// </summary>
        [JsonProperty("search_param", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchParam { get; set; }

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
        /// postback_url datatype
        /// <br/>required field if you specify <c>postback_url</c>
        /// <br/>corresponds to the datatype that will be sent to your server
        /// <br/>possible values:
        /// <br/><c>regular</c>, <c>html</c>
        /// </summary>
        [JsonProperty("postback_data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackData { get; set; }

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