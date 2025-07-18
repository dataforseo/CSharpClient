using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class Subtitles 
    {

        /// <summary>
        /// language of subtitles
        /// </summary>
        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// defines if subtitles are translatable
        /// </summary>
        [JsonProperty("is_translatable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTranslatable { get; set; }

        /// <summary>
        /// defines if subtitles are auto generated
        /// </summary>
        [JsonProperty("is_auto_generated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoGenerated { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}