# DomainInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Name** | **string** | domain name |[optional]|
**Cms** | **string** | content management system<br>content management system identified on a website<br>the content of the generator meta tag<br>the data is taken from the first random page that returns the 200 response code<br>if our crawler was unable to identify the cms, the value would be null |[optional]|
**Ip** | **string** | domain ip address |[optional]|
**Server** | **string** | website server<br>the version of the server detected on a website<br>the content of the server header<br>the information is taken from the first page which response code is 200 |[optional]|
**CrawlStart** | **string** | time when the crawling start<br>date and time when the website was sent for crawling<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**CrawlEnd** | **string** | time when the crawling ended<br>date and time when the crawling was finished<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00<br>Note: informative only if 'crawl_progress' is 'finished'<br>if 'crawl_progress' is in_progress, the value will be null |[optional]|
**ExtendedCrawlStatus** | **string** | crawl status and errors<br>indicates the reason why a website was not crawled;<br>can take the following values:<br>no_errors – no crawling errors were detected;<br>site_unreachable – our crawler could not reach a website and thus was not able to obtain a status code;<br>invalid_page_status_code – status code of the first crawled page >= 400;<br>forbidden_meta_tag – the first crawled page contains the <meta robots=”noindex”> tag;<br>forbidden_robots – robots.txt forbids crawling the page;<br>forbidden_http_header – HTTP header of the page contains “X-Robots-Tag: noindex” ;<br>too_many_redirects – the first crawled page has more than 10 redirects;<br>unknown – the reason is unknown |[optional]|
**SslInfo** | **SslInfo** | ssl certificate info<br>information about the Secure Sockets Layer protocol detected on a website |[optional]|
**Checks** | **IDictionary<string, bool?>** | website checks<br>other on-page check-ups related to the website |[optional]|
**TotalPages** | **long?** | total crawled pages<br>the total number of crawled pages |[optional]|
**PageNotFoundStatusCode** | **int?** | status code returned by a non-existent page<br>in most cases, it is recommended a server returns a 404 response code |[optional]|
**CanonicalizationStatusCode** | **int?** | status code returned by a canonicalized page<br>the checkup of the server behavior when our crawler tries to access the website via IP;<br>in most cases, it is recommended that canonicalized pages respond with a 301 or 302 status code |[optional]|
**DirectoryBrowsingStatusCode** | **int?** | status code returned by a directory<br>the status code returned by a directory page on a target website<br>in most cases, it is recommended that directories respond with a 403 or 401 status code |[optional]|
**WwwRedirectStatusCode** | **int?** | redirect status code<br>the status code of the www to non-www redirect<br>in most cases, it is recommended that redirect returns a 301 status code |[optional]|
**MainDomain** | **string** | root domain name |[optional]|