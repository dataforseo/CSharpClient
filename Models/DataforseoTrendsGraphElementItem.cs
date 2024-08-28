namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoTrendsGraphElementItem : BaseDataforseoTrendsItem
    {
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

        /// <summary>
        /// DataForSEO Trends data for the specified parameters
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TrendsGraphDataInfo> Data { get; set; }

        /// <summary>
        /// keyword popularity values averaged over the whole time range
        /// </summary>
        [Newtonsoft.Json.JsonProperty("averages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int?> Averages { get; set; }

    }
}