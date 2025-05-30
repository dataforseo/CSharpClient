using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ScreenshotItem 
    {

        /// <summary>
        /// screenshot of the requested page
        /// <br/>URL of the page screenshot on the DataForSEO storage
        /// <br/>note: the page screenshot saved on the DataForSEO storage only remains accessible for one day after making the request
        /// </summary>
        [JsonProperty("image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}