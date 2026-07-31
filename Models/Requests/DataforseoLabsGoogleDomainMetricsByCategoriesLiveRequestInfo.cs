using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo 
    {

        /// <summary>
        /// product and service categories
        /// <br/>required field
        /// <br/>The maximum number of categories you can specify: 5
        /// <br/>you can download <see href="https://cdn.dataforseo.com/v3/categories/categories_dataforseo_labs_2023_10_25.csv">the full list of possible categories</see>
        /// </summary>
        [JsonProperty("category_codes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> CategoryCodes { get; set; }

        /// <summary>
        /// first date of comparison period
        /// <br/>required field
        /// <br/>first date for which domain metrics will be provided;
        /// <br/>date format: <c>'yyyy-mm-dd'</c>;
        /// <br/>example: <c>'2021-06-01'</c>;
        /// <br/>the list available dates is available through the <see href="/v3/dataforseo_labs/google/available_history/live/">available history endpoint</see>;
        /// <br/>Note: <c>first_date</c> cannot be greater than today's date;
        /// <br/>Also note: the dates specified in <c>first_date</c> and <c>second_date</c> cannot point to the same month of the same year;
        /// <br/>you can specify the dates in any order: <c>first_date</c> can be greater than <c>second_date</c> and vice versa;
        /// <br/>minimum date: <c>'2020-10-01'</c>
        /// </summary>
        [JsonProperty("first_date", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstDate { get; set; }

        /// <summary>
        /// second date of comparison period
        /// <br/>required field
        /// <br/>second date for which domain metrics will be provided;
        /// <br/>date format: <c>'yyyy-mm-dd'</c>;
        /// <br/>example: <c>'2021-10-01'</c>;
        /// <br/>the list available dates is available through the <see href="/v3/dataforseo_labs/google/available_history/live/">available history endpoint</see>;
        /// <br/>Note: <c>second_date</c> cannot be greater than today's date;
        /// <br/>Also note: the dates specified in <c>first_date</c> and <c>second_date</c> cannot point to the same month of the same year;
        /// <br/>you can specify the dates in any order: <c>second_date</c> can be greater than <c>first_date</c> and vice versa;
        /// <br/>minimum date: <c>'2020-10-01'</c>
        /// </summary>
        [JsonProperty("second_date", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string SecondDate { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don't specify <c>location_code</c>
        /// <br/>Note: it is required to specify either <c>location_name</c> or <c>location_code</c>;
        /// <br/>you can receive the list of available locations with their <c>location_name</c> by making a separate request to
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>example:
        /// <br/><c>United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// unique location identifier
        /// <br/>required field if you don't specify <c>location_name</c>
        /// <br/>Note: it is required to specify either <c>location_name</c> or <c>location_code</c>;
        /// <br/>you can receive the list of available locations with their <c>location_code</c> by making a separate request to
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>Note: it is required to specify either <c>language_name</c> or <c>language_code</c>;
        /// <br/>you can receive the list of available languages with their <c>language_name</c> by making a separate request to
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// unique language identifier
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>Note: it is required to specify either <c>language_name</c> or <c>language_code</c>;
        /// <br/>you can receive the list of available languages with their <c>language_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// display results by item type
        /// <br/>optional field
        /// <br/>indicates the type of search results included in the response;
        /// <br/>Note: if the <c>item_types</c> array contains item types that are different from the <c>organic</c> object, the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search results not included in the response;
        /// <br/>possible values: 
        /// <br/><c>['organic', 'paid', 'featured_snippet', 'local_pack']</c>;
        /// <br/>default value: 
        /// <br/><c>['organic', 'paid']</c>
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// number of additional domain categories
        /// <br/>optional field
        /// <br/>by using this parameter, you can receive domains relevant to additional categories that are not specified in <c>category_codes</c> above;
        /// <br/>to learn more about the parameter, please refer to <see href="https://dataforseo.com/help-center/what-is-top_categories_count">this help center article;</see>
        /// <br/>by default, <c>top_categories_count</c> is equal to the number of categories specified in the <c>category_codes</c> array;
        /// <br/>Note: <c>top_categories_count</c> cannot be less than the number of categories in the <c>category_codes</c> array;
        /// <br/>maximum value: <c>5</c>
        /// </summary>
        [JsonProperty("top_categories_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TopCategoriesCount { get; set; }

        /// <summary>
        /// return subdomains in the API response
        /// <br/>optional field
        /// <br/>if <c>false</c>, the API response will contain <c>main_domain</c> only;
        /// <br/>if <c>true</c>, the API will return <c>main_domain</c> plus its subdomains (if available);
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// minimum current organic ETV of the domain
        /// <br/>optional field
        /// <br/>if specified, the API will return only domains with <c>organic_etv</c> greater than the specified value
        /// </summary>
        [JsonProperty("etv_min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EtvMin { get; set; }

        /// <summary>
        /// maximum current organic ETV of the domain
        /// <br/>optional field
        /// <br/>if specified, the API will return only domains with <c>organic_etv</c> lesser than the specified value
        /// </summary>
        [JsonProperty("etv_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EtvMax { get; set; }

        /// <summary>
        /// correlate data with previously obtained datasets
        /// <br/>optional field
        /// <br/>default value: <c>true</c>;
        /// <br/>if you use this parameter, our system will correlate data you obtain now with previously obtained datasets;
        /// <br/>this parameter is intended to mitigate any inconsistencies that may result from changes to our database;
        /// <br/>Note: we do not recommend setting <c>correlate</c> to <c>false</c>
        /// </summary>
        [JsonProperty("correlate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Correlate { get; set; }

        /// <summary>
        /// the maximum number of domains in the results array
        /// <br/>optional field
        /// <br/>default value: <c>100</c>;
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned domains
        /// <br/>optional field
        /// <br/>default value: <c>0</c>;
        /// <br/>if you specify the <c>10</c> value, the first ten domains in the results array will be omitted and the data will be provided for the successive domains
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum);
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>regex</c>, <c>not_regex</c>, <c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>match</c>, <c>not_match</c>, <c>ilike</c>, <c>not_ilike</c>, <c>like</c>, <c>not_like</c>;
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c>, as well as <c>ilike</c> and <c>not_ilike</c> to match any string of zero or more characters;
        /// <br/>example:
        /// <br/><c>['metrics_history.202110.organic.pos_1', '&gt;', 15]</c>;
        /// <br/>for more information about filters, please refer to <see href="/v3/dataforseo_labs/filters">Dataforseo Labs - Filters</see> or this <see href="https://dataforseo.com/help-center/how-to-use-filters-in-dataforseo-labs-api">help center guide</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the <c>filters</c> array to sort the results;
        /// <br/>default rule: <c>['organic_etv,desc']</c>;
        /// <br/>possible sorting types:
        /// <br/><c>asc</c> - results will be sorted in ascending order
        /// <br/><c>desc</c> - results will be sorted in descending order;
        /// <br/>you should use a comma to set up a sorting type;
        /// <br/>example:
        /// <br/><c>['organic_count,desc']</c>;
        /// <br/>note that you can set no more than three sorting rules in a single request;
        /// <br/>you should use a comma to separate several sorting rules;
        /// <br/>example:
        /// <br/><c>['organic_etv,desc','organic_count,asc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255;
        /// <br/>you can use this parameter to identify the task and match it with the result;
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