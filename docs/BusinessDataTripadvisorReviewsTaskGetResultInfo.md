# BusinessDataTripadvisorReviewsTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**UrlPath** | **string** | URL path received in a POST array |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Title** | **string** | title of the ‘reviews’ element in SERP<br>the name of the local establishment for which the reviews are collected |[optional]|
**Location** | **string** | location of the local establishment<br>address of the local establishment for which the reviews are collected |[optional]|
**ReviewsCount** | **long?** | the total number of reviews |[optional]|
**Rating** | **RatingInfo** | rating of the corresponding local establishment<br>popularity rate based on reviews and displayed in SERP |[optional]|
**RatingDistribution** | **IDictionary<string, int?>** | rating distribution by votes<br>the distribution of votes across the rating in the range from 1 to 5 |[optional]|
**ItemsCount** | **long?** | the number of reviews items in the results array<br>you can get more results by using the depth parameter when setting a task |[optional]|
**Items** | **IEnumerable<BaseBusinessDataSerpElementItem>** | found reviews<br>you can get more results by using the depth parameter when setting a task |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|