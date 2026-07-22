# AiOptimizationLlmMentionsSearchMentionsLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Platform** | **string** | platform received in a POST array |[optional]|
**ModelName** | **string** | name of the AI model from which the data was retrieved<br>Note: for the google platform type, the value is always google_ai_overview |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**Question** | **string** | relevant question |[optional]|
**Answer** | **string** | relevant answer in markdown format<br>content of the result formatted in the markdown markup language |[optional]|
**Sources** | **IEnumerable<Sources>** | array of sources<br>the sources the model cited or relied on in its final answer<br>learn more about the sources and how to retrieve LLM citation data at our Help Center |[optional]|
**SearchResults** | **IEnumerable<SearchResults>** | array of search results<br>all web search outputs the model retrieved when looking up information, including duplicates and unused entries |[optional]|
**AiSearchVolume** | **long?** | current AI search volume rate of a keyword<br>learn more about this metric here |[optional]|
**MonthlySearches** | **IEnumerable<MonthlySearchesInfo>** | monthly AI search volume rates<br>array of objects with AI search volume rates in a certain month of a year |[optional]|
**FirstResponseAt** | **string** | date and time when the response data was first recorded<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2025-10-21 06:25:30 +00:00 |[optional]|
**LastResponseAt** | **string** | date and time when the response data was last updated<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2025-10-21 06:25:30 +00:00 |[optional]|
**BrandEntities** | **IEnumerable<BrandEntities>** | array of brand entities<br>contains information on brands mentioned in the response |[optional]|
**FanOutQueries** | **IEnumerable<string>** | array of fan-out queries<br>contains related search queries derived from the main query to provide a more comprehensive response |[optional]|
**IsWebSearchBased** | **bool?** | indicates whether the response was generated using web search results<br>if true, the model retrieved live web search results to produce the response<br>if false, the response was generated from the model's internal knowledge |[optional]|