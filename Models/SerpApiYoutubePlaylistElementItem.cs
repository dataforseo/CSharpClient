using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiYoutubePlaylistElementItem  : BaseSerpApiYoutubeOrganicElementItem 
    {

        /// <summary>
        /// title of the video
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// ID of the video
        /// </summary>
        [JsonProperty("playlist_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PlaylistId { get; set; }

        /// <summary>
        /// the URL of the page where the thumbnail is hosted
        /// </summary>
        [JsonProperty("thumbnail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// the name of the channel where the video is published
        /// </summary>
        [JsonProperty("channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelName { get; set; }

        /// <summary>
        /// the URL of the channel where the video is published
        /// </summary>
        [JsonProperty("channel_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// the URL of the page where the logo image of the channel is hosted
        /// </summary>
        [JsonProperty("channel_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelLogo { get; set; }

        /// <summary>
        /// the number of videos in playlist
        /// </summary>
        [JsonProperty("videos_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? VideosCount { get; set; }

        /// <summary>
        /// information about preview videos
        /// <br/>array of objects containing information about videos in the preview block of the playlist element
        /// </summary>
        [JsonProperty("preview_videos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<PreviewVideos> PreviewVideos { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}