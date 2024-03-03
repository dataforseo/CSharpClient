namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixBusinessDataLimitsRatesDataInfo
    {
        [Newtonsoft.Json.JsonProperty("google", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBusinessDataGoogleInfo Google { get; set; }

        [Newtonsoft.Json.JsonProperty("locations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Locations { get; set; }

        [Newtonsoft.Json.JsonProperty("languages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Languages { get; set; }

        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Errors { get; set; }

        [Newtonsoft.Json.JsonProperty("yelp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBusinessDataDayLimitsRatesDataInfo Yelp { get; set; }

        [Newtonsoft.Json.JsonProperty("social_media", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixSocialMediaBusinessDataLimitsRatesDataInfo SocialMedia { get; set; }

        [Newtonsoft.Json.JsonProperty("tripadvisor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBusinessDataDayLimitsRatesDataInfo Tripadvisor { get; set; }

        [Newtonsoft.Json.JsonProperty("trustpilot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBusinessDataDayLimitsRatesDataInfo Trustpilot { get; set; }

        [Newtonsoft.Json.JsonProperty("business_listings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBusinessListingsBusinessDataLimitsRatesDataInfo BusinessListings { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}