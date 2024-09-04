namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AbsoluteItems
    {
        /// <summary>
        /// location identifier
        /// <br/>you can use this field for matching obtained results with location parameters specified in the request
        /// <br/>see the full list of available locations with their geo_id here or by making a separate request to https://api.dataforseo.com/v3/keywords_data/dataforseo_trends/locations
        /// <br/>example:
        /// <br/>US-NY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geo_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeoId { get; set; }

        /// <summary>
        /// location name
        /// <br/>you can use this field for matching obtained results with location parameters specified in the request
        /// <br/>see the full list of available locations with their geo_name here or by making a separate request to https://api.dataforseo.com/v3/keywords_data/dataforseo_trends/locations
        /// <br/>example:
        /// <br/>Andorra
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geo_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeoName { get; set; }

        /// <summary>
        /// keyword popularity rates within a given location
        /// <br/>represents location-specific keyword popularity rate over the specified time range;
        /// <br/>using these values, you can understand which of the specified keywords is more popular in the related location;
        /// <br/>the first value in the array is provided for the first term from the keywords array, the second value is provided for the second keyword, and so on;
        /// <br/>calculation: we determine the highest popularity value across all specified keywords within a given location, and then express the popularity values of each keyword as a percentage of the highest value (100);
        /// <br/>a value of 100 is the peak popularity for the term
        /// <br/>a value of 50 means that the term is half as popular
        /// <br/>a value of 0 means there was not enough data for this term
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