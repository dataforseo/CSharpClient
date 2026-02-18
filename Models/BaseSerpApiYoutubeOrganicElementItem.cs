using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("youtube_channel", typeof(SerpApiYoutubeChannelElementItem))]
    [JsonInheritance("youtube_video", typeof(SerpApiYoutubeVideoElementItem))]
    [JsonInheritance("youtube_video_paid", typeof(SerpApiYoutubeVideoPaidElementItem))]
    [JsonInheritance("youtube_playlist", typeof(SerpApiYoutubePlaylistElementItem))]

    public class BaseSerpApiYoutubeOrganicElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP for the target domain
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// block rank in SERP
        /// <br/>position among all the blocks in SERP
        /// </summary>
        [JsonProperty("block_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BlockRank { get; set; }

        /// <summary>
        /// name of the block in SERP
        /// <br/>example:
        /// <br/>'People also watched'
        /// </summary>
        [JsonProperty("block_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BlockName { get; set; }

        /// <summary>
        /// ID of the channel
        /// </summary>
        [JsonProperty("channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelId { get; set; }

        /// <summary>
        /// URL of the channel
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}