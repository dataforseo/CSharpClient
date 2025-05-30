using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class HtmlContentInfo 
    {

        /// <summary>
        /// total size of the text on the page measured in bytes
        /// </summary>
        [JsonProperty("plain_text_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PlainTextSize { get; set; }

        /// <summary>
        /// plaintext rate value
        /// <br/>plain_text_size to size ratio
        /// </summary>
        [JsonProperty("plain_text_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PlainTextRate { get; set; }

        /// <summary>
        /// number of words on the page
        /// </summary>
        [JsonProperty("plain_text_word_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? PlainTextWordCount { get; set; }

        /// <summary>
        /// Automated Readability Index
        /// </summary>
        [JsonProperty("automated_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? AutomatedReadabilityIndex { get; set; }

        /// <summary>
        /// Coleman–Liau Index
        /// </summary>
        [JsonProperty("coleman_liau_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ColemanLiauReadabilityIndex { get; set; }

        /// <summary>
        /// Dale–Chall Readability Index
        /// </summary>
        [JsonProperty("dale_chall_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? DaleChallReadabilityIndex { get; set; }

        /// <summary>
        /// Flesch–Kincaid Readability Index
        /// </summary>
        [JsonProperty("flesch_kincaid_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? FleschKincaidReadabilityIndex { get; set; }

        /// <summary>
        /// SMOG Readability Index
        /// </summary>
        [JsonProperty("smog_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? SmogReadabilityIndex { get; set; }

        /// <summary>
        /// consistency of the meta description tag with the page content
        /// <br/>measured from 0 to 1
        /// </summary>
        [JsonProperty("description_to_content_consistency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? DescriptionToContentConsistency { get; set; }

        /// <summary>
        /// consistency of the meta title tag with the page content
        /// <br/>measured from 0 to 1
        /// </summary>
        [JsonProperty("title_to_content_consistency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? TitleToContentConsistency { get; set; }

        /// <summary>
        /// consistency of meta keywordstag with the page content
        /// <br/>measured from 0 to 1
        /// </summary>
        [JsonProperty("meta_keywords_to_content_consistency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? MetaKeywordsToContentConsistency { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}