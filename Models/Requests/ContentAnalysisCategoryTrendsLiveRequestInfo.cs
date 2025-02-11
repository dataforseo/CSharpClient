using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentAnalysisCategoryTrendsLiveRequestInfo
    {
        /// <summary>
        /// target category code
        /// <br/>required field
        /// <br/>to obtain a full list of available categories, refer to the Categories endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// target page types
        /// <br/>optional field
        /// <br/>use this parameter to filter the dataset by page types
        /// <br/>possible values:
        /// <br/>"ecommerce", "news", "blogs", "message-boards", "organization"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> PageType { get; set; }

        /// <summary>
        /// results grouping type
        /// <br/>optional field
        /// <br/>possible grouping types:
        /// <br/>as_is – returns data on all citations for the target category_code
        /// <br/>one_per_domain – returns data on one citation of the category_code per domain
        /// <br/>default value: as_is
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_mode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SearchMode { get; set; }

        /// <summary>
        /// maximum number of elements within internal arrays
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of elements within the following arrays:
        /// <br/>top_domains
        /// <br/>text_categories
        /// <br/>page_categories
        /// <br/>countries
        /// <br/>languages
        /// <br/>default value: 1
        /// <br/>maximum value: 20
        /// </summary>
        [Newtonsoft.Json.JsonProperty("internal_list_limit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>required field
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2019-01-15"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>if you don’t specify this field, today’s date will be used by default
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2019-01-15"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// time range which will be used to group the results
        /// <br/>optional field
        /// <br/>default value: month
        /// <br/>possible values: day, week, month
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateGroup { get; set; }

        /// <summary>
        /// initial dataset filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like,not_like, has, has_not, match, not_match
        /// <br/>you can use the % operator with like and not_like to match any string of zero or more characters
        /// <br/>example:
        /// <br/>["domain","&lt; &gt;", "logitech.com"]
        /// <br/>[["domain","&lt; &gt;","logitech.com"],"and",["content_info.connotation_types.negative","&gt;",1000]]
        /// <br/>[["domain","&lt; &gt;","logitech.com"]],
        /// <br/>"and",
        /// <br/>[["content_info.connotation_types.negative","&gt;",1000],
        /// <br/>"or",
        /// <br/>["content_info.text_category","has",10994]]]
        /// <br/>for more information about filters, please refer to Content Analysis API – Filters
        /// </summary>
        [Newtonsoft.Json.JsonProperty("initial_dataset_filters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> InitialDatasetFilters { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}