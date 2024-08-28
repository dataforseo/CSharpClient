using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessDataGoogleReviewsTaskPostRequestInfo : BusinessDataTaskRequestInfo
    {
        /// <summary>
        /// unique, google-defined id of the business entity
        /// <br/>required field if you don’t specify keyword or place_id
        /// <br/>example:
        /// <br/>194604053573767737
        /// <br/>learn more about the identifier in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cid { get; set; }

        /// <summary>
        /// identifier of the business entity in Google Maps
        /// <br/>required field if you don’t specify keyword or cid
        /// <br/>example:
        /// <br/>GhIJQWDl0CIeQUARxks3icF8U8A
        /// <br/>learn more about the identifier in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("place_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlaceId { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of reviews in SERP
        /// <br/>we strongly recommend setting the parsing depth in the multiples of ten, because our systems processes ten reviews in a row
        /// <br/>default value: 10
        /// <br/>maximum value: 4490
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>you can use this field to sort the results
        /// <br/>possible types of sorting:
        /// <br/>newest – sort by newest first
        /// <br/>highest_rating – sort by highest rating
        /// <br/>lowest_rating – sort by lowest rating
        /// <br/>relevant – sort by relevance
        /// <br/>default value: relevant
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SortBy { get; set; }
    }
}