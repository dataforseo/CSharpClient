using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixBusinessDataGoogleInfo 
    {
        [JsonProperty("my_business_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo MyBusinessInfo { get; set; }
        [JsonProperty("my_business_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo MyBusinessUpdates { get; set; }
        [JsonProperty("hotel_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpDaysRatesDataInfo HotelInfo { get; set; }
        [JsonProperty("hotel_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo HotelSearches { get; set; }
        [JsonProperty("reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Reviews { get; set; }
        [JsonProperty("questions_and_answers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo QuestionsAndAnswers { get; set; }
        [JsonProperty("extended_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo ExtendedReviews { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}