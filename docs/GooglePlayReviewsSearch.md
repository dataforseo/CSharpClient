# GooglePlayReviewsSearch


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank among all the listed reviews</em><br>absolute position among all reviews on the list |[optional]|
**Position** | **string** | <em>the alignment of the review in SERP</em><br>can take the following values: <code>left</code> |[optional]|
**Version** | **string** | <em>version of the app</em><br>version of the app for which the review is submitted |[optional]|
**Rating** | **RatingInfo** | <em>the rating score submitted by the reviewer</em> |[optional]|
**Timestamp** | **string** | <em>date and time when the review was published</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Id** | **string** | <em>id of the review</em> |[optional]|
**HelpfulCount** | **long?** | <em>number of helpful votes</em><br>indicates how many users considered the review helpful and voted with the thumbs up icon |[optional]|
**Title** | **string** | <em>title of the review</em><br>Google Play doesn't provide an option to title reviews, so this parameter will always equal <code>null</code> |[optional]|
**ReviewText** | **string** | <em>content of the review</em> |[optional]|
**UserProfile** | **AppUserProfileInfo** | <em>user profile of the reviewer</em> |[optional]|
**Responses** | **IEnumerable<ResponseDataInfo>** | <em>response from the developer</em> |[optional]|