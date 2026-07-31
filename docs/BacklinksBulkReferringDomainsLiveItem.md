# BacklinksBulkReferringDomainsLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Target** | **string** | <em>domain, subdomain or webpage from a POST array</em> |[optional]|
**ReferringDomains** | **long?** | <em>number of referring domains pointing to the <code>target</code></em><br>note that we calculate main domains (root domains, like <code>example.com</code>) and their subdomains (e.g. <code>blog.example.com</code>) separately for this metric |[optional]|
**ReferringDomainsNofollow** | **long?** | <em>number of domains pointing at least one nofollow link to the <code>target</code></em> |[optional]|
**ReferringMainDomains** | **long?** | <em>number of referring main domains pointing to the <code>target</code></em><br>the number of primary (root) domains referring to your target |[optional]|
**ReferringMainDomainsNofollow** | **long?** | <em>number of main domains pointing at least one nofollow link to the <code>target</code></em> |[optional]|