using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class ContentAnalysisSummaryLiveRequestInfo 
    {

        /// <summary>
        /// target keyword
        /// <br/>required field
        /// <br/>UTF-8 encoding
        /// <br/>the keywords will be converted to a lowercase format;
        /// <br/>Note: to match an exact phrase instead of a stand-alone keyword, use double quotes and backslashes;
        /// <br/>example:
        /// <br/>'keyword': '\'tesla palo alto\''
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// target keyword fields and target keywords
        /// <br/>optional field
        /// <br/>use this parameter to filter the dataset by keywords that certain fields should contain;
        /// <br/>fields you can specify: title, main_title, previous_title, snippet
        /// <br/>you can indicate several fields;
        /// <br/>Note: to match an exact phrase instead of a stand-alone keyword, use double quotes and backslashes;
        /// <br/>example:
        /// <br/>'keyword_fields': {
        /// <br/>    'snippet': '\'logitech mouse\'',
        /// <br/>    'main_title': 'sale'
        /// <br/>}
        /// </summary>
        [JsonProperty("keyword_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> KeywordFields { get; set; }

        /// <summary>
        /// target page types
        /// <br/>optional field
        /// <br/>use this parameter to filter the dataset by page types
        /// <br/>possible values:
        /// <br/>'ecommerce', 'news', 'blogs', 'message-boards', 'organization'
        /// </summary>
        [JsonProperty("page_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> PageType { get; set; }

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
        [JsonProperty("internal_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

        /// <summary>
        /// positive connotation threshold
        /// <br/>optional field
        /// <br/>specified as the probability index threshold for positive sentiment related to the citation content
        /// <br/>if you specify this field, connotation_types object in the response will only contain data on citations with positive sentiment probability more than or equal to the specified value
        /// <br/>possible values: from 0 to 1
        /// <br/>default value: 0.4
        /// </summary>
        [JsonProperty("positive_connotation_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PositiveConnotationThreshold { get; set; }

        /// <summary>
        /// sentiment connotation threshold
        /// <br/>optional field
        /// <br/>specified as the probability index threshold for sentiment connotations related to the citation content
        /// <br/>if you specify this field, sentiment_connotations object in the response will only contain data on citations where the
        /// <br/>probability per each sentiment is more than or equal to the specified value
        /// <br/>possible values: from 0 to 1
        /// <br/>default value: 0.4
        /// </summary>
        [JsonProperty("sentiments_connotation_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SentimentsConnotationThreshold { get; set; }

        /// <summary>
        /// initial dataset filtering parameters
        /// <br/>optional field
        /// <br/>initial filtering parameters that apply to fields in the Search endpoint
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, like,not_like, has, has_not
        /// <br/>you can use the % operator with like and not_like to match any string of zero or more characters
        /// <br/>example:
        /// <br/>['domain','&lt;&gt;', 'logitech.com']
        /// <br/>[['domain','&lt;&gt;','logitech.com'],'and',['content_info.connotation_types.negative','&gt;',1000]]
        /// <br/>[['domain','&lt;&gt;','logitech.com']],
        /// <br/>'and',
        /// <br/>[['content_info.connotation_types.negative','&gt;',1000],
        /// <br/>'or',
        /// <br/>['content_info.text_category','has',10994]]]
        /// <br/>for more information about filters, please refer to Content Analysis API – Filters
        /// </summary>
        [JsonProperty("initial_dataset_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> InitialDatasetFilters { get; set; }

        /// <summary>
        /// defines the scale used for calculating and displaying the rank values
        /// <br/>optional field
        /// <br/>you can use this parameter to choose whether rank values are presented on a 0–100 or 0–1000 scale
        /// <br/>possible values:
        /// <br/>one_hundred — rank values are displayed on a 0–100 scale
        /// <br/>one_thousand — rank values are displayed on a 0–1000 scale
        /// <br/>default value: one_thousand
        /// <br/>learn more about how this parameter works in this Help Center article
        /// </summary>
        [JsonProperty("rank_scale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankScale { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}