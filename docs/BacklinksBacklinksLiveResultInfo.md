# BacklinksBacklinksLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Target** | **string** | <em>target domain in a POST array</em> |[optional]|
**Mode** | **string** | <em>mode specified in a POST array</em> |[optional]|
**CustomMode** | **IDictionary<string, object>** | <em>custom mode specified in a POST array</em> |[optional]|
**TotalCount** | **long?** | <em>total amount of results relevant the request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<BacklinksBacklinksLiveItem>** | <em>contains relevant backlinks and referring domains data</em> |[optional]|
**SearchAfterToken** | **string** | <em>token for subsequent requests</em><br>by specifying the unique <code>search_after_token</code> when setting a new task, you will get the subsequent results of the initial task;<br><code>search_after_token</code> values are unique for each subsequent task |[optional]|