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
**FirstResponseAt** | **string** | date and time when the response data was first recorded<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2025-10-21 06:25:30 +00:00 |[optional]|
**LastResponseAt** | **string** | date and time when the response data was last updated<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2025-10-21 06:25:30 +00:00 |[optional]|
**BrandEntities** | **IEnumerable<BrandEntities>** | array of brand entities<br>contains information on brands mentioned in the response |[optional]|
**FanOutQueries** | **IEnumerable<string>** | array of fan-out queries<br>contains related search queries derived from the main query to provide a more comprehensive response |[optional]|