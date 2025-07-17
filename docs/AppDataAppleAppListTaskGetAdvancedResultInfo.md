# AppDataAppleAppListTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | app collection received in a POST array |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>in this case, the value will be null |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**SeResultsCount** | **long?** | the total number of results |[optional]|
**ItemsCount** | **long?** | the number of app items in the results array<br>you can get more results by using the depth parameter when setting a task |[optional]|
**Items** | **IEnumerable<AppStoreSearchOrganic>** | found apps<br>you can get more results by using the depth parameter when setting a task |[optional]|