# TripadvisorReviewSearch


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank among all the listed reviews</em><br>absolute position among all reviews on the list |[optional]|
**Position** | **string** | <em>the alignment of the review in SERP</em><br>can take the following values: <code>right</code> |[optional]|
**Url** | **string** | <em>URL of the review</em> |[optional]|
**Rating** | **RatingInfo** | <em>the rating score submitted by the reviewer</em> |[optional]|
**DateOfVisit** | **string** | <em>date of the reviewer's visit to the local establishment</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Timestamp** | **string** | <em>date and time when the review was published</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**ReviewId** | **string** | <em>ID of the review</em> |[optional]|
**Title** | **string** | <em>title of the review</em> |[optional]|
**ReviewText** | **string** | <em>content of the review</em> |[optional]|
**Language** | **string** | <em>language of the review text</em> |[optional]|
**OriginalLanguage** | **string** | <em>language of the untranslated review text</em> |[optional]|
**ReviewImages** | **IEnumerable<ImageUrlInfo>** | <em>contains URLs of the images used in the review</em> |[optional]|
**UserProfile** | **BusinessDataUserProfileInfo** | <em>information from the reviewer's profile</em> |[optional]|
**Responses** | **IEnumerable<ReviewResponseItemInfo>** | <em>contains information about the owner's response</em> |[optional]|
**ReviewHighlights** | **object** | <em>review highlights</em><br>contains highlighted review criteria and assessments |[optional]|