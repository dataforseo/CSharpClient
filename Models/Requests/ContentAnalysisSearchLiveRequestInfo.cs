using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class ContentAnalysisSearchLiveRequestInfo 
    {

        /// <summary>
        /// target keyword
        /// <br/>required field
        /// <br/>UTF-8 encoding
        /// <br/>the keywords will be converted to a lowercase format;
        /// <br/>Note: to match an exact phrase instead of a stand-alone keyword, use double quotes and backslashes; 
        /// <br/>example: 
        /// <br/>`'keyword': '\'tesla palo alto\''`
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// target keyword fields and target keywords
        /// <br/>optional field
        /// <br/>use this parameter to filter the dataset by keywords that certain fields should contain;
        /// <br/>fields you can specify: <c>title</c>, <c>main_title</c>, <c>previous_title</c>, <c>snippet</c>
        /// <br/>you can indicate several fields;
        /// <br/>Note: to match an exact phrase instead of a stand-alone keyword, use double quotes and backslashes; 
        /// <br/>example:
        /// <br/>`'keyword_fields': {
        /// <br/>'snippet': '\'logitech mouse\'',
        /// <br/>'main_title': 'sale'
        /// <br/>}'`
        /// </summary>
        [JsonProperty("keyword_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> KeywordFields { get; set; }

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
        /// <br/><c>as_is</c> - returns all citations for the target <c>keyword</c>
        /// <br/><c>one_per_domain</c> - returns one citation of the <c>keyword</c> per domain
        /// <br/>default value: <c>as_is</c>
        /// </summary>
        [JsonProperty("search_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchMode { get; set; }

        /// <summary>
        /// the maximum number of returned citations
        /// <br/>optional field
        /// <br/>default value: <c>100</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>regex</c>, <c>not_regex</c>, <c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>like</c>,<c>not_like</c>, <c>match</c>, <c>not_match</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c> to match any string of zero or more characters
        /// <br/>example:
        /// <br/><c>['country','=', 'US']</c>
        /// <br/><c>[['domain_rank','&gt;',800],'and',['content_info.connotation_types.negative','&gt;',0.9]]</c>
        /// <br/><c>[['domain_rank','&gt;',800],'and',[['page_types','has','ecommerce'],'or',['content_info.text_category','has',10994]]]</c>
        /// <br/>for more information about filters, please refer to <see href="/v3/content_analysis/filters">Content Analysis API - Filters</see>
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
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/><c>['content_info.sentiment_connotations.anger,desc']</c>
        /// <br/>default rule:
        /// <br/><c>['content_info.sentiment_connotations.anger,desc']</c>
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/><c>['content_info.sentiment_connotations.anger,desc','keyword_data.keyword_info.cpc,desc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// offset in the results array of returned citations
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>if you specify the <c>10</c> value, the first ten citations in the results array will be omitted and the data will be provided for the successive citations
        /// <br/>Note: we recommend using this parameter only when retrieving up to 10,000 results
        /// <br/>for retrieving over 10,000 results, use the <c>offset_token</c> instead.
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// offset token for subsequent requests
        /// <br/>optional field
        /// <br/>provided in the identical field of the response to each request;
        /// <br/>use this parameter to avoid timeouts while trying to obtain over 10,000 results in a single request;
        /// <br/>by specifying the unique <c>offset_token</c> value from the response array, you will get the subsequent results of the initial task;
        /// <br/><c>offset_token</c> values are unique for each subsequent task 
        /// <br/>Note: if the <c>offset_token</c> is specified in the request, all other parameters except <c>limit</c> will not be taken into account when processing a task
        /// <br/>learn more about this parameter on our <see href="https://dataforseo.com/help-center/what-is-the-difference-between-the-offset-and-offset_token-parameters#offset_token">Help Center</see>
        /// </summary>
        [JsonProperty("offset_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OffsetToken { get; set; }

        /// <summary>
        /// defines the scale used for calculating and displaying the <c>domain_rank</c>, and <c>url_rank</c> values
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