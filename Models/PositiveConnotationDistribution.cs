using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PositiveConnotationDistribution 
    {
        [JsonProperty("positive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Positive { get; set; }
        [JsonProperty("negative", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Negative { get; set; }
        [JsonProperty("neutral", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Neutral { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}