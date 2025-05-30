using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppStoreMetricsBundleInfo 
    {

        /// <summary>
        /// ranking data from App Store organic search
        /// </summary>
        [JsonProperty("app_store_search_organic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppMetricsInfo AppStoreSearchOrganic { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}