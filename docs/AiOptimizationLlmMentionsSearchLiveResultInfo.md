# AiOptimizationLlmMentionsSearchLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | total amount of results relevant the request |[optional]|
**CurrentOffset** | **int?** | the number of mentions objects that are omitted in the items array |[optional]|
**SearchAfterToken** | **string** | token for subsequent requestsby specifying the unique search_after_token when setting a new task, you will get the subsequent results of the initial task;search_after_token values are unique for each subsequent task |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<AiOptimizationLlmMentionsSearchLiveItem>** | contains relevant mentions data |[optional]|