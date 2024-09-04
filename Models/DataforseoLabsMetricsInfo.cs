namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsMetricsInfo
    {
        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos1 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #2-3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_2_3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos23 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #4-10
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_4_10", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos410 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #11-20
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_11_20", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos1120 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #21-30
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_21_30", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos2130 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #31-40
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_31_40", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos3140 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #41-50
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_41_50", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos4150 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #51-60
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_51_60", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos5160 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #61-70
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_61_70", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos6170 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #71-80
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_71_80", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos7180 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #81-90
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_81_90", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos8190 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain or subdomain ranks #91-100
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_91_100", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos91100 { get; set; }

        /// <summary>
        /// estimated traffic volume
        /// <br/>estimated organic monthly traffic to the domain or subdomain
        /// <br/>calculated as the product of CTR (click-through-rate) and search volume values of all keywords in the category that the domain or subdomain ranks for
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("etv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Etv { get; set; }

        /// <summary>
        /// estimated traffic volume based on impressions
        /// <br/>estimated organic monthly traffic to the domain or subdomain
        /// <br/>calculated as the product of CTR (click-through-rate) and impressions values of all keywords in the category that the domain or subdomain ranks for
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("impressions_etv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ImpressionsEtv { get; set; }

        /// <summary>
        /// total count of organic SERPs that contain the domain or subdomain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// estimated cost of converting organic search traffic into paid
        /// <br/>represents the estimated monthly cost (USD) of running ads for all keywords in the category that the domain or subdomain ranks for
        /// <br/>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimated_paid_traffic_cost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? EstimatedPaidTrafficCost { get; set; }

        /// <summary>
        /// number of new ranked elements
        /// <br/>indicates how many new ranked elements were found for the indicated target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_new", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? IsNew { get; set; }

        /// <summary>
        /// rank went up
        /// <br/>indicates how many ranked elements of the indicated target went up
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_up", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? IsUp { get; set; }

        /// <summary>
        /// rank went down
        /// <br/>indicates how many ranked elements of the indicated target went down
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_down", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? IsDown { get; set; }

        /// <summary>
        /// lost ranked elements
        /// <br/>indicates how many ranked elements of the indicated target were previously presented in SERPs, but weren’t found during the last check
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_lost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? IsLost { get; set; }

        /// <summary>
        /// estimated traffic volume based on clickstream data
        /// <br/>calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for
        /// <br/>to retrieve results for this field, the parameter include_clickstream_data must be set to true
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clickstream_etv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ClickstreamEtv { get; set; }

        /// <summary>
        /// distribution of estimated clickstream-based metrics by gender
        /// <br/>to retrieve results for this field, the parameter include_clickstream_data must be set to true
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clickstream_gender_distribution", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ClickstreamGenderDistribution { get; set; }

        /// <summary>
        /// distribution of clickstream-based metrics by age
        /// <br/>to retrieve results for this field, the parameter include_clickstream_data must be set to true
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clickstream_age_distribution", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ClickstreamAgeDistribution { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}