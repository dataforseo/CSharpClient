using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class MonthlySearchesInfo 
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
        /// monthly average search volume rate
        /// </summary>
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SearchVolume { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}