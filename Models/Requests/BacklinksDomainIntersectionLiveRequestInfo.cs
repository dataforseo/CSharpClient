using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BacklinksDomainIntersectionLiveRequestInfo 
    {

        /// <summary>
        /// domains, subdomains or webpages to get links for
        /// <br/>required field
        /// <br/>you can set up to 20 domains, subdomains or webpages
        /// <br/>a domain or a subdomain should be specified without https:// and www.
        /// <br/>a page should be specified with absolute URL (including http:// or https://)
        /// <br/>example:
        /// <br/>'targets': {
        /// <br/>'1': 'http://planet.postgresql.org/',
        /// <br/>'2': 'http://gborg.postgresql.org/'
        /// <br/>}
        /// </summary>
        [JsonProperty("targets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Targets { get; set; }

        /// <summary>
        /// domains, subdomains or webpages you want to exclude
        /// <br/>optional field
        /// <br/>you can specify up to 10 domains, subdomains or webpages
        /// <br/>if you use this array, results will contain the referring domains that link to targets but don’t link to exclude_targets
        /// <br/>example:
        /// <br/>'exclude_targets': [
        /// <br/>'bbc.com',
        /// <br/>'https://www.apple.com/iphone/*',
        /// <br/>'https://dataforseo.com/apis/*']
        /// </summary>
        [JsonProperty("exclude_targets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ExcludeTargets { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, =, &lt;&gt;, in, not_in, like, not_like, ilike, not_ilike, match, not_match
        /// <br/>you can use the % operator with like and not_like to match any string of zero or more characters
        /// <br/>example:
        /// <br/>['1.internal_links_count','&gt;','1']
        /// <br/>[['2.referring_pages','&gt;','2'],
        /// <br/>'and',
        /// <br/>['1.backlinks','&gt;','10']]
        /// <br/>[['1.first_seen','&gt;','2017-10-23 11:31:45 +00:00'],
        /// <br/>'and',
        /// <br/>[['2.target','like','%dataforseo.com%'],'or',['1.referring_domains','&gt;','10']]]
        /// <br/>The full list of possible filters is available here.
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
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/>['backlinks,desc']
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>['backlinks,desc','rank,asc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// offset in the array of returned results
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify the 10 value, the first ten backlinks in the results array will be omitted and the data will be provided for the successive backlinks
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// the maximum number of returned results
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// maximum number of elements within internal arrays
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of elements within the following arrays:
        /// <br/>referring_links_tld
        /// <br/>referring_links_types
        /// <br/>referring_links_attributes
        /// <br/>referring_links_platform_types
        /// <br/>referring_links_semantic_locations
        /// <br/>default value: 10
        /// <br/>maximum value: 1000
        /// </summary>
        [JsonProperty("internal_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

        /// <summary>
        /// set what backlinks to return and count
        /// <br/>optional field
        /// <br/>you can use this field to choose what backlinks will be returned and used for aggregated metrics for your targets;
        /// <br/>possible values:
        /// <br/>all – all backlinks will be returned and counted;
        /// <br/>live – backlinks found during the last check will be returned and counted;
        /// <br/>lost – lost backlinks will be returned and counted;
        /// <br/>default value: live
        /// </summary>
        [JsonProperty("backlinks_status_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BacklinksStatusType { get; set; }

        /// <summary>
        /// filter the backlinks of your target
        /// <br/>optional field
        /// <br/>you can use this field to filter the initial backlinks that will be included in the dataset for aggregated metrics for your target
        /// <br/>you can filter the backlinks by all fields available in the response of this endpoint
        /// <br/>using this parameter, you can include only dofollow backlinks in the response and create a flexible backlinks dataset to calculate the metrics for
        /// <br/>example:
        /// <br/>'backlinks_filters': [['dofollow', '=', true]]
        /// </summary>
        [JsonProperty("backlinks_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> BacklinksFilters { get; set; }

        /// <summary>
        /// indicates if the subdomains of the target will be included in the search
        /// <br/>optional field
        /// <br/>if set to false, the subdomains will be ignored
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// indicates if indirect links to the targets will be included in the results
        /// <br/>optional field
        /// <br/>if set to true, the results will include data on indirect links pointing to a page that either redirects to a target, or points to a canonical page
        /// <br/>if set to false, indirect links will be ignored
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("include_indirect_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeIndirectLinks { get; set; }

        /// <summary>
        /// indicates whether the backlinks from subdomains of the target are excluded
        /// <br/>optional field
        /// <br/>if set to false, the backlinks from subdomains of the target will be omitted and you won’t receive the same domain in the response;
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("exclude_internal_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeInternalBacklinks { get; set; }

        /// <summary>
        /// indicates whether to intersect backlinks
        /// <br/>optional field
        /// <br/>use this field to intersect or merge results for the specified domains
        /// <br/>possible values: all, partial
        /// <br/>all – results are based on all backlinks;
        /// <br/>partial – results are based on the intersecting backlinks only;
        /// <br/>default value: all
        /// </summary>
        [JsonProperty("intersection_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionMode { get; set; }

        /// <summary>
        /// defines the scale used for calculating and displaying the rank, domain_from_rank, and page_from_rank values
        /// <br/>optional field
        /// <br/>you can use this parameter to choose whether rank values are presented on a 0–100 or 0–1000 scale
        /// <br/>possible values:
        /// <br/>one_hundred — rank values are displayed on a 0–100 scale
        /// <br/>one_thousand — rank values are displayed on a 0–1000 scale
        /// <br/>default value: one_thousand
        /// <br/>learn more about how this parameter works and how ranking metrics are calculated in this Help Center article
        /// </summary>
        [JsonProperty("rank_scale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankScale { get; set; }

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