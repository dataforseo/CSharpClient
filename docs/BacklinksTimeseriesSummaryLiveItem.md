# BacklinksTimeseriesSummaryLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Date** | **string** | date and time when the data for the target was stored<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Rank** | **double?** | target rank for the given date<br>learn more about the metric and how it is calculated in this help center article |[optional]|
**Backlinks** | **double?** | number of backlinks for the given date |[optional]|
**BacklinksNofollow** | **double?** | number of nofollow backlinks for the given date |[optional]|
**ReferringPages** | **double?** | number of pages pointing to target for the given date |[optional]|
**ReferringPagesNofollow** | **double?** | number of referring pages pointing at least one nofollow link to the target for the given date |[optional]|
**ReferringDomains** | **double?** | number of referring domains for the given date<br>referring domains include subdomains that are counted as separate domains for this metric |[optional]|
**ReferringDomainsNofollow** | **double?** | number of domains pointing at least one nofollow link to the target for the given date |[optional]|
**ReferringMainDomains** | **double?** | number of referring main domains for the given date |[optional]|
**ReferringMainDomainsNofollow** | **double?** | number of main domains pointing at least one nofollow link to the target for the given date |[optional]|
**ReferringIps** | **double?** | number of referring IP addresses for the given date<br>number of IP addresses pointing to this page |[optional]|
**ReferringSubnets** | **double?** | number of referring subnetworks for the given date |[optional]|