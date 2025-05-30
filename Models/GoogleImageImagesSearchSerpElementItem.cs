using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleImageImagesSearchSerpElementItem  : BaseGoogleImagesSerpElementItem 
    {

        /// <summary>
        /// title of the result in SERP
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// subtitle of the result in SERP
        /// </summary>
        [JsonProperty("subtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        /// <summary>
        /// the alt tag of the image
        /// </summary>
        [JsonProperty("alt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Alt { get; set; }

        /// <summary>
        /// search URL with refinement parameters
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// the URL of the source image
        /// </summary>
        [JsonProperty("source_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// the URL of the cached version of the image stored on Google’s servers
        /// </summary>
        [JsonProperty("encoded_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EncodedUrl { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}