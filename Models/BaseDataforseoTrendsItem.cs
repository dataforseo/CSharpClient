namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("dataforseo_trends_graph", typeof(DataforseoTrendsGraphElementItem))]
    [JsonInheritanceAttribute("subregion_interests", typeof(DataforseoTrendsSubregionInterestsElementItem))]
    [JsonInheritanceAttribute("demography", typeof(DataforseoTrendsDemographyElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseDataforseoTrendsItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// the alignment of the element
        /// <br/>can take the following values: 1, 2, 3, 4, etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Position { get; set; }

        /// <summary>
        /// relevant keywords
        /// <br/>the data included in the dataforseo_trends_graph element is based on the keywords listed in this array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Keywords { get; set; }

    }
}