using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResultInfo 
    {

        /// <summary>
        /// keyword in a POST array
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// location code in a POST array
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// forecasting date interval in a POST array
        /// </summary>
        [JsonProperty("date_interval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateInterval { get; set; }

        /// <summary>
        /// include Google search partners
        /// <br/>the value you specified when setting the task
        /// <br/>Note: parameter deprecated, the value is always false
        /// </summary>
        [JsonProperty("search_partners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SearchPartners { get; set; }

        /// <summary>
        /// the maximum custom bid
        /// <br/>the bid you have specified when setting the task
        /// <br/>represents the price you are willing to pay for an ad
        /// <br/>the higher value you have specified, the higher metrics and cost you receive in response
        /// <br/>learn more in this help center article
        /// </summary>
        [JsonProperty("bid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Bid { get; set; }

        /// <summary>
        /// keywords match-type
        /// <br/>can take the following values: exact, broad, phrase
        /// </summary>
        [JsonProperty("match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Match { get; set; }

        /// <summary>
        /// projected number of ad impressions
        /// <br/>number of impressions an ad is projected to get within the specified time period
        /// <br/>Note: parameter deprecated, the value is always null
        /// </summary>
        [JsonProperty("impressions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Impressions { get; set; }

        /// <summary>
        /// projected click through rate (CTR) of the advertisement
        /// <br/>number of clicks an ad is projected to receive divided by the number of ad impressions; the CTR is projected for the specified time period
        /// <br/>Note: parameter deprecated, the value is always null
        /// </summary>
        [JsonProperty("ctr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Ctr { get; set; }

        /// <summary>
        /// the average cost-per-click value
        /// <br/>represents the cost-per-click (USD) estimated for a keyword based on the specified time period and historical data;
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [JsonProperty("average_cpc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageCpc { get; set; }

        /// <summary>
        /// total tasks cost, USD
        /// </summary>
        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; }

        /// <summary>
        /// number of clicks on an ad
        /// <br/>number of clicks an ad is projected to get within the specified time period
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [JsonProperty("clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Clicks { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}