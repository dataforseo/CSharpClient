using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixUserDataResultInfo
    {
        /// <summary>
        /// your login
        /// </summary>
        [Newtonsoft.Json.JsonProperty("login", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Login { get; set; }

        /// <summary>
        /// your time zone
        /// <br/>can be set in your profile settings
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timezone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// your API rates
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixRatesData Rates { get; set; }

        /// <summary>
        /// section of your spending, USD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("money", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixMoneyData Money { get; set; }

        /// <summary>
        /// pricing
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixPriceData Price { get; set; }

        /// <summary>
        /// expiry date of the backlinks api subscription
        /// <br/>date and time when the current subscription to Backlinks API expires;
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2025-06-15 12:57:46 +00:00
        /// <br/>Note: if there is no active subscription to Backlinks API, the value equals null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlinks_subscription_expiry_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BacklinksSubscriptionExpiryDate { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}