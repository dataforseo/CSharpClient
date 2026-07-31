# AppDataAppleAppInfoTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AppId** | **string** | <em>application id received in a POST request</em> |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**SeResultsCount** | **long?** | <em>the total number of results</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of items in the results array</em> |[optional]|
**Items** | **IEnumerable<AppStoreInfoOrganic>** | <em>found app info</em> |[optional]|