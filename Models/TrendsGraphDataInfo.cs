namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TrendsGraphDataInfo
    {
        /// <summary>
        /// start date of the corresponding time range
        /// <br/>in the UTC format: “yyyy-mm-dd”
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// end date of the corresponding time range
        /// <br/>in the UTC format: “yyyy-mm-dd”
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// a point in time in the Unix time format
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Timestamp { get; set; }

        /// <summary>
        /// indicates whether the data is unavailable
        /// <br/>if true the data on the graph in the Google Trends interface is missing and thus labelled with a dotted line
        /// </summary>
        [Newtonsoft.Json.JsonProperty("missing_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? MissingData { get; set; }

        /// <summary>
        /// relative keyword popularity rate at a specific timestamp
        /// <br/>represents the keyword popularity rate over the given time range
        /// <br/>if you specify more than one keyword, the values will be averaged to the highest value across all specified keywords
        /// <br/>a value of 100 is the peak popularity for the term. A value of 50 means that the term is half as popular. A score of 0 means there was not enough data for this term
        /// </summary>
        [Newtonsoft.Json.JsonProperty("values", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int?> Values { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}