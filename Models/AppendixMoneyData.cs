using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixMoneyData 
    {

        /// <summary>
        /// total amount of money deposited to your account
        /// </summary>
        [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; }

        /// <summary>
        /// amount of money left in your account
        /// </summary>
        [JsonProperty("balance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Balance { get; set; }

        /// <summary>
        /// cost limits
        /// </summary>
        [JsonProperty("limits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLimitsMoneyData Limits { get; set; }

        /// <summary>
        /// statistics of your spending
        /// </summary>
        [JsonProperty("statistics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixStatisticsDataInfo Statistics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}