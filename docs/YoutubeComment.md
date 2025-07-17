# YoutubeComment


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP for the target domain<br>absolute position among all the elements in SERP |[optional]|
**AuthorName** | **string** | name of the author of the comment |[optional]|
**AuthorThumbnail** | **string** | the URL of the page where the author’s channel logo is hosted |[optional]|
**AuthorUrl** | **string** | URL of the author’s channel |[optional]|
**Text** | **string** | text of the comment |[optional]|
**PublicationDate** | **string** | displayed publication date |[optional]|
**Timestamp** | **string** | date and time when the result was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2022-11-15 12:57:46 +00:00 |[optional]|
**LikesCount** | **long?** | number of likes on the comment |[optional]|
**ReplyCount** | **long?** | number of replies on the comment |[optional]|