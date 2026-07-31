# BusinessDataTrustpilotReviewsTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | <em>domain of the business entity</em> |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Title** | **string** | <em>title of the 'reviews' element on Trustpilot</em><br>the name of the business entity for which the reviews are collected |[optional]|
**Location** | **string** | <em>location of the business entity as specified on Trustpilot</em><br>address of the business entity for which the reviews are collected |[optional]|
**ReviewsCount** | **string** | <em>the total number of reviews</em> |[optional]|
**Rating** | **object** | <em>rating of the corresponding business entity</em><br>popularity rate based on reviews and displayed in SERP |[optional]|
**ItemsCount** | **long?** | <em>the number of items in the results array</em><br>you can get more results by using the <code>depth</code> parameter when setting a task |[optional]|
**Items** | **IEnumerable<TrustpilotReviewSearch>** | <em>found reviews</em><br>you can get more results by using the <code>depth</code> parameter when setting a task |[optional]|