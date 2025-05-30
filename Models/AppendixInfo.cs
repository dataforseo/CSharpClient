using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixInfo 
    {
        [JsonProperty("task_post", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? TaskPost { get; set; }
        [JsonProperty("task_get", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? TaskGet { get; set; }
        [JsonProperty("tasks_ready", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? TasksReady { get; set; }
        [JsonProperty("live", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? Live { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}