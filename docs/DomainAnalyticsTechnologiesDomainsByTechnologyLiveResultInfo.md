# DomainAnalyticsTechnologiesDomainsByTechnologyLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | total number of relevant items in the database |[optional]|
**ItemsCount** | **long?** | number of items in the results array |[optional]|
**Offset** | **int?** | specified offset value |[optional]|
**OffsetToken** | **string** | token for subsequent requests<br>by specifying the unique offset_token when setting a new task, you will get the subsequent results of the initial task;<br>offset_token values are unique for each subsequent task |[optional]|
**Items** | **IEnumerable<DomainAnalyticsTechnologiesDomainsByLiveItem>** | items array |[optional]|