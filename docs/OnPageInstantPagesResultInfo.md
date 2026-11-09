# OnPageInstantPagesResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | status of the crawling sessionpossible values: in_progress, finished |[optional]|
**CrawlStatus** | **object** | details of the crawling sessionin this case the value will be null |[optional]|
**CrawlGatewayAddress** | **string** | crawler ip addressdisplays the IP address used by the crawler to initiate the current crawling sessionyou can find the full list of IPs used by our crawler in the Overview section |[optional]|
**ItemsCount** | **long?** | number of items in the results array |[optional]|
**Items** | **IEnumerable<OnPageHtmlResourceItem>** | items array |[optional]|