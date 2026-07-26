using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ChatGptTextElementItem  : BaseChatGptLlmScraperElementItem 
    {

        /// <summary>
        /// content of the element in markdown format
        /// <br/>content of the result formatted in the <see href="https://en.wikipedia.org/wiki/Markdown">markdown markup language</see>
        /// </summary>
        [JsonProperty("markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Markdown { get; set; }

        /// <summary>
        /// array of sources
        /// </summary>
        [JsonProperty("sources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SourceInfo> Sources { get; set; }

        /// <summary>
        /// array of brand entities
        /// <br/>contains information on brands mentioned in the text
        /// </summary>
        [JsonProperty("brand_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ChatGptBrandEntity> BrandEntities { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}