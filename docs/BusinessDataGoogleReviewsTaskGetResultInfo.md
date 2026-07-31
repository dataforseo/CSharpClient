# BusinessDataGoogleReviewsTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | <em>keyword received in a POST array</em><br><strong>keyword is returned with decoded %## (plus character '+' will be decoded to a space character)</strong> |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Title** | **string** | <em>title of the 'reviews' element in SERP</em><br>the name of the local establishment for which the reviews are collected |[optional]|
**SubTitle** | **string** | <em>subtitle of the 'reviews' element in SERP</em><br>additional information (e.g., address) on the 'reviews' element for which the reviews are collected |[optional]|
**Rating** | **RatingInfo** | <em>rating of the corresponding local establishment</em><br>popularity rate based on reviews and displayed in SERP |[optional]|
**FeatureId** | **string** | <em>the unique identifier of the 'reviews' element in SERP</em><br>learn more about the identifier in <a href='https://dataforseo.com/help-center/what-is-cid-place-id-feature-id' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**PlaceId** | **string** | <em>unique identifier of a business location assigned by Google</em><br>learn more about the identifier in <a href='https://dataforseo.com/help-center/what-is-cid-place-id-feature-id' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**Cid** | **string** | <i>google-defined client id</i><br>unique id of a local establishment<br>learn more about the identifier in <a href='https://dataforseo.com/help-center/what-is-cid-place-id-feature-id' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**ReviewsCount** | **long?** | <em>the total number of reviews</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of reviews items in the results array</em><br>you can get more results by using the <code>depth</code> parameter when setting a task |[optional]|
**Items** | **IEnumerable<GoogleReviewsSearch>** | <em>found reviews</em><br>you can get more results by using the <code>depth</code> parameter when setting a task |[optional]|