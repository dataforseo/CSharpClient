# ChatGptText


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements |[optional]|
**Markdown** | **string** | content of the element in markdown format<br>content of the result formatted in the markdown markup language |[optional]|
**Sources** | **IEnumerable<ChatGptSource>** | array of sources |[optional]|