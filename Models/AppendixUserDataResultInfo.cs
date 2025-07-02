using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixUserDataResultInfo 
    {

        /// <summary>
        /// your login
        /// </summary>
        [JsonProperty("login", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Login { get; set; }

        /// <summary>
        /// your time zone
        /// <br/>can be set in your profile settings
        /// </summary>
        [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// your API rates
        /// </summary>
        [JsonProperty("rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixRatesData Rates { get; set; }

        /// <summary>
        /// section of your spending, USD
        /// </summary>
        [JsonProperty("money", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixMoneyData Money { get; set; }

        /// <summary>
        /// pricing
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixPriceData Price { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}