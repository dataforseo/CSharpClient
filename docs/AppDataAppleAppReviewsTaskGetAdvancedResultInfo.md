# AppDataAppleAppReviewsTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AppId** | **string** | <em>application id received in a POST array</em> |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Title** | **string** | <em>title of the app</em><br>title of the application for which the reviews are collected |[optional]|
**Rating** | **RatingInfo** | <em>rating of the app</em><br>rating of the application for which the reviews are collected |[optional]|
**ReviewsCount** | **long?** | <em>the total number of reviews</em><br>in this case, the value will be <code>null</code> as App Store does not indicate the total number of app reviews |[optional]|
**ItemsCount** | **long?** | <em>the number of reviews items in the results array</em><br>you can get more results by using the <code>depth</code> parameter when setting a task |[optional]|
**Items** | **IEnumerable<AppStoreReviewsSearch>** | <em>found reviews</em> |[optional]|