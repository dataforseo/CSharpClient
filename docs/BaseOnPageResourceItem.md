# BaseOnPageResourceItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ResourceType** | **string** | type of element |[optional]|
**StatusCode** | **int?** | general status codeyou can find the full list of the response codes hereNote: we strongly recommend designing a necessary system for handling related exceptional or error conditions |[optional]|
**Location** | **string** | location headerindicates the URL to redirect a page to |[optional]|
**Url** | **string** | page URL |[optional]|
**ResourceErrors** | **OnPageResourceIssueInfo** | resource errors and warnings |[optional]|
**Size** | **int?** | resource sizeindicates the size of a given page measured in bytes |[optional]|
**EncodedSize** | **int?** | page size after encodingindicates the size of the encoded page measured in bytes |[optional]|
**TotalTransferSize** | **long?** | compressed page sizeindicates the compressed size of a given page |[optional]|
**FetchTime** | **string** | date and time when a resource was fetchedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00 |[optional]|
**CacheControl** | **CacheControl** | instructions for caching |[optional]|
**Checks** | **IDictionary<string, bool?>** | website checkson-page check-ups related to the page |[optional]|
**ContentEncoding** | **string** | type of encoding |[optional]|
**MediaType** | **string** | types of media used to display a page |[optional]|
**Server** | **string** | server version |[optional]|
**LastModified** | **LastModified** | contains data on changes related to the resourceif there is no data, the value will be null |[optional]|