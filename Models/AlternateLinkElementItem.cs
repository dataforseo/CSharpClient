using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AlternateLinkElementItem  : BaseOnPageLinkItemInfo 
    {

        /// <summary>
        /// status code of the referenced page
        /// <br/>status code of the page to which the link is pointing
        /// </summary>
        [JsonProperty("page_to_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageToStatusCode { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}