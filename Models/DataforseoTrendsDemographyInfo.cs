using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoTrendsDemographyInfo 
    {

        /// <summary>
        /// the alignment of the element
        /// <br/>can take the following values: 1, 2, 3, 4, etc.
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Position { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// relevant keywords
        /// <br/>the data included in the demography and demography_comparison is based on the keywords listed in this array
        /// </summary>
        [JsonProperty("keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// demographic breakdown of keyword popularity data per each specified term
        /// <br/>conains keyword popularity data by age and gender
        /// </summary>
        [JsonProperty("demography", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Demography Demography { get; set; }

        /// <summary>
        /// comparison of demographic data on keyword popularity for the specified parameters
        /// <br/>conains keyword popularity data by age and gender
        /// <br/>if you specified a single keyword, the value will be null
        /// </summary>
        [JsonProperty("demography_comparison", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DemographyComparisonInfo DemographyComparison { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}