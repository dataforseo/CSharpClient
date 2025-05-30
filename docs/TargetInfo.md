# TargetInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Server** | **string** | server |[optional]|
**Cms** | **string** | content management system |[optional]|
**PlatformType** | **IEnumerable<string>** | platform type |[optional]|
**IpAddress** | **string** | IP address of the target |[optional]|
**Country** | **string** | country code that the target domain is determined to belong to |[optional]|
**IsIp** | **bool?** | indicates if the target is IP<br>if true, the domain, subdomain or webpage functions as an IP address and does not have a domain name |[optional]|
**TargetSpamScore** | **double?** | spam score of the target<br>if the target is a domain/subdomain, this fields indicates the average spam score of all pages of that domain/subdomain;<br>learn more about how the metric is calculated on this help center page |[optional]|