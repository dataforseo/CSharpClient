namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RankChanges
    {
        /// <summary>
        /// previous absolute rank in SERP
        /// <br/>indicates previous rank of the element in Google SERP;
        /// <br/>if this element is new, the value will be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("previous_rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PreviousRankAbsolute { get; set; }

        /// <summary>
        /// element was previously present in SERP
        /// <br/>if the value is true, previously collected SERP didn’t contain this element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_new", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsNew { get; set; }

        /// <summary>
        /// rank of this element went up
        /// <br/>if the value is true, position of the element in SERP is higher compared to the previous check
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_up", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsUp { get; set; }

        /// <summary>
        /// rank of this element went down
        /// <br/>if the value is true, position of the element in SERP is lower compared to the previous check
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_down", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDown { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}