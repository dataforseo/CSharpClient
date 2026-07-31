# BusinessDataTripadvisorReviewsTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**UrlPath** | **string** | <em>URL path received in a POST array</em> |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Title** | **string** | <em>title of the 'reviews' element in SERP</em><br>the name of the local establishment for which the reviews are collected |[optional]|
**Location** | **string** | <em>location of the local establishment</em><br>address of the local establishment for which the reviews are collected |[optional]|
**ReviewsCount** | **long?** | <em>the total number of reviews</em> |[optional]|
**Rating** | **RatingInfo** | <em>rating of the corresponding local establishment</em><br>popularity rate based on reviews and displayed in SERP |[optional]|
**RatingDistribution** | **IDictionary<string, int?>** | <em>rating distribution by votes</em><br>the distribution of votes across the rating in the range from 1 to 5 |[optional]|
**ItemsCount** | **long?** | <em>the number of reviews items in the results array</em><br>you can get more results by using the <code>depth</code> parameter when setting a task |[optional]|
**Items** | **IEnumerable<TripadvisorReviewSearch>** | <em>found reviews</em><br>you can get more results by using the <code>depth</code> parameter when setting a task |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|