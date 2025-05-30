using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsMetricsInfo 
    {

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #1
        /// </summary>
        [JsonProperty("pos_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos1 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #2-3
        /// </summary>
        [JsonProperty("pos_2_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos23 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #4-10
        /// </summary>
        [JsonProperty("pos_4_10", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos410 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #11-20
        /// </summary>
        [JsonProperty("pos_11_20", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos1120 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #21-30
        /// </summary>
        [JsonProperty("pos_21_30", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos2130 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #31-40
        /// </summary>
        [JsonProperty("pos_31_40", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos3140 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #41-50
        /// </summary>
        [JsonProperty("pos_41_50", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos4150 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #51-60
        /// </summary>
        [JsonProperty("pos_51_60", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos5160 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #61-70
        /// </summary>
        [JsonProperty("pos_61_70", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos6170 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #71-80
        /// </summary>
        [JsonProperty("pos_71_80", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos7180 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #81-90
        /// </summary>
        [JsonProperty("pos_81_90", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos8190 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #91-100
        /// </summary>
        [JsonProperty("pos_91_100", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos91100 { get; set; }

        /// <summary>
        /// estimated traffic volume
        /// <br/>estimated organic monthly traffic to the domain or subdomain
        /// <br/>calculated as the product of CTR (click-through-rate) and search volume values of all keywords in the category that the domain or subdomain ranks for
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Etv { get; set; }

        /// <summary>
        /// total count of organic SERPs that contain the domain or subdomain
        /// </summary>
        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Count { get; set; }

        /// <summary>
        /// estimated cost of converting organic search traffic into paid
        /// <br/>represents the estimated monthly cost (USD) of running ads for all keywords in the category that the domain or subdomain ranks for
        /// <br/>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("estimated_paid_traffic_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? EstimatedPaidTrafficCost { get; set; }

        /// <summary>
        /// number of new ranked elements
        /// <br/>indicates how many new ranked elements were found for the indicated target
        /// </summary>
        [JsonProperty("is_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IsNew { get; set; }

        /// <summary>
        /// rank went up
        /// <br/>indicates how many ranked elements of the indicated target went up
        /// </summary>
        [JsonProperty("is_up", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IsUp { get; set; }

        /// <summary>
        /// rank went down
        /// <br/>indicates how many ranked elements of the indicated target went down
        /// </summary>
        [JsonProperty("is_down", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IsDown { get; set; }

        /// <summary>
        /// lost ranked elements
        /// <br/>indicates how many ranked elements of the indicated target were previously presented in SERPs, but weren’t found during the last check
        /// </summary>
        [JsonProperty("is_lost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IsLost { get; set; }

        /// <summary>
        /// estimated traffic volume based on clickstream data
        /// <br/>calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for
        /// <br/>to retrieve results for this field, the parameter include_clickstream_data must be set to true
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("clickstream_etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ClickstreamEtv { get; set; }

        /// <summary>
        /// distribution of estimated clickstream-based metrics by gender
        /// <br/>to retrieve results for this field, the parameter include_clickstream_data must be set to true
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("clickstream_gender_distribution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ClickstreamGenderDistribution { get; set; }

        /// <summary>
        /// distribution of clickstream-based metrics by age
        /// <br/>to retrieve results for this field, the parameter include_clickstream_data must be set to true
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("clickstream_age_distribution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ClickstreamAgeDistribution { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}