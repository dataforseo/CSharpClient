# OnPageKeywordDensityResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | status of the crawling session<br>possible values: in_progress, finished |[optional]|
**CrawlStatus** | **CrawlStatusInfo** | details of the crawling session |[optional]|
**TotalItemsCount** | **long?** | total number of relevant items<br>total number of keywords on the specified website or web page matching the set keyword_length and filters |[optional]|
**ItemsCount** | **long?** | number of items in the results array |[optional]|
**Items** | **IEnumerable<OnPageKeywordDensityItem>** | items array |[optional]|