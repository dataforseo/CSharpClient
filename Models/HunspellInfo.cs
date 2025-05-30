using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class HunspellInfo 
    {

        /// <summary>
        /// spellcheck language code
        /// </summary>
        [JsonProperty("hunspell_language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HunspellLanguageCode { get; set; }

        /// <summary>
        /// array of misspelled words
        /// </summary>
        [JsonProperty("misspelled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<HunspellMisspelledInfo> Misspelled { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}