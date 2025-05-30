using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentAnalysisSentimentAnalysisLiveResultInfo 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// citation distribution by sentiment connotation types
        /// <br/>contains objects with citation counts and relevant data distributed by types of sentiments (sentiment polarity);
        /// <br/>possible sentiment connotation types: positive, negative, neutral
        /// </summary>
        [JsonProperty("positive_connotation_distribution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PositiveConnotationDistribution PositiveConnotationDistribution { get; set; }

        /// <summary>
        /// citation distribution by sentiment connotations
        /// <br/>contains objects with citation counts and relevant data distributed by sentiments (emotional reactions);
        /// <br/>possible sentiment connotation types: anger, happiness, love, sadness, share, fun
        /// </summary>
        [JsonProperty("sentiment_connotation_distribution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SentimentConnotationDistribution SentimentConnotationDistribution { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}