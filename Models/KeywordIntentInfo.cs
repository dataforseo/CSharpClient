using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordIntentInfo 
    {

        /// <summary>
        /// search intent name
        /// <br/>possible values: <c>informational</c>, <c>navigational</c>, <c>commercial</c>, <c>transactional</c>
        /// </summary>
        [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// search intent probability
        /// <br/><c>1</c> indicates the highest probability
        /// </summary>
        [JsonProperty("probability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Probability { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}