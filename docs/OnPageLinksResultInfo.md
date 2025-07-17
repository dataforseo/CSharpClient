# OnPageLinksResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | status of the crawling session<br>possible values: in_progress, finished |[optional]|
**CrawlStatus** | **CrawlStatusInfo** | details of the crawling session |[optional]|
**SearchAfterToken** | **string** |  |[optional]|
**CurrentOffset** | **int?** |  |[optional]|
**TotalItemsCount** | **long?** | total number of relevant items in the database |[optional]|
**ItemsCount** | **long?** | number of items in the results array |[optional]|
**Items** | **IEnumerable<BaseOnPageLinkItem>** | items array |[optional]|