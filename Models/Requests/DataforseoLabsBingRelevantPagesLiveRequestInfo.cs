using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsBingRelevantPagesLiveRequestInfo 
    {

        /// <summary>
        /// domain
        /// <br/>required field
        /// <br/>the domain name of the target website
        /// <br/>the domain should be specified without https:// and www.
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify location_code
        /// <br/>you can receive the list of available locations with their location_name by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>ignore this field to get the results for all available locations;
        /// <br/>Note: this endpoint currently supports the US location only;
        /// <br/>example:
        /// <br/>United States
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify location_name
        /// <br/>you can receive the list of available locations with their location_code by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>ignore this field to get the results for all available locations;
        /// <br/>Note: this endpoint currently supports the US location only;
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify language_code
        /// <br/>you can receive the list of available languages with their language_name by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>ignore this field to get the results for all available languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify language_name
        /// <br/>you can receive the list of available languages with their language_code by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>ignore this field to get the results for all available languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// display results by item type
        /// <br/>optional field
        /// <br/>indicates the type of search results included in the response
        /// <br/>Note: if the item_types array contains item types that are different from organic, the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search results not included in the response;
        /// <br/>possible values:
        /// <br/>['organic', 'paid', 'featured_snippet', 'local_pack']
        /// <br/>default value:
        /// <br/>['organic', 'paid', 'featured_snippet', 'local_pack']
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// the maximum number of returned pages
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned pages
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify the 10 value, the first ten pages in the results array will be omitted and the data will be provided for the successive pages
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// data collection mode
        /// <br/>optional field
        /// <br/>you can use this field to filter the results;
        /// <br/>possible types of filtering:
        /// <br/>live — return metrics for SERPs in which the specified target currently has ranking results;
        /// <br/>lost — return metrics for SERPs in which the specified target had previously had ranking results, but didn’t have them during the last check;
        /// <br/>all — return metrics for both types of SERPs.
        /// <br/>default value: live
        /// </summary>
        [JsonProperty("historical_serp_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HistoricalSerpMode { get; set; }

        /// <summary>
        /// ignore highly similar keywords
        /// <br/>optional field
        /// <br/>if set to true, only core keywords will be returned, all highly similar keywords will be excluded;
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("ignore_synonyms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, match, not_match
        /// <br/>example:
        /// <br/>['metrics.paid.count','&gt;',0]
        /// <br/>[['metrics.organic.count','&gt;',50],'and',['metrics.organic.pos_1','&lt;&gt;',0]]
        /// <br/>[[''metrics.organic.count','&gt;',50'],
        /// <br/>'and',
        /// <br/>[['metrics.organic.pos_1','&lt;&gt;',0],'or',['metrics.organic.pos_2_3','&lt;&gt;',0]]]
        /// <br/>for more information about filters, please refer to Dataforseo Labs – Filters or this help center guide
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the filters array to sort the results
        /// <br/>possible sorting types:
        /// <br/>asc – results will be sorted in the ascending order
        /// <br/>desc – results will be sorted in the descending order
        /// <br/>you should use a comma to specify a sorting type
        /// <br/>example:
        /// <br/>['metrics.paid.etv,asc']
        /// <br/>Note: you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>['metrics.organic.etv,desc','metrics.paid.count,asc']
        /// <br/>default rule:
        /// <br/>['metrics.organic.count,desc']
        /// <br/>Note: if the item_types array contains item types that are different from organic, the results will be ordered by the first item type in the array
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
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