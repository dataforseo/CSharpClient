# AppDataGoogleAppReviewsTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AppId** | **string** | application id received in a POST array |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Title** | **string** | title of the app<br>title of the application for which the reviews are collected |[optional]|
**Rating** | **RatingInfo** | rating of the app<br>rating of the application for which the reviews are collected |[optional]|
**ReviewsCount** | **long?** | the total number of reviews |[optional]|
**ItemsCount** | **long?** | the number of reviews items in the results array<br>you can get more results by using the depth parameter when setting a task |[optional]|
**Items** | **IEnumerable<BaseAppDataSerpElementItem>** | found reviews<br>you can get more results by using the depth parameter when setting a task |[optional]|