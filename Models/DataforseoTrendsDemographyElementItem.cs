namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoTrendsDemographyElementItem : BaseDataforseoTrendsItem
    {
        /// <summary>
        /// demographic breakdown of keyword popularity data per each specified term
        /// <br/>conains keyword popularity data by age and gender
        /// </summary>
        [Newtonsoft.Json.JsonProperty("demography", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Demography Demography { get; set; }

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