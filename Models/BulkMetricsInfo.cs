using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BulkMetricsInfo 
    {

        /// <summary>
        /// estimated traffic volume
        /// <br/>estimated organic monthly traffic to the domain
        /// <br/>calculated as the product of CTR (click-through-rate) and search volume values of all keywords the domain ranks for
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Etv { get; set; }

        /// <summary>
        /// total count of organic SERPs that contain the domain
        /// </summary>
        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// estimated traffic volume based on clickstream data
        /// <br/>calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for
        /// <br/>to retrieve results for this field, the parameter include_clickstream_data must be set to true
        /// <br/>learn more about how the metric is calculated in this help center article https://dataforseo.com/help-center/whats-clickstream-estimated-traffic-volume-and-how-is-it-calculated
        /// </summary>
        [JsonProperty("clickstream_etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClickstreamEtv { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}