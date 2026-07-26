using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleAdsSearchTaskPostRequestInfo 
    {

        /// <summary>
        /// advertiser identifiers
        /// <br/>required field if <c>target</c> is not specified
        /// <br/>you can specify the maximum of 25 values in this array;
        /// <br/><c>advertiser_ids</c> values for this parameter can be found in the <see href="http://docs.dataforseo.com/v3/serp/google/ads_advertisers/task_get/advanced/">Google Ads Advertisers</see> endpoint;
        /// </summary>
        [JsonProperty("advertiser_ids", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> AdvertiserIds { get; set; }

        /// <summary>
        /// domain name
        /// <br/>required field if <c>advertiser_ids</c> is not specified
        /// <br/>domain name associated with an advertiser account
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/google/ads_search/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// <br/>Note: if you don't specify <c>location_name</c>, <c>location_code</c>, or <c>location_coordinate</c>, the ads will be searched across all the available locations
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results in SERP
        /// <br/>default value: <c>40</c>
        /// <br/>max value: <c>700</c>
        /// <br/>Your account will be billed per each SERP containing up to 40 results;
        /// <br/>Setting depth above 40 may result in additional charges <see href="https://dataforseo.com/help-center/how-many-results-scraped">if the search engine returns more than 40 results</see>;
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/serp/google-ads-search-serp-api">Pricing</see> page.
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// task priority
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/>1 – normal execution priority (set by default)
        /// <br/>2 – high execution priority
        /// <br/>You will be additionally charged for the tasks with high execution priority.
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/serp/google-ads-search-serp-api">Pricing</see> page.
        /// </summary>
        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

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
        /// <br/>corresponds to the function you used for setting a task
        /// <br/>possible values:
        /// <br/><c>advanced</c>
        /// </summary>
        [JsonProperty("postback_data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackData { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/google/ads_search/locations</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// <br/>Note: if you don't specify <c>location_name</c>, <c>location_code</c>, or <c>location_coordinate</c>, the ads will be searched across all the available locations
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_code</c>
        /// <br/>example:
        /// <br/><c>52.6178549,-155.352142</c>
        /// <br/>Note: if you don't specify <c>location_name</c>, <c>location_code</c>, or <c>location_coordinate</c>, the ads will be searched across all the available locations
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

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
        /// advertising platform
        /// <br/>optional field
        /// <br/>possible values: <c>all</c>, <c>google_play</c>, <c>google_maps</c>, <c>google_search</c>, <c>google_shopping</c>, <c>youtube</c>
        /// <br/>default value: <c>all</c>
        /// </summary>
        [JsonProperty("platform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// ad format
        /// <br/>optional field
        /// <br/>possible values: <c>all</c>, <c>text</c>, <c>image</c>, <c>video</c>
        /// </summary>
        [JsonProperty("format", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>required field if <c>date_to</c> is specified; 
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>minimum value: 2018-05-31
        /// <br/>maximum value: today's date
        /// <br/>example:
        /// <br/><c>'2020-01-01'</c>
        /// </summary>
        [JsonProperty("date_from", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>required field if <c>date_from</c> is specified; 
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>minimum value: 2018-05-31
        /// <br/>maximum value: today's date
        /// <br/>example:
        /// <br/><c>'2020-01-01'</c>
        /// </summary>
        [JsonProperty("date_to", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}