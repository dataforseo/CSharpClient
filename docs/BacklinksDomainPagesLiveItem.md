# BacklinksDomainPagesLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**MainDomain** | **string** | <em>main website domain</em><br>main website domain does not include subdomains |[optional]|
**Domain** | **string** | <em>domain</em><br>domain where the page was found |[optional]|
**Tld** | **string** | <em>top-level domain</em><br>top-level domain in the <a href='https://www.iana.org/domains/root/db' rel='noopener noreferrer' target='_blank'>DNS root zone</a> |[optional]|
**Page** | **string** | <em>page URL</em><br>relevant page URL |[optional]|
**Ip** | **string** | <em>Internet Protocol address</em> |[optional]|
**FirstVisited** | **string** | <em>date and time of the first page visit</em><br>date and time when our crawler visited this page for the first time<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2017-01-24 13:20:59 +00:00</code> |[optional]|
**PrevVisited** | **string** | <em>previous to the most recent date when our crawler visited the page</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2017-01-24 13:20:59 +00:00</code> |[optional]|
**FetchTime** | **string** | <em>most recent date and time when our crawler visited the page</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2017-01-24 13:20:59 +00:00</code> |[optional]|
**StatusCode** | **int?** | <i>general status code</i><br>you can find the full list of the response codes <a href='/v3/appendix/errors'>here</a><br><strong>Note:</strong> we strongly recommend designing a necessary system for handling related exceptional or error conditions |[optional]|
**Location** | **string** | <em>location header</em><br>indicates the URL to redirect a page to if exists |[optional]|
**Size** | **int?** | <em>indicates the page size, in bytes</em> |[optional]|
**EncodedSize** | **int?** | <em>page size after encoding</em><br>indicates the size of the encoded page, in bytes |[optional]|
**ContentEncoding** | **string** | <em>type of encoding</em> |[optional]|
**MediaType** | **string** | <em>types of media used to display a page</em> |[optional]|
**Server** | **string** | <em>server version</em> |[optional]|
**Meta** | **BacklinksPageMeta** | <em>page meta data</em> |[optional]|
**PageSummary** | **PageSummary** | <em>contains backlink data for this page</em> |[optional]|