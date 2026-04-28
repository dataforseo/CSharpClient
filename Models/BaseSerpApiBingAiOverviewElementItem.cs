using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("ai_overview_element", typeof(SerpApiBingAiOverviewElementItem))]
    [JsonInheritance("ai_overview_video_element", typeof(SerpApiBingAiOverviewVideoElementItem))]
    [JsonInheritance("ai_overview_videos_element", typeof(SerpApiBingAiOverviewVideosElementItem))]
    [JsonInheritance("ai_overview_images_element", typeof(SerpApiBingAiOverviewImagesElementItem))]
    [JsonInheritance("ai_overview_organic_element", typeof(SerpApiBingAiOverviewOrganicElementItem))]

    public class BaseSerpApiBingAiOverviewElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}