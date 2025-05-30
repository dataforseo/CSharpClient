using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class WorkDayInfo 
    {

        /// <summary>
        /// opening time
        /// </summary>
        [JsonProperty("open", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WorkTimeInfo Open { get; set; }

        /// <summary>
        /// closing time
        /// </summary>
        [JsonProperty("close", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WorkTimeInfo Close { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}