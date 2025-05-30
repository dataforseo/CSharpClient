# AppDataGoogleAppSearchesTasksReadyResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | task identifier of the completed task<br>unique task identifier in our system in the UUID format |[optional]|
**Se** | **string** | search engine specified when setting the task |[optional]|
**SeType** | **string** | search engine type |[optional]|
**DatePosted** | **string** | date when the task was posted (in the UTC format) |[optional]|
**Tag** | **string** | user-defined task identifier |[optional]|
**EndpointAdvanced** | **string** | URL for collecting the results of the Google App Searches task |[optional]|
**EndpointHtml** | **string** | URL for collecting the results of the Google App Searches HTML task<br>if HTML tasks are not supported in the specified endpoint, the value will be null |[optional]|