# BusinessDataGoogleExtendedReviewsTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword received in a POST array<br>keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character) |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **double?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Title** | **string** | title of the ‘reviews’ element in SERP<br>the name of the local establishment for which the reviews are collected |[optional]|
**SubTitle** | **string** | subtitle of the ‘reviews’ element in SERP<br>additional information (e.g., address) on the ‘reviews’ element for which the reviews are collected |[optional]|
**Rating** | **BusinessDataRatingInfo** | rating of the corresponding local establishment<br>popularity rate based on reviews and displayed in SERP |[optional]|
**FeatureId** | **string** | the unique identifier of the ‘reviews’ element in SERP<br>learn more about the identifier in this help center article |[optional]|
**PlaceId** | **string** | unique identifier of a business location assigned by Google<br>learn more about the identifier in this help center article |[optional]|
**Cid** | **string** | google-defined client id<br>unique id of a local establishment<br>learn more about the identifier in this help center article |[optional]|
**ReviewsCount** | **double?** | the total number of reviews |[optional]|
**ItemsCount** | **double?** | the number of reviews items in the results array<br>you can get more results by using the depth parameter when setting a task |[optional]|
**Items** | **IEnumerable<BusinessDataGoogleExtendedReviewsTaskGetItem>** | found reviews<br>you can get more results by using the depth parameter when setting a task |[optional]|