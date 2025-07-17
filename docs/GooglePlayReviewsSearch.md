# GooglePlayReviewsSearch


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank among all the listed reviews<br>absolute position among all reviews on the list |[optional]|
**Position** | **string** | the alignment of the review in SERP<br>can take the following values: left |[optional]|
**Version** | **string** | version of the app<br>version of the app for which the review is submitted |[optional]|
**Rating** | **RatingElement** | the rating score submitted by the reviewer |[optional]|
**Timestamp** | **string** | date and time when the review was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Id** | **string** | id of the review |[optional]|
**HelpfulCount** | **long?** | number of helpful votes<br>indicates how many users considered the review helpful and voted with the thumbs up icon |[optional]|
**Title** | **string** | title of the review<br>Google Play doesn’t provide an option to title reviews, so this parameter will always equal null |[optional]|
**ReviewText** | **string** | content of the review |[optional]|
**UserProfile** | **AppUserProfileInfo** | user profile of the reviewer |[optional]|
**Responses** | **object** | response from the developer |[optional]|