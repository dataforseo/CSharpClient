# OnPageResourcesResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | status of the crawling session<br>possible values: in_progress, finished |[optional]|
**CrawlStatus** | **CrawlStatus** | details of the crawling session |[optional]|
**SearchAfterToken** | **string** |  |[optional]|
**CurrentOffset** | **double?** |  |[optional]|
**TotalItemsCount** | **double?** | total number of relevant items crawled |[optional]|
**ItemsCount** | **double?** | number of items in the results array |[optional]|
**Items** | **IEnumerable<BaseOnPageResourceItemInfo>** | items array |[optional]|