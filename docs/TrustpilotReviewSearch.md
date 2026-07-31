# TrustpilotReviewSearch


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank among all the listed reviews</em><br>absolute position among all reviews on the list |[optional]|
**Position** | **string** | <em>the alignment of the review in SERP</em><br>can take the following values: <code>right</code> |[optional]|
**Url** | **string** | <em>the URL of the review</em> |[optional]|
**Rating** | **RatingInfo** | <em>the rating score submitted by the reviewer</em> |[optional]|
**Verified** | **bool?** | <em>indicates whether the review has the 'Verified' mark</em> |[optional]|
**Language** | **string** | <em>the language of the review</em> |[optional]|
**Timestamp** | **string** | <em>date and time when a review was published</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Title** | **string** | <em>the title of the review</em> |[optional]|
**ReviewText** | **string** | <em>the content of the review</em> |[optional]|
**ReviewImages** | **IEnumerable<string>** | <em>images submitted by the reviewer</em><br>displays URLs to the images provided by the author of the review;<br><strong>please note</strong> that Trustpilot doesn't allow adding images to reviews, so the <code>review_images</code> parameter will always equal <code>null</code> |[optional]|
**UserProfile** | **BusinessDataUserProfileInfo** | <em>user profile of the reviewer</em> |[optional]|
**Responses** | **IEnumerable<ReviewResponseItemInfo>** | <em>owner's response to the submitted review</em> |[optional]|