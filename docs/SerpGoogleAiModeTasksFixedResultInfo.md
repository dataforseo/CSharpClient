# SerpGoogleAiModeTasksFixedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | task identifier of the completed task<br>unique task identifier in our system in the UUID format |[optional]|
**Se** | **string** | search engine specified when setting the task |[optional]|
**SeType** | **string** | type of search engine<br>can take the following values: ai_mode |[optional]|
**DateFixed** | **string** | date when the task was fixed (in the UTC format) |[optional]|
**Tag** | **string** | user-defined task identifier |[optional]|
**EndpointRegular** | **string** | URL for collecting the results of the SERP Regular task<br>if SERP Regular is not supported in the specified endpoint, the value will be null |[optional]|
**EndpointAdvanced** | **string** | URL for collecting the results of the SERP Advanced task<br>if SERP Advanced is not supported in the specified endpoint, the value will be null |[optional]|
**EndpointHtml** | **string** | URL for collecting the results of the SERP HTML task<br>if SERP HTML is not supported in the specified endpoint, the value will be null |[optional]|