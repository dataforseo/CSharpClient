# AiOptimizationLlmMentionsSearchMentionsLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Platform** | **string** | <em>platform received in a POST array</em> |[optional]|
**ModelName** | **string** | <em>name of the AI model from which the data was retrieved</em><br><strong>Note:</strong> for the <code>google</code> platform type, the value is always <code>google_ai_overview</code> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**Question** | **string** | <em>relevant question</em> |[optional]|
**Answer** | **string** | <em>relevant answer in markdown format</em><br>content of the result formatted in the <a href='https://en.wikipedia.org/wiki/Markdown' target='_blank'>markdown markup language</a> |[optional]|
**Sources** | **IEnumerable<Sources>** | <em>array of sources</em><br>the sources the model cited or relied on in its final answer<br>learn more about the sources and how to retrieve LLM citation data at our <a href='https://dataforseo.com/help-center/how-to-get-llm-citation-data-with-llm-mentions-api' target='_blank'>Help Center</a> |[optional]|
**SearchResults** | **IEnumerable<SearchResults>** | <em>array of search results</em><br>all web search outputs the model retrieved when looking up information, including duplicates and unused entries |[optional]|
**AiSearchVolume** | **long?** | <em>current AI search volume rate of a keyword</em><br>learn more about this metric <a href='https://dataforseo.com/help-center/how-the-ai-search-volume-metric-works-in-llm-mentions' rel='noopener noreferrer' target='_blank'>here</a> |[optional]|
**MonthlySearches** | **IEnumerable<MonthlySearchesInfo>** | <em>monthly AI search volume rates</em><br>array of objects with AI search volume rates in a certain month of a year |[optional]|
**FirstResponseAt** | **string** | <em>date and time when the response data was first recorded</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2025-10-21 06:25:30 +00:00</code> |[optional]|
**LastResponseAt** | **string** | <em>date and time when the response data was last updated</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2025-10-21 06:25:30 +00:00</code> |[optional]|
**BrandEntities** | **IEnumerable<BrandEntities>** | <em>array of brand entities</em><br>contains information on brands mentioned in the response |[optional]|
**FanOutQueries** | **IEnumerable<string>** | <em>array of fan-out queries</em><br>contains related search queries derived from the main query to provide a more comprehensive response |[optional]|
**IsWebSearchBased** | **bool?** | <em>indicates whether the response was generated using web search results</em><br>if <code>true</code>, the model retrieved live web search results to produce the response<br>if <code>false</code>, the response was generated from the model's internal knowledge |[optional]|