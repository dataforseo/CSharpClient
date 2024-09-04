namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Table
    {
        /// <summary>
        /// name assigned to the table element
        /// <br/>possible values:
        /// <br/>table_element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table_element", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TableElement { get; set; }

        /// <summary>
        /// column names
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table_header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> TableHeader { get; set; }

        /// <summary>
        /// the content of the table
        /// <br/>one line of the table in this element of the array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table_content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<System.Collections.Generic.ICollection<string>> TableContent { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}