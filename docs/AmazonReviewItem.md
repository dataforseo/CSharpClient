# AmazonReviewItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank among all the listed reviews</em><br>absolute position among all reviews on the list |[optional]|
**Position** | **string** | <em>the alignment of the review in SERP</em><br>can take the following values: <code>right</code> |[optional]|
**Xpath** | **string** | <em>the <a href='https://en.wikipedia.org/wiki/XPath'>XPath</a> of the element</em> |[optional]|
**Verified** | **bool?** | <em>indicates whether the review has the 'Verified Purchase' mark</em> |[optional]|
**Subtitle** | **string** | <em>subtitle of the review</em> |[optional]|
**HelpfulVotes** | **string** | <em>helpful votes count</em><br>number of users who clicked on the 'Helpful' button under the review text |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images of the product submitted by the reviewer</em> |[optional]|
**Videos** | **IEnumerable<VideoElement>** | <em>videos of the product submitted by the reviewer</em> |[optional]|
**UserProfile** | **UserProfileInfo** | <em>user profile of the reviewer</em> |[optional]|
**Title** | **string** | <em>title of the review</em> |[optional]|
**Url** | **string** |  |[optional]|
**ReviewText** | **string** | <em>content of the review</em> |[optional]|
**PublicationDate** | **string** | <em>date and time when the review was published</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Rating** | **RatingInfo** | <em>the rating score submitted by the reviewer</em> |[optional]|