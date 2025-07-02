using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpGoogleAutocompleteAdvancedItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// relevance of suggested keyword
        /// <br/>represents the relevant of the autocomplete suggestion to the target keyword
        /// <br/>can take values from 500 to 2000
        /// <br/>the higher the value, the more relevant is the suggestion
        /// <br/>Note: only available for the following client:
        /// <br/>chrome/chrome-omni
        /// </summary>
        [JsonProperty("relevance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Relevance { get; set; }

        /// <summary>
        /// google autocomplete keyword suggestion
        /// </summary>
        [JsonProperty("suggestion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// google autocomplete suggestion type
        /// <br/>Note: only available for the following client:
        /// <br/>chrome/chrome-omni
        /// </summary>
        [JsonProperty("suggestion_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SuggestionType { get; set; }

        /// <summary>
        /// url to search results
        /// <br/>url to search results relevant to the google autocomplete suggestion
        /// </summary>
        [JsonProperty("search_query_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchQueryUrl { get; set; }

        /// <summary>
        /// url of the thumbnail image
        /// <br/>url of the thumbnail image of the google autocomplete suggestion
        /// <br/>Note: only available for the following client:
        /// <br/>gws-wiz
        /// <br/>gws-wiz-serp
        /// </summary>
        [JsonProperty("thumbnail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// keywords highlighted in autocomplete
        /// <br/>contains a list of google autocomplete suggestions that are highlighted in the search bar;
        /// <br/>Note: array is only available for the following client:
        /// <br/>gws-wiz
        /// <br/>psy-ab
        /// <br/>gws-wiz-local
        /// </summary>
        [JsonProperty("highlighted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Highlighted { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}