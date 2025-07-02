# BaseOnPageResourceItemInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ResourceType** | **string** | type of the returned resource |[optional]|
**StatusCode** | **int?** | status code of the page |[optional]|
**Location** | **string** | location header<br>indicates the URL to redirect a page to |[optional]|
**Url** | **string** | page URL |[optional]|
**ResourceErrors** | **OnPageResourceIssueInfo** | resource errors and warnings |[optional]|
**Size** | **int?** | resource size<br>indicates the size of a given page measured in bytes |[optional]|
**EncodedSize** | **int?** | page size after encoding<br>indicates the size of the encoded page measured in bytes |[optional]|
**TotalTransferSize** | **long?** | compressed page size<br>indicates the compressed size of a given page |[optional]|
**FetchTime** | **string** | date and time when a resource was fetched<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**CacheControl** | **CacheControl** | instructions for caching |[optional]|
**Checks** | **IDictionary<string, bool?>** | website checks<br>on-page check-ups related to the page |[optional]|
**ContentEncoding** | **string** | type of encoding |[optional]|
**MediaType** | **string** | types of media used to display a page |[optional]|
**Server** | **string** | server version |[optional]|
**LastModified** | **LastModified** | contains data on changes related to the resource<br>if there is no data, the value will be null |[optional]|