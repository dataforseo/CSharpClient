# BacklinksDomainIntersection


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Target** | **string** | <em>domain that links to the corresponding target from the POST array</em> |[optional]|
**Rank** | **int?** | <em>rank referred to the <code>target</code> from the POST array</em><br>indicates the rank that the referring domain (<code>target</code> above) refers to your target from the POST array;<br><code>rank</code> is calculated based on the method for node ranking in a linked database - a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in <a href='https://dataforseo.com/help-center/what_is_rank_in_backlinks_api' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**Backlinks** | **long?** | <em>indicates the number of backlinks</em> |[optional]|
**FirstSeen** | **string** | <em>date and time when our crawler found the backlink from this <code>target</code> for the first time</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**LostDate** | **string** | <em>date and time when the last backlink from this <code>target</code> was lost</em><br>indicates the date and time when our crawler visited the page and it responded with 4xx or 5xx status code or the last backlink was removed<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**BacklinksSpamScore** | **long?** | <em>average spam score of the backlinks pointing to the <code>target</code></em><br>learn more about how the metric is calculated on <a href='https://dataforseo.com/help-center/what-is-spam-score-and-how-is-it-calculated' rel='noopener noreferrer' target='_blank'>this help center page</a> |[optional]|
**BrokenBacklinks** | **long?** | <em>number of broken backlinks</em> |[optional]|
**BrokenPages** | **int?** | <em>number of broken pages</em> |[optional]|
**ReferringDomains** | **long?** | <em>number of referring domains</em> |[optional]|
**ReferringDomainsNofollow** | **long?** | <em>number of domains pointing at least one nofollow link to the corresponding target</em> |[optional]|
**ReferringMainDomains** | **long?** | <em>number of referring main domains</em> |[optional]|
**ReferringMainDomainsNofollow** | **long?** | <em>number of main domains pointing at least one nofollow link to the <code>target</code></em> |[optional]|
**ReferringIps** | **long?** | <em>number of referring IP addresses</em> |[optional]|
**ReferringSubnets** | **long?** | <em>number of referring subnetworks</em> |[optional]|
**ReferringPages** | **long?** | <em>indicates the number of pages pointing to the <code>target</code></em> |[optional]|
**ReferringPagesNofollow** | **long?** | <em>number of referring pages pointing at least one nofollow link to the <code>target</code></em> |[optional]|
**ReferringLinksTld** | **IDictionary<string, int?>** | <em>top level domains of the referring links</em><br>contains top-level domains and referring link count per each |[optional]|
**ReferringLinksTypes** | **IDictionary<string, int?>** | <em>types of the referring links</em><br>indicates the types of referring links and link count per each type<br>possible values:<br><code>anchor</code>, <code>image</code>, <code>link</code>, <code>meta</code>, <code>canonical</code>, <code>alternate</code>, <code>redirect</code> |[optional]|
**ReferringLinksAttributes** | **IDictionary<string, int?>** | <em>link attributes of the referring links</em><br>indicates link attributes of the referring links and the link count per each attribute |[optional]|
**ReferringLinksPlatformTypes** | **IDictionary<string, int?>** | <em>types of referring platforms</em><br>indicates referring platform types and link count per each platform<p>possible values: <code>cms</code>, <code>blogs</code>, <code>ecommerce</code>, <code>message-boards</code>, <code>wikis</code>, <code>news</code>, <code>organization</code> |[optional]|
**ReferringLinksSemanticLocations** | **IDictionary<string, int?>** | <em>semantic locations of the referring links</em><br>indicates semantic elements in HTML where the referring links are located and the link count per each semantic location<br>you can get the full list of semantic elements <a href='https://www.w3schools.com/html/html5_semantic_elements.asp' rel='noopener noreferrer' target='_blank'>here</a> |[optional]|
**ReferringLinksCountries** | **object** | <em>ISO country codes of the referring links</em><br>indicates ISO country codes of the domains where the referring links are located and the link count per each country |[optional]|