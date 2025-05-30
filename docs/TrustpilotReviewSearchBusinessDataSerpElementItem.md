# TrustpilotReviewSearchBusinessDataSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Position** | **string** | the alignment of the review in SERP<br>can take the following values: right |[optional]|
**Url** | **string** | the URL of the review |[optional]|
**Rating** | **BusinessDataRatingInfo** | the rating score submitted by the reviewer |[optional]|
**Verified** | **bool?** | indicates whether the review has the “Verified” mark |[optional]|
**Language** | **string** | the language of the review |[optional]|
**Timestamp** | **string** | date and time when a review was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Title** | **string** | the title of the review |[optional]|
**ReviewText** | **string** | the content of the review |[optional]|
**ReviewImages** | **IEnumerable<string>** | images submitted by the reviewer<br>displays URLs to the images provided by the author of the review;<br>please note that Trustpilot doesn’t allow adding images to reviews, so the review_images parameter will always equal null |[optional]|
**UserProfile** | **BusinessDataUserProfileInfo** | user profile of the reviewer |[optional]|
**Responses** | **IEnumerable<ReviewResponseItemInfo>** | owner’s response to the submitted review |[optional]|