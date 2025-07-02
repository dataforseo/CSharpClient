using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsAppleAppCompetitorsLiveItem 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// id of the competitor app
        /// </summary>
        [JsonProperty("app_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// average position of the app in App Store SERP
        /// <br/>Note: average position is calculated for intersected keywords only;
        /// <br/>the value for a given application may differ when combined with different target applications
        /// </summary>
        [JsonProperty("avg_position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? AvgPosition { get; set; }

        /// <summary>
        /// sum of all app positions in App Store SERP
        /// <br/>Note: sum position is calculated for intersected keywords only;
        /// <br/>the value for a given application may differ when combined with different target applications
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
        /// <br/>ranking data relevant to the keywords that the provided competitor application shares with the app in a POST request;
        /// <br/>note: in this array ranking data is provided for the returned competitor’s app_id
        /// </summary>
        [JsonProperty("competitor_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppStoreMetricsBundleInfo CompetitorMetrics { get; set; }

        /// <summary>
        /// metrics for all keywords of the application
        /// <br/>full overview of ranking data relevant to all keywords that the provided app_id is ranking for
        /// </summary>
        [JsonProperty("full_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppStoreMetricsBundleInfo FullMetrics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}