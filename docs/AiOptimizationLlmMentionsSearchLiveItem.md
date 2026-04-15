# AiOptimizationLlmMentionsSearchLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Platform** | **string** | platform received in a POST array |[optional]|
**ModelName** | **string** | name of the AI model from which the data was retrievedNote: for the google platform type, the value is always google_ai_overview |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**Question** | **string** | relevant question |[optional]|
**Answer** | **string** | relevant answer in markdown formatcontent of the result formatted in the markdown markup language |[optional]|
**Sources** | **IEnumerable<Sources>** | array of sourcesthe sources the model cited or relied on in its final answer |[optional]|
**SearchResults** | **IEnumerable<SearchResults>** | array of search resultsall web search outputs the model retrieved when looking up information, including duplicates and unused entries |[optional]|
**AiSearchVolume** | **long?** | current AI search volume rate of a keywordlearn more about this metric here |[optional]|
**MonthlySearches** | **IEnumerable<MonthlySearchesInfo>** | monthly AI search volume ratesarray of objects with AI search volume rates in a certain month of a year |[optional]|
**FirstResponseAt** | **string** | date and time when the response data was first recordedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2025-10-21 06:25:30 +00:00 |[optional]|
**LastResponseAt** | **string** | date and time when the response data was last updatedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2025-10-21 06:25:30 +00:00 |[optional]|
**BrandEntities** | **IEnumerable<BrandEntities>** | array of brand entitiescontains information on brands mentioned in the response |[optional]|
**FanOutQueries** | **IEnumerable<string>** | array of fan-out queriescontains related search queries derived from the main query to provide a more comprehensive response |[optional]|