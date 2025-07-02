using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageLighthouseAuditsResultInfo 
    {

        /// <summary>
        /// the list of available lighthouse audits
        /// <br/>an array containing the titles of available audits
        /// <br/>Note: the titles can change depending on if the audit passed or failed and may contain markdown code
        /// </summary>
        [JsonProperty("audits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Audits { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}