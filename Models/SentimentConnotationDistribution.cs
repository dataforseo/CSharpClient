using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SentimentConnotationDistribution 
    {
        [JsonProperty("anger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Anger { get; set; }
        [JsonProperty("happiness", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Happiness { get; set; }
        [JsonProperty("love", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Love { get; set; }
        [JsonProperty("sadness", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Sadness { get; set; }
        [JsonProperty("share", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Share { get; set; }
        [JsonProperty("fun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Fun { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}