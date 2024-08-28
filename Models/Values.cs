namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Values
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
        /// relative keyword popularity rate in a given location
        /// <br/>represents location-specific keyword popularity rate over the specified time range;
        /// <br/>using this value you can understand how popular a keyword is in one location compared to another location;
        /// <br/>calculation: we determine the highest popularity value for the relevant keyword across all locations, and then express all other values as a percentage of that highest value (100);
        /// <br/>a value of 100 is the highest popularity for the term
        /// <br/>a value of 50 means that the term is half as popular
        /// <br/>a value of 0 means there was not enough data for this term
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Value { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}