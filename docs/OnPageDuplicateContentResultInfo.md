# OnPageDuplicateContentResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | <em>status of the crawling session</em><br>possible values: <code>in_progress</code>, <code>finished</code> |[optional]|
**CrawlStatus** | **CrawlStatusInfo** | <em>details of the crawling session</em> |[optional]|
**ItemsCount** | **long?** | <em>number of items in the results array</em> |[optional]|
**Items** | **IEnumerable<OnPageDuplicateContentItem>** | <em>items array</em> |[optional]|