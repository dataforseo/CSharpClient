# BacklinksDomainPagesLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**MainDomain** | **string** | main website domain<br>main website domain does not include subdomains |[optional]|
**Domain** | **string** | domain<br>domain where the page was found |[optional]|
**Tld** | **string** | top-level domain<br>top-level domain in the DNS root zone |[optional]|
**Page** | **string** | page URL<br>relevant page URL |[optional]|
**Ip** | **string** | Internet Protocol address |[optional]|
**FirstVisited** | **string** | date and time of the first page visit<br>date and time when our crawler visited this page for the first time<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2017-01-24 13:20:59 +00:00 |[optional]|
**PrevVisited** | **string** | previous to the most recent date when our crawler visited the page<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2017-01-24 13:20:59 +00:00 |[optional]|
**FetchTime** | **string** | most recent date and time when our crawler visited the page<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2017-01-24 13:20:59 +00:00 |[optional]|
**StatusCode** | **double?** | HTTP status code of the page |[optional]|
**Location** | **string** | location header<br>indicates the URL to redirect a page to if exists |[optional]|
**Size** | **double?** | indicates the page size, in bytes |[optional]|
**EncodedSize** | **double?** | page size after encoding<br>indicates the size of the encoded page, in bytes |[optional]|
**ContentEncoding** | **string** | type of encoding |[optional]|
**MediaType** | **string** | types of media used to display a page |[optional]|
**Server** | **string** | server version |[optional]|
**Meta** | **BacklinksPageMeta** | page meta data |[optional]|
**PageSummary** | **PageSummary** | contains backlink data for this page |[optional]|