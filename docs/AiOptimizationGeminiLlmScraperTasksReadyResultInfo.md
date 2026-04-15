# AiOptimizationGeminiLlmScraperTasksReadyResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | task identifier of the completed taskunique task identifier in our system in the UUID format |[optional]|
**Se** | **string** | search engine specified when setting the task |[optional]|
**Function** | **string** | search engine functionexample: llm_scraper |[optional]|
**DatePosted** | **string** | date when the task was posted (in the UTC format) |[optional]|
**Tag** | **string** | user-defined task identifier |[optional]|
**EndpointAdvanced** | **string** | URL for collecting the results of the Advanced taskif the Advanced function is not supported in the specified endpoint, the value will be null |[optional]|
**EndpointHtml** | **string** | URL for collecting the results of the HTML taskif the HTML function is not supported in the specified endpoint, the value will be null |[optional]|