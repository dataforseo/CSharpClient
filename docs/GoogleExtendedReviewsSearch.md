# GoogleExtendedReviewsSearch


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank among all the listed reviews<br>absolute position among all reviews on the list |[optional]|
**Position** | **string** | the alignment of the review in SERP<br>can take the following values: right |[optional]|
**Xpath** | **string** | the XPath of the review |[optional]|
**ReviewText** | **string** | the content of the review |[optional]|
**OriginalReviewText** | **string** | original content of the review<br>the original content of the review, no auto-translate applied |[optional]|
**TimeAgo** | **string** | the time of publication<br>indicates the time (in the ‘time ago’ format) when the review was listed |[optional]|
**Timestamp** | **string** | date and time when a review was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Rating** | **RatingElement** | the rating score submitted by the reviewer |[optional]|
**ReviewsCount** | **long?** | total number of reviews submitted by the reviewer |[optional]|
**PhotosCount** | **long?** | total number of photos submitted by the reviewer |[optional]|
**LocalGuide** | **bool?** | indicates whether the reviewer has a ‘local guide’ status |[optional]|
**ProfileName** | **string** | profile name of the reviewer |[optional]|
**ProfileUrl** | **string** | URL of the reviewer’s profile |[optional]|
**ReviewUrl** | **string** | the URL of the review |[optional]|
**ProfileImageUrl** | **string** | URL of the reviewer’s profile image |[optional]|
**OwnerAnswer** | **string** | text of the owner’s response<br>the owner’s response to the review |[optional]|
**OriginalOwnerAnswer** | **string** | original text of the owner’s response<br>the original response to the review, no auto-translate applied |[optional]|
**OwnerTimeAgo** | **string** | publication time<br>indicates the time (in the ‘time ago’ format) when the owner submitted the response to the review |[optional]|
**OwnerTimestamp** | **string** | date and time of the owner’s reply to the review<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**ReviewId** | **string** | the unique identifier of a review on Google<br>example:<br>ChZDSUhNMG9nS0VJQ0FnSUMxbHFyMFlnEAE |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images submitted by the reviewer |[optional]|
**ReviewHighlights** | **IEnumerable<ReviewHighlights>** | review highlights<br>contains highlighted review criteria and assessments |[optional]|
**Source** | **Source** | source of the review<br>contains information about the source where the review was posted |[optional]|