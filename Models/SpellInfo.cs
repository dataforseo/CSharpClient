using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SpellInfo 
    {

        /// <summary>
        /// keyword obtained as a result of search engine autocorrection
        /// <br/> the results will be provided for the corrected keyword
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// type of autocorrection
        /// <br/> possible values:
        /// <br/> did_you_mean, showing_results_for, no_results_found_for, including_results_for
        /// <br/> note: Yahoo and Yandex support only the following autocorrection type:
        /// <br/> including_results_for
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}