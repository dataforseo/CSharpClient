# BacklinksBulkPagesSummaryLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Url** | **string** | <em>page URL</em> |[optional]|
**Rank** | **int?** | <em>page rank</em><br>rank of the page on the <code>target</code> website<br><code>rank</code> is calculated based on the method for node ranking in a linked database - a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in <a href='https://dataforseo.com/help-center/what_is_rank_in_backlinks_api' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**MainDomainRank** | **int?** | <em>rank of the main domain</em><br>rank of the main domain is calculated based on the method for node ranking in a linked database - a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in <a href='https://dataforseo.com/help-center/what_is_rank_in_backlinks_api' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**Backlinks** | **long?** | <em>number of backlinks</em> |[optional]|
**FirstSeen** | **string** | <em>date and time when our crawler found a backlink to this page for the first time</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**LostDate** | **string** | <em>date and time when the last backlink to this page was lost</em><br>indicates the date and time when our crawler visited the page and it responded with 4xx or 5xx status code or the last backlink was removed<br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code>2017-01-24 13:20:59 +00:00</code> |[optional]|
**BacklinksSpamScore** | **long?** | <em>average spam score of the backlinks pointing to the page</em><br>learn more about how the metric is calculated on <a href='https://dataforseo.com/help-center/what-is-spam-score-and-how-is-it-calculated' rel='noopener noreferrer' target='_blank'>this help center page</a> |[optional]|
**BrokenBacklinks** | **long?** | <em>number of broken backlinks</em><br>number of broken backlinks pointing to the page |[optional]|
**BrokenPages** | **int?** | <em>number of broken pages</em><br>number of pages that respond with 4xx or 5xx status codes where backlinks are pointing to |[optional]|
**ReferringDomains** | **long?** | <em>indicates the number domains referring to the page</em> |[optional]|
**ReferringDomainsNofollow** | **long?** | <em>number of domains pointing at least one nofollow link to the <code>target</code></em> |[optional]|
**ReferringMainDomains** | **long?** | <em>indicates the number of referring main domains</em> |[optional]|
**ReferringMainDomainsNofollow** | **long?** |  |[optional]|
**ReferringIps** | **long?** | <em>number of referring IP addresses</em><br>number of IP addresses pointing to this page |[optional]|
**ReferringSubnets** | **long?** | <em>number of referring subnetworks</em> |[optional]|
**ReferringPages** | **long?** | <em>indicates the number of pages pointing to the relevant <code>url</code></em> |[optional]|
**ReferringPagesNofollow** | **long?** | <em>number of referring pages pointing at least one nofollow link to the <code>target</code></em> |[optional]|
**ReferringLinksTld** | **IDictionary<string, long?>** | <em>top-level domains of the referring links</em><br>contains top level domains and referring link count per each |[optional]|
**ReferringLinksTypes** | **IDictionary<string, long?>** | <em>types of referring links</em><br>indicates the types of the referring links and link count per each type<br>possible values:<br><code>anchor</code>, <code>image</code>, <code>link</code>, <code>meta</code>, <code>canonical</code>, <code>alternate</code>, <code>redirect</code> |[optional]|
**ReferringLinksAttributes** | **IDictionary<string, long?>** | <em>link attributes of the referring links</em><br>indicates link attributes of the referring links and link count per each attribute |[optional]|
**ReferringLinksPlatformTypes** | **IDictionary<string, long?>** | <em>types of referring platforms</em><br>indicates referring platform types and and link count per each platform<p>possible values: <code>cms</code>, <code>blogs</code>, <code>ecommerce</code>, <code>message-boards</code>, <code>wikis</code>, <code>news</code>, <code>organization</code> |[optional]|
**ReferringLinksSemanticLocations** | **IDictionary<string, long?>** | <em>semantic locations of the referring links</em><br>indicates semantic elements in HTML where the referring links are located and link count per each semantic location<p>you can get the full list of semantic elements <a href='https://www.w3schools.com/html/html5_semantic_elements.asp' target='_blank' rel='noopener noreferrer'>here</a><br>examples:<br><code>article</code>, <code>section</code>, <code>footer</code> |[optional]|
**ReferringLinksCountries** | **IDictionary<string, long?>** | <em>ISO country codes of the referring links</em><br>indicates ISO country codes of the domains where the referring links are located and the link count per each country |[optional]|