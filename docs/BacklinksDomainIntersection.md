# BacklinksDomainIntersection


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Target** | **string** | domain that links to the corresponding target from the POST array |[optional]|
**Rank** | **int?** | rank referred to the target from the POST array<br>indicates the rank that the referring domain (target above) refers to your target from the POST array;<br>rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in this help center article |[optional]|
**Backlinks** | **long?** | indicates the number of backlinks |[optional]|
**FirstSeen** | **string** | date and time when our crawler found the backlink from this target for the first time<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**LostDate** | **string** | date and time when the last backlink from this target was lost<br>indicates the date and time when our crawler visited the page and it responded with 4xx or 5xx status code or the last backlink was removed<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**BacklinksSpamScore** | **long?** | average spam score of the backlinks pointing to the target<br>learn more about how the metric is calculated on this help center page |[optional]|
**BrokenBacklinks** | **long?** | number of broken backlinks |[optional]|
**BrokenPages** | **int?** | number of broken pages |[optional]|
**ReferringDomains** | **long?** | number of referring domains |[optional]|
**ReferringDomainsNofollow** | **long?** | number of domains pointing at least one nofollow link to the corresponding target |[optional]|
**ReferringMainDomains** | **long?** | number of referring main domains |[optional]|
**ReferringMainDomainsNofollow** | **long?** | number of main domains pointing at least one nofollow link to the target |[optional]|
**ReferringIps** | **long?** | number of referring IP addresses |[optional]|
**ReferringSubnets** | **long?** | number of referring subnetworks |[optional]|
**ReferringPages** | **long?** | indicates the number of pages pointing to the target |[optional]|
**ReferringPagesNofollow** | **long?** | number of referring pages pointing at least one nofollow link to the target |[optional]|
**ReferringLinksTld** | **IDictionary<string, int?>** | top level domains of the referring links<br>contains top-level domains and referring link count per each |[optional]|
**ReferringLinksTypes** | **IDictionary<string, int?>** | types of the referring links<br>indicates the types of referring links and link count per each type<br>possible values:<br>anchor, image, link, meta, canonical, alternate, redirect |[optional]|
**ReferringLinksAttributes** | **IDictionary<string, int?>** | link attributes of the referring links<br>indicates link attributes of the referring links and the link count per each attribute |[optional]|
**ReferringLinksPlatformTypes** | **IDictionary<string, int?>** | types of referring platforms<br>indicates referring platform types and link count per each platform<br>possible values: cms, blogs, ecommerce, message-boards, wikis, news, organization |[optional]|
**ReferringLinksSemanticLocations** | **IDictionary<string, int?>** | semantic locations of the referring links<br>indicates semantic elements in HTML where the referring links are located and the link count per each semantic location<br>you can get the full list of semantic elements here |[optional]|
**ReferringLinksCountries** | **object** | ISO country codes of the referring links<br>indicates ISO country codes of the domains where the referring links are located and the link count per each country |[optional]|