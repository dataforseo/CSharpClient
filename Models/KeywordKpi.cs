using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordKpi 
    {

        /// <summary>
        /// keyword data aggregated for desktop devices
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [JsonProperty("desktop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KeywordKpiInfo> Desktop { get; set; }

        /// <summary>
        /// keyword data aggregated for mobile devices
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [JsonProperty("mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KeywordKpiInfo> Mobile { get; set; }

        /// <summary>
        /// keyword data aggregated for tablet devices
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [JsonProperty("tablet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KeywordKpiInfo> Tablet { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}