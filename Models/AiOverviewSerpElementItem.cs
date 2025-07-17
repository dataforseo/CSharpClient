using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOverviewSerpElementItem  : BaseSerpApiElementItem 
    {

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values;
        /// <br/>positions of elements with different type values are omitted from rank_group;
        /// <br/>always equals 0 for desktop
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// <br/>always equals 0 for desktop
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// indicates whether the element is loaded asynchronically
        /// <br/>if true, the ai_overview element is loaded asynchronically;
        /// <br/>if false, the ai_overview element is loaded from cache;
        /// </summary>
        [JsonProperty("asynchronous_ai_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsynchronousAiOverview { get; set; }

        /// <summary>
        /// content of the element in markdown format
        /// </summary>
        [JsonProperty("markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Markdown { get; set; }

        /// <summary>
        /// contains arrays of specific images
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseSerpApiAiOverviewElementItem> Items { get; set; }

        /// <summary>
        /// references relevant to the element
        /// <br/>includes references to webpages that were used to generate the ai_overview_element
        /// </summary>
        [JsonProperty("references", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiAiOverviewReferenceInfo> References { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}