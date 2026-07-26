# OnPageUncrawlableResourcesResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | <em>status of the crawling session</em><br>possible values: <code>in_progress</code>, <code>finished</code> |[optional]|
**CrawlStatus** | **CrawlStatusInfo** | <em>details of the crawling session</em> |[optional]|
**CurrentOffset** | **int?** |  |[optional]|
**TotalItemsCount** | **long?** | <em>total number of uncrawlable resources found</em><br> total number of uncrawlable resources found during the crawl of the target domain |[optional]|
**ItemsCount** | **long?** | <em>number of uncrawlable resources in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<OnPageUncrawlableResourcesItem>** | <em>array of uncrawlable resources</em> |[optional]|