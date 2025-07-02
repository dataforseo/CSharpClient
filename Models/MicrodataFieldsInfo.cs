using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class MicrodataFieldsInfo 
    {

        /// <summary>
        /// field name
        /// <br/>name of the data field
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// parent microdata types
        /// <br/>for a full list of available types, please visit schema.org
        /// </summary>
        [JsonProperty("types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Types { get; set; }

        /// <summary>
        /// microdata value
        /// <br/>microdata value specified on a target web page
        /// </summary>
        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// microdata validation test results
        /// <br/>sub-type microdata test results that contain detected errors and related messages
        /// </summary>
        [JsonProperty("test_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MessageInfo TestResults { get; set; }

        /// <summary>
        /// microdata fields
        /// <br/>an array of objects containing data fields related to the certain microdata type
        /// </summary>
        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<MicrodataFieldsInfo> Fields { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}