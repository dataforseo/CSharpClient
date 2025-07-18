# BacklinksReferringNetworksLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**NetworkAddress** | **string** | address of the referring subnetwork or IP |[optional]|
**Rank** | **int?** | network rank<br>rank volume that a referring network passes to the target<br>rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in this help center article |[optional]|
**Backlinks** | **long?** | indicates the number of backlinks pointing to the target |[optional]|
**FirstSeen** | **string** | date and time when our crawler found the backlink for the first time<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**LostDate** | **string** | date and time when the last backlink from this domain was lost<br>indicates the date and time when our crawler visited the page and it responded with 4xx or 5xx status code or the last backlink was removed<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2017-01-24 13:20:59 +00:00 |[optional]|
**BrokenBacklinks** | **long?** | number of broken backlinks<br>number of broken backlinks pointing to the domain |[optional]|
**BrokenPages** | **int?** | number of broken pages<br>number of pages that respond with 4xx or 5xx status codes where backlinks are pointing to |[optional]|
**ReferringDomains** | **long?** | indicates the number of referring domains<br>referring domains include subdomains that are counted as separate domains for this metric |[optional]|
**ReferringDomainsNofollow** | **long?** | number of domains pointing at least one nofollow link to the target |[optional]|
**ReferringMainDomains** | **long?** | indicates the number of referring main domains |[optional]|
**ReferringMainDomainsNofollow** | **long?** | number of main domains pointing at least one nofollow link to the target |[optional]|
**ReferringIps** | **long?** | number of referring IP addresses<br>number of IP addresses pointing to this page |[optional]|
**ReferringSubnets** | **long?** | number of referring subnetworks |[optional]|
**ReferringPages** | **long?** | indicates the number of pages pointing to the target specified |[optional]|
**ReferringPagesNofollow** | **long?** | number of referring pages pointing at least one nofollow link to the target |[optional]|
**ReferringLinksTld** | **IDictionary<string, long?>** | top-level domains of the referring links<br>contains top level domains and referring link count per each |[optional]|
**ReferringLinksTypes** | **IDictionary<string, long?>** | types of referring links<br>indicates the types of the referring links and link count per each type<br>possible values:<br>anchor, image, link, meta, canonical, alternate, redirect |[optional]|
**ReferringLinksAttributes** | **IDictionary<string, long?>** | link attributes of the referring links<br>indicates link attributes of the referring links and link count per each attribute |[optional]|
**ReferringLinksPlatformTypes** | **IDictionary<string, long?>** | types of referring platforms<br>indicates referring platform types and and link count per each platform<br>possible values: cms, blogs, ecommerce, message-boards, wikis, news, organization |[optional]|
**ReferringLinksSemanticLocations** | **IDictionary<string, long?>** | semantic locations of the referring links<br>indicates semantic elements in HTML where the referring links are located and the link count per each semantic location<br>you can get the full list of semantic elements here<br>examples:<br>article, section, summary |[optional]|
**ReferringLinksCountries** | **IDictionary<string, long?>** | ISO country codes of the referring links<br>indicates ISO country codes of the domains where the referring links are located and the link count per each country |[optional]|