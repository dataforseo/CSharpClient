# GoogleBusinessPost


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank among all the listed updates</em><br>absolute position among all present elements |[optional]|
**Position** | **string** | <em>the alignment of the element in SERP</em><br>can take the following values: <code>right</code> |[optional]|
**Xpath** | **string** | <em>the <a href='https://en.wikipedia.org/wiki/XPath'>XPath</a> of the element</em> |[optional]|
**Author** | **string** | <em>author of the post</em> |[optional]|
**Snippet** | **string** | <em>additional content of a post</em> |[optional]|
**PostText** | **string** | <em>main content of a post</em> |[optional]|
**Url** | **string** | <em>url of a post</em> |[optional]|
**ImagesUrl** | **string** | <em>url of an image included in the post</em> |[optional]|
**PostDate** | **string** | <em>date when a post was published</em><br>in the following format:<br><code>'mm/dd/yyyy hh:mm:ss'</code> |[optional]|
**Timestamp** | **string** | <em>time when a post was published</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Links** | **IEnumerable<LinkElement>** | <em>links included in the post</em> |[optional]|