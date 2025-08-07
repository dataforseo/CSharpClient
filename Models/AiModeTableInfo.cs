using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiModeTableInfo 
    {

        /// <summary>
        /// content in the header of the table
        /// </summary>
        [JsonProperty("table_header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> TableHeader { get; set; }

        /// <summary>
        /// array of contents of the table present in the element
        /// <br/>each array represents the table row
        /// </summary>
        [JsonProperty("table_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<IEnumerable<string>> TableContent { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}