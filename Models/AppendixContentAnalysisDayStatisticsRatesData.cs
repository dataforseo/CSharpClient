using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixContentAnalysisDayStatisticsRatesData 
    {
        [JsonProperty("search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Search { get; set; }
        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Summary { get; set; }
        [JsonProperty("sentiment_analysis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo SentimentAnalysis { get; set; }
        [JsonProperty("rating_distribution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo RatingDistribution { get; set; }
        [JsonProperty("phrase_trends", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo PhraseTrends { get; set; }
        [JsonProperty("category_trends", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo CategoryTrends { get; set; }
        [JsonProperty("locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Locations { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Languages { get; set; }
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Categories { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Errors { get; set; }
        [JsonProperty("available_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AvailableFilters { get; set; }
        [JsonProperty("id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IdList { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}