# TripadvisorReviewSearchBusinessDataSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Position** | **string** | the alignment of the review in SERP<br>can take the following values: right |[optional]|
**Url** | **string** | URL of the review |[optional]|
**Rating** | **RatingInfo** | the rating score submitted by the reviewer |[optional]|
**DateOfVisit** | **string** | date of the reviewer’s visit to the local establishment<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Timestamp** | **string** | date and time when the review was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Title** | **string** | title of the review |[optional]|
**ReviewText** | **string** | content of the review |[optional]|
**ReviewImages** | **IEnumerable<ImageUrlInfo>** | contains URLs of the images used in the review |[optional]|
**UserProfile** | **BusinessDataUserProfileInfo** | information from the reviewer’s profile |[optional]|
**Responses** | **IEnumerable<ReviewResponseItemInfo>** | contains information about the owner’s response |[optional]|
**ReviewHighlights** | **IEnumerable<ReviewHighlights>** | review highlights<br>contains highlighted review criteria and assessments |[optional]|