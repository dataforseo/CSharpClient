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
        public int? Sentences { get; set; }

        /// <summary>
        /// number of paragraphs found in the target text
        /// </summary>
        [JsonProperty("paragraphs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Paragraphs { get; set; }

        /// <summary>
        /// number of words found in the target text
        /// </summary>
        [JsonProperty("words", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Words { get; set; }

        /// <summary>
        /// number of characters without spaces found in the target text
        /// </summary>
        [JsonProperty("characters_without_spaces", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CharactersWithoutSpaces { get; set; }

        /// <summary>
        /// number of characters with spaces found in the target text
        /// </summary>
        [JsonProperty("characters_with_spaces", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CharactersWithSpaces { get; set; }

        /// <summary>
        /// average number of words per sentence in the target text
        /// </summary>
        [JsonProperty("words_per_sentence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WordsPerSentence { get; set; }

        /// <summary>
        /// average number of characters per word in the target text
        /// </summary>
        [JsonProperty("characters_per_word", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CharactersPerWord { get; set; }

        /// <summary>
        /// vocabulary density of the target text
        /// </summary>
        [JsonProperty("vocabulary_density", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VocabularyDensity { get; set; }

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
        public int? AutomatedReadabilityIndex { get; set; }

        /// <summary>
        /// Coleman–Liau Index
        /// </summary>
        [JsonProperty("coleman_liau_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ColemanLiauIndex { get; set; }

        /// <summary>
        /// Flesch–Kincaid Readability Index
        /// </summary>
        [JsonProperty("flesch_kincaid_grade_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FleschKincaidGradeLevel { get; set; }

        /// <summary>
        /// SMOG Readability Index
        /// </summary>
        [JsonProperty("smog_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SmogReadabilityIndex { get; set; }

        /// <summary>
        /// number of spelling errors found in the target text
        /// </summary>
        [JsonProperty("spelling_errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SpellingErrors { get; set; }

        /// <summary>
        /// number of grammar errors found in the target text
        /// </summary>
        [JsonProperty("grammar_errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GrammarErrors { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}