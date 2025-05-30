using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TechnologiesInfo 
    {
        [JsonProperty("add_ons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> AddOns { get; set; }
        [JsonProperty("analytics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Analytics { get; set; }
        [JsonProperty("web_development", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> WebDevelopment { get; set; }
        [JsonProperty("security", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Security { get; set; }
        [JsonProperty("business_tools", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> BusinessTools { get; set; }
        [JsonProperty("sales", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Sales { get; set; }
        [JsonProperty("other", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Other { get; set; }
        [JsonProperty("user_generated_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> UserGeneratedContent { get; set; }
        [JsonProperty("privacy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Privacy { get; set; }
        [JsonProperty("servers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Servers { get; set; }
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Location { get; set; }
        [JsonProperty("content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Content { get; set; }
        [JsonProperty("media", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Media { get; set; }
        [JsonProperty("marketing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Marketing { get; set; }
        [JsonProperty("communication", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Communication { get; set; }
        [JsonProperty("utilities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Utilities { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}