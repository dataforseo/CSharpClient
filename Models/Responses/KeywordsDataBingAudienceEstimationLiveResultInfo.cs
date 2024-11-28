using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataBingAudienceEstimationLiveResultInfo
    {
        /// <summary>
        /// monthly estimated impressions range
        /// </summary>
        [Newtonsoft.Json.JsonProperty("est_impressions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EstInfo EstImpressions { get; set; }

        /// <summary>
        /// monthly estimated reach user count range
        /// </summary>
        [Newtonsoft.Json.JsonProperty("est_audience_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EstInfo EstAudienceSize { get; set; }

        /// <summary>
        /// monthly estimated click count range
        /// </summary>
        [Newtonsoft.Json.JsonProperty("est_clicks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EstInfo EstClicks { get; set; }

        /// <summary>
        /// monthly estimated spending range
        /// </summary>
        [Newtonsoft.Json.JsonProperty("est_spend", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EstInfo EstSpend { get; set; }

        /// <summary>
        /// indicates the estimated cost per event with range result
        /// </summary>
        [Newtonsoft.Json.JsonProperty("est_cost_per_event", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EstCInfo EstCostPerEvent { get; set; }

        /// <summary>
        /// estimated click-through rate range
        /// </summary>
        [Newtonsoft.Json.JsonProperty("est_ctr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EstCInfo EstCtr { get; set; }

        /// <summary>
        /// suggested bid value under the current targeting
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suggested_bid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? SuggestedBid { get; set; }

        /// <summary>
        /// suggested daily budget value under the current targeting and bid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suggested_budget", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SuggestedBudget { get; set; }

        /// <summary>
        /// indicates event lost count due to insufficient input bid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("events_lost_to_bid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? EventsLostToBid { get; set; }

        /// <summary>
        /// indicates the event lost count due to insufficient input budget
        /// </summary>
        [Newtonsoft.Json.JsonProperty("events_lost_to_budget", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EventsLostToBudget { get; set; }

        /// <summary>
        /// monthly estimated user count
        /// </summary>
        [Newtonsoft.Json.JsonProperty("est_reach_audience_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? EstReachAudienceSize { get; set; }

        /// <summary>
        /// monthly estimated impressions
        /// </summary>
        [Newtonsoft.Json.JsonProperty("est_reach_impressions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? EstReachImpressions { get; set; }

        /// <summary>
        /// currency name
        /// <br/>example: USDollar
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }

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