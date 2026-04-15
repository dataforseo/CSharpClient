# AiOptimizationGeminiLlmScraperTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword received in a POST arraythe keyword is returned with decoded %## (plus symbol '+' will be decoded to a space character) |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**Model** | **string** | indicates the model version |[optional]|
**Datetime** | **string** | date and time when the result was receivedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00 |[optional]|
**Markdown** | **string** | content of the element in markdown formatcontent of the result formatted in the markdown markup language |[optional]|
**Sources** | **IEnumerable<SourceInfo>** | array of sourcesthe sources the model actually cited or relied on in its final answer |[optional]|
**SeResultsCount** | **long?** | total number of results |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search resultscontains types of search results (items) found in SERP.possible item types:gemini_text, gemini_table, gemini_images |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<BaseGeminiLlmScraperElementItem>** | items present in the element |[optional]|