namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoTrendsSubregionInterestsElementItem : BaseDataforseoTrendsItem
    {
        /// <summary>
        /// subregional keyword popuarity data for each specified term
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interests", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Interests> Interests { get; set; }

        /// <summary>
        /// comparison of data on subregional keyword popularity for the specified parameters
        /// <br/>if you specified a single keyword, the value will be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interests_comparison", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InterestsComparison InterestsComparison { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}