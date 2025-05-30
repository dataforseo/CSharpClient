using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageLighthouseLiveJsonTaskInfo  : BaseResponseTaskInfo 
    {

        /// <summary>
        /// results of Lighthouse audit
        /// <br/>this array will include data according to the parameters you specified when setting a task;
        /// <br/>all fields and their descriptions are available in the official documentation by this link.
        /// </summary>
        [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<IDictionary<string, object>> Result { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}