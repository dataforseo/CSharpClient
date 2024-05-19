namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoTrendsDemographyInfo
    {
        /// <summary>
        /// the alignment of the element
        /// <br/>can take the following values: 1, 2, 3, 4, etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Position { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// relevant keywords
        /// <br/>the data included in the demography and demography_comparison is based on the keywords listed in this array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Keywords { get; set; }

        /// <summary>
        /// demographic breakdown of keyword popularity data per each specified term
        /// <br/>conains keyword popularity data by age and gender
        /// </summary>
        [Newtonsoft.Json.JsonProperty("demography", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Demography Demography { get; set; }

        /// <summary>
        /// comparison of demographic data on keyword popularity for the specified parameters
        /// <br/>conains keyword popularity data by age and gender
        /// <br/>if you specified a single keyword, the value will be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("demography_comparison", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DemographyComparisonInfo DemographyComparison { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}