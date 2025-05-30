using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class HistoricalMetricsBundleInfo 
    {

        /// <summary>
        /// traffic data from organic search
        /// </summary>
        [JsonProperty("organic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<HistoricalMetricsInfo> Organic { get; set; }

        /// <summary>
        /// traffic data from paid search
        /// </summary>
        [JsonProperty("paid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<HistoricalMetricsInfo> Paid { get; set; }

        /// <summary>
        /// traffic data from the local pack results in SERP
        /// </summary>
        [JsonProperty("local_pack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<HistoricalMetricsInfo> LocalPack { get; set; }

        /// <summary>
        /// traffic data from the featured snippet results in Google SERP
        /// </summary>
        [JsonProperty("featured_snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<HistoricalMetricsInfo> FeaturedSnippet { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}