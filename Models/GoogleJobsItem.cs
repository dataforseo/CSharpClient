using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleJobsItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

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
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the XPath of the element
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// ID of the job on Google Jobs
        /// </summary>
        [JsonProperty("job_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// title of the element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// name of the employer
        /// </summary>
        [JsonProperty("employer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EmployerName { get; set; }

        /// <summary>
        /// URL to the employer’s website
        /// </summary>
        [JsonProperty("employer_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EmployerUrl { get; set; }

        /// <summary>
        /// URL to the image used in the job posting
        /// </summary>
        [JsonProperty("employer_image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EmployerImageUrl { get; set; }

        /// <summary>
        /// location for which the job vacancy is posted
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// original source of the job vacancy
        /// </summary>
        [JsonProperty("source_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SourceName { get; set; }

        /// <summary>
        /// URL to the original source of the job vacancy
        /// </summary>
        [JsonProperty("source_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// the salary indicated in the job vacancy
        /// <br/>if the salary isn’t indicated, this field will equal null
        /// </summary>
        [JsonProperty("salary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Salary { get; set; }

        /// <summary>
        /// employment contract type
        /// </summary>
        [JsonProperty("contract_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ContractType { get; set; }

        /// <summary>
        /// date and time when the result was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// indicates how long ago the job vacancy was posted
        /// </summary>
        [JsonProperty("time_ago", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TimeAgo { get; set; }

        /// <summary>
        /// rectangle parameters
        /// <br/>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP;
        /// <br/>in this case, will equal null
        /// </summary>
        [JsonProperty("rectangle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AiModeRectangleInfo Rectangle { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}