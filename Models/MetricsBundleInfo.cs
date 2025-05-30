using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class MetricsBundleInfo 
    {

        /// <summary>
        /// ranking and traffic data from organic search
        /// </summary>
        [JsonProperty("organic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public OrganicMetricsInfo Organic { get; set; }

        /// <summary>
        /// ranking and traffic data from paid search
        /// </summary>
        [JsonProperty("paid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PaidMetricsInfo Paid { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}