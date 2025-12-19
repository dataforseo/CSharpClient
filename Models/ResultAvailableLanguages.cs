using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ResultAvailableLanguages 
    {

        /// <summary>
        /// supported LLM platforms
        /// <br/>contains the sources of data supported for a specific location and language combination
        /// <br/>only google and chat_gpt are currently available
        /// </summary>
        [JsonProperty("available_platforms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> AvailablePlatforms { get; set; }

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
        /// number of LLM responses
        /// <br/>the number of LLM responses available in the database for the certain location and language parameters
        /// </summary>
        [JsonProperty("responses_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ResponsesCount { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}