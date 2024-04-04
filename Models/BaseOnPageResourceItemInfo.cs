namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("html", typeof(HtmlResourceElementItem))]
    [JsonInheritanceAttribute("script", typeof(ScriptResourceElementItem))]
    [JsonInheritanceAttribute("stylesheet", typeof(StylesheetResourceElementItem))]
    [JsonInheritanceAttribute("image", typeof(ImageResourceElementItem))]
    [JsonInheritanceAttribute("broken", typeof(BrokenResourceElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseOnPageResourceItemInfo
    {

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}