# ContentGenerationTextSummaryLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Sentences** | **int?** | number of sentences found in the target text |[optional]|
**Paragraphs** | **int?** | number of paragraphs found in the target text |[optional]|
**Words** | **int?** | number of words found in the target text |[optional]|
**CharactersWithoutSpaces** | **int?** | number of characters without spaces found in the target text |[optional]|
**CharactersWithSpaces** | **int?** | number of characters with spaces found in the target text |[optional]|
**WordsPerSentence** | **int?** | average number of words per sentence in the target text |[optional]|
**CharactersPerWord** | **int?** | average number of characters per word in the target text |[optional]|
**VocabularyDensity** | **int?** | vocabulary density of the target text |[optional]|
**KeywordDensity** | **IDictionary<string, long?>** | keyword density of the target text<br>contains most common words and their count |[optional]|
**AutomatedReadabilityIndex** | **int?** | Automated Readability Index |[optional]|
**ColemanLiauIndex** | **int?** | Coleman–Liau Index |[optional]|
**FleschKincaidGradeLevel** | **int?** | Flesch–Kincaid Readability Index |[optional]|
**SmogReadabilityIndex** | **int?** | SMOG Readability Index |[optional]|
**SpellingErrors** | **int?** | number of spelling errors found in the target text |[optional]|
**GrammarErrors** | **int?** | number of grammar errors found in the target text |[optional]|