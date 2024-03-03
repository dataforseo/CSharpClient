namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MicrodataInspectionInfo
    {
        /// <summary>
        /// parent microdata types
        /// <br/>for a full list of available types, please visit schema.org
        /// </summary>
        [Newtonsoft.Json.JsonProperty("types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Types { get; set; }

        /// <summary>
        /// microdata fields
        /// <br/>an array of objects containing data fields related to the certain microdata type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fields", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MicrodataFieldsInfo> Fields { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}