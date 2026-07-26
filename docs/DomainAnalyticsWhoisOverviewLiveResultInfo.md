# DomainAnalyticsWhoisOverviewLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | <em>total amount of results in our database relevant to your request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Offset** | **int?** | <em> results offset value specified in POST request</em> |[optional]|
**OffsetToken** | **string** |  |[optional]|
**Items** | **IEnumerable<DomainAnalyticsWhoisOverviewLiveItem>** | <em>contains ranking and traffic data</em> |[optional]|