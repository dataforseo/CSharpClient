# BacklinksBacklinksLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Target** | **string** | target domain in a POST array |[optional]|
**Mode** | **string** | mode specified in a POST array |[optional]|
**CustomMode** | **IDictionary<string, object>** | custom mode specified in a POST array |[optional]|
**TotalCount** | **long?** | total amount of results relevant the request |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<BacklinksBacklinksLiveItem>** | contains relevant backlinks and referring domains data |[optional]|
**SearchAfterToken** | **string** | token for subsequent requests<br>by specifying the unique search_after_token when setting a new task, you will get the subsequent results of the initial task;<br>search_after_token values are unique for each subsequent task |[optional]|