using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleSubdomainsLiveRequestInfo 
    {

        /// <summary>
        /// domain
        /// <br/>required field
        /// <br/>the domain name of the target website
        /// <br/>the domain should be specified without <c>https://</c> and <c>www.</c>
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_name</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>ignore this field to get the results for all available locations
        /// <br/>example:
        /// <br/><c>United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>location_name</c>
        /// <br/>you can receive the list of available locations with their <c>location_code</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>ignore this field to get the results for all available locations
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_name</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>ignore this field to get the results for all available languages
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>ignore this field to get the results for all available languages
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// display results by item type
        /// <br/>optional field
        /// <br/>indicates the type of search results included in the response
        /// <br/>Note: if the <c>item_types</c> array contains item types that are different from <c>organic</c>, the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search results not included in the response;
        /// <br/>possible values: 
        /// <br/><c>['organic', 'paid', 'featured_snippet', 'local_pack']</c>
        /// <br/>default value: 
        /// <br/><c>['organic', 'paid']</c>
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// include or exclude data from clickstream-based metrics in the result
        /// <br/>optional field
        /// <br/>if the parameter is set to <c>true</c>, you will receive <c>clickstream_etv</c>, <c>clickstream_gender_distribution</c>, and <c>clickstream_age_distribution</c> fields with clickstream data in the response
        /// <br/>default value: <c>false</c>
        /// <br/>with this parameter enabled, you will be charged double the price for the request
        /// <br/>learn more about how clickstream-based metrics are calculated in this <see href="https://dataforseo.com/help-center/what-are-clickstream-based-metrics-and-how-do-we-calculate-them">help center article</see>
        /// </summary>
        [JsonProperty("include_clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

        /// <summary>
        /// data collection mode
        /// <br/>optional field
        /// <br/>you can use this field to filter the results;
        /// <br/>possible types of filtering:
        /// <br/><c>live</c> — return metrics for SERPs in which the specified <c>target</c> currently has ranking results;
        /// <br/><c>lost</c> — return metrics for SERPs in which the specified <c>target</c> had previously had ranking results, but didn't have them during the last check;
        /// <br/><c>all</c> — return metrics for both types of SERPs.
        /// <br/>default value: <c>live</c>
        /// </summary>
        [JsonProperty("historical_serp_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HistoricalSerpMode { get; set; }

        /// <summary>
        /// ignore highly similar keywords
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, only core keywords will be returned, all highly similar keywords will be excluded;  
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("ignore_synonyms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>regex</c>, <c>not_regex</c>, <c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>
        /// <br/>example:
        /// <br/><c>['metrics.paid.count','&gt;',0]</c>
        /// <br/><c>[['metrics.paid.count','&gt;',0],'and',['metrics.paid.etv','&gt;','50']]</c>
        /// <br/><c>[['metrics.organic.count','&gt;','10'],'and',[['metrics.organic.pos_1','&lt;&gt;',0],'or',['metrics.organic.pos_2_3','&lt;&gt;',0]]]</c>
        /// <br/>for more information about filters, please refer to <see href="/v3/dataforseo_labs/filters">Dataforseo Labs - Filters</see> or this <see href="https://dataforseo.com/help-center/how-to-use-filters-in-dataforseo-labs-api">help center guide</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the <c>filters</c> array to sort the results
        /// <br/>possible sorting types:
        /// <br/><c>asc</c> - results will be sorted in the ascending order
        /// <br/><c>desc</c> - results will be sorted in the descending order
        /// <br/>you should use a comma to specify a sorting type
        /// <br/>example:
        /// <br/><c>['metrics.paid.etv,asc']</c>
        /// <br/>Note: you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/><c>['metrics.organic.etv,desc','metrics.paid.count,asc']</c>
        /// <br/>default rule:
        /// <br/><c>['metrics.organic.count,desc']</c>
        /// <br/>Note: if the <c>item_types</c> array contains item types that are different from <c>organic</c>, the results will be ordered by the first item type in the array
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// the maximum number of returned keywords
        /// <br/>optional field
        /// <br/>default value: <c>100</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned keywords
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>if you specify the <c>10</c> value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

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