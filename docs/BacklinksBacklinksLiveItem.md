# BacklinksBacklinksLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**DomainFrom** | **string** | domain referring to the target domain or webpage |[optional]|
**UrlFrom** | **string** | URL of the page where the backlink is found |[optional]|
**UrlFromHttps** | **bool?** | indicates whether the referring URL is secured with HTTPS<br>if true, the referring URL is secured with HTTPS |[optional]|
**DomainTo** | **string** | domain the backlink is pointing to |[optional]|
**UrlTo** | **string** | URL the backlink is pointing to |[optional]|
**UrlToHttps** | **bool?** | indicates if the URL the backlink is pointing to is secured with HTTPS<br>if true, the URL is secured with HTTPS |[optional]|
**TldFrom** | **string** | top-level domain of the referring URL |[optional]|
**IsNew** | **bool?** | indicates whether the backlink is new<br>if true, the backlink was found on the page last time our crawler visited it |[optional]|
**IsLost** | **bool?** | indicates whether the backlink was removed<br>if true, the backlink or the entire page was removed |[optional]|
**BacklinkSpamScore** | **int?** | spam score of the backlink<br>learn more about how the metric is calculated on this help center page |[optional]|
**Rank** | **int?** | backlink rank<br>rank that the given backlink passes to the target<br>rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in this help center article |[optional]|
**PageFromRank** | **int?** | page rank of the referring page<br>page_from_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in this help center article |[optional]|
**DomainFromRank** | **int?** | domain rank of the referring domain<br>domain_from_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in this help center article |[optional]|
**DomainFromPlatformType** | **IEnumerable<string>** | platform types of the referring domain<br>possible values: cms, blogs, ecommerce, message-boards, wikis, news, organization |[optional]|
**DomainFromIsIp** | **bool?** | indicates if the domain is IP<br>if true, the domain functions as an IP address and does not have a domain name |[optional]|
**DomainFromIp** | **string** | IP address of the referring domain |[optional]|
**DomainFromCountry** | **string** | ISO country code of the referring domain |[optional]|
**PageFromExternalLinks** | **int?** | number of external links found on the referring page |[optional]|
**PageFromInternalLinks** | **int?** | number of internal links found on the referring page |[optional]|
**PageFromSize** | **int?** | size of the referring page, in bytes<br>example:<br>63357 |[optional]|
**PageFromEncoding** | **string** | character encoding of the referring page<br>example:<br>utf-8 |[optional]|
**PageFromLanguage** | **string** | language of the referring page<br>in ISO 639-1 format<br>example:<br>en |[optional]|
**PageFromTitle** | **string** | title of the referring page |[optional]|
**PageFromStatusCode** | **int?** | HTTP status code returned by the referring page<br>example:<br>200 |[optional]|
**FirstSeen** | **string** | date and time when our crawler found the backlink for the first time<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**PrevSeen** | **string** | previous to the most recent date when our crawler visited the backlink<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**LastSeen** | **string** | most recent date when our crawler visited the backlink<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**ItemType** | **string** | link type<br>possible values:<br>anchor, image, meta, canonical, alternate, redirect |[optional]|
**Attributes** | **IEnumerable<string>** | link attributes of the referring links<br>example:<br>nofollow |[optional]|
**Dofollow** | **bool?** | indicates whether the backlink is dofollow<br>if false, the backlink is nofollow |[optional]|
**Original** | **bool?** | indicates whether the backlink was present on the referring page when our crawler first visited it |[optional]|
**Alt** | **string** | alternative text of the image<br>this field will be null if backlink type is not image |[optional]|
**ImageUrl** | **string** | URL of the image<br>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available) |[optional]|
**Anchor** | **string** | anchor text of the backlink |[optional]|
**TextPre** | **string** | snippet before the anchor text |[optional]|
**TextPost** | **string** | snippet after the anchor text |[optional]|
**SemanticLocation** | **string** | indicates semantic element in HTML where the backlink is found<br>you can get the full list of semantic elements here<br>examples:<br>article, section, summary |[optional]|
**LinksCount** | **long?** | number of identical backlinks found on the referring page |[optional]|
**GroupCount** | **long?** | indicates total number of backlinks from this domain<br>for example, if mode is set to one_per_domain, this field will indicate the total number of backlinks coming from this domain |[optional]|
**IsBroken** | **bool?** | indicates whether the backlink is broken<br>if true, the backlink is pointing to a page responding with a 4xx or 5xx status code |[optional]|
**UrlToStatusCode** | **int?** | status code of the referenced page<br>if the value is null, our crawler hasn’t yet visited the webpage the link is pointing to<br>example:<br>200 |[optional]|
**UrlToSpamScore** | **int?** | spam score of the referenced page<br>if the value is null, our crawler hasn’t yet visited the webpage the link is pointing to;<br>learn more about how the metric is calculated on this help center page |[optional]|
**UrlToRedirectTarget** | **string** | target url of the redirect<br>target page the redirect is pointing to |[optional]|
**RankedKeywordsInfo** | **RankedKeywordsInfo** | number of keywords for which the page is ranked in top search results |[optional]|
**IsIndirectLink** | **bool?** | indicates whether the backlink is an indirect link<br>if true, the backlink is an indirect link pointing to a page that either redirects to url_to, or points to a canonical page |[optional]|
**IndirectLinkPath** | **IEnumerable<BacklinksRedirectInfo>** | indirect link path<br>indicates a URL or a sequence of URLs that lead to url_to |[optional]|