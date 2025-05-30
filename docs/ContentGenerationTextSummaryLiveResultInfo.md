# ContentGenerationTextSummaryLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Sentences** | **double?** | number of sentences found in the target text |[optional]|
**Paragraphs** | **double?** | number of paragraphs found in the target text |[optional]|
**Words** | **double?** | number of words found in the target text |[optional]|
**CharactersWithoutSpaces** | **double?** | number of characters without spaces found in the target text |[optional]|
**CharactersWithSpaces** | **double?** | number of characters with spaces found in the target text |[optional]|
**WordsPerSentence** | **float?** | average number of words per sentence in the target text |[optional]|
**CharactersPerWord** | **float?** | average number of characters per word in the target text |[optional]|
**VocabularyDensity** | **float?** | vocabulary density of the target text |[optional]|
**KeywordDensity** | **IDictionary<string, long?>** | keyword density of the target text<br>contains most common words and their count |[optional]|
**AutomatedReadabilityIndex** | **float?** | Automated Readability Index |[optional]|
**ColemanLiauIndex** | **float?** | Coleman–Liau Index |[optional]|
**FleschKincaidGradeLevel** | **float?** | Flesch–Kincaid Readability Index |[optional]|
**SmogReadabilityIndex** | **float?** | SMOG Readability Index |[optional]|
**SpellingErrors** | **double?** | number of spelling errors found in the target text |[optional]|
**GrammarErrors** | **double?** | number of grammar errors found in the target text |[optional]|