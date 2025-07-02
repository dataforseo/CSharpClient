using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SearchVolumeTrend 
    {

        /// <summary>
        /// search volume change in percent compared to the previous month
        /// </summary>
        [JsonProperty("monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Monthly { get; set; }

        /// <summary>
        /// search volume change in percent compared to the previous quarter
        /// </summary>
        [JsonProperty("quarterly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quarterly { get; set; }

        /// <summary>
        /// search volume change in percent compared to the previous year
        /// </summary>
        [JsonProperty("yearly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Yearly { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}