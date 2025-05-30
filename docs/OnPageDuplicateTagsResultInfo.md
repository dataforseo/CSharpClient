# OnPageDuplicateTagsResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | status of the crawling session<br>possible values: in_progress, finished |[optional]|
**CrawlStatus** | **CrawlStatus** | details of the crawling session |[optional]|
**TotalPagesCount** | **double?** | total number of pages with duplicate tags<br>displays the total number of pages with duplicate tags of the target website |[optional]|
**PagesCount** | **double?** | number of pages with duplicate tags in the response<br>displays the number of pages with duplicate tags returned in the response |[optional]|
**ItemsCount** | **double?** | number of items in the results array |[optional]|
**Items** | **IEnumerable<OnPageDuplicateTagsItem>** | items array |[optional]|