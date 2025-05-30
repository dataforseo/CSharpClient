# AmazonAmazonReviewItemSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Verified** | **bool?** | indicates whether the review has the “Verified Purchase” mark |[optional]|
**Subtitle** | **string** | subtitle of the review |[optional]|
**HelpfulVotes** | **string** | helpful votes count<br>number of users who clicked on the ‘Helpful” button under the review text |[optional]|
**Images** | **IEnumerable<ImagesElement>** | images of the product submitted by the reviewer |[optional]|
**Videos** | **IEnumerable<VideoElement>** | videos of the product submitted by the reviewer |[optional]|
**UserProfile** | **UserProfileInfo** | user profile of the reviewer |[optional]|
**Title** | **string** | title of the review |[optional]|
**Url** | **string** | URL to the reviewer’s profile |[optional]|
**ReviewText** | **string** | content of the review |[optional]|
**PublicationDate** | **string** | date and time when the review was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Rating** | **BusinessDataRatingInfo** | the rating score submitted by the reviewer |[optional]|