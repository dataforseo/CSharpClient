using Newtonsoft.Json;
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
        /// <br/>you can download the full list of possible categories
        /// </summary>
        [JsonProperty("category_codes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> CategoryCodes { get; set; }

        /// <summary>
        /// first date of comparison period
        /// <br/>required field
        /// <br/>first date for which domain metrics will be provided;
        /// <br/>date format: 'yyyy-mm-dd';
        /// <br/>example: '2021-06-01';
        /// <br/>the list available dates is available through the available history endpoint;
        /// <br/>Note: first_date cannot be greater than today’s date;
        /// <br/>Also note: the dates specified in first_date and second_date cannot point to the same month of the same year;
        /// <br/>you can specify the dates in any order: first_date can be greater than second_date and vice versa;
        /// <br/>minimum date: '2020-10-01'
        /// </summary>
        [JsonProperty("first_date", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstDate { get; set; }

        /// <summary>
        /// second date of comparison period
        /// <br/>required field
        /// <br/>second date for which domain metrics will be provided;
        /// <br/>date format: 'yyyy-mm-dd';
        /// <br/>example: '2021-10-01';
        /// <br/>the list available dates is available through the available history endpoint;
        /// <br/>Note: second_date cannot be greater than today’s date;
        /// <br/>Also note: the dates specified in first_date and second_date cannot point to the same month of the same year;
        /// <br/>you can specify the dates in any order: second_date can be greater than first_date and vice versa;
        /// <br/>minimum date: '2020-10-01'
        /// </summary>
        [JsonProperty("second_date", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string SecondDate { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don’t specify location_code
        /// <br/>Note: it is required to specify either location_name or location_code;
        /// <br/>you can receive the list of available locations with their location_name by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>example:
        /// <br/>United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// unique location identifier
        /// <br/>required field if you don’t specify location_name
        /// <br/>Note: it is required to specify either location_name or location_code;
        /// <br/>you can receive the list of available locations with their location_code by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don’t specify language_code
        /// <br/>Note: it is required to specify either language_name or language_code;
        /// <br/>you can receive the list of available languages with their language_name by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// unique language identifier
        /// <br/>required field if you don’t specify language_name
        /// <br/>Note: it is required to specify either language_name or language_code;
        /// <br/>you can receive the list of available languages with their language_code by making a separate request to https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// display results by item type
        /// <br/>optional field
        /// <br/>indicates the type of search results included in the response;
        /// <br/>Note: if the item_types array contains item types that are different from the organic object, the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search results not included in the response;
        /// <br/>possible values:
        /// <br/>['organic', 'paid', 'featured_snippet', 'local_pack'];
        /// <br/>default value:
        /// <br/>['organic', 'paid']
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// number of additional domain categories
        /// <br/>optional field
        /// <br/>by using this parameter, you can receive domains relevant to additional categories that are not specified in category_codes above;
        /// <br/>to learn more about the parameter, please refer to this help center article;
        /// <br/>by default, top_categories_count is equal to the number of categories specified in the category_codes array;
        /// <br/>Note: top_categories_count cannot be less than the number of categories in the category_codes array;
        /// <br/>maximum value: 5
        /// </summary>
        [JsonProperty("top_categories_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TopCategoriesCount { get; set; }

        /// <summary>
        /// return subdomains in the API response
        /// <br/>optional field
        /// <br/>if false, the API response will contain main_domain only;
        /// <br/>if true, the API will return main_domain plus its subdomains (if available);
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// minimum current organic ETV of the domain
        /// <br/>optional field
        /// <br/>if specified, the API will return only domains with organic_etv greater than the specified value
        /// </summary>
        [JsonProperty("etv_min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EtvMin { get; set; }

        /// <summary>
        /// maximum current organic ETV of the domain
        /// <br/>optional field
        /// <br/>if specified, the API will return only domains with organic_etv lesser than the specified value
        /// </summary>
        [JsonProperty("etv_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EtvMax { get; set; }

        /// <summary>
        /// correlate data with previously obtained datasets
        /// <br/>optional field
        /// <br/>default value: true;
        /// <br/>if you use this parameter, our system will correlate data you obtain now with previously obtained datasets;
        /// <br/>this parameter is intended to mitigate any inconsistencies that may result from changes to our database;
        /// <br/>Note: we do not recommend setting correlate to false
        /// </summary>
        [JsonProperty("correlate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Correlate { get; set; }

        /// <summary>
        /// the maximum number of domains in the results array
        /// <br/>optional field
        /// <br/>default value: 100;
        /// <br/>maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned domains
        /// <br/>optional field
        /// <br/>default value: 0;
        /// <br/>if you specify the 10 value, the first ten domains in the results array will be omitted and the data will be provided for the successive domains
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum);
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, match, not_match, ilike, not_ilike, like, not_like;
        /// <br/>you can use the % operator with like and not_like, as well as ilike and not_ilike to match any string of zero or more characters;
        /// <br/>example:
        /// <br/>['metrics_history.202110.organic.pos_1', '&gt;', 15];
        /// <br/>for more information about filters, please refer to Dataforseo Labs – Filters or this help center guide
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the filters array to sort the results;
        /// <br/>default rule: ['organic_etv,desc'];
        /// <br/>possible sorting types:
        /// <br/>asc – results will be sorted in ascending order
        /// <br/>desc – results will be sorted in descending order;
        /// <br/>you should use a comma to set up a sorting type;
        /// <br/>example:
        /// <br/>['organic_count,desc'];
        /// <br/>note that you can set no more than three sorting rules in a single request;
        /// <br/>you should use a comma to separate several sorting rules;
        /// <br/>example:
        /// <br/>['organic_etv,desc','organic_count,asc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255;
        /// <br/>you can use this parameter to identify the task and match it with the result;
        /// <br/>you will find the specified tag value in the data object of the response
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