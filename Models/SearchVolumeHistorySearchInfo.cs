namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SearchVolumeHistorySearchInfo
    {
        /// <summary>
        /// device type = desktop
        /// <br/>contains historical search volume data for searches made from desktop devices
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desktop", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SearchVolumeHistoryItemInfo> Desktop { get; set; }

        /// <summary>
        /// device type = non-smartphones
        /// <br/>contains historical search volume data for searches made from feature phones (non-smartphone mobile devices)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("non_smartphones", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SearchVolumeHistoryItemInfo> NonSmartphones { get; set; }

        /// <summary>
        /// device type = mobile
        /// <br/>contains historical search volume data for searches made from mobile devices
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SearchVolumeHistoryItemInfo> Mobile { get; set; }

        /// <summary>
        /// device type = tablet
        /// <br/>contains historical search volume data for searches made from tablets
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tablet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SearchVolumeHistoryItemInfo> Tablet { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}