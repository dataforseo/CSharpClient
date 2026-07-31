using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AnnotationInfo 
    {

        /// <summary>
        /// the domain name or title of the quoted source
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL of the quoted source
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// start of the annotation indexing
        /// </summary>
        [JsonProperty("start_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StartIndex { get; set; }

        /// <summary>
        /// end of the annotation indexing
        /// </summary>
        [JsonProperty("end_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EndIndex { get; set; }

        /// <summary>
        /// text of the reasoning chain section
        /// <br/>text of the reasoning chain  section summarizing the model's thought process
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