using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ListDataInfo 
    {

        /// <summary>
        /// the most popular related topics
        /// <br/>represents the list of the most popular related topics
        /// </summary>
        [JsonProperty("top", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Top { get; set; }

        /// <summary>
        /// emerging related topics
        /// <br/>represents the list of related topics with the biggest increase in search frequency since the last time period
        /// </summary>
        [JsonProperty("rising", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Rising { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}