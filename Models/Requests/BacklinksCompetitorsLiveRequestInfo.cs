using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BacklinksCompetitorsLiveRequestInfo 
    {

        /// <summary>
        /// domain, subdomain or webpage to get competitor domains for
        /// <br/>required field
        /// <br/>a domain or a subdomain should be specified without https:// and www.
        /// <br/>a page should be specified with absolute URL (including http:// or https://)
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// the maximum number of returned domains
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned domains
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify the 10 value, the first ten domains in the results array will be omitted and the data will be provided for the successive pages
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, =, &lt;&gt;, in, not_in, like, not_like, ilike, not_ilike, match, not_match
        /// <br/>you can use the % operator with like and not_like to match any string of zero or more characters
        /// <br/>example:
        /// <br/>['rank','&gt;','100']
        /// <br/>[['target','like','%forbes%'],
        /// <br/>'and',
        /// <br/>[['rank','&gt;','100'],'or',['intersections','&gt;','5']]]
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
        /// <br/>['rank,desc']
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>['intersections,desc','rank,asc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// indicates if only main domain of the target will be included in the search
        /// <br/>optional field
        /// <br/>if set to true, only the main domain will be included in search;
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("main_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MainDomain { get; set; }

        /// <summary>
        /// indicates whether large domain will appear in results
        /// <br/>optional field
        /// <br/>if set to true, the results from the large domain (google.com, amazon.com, etc.) will be omitted;
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("exclude_large_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeLargeDomains { get; set; }

        /// <summary>
        /// indicates if internal backlinks from subdomains to the target will be excluded from the results
        /// <br/>optional field
        /// <br/>if set to true, the results will not include data on internal backlinks from subdomains of the same domain as target
        /// <br/>if set to false, internal links will be included in the results
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("exclude_internal_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeInternalBacklinks { get; set; }

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