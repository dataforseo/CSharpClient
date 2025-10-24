# BusinessDataTrustpilotReviewsTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | domain of the business entity |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Title** | **string** | title of the ‘reviews’ element on Trustpilot<br>the name of the business entity for which the reviews are collected |[optional]|
**Location** | **string** | location of the business entity as specified on Trustpilot<br>address of the business entity for which the reviews are collected |[optional]|
**ReviewsCount** | **long?** | the total number of reviews |[optional]|
**Rating** | **RatingInfo** | rating of the corresponding business entity<br>popularity rate based on reviews and displayed in SERP |[optional]|
**ItemsCount** | **long?** | the number of items in the results array<br>you can get more results by using the depth parameter when setting a task |[optional]|
**Items** | **IEnumerable<TrustpilotReviewSearch>** | found reviews<br>you can get more results by using the depth parameter when setting a task |[optional]|