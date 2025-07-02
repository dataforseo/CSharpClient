using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class EstInfo 
    {

        /// <summary>
        /// indicates the upper bound of the range result
        /// </summary>
        [JsonProperty("high", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? High { get; set; }

        /// <summary>
        /// indicates the lower bound of the range result
        /// </summary>
        [JsonProperty("low", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Low { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}