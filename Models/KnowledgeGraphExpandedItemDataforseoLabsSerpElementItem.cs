namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KnowledgeGraphExpandedItemDataforseoLabsSerpElementItem : BaseDataforseoLabsSerpElementItem
    {
        /// <summary>
        /// title of a given link element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// google defined data attribute ID
        /// <br/>example:
        /// <br/>action:listen_artist
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_attrid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DataAttrid { get; set; }

        /// <summary>
        /// expanded element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expanded_element", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<KnowledgeGraphExpandedElement> ExpandedElement { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}