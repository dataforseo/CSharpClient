# BacklinksHistoryLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Date** | **string** | date and time when the data for the target was stored<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Rank** | **double?** | domain rank on the given date<br>learn more about the metric and how it is calculated in this help center article |[optional]|
**Backlinks** | **double?** | number of backlinks |[optional]|
**NewBacklinks** | **double?** | number of new backlinks for the target<br>data is provided based in a comparison with the previous period<br>Note: this data is available from May 2021;<br>if the date range specified in the POST request precedes May 2021, the field will equal 0 |[optional]|
**LostBacklinks** | **double?** | number of lost backlinks for the target<br>data is provided based in a comparison with the previous period<br>Note: this data is available from May 2021;<br>if the date range specified in the POST request precedes May 2021, the field will equal 0 |[optional]|
**NewReferringDomains** | **double?** | number of new referring domains for the target<br>data is provided based in a comparison with the previous period<br>Note: this data is available from May 2021;<br>if the date range specified in the POST request precedes May 2021, the field will equal 0 |[optional]|
**LostReferringDomains** | **double?** | number of lost referring domains for the target<br>data is provided based in a comparison with the previous period<br>Note: this data is available from May 2021;<br>if the date range specified in the POST request precedes May 2021, the field will equal 0 |[optional]|
**CrawledPages** | **double?** | number of crawled pages for the target |[optional]|
**Info** | **TargetInfo** | information about the target |[optional]|
**InternalLinksCount** | **double?** | number of internal links<br>calculated as the sum of internal links on the pages of the specified target |[optional]|
**ExternalLinksCount** | **double?** | number of external links on the page<br>calculated as the sum of external links on the pages of the specified target |[optional]|
**BrokenBacklinks** | **double?** | number of broken backlinks<br>number of broken backlinks pointing to the target |[optional]|
**BrokenPages** | **double?** | number of broken pages<br>number of pages that receive backlinks but respond with 4xx or 5xx status codes |[optional]|
**ReferringDomains** | **double?** | number of referring domains<br>referring domains include subdomains that are counted as separate domains for this metric |[optional]|
**ReferringDomainsNofollow** | **double?** | number of domains pointing at least one nofollow link to the target |[optional]|
**ReferringMainDomains** | **double?** | number of referring main domains |[optional]|
**ReferringMainDomainsNofollow** | **long?** | number of main domains pointing at least one nofollow link to the target |[optional]|
**ReferringIps** | **double?** | number of referring IP addresses<br>number of IP addresses pointing to this page |[optional]|
**ReferringSubnets** | **double?** | number of referring subnetworks |[optional]|
**ReferringPages** | **double?** | number of pages pointing to the target |[optional]|
**ReferringPagesNofollow** | **double?** | number of referring pages pointing at least one nofollow link to the target |[optional]|
**ReferringLinksTld** | **IDictionary<string, long?>** | top-level domains of the referring links<br>contains top-level domains and referring link count per each |[optional]|
**ReferringLinksTypes** | **IDictionary<string, long?>** | types of referring links<br>indicates the types of the referring links and link count per each type<br>possible values:<br>anchor, image, link, meta, canonical, alternate, redirect |[optional]|
**ReferringLinksAttributes** | **IDictionary<string, long?>** | link attributes of the referring links<br>indicates link attributes of the referring links and link count per each attribute |[optional]|
**ReferringLinksPlatformTypes** | **IDictionary<string, long?>** | types of referring platforms<br>indicates referring platform types and and link count per each platform<br>possible values: cms, blogs, ecommerce, message-boards, wikis, news, organization |[optional]|
**ReferringLinksSemanticLocations** | **IDictionary<string, long?>** | semantic locations of the referring links<br>indicates semantic elements in HTML where the referring links are located and link count per each semantic location<br>you can get the full list of semantic elements here<br>examples:<br>article, section, summary |[optional]|
**ReferringLinksCountries** | **IDictionary<string, long?>** | ISO country codes of the referring links<br>indicates ISO country codes of the domains where the referring links are located and the link count per each country |[optional]|