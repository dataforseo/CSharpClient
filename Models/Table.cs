using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class Table 
    {

        /// <summary>
        /// name assigned to the table element
        /// <br/>possible values:
        /// <br/>table_element
        /// </summary>
        [JsonProperty("table_element", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TableElement { get; set; }

        /// <summary>
        /// column names
        /// </summary>
        [JsonProperty("table_header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> TableHeader { get; set; }

        /// <summary>
        /// the content of the table
        /// <br/>one line of the table in this element of the array
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