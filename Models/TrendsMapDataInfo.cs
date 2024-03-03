namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TrendsMapDataInfo
    {
        /// <summary>
        /// Google Trends location identifier
        /// <br/>you can use this field for matching obtained results with location parameters specified in the request
        /// <br/>example:
        /// <br/>US-NY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geo_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeoId { get; set; }

        /// <summary>
        /// Google Trends location name
        /// <br/>you can use this field for matching obtained results with location parameters specified in the request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geo_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeoName { get; set; }

        /// <summary>
        /// relative keyword popularity rate in a given location
        /// <br/>represents the location-specific keyword popularity rate over the given time range
        /// <br/>if you specify more than one keyword, the values will be averaged to the highest value across all specified keywords
        /// <br/>a value of 100 is the peak popularity for the term
        /// <br/>a value of 50 means that the term is half as popular
        /// <br/>a value of 0 means there was not enough data for this term
        /// </summary>
        [Newtonsoft.Json.JsonProperty("values", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int?> Values { get; set; }

        /// <summary>
        /// max value among comparable terms
        /// <br/>represents the maximum value if you specified more than two keywords in a POST array
        /// <br/>if you specified only one keyword, the value will be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_value_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxValueIndex { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}