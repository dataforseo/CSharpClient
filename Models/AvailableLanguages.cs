using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AvailableLanguages 
    {

        /// <summary>
        /// supported sources
        /// <br/>contains the sources of data supported for a specific location and language combination
        /// <br/>only google and bing are currently available
        /// </summary>
        [JsonProperty("available_sources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> AvailableSources { get; set; }

        /// <summary>
        /// language name
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code according to ISO 639-1
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// the number of keywords available for the given location and language
        /// </summary>
        [JsonProperty("keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Keywords { get; set; }

        /// <summary>
        /// the number of SERP pages available for the given location and language
        /// </summary>
        [JsonProperty("serps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Serps { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}