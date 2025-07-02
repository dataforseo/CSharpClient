using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class MetricsInfo 
    {

        /// <summary>
        /// number of organic SERPs where the domain ranks #1
        /// </summary>
        [JsonProperty("pos_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos1 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #2-3
        /// </summary>
        [JsonProperty("pos_2_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos23 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #4-10
        /// </summary>
        [JsonProperty("pos_4_10", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos410 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #11-20
        /// </summary>
        [JsonProperty("pos_11_20", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos1120 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #21-30
        /// </summary>
        [JsonProperty("pos_21_30", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos2130 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #31-40
        /// </summary>
        [JsonProperty("pos_31_40", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos3140 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #41-50
        /// </summary>
        [JsonProperty("pos_41_50", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos4150 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #51-60
        /// </summary>
        [JsonProperty("pos_51_60", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos5160 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #61-70
        /// </summary>
        [JsonProperty("pos_61_70", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos6170 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #71-80
        /// </summary>
        [JsonProperty("pos_71_80", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos7180 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #81-90
        /// </summary>
        [JsonProperty("pos_81_90", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos8190 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #91-100
        /// </summary>
        [JsonProperty("pos_91_100", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pos91100 { get; set; }

        /// <summary>
        /// estimated traffic volume
        /// <br/>estimated organic monthly traffic to the domain
        /// <br/>calculated as the product of CTR (click-through-rate) and search volume values of all keywords the domain ranks for
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Etv { get; set; }

        /// <summary>
        /// estimated traffic volume based on impressions
        /// <br/>estimated organic monthly traffic to the domain
        /// <br/>calculated as the product of CTR (click-through-rate) and impressions values of all keywords the domain ranks for
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("impressions_etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ImpressionsEtv { get; set; }

        /// <summary>
        /// total count of organic SERPs that contain the domain
        /// </summary>
        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// estimated cost of converting organic search traffic into paid
        /// <br/>represents the estimated monthly cost of running ads (USD) for all keywords a domain ranks for
        /// <br/>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("estimated_paid_traffic_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? EstimatedPaidTrafficCost { get; set; }

        /// <summary>
        /// number of new ranked elements
        /// <br/>indicates how many new ranked elements were found for this domain
        /// </summary>
        [JsonProperty("is_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? IsNew { get; set; }

        /// <summary>
        /// rank went up
        /// <br/>indicates how many ranked elements of this domain went up in Google Search
        /// </summary>
        [JsonProperty("is_up", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? IsUp { get; set; }

        /// <summary>
        /// rank went down
        /// <br/>indicates how many ranked elements of this domain went down in Google Search
        /// </summary>
        [JsonProperty("is_down", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? IsDown { get; set; }

        /// <summary>
        /// lost ranked elements
        /// <br/>indicates how many ranked elements of this domain were previously presented in SERPs, but weren’t found during the last check
        /// </summary>
        [JsonProperty("is_lost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? IsLost { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}