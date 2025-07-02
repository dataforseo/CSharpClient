# BusinessDataTrustpilotSearchTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword in a POST array |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**ItemsCount** | **long?** | the number of items in the results array<br>you can get more results by using the depth parameter when setting a task |[optional]|
**Items** | **IEnumerable<BaseBusinessDataSerpElementItem>** | found reviews<br>you can get more results by using the depth parameter when setting a task |[optional]|