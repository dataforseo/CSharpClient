using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ImpressionsInfo 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// date and time when the clickstream dataset was updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// </summary>
        [JsonProperty("last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// the maximum CPC
        /// <br/>it stands for the price you are willing to pay for an ad. The higher value, the higher positions and price you will getwe return the results for the 999 bid value to provide the highest number of impressions and level down the account-specific factors
        /// </summary>
        [JsonProperty("bid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Bid { get; set; }

        /// <summary>
        /// type of keyword match
        /// <br/>can take the following values: exact, broad, phrase
        /// </summary>
        [JsonProperty("match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        /// <summary>
        /// the minimum ad position
        /// <br/>represents the minimum position of the advertisement
        /// </summary>
        [JsonProperty("ad_position_min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? AdPositionMin { get; set; }

        /// <summary>
        /// the maximum ad position
        /// <br/>represents the maximum position of the advertisement
        /// </summary>
        [JsonProperty("ad_position_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? AdPositionMax { get; set; }

        /// <summary>
        /// the average ad position
        /// <br/>represents the average position of the advertisement
        /// </summary>
        [JsonProperty("ad_position_average", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AdPositionAverage { get; set; }

        /// <summary>
        /// the minimum value of cost-per-click
        /// <br/>the minimum cost-per-click (USD) for the keyword given that a bid is set to 999;
        /// <br/>note: this field does not represent an actual CPC value;
        /// <br/>you can find an actual CPC value for a keyword in the cpc field of the keyword_info object
        /// </summary>
        [JsonProperty("cpc_min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CpcMin { get; set; }

        /// <summary>
        /// the maximum value of cost-per-click
        /// <br/>the maximum cost-per-click (USD) for the keyword given that a bid is set to 999;
        /// <br/>note: this field does not represent an actual CPC value;
        /// <br/>you can find an actual CPC value for a keyword in the cpc field of the keyword_info object
        /// </summary>
        [JsonProperty("cpc_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CpcMax { get; set; }

        /// <summary>
        /// the average value of cost-per-click
        /// <br/>the average cost-per-click (USD) for the keyword given that a bid is set to 999;
        /// <br/>note: this field does not represent an actual CPC value;
        /// <br/>you can find an actual CPC value for a keyword in the cpc field of the keyword_info object
        /// </summary>
        [JsonProperty("cpc_average", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CpcAverage { get; set; }

        /// <summary>
        /// the minimum value of daily impressions
        /// <br/>represents the minimum number of daily impressions of the advertisement given that that a bid is set to 999; provides a more accurate alternative to Google search volume data
        /// </summary>
        [JsonProperty("daily_impressions_min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? DailyImpressionsMin { get; set; }

        /// <summary>
        /// the maximum value of daily impressions
        /// <br/>represents the maximum number of daily impressions of the advertisement given that that a bid is set to 999; provides a more accurate alternative to Google search volume data
        /// </summary>
        [JsonProperty("daily_impressions_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? DailyImpressionsMax { get; set; }

        /// <summary>
        /// the average value of daily impressions
        /// <br/>represents the average number of daily impressions of the advertisement given that that a bid is set to 999; provides a more accurate alternative to Google search volume data
        /// </summary>
        [JsonProperty("daily_impressions_average", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyImpressionsAverage { get; set; }

        /// <summary>
        /// the minimum value of daily clicks
        /// <br/>represents the minimum number of daily clicks on the advertisement
        /// </summary>
        [JsonProperty("daily_clicks_min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? DailyClicksMin { get; set; }

        /// <summary>
        /// the maximum value of daily clicks
        /// <br/>represents the maximum number of daily clicks on the advertisement
        /// </summary>
        [JsonProperty("daily_clicks_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? DailyClicksMax { get; set; }

        /// <summary>
        /// the average value of daily clicks
        /// <br/>represents the average number of daily clicks on the advertisement
        /// </summary>
        [JsonProperty("daily_clicks_average", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyClicksAverage { get; set; }

        /// <summary>
        /// the minimum daily charge value
        /// <br/>represents the minimum daily cost of the advertisement (USD)
        /// </summary>
        [JsonProperty("daily_cost_min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? DailyCostMin { get; set; }

        /// <summary>
        /// the maximum daily charge value
        /// <br/>represents the maximum daily cost of the advertisement (USD)
        /// </summary>
        [JsonProperty("daily_cost_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? DailyCostMax { get; set; }

        /// <summary>
        /// the average daily charge value
        /// <br/>represents the average daily cost of the advertisement (USD)
        /// </summary>
        [JsonProperty("daily_cost_average", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyCostAverage { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}