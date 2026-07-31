using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BacklinksSummaryLiveRequestInfo 
    {

        /// <summary>
        /// domain, subdomain or webpage to get data for
        /// <br/>required field
        /// <br/>a domain or a subdomain should be specified without <c>https://</c> and <c>www.</c>
        /// <br/>a page should be specified with absolute URL (including <c>http://</c> or <c>https://</c>)
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// indicates if the subdomains of the <c>target</c> will be included in the search
        /// <br/>optional field
        /// <br/>if set to <c>false</c>, the subdomains will be ignored
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// indicates if indirect links to the <c>target</c> will be included in the results
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, the results will include data on indirect links pointing to a page that either redirects to the target, or points to a canonical page
        /// <br/>if set to <c>false</c>, indirect links will be ignored
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("include_indirect_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeIndirectLinks { get; set; }

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