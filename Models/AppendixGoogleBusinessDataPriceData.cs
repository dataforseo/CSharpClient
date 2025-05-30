using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixGoogleBusinessDataPriceData 
    {
        [JsonProperty("extended_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo ExtendedReviews { get; set; }
        [JsonProperty("hotel_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixHotelInfoGoogleBusinessDataPriceData HotelInfo { get; set; }
        [JsonProperty("hotel_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixGoogleBusinessDataPriceDataInfo HotelSearches { get; set; }
        [JsonProperty("my_business_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixGoogleBusinessDataPriceDataInfo MyBusinessInfo { get; set; }
        [JsonProperty("my_business_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixGoogleBusinessDataPriceDataInfo MyBusinessUpdates { get; set; }
        [JsonProperty("questions_and_answers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixGoogleBusinessDataPriceDataInfo QuestionsAndAnswers { get; set; }
        [JsonProperty("reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixGoogleBusinessDataPriceDataInfo Reviews { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}