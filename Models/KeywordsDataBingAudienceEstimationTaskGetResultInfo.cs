using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataBingAudienceEstimationTaskGetResultInfo 
    {

        /// <summary>
        /// monthly estimated impressions range
        /// </summary>
        [JsonProperty("est_impressions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EstInfo EstImpressions { get; set; }

        /// <summary>
        /// monthly estimated reach user count range
        /// </summary>
        [JsonProperty("est_audience_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EstInfo EstAudienceSize { get; set; }

        /// <summary>
        /// monthly estimated click count range
        /// </summary>
        [JsonProperty("est_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EstInfo EstClicks { get; set; }

        /// <summary>
        /// monthly estimated spending range
        /// </summary>
        [JsonProperty("est_spend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EstInfo EstSpend { get; set; }

        /// <summary>
        /// indicates the estimated cost per event with range result
        /// </summary>
        [JsonProperty("est_cost_per_event", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EstCInfo EstCostPerEvent { get; set; }

        /// <summary>
        /// estimated click-through rate range
        /// </summary>
        [JsonProperty("est_ctr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EstCInfo EstCtr { get; set; }

        /// <summary>
        /// suggested bid value under the current targeting
        /// </summary>
        [JsonProperty("suggested_bid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? SuggestedBid { get; set; }

        /// <summary>
        /// suggested daily budget value under the current targeting and bid
        /// </summary>
        [JsonProperty("suggested_budget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SuggestedBudget { get; set; }

        /// <summary>
        /// indicates event lost count due to insufficient input bid
        /// </summary>
        [JsonProperty("events_lost_to_bid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? EventsLostToBid { get; set; }

        /// <summary>
        /// indicates the event lost count due to insufficient input budget
        /// </summary>
        [JsonProperty("events_lost_to_budget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EventsLostToBudget { get; set; }

        /// <summary>
        /// monthly estimated user count
        /// </summary>
        [JsonProperty("est_reach_audience_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? EstReachAudienceSize { get; set; }

        /// <summary>
        /// monthly estimated impressions
        /// </summary>
        [JsonProperty("est_reach_impressions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? EstReachImpressions { get; set; }

        /// <summary>
        /// currency name
        /// <br/>example: USDollar
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}