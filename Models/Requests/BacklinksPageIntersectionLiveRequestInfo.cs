using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BacklinksPageIntersectionLiveRequestInfo 
    {

        /// <summary>
        /// domains, subdomains or webpages to get links for
        /// <br/>required field
        /// <br/>you can set up to 20 domains, subdomains or webpages
        /// <br/>a domain or a subdomain should be specified without <c>https://</c> and <c>www.</c>
        /// <br/>a page should be specified with absolute URL (including <c>http://</c> or <c>https://</c>)
        /// <br/>example:
        /// <br/>`'targets': {
        /// <br/>'1': 'http://planet.postgresql.org/',
        /// <br/>'2': 'http://gborg.postgresql.org/'
        /// <br/>}`
        /// </summary>
        [JsonProperty("targets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Targets { get; set; }

        /// <summary>
        /// domains, subdomains or webpages you want to exclude
        /// <br/>optional field
        /// <br/>you can set up to 10 domains, subdomains or webpages
        /// <br/>if you use this array, results will contain the referring pages that link to <c>targets</c> but don't link to <c>exclude_targets</c>
        /// <br/>example:
        /// <br/>`'exclude_targets': [
        /// <br/>'bbc.com',
        /// <br/>'https://www.apple.com/iphone/*',
        /// <br/>'https://dataforseo.com/apis/*']`
        /// </summary>
        [JsonProperty("exclude_targets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ExcludeTargets { get; set; }

        /// <summary>
        /// set what backlinks to return and count
        /// <br/>optional field
        /// <br/>you can use this field to choose what backlinks will be returned and used for aggregated metrics for your <c>targets</c>;
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
        /// <br/><c>['1.rank','&gt;','80']</c>
        /// <br/><c>[['2.page_from_rank','&gt;','55'],'and',['1.original','=','true']]</c>
        /// <br/><c>[['1.first_seen','&gt;','2017-10-23 11:31:45 +00:00'],'and',[['1.acnhor','like','%seo%'],'or',['1.text_pre','not_like','%seo%']]]</c>
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
        /// <br/>if you specify the <c>10</c> value, the first ten backlinks in the results array will be omitted and the data will be provided for the successive backlinks
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// the maximum number of returned backlinks
        /// <br/>optional field
        /// <br/>default value: <c>100</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// maximum number of elements within internal arrays
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of elements within the following arrays:
        /// <br/><c>attributes</c>
        /// <br/><c>domain_from_platform_type</c>
        /// <br/>default value: <c>10</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("internal_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

        /// <summary>
        /// indicates if the subdomains of the <c>targets</c> will be included in the search
        /// <br/>optional field
        /// <br/>if set to <c>false</c>, the subdomains will be ignored
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// indicates if indirect links to the <c>targets</c> will be included in the results
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, the results will include data on indirect links pointing to a page that either redirects to a target, or points to a canonical page
        /// <br/>if set to <c>false</c>, indirect links will be ignored
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("include_indirect_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeIndirectLinks { get; set; }

        /// <summary>
        /// indicates if internal backlinks from subdomains to the <c>target</c> will be excluded from the results
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, the results will not include data on internal backlinks from subdomains of the same domain as <c>target</c>
        /// <br/>if set to <c>false</c>, internal links will be included in the result
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("exclude_internal_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeInternalBacklinks { get; set; }

        /// <summary>
        /// indicates whether to intersect backlinks
        /// <br/>optional field
        /// <br/>use this field to intersect or merge results for the specified URLs
        /// <br/>possible values: <c>all</c>, <c>partial</c>
        /// <br/><c>all</c> - results are based on all backlinks;
        /// <br/><c>partial</c> - results are based on the intersecting backlinks only;
        /// <br/>default value: <c>all</c>
        /// </summary>
        [JsonProperty("intersection_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionMode { get; set; }

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