namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AutocompleteSerpElementItem : BaseSerpElementItem
    {
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
        /// relevance of suggested keyword
        /// <br/>represents the relevant of the autocomplete suggestion to the target keyword
        /// <br/>can take values from 500 to 2000
        /// <br/>the higher the value, the more relevant is the suggestion
        /// <br/>Note: only available for the following client:
        /// <br/>chrome/chrome-omni
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relevance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Relevance { get; set; }

        /// <summary>
        /// google autocomplete keyword suggestion
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suggestion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// google autocomplete suggestion type
        /// <br/>Note: only available for the following client:
        /// <br/>chrome/chrome-omni
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suggestion_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SuggestionType { get; set; }

        /// <summary>
        /// url to search results
        /// <br/>url to search results relevant to the google autocomplete suggestion
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_query_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SearchQueryUrl { get; set; }

        /// <summary>
        /// url of the thumbnail image
        /// <br/>url of the thumbnail image of the google autocomplete suggestion
        /// <br/>Note: only available for the following client:
        /// <br/>gws-wiz
        /// <br/>gws-wiz-serp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thumbnail_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// keywords highlighted in autocomplete
        /// <br/>contains a list of google autocomplete suggestions that are highlighted in the search bar;
        /// <br/>Note: array is only available for the following client:
        /// <br/>gws-wiz
        /// <br/>psy-ab
        /// <br/>gws-wiz-local
        /// </summary>
        [Newtonsoft.Json.JsonProperty("highlighted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Highlighted { get; set; }

    }
}