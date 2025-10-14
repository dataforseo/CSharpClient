# AiOptimizationChatGptLlmScraperTasksReadyResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | task identifier of the completed task<br>unique task identifier in our system in the UUID format |[optional]|
**Se** | **string** | search engine specified when setting the task |[optional]|
**SeType** | **string** | type of search engine<br>example: llm_scraper |[optional]|
**DatePosted** | **string** | date when the task was posted (in the UTC format) |[optional]|
**Tag** | **string** | user-defined task identifier |[optional]|
**EndpointRegular** | **string** | URL for collecting the results of the Regular task<br>if the Regular function is not supported in the specified endpoint, the value will be null |[optional]|
**EndpointAdvanced** | **string** | URL for collecting the results of the Advanced task<br>if the Advanced function is not supported in the specified endpoint, the value will be null |[optional]|
**EndpointHtml** | **string** | URL for collecting the results of the HTML task<br>if the HTML function is not supported in the specified endpoint, the value will be null |[optional]|