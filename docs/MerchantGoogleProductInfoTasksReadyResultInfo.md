# MerchantGoogleProductInfoTasksReadyResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | task identifier of the completed task<br>unique task identifier in our system in the UUID format |[optional]|
**Se** | **string** | search engine specified when setting the task |[optional]|
**SeType** | **string** | type of search engine<br>can take the following values: shopping_specifications |[optional]|
**DatePosted** | **string** | date when the task was posted (in the UTC format) |[optional]|
**Tag** | **string** | user-defined task identifier |[optional]|
**EndpointAdvanced** | **string** | URL for collecting the results of the Google Shopping Product Specifications Advanced task |[optional]|
**EndpointHtml** | **string** | URL for collecting the results of the Google Shopping Product Specifications HTML task<br>note: HTML is not available for this endpoint, the value will be null |[optional]|