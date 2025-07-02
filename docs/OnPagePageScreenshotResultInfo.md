# OnPagePageScreenshotResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | status of the crawling session<br>possible values: in_progress, finished |[optional]|
**ErrorMessage** | **string** | error message<br>if the url you indicated returns a 404 status code or is not a valid URL, you will obtain 'error_message':'Screenshot is empty'<br>if no error is encountered, the value will be null |[optional]|
**ItemsCount** | **long?** | number of items in the results array |[optional]|
**Items** | **IEnumerable<ScreenshotItem>** | items array |[optional]|