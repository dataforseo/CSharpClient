# BacklinksTimeseriesSummaryLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Date** | **string** | <em>date and time when the data for the target was stored</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Rank** | **int?** | <em><code>target</code> rank for the given <code>date</code></em><br>learn more about the metric and how it is calculated in <a href='https://dataforseo.com/help-center/what_is_rank_in_backlinks_api' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**Backlinks** | **long?** | <em>number of backlinks for the given <code>date</code></em> |[optional]|
**BacklinksNofollow** | **long?** | <em>number of nofollow backlinks for the given <code>date</code></em> |[optional]|
**ReferringPages** | **long?** | <em>number of pages pointing to <code>target</code> for the given <code>date</code></em> |[optional]|
**ReferringPagesNofollow** | **long?** | <em>number of referring pages pointing at least one nofollow link to the <code>target</code> for the given <code>date</code></em> |[optional]|
**ReferringDomains** | **long?** | <em>number of referring domains for the given <code>date</code></em><br>referring domains include subdomains that are counted as separate domains for this metric |[optional]|
**ReferringDomainsNofollow** | **long?** | <em>number of domains pointing at least one nofollow link to the <code>target</code> for the given <code>date</code></em> |[optional]|
**ReferringMainDomains** | **long?** | <em>number of referring main domains for the given <code>date</code></em> |[optional]|
**ReferringMainDomainsNofollow** | **long?** | <em>number of main domains pointing at least one nofollow link to the <code>target</code> for the given <code>date</code></em> |[optional]|
**ReferringIps** | **long?** | <em>number of referring IP addresses for the given <code>date</code></em><br>number of IP addresses pointing to this page |[optional]|
**ReferringSubnets** | **long?** | <em>number of referring subnetworks for the given <code>date</code></em> |[optional]|