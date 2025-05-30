# BacklinksSummaryLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Target** | **string** | target in a POST array |[optional]|
**FirstSeen** | **string** | date and time when our crawler found the backlink for the target for the first time<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**LostDate** | **string** | date and time when the backlink was lost<br>indicates the date and time when our crawler visited the target and it responded with a 4xx or 5xx status code or when its last backlink was removed<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Rank** | **double?** | target rank<br>learn more about the metric and how it is calculated in this help center article |[optional]|
**Backlinks** | **double?** | indicates the number of backlinks |[optional]|
**BacklinksSpamScore** | **double?** | spam score of the backlinks<br>displays the total spam score of all backlinks pointing to the target domain, subdomain, or webpage;<br>to learn more about how the metric is calculated, refer to this Help Center page |[optional]|
**CrawledPages** | **double?** | number of crawled pages for the target |[optional]|
**Info** | **TargetInfo** | information about the target |[optional]|
**InternalLinksCount** | **double?** | number of internal links<br>calculated as the sum of internal links on the pages of the specified target |[optional]|
**ExternalLinksCount** | **double?** | number of external links on the page<br>calculated as the sum of external links on the pages of the specified target |[optional]|
**BrokenBacklinks** | **double?** | number of broken backlinks<br>number of broken backlinks pointing to the target |[optional]|
**BrokenPages** | **double?** | number of broken pages<br>number of pages on the target that respond with 4xx or 5xx status codes<br>note that the number of broken pages includes pages on the target discovered by following external links, but it may also include pages discovered by following the target’s sitemap |[optional]|
**ReferringDomains** | **double?** | indicates the number of referring domains<br>referring domains include subdomains that are counted as separate domains for this metric |[optional]|
**ReferringDomainsNofollow** | **double?** | number of domains pointing at least one nofollow link to the target |[optional]|
**ReferringMainDomains** | **double?** | indicates the number of referring main domains |[optional]|
**ReferringMainDomainsNofollow** | **long?** | number of main domains pointing at least one nofollow link to the target |[optional]|
**ReferringIps** | **double?** | number of referring IP addresses<br>number of IP addresses pointing to this page |[optional]|
**ReferringSubnets** | **double?** | number of referring subnetworks |[optional]|
**ReferringPages** | **double?** | indicates the number of pages pointing to the target |[optional]|
**ReferringPagesNofollow** | **double?** | number of referring pages pointing at least one nofollow link to the target |[optional]|
**ReferringLinksTld** | **IDictionary<string, long?>** | top-level domains of the referring links<br>contains top level domains and referring link count per each |[optional]|
**ReferringLinksTypes** | **IDictionary<string, long?>** | types of referring links<br>indicates the types of the referring links and link count per each type<br>possible values:<br>anchor, image, link, meta, canonical, alternate, redirect |[optional]|
**ReferringLinksAttributes** | **IDictionary<string, long?>** | link attributes of the referring links<br>indicates link attributes of the referring links and link count per each attribute<br>example values:<br>nofollow, noopener, noreferrer, external, ugc, sponsored |[optional]|
**ReferringLinksPlatformTypes** | **IDictionary<string, long?>** | types of referring platforms<br>indicates referring platform types and and link count per each platform<br>possible values: cms, blogs, ecommerce, message-boards, wikis, news, organization |[optional]|
**ReferringLinksSemanticLocations** | **IDictionary<string, long?>** | semantic locations of the referring links<br>indicates semantic elements in HTML where the referring links are located and link count per each semantic location<br>you can get the full list of semantic elements here<br>example values:<br>article, section, summary, '' |[optional]|
**ReferringLinksCountries** | **IDictionary<string, long?>** | ISO country codes of the referring links<br>indicates ISO country codes of the domains where the referring links are located and the link count per each country |[optional]|