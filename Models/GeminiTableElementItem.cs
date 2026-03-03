using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GeminiTableElementItem  : BaseGeminiLlmScraperElementItem 
    {

        /// <summary>
        /// unformatted text content of the element
        /// </summary>
        [JsonProperty("original_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalText { get; set; }

        /// <summary>
        /// table present in the element
        /// <br/>the header and content of the table present in the element
        /// </summary>
        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Table Table { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}