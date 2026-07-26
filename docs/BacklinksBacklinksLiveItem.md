# BacklinksBacklinksLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**DomainFrom** | **string** | <em>domain referring to the target domain or webpage</em> |[optional]|
**UrlFrom** | **string** | <em>URL of the page where the backlink is found</em> |[optional]|
**UrlFromHttps** | **bool?** | <em>indicates whether the referring URL is secured with HTTPS</em><br>if <code>true</code>, the referring URL is secured with HTTPS |[optional]|
**DomainTo** | **string** | <em>domain the backlink is pointing to</em> |[optional]|
**UrlTo** | **string** | <em>URL the backlink is pointing to</em> |[optional]|
**UrlToHttps** | **bool?** | <em>indicates if the URL the backlink is pointing to is secured with HTTPS</em><br>if <code>true</code>, the URL is secured with HTTPS |[optional]|
**TldFrom** | **string** | <em>top-level domain of the referring URL</em> |[optional]|
**IsNew** | **bool?** | <em>indicates whether the backlink is new</em><br>if <code>true</code>, the backlink was found on the page last time our crawler visited it |[optional]|
**IsLost** | **bool?** | <em>indicates whether the backlink was removed</em><br>if <code>true</code>, the backlink or the entire page was removed |[optional]|
**BacklinkSpamScore** | **int?** | <em>spam score of the backlink</em><br>learn more about how the metric is calculated on <a href='https://dataforseo.com/help-center/what-is-spam-score-and-how-is-it-calculated' rel='noopener noreferrer' target='_blank'>this help center page</a> |[optional]|
**Rank** | **int?** | <em>backlink rank</em><br>rank that the given backlink passes to the <code>target</code><br><code>rank</code> is calculated based on the method for node ranking in a linked database - a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in <a href='https://dataforseo.com/help-center/what_is_rank_in_backlinks_api' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**PageFromRank** | **int?** | <em>page rank of the referring page</em><br><code>page_from_rank</code> is calculated based on the method for node ranking in a linked database - a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in <a href='https://dataforseo.com/help-center/what_is_rank_in_backlinks_api' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**DomainFromRank** | **int?** | <em>domain rank of the referring domain</em><br><code>domain_from_rank</code> is calculated based on the method for node ranking in a linked database - a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in <a href='https://dataforseo.com/help-center/what_is_rank_in_backlinks_api' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**DomainFromPlatformType** | **IEnumerable<string>** | <em>platform types of the referring domain</em><p>possible values: <code>cms</code>, <code>blogs</code>, <code>ecommerce</code>, <code>message-boards</code>, <code>wikis</code>, <code>news</code>, <code>organization</code> |[optional]|
**DomainFromIsIp** | **bool?** | <em>indicates if the domain is IP</em><br>if <code>true</code>, the domain functions as an IP address and does not have a domain name |[optional]|
**DomainFromIp** | **string** | <em>IP address of the referring domain</em> |[optional]|
**DomainFromCountry** | **string** | <em>ISO country code of the referring domain</em> |[optional]|
**PageFromExternalLinks** | **int?** | <em>number of external links found on the referring page</em> |[optional]|
**PageFromInternalLinks** | **int?** | <em>number of internal links found on the referring page</em> |[optional]|
**PageFromSize** | **int?** | <em>size of the referring page, in bytes</em><br>example:<br><code>63357</code> |[optional]|
**PageFromEncoding** | **string** | <em>character encoding of the referring page</em><br>example:<br><code>utf-8</code> |[optional]|
**PageFromLanguage** | **string** | <em>language of the referring page</em><br>in ISO 639-1 format<br>example:<br><code>en</code> |[optional]|
**PageFromTitle** | **string** | <em>title of the referring page</em> |[optional]|
**PageFromStatusCode** | **int?** | <em>HTTP status code returned by the referring page</em><br>example:<br><code>200</code> |[optional]|
**FirstSeen** | **string** | <em>date and time when our crawler found the backlink for the first time</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**PrevSeen** | **string** | <em>previous to the most recent date when our crawler visited the backlink</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**LastSeen** | **string** | <em>most recent date when our crawler visited the backlink</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**ItemType** | **string** | <em>link type</em><br>possible values:<br><code>anchor</code>, <code>image</code>, <code>meta</code>, <code>canonical</code>, <code>alternate</code>, <code>redirect</code> |[optional]|
**Attributes** | **IEnumerable<string>** | <em>link attributes of the referring links</em><br>example:<br><code>nofollow</code> |[optional]|
**Dofollow** | **bool?** | <em>indicates whether the backlink is dofollow</em><br>if <code>false</code>, the backlink is nofollow |[optional]|
**Original** | **bool?** | <em>indicates whether the backlink was present on the referring page when our crawler first visited it</em> |[optional]|
**Alt** | **string** | <em>alternative text of the image</em><br>this field will be <code>null</code> if backlink <code>type</code> is not image |[optional]|
**ImageUrl** | **string** | <em>URL of the image</em><br>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available) |[optional]|
**Anchor** | **string** | <em>anchor text of the backlink</em> |[optional]|
**TextPre** | **string** | <em>snippet before the anchor text</em> |[optional]|
**TextPost** | **string** | <em>snippet after the anchor text</em> |[optional]|
**SemanticLocation** | **string** | <em>indicates semantic element in HTML where the backlink is found</em><br>you can get the full list of semantic elements <a href='https://www.w3schools.com/html/html5_semantic_elements.asp' target='_blank' rel='noopener noreferrer'>here</a><br>examples:<br><code>article</code>, <code>section</code>, <code>summary</code> |[optional]|
**LinksCount** | **long?** | <em>number of identical backlinks found on the referring page</em> |[optional]|
**GroupCount** | **long?** | <em>indicates total number of backlinks from this domain</em><br>for example, if <code>mode</code> is set to <code>one_per_domain</code>, this field will indicate the total number of backlinks coming from this domain |[optional]|
**IsBroken** | **bool?** | <em>indicates whether the backlink is broken</em><br>if <code>true</code>, the backlink is pointing to a page responding with a 4xx or 5xx status code |[optional]|
**UrlToStatusCode** | **int?** | <em>status code of the referenced page</em><br>if the value is <code>null</code>, our crawler hasn't yet visited the webpage the link is pointing to<br>example:<br><code>200</code> |[optional]|
**UrlToSpamScore** | **int?** | <em>spam score of the referenced page</em><br>if the value is <code>null</code>, our crawler hasn't yet visited the webpage the link is pointing to;<br>learn more about how the metric is calculated on <a href='https://dataforseo.com/help-center/what-is-spam-score-and-how-is-it-calculated' rel='noopener noreferrer' target='_blank'>this help center page</a> |[optional]|
**UrlToRedirectTarget** | **string** | <em>target url of the redirect</em><br>target page the redirect is pointing to |[optional]|
**RankedKeywordsInfo** | **RankedKeywordsInfo** |  |[optional]|
**IsIndirectLink** | **bool?** | <em>indicates whether the backlink is an indirect link</em><br>if <code>true</code>, the backlink is an indirect link pointing to a page that either redirects to <code>url_to</code>, or points to a canonical page |[optional]|
**IndirectLinkPath** | **IEnumerable<BacklinksRedirectInfo>** | <em>indirect link path</em><br>indicates a URL or a sequence of URLs that lead to <code>url_to</code> |[optional]|