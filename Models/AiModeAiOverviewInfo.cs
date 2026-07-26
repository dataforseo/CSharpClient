using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiModeAiOverviewInfo 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical <c>type</c> values
        /// <br/>positions of elements with different <c>type</c> values are omitted from <c>rank_group</c>
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
        /// SERP page
        /// <br/>SERP page on which the element ranks
        /// </summary>
        [JsonProperty("page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/><c>left</c>, <c>right</c>
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the <see href="https://en.wikipedia.org/wiki/XPath">XPath</see> of the element
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// content of the element in markdown format
        /// <br/>the text of the <c>ai_overview</c> formatted in the <see href="https://en.wikipedia.org/wiki/Markdown">markdown markup language</see>
        /// </summary>
        [JsonProperty("markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Markdown { get; set; }

        /// <summary>
        /// items present in the element
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseSerpApiAiModeAiOverviewElementItem> Items { get; set; }

        /// <summary>
        /// additional references relevant to the item
        /// <br/>includes references to webpages that may have been used to generate the <c>ai_overview</c>
        /// </summary>
        [JsonProperty("references", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiModeAiOverviewReferenceInfo> References { get; set; }

        /// <summary>
        /// rectangle parameters
        /// <br/>contains cartesian coordinates and pixel dimensions of the result's snippet in SERP
        /// <br/>equals <c>null</c> if <c>calculate_rectangles</c> in the POST request is not set to <c>true</c>
        /// </summary>
        [JsonProperty("rectangle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AiModeRectangleInfo Rectangle { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}