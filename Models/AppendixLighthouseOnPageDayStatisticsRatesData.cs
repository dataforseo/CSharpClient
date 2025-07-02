using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixLighthouseOnPageDayStatisticsRatesData 
    {
        [JsonProperty("task_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TaskPost { get; set; }
        [JsonProperty("tasks_ready", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TasksReady { get; set; }
        [JsonProperty("task_get", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TaskGet { get; set; }
        [JsonProperty("live", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Live { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Languages { get; set; }
        [JsonProperty("audits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Audits { get; set; }
        [JsonProperty("versions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Versions { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}