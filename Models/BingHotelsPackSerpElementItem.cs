using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BingHotelsPackSerpElementItem  : BaseBingSerpApiElementItem 
    {

        /// <summary>
        /// title of the item
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// starting date of stay
        /// <br/>in the format “year-month-date”
        /// <br/>example:
        /// <br/>2019-11-15
        /// </summary>
        [JsonProperty("date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of stay
        /// <br/>in the format “year-month-date”
        /// <br/>example:
        /// <br/>2019-11-17
        /// </summary>
        [JsonProperty("date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// contains results featured in the ‘hotels_pack’ element of SERP
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<HotelsPackElement> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}