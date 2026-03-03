using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GeminiTextElementItem  : BaseGeminiLlmScraperElementItem 
    {

        /// <summary>
        /// unformatted text content of the element
        /// </summary>
        [JsonProperty("original_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalText { get; set; }

        /// <summary>
        /// array of sources
        /// </summary>
        [JsonProperty("sources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SourceInfo> Sources { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}