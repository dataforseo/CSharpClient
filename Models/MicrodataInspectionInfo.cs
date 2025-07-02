using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class MicrodataInspectionInfo 
    {

        /// <summary>
        /// parent microdata types
        /// <br/>for a full list of available types, please visit schema.org
        /// </summary>
        [JsonProperty("types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Types { get; set; }

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