using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppUserProfileInfo 
    {

        /// <summary>
        /// profile name of the reviewer
        /// </summary>
        [JsonProperty("profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileName { get; set; }

        /// <summary>
        /// URL to the reviewer’s profile image
        /// </summary>
        [JsonProperty("profile_image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileImageUrl { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}