namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessListingAggregationInfo
    {
        /// <summary>
        /// the most mentioned related categories
        /// <br/>top categories displayed with the number of businesses in each category
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top_categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> TopCategories { get; set; }

        /// <summary>
        /// the most mentioned counties
        /// <br/>country codes with the biggest number of businesses in the category
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top_countries", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> TopCountries { get; set; }

        /// <summary>
        /// number of unique websites
        /// </summary>
        [Newtonsoft.Json.JsonProperty("websites_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? WebsitesCount { get; set; }

        /// <summary>
        /// number of unique entities
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// the most mentioned service details
        /// <br/>service details of a business entity displayed in a form of checks and the number of entities mentioning each attribute
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top_attributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> TopAttributes { get; set; }

        /// <summary>
        /// top keywords mentioned in customer reviews
        /// <br/>contains most popular keywords related to products/services mentioned in customer reviews of a business entity and the number of reviews mentioning each keyword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top_place_topics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> TopPlaceTopics { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}