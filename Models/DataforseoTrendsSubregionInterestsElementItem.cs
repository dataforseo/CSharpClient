namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoTrendsSubregionInterestsElementItem : BaseDataforseoTrendsItem
    {
        /// <summary>
        /// the alignment of the element
        /// <br/>can take the following values: 1, 2, 3, 4, etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Position { get; set; }

        /// <summary>
        /// relevant keywords
        /// <br/>the data included in the interests and interests_comparison is based on the keywords listed in this array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Keywords { get; set; }

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

    }
}