using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleFinanceAboutElementItem  : BaseSerpApiGoogleFinanceElementItem 
    {

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// displayed name of the market index
        /// <br/>example: E-mini Dow ($5)
        /// </summary>
        [JsonProperty("displayed_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayedName { get; set; }

        /// <summary>
        /// company description
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// source of information provided in description
        /// </summary>
        [JsonProperty("description_source_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DescriptionSourceUrl { get; set; }

        /// <summary>
        /// Chief Executive Officer of the company
        /// </summary>
        [JsonProperty("ceo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ceo { get; set; }

        /// <summary>
        /// date when the company was founded
        /// <br/>in the format: “yyyy-mm-ddThh-mm-ssZ”
        /// <br/>example:
        /// <br/>1993-04-05T00:00:00Z
        /// </summary>
        [JsonProperty("founded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Founded { get; set; }

        /// <summary>
        /// company headquarters
        /// </summary>
        [JsonProperty("headquarters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Headquarters { get; set; }

        /// <summary>
        /// company website
        /// </summary>
        [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Website { get; set; }

        /// <summary>
        /// number of company employees
        /// </summary>
        [JsonProperty("employees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Employees { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}