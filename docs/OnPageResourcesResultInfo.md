# OnPageResourcesResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | status of the crawling session<br>possible values: in_progress, finished |[optional]|
**CrawlStatus** | **CrawlStatusInfo** | details of the crawling session |[optional]|
**SearchAfterToken** | **string** |  |[optional]|
**CurrentOffset** | **int?** |  |[optional]|
**TotalItemsCount** | **long?** | total number of relevant items crawled |[optional]|
**ItemsCount** | **long?** | number of items in the results array |[optional]|
**Items** | **IEnumerable<BaseOnPageResourceItem>** | items array |[optional]|