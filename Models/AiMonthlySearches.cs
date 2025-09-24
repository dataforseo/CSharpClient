using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiMonthlySearches 
    {

        /// <summary>
        /// year
        /// </summary>
        [JsonProperty("year", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Year { get; set; }

        /// <summary>
        /// month
        /// </summary>
        [JsonProperty("month", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Month { get; set; }

        /// <summary>
        /// AI search volume rate in a certain month of a year
        /// <br/>learn more about this metric here
        /// </summary>
        [JsonProperty("ai_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? AiSearchVolume { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}