# OnPageMicrodataResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | status of the crawling session<br>possible values: in_progress, finished |[optional]|
**CrawlStatus** | **CrawlStatus** | details of the crawling session |[optional]|
**TestSummary** | **TestSummary** | microdata validation test results |[optional]|
**ItemsCount** | **double?** | number of items in the results array |[optional]|
**Items** | **IEnumerable<OnPageMicrodataItem>** | items array |[optional]|