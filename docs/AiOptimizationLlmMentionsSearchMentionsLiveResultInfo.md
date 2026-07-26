# AiOptimizationLlmMentionsSearchMentionsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | <em>total amount of results relevant the request</em> |[optional]|
**Offset** | **int?** |  |[optional]|
**SearchAfterToken** | **string** | <em>token for subsequent requests</em><br>by specifying the unique <code>search_after_token</code> when setting a new task, you will get the subsequent results of the initial task;<br><code>search_after_token</code> values are unique for each subsequent task |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<AiOptimizationLlmMentionsSearchMentionsLiveItem>** | <em>contains relevant mentions data</em> |[optional]|