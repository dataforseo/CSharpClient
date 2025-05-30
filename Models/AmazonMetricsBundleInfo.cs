using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AmazonMetricsBundleInfo 
    {

        /// <summary>
        /// ranking data from Amazon organic SERP
        /// </summary>
        [JsonProperty("amazon_serp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppMetricsInfo AmazonSerp { get; set; }

        /// <summary>
        /// ranking data from Amazon paid SERP
        /// </summary>
        [JsonProperty("amazon_paid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppMetricsInfo AmazonPaid { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}