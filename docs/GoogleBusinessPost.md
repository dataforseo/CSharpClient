# GoogleBusinessPost


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank among all the listed updates<br>absolute position among all present elements |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values: right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Author** | **string** | author of the post |[optional]|
**Snippet** | **string** | additional content of a post |[optional]|
**PostText** | **string** | main content of a post |[optional]|
**Url** | **string** | url of a post |[optional]|
**ImagesUrl** | **string** | url of an image included in the post |[optional]|
**PostDate** | **string** | date when a post was published<br>in the following format:<br>'mm/dd/yyyy hh:mm:ss' |[optional]|
**Timestamp** | **string** | time when a post was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Links** | **IEnumerable<LinkElement>** | links included in the post |[optional]|