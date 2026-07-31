using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class ContentAnalysisCategoryTrendsLiveRequestInfo 
    {

        /// <summary>
        /// target category code
        /// <br/>required field
        /// <br/>to obtain a full list of available categories, refer to the <see href="/v3/content_analysis/categories/">Categories</see> endpoint
        /// </summary>
        [JsonProperty("category_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryCode { get; set; }

        /// <summary>
        /// target page types
        /// <br/>optional field
        /// <br/>use this parameter to filter the dataset by page types
        /// <br/>possible values: 
        /// <br/><c>'ecommerce'</c>, <c>'news'</c>, <c>'blogs'</c>, <c>'message-boards'</c>, <c>'organization'</c>
        /// </summary>
        [JsonProperty("page_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> PageType { get; set; }

        /// <summary>
        /// results grouping type
        /// <br/>optional field
        /// <br/>possible grouping types:
        /// <br/><c>as_is</c> - returns data on all citations for the target <c>category_code</c>
        /// <br/><c>one_per_domain</c> - returns data on one citation of the <c>category_code</c> per domain
        /// <br/>default value: <c>as_is</c>
        /// </summary>
        [JsonProperty("search_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchMode { get; set; }

        /// <summary>
        /// maximum number of elements within internal arrays
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of elements within the following arrays:
        /// <br/><c>top_domains</c>
        /// <br/><c>text_categories</c>
        /// <br/><c>page_categories</c>
        /// <br/><c>countries</c>
        /// <br/><c>languages</c>
        /// <br/>default value: <c>1</c>
        /// <br/>maximum value: <c>20</c>
        /// </summary>
        [JsonProperty("internal_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>required field
        /// <br/>minimum value: <c>2022-10-31</c>
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2019-01-15'</c>
        /// </summary>
        [JsonProperty("date_from", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>if you don't specify this field, today's date will be used by default
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2019-01-15'</c>
        /// </summary>
        [JsonProperty("date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// time range which will be used to group the results
        /// <br/>optional field
        /// <br/>default value: <c>month</c>
        /// <br/>possible values: <c>day</c>, <c>week</c>, <c>month</c>
        /// </summary>
        [JsonProperty("date_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateGroup { get; set; }

        /// <summary>
        /// initial dataset filtering parameters
        /// <br/>optional field
        /// <br/>initial filtering parameters that apply to fields in the <see href="/v3/content_analysis/search/live/?bash">Search endpoint</see>;
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>regex</c>, <c>not_regex</c>, <c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>like</c>,<c>not_like</c>, <c>has</c>, <c>has_not</c>, <c>match</c>, <c>not_match</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c> to match any string of zero or more characters
        /// <br/>example:
        /// <br/><c>['domain','&lt;&gt;', 'logitech.com']</c>
        /// <br/><c>[['domain','&lt;&gt;','logitech.com'],'and',['content_info.connotation_types.negative','&gt;',1000]]</c>
        /// <br/><c>[['domain',''and',[['content_info.connotation_types.negative','&gt;',1000],'or',['content_info.text_category','has',10994]]]</c>
        /// <br/>for more information about filters, please refer to <see href="/v3/content_analysis/filters">Content Analysis API - Filters</see>
        /// <br/>learn more about the initial dataset filters in <see href="https://dataforseo.com/help-center/what-are-the-initial-dataset-filters-and-how-do-they-work">this help center article.</see>
        /// </summary>
        [JsonProperty("initial_dataset_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> InitialDatasetFilters { get; set; }

        /// <summary>
        /// defines the scale used for calculating and displaying the <c>rank</c> values
        /// <br/>optional field
        /// <br/>you can use this parameter to choose whether rank values are presented on a 0–100 or 0–1000 scale
        /// <br/>possible values:
        /// <br/><c>one_hundred</c> — rank values are displayed on a 0–100 scale
        /// <br/><c>one_thousand</c> — rank values are displayed on a 0–1000 scale
        /// <br/>default value: <c>one_thousand</c>
        /// <br/>learn more about how this parameter works in <see href="https://dataforseo.com/help-center/using-the-rank_scale-parameter-in-content-analysis-api">this Help Center article</see>
        /// </summary>
        [JsonProperty("rank_scale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankScale { get; set; }

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