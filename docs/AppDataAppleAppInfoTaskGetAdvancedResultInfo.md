# AppDataAppleAppInfoTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AppId** | **string** | application id received in a POST request |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**SeResultsCount** | **long?** | the total number of results |[optional]|
**ItemsCount** | **long?** | the number of items in the results array |[optional]|
**Items** | **IEnumerable<AppStoreInfoOrganic>** | found app info |[optional]|