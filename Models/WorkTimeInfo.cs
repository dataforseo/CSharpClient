using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class WorkTimeInfo 
    {

        /// <summary>
        /// hours in the 24-hour format
        /// </summary>
        [JsonProperty("hour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hour { get; set; }

        /// <summary>
        /// minutes
        /// </summary>
        [JsonProperty("minute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Minute { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}