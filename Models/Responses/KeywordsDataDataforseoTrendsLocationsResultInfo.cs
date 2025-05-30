using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataDataforseoTrendsLocationsResultInfo
    {
        /// <summary>
        /// location code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LocationCode { get; set; }

        /// <summary>
        /// full name of the location
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// the code of the superordinate location
        /// <br/>example:
        /// <br/>"location_code": 9041134,
        /// <br/>"location_name": "Vienna International Airport,Lower Austria,Austria",
        /// <br/>"location_code_parent": 20044
        /// <br/>where location_code_parent corresponds to:
        /// <br/>"location_code": 20044,
        /// <br/>"location_name": "Lower Austria,Austria"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code_parent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LocationCodeParent { get; set; }

        /// <summary>
        /// ISO country code of the location
        /// </summary>
        [Newtonsoft.Json.JsonProperty("country_iso_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryIsoCode { get; set; }

        /// <summary>
        /// location type
        /// <br/>possible values according to Google’s target types
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationType { get; set; }

        /// <summary>
        /// DataForSEO trends location identifier
        /// <br/>you can use this field for matching obtained results with the location_code parameter specified in the request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geo_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeoId { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}