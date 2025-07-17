using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageResourceLocationInfo 
    {

        /// <summary>
        /// line number
        /// <br/>the number of the line on which the resource is located
        /// </summary>
        [JsonProperty("line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line { get; set; }

        /// <summary>
        /// position in line
        /// <br/>the number of line characters before the resource;
        /// <br/>sometimes referred to as column
        /// <br/>Note: counts from 1, i.e. if the resource doesn’t have any characters to the left, the value will be 1
        /// </summary>
        [JsonProperty("offset_left", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OffsetLeft { get; set; }

        /// <summary>
        /// position in the document
        /// <br/>the total number of characters between the resource and the top of HTML
        /// </summary>
        [JsonProperty("offset_top", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OffsetTop { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}