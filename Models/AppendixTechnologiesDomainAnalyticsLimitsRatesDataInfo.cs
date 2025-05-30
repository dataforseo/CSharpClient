using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixTechnologiesDomainAnalyticsLimitsRatesDataInfo 
    {
        [JsonProperty("domain_technologies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo DomainTechnologies { get; set; }
        [JsonProperty("domains_by_technology", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo DomainsByTechnology { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Languages { get; set; }
        [JsonProperty("locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Locations { get; set; }
        [JsonProperty("technologies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Technologies { get; set; }
        [JsonProperty("aggregation_technologies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo AggregationTechnologies { get; set; }
        [JsonProperty("technologies_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TechnologiesSummary { get; set; }
        [JsonProperty("domains_by_html_terms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo DomainsByHtmlTerms { get; set; }
        [JsonProperty("technology_stats", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TechnologyStats { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}