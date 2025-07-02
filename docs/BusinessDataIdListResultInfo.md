# BusinessDataIdListResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | id of the task |[optional]|
**Url** | **string** | URL of the task<br>URL you used for making an API call |[optional]|
**DatetimePosted** | **string** | date and time when the task was made<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2023-01-15 12:57:46 +00:00 |[optional]|
**DatetimeDone** | **string** | date and time when the task was completed<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2023-01-15 12:57:46 +00:00 |[optional]|
**Status** | **string** | informational message of the task<br>you can find the full list of general informational messages here |[optional]|
**Cost** | **float?** | cost of the task, USD |[optional]|
**Metadata** | **IDictionary<string, object>** | contains parameters you specified in the POST request |[optional]|