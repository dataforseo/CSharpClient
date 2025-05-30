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

        /// <summary>
        /// expiry date of the backlinks api subscription
        /// <br/>date and time when the current subscription to Backlinks API expires;
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2025-06-15 12:57:46 +00:00
        /// <br/>Note: if there is no active subscription to Backlinks API, the value equals null
        /// </summary>
        [JsonProperty("backlinks_subscription_expiry_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BacklinksSubscriptionExpiryDate { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}