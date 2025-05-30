using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsGoogleDomainMetricsByCategoriesLiveItem 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// categories for which domains are collected
        /// </summary>
        [JsonProperty("top_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<double?> TopCategories { get; set; }

        /// <summary>
        /// current organic ETV of the domain
        /// </summary>
        [JsonProperty("organic_etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? OrganicEtv { get; set; }

        /// <summary>
        /// current total count of organic SERPs that contain the domain
        /// </summary>
        [JsonProperty("organic_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OrganicCount { get; set; }

        /// <summary>
        /// current number of lost ranked elements
        /// <br/>indicates how many ranked elements of the domain were previously presented in SERPs, but weren’t found during the last check
        /// </summary>
        [JsonProperty("organic_is_lost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OrganicIsLost { get; set; }

        /// <summary>
        /// current number of new ranked elements
        /// <br/>indicates how many new ranked elements were found for the domain
        /// </summary>
        [JsonProperty("organic_is_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OrganicIsNew { get; set; }

        /// <summary>
        /// domain found for the specified category
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// primary domain
        /// </summary>
        [JsonProperty("main_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        /// <summary>
        /// historical ranking and traffic data of the domain
        /// </summary>
        [JsonProperty("metrics_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, DataforseoLabsMetricsInfo>> MetricsHistory { get; set; }

        /// <summary>
        /// metrics difference between first_date and second_date
        /// <br/>calculated by subtracting domain metrics as of the greater date from domain metrics as of the smaller date
        /// </summary>
        [JsonProperty("metrics_difference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, DataforseoLabsMetricsInfo> MetricsDifference { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}