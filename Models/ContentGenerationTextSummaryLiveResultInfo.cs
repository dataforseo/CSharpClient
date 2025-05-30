using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentGenerationTextSummaryLiveResultInfo 
    {

        /// <summary>
        /// number of sentences found in the target text
        /// </summary>
        [JsonProperty("sentences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Sentences { get; set; }

        /// <summary>
        /// number of paragraphs found in the target text
        /// </summary>
        [JsonProperty("paragraphs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Paragraphs { get; set; }

        /// <summary>
        /// number of words found in the target text
        /// </summary>
        [JsonProperty("words", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Words { get; set; }

        /// <summary>
        /// number of characters without spaces found in the target text
        /// </summary>
        [JsonProperty("characters_without_spaces", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CharactersWithoutSpaces { get; set; }

        /// <summary>
        /// number of characters with spaces found in the target text
        /// </summary>
        [JsonProperty("characters_with_spaces", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CharactersWithSpaces { get; set; }

        /// <summary>
        /// average number of words per sentence in the target text
        /// </summary>
        [JsonProperty("words_per_sentence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? WordsPerSentence { get; set; }

        /// <summary>
        /// average number of characters per word in the target text
        /// </summary>
        [JsonProperty("characters_per_word", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CharactersPerWord { get; set; }

        /// <summary>
        /// vocabulary density of the target text
        /// </summary>
        [JsonProperty("vocabulary_density", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? VocabularyDensity { get; set; }

        /// <summary>
        /// keyword density of the target text
        /// <br/>contains most common words and their count
        /// </summary>
        [JsonProperty("keyword_density", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> KeywordDensity { get; set; }

        /// <summary>
        /// Automated Readability Index
        /// </summary>
        [JsonProperty("automated_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? AutomatedReadabilityIndex { get; set; }

        /// <summary>
        /// Coleman–Liau Index
        /// </summary>
        [JsonProperty("coleman_liau_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ColemanLiauIndex { get; set; }

        /// <summary>
        /// Flesch–Kincaid Readability Index
        /// </summary>
        [JsonProperty("flesch_kincaid_grade_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? FleschKincaidGradeLevel { get; set; }

        /// <summary>
        /// SMOG Readability Index
        /// </summary>
        [JsonProperty("smog_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? SmogReadabilityIndex { get; set; }

        /// <summary>
        /// number of spelling errors found in the target text
        /// </summary>
        [JsonProperty("spelling_errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SpellingErrors { get; set; }

        /// <summary>
        /// number of grammar errors found in the target text
        /// </summary>
        [JsonProperty("grammar_errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? GrammarErrors { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}