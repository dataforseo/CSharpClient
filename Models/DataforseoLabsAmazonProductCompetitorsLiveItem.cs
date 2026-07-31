using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsAmazonProductCompetitorsLiveItem 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// ASIN in a POST array
        /// </summary>
        [JsonProperty("asin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Asin { get; set; }

        /// <summary>
        /// average position of the product in Amazon SERP
        /// <br/>Note: average position is calculated for intersected keywords only;
        /// <br/>the value for a given product may differ when combined with different target products
        /// </summary>
        [JsonProperty("avg_position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? AvgPosition { get; set; }

        /// <summary>
        /// sum of all product positions in Amazon SERP
        /// <br/>Note: average position is calculated for intersected keywords only;
        /// <br/>the value for a given product may differ when combined with different target products
        /// </summary>
        [JsonProperty("sum_position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SumPosition { get; set; }

        /// <summary>
        /// number of intersecting keywords
        /// </summary>
        [JsonProperty("intersections", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intersections { get; set; }

        /// <summary>
        /// metrics for intersecting keywords
        /// <br/>ranking data relevant to the keywords that the provided <c>asin</c> shares with the target <c>asin</c>;
        /// <br/>Note: in this object ranking data is provided for the returned competitor's <c>asin</c>
        /// </summary>
        [JsonProperty("competitor_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AmazonMetricsBundleInfo CompetitorMetrics { get; set; }

        /// <summary>
        /// metrics for all keywords of the product
        /// <br/>full overview of ranking data relevant to all keywords that the provided <c>asin</c> is ranking for
        /// </summary>
        [JsonProperty("full_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AmazonMetricsBundleInfo FullMetrics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}