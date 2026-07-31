using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BacklinksDomainPagesLiveRequestInfo 
    {

        /// <summary>
        /// domain or subdomain
        /// <br/>required field
        /// <br/>a domain or a subdomain should be specified without <c>https://</c> and <c>www.</c>
        /// <br/>example:
        /// <br/><c>forbes.com</c>
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// the maximum number of returned pages
        /// <br/>optional field
        /// <br/>default value: <c>100</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned pages
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>if you specify the <c>10</c> value, the first ten pages in the results array will be omitted and the data will be provided for the successive pages
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// maximum number of elements within internal arrays
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of elements within the following arrays:
        /// <br/><c>referring_links_tld</c>
        /// <br/><c>referring_links_types</c>
        /// <br/><c>referring_links_attributes</c>
        /// <br/><c>referring_links_platform_types</c>
        /// <br/><c>referring_links_semantic_locations</c>
        /// <br/>default value: <c>10</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("internal_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

        /// <summary>
        /// set what backlinks to return and count
        /// <br/>optional field
        /// <br/>you can use this field to choose what backlinks will be returned and used for aggregated metrics;
        /// <br/>possible values: 
        /// <br/><c>all</c> - all backlinks will be returned and counted;
        /// <br/><c>live</c> - backlinks found during the last check will be returned and counted;
        /// <br/><c>lost</c> - lost backlinks will be returned and counted;
        /// <br/>default value: <c>live</c>
        /// </summary>
        [JsonProperty("backlinks_status_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BacklinksStatusType { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>regex</c>, <c>not_regex</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>like</c>, <c>not_like</c>, <c>ilike</c>, <c>not_ilike</c>, <c>match</c>, <c>not_match</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c> to match any string of zero or more characters
        /// <br/>example:
        /// <br/><c>['meta.internal_links_count','&gt;','1']</c>
        /// <br/><c>[['meta.external_links_count','&gt;','2'],'and',['backlinks','&gt;','10']]</c>
        /// <br/><c>[['first_visited','&gt;','2017-10-23 11:31:45 +00:00'],'and',[['title','like','%seo%'],'or',['referring_domains','&gt;','10']]]</c>
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
        /// <br/><c>['page_summary.backlinks,desc']</c>
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/><c>['page_summary.backlinks,desc','page_summary.rank,asc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// filter the backlinks of your <c>target</c>
        /// <br/>optional field
        /// <br/>you can use this field to filter the initial backlinks that will be included in the dataset for aggregated metrics for your <c>target</c>
        /// <br/>you can filter the backlinks by all fields available in the response of <see href="/v3/backlinks/backlinks/live">this endpoint</see>
        /// <br/>using this parameter, you can include only dofollow backlinks in the response and create a flexible backlinks dataset to calculate the metrics for
        /// <br/>example:
        /// <br/><c>'backlinks_filters': ['dofollow', '=', true]</c>
        /// </summary>
        [JsonProperty("backlinks_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> BacklinksFilters { get; set; }

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