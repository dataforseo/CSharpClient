using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleAppIntersectionLiveRequestInfo 
    {

        /// <summary>
        /// ids of the target apps
        /// <br/>required field
        /// <br/>IDs of the target mobile applications on Google Play;
        /// <br/>you can find the ID in the URL of every app listed on Google Play;
        /// <br/>example:
        /// <br/>in the URL <c>https://play.google.com/store/apps/details?id=org.telegram.messenger</c>
        /// <br/>the id is <c>org.telegram.messenger</c>;;
        /// <br/>the ids should be specified the following way:
        /// <br/><c>'app_ids': {'1': 'org.telegram.messenger','2': 'com.zhiliaoapp.musically'}</c>
        /// <br/>if you specify a single ID here, the API will return results only for one application;
        /// <br/>the maximum number of app IDs you can specify in this object is <c>20</c>
        /// </summary>
        [JsonProperty("app_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> AppIds { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don't specify <c>location_code</c>
        /// <br/>Note: it is required to specify either <c>location_name</c> or <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_name</c> by making a separate request to 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>Note: this endpoint currently supports the US location only;
        /// <br/>example:
        /// <br/><c>United States</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if you don't specify <c>location_name</c>
        /// <br/>Note: it is required to specify either <c>location_name</c> or <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_code</c> by making a separate request to 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>Note: this endpoint currently supports the US location only;
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>Note: it is required to specify either <c>language_name</c> or <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_name</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>Note: this endpoint currently supports the English language only;
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>Note: it is required to specify either <c>language_name</c> or <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>Note: this endpoint currently supports the English language only
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>
        /// <br/>example:
        /// <br/><c>['keyword_data.keyword_info.search_volume','&gt;',500]</c>
        /// <br/><c>[['keyword_data.keyword_info.search_volume','&lt;&gt;',500],'and',[intersection_result.382617920.rank_group','&gt;=','10']]</c>
        /// <br/>for more information about filters, please refer to <see href="/v3/dataforseo_labs/filters">Dataforseo Labs - Filters</see> or this <see href="https://dataforseo.com/help-center/how-to-use-filters-in-dataforseo-labs-api">help center guide</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the <c>filters</c> array to sort the results;
        /// <br/>possible sorting types:
        /// <br/><c>asc</c> - results will be sorted in the ascending order;
        /// <br/><c>desc</c> - results will be sorted in the descending order;
        /// <br/>you should use a comma to specify a sorting type;
        /// <br/>example:
        /// <br/><c>['intersection_result.382617920.rank_absolute,asc']</c>
        /// <br/>Note: you can set no more than three sorting rules in a single request;
        /// <br/>you should use a comma to separate several sorting rules;
        /// <br/>example:
        /// <br/><c>['intersection_result.382617920.rank_absolute,desc','keyword_data.keyword_info.search_volume,asc']</c>
        /// <br/>default rule:
        /// <br/><c>['keyword_data.keyword_info.search_volume,desc']</c>
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