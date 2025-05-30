using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixContentGenerationLimitsRatesDataInfo 
    {
        [JsonProperty("generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Generate { get; set; }
        [JsonProperty("generate_meta_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo GenerateMetaTags { get; set; }
        [JsonProperty("generate_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo GenerateText { get; set; }
        [JsonProperty("paraphrase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Paraphrase { get; set; }
        [JsonProperty("check_grammar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixContentGenerationDayLimitsRatesDataInfo CheckGrammar { get; set; }
        [JsonProperty("text_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixContentGenerationDayLimitsRatesDataInfo TextSummary { get; set; }
        [JsonProperty("generate_sub_topics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo GenerateSubTopics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}