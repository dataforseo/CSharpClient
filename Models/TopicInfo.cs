using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TopicInfo 
    {

        /// <summary>
        /// meta title
        /// </summary>
        [JsonProperty("h_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HTitle { get; set; }

        /// <summary>
        /// main title of the block
        /// </summary>
        [JsonProperty("main_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MainTitle { get; set; }

        /// <summary>
        /// content author name
        /// </summary>
        [JsonProperty("author", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// content language
        /// </summary>
        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// HTML level
        /// </summary>
        [JsonProperty("level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// primary content on the page
        /// <br/>you can find more information about content priority calculation in this help center article
        /// </summary>
        [JsonProperty("primary_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SectionContentItemInfo> PrimaryContent { get; set; }

        /// <summary>
        /// secondary content on the page
        /// <br/>you can find more information about content priority calculation in this help center article
        /// </summary>
        [JsonProperty("secondary_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SectionContentItemInfo> SecondaryContent { get; set; }

        /// <summary>
        /// content of the table on the page
        /// </summary>
        [JsonProperty("table_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TableContentInfo> TableContent { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}