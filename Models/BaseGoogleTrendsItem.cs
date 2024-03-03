namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("google_trends_graph", typeof(GoogleTrendsGraphElementItem))]
    [JsonInheritanceAttribute("google_trends_map", typeof(GoogleTrendsMapElementItem))]
    [JsonInheritanceAttribute("google_trends_topics_list", typeof(GoogleTrendsTopicsListElementItem))]
    [JsonInheritanceAttribute("google_trends_queries_list", typeof(GoogleTrendsQueriesListElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseGoogleTrendsItem
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