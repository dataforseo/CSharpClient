using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BacklinksBacklinksLiveRequestInfo 
    {

        /// <summary>
        /// domain, subdomain or webpage to get backlinks for
        /// <br/>required field
        /// <br/>a domain or a subdomain should be specified without <c>https://</c> and <c>www.</c>
        /// <br/>a page should be specified with absolute URL (including <c>http://</c> or <c>https://</c>)
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// results grouping type
        /// <br/>optional field
        /// <br/>possible grouping types:
        /// <br/><c>as_is</c> - returns all backlinks
        /// <br/><c>one_per_domain</c> - returns one backlink per domain
        /// <br/><c>one_per_anchor</c> - returns one backlink per anchor
        /// <br/>default value: <c>as_is</c>
        /// </summary>
        [JsonProperty("mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// detailed results grouping type
        /// <br/>optional field
        /// <br/>use this object to get a specific number of backlinks per <c>field</c>
        /// <br/>if you use <c>custom_mode</c>, then <c>mode</c> will be ignored
        /// <br/>example:
        /// <br/><c>'custom_mode': {'field': 'domain', 'value': 100}</c>
        /// </summary>
        [JsonProperty("custom_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> CustomMode { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>like</c>, <c>not_like</c>, <c>ilike</c>, <c>not_ilike</c>, <c>regex</c>, <c>not_regex</c>, <c>match</c>, <c>not_match</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c> to match any string of zero or more characters
        /// <br/>example:
        /// <br/><c>['rank','&gt;','80']</c>
        /// <br/><c>[['page_from_rank','&gt;','55'],'and',['dofollow','=',true]]</c>
        /// <br/><c>[['first_seen','&gt;','2017-10-23 11:31:45 +00:00'],'and',[['anchor','like','%seo%'],'or',['text_pre','like','%seo%']]]</c>
        /// <br/>The full list of possible filters is available <see href="/v3/backlinks/filters/?bash">here.</see>
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
        /// <br/><c>['rank,desc']</c>
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/><c>['domain_from_rank,desc','page_from_rank,asc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// offset in the results array of the returned backlinks
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>if you specify the <c>10</c> value, the first ten backlinks in the results array will be omitted and the data will be provided for the successive backlinks;
        /// <br/>Note: the maximum value is <c>20,000</c>, use the <c>search_after_token</c> if you would like to offset more results
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// token for subsequent requests
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>use this parameter to avoid timeouts while trying to obtain over <c>20,000</c> results in a single request;
        /// <br/>by specifying the unique <c>search_after_token</c> value from the response array, you will get the subsequent results of the initial task;
        /// <br/><c>search_after_token</c> values are unique for each subsequent task ;
        /// <br/>Note: if the <c>search_after_token</c> is specified in the request, all other parameters should be identical to the previous request
        /// </summary>
        [JsonProperty("search_after_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchAfterToken { get; set; }

        /// <summary>
        /// the maximum number of returned backlinks
        /// <br/>optional field
        /// <br/>default value: <c>100</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// set what backlinks to return and count
        /// <br/>optional field
        /// <br/>you can use this field to choose what backlinks will be returned and used for aggregated metrics for your <c>target</c>;
        /// <br/>possible values: 
        /// <br/><c>all</c> - all backlinks will be returned and counted;
        /// <br/><c>live</c> - backlinks found during the last check will be returned and counted;
        /// <br/><c>lost</c> - lost backlinks will be returned and counted;
        /// <br/>default value: <c>live</c>
        /// </summary>
        [JsonProperty("backlinks_status_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BacklinksStatusType { get; set; }

        /// <summary>
        /// indicates if the subdomains of the <c>target</c> will be included in the search
        /// <br/>optional field
        /// <br/>if set to <c>false</c>, the subdomains will be ignored
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// indicates if internal backlinks from subdomains to the <c>target</c> will be excluded from the results
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, the results will not include data on internal backlinks from subdomains of the same domain as <c>target</c>
        /// <br/>if set to <c>false</c>, internal links will be included in the results
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("exclude_internal_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeInternalBacklinks { get; set; }

        /// <summary>
        /// defines the scale used for calculating and displaying the <c>rank</c>, <c>domain_from_rank</c>, and <c>page_from_rank</c> values
        /// <br/>optional field
        /// <br/>you can use this parameter to choose whether rank values are presented on a 0–100 or 0–1000 scale
        /// <br/>possible values:
        /// <br/><c>one_hundred</c> — rank values are displayed on a 0–100 scale
        /// <br/><c>one_thousand</c> — rank values are displayed on a 0–1000 scale
        /// <br/>default value: <c>one_thousand</c>
        /// <br/>learn more about how this parameter works and how ranking metrics are calculated in <see href="https://dataforseo.com/help-center/what_is_rank_in_backlinks_api#rank_scale">this Help Center article</see>
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