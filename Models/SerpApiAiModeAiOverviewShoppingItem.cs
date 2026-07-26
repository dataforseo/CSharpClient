using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiAiModeAiOverviewShoppingItem  : BaseSerpApiAiModeAiOverviewElementItem 
    {

        /// <summary>
        /// title of the link
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// content of the element in markdown format
        /// <br/>the text of the <c>ai_overview</c> formatted in the <see href="https://en.wikipedia.org/wiki/Markdown">markdown markup language</see>
        /// </summary>
        [JsonProperty("markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Markdown { get; set; }

        /// <summary>
        /// items of the element
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiModeAiOverviewShoppingElementInfo> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}