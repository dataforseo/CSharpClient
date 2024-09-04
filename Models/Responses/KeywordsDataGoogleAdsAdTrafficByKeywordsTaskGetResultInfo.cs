using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResultInfo
    {
        /// <summary>
        /// keyword in a POST array
        /// <br/>metrics are provided for all the keywords specified in the POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// location code in a POST array
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// forecasting date interval in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_interval", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateInterval { get; set; }

        /// <summary>
        /// include Google search partners
        /// <br/>the value you specified when setting the task
        /// <br/>if true, the results are returned for owned, operated, and syndicated networks across Google and partner sites that host Google search;
        /// <br/>if false, the results are returned for Google search sites only
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_partners", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SearchPartners { get; set; }

        /// <summary>
        /// the maximum custom bid
        /// <br/>the bid you have specified when setting the task
        /// <br/>represents the price you are willing to pay for an ad
        /// <br/>the higher value you have specified, the higher metrics and cost you receive in response
        /// <br/>learn more in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Bid { get; set; }

        /// <summary>
        /// keywords match-type
        /// <br/>can take the following values: exact, broad, phrase
        /// </summary>
        [Newtonsoft.Json.JsonProperty("match", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Match { get; set; }

        /// <summary>
        /// projected number of ad impressions
        /// <br/>number of impressions an ad is projected to get within the specified time period
        /// <br/>if there is no data, then the value is null
        /// <br/>learn more about impressions in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("impressions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Impressions { get; set; }

        /// <summary>
        /// projected clickthrough rate (CTR) of the advertisement
        /// <br/>number of clicks an ad is projected to receive divided by the number of ad impressions; the CTR is projected for the specified time period
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ctr { get; set; }

        /// <summary>
        /// the average cost-per-click value
        /// <br/>represents the cost-per-click (USD) estimated for a keyword based on the specified time period and historical data;
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("average_cpc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AverageCpc { get; set; }

        /// <summary>
        /// charge for an ad
        /// <br/>amount that will be charged for running an ad within the specified time period
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Cost { get; set; }

        /// <summary>
        /// number of clicks on an ad
        /// <br/>number of clicks an ad is projected to get within the specified time period
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clicks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Clicks { get; set; }

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