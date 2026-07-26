# AiOptimizationGeminiLlmScraperTasksReadyResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | <em>task identifier of the completed task</em><br><strong>unique task identifier in our system in the <a href='https://en.wikipedia.org/wiki/Universally_unique_identifier'>UUID</a> format</strong> |[optional]|
**Se** | **string** | <em>search engine specified when setting the task</em> |[optional]|
**Function** | **string** | <em>search engine function</em><br>example: <code>llm_scraper</code> |[optional]|
**DatePosted** | **string** | <em>date when the task was posted (in the UTC format)</em> |[optional]|
**Tag** | **string** | <em>user-defined task identifier</em> |[optional]|
**EndpointAdvanced** | **string** | <em>URL for collecting the results of the Advanced task</em><br>if the Advanced function is not supported in the specified endpoint, the value will be <code>null</code> |[optional]|
**EndpointHtml** | **string** | <em>URL for collecting the results of the HTML task</em><br>if the HTML function is not supported in the specified endpoint, the value will be <code>null</code> |[optional]|