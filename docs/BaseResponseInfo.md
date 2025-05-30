# BaseResponseInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Version** | **string** | the current version of the API |[optional]|
**StatusCode** | **int?** | general status code<br>you can find the full list of the response codes here |[optional]|
**StatusMessage** | **string** | general informational message<br>you can find the full list of general informational messages here |[optional]|
**Time** | **string** | total execution time, seconds |[optional]|
**Cost** | **double?** | total tasks cost, USD |[optional]|
**TasksCount** | **long?** | the number of tasks in the tasks array |[optional]|
**TasksError** | **long?** | the number of tasks in the tasks array returned with an error |[optional]|