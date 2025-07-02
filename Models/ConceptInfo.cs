using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ConceptInfo 
    {

        /// <summary>
        /// the concept name for the keyword in the concept_group
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// the concept group of the concept details
        /// </summary>
        [JsonProperty("concept_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ConceptGroupInfo ConceptGroup { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}