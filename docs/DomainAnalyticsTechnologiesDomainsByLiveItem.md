# DomainAnalyticsTechnologiesDomainsByLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Domain** | **string** | specified domain name |[optional]|
**Title** | **string** | domain meta title |[optional]|
**Description** | **string** | domain meta description |[optional]|
**MetaKeywords** | **IEnumerable<string>** | domain meta keywords |[optional]|
**DomainRank** | **string** | backlink rank of the target domain<br>learn more about the metric and how it is calculated in this help center article |[optional]|
**LastVisited** | **string** | most recent date when our crawler visited the domain<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2022-10-10 12:57:46 +00:00 |[optional]|
**CountryIsoCode** | **string** | domain ISO code<br>ISO code of the country that target domain is determined to belong to |[optional]|
**LanguageCode** | **string** | domain language<br>code of the language that target domain is determined to be associated with |[optional]|
**ContentLanguageCode** | **string** | content language<br>code of the language that content on the target domain is written with |[optional]|
**PhoneNumbers** | **IEnumerable<string>** | phone numbers of the target<br>contact phone numbers indicated on the target website |[optional]|
**Emails** | **IEnumerable<string>** | emails of the target<br>emails indicated on the target website |[optional]|
**SocialGraphUrls** | **IEnumerable<string>** | social media links and handles<br>social media URLs detected in the social graphs of the target website |[optional]|
**Technologies** | **TechnologiesInfo** | technologies used by target domain<br>contains objects with the names of technologies used on the website;<br>to get a full list of technologies and their structure, refer to the technologies endpoint |[optional]|