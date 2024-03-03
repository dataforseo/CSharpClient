namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MapsSearchSerpElementItem : BaseSerpElementItem
    {
        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// domain in the SERP element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// title of the result in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// relevant URL in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// URL of the preferred contact page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactUrl { get; set; }

        /// <summary>
        /// the element’s rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// hotel class rating
        /// <br/>class ratings range between 1-5 stars, learn more
        /// <br/>if there is no hotel class rating information, the value will be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hotel_rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? HotelRating { get; set; }

        /// <summary>
        /// property price level
        /// <br/>can take values: inexpensive, moderate, expensive, very_expensive
        /// <br/>if there is no price level information, the value will be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price_level", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PriceLevel { get; set; }

        /// <summary>
        /// the distribution of ratings of the business entity
        /// <br/>the object displays the number of 1-star to 5-star ratings, as reviewed by users
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating_distribution", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, int?> RatingDistribution { get; set; }

        /// <summary>
        /// element snippet
        /// <br/>contains the address and other information about the local establishment featured in the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("snippet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Snippet { get; set; }

        /// <summary>
        /// address line
        /// <br/>address of the local establishment featured in the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// object containing address components of the local establishment
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AddressInfo AddressInfo { get; set; }

        /// <summary>
        /// unique place identifier
        /// <br/>place id of the local establishment featured in the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("place_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlaceId { get; set; }

        /// <summary>
        /// phone number
        /// <br/>phone number of the local establishment featured in the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// URL of the main image featured in Google My Business profile
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_image", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainImage { get; set; }

        /// <summary>
        /// total count of images featured in Google My Business profile
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_photos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalPhotos { get; set; }

        /// <summary>
        /// business category
        /// <br/>Google My Business general category that best describes the services provided by the business entity
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// additional business categories
        /// <br/>additional Google My Business categories that describe the services provided by the business entity in more detail
        /// </summary>
        [Newtonsoft.Json.JsonProperty("additional_categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> AdditionalCategories { get; set; }

        /// <summary>
        /// global category IDs
        /// <br/>universal category IDs that do not change based on the selected country
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_ids", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> CategoryIds { get; set; }

        /// <summary>
        /// open hours
        /// <br/>information about work hours of the local establishment
        /// </summary>
        [Newtonsoft.Json.JsonProperty("work_hours", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public WorkHours WorkHours { get; set; }

        /// <summary>
        /// the unique identifier of the element in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feature_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FeatureId { get; set; }

        /// <summary>
        /// google-defined client id
        /// <br/>unique id of a local establishment;
        /// <br/>can be used with Google Reviews API to get a full list of reviews
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cid { get; set; }

        /// <summary>
        /// latitude coordinate of the local establishments in google maps
        /// <br/>example:
        /// <br/>"latitude": 51.584091
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latitude", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Latitude { get; set; }

        /// <summary>
        /// longitude coordinate of the local establishment in google maps
        /// <br/>example:
        /// <br/>"longitude": -0.31365919999999997
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longitude", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Longitude { get; set; }

        /// <summary>
        /// indicates whether ownership of this local establishment is claimed
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_claimed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsClaimed { get; set; }

        /// <summary>
        /// Google local justifications
        /// <br/>snippets of text that “justify” why the business is showing up for search query
        /// </summary>
        [Newtonsoft.Json.JsonProperty("local_justifications", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LocalJustificationInfo> LocalJustifications { get; set; }

        /// <summary>
        /// indicates whether this local establishment is a directory
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_directory_item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDirectoryItem { get; set; }

    }
}