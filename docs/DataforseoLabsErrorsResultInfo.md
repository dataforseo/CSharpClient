# DataforseoLabsErrorsResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | id of the task |[optional]|
**Datetime** | **string** | date and time when an error occurred<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Function** | **string** | corresponding API function |[optional]|
**ErrorCode** | **int?** | error code |[optional]|
**ErrorMessage** | **string** | error message or error URL<br>error message (see full list) or URL that caused an error |[optional]|
**HttpUrl** | **string** | URL that caused an error<br>URL you used for making an API call |[optional]|
**HttpMethod** | **string** | HTTP method |[optional]|
**HttpCode** | **int?** | HTTP status code |[optional]|
**HttpTime** | **double?** | time taken by HTTP request |[optional]|
**HttpResponse** | **string** | HTTP response<br>server response |[optional]|