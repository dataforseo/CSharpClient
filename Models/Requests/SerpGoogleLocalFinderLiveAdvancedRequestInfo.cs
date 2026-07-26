using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleLocalFinderLiveAdvancedRequestInfo 
    {

        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 700 characters in the <c>keyword</c> field
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your <c>keyword</c>, please specify it as “%25”;
        /// <br/>if you need to use the “+” character for your <c>keyword</c>, please specify it as “%2B”
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/{{low_se_name}}/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/{{low_se_name}}/languages</c>
        /// <br/>example:<c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results in SERP
        /// <br/>default value for <c>desktop</c>: <c>20</c>
        /// <br/>max value for <c>desktop</c>: <c>100</c>
        /// <br/>default value for <c>mobile</c>: <c>10</c>
        /// <br/>max value for <c>mobile</c>: <c>100</c>
        /// <br/>Your account will be billed per each SERP containing up to 20 results for desktop or up to 10 results for a mobile device;
        /// <br/>Setting depth above 20 for desktop or above 10 for mobile may result in additional charges if the search engine returns more than 20 or 10 results respectively;;
        /// <br/>If the specified depth is higher than the number of results in the response, the difference will be refunded to your account balance automatically
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/serp/google-local-finder-serp-api">Pricing</see> page.
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

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
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// task priority
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/>1 – normal execution priority (set by default)
        /// <br/>2 – high execution priority
        /// <br/>You will be additionally charged for the tasks with high execution priority.
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/serp/google-local-finder-serp-api">Pricing</see> page.
        /// </summary>
        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don't specify <c>location_name</c> or <c>location_code</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_code</c>
        /// <br/><c>location_coordinate</c> parameter should be specified in the 'latitude,longitude,zoom' format
        /// <br/>if 'zoom' is not specified, 9z will be applied as a default value
        /// <br/>the maximum number of decimal digits for 'latitude' and 'longitude': 7
        /// <br/>the minimum value for 'zoom': 4z
        /// <br/>the maximum value for 'zoom': 18z
        /// <br/>example:
        /// <br/><c>52.6178549,-155.352142,20z</c>
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// filter results by minimum rating
        /// <br/>optional field
        /// <br/>possible values for <c>desktop</c>: <c>3.5</c>, <c>4</c>, <c>4.5</c>;
        /// <br/>possible values for <c>mobile</c>: <c>2</c>, <c>2.5</c>, <c>3</c>, <c>3.5</c>, <c>4</c>, <c>4.5</c>
        /// </summary>
        [JsonProperty("min_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MinRating { get; set; }

        /// <summary>
        /// filter results by open hours
        /// <br/>optional field
        /// <br/>using this field, you can filter places in the results by the time a place is open for visitors
        /// <br/>note that Google may also provide results that do not match this filter
        /// <br/>possible values: <c>'open_now'</c>, <c>'24_hours'</c>, <c>'$day_value'</c>, <c>'$day_value;$time_value'</c>;
        /// <br/>instead of <c>$day_value</c> use one of these values: <c>'monday'</c>, <c>'tuesday'</c>, <c>'wednesday'</c>, <c>'thursday'</c>, <c>'friday'</c>, <c>'saturday'</c>, <c>'sunday'</c>;
        /// <br/>instead of <c>$time_value</c> use one of these values: <c>'00'</c>, <c>'01'</c>, <c>'02'</c>, <c>'03'</c>, <c>'04'</c>, <c>'05'</c>, <c>'06'</c>, <c>'07'</c>, <c>'08'</c>, <c>'09'</c>, <c>'10'</c>, <c>'11'</c>, <c>'12'</c>, <c>'13'</c>, <c>'14'</c>, <c>'15'</c>, <c>'16'</c>, <c>'17'</c>, <c>'18'</c>, <c>'19'</c>, <c>'20'</c>, <c>'21'</c>, <c>'22'</c>, <c>'23'</c>
        /// <br/>example: <c>'tuesday;18'</c>
        /// </summary>
        [JsonProperty("time_filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TimeFilter { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}