# AiOptimizationLlmMentionsSearchLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Platform** | **string** | platform received in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**Question** | **string** | relevant question |[optional]|
**Answer** | **string** | relevant answer in markdown format<br>content of the result formatted in the markdown markup language |[optional]|
**Sources** | **IEnumerable<Sources>** | array of sources<br>the sources the model cited or relied on in its final answer |[optional]|
**SearchResults** | **IEnumerable<SearchResults>** | array of search results<br>all web search outputs the model retrieved when looking up information, including duplicates and unused entries |[optional]|
**AiSearchVolume** | **long?** | current AI search volume rate of a keyword<br>learn more about this metric here |[optional]|
**MonthlySearches** | **IEnumerable<MonthlySearchesInfo>** |  |[optional]|