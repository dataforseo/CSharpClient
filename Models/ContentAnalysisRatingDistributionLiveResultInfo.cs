using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentAnalysisRatingDistributionLiveResultInfo 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// min rating on a distribution scale
        /// </summary>
        [JsonProperty("min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Min { get; set; }

        /// <summary>
        /// max rating on a distribution scale
        /// </summary>
        [JsonProperty("max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        /// <summary>
        /// contains rating distribution metrics
        /// </summary>
        [JsonProperty("metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Metrics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}