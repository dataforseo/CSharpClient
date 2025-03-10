namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GoogleFinanceNewsSerpElementItem : BaseGoogleFinanceSerpElementItem
    {
        /// <summary>
        /// title of the news element
        /// <br/>example: In the news
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// sub-title of the news element
        /// <br/>example: Based on Europe, Middle East, and Africa
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubTitle { get; set; }

        /// <summary>
        /// market indexes data
        /// <br/>array of items containing market indexes data;
        /// <br/>possible type of items: google_finance_asset_pair_element, google_finance_market_instrument_element, google_finance_market_index_element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<GoogleFinanceNewsElement> Items { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}