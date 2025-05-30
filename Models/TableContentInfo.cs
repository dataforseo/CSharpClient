using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TableContentInfo 
    {

        /// <summary>
        /// parsed content of the header
        /// </summary>
        [JsonProperty("header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TableContentItemInfo> Header { get; set; }

        /// <summary>
        /// content of the body of the table
        /// </summary>
        [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TableContentItemInfo> Body { get; set; }

        /// <summary>
        /// content of the footer of the table
        /// </summary>
        [JsonProperty("footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TableContentItemInfo> Footer { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}