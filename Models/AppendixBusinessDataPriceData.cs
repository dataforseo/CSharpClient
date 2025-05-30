using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixBusinessDataPriceData 
    {
        [JsonProperty("business_listings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBusinessListingsBusinessDataPriceData BusinessListings { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Errors { get; set; }
        [JsonProperty("google", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixGoogleBusinessDataPriceData Google { get; set; }
        [JsonProperty("social_media", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSocialMediaBusinessDataPriceData SocialMedia { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Languages { get; set; }
        [JsonProperty("locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Locations { get; set; }
        [JsonProperty("tripadvisor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTrBusinessDataPriceDataInfo Tripadvisor { get; set; }
        [JsonProperty("trustpilot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTrBusinessDataPriceDataInfo Trustpilot { get; set; }
        [JsonProperty("yelp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTrBusinessDataPriceDataInfo Yelp { get; set; }
        [JsonProperty("tasks_ready", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo TasksReady { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}