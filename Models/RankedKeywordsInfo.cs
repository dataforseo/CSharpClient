using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class RankedKeywordsInfo 
    {
        [JsonProperty("google", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DataforseoLabsAvailableFiltersGoogleInfo Google { get; set; }
        [JsonProperty("bing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Bing { get; set; }
        [JsonProperty("amazon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DataforseoLabsAvailableFiltersAmazonInfo Amazon { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}