using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsStatusInfo 
    {

        /// <summary>
        /// update date of the Google endpoints
        /// <br/>indicates the last date when the Google endpoints of DataForSEO Labs API were updated;
        /// <br/>example:
        /// <br/>2022-05-16
        /// </summary>
        [JsonProperty("date_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateUpdate { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}