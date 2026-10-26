using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiAiModeAiOverviewCodeBlockElementItem  : BaseSerpApiAiModeAiOverviewElementItem 
    {

        /// <summary>
        /// programming language or data format of the code block
        /// <br/>indicates the syntax the code block is rendered in
        /// <br/>examples:
        /// <br/>`json`, `python`
        /// </summary>
        [JsonProperty("code_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CodeType { get; set; }

        /// <summary>
        /// text description in the element
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}