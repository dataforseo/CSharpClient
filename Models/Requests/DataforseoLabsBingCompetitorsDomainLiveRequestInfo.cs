using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsBingCompetitorsDomainLiveRequestInfo
    {
        /// <summary>
        /// domain
        /// <br/>required field
        /// <br/>the domain name of the target website
        /// <br/>the domain should be specified without https:// and www.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don’t specify location_code
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_name by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>Note: this endpoint currently supports the US location only;
        /// <br/>example:
        /// <br/>United States
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if you don’t specify location_name
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_code by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>Note: this endpoint currently supports the US location only;
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don’t specify language_code
        /// <br/>Note: it is required to specify either language_name or language_code
        /// <br/>you can receive the list of available languages with their language_name by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if you don’t specify language_name
        /// <br/>Note: it is required to specify either language_name or language_code
        /// <br/>you can receive the list of available languages with their language_code by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// display results by item type
        /// <br/>optional field
        /// <br/>indicates the type of search results included in the response
        /// <br/>Note: if the item_types array contains item types that are different from organic, the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search results not included in the response;
        /// <br/>possible values:
        /// <br/>["organic", "paid", "featured_snippet", "local_pack"]
        /// <br/>default value:
        /// <br/>["organic", "paid", "featured_snippet", "local_pack"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ItemTypes { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in
        /// <br/>example:
        /// <br/>["metrics.organic.count","&gt;",50]
        /// <br/>[["metrics.organic.pos_1","&lt; &gt;",0],"and",["metrics.organic.etv","&gt;=","10"]]
        /// <br/>[[["metrics.organic.count","&gt;=",50],"and",["metrics.organic.pos_1","in",[1,5]]],
        /// <br/>"or",
        /// <br/>["metrics.organic.etv","&gt;=","100"]]
        /// <br/>for more information about filters, please refer to Dataforseo Labs – Filters or this help center guide
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the filters array to sort the results
        /// <br/>possible sorting types:
        /// <br/>asc – results will be sorted in the ascending order
        /// <br/>desc – results will be sorted in the descending order
        /// <br/>you should use a comma to specify a sorting type
        /// <br/>example:
        /// <br/>["metrics.paid.etv,asc"]
        /// <br/>Note: you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>["metrics.organic.etv,desc","metrics.paid.count,asc"]
        /// <br/>default rule:
        /// <br/>["metrics.organic.count,desc"]
        /// <br/>Note: if the item_types array contains item types that are different from organic, the results will be ordered by the first item type in the array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> OrderBy { get; set; }

        /// <summary>
        /// the maximum number of returned domains
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>maximum value: 1000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned domains
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify the 10 value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// maximum rank up to which competitors will be considered
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>if you specify 10 here, we will extract competitors from the top 10 Bing search results only
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxRankGroup { get; set; }

        /// <summary>
        /// indicates whether to exclude world’s largest websites
        /// <br/>optional field
        /// <br/>default value: false
        /// <br/>set to true if you want to get highly-relevant competitors excluding the websites listed below:
        /// <br/>wikipedia.org
        /// <br/>pinterest.com
        /// <br/>amazon.com
        /// <br/>google.com
        /// <br/>facebook.com
        /// <br/>wordpress.com
        /// <br/>medium.com
        /// <br/>quora.com
        /// <br/>reddit.com
        /// <br/>youtube.com
        /// <br/>ebay.com
        /// <br/>uol.com.br
        /// <br/>instagram.com
        /// <br/>olx.com
        /// <br/>twitter.com
        /// <br/>linkedin.com
        /// <br/>slideshare.net
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exclude_top_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ExcludeTopDomains { get; set; }

        /// <summary>
        /// additional domains for improving results accuracy
        /// <br/>optional field
        /// <br/>to improve the accuracy of the result, you can specify domains that are known to intersect with the target in SERPs;
        /// <br/>if you use this array, metrics in the result will be based on SERPs where both target website and intersecting_domains appear;
        /// <br/>Note: you can specify up to 20 domains in this array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intersecting_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> IntersectingDomains { get; set; }

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