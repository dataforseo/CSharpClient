# OnPageMicrodataResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | status of the crawling session<br>possible values: in_progress, finished |[optional]|
**CrawlStatus** | **CrawlStatusInfo** | details of the crawling session |[optional]|
**TestSummary** | **TestSummary** | microdata validation test results |[optional]|
**ItemsCount** | **long?** | number of items in the results array |[optional]|
**Items** | **IEnumerable<OnPageMicrodataInfoItem>** | items array |[optional]|