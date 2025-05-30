using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsStatusResultInfo 
    {

        /// <summary>
        /// update information for the Google endpoints
        /// </summary>
        [JsonProperty("google", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DataforseoLabsStatusInfo Google { get; set; }

        /// <summary>
        /// update information for the Bing endpoints
        /// </summary>
        [JsonProperty("bing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DataforseoLabsStatusInfo Bing { get; set; }

        /// <summary>
        /// update information for the Amazon endpoints
        /// </summary>
        [JsonProperty("amazon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DataforseoLabsStatusInfo Amazon { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}