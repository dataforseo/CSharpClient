# DataforseoLabsGoogleDomainWhoisOverviewLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Domain** | **string** | domain name |[optional]|
**CreatedDatetime** | **string** | date and time of registration<br>date and time (in the ISO 8601 format) when the domain was first registered<br>example:<br>'1997-03-29 03:00:00 +00:00' |[optional]|
**ChangedDatetime** | **string** | date and time when the domain entry was changed<br>date and time (in the ISO 8601 format) when the domain entry was last modified<br>example:<br>'2021-01-14 08:36:28 +00:00' |[optional]|
**ExpirationDatetime** | **string** | date and time when the domain will expire<br>date and time (in the ISO 8601 format) when the domain is due to expire<br>example:<br>'2022-11-26 17:21:23 +00:00' |[optional]|
**UpdatedDatetime** | **string** | date and time when the domain was updated<br>date and time (in the ISO 8601 format) when the domain was last updated<br>example:<br>'2021-01-29 13:59:38 +00:00' |[optional]|
**FirstSeen** | **string** | date and time when our crawler found the domain for the first time<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>'2019-11-15 12:57:46 +00:00' |[optional]|
**EppStatusCodes** | **IEnumerable<string>** | extensive provisioning protocol status codes<br>the status of a domain name registration as defined by ICANN |[optional]|
**Tld** | **string** | top-level domain<br>top-level domain in the DNS root zone |[optional]|
**Registered** | **bool?** | domain registration status<br>if false, the domain name registration has expired<br>Note: expired domains will remain in the database for only a short period of time |[optional]|
**Registrar** | **string** | domain registrar<br>if null, the domain registrar is unknown<br>example:<br>NameCheap, Inc. |[optional]|
**Metrics** | **IDictionary<string, DataforseoLabsMetricsInfo>** | ranking data relevant to the specified domain |[optional]|
**BacklinksInfo** | **BacklinksInfo** | backlink data for the returned domain |[optional]|