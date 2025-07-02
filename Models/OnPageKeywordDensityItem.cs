using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageKeywordDensityItem 
    {

        /// <summary>
        /// returned keyword
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// keyword frequency
        /// <br/>number of times the keyword appears on the website (or webpage if you specified a url)
        /// </summary>
        [JsonProperty("frequency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Frequency { get; set; }

        /// <summary>
        /// keyword density
        /// <br/>calculated as a ratio of frequency to the total count of keywords with the set keyword_length on the web page or website
        /// </summary>
        [JsonProperty("density", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Density { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}