namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class YelpSearchPaidBusinessDataSerpElementItem : BaseBusinessDataSerpElementItem
    {
        /// <summary>
        /// position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank among all the listed results
        /// <br/>absolute position among all reviews on the list
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the unique identifier of a business identity on Yelp
        /// <br/>example:
        /// <br/>2sWZ17vpEF2vuM_7ic721w
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yelp_business_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string YelpBusinessId { get; set; }

        /// <summary>
        /// link to the Yelp profile of the business entity
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BusinessUrl { get; set; }

        /// <summary>
        /// Yelp business identifier
        /// <br/>displayed only if the request contained the corresponding field
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// name of the business entity
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// description containing the featured review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// information about the location of the business entity
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BusinessAddressLocationInfo Location { get; set; }

        /// <summary>
        /// price range of the business entity
        /// <br/>indicates the number of currency signs next to the business listing corresponding to its price score
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price_range", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PriceRange { get; set; }

        /// <summary>
        /// contact phone number
        /// <br/>example:
        /// <br/>(804) 342-1981
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// Yelp guaranteed label
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_guaranteed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsGuaranteed { get; set; }

        /// <summary>
        /// the rating score submitted by the reviewer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// categories related to the business entity
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Categories { get; set; }

        /// <summary>
        /// links to photos appearing in the result
        /// </summary>
        [Newtonsoft.Json.JsonProperty("photos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Photos { get; set; }

        /// <summary>
        /// tags generated by Yelp
        /// <br/>example:
        /// <br/>"New on Yelp"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Tags { get; set; }

        /// <summary>
        /// highlights describing business offerings
        /// <br/>example:
        /// <br/>"casual_dining"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_highlights", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> BusinessHighlights { get; set; }

        /// <summary>
        /// tags corresponding to the availability of certain business offerings
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_offerings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ServiceOfferingsElement> ServiceOfferings { get; set; }

    }
}