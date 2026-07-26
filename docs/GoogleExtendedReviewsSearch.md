# GoogleExtendedReviewsSearch


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank among all the listed reviews</em><br>absolute position among all reviews on the list |[optional]|
**Position** | **string** | <em>the alignment of the review in SERP</em><br>can take the following values: <code>right</code> |[optional]|
**Xpath** | **string** | <em>the <a href='https://en.wikipedia.org/wiki/XPath' rel='noopener noreferrer' target='_blank'>XPath</a> of the review</em> |[optional]|
**ReviewText** | **string** | <em>the content of the review</em> |[optional]|
**OriginalReviewText** | **string** | <em>original content of the review</em><br>the original content of the review, no auto-translate applied |[optional]|
**TimeAgo** | **string** | <em>the time of publication</em><br>indicates the time (in the 'time ago' format) when the review was listed |[optional]|
**Timestamp** | **string** | <em>date and time when a review was published</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Rating** | **RatingInfo** | <em>the rating score submitted by the reviewer</em> |[optional]|
**ReviewsCount** | **long?** | <em>total number of reviews submitted by the reviewer</em> |[optional]|
**PhotosCount** | **long?** | <em>total number of photos submitted by the reviewer</em> |[optional]|
**LocalGuide** | **bool?** | <em>indicates whether the reviewer has a 'local guide' status</em> |[optional]|
**ProfileName** | **string** | <em>profile name of the reviewer</em> |[optional]|
**ProfileUrl** | **string** | <em>URL of the reviewer's profile</em> |[optional]|
**ReviewUrl** | **string** | <em>the URL of the review</em> |[optional]|
**ProfileImageUrl** | **string** | <em>URL of the reviewer's profile image</em> |[optional]|
**OwnerAnswer** | **string** | <em>text of the owner's response</em><br>the owner's response to the review |[optional]|
**OriginalOwnerAnswer** | **string** | <em>original text of the owner's response</em><br>the original response to the review, no auto-translate applied |[optional]|
**OwnerTimeAgo** | **string** | <em>publication time</em><br>indicates the time (in the 'time ago' format) when the owner submitted the response to the review |[optional]|
**OwnerTimestamp** | **string** | <em>date and time of the owner's reply to the review</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**ReviewId** | **string** | <em>the unique identifier of a review on Google</em><br>example:<br><code>ChZDSUhNMG9nS0VJQ0FnSUMxbHFyMFlnEAE</code> |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images submitted by the reviewer</em> |[optional]|
**ReviewHighlights** | **IEnumerable<ReviewHighlights>** | <em>review highlights</em><br>contains highlighted review criteria and assessments |[optional]|
**Source** | **Source** | <em>source of the review</em><br>contains information about the source where the review was posted |[optional]|