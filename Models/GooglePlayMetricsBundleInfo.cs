using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GooglePlayMetricsBundleInfo 
    {

        /// <summary>
        /// ranking data from Google Play organic search
        /// </summary>
        [JsonProperty("google_play_search_organic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppMetricsInfo GooglePlaySearchOrganic { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}