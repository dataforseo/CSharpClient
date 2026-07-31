using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo 
    {

        /// <summary>
        /// asins of target products
        /// <br/>required field
        /// <br/>product IDs of the products for which you need to find keyword intersections;
        /// <br/>specify the ASINs as in the following example:
        /// <br/><c>'asins': {'1': '019005476X','2': '0190074442'}</c>
        /// <br/>the maximum number of ASINs you can specify in this object is 20;
        /// <br/>learn more about the parameter on <see href="https://dataforseo.com/help-center/how-to-get-amazon-product-data-using-asin">this help center page</see>
        /// </summary>
        [JsonProperty("asins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Asins { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if don't specify <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_name</c> by making a separate request to 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>Note: this endpoint currently supports the US, Egypt, Saudi Arabia, and the United Arab Emirates locations only;
        /// <br/>example:
        /// <br/><c>United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if don't specify <c>location_name</c>
        /// <br/>you can receive the list of available locations with their <c>location_code</c> by making a separate request to
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>Note: this endpoint currently supports the US, Egypt, Saudi Arabia, and the United Arab Emirates locations only;
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if don't specify <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_name</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if don't specify <c>language_name</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// the maximum number of products in the results array
        /// <br/>optional field
        /// <br/>default value: <c>100</c>;
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// mode for finding asin intersections
        /// <br/>optional field
        /// <br/>possible values: <c>union</c>, <c>intersect</c>;
        /// <br/>default value: <c>intersect</c>;
        /// <br/>learn more about the parameter in <see href="https://dataforseo.com/help-center/what-is-intersection-mode-in-amazon-keyword-intersections-endpoint">this help center guide</see>
        /// </summary>
        [JsonProperty("intersection_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionMode { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>regex</c>, <c>not_regex</c>, <c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>ilike</c>, <c>not_ilike</c>, <c>like</c>, <c>not_like</c>, <c>match</c>, <c>not_match</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c>, as well as <c>ilike</c> and <c>not_ilike</c> to match any string of zero or more characters
        /// <br/>example:
        /// <br/><c>['avg_position','&lt;', 10]</c>
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
        /// <br/>you should use a comma to set up a sorting parameter
        /// <br/>example:
        /// <br/><c>['sum_position,desc']</c>
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/><c>['intersections,desc','avg_position,asc']</c>
        /// <br/>default rule:
        /// <br/><c>['intersections,desc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

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