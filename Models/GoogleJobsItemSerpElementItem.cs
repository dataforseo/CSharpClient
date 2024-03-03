namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GoogleJobsItemSerpElementItem : BaseSerpElementItem
    {
        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the XPath of the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xpath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// ID of the job on Google Jobs
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// title of the job
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// name of the employer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employer_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmployerName { get; set; }

        /// <summary>
        /// URL to the employer’s website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employer_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmployerUrl { get; set; }

        /// <summary>
        /// URL to the image used in the job posting
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employer_image_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmployerImageUrl { get; set; }

        /// <summary>
        /// location for which the job vacancy is posted
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// original source of the job vacancy
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceName { get; set; }

        /// <summary>
        /// URL to the original source of the job vacancy
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// the salary indicated in the job vacancy
        /// <br/>if the salary isn’t indicated, this field will equal null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("salary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Salary { get; set; }

        /// <summary>
        /// employment contract type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractType { get; set; }

        /// <summary>
        /// date and time when the result was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// indicates how long ago the job vacancy was posted
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_ago", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeAgo { get; set; }

        /// <summary>
        /// rectangle parameters
        /// <br/>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP;
        /// <br/>in this case, will equal null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rectangle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Rectangle Rectangle { get; set; }

    }
}