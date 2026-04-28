# OnPageUncrawlableResourcesResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | status of the crawling sessionpossible values: in_progress, finished |[optional]|
**CrawlStatus** | **CrawlStatusInfo** | details of the crawling session |[optional]|
**CurrentOffset** | **int?** |  |[optional]|
**TotalItemsCount** | **long?** | total number of uncrawlable resources found total number of uncrawlable resources found during the crawl of the target domain |[optional]|
**ItemsCount** | **long?** | number of uncrawlable resources in the items array |[optional]|
**Items** | **IEnumerable<OnPageUncrawlableResourcesItem>** | array of uncrawlable resources |[optional]|