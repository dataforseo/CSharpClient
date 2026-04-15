# DomainAnalyticsWhoisOverviewLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | total amount of results in our database relevant to your request |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Offset** | **int?** | results offset value specified in POST request |[optional]|
**OffsetToken** | **string** |  |[optional]|
**Items** | **IEnumerable<DomainAnalyticsWhoisOverviewLiveItem>** | contains ranking and traffic data |[optional]|