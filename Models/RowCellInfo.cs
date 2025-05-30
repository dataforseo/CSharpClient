using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class RowCellInfo 
    {

        /// <summary>
        /// content of the row cells of the header
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// contains other URLs and anchors found in the content element
        /// </summary>
        [JsonProperty("urls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ContentUrlInfo> Urls { get; set; }

        /// <summary>
        /// content of the row cells of the header
        /// </summary>
        [JsonProperty("is_header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHeader { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}