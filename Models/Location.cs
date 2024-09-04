namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Location
    {
        /// <summary>
        /// name of the neighborhood where the hotel is located
        /// </summary>
        [Newtonsoft.Json.JsonProperty("neighborhood", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Neighborhood { get; set; }

        /// <summary>
        /// description of the neighborhood where the hotel is located
        /// </summary>
        [Newtonsoft.Json.JsonProperty("neighborhood_description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NeighborhoodDescription { get; set; }

        /// <summary>
        /// url to the location of the hotel in google maps
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maps_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MapsUrl { get; set; }

        /// <summary>
        /// overall score of the hotel location
        /// <br/>indicates the overall score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby things to do and restaurants, transportation, and airports;
        /// <br/>note that the criteria are not weighted equally in the overall score
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overall_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? OverallScore { get; set; }

        /// <summary>
        /// category scores of the hotel location
        /// <br/>the scores of the hotel’s location tied to the categories that indicate the proximity to nearby things to do, restaurants, transportation, and airports;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("score_by_categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ScoreByCategories ScoreByCategories { get; set; }

        /// <summary>
        /// hotel latitude
        /// <br/>latitude coordinates of the hotel’s location
        /// <br/>example:
        /// <br/>39.4806397
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latitude", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Latitude { get; set; }

        /// <summary>
        /// hotel longitude
        /// <br/>latitude coordinates of the hotel’s location
        /// <br/>example:
        /// <br/>-106.0512973
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longitude", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Longitude { get; set; }

        /// <summary>
        /// elements of the location chain
        /// <br/>additional parameters of each element of the location chain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_chain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LocationChain> LocationChain { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}