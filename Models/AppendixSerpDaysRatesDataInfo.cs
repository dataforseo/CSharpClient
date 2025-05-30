using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixSerpDaysRatesDataInfo 
    {
        [JsonProperty("task_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TaskPost { get; set; }
        [JsonProperty("task_get", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixFunctionTypeInfo TaskGet { get; set; }
        [JsonProperty("tasks_ready", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TasksReady { get; set; }
        [JsonProperty("locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Locations { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Languages { get; set; }
        [JsonProperty("live", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixFunctionTypeInfo Live { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Errors { get; set; }
        [JsonProperty("tasks_fixed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TasksFixed { get; set; }
        [JsonProperty("jobs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixJobsSerpLimitsRatesDataInfo Jobs { get; set; }
        [JsonProperty("screenshot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Screenshot { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}