namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("maps_search", typeof(GoogleMapsMapsSearchSerpElementItem))]
    [JsonInheritanceAttribute("maps_paid_item", typeof(GoogleMapsMapsPaidItemSerpElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseGoogleMapsSerpElementItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// domain in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// title of the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// search URL with refinement parameters
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// the element’s rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// the distribution of ratings of the business entity
        /// <br/>the object displays the number of 1-star to 5-star ratings, as reviewed by users
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating_distribution", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, int?> RatingDistribution { get; set; }

    }
}