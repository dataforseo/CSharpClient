using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class StoresCountInfo 
    {

        /// <summary>
        /// number of stores that offer the product
        /// </summary>
        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// text displayed on the Google Shopping page
        /// </summary>
        [JsonProperty("displayed_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayedText { get; set; }

        /// <summary>
        /// whether the number of stores is taken from text
        /// <br/>indicates whether the number of stores is taken from <c>displayed_text</c>;
        /// <br/>if the API finds the exact number of stores in the HTML code of the Google Shopping page, this parameter is <c>false</c>;
        /// <br/>if the API cannot find the number of stores in the HTML code of the page, it takes the number from the <c>displayed_text</c>;
        /// <br/>in this case, the parameter is <c>true</c>
        /// </summary>
        [JsonProperty("count_from_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CountFromText { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}