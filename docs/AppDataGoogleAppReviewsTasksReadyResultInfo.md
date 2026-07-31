# AppDataGoogleAppReviewsTasksReadyResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | <em>task identifier of the completed task</em><br><strong>unique task identifier in our system in the <a href='https://en.wikipedia.org/wiki/Universally_unique_identifier'>UUID</a> format</strong> |[optional]|
**Se** | **string** | <em>search engine specified when setting the task</em> |[optional]|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**DatePosted** | **string** | <em>date when the task was posted (in the UTC format)</em> |[optional]|
**Tag** | **string** |  |[optional]|
**EndpointAdvanced** | **string** | <em>URL for collecting the results of the {{up_se_name}} {{normal_se_type}} task</em> |[optional]|
**EndpointHtml** | **string** | <em>URL for collecting the results of the {{up_se_name}} {{normal_se_type}} HTML task</em><br>if HTML tasks are not supported in the specified endpoint, the value will be <code>null</code> |[optional]|