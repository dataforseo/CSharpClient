using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DomainAnalyticsTechnologiesTechnologiesResultInfo 
    {

        /// <summary>
        /// array of technology groups
        /// </summary>
        [JsonProperty("groups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Groups> Groups { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}