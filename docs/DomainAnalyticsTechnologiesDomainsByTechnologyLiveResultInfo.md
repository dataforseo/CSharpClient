# DomainAnalyticsTechnologiesDomainsByTechnologyLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **double?** | total number of relevant items in the database |[optional]|
**ItemsCount** | **double?** | number of items in the results array |[optional]|
**Offset** | **double?** | specified offset value |[optional]|
**OffsetToken** | **string** | token for subsequent requests<br>by specifying the unique offset_token when setting a new task, you will get the subsequent results of the initial task;<br>offset_token values are unique for each subsequent task |[optional]|
**Items** | **IEnumerable<DomainAnalyticsTechnologiesDomainsByLiveItem>** | items array |[optional]|