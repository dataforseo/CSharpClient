using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OnPageLinksRequestInfo
    {
        /// <summary>
        /// ID of the task
        /// <br/>required field
        /// <br/>you can get this ID in the response of the Task POST endpoint
        /// <br/>example:
        /// <br/>“07131248-1535-0216-1000-17384017ad04”
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// relative page URL
        /// <br/>optional field
        /// <br/>if you use this field, the API response will contain only links from the specified page
        /// <br/>note that in this field you can specify relative URLs only
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PageFrom { get; set; }

        /// <summary>
        /// relative page URL
        /// <br/>optional field
        /// <br/>if you use this field, the API response will contain only internal links pointing to the specified page
        /// <br/>note that in this field you can specify relative URLs only
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PageTo { get; set; }

        /// <summary>
        /// the maximum number of returned links
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>maximum value: 1000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned links
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify the 10 value, the first ten links in the results array will be omitted and the data will be provided for the successive links
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, =, &lt; &gt;, in, not_in, like, not_like
        /// <br/>you can use the % operator with like and not_like to match any string of zero or more characters
        /// <br/>example:
        /// <br/>["direction","=","external"]
        /// <br/>[["domain_to","&lt; &gt;","example.com"],
        /// <br/>"and",
        /// <br/>["link_from","not_like","%example.com/blog%"]]
        /// <br/>[["direction","=","external"],
        /// <br/>"and",
        /// <br/>[["link_from","like","%example.com/blog%"],"or",["link_from","like","%example.com/help%"]]]
        /// <br/>The full list of possible filters is available by this link.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> Filters { get; set; }

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