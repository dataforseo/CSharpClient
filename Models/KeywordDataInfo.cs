using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordDataInfo 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// returned keyword idea
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// location code in a POST array
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// keyword data for the returned keyword idea
        /// </summary>
        [JsonProperty("keyword_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeywordInfo KeywordInfo { get; set; }

        /// <summary>
        /// contains keyword search volume normalized with Bing search volume
        /// </summary>
        [JsonProperty("keyword_info_normalized_with_bing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeywordInfoNormalizedWithInfo KeywordInfoNormalizedWithBing { get; set; }

        /// <summary>
        /// contains keyword search volume normalized with clickstream data
        /// </summary>
        [JsonProperty("keyword_info_normalized_with_clickstream", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeywordInfoNormalizedWithInfo KeywordInfoNormalizedWithClickstream { get; set; }

        /// <summary>
        /// clickstream data for the returned keyword
        /// <br/>to retrieve results for this field, the parameter include_clickstream_data must be set to true
        /// </summary>
        [JsonProperty("clickstream_keyword_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ClickstreamKeywordInfo ClickstreamKeywordInfo { get; set; }

        /// <summary>
        /// additional information about the keyword
        /// </summary>
        [JsonProperty("keyword_properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeywordProperties KeywordProperties { get; set; }

        /// <summary>
        /// SERP data
        /// <br/>the value will be null if you didn’t set the field include_serp_info to true in the POST array or if there is no SERP data for this keyword in our database
        /// </summary>
        [JsonProperty("serp_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SerpInfo SerpInfo { get; set; }

        /// <summary>
        /// backlink data for the returned keyword
        /// <br/>this object provides the average number of backlinks, referring pages and domains, as well as the average rank values among the top-10 webpages ranking organically for the keyword
        /// </summary>
        [JsonProperty("avg_backlinks_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AvgBacklinksInfo AvgBacklinksInfo { get; set; }

        /// <summary>
        /// search intent info for the returned keyword
        /// <br/>learn about search intent in this help center article
        /// </summary>
        [JsonProperty("search_intent_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SearchIntentInfo SearchIntentInfo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}