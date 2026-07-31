# TargetInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Server** | **string** | <em>server</em> |[optional]|
**Cms** | **string** | <em>content management system</em> |[optional]|
**PlatformType** | **IEnumerable<string>** | <em>platform type</em> |[optional]|
**IpAddress** | **string** | <em>IP address of the <code>target</code></em> |[optional]|
**Country** | **string** | <em>country code that the <code>target</code> domain is determined to belong to</em> |[optional]|
**IsIp** | **bool?** | <em>indicates if the <code>target</code> is IP</em><br>if <code>true</code>, the domain, subdomain or webpage functions as an IP address and does not have a domain name |[optional]|
**TargetSpamScore** | **int?** | <em>spam score of the <code>target</code></em><br>if the <code>target</code> is a domain/subdomain, this fields indicates the average spam score of all pages of that domain/subdomain;<br>learn more about how the metric is calculated on <a href='https://dataforseo.com/help-center/what-is-spam-score-and-how-is-it-calculated' rel='noopener noreferrer' target='_blank'>this help center page</a> |[optional]|