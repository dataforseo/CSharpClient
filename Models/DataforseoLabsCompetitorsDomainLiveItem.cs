using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsCompetitorsDomainLiveItem 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// domain name
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// average position of the domain in SERP
        /// <br/>Note: average position is calculated for intersected keywords only;
        /// <br/>the value for a given domain may differ when combined with different target websites
        /// </summary>
        [JsonProperty("avg_position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? AvgPosition { get; set; }

        /// <summary>
        /// sum of all domain positions in SERP
        /// <br/>Note: average position is calculated for intersected keywords only;
        /// <br/>the value for a given domain may differ when combined with different target websites
        /// </summary>
        [JsonProperty("sum_position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SumPosition { get; set; }

        /// <summary>
        /// number of intersecting keywords
        /// </summary>
        [JsonProperty("intersections", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Intersections { get; set; }

        /// <summary>
        /// metrics for all keywords of the domain
        /// <br/>full overview of ranking and traffic data relevant to all keywords that the provided domain is ranking for
        /// </summary>
        [JsonProperty("full_domain_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, DataforseoLabsMetricsInfo> FullDomainMetrics { get; set; }

        /// <summary>
        /// metrics for intersecting keywords
        /// <br/>ranking and traffic data relevant to the keywords that the provided domain shares with the target domain
        /// <br/>note: in this array ranking and traffic data is provided for the target considering the keywords target shares in search with the competitor’s domain
        /// </summary>
        [JsonProperty("metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, DataforseoLabsMetricsInfo> Metrics { get; set; }

        /// <summary>
        /// metrics for intersecting keywords
        /// <br/>ranking and traffic data relevant to the keywords that the provided domain shares with the target domain
        /// <br/>note: in this array ranking and traffic data is provided for the returned competitor’s domain
        /// </summary>
        [JsonProperty("competitor_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, DataforseoLabsMetricsInfo> CompetitorMetrics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}