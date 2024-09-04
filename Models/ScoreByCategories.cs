namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ScoreByCategories
    {
        /// <summary>
        /// overall score of the hotel location
        /// <br/>indicates the overall score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby things to do and restaurants, transportation, and airports;
        /// <br/>note that the criteria are not weighted equally in the overall score
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overall", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Overall { get; set; }

        /// <summary>
        /// score relative to nearby things to do
        /// <br/>indicates the score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby things to do
        /// </summary>
        [Newtonsoft.Json.JsonProperty("things_to_do", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ThingsToDo { get; set; }

        /// <summary>
        /// score relative to nearby restaurants
        /// <br/>indicates the score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby restaurants
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restaurants", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Restaurants { get; set; }

        /// <summary>
        /// score relative to nearby transit options
        /// <br/>indicates the score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby transit options
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Transit { get; set; }

        /// <summary>
        /// score relative to nearby airports
        /// <br/>indicates the score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby airports
        /// </summary>
        [Newtonsoft.Json.JsonProperty("airport_access", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? AirportAccess { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}