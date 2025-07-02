using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TestSummary 
    {

        /// <summary>
        /// number of fatal microdata errors
        /// </summary>
        [JsonProperty("fatal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fatal { get; set; }

        /// <summary>
        /// number of serious microdata errors
        /// </summary>
        [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Error { get; set; }

        /// <summary>
        /// number of microdata warnings
        /// </summary>
        [JsonProperty("warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Warning { get; set; }

        /// <summary>
        /// number of microdata information flags
        /// </summary>
        [JsonProperty("info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Info { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}